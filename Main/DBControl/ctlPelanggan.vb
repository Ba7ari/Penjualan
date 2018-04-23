Option Strict On
Imports System.Data.OleDb
Public Class ctlPelanggan
    Inherits Pelanggan
    Private db As New DBConnection
    Private cmd As OleDbCommand
    Private dr As OleDbDataReader
    Private da As OleDbDataAdapter
    Private q As String

    Public Function autoNum() As String
        q = "SELECT kdplg FROM pelanggan ORDER BY kdplg DESC"
        dr = db.exeReader(q)
        If dr.Read Then
            Return Format(Val(dr.GetString(0).Substring(2, 5)) + 1, "PL0####")
        End If
        Return "PL00001"
    End Function

    Public Function insert() As Boolean
        q = "INSERT INTO pelanggan VALUES('" & kdPlg & "','" & nmPlg & "','" & alamat & "','" & telp & "')"
        If db.exeNonQuery(q) Then
            Return True
        End If
        Return False
    End Function

    Public Function update() As Boolean
        q = "UPDATE pelanggan SET nmplg='" & nmPlg & "',alamat='" & alamat & "',telp='" & telp & "' WHERE kdplg= '" & kdPlg & "'"
        If db.exeNonQuery(q) Then
            Return True
        End If
        Return False
    End Function

    Public Function delete() As Boolean
        q = "DELETE FROM pelanggan WHERE Kdplg='" & kdPlg & "'"
        If db.exeNonQuery(q) Then
            Return True
        End If
        Return False
    End Function

    Public Sub getByKey(ByVal field As String, ByVal keyValue As String)
        q = "SELECT * FROM pelanggan WHERE " & field & "='" & keyValue & "'"
        dr = db.exeReader(q)
        If dr.Read Then
            kdPlg = dr.GetString(0)
            nmPlg = dr.GetString(1)
            alamat = dr.GetString(2)
            telp = dr.GetString(3)
        Else
            kdPlg = String.Empty
            nmPlg = String.Empty
            alamat = String.Empty
            telp = String.Empty
        End If
    End Sub

    Public Function recordExist() As Boolean
        q = "SELECT * FROM pelanggan WHERE kdplg='" & kdPlg & "'"
        dr = db.exeReader(q)
        If dr.Read Then
            Return True
        End If
        Return False
    End Function

    Public Function arrAll() As ArrayList
        q = "SELECT * FROM pelanggan"
        Dim arrLst As New ArrayList
        dr = db.exeReader(q)
        If Not dr Is Nothing Then
            While dr.Read
                Dim objData As New Pelanggan
                With objData
                    .kdPlg = dr.GetString(0)
                    .nmPlg = dr.GetString(1)
                    .alamat = dr.GetString(2)
                    .telp = dr.GetString(3)
                End With
                arrLst.Add(objData)
            End While
        End If
        Return arrLst
    End Function

    Public Function arrByPrefix(ByVal field As String, ByVal keyValue As String) As ArrayList
        q = "SELECT * FROM pelanggan WHERE " & field & " LIKE '" & keyValue & "%'"
        Dim arrLst As New ArrayList
        dr = db.exeReader(q)
        If Not dr Is Nothing Then
            While dr.Read
                Dim objData As New Pelanggan
                With objData
                    .kdPlg = dr.GetString(0)
                    .nmPlg = dr.GetString(1)
                    .alamat = dr.GetString(2)
                    .telp = dr.GetString(3)
                End With
                arrLst.Add(objData)
            End While
        End If
        Return arrLst
    End Function

    Public Function tblByKey(ByVal field As String, ByVal keyValue As String) As DataTable
        q = "SELECT * FROM pelanggan WHERE " & field & " = '" & keyValue & "'"
        Dim tbl As New DataTable
        da = db.adapter(q)
        da.Fill(tbl)
        Return tbl
    End Function

    Public Function tblByPrefix(ByVal field As String, ByVal keyValue As String) As DataTable
        q = "SELECT * FROM pelanggan WHERE " & field & " LIKE '" & keyValue & "%'"
        Dim tbl As New DataTable
        da = db.adapter(q)
        da.Fill(tbl)
        Return tbl
    End Function
End Class
