Option Strict On
Imports System.Data.OleDb
Public Class ctlSubKategori
    Inherits SubKategori
    Private db As New DBConnection
    Private cmd As OleDbCommand
    Private dr As OleDbDataReader
    Private da As OleDbDataAdapter
    Private q As String

    Public Function autoNum() As String
        q = "SELECT kdsub FROM subkategori ORDER BY kdsub DESC"
        dr = db.exeReader(q)
        If dr.Read Then
            Return Format(Val(dr.GetString(0).Substring(2, 2)) + 1, "SK0#")
        End If
        Return "SK01"
    End Function

    Public Function insert() As Boolean
        q = "INSERT INTO subkategori VALUES('" & kdSub & "','" & nmSub & "','" & kdKategori & "')"
        If db.exeNonQuery(q) Then
            Return True
        End If
        Return False
    End Function

    Public Function update() As Boolean
        q = "UPDATE subkategori SET nmsub='" & nmSub & "',kdkategori='" & kdKategori & "' WHERE kdsub= '" & kdSub & "'"
        If db.exeNonQuery(q) Then
            Return True
        End If
        Return False
    End Function

    Public Function delete() As Boolean
        q = "DELETE FROM subkategori WHERE kdsub='" & kdSub & "'"
        If db.exeNonQuery(q) Then
            Return True
        End If
        Return False
    End Function

    Public Sub getByKey(ByVal field As String, ByVal keyValue As String)
        q = "SELECT * FROM subkategori WHERE " & field & "='" & keyValue & "'"
        dr = db.exeReader(q)
        If dr.Read Then
            kdSub = dr.GetString(0)
            nmSub = dr.GetString(1)
            kdKategori = dr.GetString(2)
        Else
            kdSub = String.Empty
            nmSub = String.Empty
            kdKategori = String.Empty
        End If
    End Sub

    Public Function recordExist() As Boolean
        q = "SELECT * FROM subkategori WHERE kdsub='" & kdSub & "'"
        dr = db.exeReader(q)
        If dr.Read Then
            Return True
        End If
        Return False
    End Function

    Public Function arrAll() As ArrayList
        q = "SELECT * FROM subkategori"
        Dim arrLst As New ArrayList
        dr = db.exeReader(q)
        If Not dr Is Nothing Then
            While dr.Read
                Dim objData As New SubKategori
                With objData
                    .kdSub = dr.GetString(0)
                    .nmSub = dr.GetString(1)
                    .kdKategori = dr.GetString(2)
                End With
                arrLst.Add(objData)
            End While
        End If
        Return arrLst
    End Function

    Public Function arrByKey(ByVal field As String, ByVal keyValue As String) As ArrayList
        q = "SELECT * FROM subkategori WHERE " & field & "='" & keyValue & "'"
        Dim arrLst As New ArrayList
        dr = db.exeReader(q)
        If Not dr Is Nothing Then
            While dr.Read
                Dim objData As New SubKategori
                With objData
                    .kdSub = dr.GetString(0)
                    .nmSub = dr.GetString(1)
                    .kdKategori = dr.GetString(2)
                End With
                arrLst.Add(objData)
            End While
        End If
        Return arrLst
    End Function
End Class
