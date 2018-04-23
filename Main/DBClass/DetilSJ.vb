Option Strict On
Public Class DetilSJ
    Private _noSj, _kdBrg, _keterangan As String, _jmlKirim As Integer

    Public Property noSj() As String
        Get
            Return _noSj
        End Get
        Set(ByVal value As String)
            _noSj = value
        End Set
    End Property

    Public Property kdBrg() As String
        Get
            Return _kdBrg
        End Get
        Set(ByVal value As String)
            _kdBrg = value
        End Set
    End Property

    Public Property jmlKirim() As Integer
        Get
            Return _jmlKirim
        End Get
        Set(ByVal value As Integer)
            _jmlKirim = value
        End Set
    End Property

    Public Property keterangan() As String
        Get
            Return _keterangan
        End Get
        Set(ByVal value As String)
            _keterangan = value
        End Set
    End Property
End Class
