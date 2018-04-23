Option Strict On
Public Class Kendaraan
    Private _noPol, _merkKend, _jmlRoda, _bhnBakar As String

    Public Property noPol() As String
        Get
            Return _noPol
        End Get
        Set(ByVal value As String)
            _noPol = value
        End Set
    End Property

    Public Property merkKend() As String
        Get
            Return _merkKend
        End Get
        Set(ByVal value As String)
            _merkKend = value
        End Set
    End Property

    Public Property jmlRoda() As String
        Get
            Return _jmlRoda
        End Get
        Set(ByVal value As String)
            _jmlRoda = value
        End Set
    End Property

    Public Property bhnBakar() As String
        Get
            Return _bhnBakar
        End Get
        Set(ByVal value As String)
            _bhnBakar = value
        End Set
    End Property
End Class
