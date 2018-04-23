Option Strict On
Imports System.Data.OleDb
Public Class ctlDetilPesanan
    Inherits DetilPesanan
    Private db As New DBConnection
    Private cmd As OleDbCommand
    Private dr As OleDbDataReader
    Private q As String

    Public Sub insert()
        q = "INSERT INTO isi VALUES('" & noSp & "','" & kdBrg & "','" & hrgPsn & "','" & jmlPsn & "')"
        db.exeNonQuery(q)
    End Sub

    Public Sub updateJmlPsn()
        q = "UPDATE isi SET jmlpsn='" & jmlPsn & "' WHERE nosp='" & noSp & "' AND kdbrg='" & kdBrg & "'"
        db.exeNonQuery(q)
    End Sub

    Public Sub getByCK()
        q = "SELECT * FROM isi WHERE nosp='" & noSp & "' AND kdbrg='" & kdBrg & "'"
        dr = db.exeReader(q)
        If dr.Read Then
            noSp = dr.GetString(0)
            kdBrg = dr.GetString(1)
            hrgPsn = dr.GetInt32(2)
            jmlPsn = dr.GetInt32(3)
        Else
            noSp = String.Empty
            kdBrg = String.Empty
            hrgPsn = 0
            jmlPsn = 0
        End If
    End Sub

    Public Function recordExist() As Boolean
        q = "SELECT * FROM isi WHERE nosp='" & noSp & "' AND kdbrg='" & kdBrg & "'"
        dr = db.exeReader(q)
        If dr.Read Then
            Return True
        End If
        Return False
    End Function

    Public Function arrByKey(ByVal field As String, ByVal keyValue As String) As ArrayList
        q = "SELECT * FROM isi WHERE " & field & "='" & keyValue & "'"
        Dim arrLst As New ArrayList
        dr = db.exeReader(q)
        If Not dr Is Nothing Then
            While dr.Read
                Dim objData As New DetilPesanan
                With objData
                    .noSp = dr.GetString(0)
                    .kdBrg = dr.GetString(1)
                    .hrgPsn = dr.GetInt32(2)
                    .jmlPsn = dr.GetInt32(3)
                End With
                arrLst.Add(objData)
            End While
        End If
        Return arrLst
    End Function

    Public Function arrByFK() As ArrayList
        q = "SELECT isi.nosp,isi.kdbrg,barang.nmbrg,isi.hrgpsn,isi.jmlpsn" & _
            " FROM isi,barang WHERE isi.kdbrg=barang.kdbrg AND nosp = '" & noSp & "'"
        Dim arrLst As New ArrayList
        dr = db.exeReader(q)
        If Not dr Is Nothing Then
            While dr.Read
                Dim objData As New DetilPesanan
                With objData
                    .noSp = dr.GetString(0)
                    .kdBrg = dr.GetString(1)
                    .nmBrg = dr.GetString(2)
                    .hrgPsn = dr.GetInt32(3)
                    .jmlPsn = dr.GetInt32(4)
                End With
                arrLst.Add(objData)
            End While
        End If
        Return arrLst
    End Function
End Class
