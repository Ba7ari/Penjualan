Option Strict On
Imports System.Data.OleDb
Public Class ctlBarang
    Inherits Barang
    Private db As New DBConnection
    Private cmd As OleDbCommand
    Private dr As OleDbDataReader
    Private da As OleDbDataAdapter
    Private q As String
    Private _jmlJual As Integer

    Public WriteOnly Property jmlJual() As Integer
        Set(ByVal value As Integer)
            _jmlJual = value
        End Set
    End Property

    Public Function autoNum() As String
        q = "SELECT kdbrg FROM barang ORDER BY kdbrg DESC"
        dr = db.exeReader(q)
        If dr.Read Then
            Return Format(Val(dr.GetString(0).Substring(2, 5)) + 1, "BR0####")
        End If
        Return "BR00001"
    End Function

    Public Function insert() As Boolean
        q = "INSERT INTO barang VALUES('" & kdBrg & "','" & nmBrg & "','" & satuan & "','" & harga & "','" & stok & "','" & kdSub & "')"
        If db.exeNonQuery(q) Then
            Return True
        End If
        Return False
    End Function

    Public Function update() As Boolean
        q = "UPDATE barang SET nmbrg='" & nmBrg & "',satuan='" & satuan & "',harga='" & harga & "',stok='" & stok & "',kdsub='" & kdSub & "' WHERE kdbrg= '" & kdBrg & "'"
        If db.exeNonQuery(q) Then
            Return True
        End If
        Return False
    End Function

    Public Function delete() As Boolean
        q = "DELETE FROM barang WHERE kdbrg='" & kdBrg & "'"
        If db.exeNonQuery(q) Then
            Return True
        End If
        Return False
    End Function

    Public Sub updateStok()
        q = "UPDATE barang SET stok=stok - '" & _jmlJual & "' WHERE kdbrg= '" & kdBrg & "'"
        db.exeNonQuery(q)
    End Sub

    Public Sub getByKey(ByVal field As String, ByVal keyValue As String)
        q = "SELECT * FROM barang WHERE " & field & " = '" & keyValue & "'"
        dr = db.exeReader(q)
        If dr.Read Then
            kdBrg = dr.GetString(0)
            nmBrg = dr.GetString(1)
            satuan = dr.GetString(2)
            harga = dr.GetInt32(3)
            stok = dr.GetInt32(4)
            kdSub = dr.GetString(5)
        Else
            kdBrg = String.Empty
            nmBrg = String.Empty
            satuan = String.Empty
            harga = 0
            stok = 0
            kdSub = String.Empty
        End If
    End Sub

    Public Function recordExist() As Boolean
        q = "SELECT * FROM barang WHERE kdbrg='" & kdBrg & "'"
        dr = db.exeReader(q)
        If dr.Read Then
            Return True
        End If
        Return False
    End Function

    Public Function arrAll() As ArrayList
        q = "SELECT * FROM barang"
        Dim arrLst As New ArrayList
        dr = db.exeReader(q)
        If Not dr Is Nothing Then
            While dr.Read
                Dim objData As New Barang
                With objData
                    .kdBrg = dr.GetString(0)
                    .nmBrg = dr.GetString(1)
                    .satuan = dr.GetString(2)
                    .harga = dr.GetInt32(3)
                    .stok = dr.GetInt32(4)
                    .kdSub = dr.GetString(5)
                End With
                arrLst.Add(objData)
            End While
        End If
        Return arrLst
    End Function

    Public Function arrByPrefix(ByVal field As String, ByVal keyValue As String) As ArrayList
        q = "SELECT * FROM barang WHERE " & field & " LIKE '" & keyValue & "%'"
        Dim arrLst As New ArrayList
        dr = db.exeReader(q)
        If Not dr Is Nothing Then
            While dr.Read
                Dim objData As New Barang
                With objData
                    .kdBrg = dr.GetString(0)
                    .nmBrg = dr.GetString(1)
                    .satuan = dr.GetString(2)
                    .harga = dr.GetInt32(3)
                    .stok = dr.GetInt32(4)
                    .kdSub = dr.GetString(5)
                End With
                arrLst.Add(objData)
            End While
        End If
        Return arrLst
    End Function

    Public Function tblByKey(ByVal field As String, ByVal keyValue As String) As DataTable
        Dim tbl As New DataTable
        q = "SELECT * FROM barang WHERE " & field & " = '" & keyValue & "'"
        da = db.adapter(q)
        da.Fill(tbl)
        Return tbl
    End Function

    Public Function tblByPrefix(ByVal field As String, ByVal keyValue As String) As DataTable
        Dim tbl As New DataTable
        q = "SELECT * FROM barang WHERE " & field & " LIKE '" & keyValue & "%'"
        da = db.adapter(q)
        da.Fill(tbl)
        Return tbl
    End Function

    Public Function tblTopTen(ByVal tglAwal As Date, ByVal tglAkhir As Date) As DataTable
        q = "SELECT barang.kdbrg,barang.nmbrg,barang.satuan,subkategori.nmsub," & _
            " kategori.nmkategori,SUM(isi.jmlpsn) AS jmljual" & _
            " FROM barang,subkategori,kategori,pesanan,isi" & _
            " WHERE barang.kdsub=subkategori.kdsub AND subkategori.kdkategori=kategori.kdkategori" & _
            " AND barang.kdbrg=isi.kdbrg AND isi.nosp=pesanan.nosp" & _
            " AND pesanan.tglsp>=#" & tglAwal & "# AND pesanan.tglsp<=#" & tglAkhir & "#" & _
            " GROUP BY barang.kdbrg,barang.nmbrg,barang.satuan,subkategori.nmsub,kategori.nmkategori" & _
            " ORDER BY SUM(isi.jmlpsn) DESC"
        Dim tbl As New DataTable
        da = db.adapter(q)
        da.Fill(tbl)
        Return tbl
    End Function

    Public Function tblNotSaleable(ByVal tglAwal As Date, ByVal tglAkhir As Date) As DataTable
        q = "SELECT * FROM barang WHERE kdbrg NOT IN(SELECT barang.kdbrg FROM barang,isi,pesanan" & _
            " WHERE barang.kdbrg=isi.kdbrg AND isi.nosp=pesanan.nosp" & _
            " AND pesanan.tglsp>=#" & tglAwal & "# AND pesanan.tglsp<=#" & tglAkhir & "#)"
        Dim tbl As New DataTable
        da = db.adapter(q)
        da.Fill(tbl)
        Return tbl
    End Function
End Class
