Option Strict On
Imports System.Data.OleDb
Public Class ctlJurnal
    Inherits Jurnal
    Private db As New DBConnection
    Private cmd As OleDbCommand
    Private dr As OleDbDataReader
    Private da As OleDbDataAdapter
    Private q As String

    Public Sub insert()
        q = "INSERT INTO jurnal VALUES('" & noBukti & "','" & kdRek & "','" & tglBukti & "','" & jumlah & "','" & posisi & "')"
        db.exeNonQuery(q)
    End Sub

    Public Function tblJurnalUmum() As DataTable
        q = "SELECT jurnal.nobukti,jurnal.kdrek,jurnal.tglbukti,jurnal.jumlah,jurnal.posisi," & _
            " rekening.nmrek FROM jurnal,rekening WHERE jurnal.kdrek=rekening.kdrek" & _
            " ORDER BY jurnal.tglbukti"
        Dim tbl As New DataTable
        da = db.adapter(q)
        da.Fill(tbl)
        Return tbl
    End Function
End Class
