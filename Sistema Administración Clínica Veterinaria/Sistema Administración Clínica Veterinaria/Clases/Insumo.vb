Public Class Insumo

    Protected _codAtencion As Integer
    Protected _codProducto As Integer
    Protected _cantidad As Double
    Protected _precio As Integer

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(codAtencion As Integer, codProducto As Integer, cantidad As Double, precio As Integer)
        MyBase.New()
        _codAtencion = codAtencion
        _codProducto = codProducto
        _cantidad = cantidad
        _precio = precio
    End Sub

    Public Property CodAtencion As Integer
        Get
            Return _codAtencion
        End Get
        Set(value As Integer)
            _codAtencion = value
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

    Public Property Cantidad As Double
        Get
            Return _cantidad
        End Get
        Set(value As Double)
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
