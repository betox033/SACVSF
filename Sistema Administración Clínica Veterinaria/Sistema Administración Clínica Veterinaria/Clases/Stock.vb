Public Class Stock

    Protected _codProducto As Integer
    Protected _cantTotal As Double
    Protected _cantActual As Double
    Protected _numFrascos As Integer

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(codProducto As Integer, cantTotal As Double, cantActual As Double, numFrascos As Integer)
        MyBase.New()
        _codProducto = codProducto
        _cantTotal = cantTotal
        _cantActual = _cantActual
        _numFrascos = numFrascos
    End Sub

    Public Property Codproducto As Integer
        Get
            Return _codProducto
        End Get
        Set(value As Integer)
            _codProducto = value
        End Set
    End Property

    Public Property CantTotal As Double
        Get
            Return _cantTotal
        End Get
        Set(value As Double)
            _cantTotal = value
        End Set
    End Property

    Public Property CantActual As Double
        Get
            Return _cantActual
        End Get
        Set(value As Double)
            _cantActual = value
        End Set
    End Property

    Public Property NumFrascos As Integer
        Get
            Return _numFrascos
        End Get
        Set(value As Integer)
            _numFrascos = value
        End Set
    End Property


End Class
