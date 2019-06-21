Public Class Ajuste

    Protected _codProducto As Integer
    Protected _fechaHora As String
    Protected _tipoAjuste As Char
    Protected _cantidad As Double

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(codProducto As Integer, fechaHora As String, tipoAjuste As Char, cantidad As Double)
        MyBase.New()
        _codProducto = codProducto
        _fechaHora = fechaHora
        _tipoAjuste = tipoAjuste
        _cantidad = cantidad
    End Sub

    Public Property Codproducto As Integer
        Get
            Return _codProducto
        End Get
        Set(value As Integer)
            _codProducto = value
        End Set
    End Property

    Public Property FechaHora As String
        Get
            Return _fechaHora
        End Get
        Set(value As String)
            _fechaHora = value
        End Set
    End Property

    Public Property TipoAjuste As Char
        Get
            Return _tipoAjuste
        End Get
        Set(value As Char)
            _tipoAjuste = value
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

End Class
