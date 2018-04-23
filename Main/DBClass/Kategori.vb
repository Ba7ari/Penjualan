Option Strict On
Public Class Kategori
    Private _kdKategori, _nmKategori As String

    Public Property kdKategori() As String
        Get
            Return _kdKategori
        End Get
        Set(ByVal value As String)
            _kdKategori = value
        End Set
    End Property

    Public Property nmKategori() As String
        Get
            Return _nmKategori
        End Get
        Set(ByVal value As String)
            _nmKategori = value
        End Set
    End Property
End Class
