Option Strict On
Public Class frmSJ
    Dim cSj As New ctlSJ
    Dim cDetilSj As New ctlDetilSJ
    Dim cKendaraan As New ctlKendaraan
    Dim cFaktur As New ctlFaktur
    Dim cPesanan As New ctlPesanan
    Dim cDetilPesanan As New ctlDetilPesanan
    Dim cPelanggan As New ctlPelanggan
    Dim cBarang As New ctlBarang
    Friend WithEvents txtTtlkirim As New TextBox

    Private Sub mulai()
        gM.resCtrlTxt(Me)
        txtNosj.Text = cSj.autoNum
        txtTglsj.Text = Today.ToLongDateString
        lbxKdbrg.Items.Clear()
        lvw.Items.Clear()
        txtJmlpsn.Text = FormatNumber(0, 0)
        txtTtlkirim.Text = FormatNumber(0, 0)
    End Sub

    Private Sub bersih()
        txtKdbrg.Clear()
        txtJmlkirim.Text = FormatNumber(0, 0)
        txtKet.Clear()
        lbxKdbrg.SelectedItems.Clear()
    End Sub

    Private Sub fillCboNopol()
        With cboNopol
            .Items.Clear()
            .Items.Add("Silakan Pilih")
            Dim arrLst As ArrayList = cKendaraan.arrAll
            If arrLst.Count > 0 Then
                Dim i As Integer
                For i = 0 To arrLst.Count - 1
                    Dim objData As Kendaraan = CType(arrLst(i), Kendaraan)
                    .Items.Add(objData.noPol)
                Next
            End If
        End With
    End Sub

    Private Sub txtJmlkirim_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJmlkirim.GotFocus
        txtJmlkirim.Select(txtJmlkirim.TextLength, txtJmlkirim.TextLength)
    End Sub

    Private Sub frmSJ_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown, txtAlamat.KeyDown, txtJmlkirim.KeyDown, txtJmlpsn.KeyDown, txtKdbrg.KeyDown, txtKdplg.KeyDown, txtKet.KeyDown, txtNmbrg.KeyDown, txtNmplg.KeyDown, txtNofaktur.KeyDown, txtNosj.KeyDown, txtNosp.KeyDown, txtTglfaktur.KeyDown, txtTglsj.KeyDown, txtTglsp.KeyDown
        gM.cekLockKeysOnKeyDown(e)
    End Sub

    Private Sub frmSJ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Shown, btnClear.Click
        fillCboNopol()
        mulai()
    End Sub

    Private Sub txtNofaktur_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNofaktur.TextChanged
        With cFaktur
            .getByKey("nofaktur", txtNofaktur.Text)
            If .tglFaktur <> Nothing Then
                txtTglfaktur.Text = .tglFaktur.ToLongDateString
            Else
                txtTglfaktur.Text = String.Empty
            End If
            txtNosp.Text = .noSp
        End With
    End Sub

    Private Sub txtNosp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNosp.TextChanged
        bersih()
        lvw.Items.Clear()
        lbxKdbrg.Items.Clear()

        With cPesanan
            .noSp = txtNosp.Text
            .getByPK()
            If .tglSp <> Nothing Then
                txtTglsp.Text = .tglSp.ToLongDateString
            Else
                txtTglsp.Text = String.Empty
            End If
            txtKdplg.Text = .kdPlg
        End With

        lbxKdbrg.Items.Clear()
        Dim arrLst As ArrayList = cDetilPesanan.arrByKey("nosp", txtNosp.Text)
        If arrLst.Count > 0 Then
            Dim i As Integer
            For i = 0 To arrLst.Count - 1
                Dim objData As DetilPesanan = CType(arrLst(i), DetilPesanan)
                lbxKdbrg.Items.Add(objData.kdBrg)
            Next
        End If
    End Sub

    Private Sub txtKdplg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKdplg.TextChanged
        With cPelanggan
            .getByKey("kdplg", txtKdplg.Text)
            txtNmplg.Text = .nmPlg
            txtAlamat.Text = .alamat
        End With
    End Sub

    Private Sub txtKdbrg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKdbrg.TextChanged
        With cDetilPesanan
            .noSp = txtNosp.Text
            .kdBrg = txtKdbrg.Text
            .getByCK()
            txtJmlpsn.Text = .jmlPsn.ToString
        End With

        cBarang.getByKey("kdbrg", txtKdbrg.Text)
        txtNmbrg.Text = cBarang.nmBrg
    End Sub

    Private Sub lbxKdbrg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbxKdbrg.SelectedIndexChanged
        If lbxKdbrg.SelectedItems.Count > 0 Then
            txtKdbrg.Text = lbxKdbrg.SelectedItem.ToString
        End If
    End Sub

    Private Sub btnAddList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddList.Click
        If txtKdbrg.Text = String.Empty Then
            MessageBox.Show("Pilih Barang yang akan dikirim", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Val(txtJmlkirim.Text) = 0 Then
            MessageBox.Show("Input Jumlah Barang yang akan dikirim", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Val(txtJmlkirim.Text) > Val(txtJmlpsn.Text) Then
            MessageBox.Show("Jumlah Barang yang akan dikirim tidak dapat melebihi Jumlah Barang yang dipesan, silakan ganti nilai Jumlah Barang yang anda inputkan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim i As Integer
            If lvw.Items.Count > 0 Then
                For i = 0 To lvw.Items.Count - 1
                    If lvw.Items(i).Text = txtKdbrg.Text Then
                        MessageBox.Show("Barang sudah ada dalam daftar pengiriman", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Next
            End If
            With lvw.Items.Add(txtKdbrg.Text)
                .SubItems.Add(txtNmbrg.Text)
                .SubItems.Add(txtJmlpsn.Text)
                .SubItems.Add(txtJmlkirim.Text)
                .SubItems.Add(txtKet.Text)
            End With
            txtTtlkirim.Text = FormatNumber(CInt(txtTtlkirim.Text) + CInt(txtJmlkirim.Text), 0)
            If lbxKdbrg.Items.Count > 0 Then
                If txtKdbrg.Text Like lbxKdbrg.SelectedItem.ToString Then
                    lbxKdbrg.Items.Remove(lbxKdbrg.SelectedItem)
                End If
            End If
            bersih()
        End If
    End Sub

    Private Sub HapusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusToolStripMenuItem.Click
        If lvw.SelectedItems.Count > 0 Then
            lbxKdbrg.Items.Add(lvw.SelectedItems(0).Text)
            txtTtlkirim.Text = FormatNumber(CInt(txtTtlkirim.Text) - CInt(lvw.SelectedItems(0).SubItems(3).Text), 0)
            lvw.SelectedItems(0).Remove()
        End If
    End Sub

    Private Sub btnBrowseFaktur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseFaktur.Click
        Dim frm As New frmBrowse
        frm.table = gM.dbTable.Faktur
        frm.ShowDialog()
        If frm.keyValue <> String.Empty Then
            txtNofaktur.Text = frm.keyValue
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        cFaktur.noFaktur = txtNofaktur.Text
        cKendaraan.noPol = cboNopol.Text
        If cFaktur.inSJ Then
            MessageBox.Show("Faktur sudah terdaftar dalam data Pengiriman", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf lvw.Items.Count = 0 Then
            MessageBox.Show("Daftar Barang yang akan dikirim tidak ada", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf cKendaraan.recordExist = False Then
            MessageBox.Show("Input No. Polisi kendaraan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            With cSj
                .noSj = txtNosj.Text
                .tglSj = CDate(txtTglsj.Text)
                .noPol = cboNopol.Text
                .noFaktur = txtNofaktur.Text
            End With
            If cSj.insert Then
                If lvw.Items.Count > 0 Then
                    Dim i As Integer
                    For i = 0 To lvw.Items.Count - 1
                        'insert detail
                        With cDetilSj
                            .noSj = txtNosj.Text
                            .kdBrg = lvw.Items(i).SubItems(0).Text
                            .jmlKirim = CInt(lvw.Items(i).SubItems(3).Text)
                            .keterangan = lvw.Items(i).SubItems(4).Text
                            .insert()
                        End With
                    Next
                End If

                If MessageBox.Show("Data berhasil disimpan, apakah akan dicetak?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim frm As New frmGeneratingRpt
                    frm.rptName = "rptSJ"
                    frm.keyValue = txtNosj.Text
                    frm.ShowDialog()
                End If

                mulai()
            End If
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub txtNofaktur_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNofaktur.KeyPress
        gM.noInject(e)
    End Sub

    Private Sub txtJmlkirim_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJmlkirim.KeyPress
        gM.numOnly(e)
        If Asc(e.KeyChar) = 13 Then
            txtKet.Focus()
        End If
    End Sub

    Private Sub txtJmlpsn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJmlpsn.TextChanged
        If Val(txtJmlpsn.Text) = 0 Then
            txtJmlpsn.Text = FormatNumber(0, 0)
        End If
        txtJmlkirim.Text = txtJmlpsn.Text
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        bersih()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim frm As New frmCetak3
        frm.rptName = "rptSJ"
        frm.pk = "No. Surat Jalan"
        frm.ShowDialog()
    End Sub

    Private Sub txtKet_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKet.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnAddList.PerformClick()
        End If
    End Sub

    Private Sub btnUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUndo.Click
        With lvw
            If .Items.Count > 0 Then
                Dim i As Integer = .Items.Count - 1
                lbxKdbrg.Items.Add(.Items(i).Text)
                lbxKdbrg.SelectedItem = .Items(i).Text
                txtKet.Text = .Items(i).SubItems(4).Text
                txtTtlkirim.Text = FormatNumber(CInt(txtTtlkirim.Text) - CInt(.Items(i).SubItems(3).Text), 0)
                .Items(i).Remove()
                txtJmlkirim.Focus()
            End If
        End With
    End Sub

    Private Sub txtTtlKirim_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTtlkirim.TextChanged
        If Val(txtTtlkirim.Text) = 0 Then
            btnUndo.Enabled = False
        Else
            btnUndo.Enabled = True
        End If
    End Sub

    Private Sub lvw_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvw.SelectedIndexChanged

    End Sub
End Class