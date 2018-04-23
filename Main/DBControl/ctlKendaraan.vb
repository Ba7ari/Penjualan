Option Strict On
Imports System.Data.OleDb
Public Class ctlKendaraan
    Inherits Kendaraan
    Private db As New DBConnection
    Private cmd As OleDbCommand
    Private dr As OleDbDataReader
    Private da As OleDbDataAdapter
    Private q As String

    Public Function insert() As Boolean
        q = "INSERT INTO kendaraan VALUES('" & noPol & "','" & merkKend & "','" & jmlRoda & "','" & bhnBakar & "')"
        If db.exeNonQuery(q) Then
            Return True
        End If
        Return False
    End Function

    Public Function update() As Boolean
        q = "UPDATE kendaraan SET merkkend='" & merkKend & "',jmlroda='" & jmlRoda & "',bahanbakar='" & bhnBakar & "' WHERE nopol='" & noPol & "'"
        If db.exeNonQuery(q) Then
            Return True
        End If
        Return False
    End Function

    Public Function delete() As Boolean
        q = "DELETE FROM kendaraan WHERE nopol='" & noPol & "'"
        If db.exeNonQuery(q) Then
            Return True
        End If
        Return False
    End Function

    Public Sub getByKey(ByVal field As String, ByVal keyValue As String)
        q = "SELECT * FROM kendaraan WHERE " & field & "='" & keyValue & "'"
        dr = db.exeReader(q)
        If dr.Read Then
            noPol = dr.GetString(0)
            merkKend = dr.GetString(1)
            jmlRoda = dr.GetString(2)
            bhnBakar = dr.GetString(3)
        Else
            noPol = String.Empty
            merkKend = String.Empty
            jmlRoda = String.Empty
            bhnBakar = String.Empty
        End If
    End Sub

    Public Function recordExist() As Boolean
        q = "SELECT * FROM kendaraan WHERE nopol='" & noPol & "'"
        dr = db.exeReader(q)
        If dr.Read Then
            Return True
        End If
        Return False
    End Function

    Public Function arrAll() As ArrayList
        q = "SELECT * FROM kendaraan"
        Dim arrLst As New ArrayList
        dr = db.exeReader(q)
        If Not dr Is Nothing Then
            While dr.Read
                Dim objData As New Kendaraan
                With objData
                    .noPol = dr.GetString(0)
                    .merkKend = dr.GetString(1)
                    .jmlRoda = dr.GetString(2)
                    .bhnBakar = dr.GetString(3)
                End With
                arrLst.Add(objData)
            End While
        End If
        Return arrLst
    End Function

    Public Function arrByPrefix(ByVal field As String, ByVal keyValue As String) As ArrayList
        q = "SELECT * FROM kendaraan WHERE " & field & " LIKE '" & keyValue & "%'"
        Dim arrLst As New ArrayList
        dr = db.exeReader(q)
        If Not dr Is Nothing Then
            While dr.Read
                Dim objData As New Kendaraan
                With objData
                    .noPol = dr.GetString(0)
                    .merkKend = dr.GetString(1)
                    .jmlRoda = dr.GetString(2)
                    .bhnBakar = dr.GetString(3)
                End With
                arrLst.Add(objData)
            End While
        End If
        Return arrLst
    End Function
End Class
