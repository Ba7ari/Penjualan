Option Strict On
Public Class Pesanan
    Private _noSp As String, _tglSp As Date, _kdPlg As String

    Public Property noSp() As String
        Get
            Return _noSp
        End Get
        Set(ByVal value As String)
            _noSp = value
        End Set
    End Property

    Public Property tglSp() As Date
        Get
            Return _tglSp
        End Get
        Set(ByVal value As Date)
            _tglSp = value
        End Set
    End Property

    Public Property kdPlg() As String
        Get
            Return _kdPlg
        End Get
        Set(ByVal value As String)
            _kdPlg = value
        End Set
    End Property
End Class
