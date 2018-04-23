Option Strict On
Imports System.Data.OleDb
Public Class ctlFaktur
    Inherits Faktur
    Private db As New DBConnection
    Private cmd As OleDbCommand
    Private dr As OleDbDataReader
    Private da As OleDbDataAdapter
    Private q As String

    Public Function autoNum() As String
        q = "SELECT nofaktur FROM faktur ORDER BY nofaktur DESC"
        dr = db.exeReader(q)
        If dr.Read Then
            Return Format(Val(dr.GetString(0).Substring(2, 6)) + 1, "FR0#####")
        End If
        Return "FR000001"
    End Function

    Public Function insert() As Boolean
        q = "INSERT INTO faktur VALUES('" & noFaktur & "','" & tglFaktur & "','" & noSp & "')"
        If db.exeNonQuery(q) Then
            Return True
        End If
        Return False
    End Function

    Public Sub getByKey(ByVal field As String, ByVal keyValue As String)
        q = "SELECT * FROM faktur WHERE " & field & "='" & keyValue & "'"
        dr = db.exeReader(q)
        If dr.Read Then
            noFaktur = dr.GetString(0)
            tglFaktur = dr.GetDateTime(1)
            noSp = dr.GetString(2)
        Else
            noFaktur = String.Empty
            tglFaktur = Nothing
            noSp = String.Empty
        End If
    End Sub

    Public Function recordExist() As Boolean
        q = "SELECT * FROM faktur WHERE nofaktur='" & noFaktur & "'"
        dr = db.exeReader(q)
        If dr.Read Then
            Return True
        End If
        Return False
    End Function

    Public Function inSJ() As Boolean
        q = "SELECT * FROM faktur WHERE nofaktur IN(SELECT nofaktur FROM sj)" & _
            " AND faktur.nofaktur='" & noFaktur & "'"
        dr = db.exeReader(q)
        If dr.Read Then
            Return True
        End If
        Return False
    End Function

    Public Function inKwitansi() As Boolean
        q = "SELECT * FROM faktur WHERE nofaktur IN(SELECT nofaktur FROM kwitansi)" & _
            " AND faktur.nofaktur='" & noFaktur & "'"
        dr = db.exeReader(q)
        If dr.Read Then
            Return True
        End If
        Return False
    End Function

    Public Function arrAll() As ArrayList
        q = "SELECT * FROM faktur"
        Dim arrLst As New ArrayList
        dr = db.exeReader(q)
        If Not dr Is Nothing Then
            While dr.Read
                Dim objData As New Faktur
                With objData
                    .noFaktur = dr.GetString(0)
                    .tglFaktur = dr.GetDateTime(1)
                    .noSp = dr.GetString(2)
                End With
                arrLst.Add(objData)
            End While
        End If
        Return arrLst
    End Function

    Public Function arrByPrefix(ByVal field As String, ByVal keyValue As String) As ArrayList
        q = "SELECT * FROM faktur WHERE " & field & " LIKE '" & keyValue & "%'"
        Dim arrLst As New ArrayList
        dr = db.exeReader(q)
        If Not dr Is Nothing Then
            While dr.Read
                Dim objData As New Faktur
                With objData
                    .noFaktur = dr.GetString(0)
                    .tglFaktur = dr.GetDateTime(1)
                    .noSp = dr.GetString(2)
                End With
                arrLst.Add(objData)
            End While
        End If
        Return arrLst
    End Function

    Public Function tblByPK() As DataTable
        q = "SELECT faktur.nofaktur,faktur.tglfaktur,pesanan.nosp,pesanan.tglsp," & _
            " pelanggan.nmplg,pelanggan.alamat,barang.nmbrg,isi.hrgpsn,isi.jmlpsn" & _
            " FROM faktur,pesanan,isi,pelanggan,barang" & _
            " WHERE faktur.nosp=pesanan.nosp AND pesanan.nosp=isi.nosp" & _
            " AND pesanan.kdplg=pelanggan.kdplg and isi.kdbrg=barang.kdbrg" & _
            " AND faktur.nofaktur = '" & noFaktur & "'"
        Dim tbl As New DataTable
        da = db.adapter(q)
        da.Fill(tbl)
        Return tbl
    End Function
End Class
