Public Class DetalleVenta

    Protected _codVenta As Integer
    Protected _codProducto As Integer
    Protected _cantidad As Integer
    Protected _precio As Integer

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(codVenta As Integer, codProducto As Integer, cantidad As Integer, precio As Integer)
        MyBase.New()
        _codVenta = codVenta
        _codProducto = codProducto
        _cantidad = cantidad
        _precio = precio
    End Sub

    Public Property CodVenta As Integer
        Get
            Return _codVenta
        End Get
        Set(value As Integer)
            _codVenta = value
        End Set
    End Property

    Public Property CodProducto As Integer
        Get
            Return _codProducto
        End Get
        Set(value As Integer)
            _codProducto = value
        End Set
    End Property

    Public Property Cantidad As Integer
        Get
            Return _cantidad
        End Get
        Set(value As Integer)
            _cantidad = value
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
End Class
