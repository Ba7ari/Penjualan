Option Strict On
Public Class frmKendaraan
    Private _mode As String
    Dim cKendaraan As New ctlKendaraan

    Public WriteOnly Property mode() As String
        Set(ByVal value As String)
            _mode = value
        End Set
    End Property

    Private Sub frmKendaraan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown, txtBhnbakar.KeyDown, txtJmlroda.KeyDown, txtMerkkend.KeyDown, txtNopol.KeyDown
        gM.cekLockKeysOnKeyDown(e)
    End Sub

    Private Sub frmKendaraan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case _mode
            Case Is = "Insert"
                Me.Text = "Add New"
                btnSave.Text = "Insert"
                txtNopol.ReadOnly = False
                txtNopol.BackColor = Color.FromKnownColor(KnownColor.Window)
                txtNopol.Select()
            Case Is = "Update"
                Me.Text = "Update"
                btnSave.Text = "Update"
                txtNopol.ReadOnly = True
                txtNopol.BackColor = Me.BackColor
                txtMerkkend.Select()
                txtMerkkend.Select(txtMerkkend.TextLength, txtMerkkend.TextLength)
        End Select
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtNopol.Text.Trim = String.Empty Or txtMerkkend.Text.Trim = String.Empty Or _
        Val(txtJmlroda.Text) = 0 Or txtBhnbakar.Text.Trim = String.Empty Then
            MessageBox.Show("Data yang diinput harus lengkap", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            With cKendaraan
                .noPol = txtNopol.Text
                .merkKend = txtMerkkend.Text
                .jmlRoda = txtJmlroda.Text
                .bhnBakar = txtBhnbakar.Text
                If btnSave.Text = "Insert" Then
                    .noPol = txtNopol.Text
                    If .recordExist Then
                        MessageBox.Show("No. Polisi Kendaraan telah terdaftar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                    If .insert() Then
                        MessageBox.Show("Data berhasil disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    If .update() Then
                        MessageBox.Show("Data berhasil diupdate", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
                Me.Close()
            End With
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtJmlroda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJmlroda.KeyPress
        gM.numOnly(e)
    End Sub

    Private Sub txtNopol_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNopol.KeyPress
        gM.noInject(e)
    End Sub

    Private Sub txtNopol_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNopol.TextChanged

    End Sub

    Private Sub txtMerkkend_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMerkkend.TextChanged

    End Sub
End Class