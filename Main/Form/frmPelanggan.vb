Option Strict On
Public Class frmPelanggan
    Dim cPelanggan As New ctlPelanggan

    Private Sub mulai()
        gM.resCtrlTxt(Me)
        txtKdplg.Text = "(Auto Generate)"
        btnSave.Text = "Simpan"
        btnDelete.Enabled = False
    End Sub

    Private Sub fill()
        With cPelanggan
            If btnSave.Text = "Simpan" Then
                .kdPlg = .autoNum
            Else
                .kdPlg = txtKdplg.Text
            End If
            .nmPlg = txtNmplg.Text
            .alamat = txtAlamat.Text
            .telp = txtTelp.Text
        End With
    End Sub

    Private Function txtEmpty() As Boolean
        If txtNmplg.Text.Trim = String.Empty Or txtAlamat.Text.Trim = String.Empty Or _
           txtTelp.Text.Trim = String.Empty Then
            Return True
        End If
        Return False
    End Function

    Private Sub frmPelanggan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown, txtKdplg.KeyDown, txtNmplg.KeyDown, txtAlamat.KeyDown, txtTelp.KeyDown
        gM.cekLockKeysOnKeyDown(e)
    End Sub

    Private Sub frmPelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Shown, btnClear.Click
        mulai()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtEmpty() Then
            MessageBox.Show("Data yang diinput harus lengkap", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Not txtTelp.Text.StartsWith("0") Then
            MessageBox.Show("Kode Wilayah (untuk lokal) atau Kode Operator (untuk mobile) No. Telepon tidak dikenal", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            fill()
            With cPelanggan
                If btnSave.Text = "Simpan" Then
                    If .insert() Then
                        MessageBox.Show("Data berhasil disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    If .update() Then
                        MessageBox.Show("Data berhasil diupdate", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End With
            mulai()
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        fill()
        If MessageBox.Show("Benar data akan dihapus?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If cPelanggan.delete() Then
                mulai()
            End If
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Dim frm As New frmBrowse
        frm.table = gM.dbTable.Pelanggan
        frm.ShowDialog()
        If frm.keyValue <> String.Empty Then
            txtKdplg.Text = frm.keyValue
        End If
    End Sub

    Private Sub txtKdplg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKdplg.TextChanged
        cPelanggan.getByKey("kdplg", txtKdplg.Text)
        txtNmplg.Text = cPelanggan.nmPlg
        txtAlamat.Text = cPelanggan.alamat
        txtTelp.Text = cPelanggan.telp
        btnSave.Text = "Update"
        btnDelete.Enabled = True
    End Sub

    Private Sub txtTelp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelp.KeyPress
        gM.numOnly(e)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim frm As New frmCetak1
        frm.rptName = "rptPelanggan"
        frm.ShowDialog()
    End Sub

    Private Sub txtNmplg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNmplg.TextChanged

    End Sub
End Class