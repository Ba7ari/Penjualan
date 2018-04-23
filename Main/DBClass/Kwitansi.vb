Option Strict On
Public Class Kwitansi
    Private _noKwt As String, _tglKwt As Date, _noFaktur As String

    Public Property noKwt() As String
        Get
            Return _noKwt
        End Get
        Set(ByVal value As String)
            _noKwt = value
        End Set
    End Property

    Public Property tglKwt() As Date
        Get
            Return _tglKwt
        End Get
        Set(ByVal value As Date)
            _tglKwt = value
        End Set
    End Property

    Public Property noFaktur() As String
        Get
            Return _noFaktur
        End Get
        Set(ByVal value As String)
            _noFaktur = value
        End Set
    End Property
End Class
