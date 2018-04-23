Option Strict On
Public Class frmNotaKontan
    Dim cNk As New ctlNotaKontan
    Dim cDetilNk As New ctlDetilNotaKontan
    Dim cBarang As New ctlBarang
    Dim cJurnal As New ctlJurnal
    Dim cRekening As New ctlRekening

    Private Sub mulai()
        gM.resCtrlTxt(Me)
        txtNonk.Text = cNk.autoNum
        txtTglnk.Text = Today.ToLongDateString
        lvw.Items.Clear()
        txtJmlbeli.Text = CStr(1)
        lblGrand.Text = CStr(0)
        txtBayar.Text = CStr(0)
        txtKembali.Text = CStr(0)
    End Sub

    Private Sub hitungKembali()
        If Val(lblGrand.Text) > 0 Or Val(txtBayar.Text) > 0 Then
            Dim tmpKembali As Double = CDbl(txtBayar.Text) - CDbl(lblGrand.Text)
            txtKembali.Text = FormatNumber(tmpKembali, 0)
        Else
            txtKembali.Text = CStr(0)
        End If
    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Shell("calc.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub txtJmlbeli_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJmlbeli.GotFocus
        txtJmlbeli.Select(txtJmlbeli.TextLength, txtJmlbeli.TextLength)
    End Sub

    Private Sub txtKdbrg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKdbrg.GotFocus
        txtKdbrg.Select(txtKdbrg.TextLength, txtKdbrg.TextLength)
    End Sub

    Private Sub frmNotaKontan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown, txtBayar.KeyDown, txtJmlbeli.KeyDown, txtKdbrg.KeyDown, txtKembali.KeyDown, txtNonk.KeyDown, txtTglnk.KeyDown
        gM.cekLockKeysOnKeyDown(e)
    End Sub

    Private Sub frmNotaKontan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, btnClear.Click
        mulai()
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
        ElseIf Val(txtJmlbeli.Text) = 0 Then
            MessageBox.Show("Input Jumlah Barang", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf cBarang.recordExist And tmpStok < Val(txtJmlbeli.Text) Then
            MessageBox.Show("Stok tidak mencukupi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            cBarang.kdBrg = txtKdbrg.Text
            cBarang.getByKey("kdbrg", txtKdbrg.Text)
            With lvw.Items.Add(txtKdbrg.Text)
                .SubItems.Add(cBarang.nmBrg)
                .SubItems.Add(FormatNumber(cBarang.harga, 0))
                .SubItems.Add(txtJmlbeli.Text)
                .SubItems.Add(FormatNumber(CInt(txtJmlbeli.Text) * CInt(cBarang.harga), 0))
            End With
            Dim grand As Double = CDbl(lblGrand.Text) + (CInt(txtJmlbeli.Text) * cBarang.harga)
            lblGrand.Text = FormatNumber(grand, 0)

            txtKdbrg.Clear()
            txtJmlbeli.Text = FormatNumber(1, 0)
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
        If Val(lblGrand.Text) = 0 Then
            MessageBox.Show("Daftar Pembelian tidak ada", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf CDbl(txtBayar.Text) < CDbl(lblGrand.Text) Then
            MessageBox.Show("Pembayaran kurang", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            With cNk
                .noNk = txtNonk.Text
                .tglNk = CDate(txtTglnk.Text)
            End With
            If cNk.insert Then
                If lvw.Items.Count > 0 Then
                    Dim i As Integer
                    For i = 0 To lvw.Items.Count - 1
                        'insert detail
                        With cDetilNk
                            .noNk = txtNonk.Text
                            .kdBrg = lvw.Items(i).SubItems(0).Text
                            .hrgBeli = CInt(lvw.Items(i).SubItems(2).Text)
                            If .recordExist Then
                                .getByCK()
                                Dim tmpJmlBeli As Integer = .jmlBeli
                                .jmlBeli = tmpJmlBeli + CInt(lvw.Items(i).SubItems(3).Text)
                                .updateJmlBeli()
                            Else
                                .jmlBeli = CInt(lvw.Items(i).SubItems(3).Text)
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

                With cJurnal
                    'insert kas
                    cRekening.getByKey("nmrek", "Kas")
                    Dim kdRekKas As String = cRekening.kdRek
                    .noBukti = txtNonk.Text
                    .kdRek = kdRekKas
                    .tglBukti = CDate(txtTglnk.Text)
                    .jumlah = CDbl(lblGrand.Text)
                    .posisi = "Debet"
                    .insert()

                    'insert penjualan
                    cRekening.getByKey("nmrek", "Penjualan")
                    Dim kdRekPenjualan As String = cRekening.kdRek
                    .noBukti = txtNonk.Text
                    .kdRek = kdRekPenjualan
                    .tglBukti = CDate(txtTglnk.Text)
                    .jumlah = CDbl(lblGrand.Text)
                    .posisi = "Kredit"
                    .insert()
                End With

                Dim frm As New frmGeneratingRpt
                frm.rptName = "rptNotaKontan"
                frm.dibayar = CDbl(txtBayar.Text)
                frm.kembali = CDbl(txtKembali.Text)
                frm.keyValue = txtNonk.Text
                frm.ShowDialog()

                mulai()
            End If
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub txtJmlbeli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJmlbeli.KeyPress
        gM.numOnly(e)
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
                txtJmlbeli.Text = .Items(i).SubItems(3).Text
                .Items(i).Remove()
                txtJmlbeli.Focus()
            End If
        End With
    End Sub

    Private Sub lblGrand_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblGrand.TextChanged
        If Val(lblGrand.Text) = 0 Then
            btnUndo.Enabled = False
            lblGrand.Text = CStr(0)
        Else
            btnUndo.Enabled = True
        End If

        hitungKembali()
    End Sub

    Private Sub txtKdbrg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKdbrg.KeyPress
        gM.noInject(e)
        If Asc(e.KeyChar) = 13 Then
            btnAddList.PerformClick()
        End If
    End Sub

    Private Sub txtBayar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBayar.KeyPress
        gM.numOnly(e)
        If Asc(e.KeyChar) = 13 Then
            btnSave.Focus()
        End If
    End Sub

    Private Sub txtBayar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBayar.TextChanged
        If Val(txtBayar.Text) > 0 Then
            txtBayar.Text = FormatNumber(txtBayar.Text, 0)
        Else
            txtBayar.Text = CStr(0)
        End If
        txtBayar.Select(txtBayar.TextLength, txtBayar.TextLength)

        hitungKembali()
    End Sub

    Private Sub txtKembali_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKembali.TextChanged
        If txtKembali.Text.StartsWith("-") Then
            txtKembali.ForeColor = Color.Red
        Else
            txtKembali.ForeColor = Control.DefaultForeColor
        End If
    End Sub

    Private Sub lvw_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvw.SelectedIndexChanged

    End Sub

    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub txtKdbrg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKdbrg.TextChanged

    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub
End Class