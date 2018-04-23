Option Strict On
Imports System.Data.OleDb
Public Class ctlRekening
    Inherits Rekening
    Private db As New DBConnection
    Private cmd As OleDbCommand
    Private dr As OleDbDataReader
    Private da As OleDbDataAdapter
    Private q As String

    Public Function insert() As Boolean
        q = "INSERT INTO rekening VALUES('" & kdRek & "','" & nmRek & "')"
        If db.exeNonQuery(q) Then
            Return True
        End If
        Return False
    End Function

    Public Function update() As Boolean
        q = "UPDATE rekening SET nmrek='" & nmRek & "' WHERE kdrek='" & kdRek & "'"
        If db.exeNonQuery(q) Then
            Return True
        End If
        Return False
    End Function

    Public Function delete() As Boolean
        q = "DELETE FROM rekening WHERE kdrek='" & kdRek & "'"
        If db.exeNonQuery(q) Then
            Return True
        End If
        Return False
    End Function

    Public Sub getByKey(ByVal field As String, ByVal keyValue As String)
        q = "SELECT * FROM rekening WHERE " & field & " = '" & keyValue & "'"
        dr = db.exeReader(q)
        If dr.Read Then
            kdRek = dr.GetString(0)
            nmRek = dr.GetString(1)
        Else
            kdRek = String.Empty
            nmRek = String.Empty
        End If
    End Sub

    Public Function recordExist() As Boolean
        q = "SELECT * FROM rekening WHERE kdrek='" & kdRek & "'"
        dr = db.exeReader(q)
        If dr.Read Then
            Return True
        End If
        Return False
    End Function

    Public Function arrAll() As ArrayList
        q = "SELECT * FROM rekening"
        Dim arrLst As New ArrayList
        dr = db.exeReader(q)
        If Not dr Is Nothing Then
            While dr.Read
                Dim objData As New Rekening
                With objData
                    .kdRek = dr.GetString(0)
                    .nmRek = dr.GetString(1)
                End With
                arrLst.Add(objData)
            End While
        End If
        Return arrLst
    End Function

    Public Function arrByPrefix(ByVal field As String, ByVal keyValue As String) As ArrayList
        q = "SELECT * FROM rekening WHERE " & field & " LIKE '" & keyValue & "%'"
        Dim arrLst As New ArrayList
        dr = db.exeReader(q)
        If Not dr Is Nothing Then
            While dr.Read
                Dim objData As New Rekening
                With objData
                    .kdRek = dr.GetString(0)
                    .nmRek = dr.GetString(1)
                End With
                arrLst.Add(objData)
            End While
        End If
        Return arrLst
    End Function
End Class
