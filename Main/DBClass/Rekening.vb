Option Strict On
Public Class Rekening
    Private _kdRek, _nmRek As String

    Public Property kdRek() As String
        Get
            Return _kdRek
        End Get
        Set(ByVal value As String)
            _kdRek = value
        End Set
    End Property

    Public Property nmRek() As String
        Get
            Return _nmRek
        End Get
        Set(ByVal value As String)
            _nmRek = value
        End Set
    End Property
End Class
