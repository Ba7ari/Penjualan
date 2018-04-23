Option Strict On
Public Class frmFaktur
    Dim cFaktur As New ctlFaktur
    Dim cPesanan As New ctlPesanan
    Dim cDetilPesanan As New ctlDetilPesanan
    Dim cPelanggan As New ctlPelanggan

    Private Sub mulai()
        gM.resCtrlTxt(Me)
        txtNofaktur.Text = cFaktur.autoNum
        txtTglfaktur.Text = Today.ToLongDateString
        lvw.Items.Clear()
        lblGrand.Text = FormatNumber(0, 0)
    End Sub

    Private Sub frmFaktur_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown, txtAlamat.KeyDown, txtKdplg.KeyDown, txtNmplg.KeyDown, txtNofaktur.KeyDown, txtNosp.KeyDown, txtTglfaktur.KeyDown, txtTglsp.KeyDown
        gM.cekLockKeysOnKeyDown(e)
    End Sub

    Private Sub frmFaktur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Shown, btnClear.Click
        mulai()
    End Sub

    Private Sub txtNosp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNosp.TextChanged
        lblGrand.ResetText()
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

        lvw.Items.Clear()
        cDetilPesanan.noSp = txtNosp.Text
        Dim arrLst As ArrayList = cDetilPesanan.arrByFK
        If arrLst.Count > 0 Then
            Dim i As Integer
            For i = 0 To arrLst.Count - 1
                Dim objData As DetilPesanan = CType(arrLst(i), DetilPesanan)
                With lvw.Items.Add(objData.kdBrg)
                    .SubItems.Add(objData.nmBrg)
                    .SubItems.Add(FormatNumber(objData.hrgPsn, 0))
                    .SubItems.Add(objData.jmlPsn.ToString)
                    Dim total As Double = CInt(lvw.Items(i).SubItems(2).Text) * CInt(lvw.Items(i).SubItems(3).Text)
                    .SubItems.Add(FormatNumber(total, 0))
                    Dim grand As Double = CDbl(lblGrand.Text) + total
                    lblGrand.Text = FormatNumber(grand, 0)
                End With
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

    Private Sub btnBrowsePesan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowsePesan.Click
        Dim frm As New frmBrowse
        frm.table = gM.dbTable.Pesanan
        frm.ShowDialog()
        If frm.keyValue <> String.Empty Then
            txtNosp.Text = frm.keyValue
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        cPesanan.noSp = txtNosp.Text
        If cPesanan.inFaktur Then
            MessageBox.Show("Pesanan sudah terdaftar dalam data Faktur", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Val(lblGrand.Text) = 0 Then
            MessageBox.Show("Pesanan tidak ada", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            With cFaktur
                .noFaktur = txtNofaktur.Text
                .tglFaktur = CDate(txtTglfaktur.Text)
                .noSp = txtNosp.Text
                If .insert Then
                    If MessageBox.Show("Data berhasil disimpan, apakah akan dicetak?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Dim frm As New frmGeneratingRpt
                        frm.rptName = "rptFaktur"
                        frm.keyValue = txtNofaktur.Text
                        frm.ShowDialog()
                    End If

                    mulai()
                End If
            End With
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim frm As New frmCetak3
        frm.rptName = "rptFaktur"
        frm.pk = "No. Faktur"
        frm.ShowDialog()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub txtNosp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNosp.KeyPress
        gM.noInject(e)
    End Sub

    Private Sub lblGrand_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblGrand.TextChanged
        If Val(lblGrand.Text) = 0 Then
            lblGrand.Text = FormatNumber(0, 0)
        End If
    End Sub

    Private Sub lvw_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvw.SelectedIndexChanged

    End Sub
End Class