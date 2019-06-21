Public Class Producto

    Protected _codProducto As Integer
    Protected _nomProducto As String
    Protected _tipoProducto As Char
    Protected _codProveedor As Integer
    Protected _precio As Integer
    Protected _stockCritico As Integer
    Protected _stock As Integer
    Protected _unidad As String
    Protected _estado As Boolean

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(codProducto As Integer, nomProducto As String, tipoProducto As Char, codProveedor As Integer,
                   precio As Integer, stockCritico As Integer, stock As Integer, unidad As String, estado As Boolean)
        MyBase.New()
        _codProducto = codProducto
        _nomProducto = nomProducto
        _tipoProducto = tipoProducto
        _codProveedor = codProveedor
        _precio = precio
        _stockCritico = stockCritico
        _stock = stock
        _unidad = unidad
        _estado = estado
    End Sub

    Public Property CodProducto As Integer
        Get
            Return _codProducto
        End Get
        Set(value As Integer)
            _codProducto = value
        End Set
    End Property

    Public Property NomProducto As String
        Get
            Return _nomProducto
        End Get
        Set(value As String)
            _nomProducto = value
        End Set
    End Property

    Public Property TipoProducto As Char
        Get
            Return _tipoProducto
        End Get
        Set(value As Char)
            _tipoProducto = value
        End Set
    End Property

    Public Property CodProveedor As Integer
        Get
            Return _codProveedor
        End Get
        Set(value As Integer)
            _codProveedor = value
        End Set
    End Property

    Public Property Precio As Integer
        Get
            Return _precio
        End Get
        Set(value As Integer)
            _precio = value
        End Set
    End Property

    Public Property StockCritico As Integer
        Get
            Return _stockCritico
        End Get
        Set(value As Integer)
            _stockCritico = value
        End Set
    End Property

    Public Property Stock As Integer
        Get
            Return _stock
        End Get
        Set(value As Integer)
            _stock = value
        End Set
    End Property

    Public Property Unidad As String
        Get
            Return _unidad
        End Get
        Set(value As String)
            _unidad = value
        End Set
    End Property

    Public Property Estado As Boolean
        Get
            Return _estado
        End Get
        Set(value As Boolean)
            _estado = value
        End Set
    End Property


End Class
