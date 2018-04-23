Option Strict On
Imports System.Data.OleDb
Public Class ctlKwitansi
    Inherits Kwitansi
    Private db As New DBConnection
    Private cmd As OleDbCommand
    Private dr As OleDbDataReader
    Private da As OleDbDataAdapter
    Private q As String

    Public Function autoNum() As String
        q = "SELECT nokwt FROM kwitansi ORDER BY nokwt DESC"
        dr = db.exeReader(q)
        If dr.Read Then
            Return Format(Val(dr.GetString(0).Substring(2, 6)) + 1, "KW0#####")
        End If
        Return "KW000001"
    End Function

    Public Function insert() As Boolean
        q = "INSERT INTO kwitansi VALUES('" & noKwt & "','" & tglKwt & "','" & noFaktur & "')"
        If db.exeNonQuery(q) Then
            Return True
        End If
        Return False
    End Function

    Public Sub getByPK()
        q = "SELECT * FROM kwitansi WHERE nokwt='" & noKwt & "'"
        dr = db.exeReader(q)
        If dr.Read Then
            noKwt = dr.GetString(0)
            tglKwt = dr.GetDateTime(1)
            noFaktur = dr.GetString(2)
        Else
            noKwt = String.Empty
            tglKwt = Nothing
            noFaktur = String.Empty
        End If
    End Sub

    Public Function recordExist() As Boolean
        q = "SELECT * FROM kwitansi WHERE nokwt='" & noKwt & "'"
        dr = db.exeReader(q)
        If dr.Read Then
            Return True
        End If
        Return False
    End Function

    Public Function arrAll() As ArrayList
        q = "SELECT * FROM kwitansi"
        Dim arrLst As New ArrayList
        dr = db.exeReader(q)
        If Not dr Is Nothing Then
            While dr.Read
                Dim objData As New Kwitansi
                With objData
                    .noKwt = dr.GetString(0)
                    .tglKwt = dr.GetDateTime(1)
                    .noFaktur = dr.GetString(2)
                End With
                arrLst.Add(objData)
            End While
        End If
        Return arrLst
    End Function

    Public Function arrByPrefix(ByVal field As String, ByVal keyValue As String) As ArrayList
        q = "SELECT * FROM kwitansi WHERE " & field & " LIKE '" & keyValue & "%'"
        Dim arrLst As New ArrayList
        dr = db.exeReader(q)
        If Not dr Is Nothing Then
            While dr.Read
                Dim objData As New Kwitansi
                With objData
                    .noKwt = dr.GetString(0)
                    .tglKwt = dr.GetDateTime(1)
                    .noFaktur = dr.GetString(2)
                End With
                arrLst.Add(objData)
            End While
        End If
        Return arrLst
    End Function

    Public Function tblByPK() As DataTable
        q = "SELECT kwitansi.nokwt,kwitansi.tglkwt,faktur.nofaktur,faktur.tglfaktur,pesanan.nosp,pesanan.tglsp," & _
            " pelanggan.nmplg,pelanggan.alamat,barang.nmbrg,isi.hrgpsn,isi.jmlpsn" & _
            " FROM kwitansi,faktur,pesanan,isi,pelanggan,barang" & _
            " WHERE kwitansi.nofaktur=faktur.nofaktur AND faktur.nosp=pesanan.nosp" & _
            " AND pesanan.nosp = isi.nosp AND pesanan.kdplg = pelanggan.kdplg" & _
            " AND isi.kdbrg=barang.kdbrg AND kwitansi.nokwt='" & noKwt & "'"
        Dim tbl As New DataTable
        da = db.adapter(q)
        da.Fill(tbl)
        Return tbl
    End Function
End Class
