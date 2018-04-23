Option Strict On
Public Class frmRekening
    Private _mode As String
    Dim cRekening As New ctlRekening

    Public WriteOnly Property mode() As String
        Set(ByVal value As String)
            _mode = value
        End Set
    End Property

    Private Sub frmRekening_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown, txtKdrek.KeyDown, txtNmrek.KeyDown
        gM.cekLockKeysOnKeyDown(e)
    End Sub

    Private Sub frmRekening_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case _mode
            Case Is = "Insert"
                Me.Text = "Add New"
                btnSave.Text = "Insert"
                txtKdrek.ReadOnly = False
                txtKdrek.BackColor = Color.FromKnownColor(KnownColor.Window)
                txtKdrek.Select()
            Case Is = "Update"
                Me.Text = "Update"
                btnSave.Text = "Update"
                txtKdrek.ReadOnly = True
                txtKdrek.BackColor = Me.BackColor
                txtNmrek.Select()
                txtNmrek.Select(txtNmrek.TextLength, txtNmrek.TextLength)
        End Select
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtKdrek.Text.Trim = String.Empty Or txtNmrek.Text.Trim = String.Empty Then
            MessageBox.Show("Data yang diinput harus lengkap", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            With cRekening
                .kdRek = txtKdrek.Text
                .nmRek = txtNmrek.Text
                If btnSave.Text = "Insert" Then
                    .kdRek = txtKdrek.Text
                    If .recordExist Then
                        MessageBox.Show("Kode Rekening telah terpakai", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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

    Private Sub txtKdrek_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKdrek.KeyPress
        gM.noInject(e)
    End Sub
End Class