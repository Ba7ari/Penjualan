Option Strict On
Imports System.Data.OleDb
Public Class ctlDetilNotaKontan
    Inherits DetilNotaKontan
    Private db As New DBConnection
    Private cmd As OleDbCommand
    Private dr As OleDbDataReader
    Private q As String

    Public Sub insert()
        q = "INSERT INTO ada VALUES('" & nonk & "','" & kdBrg & "','" & hrgbeli & "','" & jmlbeli & "')"
        db.exeNonQuery(q)
    End Sub

    Public Sub updateJmlBeli()
        q = "UPDATE ada SET jmlbeli='" & jmlBeli & "' WHERE nonk='" & noNk & "' AND kdbrg='" & kdBrg & "'"
        db.exeNonQuery(q)
    End Sub

    Public Sub getByCK()
        q = "SELECT * FROM ada WHERE nonk='" & noNk & "' AND kdbrg='" & kdBrg & "'"
        dr = db.exeReader(q)
        If dr.Read Then
            noNk = dr.GetString(0)
            kdBrg = dr.GetString(1)
            hrgBeli = dr.GetInt32(2)
            jmlBeli = dr.GetInt32(3)
        Else
            noNk = String.Empty
            kdBrg = String.Empty
            hrgBeli = 0
            jmlBeli = 0
        End If
    End Sub

    Public Function recordExist() As Boolean
        q = "SELECT * FROM ada WHERE nonk='" & noNk & "' AND kdbrg='" & kdBrg & "'"
        dr = db.exeReader(q)
        If dr.Read Then
            Return True
        End If
        Return False
    End Function
End Class
