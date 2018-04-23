Option Strict On
Public Class frmPesanan
    Dim cPesanan As New ctlPesanan
    Dim cDetilPesanan As New ctlDetilPesanan
    Dim cPelanggan As New ctlPelanggan
    Dim cBarang As New ctlBarang

    Private Sub mulai()
        gM.resCtrlTxt(Me)
        txtNosp.Text = cPesanan.autoNum
        txtTglsp.Text = Today.ToLongDateString
        lvw.Items.Clear()
        txtJmlpsn.Text = FormatNumber(1, 0)
        lblGrand.Text = FormatNumber(0, 0)
    End Sub

    Private Sub frmPesanan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown, txtAlamat.KeyDown, txtJmlpsn.KeyDown, txtKdbrg.KeyDown, txtKdplg.KeyDown, txtNmplg.KeyDown, txtNosp.KeyDown, txtTglsp.KeyDown
        gM.cekLockKeysOnKeyDown(e)
    End Sub

    Private Sub frmPesanan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load, Me.Shown, btnClear.Click
        mulai()
    End Sub

    Private Sub txtKdplg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKdplg.TextChanged
        With cPelanggan
            .kdPlg = txtKdplg.Text
            .getByKey("kdplg", txtKdplg.Text)
            txtNmplg.Text = .nmPlg
            txtAlamat.Text = .alamat
            .getByKey("kdplg", txtKdplg.Text)
        End With
    End Sub

    Private Sub btnBrowsePlg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowsePlg.Click
        Dim frm As New frmBrowse
        frm.table = gM.dbTable.Pelanggan
        frm.ShowDialog()
        If frm.keyValue <> String.Empty Then
            txtKdplg.Text = frm.keyValue
        End If
    End Sub

    Private Sub btnBrowseBarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseBarang.Click
        Dim frm As New frmBrowse
        frm.table = gM.dbTable.Barang
        frm.ShowDialog()
        If frm.keyValue <> String.Empty Then
            txtKdbrg.Text = frm.keyValue
        End If
        txtKdbrg.Focus()
    End Sub

    Private Sub btnAddList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddList.Click
        cBarang.kdBrg = txtKdbrg.Text
        cBarang.getByKey("kdbrg", txtKdbrg.Text)
        Dim tmpStok As Integer = cBarang.stok
        If cBarang.recordExist = False Then
            MessageBox.Show("Barang tidak terdaftar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Val(txtJmlpsn.Text) = 0 Then
            MessageBox.Show("Input Jumlah Barang", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf cBarang.recordExist And tmpStok < Val(txtJmlpsn.Text) Then
            MessageBox.Show("Stok tidak mencukupi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            cBarang.kdBrg = txtKdbrg.Text
            cBarang.getByKey("kdbrg", txtKdbrg.Text)
            With lvw.Items.Add(txtKdbrg.Text)
                .SubItems.Add(cBarang.nmBrg)
                .SubItems.Add(FormatNumber(cBarang.harga, 0))
                .SubItems.Add(txtJmlpsn.Text)
                .SubItems.Add(FormatNumber(CInt(txtJmlpsn.Text) * CInt(cBarang.harga), 0))
            End With
            Dim grand As Double = CDbl(lblGrand.Text) + (CInt(txtJmlpsn.Text) * cBarang.harga)
            lblGrand.Text = FormatNumber(grand, 0)

            txtKdbrg.Clear()
            txtJmlpsn.Text = FormatNumber(1, 0)
            txtKdbrg.Focus()
        End If
    End Sub

    Private Sub HapusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusToolStripMenuItem.Click
        If lvw.SelectedItems.Count > 0 Then
            Dim grand As Double = CDbl(lblGrand.Text) - CDbl(lvw.SelectedItems(0).SubItems(4).Text)
            lblGrand.Text = FormatNumber(grand, 0)
            lvw.SelectedItems(0).Remove()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        cPelanggan.kdPlg = txtKdplg.Text
        If cPelanggan.recordExist = False Then
            MessageBox.Show("Pelanggan tidak terdaftar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Val(lblGrand.Text) = 0 Then
            MessageBox.Show("Daftar Pesanan tidak ada", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            With cPesanan
                .noSp = txtNosp.Text
                .tglSp = CDate(txtTglsp.Text)
                .kdPlg = txtKdplg.Text
            End With
            If cPesanan.insert Then
                If lvw.Items.Count > 0 Then
                    Dim i As Integer
                    For i = 0 To lvw.Items.Count - 1
                        'insert detail
                        With cDetilPesanan
                            .noSp = txtNosp.Text
                            .kdBrg = lvw.Items(i).SubItems(0).Text
                            .hrgPsn = CInt(lvw.Items(i).SubItems(2).Text)
                            If .recordExist Then
                                .getByCK()
                                Dim tmpJmlPsn As Integer = .jmlPsn
                                .jmlPsn = tmpJmlPsn + CInt(lvw.Items(i).SubItems(3).Text)
                                .updateJmlPsn()
                            Else
                                .jmlPsn = CInt(lvw.Items(i).SubItems(3).Text)
                                .insert()
                            End If
                        End With

                        'update stok
                        With cBarang
                            .kdBrg = lvw.Items(i).SubItems(0).Text
                            .jmlJual = CInt(lvw.Items(i).SubItems(3).Text)
                            .updateStok()
                        End With
                    Next
                End If
                MessageBox.Show("Data berhasil disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mulai()
            End If
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub txtKdplg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKdplg.KeyPress
        gM.noInject(e)
    End Sub

    Private Sub txtJmlpsn_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJmlpsn.GotFocus
        txtJmlpsn.Select(txtJmlpsn.TextLength, txtJmlpsn.TextLength)
    End Sub

    Private Sub txtJmlpsn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJmlpsn.KeyPress
        gM.numOnly(e)
        If Asc(e.KeyChar) = 13 Then
            btnAddList.PerformClick()
        End If
    End Sub

    Private Sub txtKdbrg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKdbrg.GotFocus
        txtKdbrg.Select(txtKdbrg.TextLength, txtKdbrg.TextLength)
    End Sub

    Private Sub txtKdbrg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKdbrg.KeyPress
        gM.noInject(e)
        If Asc(e.KeyChar) = 13 Then
            btnAddList.PerformClick()
        End If
    End Sub

    Private Sub btnUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUndo.Click
        With lvw
            If .Items.Count > 0 Then
                Dim i As Integer = .Items.Count - 1
                Dim grand As Double = CDbl(lblGrand.Text) - CDbl(.Items(i).SubItems(4).Text)
                lblGrand.Text = FormatNumber(grand, 0)
                txtKdbrg.Text = .Items(i).Text
                txtJmlpsn.Text = .Items(i).SubItems(3).Text
                .Items(i).Remove()
                txtJmlpsn.Focus()
            End If
        End With
    End Sub

    Private Sub lblGrand_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblGrand.TextChanged
        If Val(lblGrand.Text) = 0 Then
            btnUndo.Enabled = False
            lblGrand.Text = FormatNumber(0, 0)
        Else
            btnUndo.Enabled = True
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtKdbrg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKdbrg.TextChanged

    End Sub

    Private Sub lvw_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvw.SelectedIndexChanged

    End Sub
End Class