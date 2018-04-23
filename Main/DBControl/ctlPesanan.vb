Option Strict On
Imports System.Data.OleDb
Public Class ctlPesanan
    Inherits Pesanan
    Private db As New DBConnection
    Private cmd As OleDbCommand
    Private dr As OleDbDataReader
    Private da As OleDbDataAdapter
    Private q As String

    Public Function autoNum() As String
        q = "SELECT nosp FROM pesanan ORDER BY nosp DESC"
        dr = db.exeReader(q)
        If dr.Read Then
            Return Format(Val(dr.GetString(0).Substring(2, 6)) + 1, "SP0#####")
        End If
        Return "SP000001"
    End Function

    Public Function insert() As Boolean
        q = "INSERT INTO pesanan VALUES('" & noSp & "','" & tglSp & "','" & kdPlg & "')"
        If db.exeNonQuery(q) Then
            Return True
        End If
        Return False
    End Function

    Public Sub getByPK()
        q = "SELECT * FROM pesanan WHERE nosp='" & noSp & "'"
        dr = db.exeReader(q)
        If dr.Read Then
            noSp = dr.GetString(0)
            tglSp = dr.GetDateTime(1)
            kdPlg = dr.GetString(2)
        Else
            noSp = String.Empty
            tglSp = Nothing
            kdPlg = String.Empty
        End If
    End Sub

    Public Function inFaktur() As Boolean
        q = "SELECT * FROM pesanan WHERE nosp IN(SELECT nosp FROM faktur)" & _
            " AND pesanan.nosp='" & noSp & "'"
        dr = db.exeReader(q)
        If dr.Read Then
            Return True
        End If
        Return False
    End Function

    Public Function arrAll() As ArrayList
        q = "SELECT * FROM pesanan"
        Dim arrLst As New ArrayList
        dr = db.exeReader(q)
        If Not dr Is Nothing Then
            While dr.Read
                Dim objData As New Pesanan
                With objData
                    .noSp = dr.GetString(0)
                    .tglSp = dr.GetDateTime(1)
                    .kdPlg = dr.GetString(2)
                End With
                arrLst.Add(objData)
            End While
        End If
        Return arrLst
    End Function

    Public Function arrByPrefix(ByVal field As String, ByVal keyValue As String) As ArrayList
        q = "SELECT * FROM pesanan WHERE " & field & " LIKE '" & keyValue & "%'"
        Dim arrLst As New ArrayList
        dr = db.exeReader(q)
        If Not dr Is Nothing Then
            While dr.Read
                Dim objData As New Pesanan
                With objData
                    .noSp = dr.GetString(0)
                    .tglSp = dr.GetDateTime(1)
                    .kdPlg = dr.GetString(2)
                End With
                arrLst.Add(objData)
            End While
        End If
        Return arrLst
    End Function

    Public Function tblPenjualanPesan() As DataTable
        q = "SELECT pesanan.nosp,pesanan.tglsp,pelanggan.nmplg,barang.nmbrg,isi.hrgpsn,isi.jmlpsn" & _
            " FROM pesanan,isi,pelanggan,barang" & _
            " WHERE pesanan.nosp=isi.nosp AND pesanan.kdplg=pelanggan.kdplg" & _
            " AND isi.kdbrg=barang.kdbrg"
        Dim tbl As New DataTable
        da = db.adapter(q)
        da.Fill(tbl)
        Return tbl
    End Function
End Class
