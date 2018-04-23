Option Strict On
Public Class SubKategori
    Private _kdSub, _nmSub, _kdKategori As String

    Public Property kdSub() As String
        Get
            Return _kdSub
        End Get
        Set(ByVal value As String)
            _kdSub = value
        End Set
    End Property

    Public Property nmSub() As String
        Get
            Return _nmSub
        End Get
        Set(ByVal value As String)
            _nmSub = value
        End Set
    End Property

    Public Property kdKategori() As String
        Get
            Return _kdKategori
        End Get
        Set(ByVal value As String)
            _kdKategori = value
        End Set
    End Property
End Class
