Option Strict On
Public Class SJ
    Private _noSj As String, _tglSj As Date, _noPol, _noFaktur As String

    Public Property noSj() As String
        Get
            Return _noSj
        End Get
        Set(ByVal value As String)
            _noSj = value
        End Set
    End Property

    Public Property tglSj() As Date
        Get
            Return _tglSj
        End Get
        Set(ByVal value As Date)
            _tglSj = value
        End Set
    End Property

    Public Property noPol() As String
        Get
            Return _noPol
        End Get
        Set(ByVal value As String)
            _noPol = value
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
