Option Strict On
Public Class Jurnal
    Private _noBukti, _kdRek As String
    Private _tglBukti As Date
    Private _jumlah As Double, _posisi As String

    Public Property noBukti() As String
        Get
            Return _noBukti
        End Get
        Set(ByVal value As String)
            _noBukti = value
        End Set
    End Property

    Public Property kdRek() As String
        Get
            Return _kdRek
        End Get
        Set(ByVal value As String)
            _kdRek = value
        End Set
    End Property

    Public Property tglBukti() As Date
        Get
            Return _tglBukti
        End Get
        Set(ByVal value As Date)
            _tglBukti = value
        End Set
    End Property

    Public Property jumlah() As Double
        Get
            Return _jumlah
        End Get
        Set(ByVal value As Double)
            _jumlah = value
        End Set
    End Property

    Public Property posisi() As String
        Get
            Return _posisi
        End Get
        Set(ByVal value As String)
            _posisi = value
        End Set
    End Property
End Class
