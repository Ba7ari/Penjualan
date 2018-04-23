Option Strict On
Public Class DetilPesanan
    Private _noSp, _kdBrg, _nmBrg As String, _hrgPsn, _jmlPsn As Integer

    Public Property noSp() As String
        Get
            Return _noSp
        End Get
        Set(ByVal value As String)
            _noSp = value
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

    Public Property nmBrg() As String
        Get
            Return _nmBrg
        End Get
        Set(ByVal value As String)
            _nmBrg = value
        End Set
    End Property

    Public Property hrgPsn() As Integer
        Get
            Return _hrgPsn
        End Get
        Set(ByVal value As Integer)
            _hrgPsn = value
        End Set
    End Property

    Public Property jmlPsn() As Integer
        Get
            Return _jmlPsn
        End Get
        Set(ByVal value As Integer)
            _jmlPsn = value
        End Set
    End Property
End Class
