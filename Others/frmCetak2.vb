Option Strict On
Public Class frmCetak2
    Private _rptName As String

    Public WriteOnly Property rptName() As String
        Set(ByVal value As String)
            _rptName = value
        End Set
    End Property

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim frm As New frmGeneratingRpt
        frm.rptName = _rptName
        frm.tglAwal = dtpAwal.Value.Date
        frm.tglAkhir = dtpAkhir.Value.Date
        frm.ShowDialog()
    End Sub

    Private Sub frmCetak2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpAwal.Value = Now.AddDays(-(Now.Day - 1))
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class