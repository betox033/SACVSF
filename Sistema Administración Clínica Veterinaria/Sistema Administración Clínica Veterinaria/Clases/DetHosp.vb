Public Class DetHosp

    Protected _idHosp As Integer
    Protected _codProducto As Integer
    Protected _periodicidad As Integer
    Protected _dosis As Double
    Protected _cantidad As Double
    Protected _precio As Integer

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(idHosp As Integer, codProducto As Integer, periodicidad As Integer, dosis As Double,
                   cantidad As Double, precio As Integer)
        MyBase.New()
    End Sub

    Public Property IdHosp As Integer
        Get
            Return _idHosp
        End Get
        Set(value As Integer)
            _idHosp = value
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

    Public Property Periodicidad As Integer
        Get
            Return _periodicidad
        End Get
        Set(value As Integer)
            _periodicidad = value
        End Set
    End Property

    Public Property Dosis As Double
        Get
            Return _dosis
        End Get
        Set(value As Double)
            _dosis = value
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
