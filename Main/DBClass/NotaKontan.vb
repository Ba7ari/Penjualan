Option Strict On
Public Class NotaKontan
    Private _noNk As String, _tglNk As Date

    Public Property noNk() As String
        Get
            Return _noNk
        End Get
        Set(ByVal value As String)
            _noNk = value
        End Set
    End Property

    Public Property tglNk() As Date
        Get
            Return _tglNk
        End Get
        Set(ByVal value As Date)
            _tglNk = value
        End Set
    End Property
End Class
