Option Strict On
Public Class Faktur
    Private _noFaktur As String, _tglFaktur As Date, _noSp As String

    Public Property noFaktur() As String
        Get
            Return _noFaktur
        End Get
        Set(ByVal value As String)
            _noFaktur = value
        End Set
    End Property

    Public Property tglFaktur() As Date
        Get
            Return _tglFaktur
        End Get
        Set(ByVal value As Date)
            _tglFaktur = value
        End Set
    End Property

    Public Property noSp() As String
        Get
            Return _noSp
        End Get
        Set(ByVal value As String)
            _noSp = value
        End Set
    End Property
End Class
