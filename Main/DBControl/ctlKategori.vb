Option Strict On
Imports System.Data.OleDb
Public Class ctlKategori
    Inherits Kategori
    Private db As New DBConnection
    Private cmd As OleDbCommand
    Private dr As OleDbDataReader
    Private da As OleDbDataAdapter
    Private q As String

    Public Function autoNum() As String
        q = "SELECT kdkategori FROM kategori ORDER BY kdkategori DESC"
        dr = db.exeReader(q)
        If dr.Read Then
            Return Format(Val(dr.GetString(0).Substring(2, 2)) + 1, "KT0#")
        End If
        Return "KT01"
    End Function

    Public Function insert() As Boolean
        q = "INSERT INTO kategori VALUES('" & kdKategori & "','" & nmKategori & "')"
        If db.exeNonQuery(q) Then
            Return True
        End If
        Return False
    End Function

    Public Function update() As Boolean
        q = "UPDATE kategori SET nmkategori='" & nmKategori & "' WHERE kdkategori= '" & kdKategori & "'"
        If db.exeNonQuery(q) Then
            Return True
        End If
        Return False
    End Function

    Public Function delete() As Boolean
        q = "DELETE FROM kategori WHERE kdkategori='" & kdKategori & "'"
        If db.exeNonQuery(q) Then
            Return True
        End If
        Return False
    End Function

    Public Sub getByKey(ByVal field As String, ByVal keyValue As String)
        q = "SELECT * FROM kategori WHERE " & field & "='" & keyValue & "'"
        dr = db.exeReader(q)
        If dr.Read Then
            kdKategori = dr.GetString(0)
            nmKategori = dr.GetString(1)
        Else
            kdKategori = String.Empty
            nmKategori = String.Empty
        End If
    End Sub

    Public Function recordExist() As Boolean
        q = "SELECT * FROM kategori WHERE kdkategori='" & kdKategori & "'"
        dr = db.exeReader(q)
        If dr.Read Then
            Return True
        End If
        Return False
    End Function

    Public Function arrAll() As ArrayList
        q = "SELECT * FROM kategori"
        Dim arrLst As New ArrayList
        dr = db.exeReader(q)
        If Not dr Is Nothing Then
            While dr.Read
                Dim objData As New Kategori
                With objData
                    .kdKategori = dr.GetString(0)
                    .nmKategori = dr.GetString(1)
                End With
                arrLst.Add(objData)
            End While
        End If
        Return arrLst
    End Function
End Class
