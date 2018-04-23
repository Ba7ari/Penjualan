Option Strict On
Public Class Barang
    Private _kdBrg, _nmBrg, _satuan As String
    Private _harga, _stok As Integer, _kdSub As String

    Public Property kdBrg() As String
        Get
            Return _kdBrg
        End Get
        Set(ByVal value As String)
            _kdBrg = value
        End Set
    End Property

    Public Property nmBrg() As String
        Get
            Return _nmBrg
        End Get
        Set(ByVal value As String)
            _nmBrg = value
        End Set
    End Property

    Public Property satuan() As String
        Get
            Return _satuan
        End Get
        Set(ByVal value As String)
            _satuan = value
        End Set
    End Property

    Public Property harga() As Integer
        Get
            Return _harga
        End Get
        Set(ByVal value As Integer)
            _harga = value
        End Set
    End Property

    Public Property stok() As Integer
        Get
            Return _stok
        End Get
        Set(ByVal value As Integer)
            _stok = value
        End Set
    End Property

    Public Property kdSub() As String
        Get
            Return _kdSub
        End Get
        Set(ByVal value As String)
            _kdSub = value
        End Set
    End Property
End Class
