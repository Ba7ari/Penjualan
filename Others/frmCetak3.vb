Option Strict On
Public Class frmCetak3
    Private _rptName, _pk As String
    Dim cFaktur As New ctlFaktur
    Dim cKwitansi As New ctlKwitansi
    Dim cSj As New ctlSJ

#Region "Properties"
    Public WriteOnly Property rptName() As String
        Set(ByVal value As String)
            _rptName = value
        End Set
    End Property

    Public WriteOnly Property pk() As String
        Set(ByVal value As String)
            _pk = value
        End Set
    End Property
#End Region

    Private Sub frmCetak3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown, txtKey.KeyDown
        gM.cekLockKeysOnKeyDown(e)
    End Sub

    Private Sub frmCetak3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "Input " & "'" & _pk & "'" & " atau pergunakan tombol 'Cari'."
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Select Case _rptName
            Case Is = "rptFaktur"
                cFaktur.noFaktur = txtKey.Text
                If cFaktur.recordExist = False Then
                    MessageBox.Show("Faktur tidak terdaftar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Case Is = "rptKwitansi"
                cKwitansi.noKwt = txtKey.Text
                If cKwitansi.recordExist = False Then
                    MessageBox.Show("Kwitansi tidak terdaftar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Case Is = "rptSJ"
                cSj.noSj = txtKey.Text
                If cSj.recordExist = False Then
                    MessageBox.Show("Surat Jalan tidak terdaftar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
        End Select
        Dim frm As New frmGeneratingRpt
        frm.rptName = _rptName
        frm.keyValue = txtKey.Text
        frm.ShowDialog()
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Dim frm As New frmBrowse
        Select Case _rptName
            Case Is = "rptFaktur"
                frm.table = gM.dbTable.Faktur
            Case Is = "rptKwitansi"
                frm.table = gM.dbTable.Kwitansi
            Case Is = "rptSJ"
                frm.table = gM.dbTable.SJ
        End Select
        frm.ShowDialog()
        If frm.keyValue <> String.Empty Then
            txtKey.Text = frm.keyValue
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtKey_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKey.KeyPress
        gM.noInject(e)
    End Sub
End Class