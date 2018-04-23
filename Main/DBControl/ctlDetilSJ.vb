Option Strict On
Imports System.Data.OleDb
Public Class ctlDetilSJ
    Inherits DetilSJ
    Private db As New DBConnection
    Private cmd As OleDbCommand
    Private dr As OleDbDataReader
    Private q As String

    Public Sub insert()
        q = "INSERT INTO kirim VALUES('" & noSj & "','" & kdBrg & "','" & jmlKirim & "','" & keterangan & "')"
        db.exeNonQuery(q)
    End Sub
End Class
