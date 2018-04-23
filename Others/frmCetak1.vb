Option Strict On
Public Class frmCetak1
    Private _rptName As String, _fld As String

#Region "Properties"
    Public WriteOnly Property rptName() As String
        Set(ByVal value As String)
            _rptName = value
        End Set
    End Property

    Public ReadOnly Property fld() As String
        Get
            Return gM.fieldValue(cboFilter.Text)
        End Get
    End Property
#End Region

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim frm As New frmGeneratingRpt
        frm.rptName = _rptName
        frm.field = fld
        If txtKey.Text.Trim = String.Empty Then
            If MessageBox.Show("Tanpa kata kunci semua data '" & _rptName.Substring(3) & "' akan ditampilkan, 'Yes' untuk melanjutkan, 'No' untuk membatalkan", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                frm.keyValue = String.Empty
                frm.ShowDialog()
            Else : Exit Sub
            End If
        Else
            If rb1.Checked = True Then
                frm.akurat = True
                frm.keyValue = txtKey.Text
            ElseIf rb1.Checked = False Then
                frm.akurat = False
                frm.keyValue = txtKey.Text.Trim
            End If
            frm.ShowDialog()
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmCetak1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown, txtKey.KeyDown
        gM.cekLockKeysOnKeyDown(e)
    End Sub

    Private Sub frmCetak1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboFilter.Items.Clear()
        Select Case _rptName
            Case Is = "rptPelanggan"
                cboFilter.Items.Add("Nama Pelanggan")
                cboFilter.Items.Add("Alamat")
            Case Is = "rptBarang"
                cboFilter.Items.Add("Nama Barang")
                cboFilter.Items.Add("Kode Sub Kategori")
        End Select
        cboFilter.SelectedIndex = 0
    End Sub

    Private Sub cboFilter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFilter.SelectedIndexChanged
        txtKey.Clear()
    End Sub

    Private Sub txtKey_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKey.KeyPress
        gM.noInject(e)
    End Sub
End Class