Option Strict On
Public Class frmKwitansi
    Dim cKwitansi As New ctlKwitansi
    Dim cFaktur As New ctlFaktur
    Dim cPesanan As New ctlPesanan
    Dim cDetilPesanan As New ctlDetilPesanan
    Dim cPelanggan As New ctlPelanggan
    Dim cJurnal As New ctlJurnal
    Dim cRekening As New ctlRekening

    Private Sub mulai()
        gM.resCtrlTxt(Me)
        txtNokwt.Text = cKwitansi.autoNum
        txtTglkwt.Text = Today.ToLongDateString
        lvw.Items.Clear()
        lblGrand.Text = FormatNumber(0, 0)
    End Sub

    Private Sub frmKwitansi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown, txtAlamat.KeyDown, txtKdplg.KeyDown, txtNmplg.KeyDown, txtNofaktur.KeyDown, txtNokwt.KeyDown, txtNosp.KeyDown, txtTglfaktur.KeyDown, txtTglkwt.KeyDown, txtTglsp.KeyDown
        gM.cekLockKeysOnKeyDown(e)
    End Sub

    Private Sub frmKwitansi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Shown
        mulai()
    End Sub

    Private Sub btnBrowseFaktur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseFaktur.Click
        Dim frm As New frmBrowse
        frm.table = gM.dbTable.Faktur
        frm.ShowDialog()
        If frm.keyValue <> String.Empty Then
            txtNofaktur.Text = frm.keyValue
        End If
    End Sub

    Private Sub txtNofaktur_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNofaktur.KeyPress
        gM.noInject(e)
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

    Private Sub txtKdplg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKdplg.TextChanged
        With cPelanggan
            .getByKey("kdplg", txtKdplg.Text)
            txtNmplg.Text = .nmPlg
            txtAlamat.Text = .alamat
        End With
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
                    Dim total As Double = CDbl(lvw.Items(i).SubItems(2).Text) * CInt(lvw.Items(i).SubItems(3).Text)
                    .SubItems.Add(FormatNumber(total, 0))
                    Dim grand As Double = CDbl(lblGrand.Text) + total
                    lblGrand.Text = FormatNumber(grand, 0)
                End With
            Next
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        mulai()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        cFaktur.noFaktur = txtNofaktur.Text
        If cFaktur.inKwitansi Then
            MessageBox.Show("Faktur sudah terdaftar dalam data Kwitansi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNofaktur.Focus()
            txtNofaktur.Select(txtNofaktur.TextLength, txtNofaktur.TextLength)
        ElseIf lvw.Items.Count = 0 Then
            MessageBox.Show("Input No. Faktur dengan benar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNofaktur.Focus()
            txtNofaktur.Select(txtNofaktur.TextLength, txtNofaktur.TextLength)
        Else
            With cKwitansi
                .noKwt = txtNokwt.Text
                .tglKwt = CDate(txtTglkwt.Text)
                .noFaktur = txtNofaktur.Text
            End With
            If cKwitansi.insert Then
                With cJurnal
                    'insert kas
                    cRekening.getByKey("nmrek", "Kas")
                    Dim kdRekKas As String = cRekening.kdRek
                    .noBukti = txtNokwt.Text
                    .kdRek = kdRekKas
                    .tglBukti = CDate(txtTglkwt.Text)
                    .jumlah = CDbl(lblGrand.Text)
                    .posisi = "Debet"
                    .insert()

                    'insert penjualan
                    cRekening.getByKey("nmrek", "Penjualan")
                    Dim kdRekPenjualan As String = cRekening.kdRek
                    .noBukti = txtNokwt.Text
                    .kdRek = kdRekPenjualan
                    .tglBukti = CDate(txtTglkwt.Text)
                    .jumlah = CDbl(lblGrand.Text)
                    .posisi = "Kredit"
                    .insert()
                End With

                If MessageBox.Show("Data berhasil disimpan, apakah akan dicetak?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim frm As New frmGeneratingRpt
                    frm.rptName = "rptKwitansi"
                    frm.keyValue = txtNokwt.Text
                    frm.ShowDialog()
                End If

                mulai()
            End If
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim frm As New frmCetak3
        frm.rptName = "rptKwitansi"
        frm.pk = "No. Kwitansi"
        frm.ShowDialog()
    End Sub

    Private Sub lblGrand_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblGrand.TextChanged
        If Val(lblGrand.Text) = 0 Then
            lblGrand.Text = FormatNumber(0, 0)
        End If
    End Sub
End Class