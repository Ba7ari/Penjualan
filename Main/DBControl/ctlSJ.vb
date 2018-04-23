Option Strict On
Imports System.Data.OleDb
Public Class ctlSJ
    Inherits SJ
    Private db As New DBConnection
    Private cmd As OleDbCommand
    Private dr As OleDbDataReader
    Private da As OleDbDataAdapter
    Private q As String

    Public Function autoNum() As String
        q = "SELECT nosj FROM kirim ORDER BY nosj DESC"
        dr = db.exeReader(q)
        If dr.Read Then
            Return Format(Val(dr.GetString(0).Substring(2, 6)) + 1, "SJ0#####")
        End If
        Return "SJ000001"
    End Function

    Public Function insert() As Boolean
        q = "INSERT INTO sj VALUES('" & noSj & "','" & tglSj & "','" & noPol & "','" & noFaktur & "')"
        If db.exeNonQuery(q) Then
            Return True
        End If
        Return False
    End Function

    Public Sub getByPK()
        q = "SELECT * FROM sj WHERE nosj='" & noSj & "'"
        dr = db.exeReader(q)
        If dr.Read Then
            noSj = dr.GetString(0)
            tglSj = dr.GetDateTime(1)
            noPol = dr.GetString(2)
            noFaktur = dr.GetString(3)
        Else
            noSj = String.Empty
            tglSj = Nothing
            noPol = String.Empty
            noFaktur = String.Empty
        End If
    End Sub

    Public Function recordExist() As Boolean
        q = "SELECT * FROM sj WHERE nosj='" & noSj & "'"
        dr = db.exeReader(q)
        If dr.Read Then
            Return True
        End If
        Return False
    End Function

    Public Function arrAll() As ArrayList
        q = "SELECT * FROM sj"
        Dim arrLst As New ArrayList
        dr = db.exeReader(q)
        If Not dr Is Nothing Then
            While dr.Read
                Dim objData As New SJ
                With objData
                    .noSj = dr.GetString(0)
                    .tglSj = dr.GetDateTime(1)
                    .noPol = dr.GetString(2)
                    .noFaktur = dr.GetString(3)
                End With
                arrLst.Add(objData)
            End While
        End If
        Return arrLst
    End Function

    Public Function arrByPrefix(ByVal field As String, ByVal keyValue As String) As ArrayList
        q = "SELECT * FROM sj WHERE " & field & " LIKE '" & keyValue & "%'"
        Dim arrLst As New ArrayList
        dr = db.exeReader(q)
        If Not dr Is Nothing Then
            While dr.Read
                Dim objData As New SJ
                With objData
                    .noSj = dr.GetString(0)
                    .tglSj = dr.GetDateTime(1)
                    .noPol = dr.GetString(2)
                    .noFaktur = dr.GetString(3)
                End With
                arrLst.Add(objData)
            End While
        End If
        Return arrLst
    End Function

    Public Function tblByPK() As DataTable
        q = "SELECT sj.nosj,sj.tglsj,sj.nopol,faktur.nofaktur,faktur.tglfaktur,pesanan.nosp," & _
            " pesanan.tglsp,pelanggan.nmplg,pelanggan.alamat,pelanggan.telp,barang.nmbrg,kirim.jmlkirim,kirim.keterangan" & _
            " FROM sj,kirim,faktur,pesanan,pelanggan,barang" & _
            " WHERE sj.nosj=kirim.nosj AND sj.nofaktur=faktur.nofaktur AND faktur.nosp=" & _
            " pesanan.nosp AND pesanan.kdplg=pelanggan.kdplg AND kirim.kdbrg=barang.kdbrg AND sj.nosj='" & noSj & "'"
        Dim tbl As New DataTable
        da = db.adapter(q)
        da.Fill(tbl)
        Return tbl
    End Function

    Public Function tblPengiriman() As DataTable
        q = "SELECT sj.nosj,sj.tglsj,faktur.nofaktur,faktur.tglfaktur,pesanan.nosp," & _
            " pesanan.tglsp,pelanggan.nmplg,barang.nmbrg,kirim.jmlkirim" & _
            " FROM sj,kirim,faktur,pesanan,pelanggan,barang" & _
            " WHERE sj.nosj=kirim.nosj AND sj.nofaktur=faktur.nofaktur AND faktur.nosp=" & _
            " pesanan.nosp AND pesanan.kdplg=pelanggan.kdplg AND kirim.kdbrg=barang.kdbrg"
        Dim tbl As New DataTable
        da = db.adapter(q)
        da.Fill(tbl)
        Return tbl
    End Function
End Class
