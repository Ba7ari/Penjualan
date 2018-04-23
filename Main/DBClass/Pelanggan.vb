Option Strict On
Public Class Pelanggan
    Private _kdPlg, _nmPlg, _alamat, _telp As String

    Public Property kdPlg() As String
        Get
            Return _kdPlg
        End Get
        Set(ByVal value As String)
            _kdPlg = value
        End Set
    End Property

    Public Property nmPlg() As String
        Get
            Return _nmPlg
        End Get
        Set(ByVal value As String)
            _nmPlg = value
        End Set
    End Property

    Public Property alamat() As String
        Get
            Return _alamat
        End Get
        Set(ByVal value As String)
            _alamat = value
        End Set
    End Property

    Public Property telp() As String
        Get
            Return _telp
        End Get
        Set(ByVal value As String)
            _telp = value
        End Set
    End Property
End Class
