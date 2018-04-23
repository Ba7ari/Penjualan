Option Strict On
Public Class DetilNotaKontan
    Private _noNk, _kdBrg As String
    Private _hrgBeli, _jmlBeli As Integer

    Public Property noNk() As String
        Get
            Return _noNk
        End Get
        Set(ByVal value As String)
            _noNk = value
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

    Public Property hrgBeli() As Integer
        Get
            Return _hrgBeli
        End Get
        Set(ByVal value As Integer)
            _hrgBeli = value
        End Set
    End Property

    Public Property jmlBeli() As Integer
        Get
            Return _jmlBeli
        End Get
        Set(ByVal value As Integer)
            _jmlBeli = value
        End Set
    End Property
End Class
