Option Strict On
Imports System.Data.OleDb
Public Class ctlNotaKontan
    Inherits NotaKontan
    Private db As New DBConnection
    Private cmd As OleDbCommand
    Private dr As OleDbDataReader
    Private da As OleDbDataAdapter
    Private q As String

    Public Function autoNum() As String
        q = "SELECT nonk FROM notakontan ORDER BY nonk DESC"
        dr = db.exeReader(q)
        If dr.Read Then
            Return Format(Val(dr.GetString(0).Substring(2, 6)) + 1, "NK0#####")
        End If
        Return "NK000001"
    End Function

    Public Function insert() As Boolean
        q = "INSERT INTO notakontan VALUES('" & noNk & "','" & tglNk & "')"
        If db.exeNonQuery(q) Then
            Return True
        End If
        Return False
    End Function

    Public Function tblByPK() As DataTable
        q = "SELECT notakontan.nonk,notakontan.tglnk,barang.nmbrg,ada.hrgbeli,ada.jmlbeli" & _
            " FROM notakontan,ada,barang" & _
            " WHERE notakontan.nonk=ada.nonk AND ada.kdbrg=barang.kdbrg" & _
            " AND notakontan.nonk = '" & noNk & "'"
        Dim tbl As New DataTable
        da = db.adapter(q)
        da.Fill(tbl)
        Return tbl
    End Function

    Public Function tblPenjualanKontan() As DataTable
        q = "SELECT notakontan.nonk,notakontan.tglnk,barang.nmbrg,ada.hrgbeli,ada.jmlbeli" & _
            " FROM notakontan,ada,barang" & _
            " WHERE notakontan.nonk=ada.nonk AND ada.kdbrg=barang.kdbrg"
        Dim tbl As New DataTable
        da = db.adapter(q)
        da.Fill(tbl)
        Return tbl
    End Function
End Class
