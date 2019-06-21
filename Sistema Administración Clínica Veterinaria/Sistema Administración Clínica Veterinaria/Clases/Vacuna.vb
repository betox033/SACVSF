Public Class Vacuna

    Protected _numVacuna As Integer
    Protected _idFicha As String
    Protected _codProducto As Integer
    Protected _nOrdinal As Integer
    Protected _dosis As Double
    Protected _fechaVacuna As String
    Protected _fechaProxVacuna As String
    Protected _correoEnviado As Boolean

    Public Sub New()
        MyBase.New
    End Sub

    Public Sub New(numVacuna As Integer, idFicha As String, codProducto As Integer, nOrdinal As Integer,
                   dosis As Double, fechaVacuna As String, fechaProxVacuna As String, correoEnviado As Boolean)
        MyBase.New
        _numVacuna = numVacuna
        _idFicha = idFicha
        _codProducto = codProducto
        _nOrdinal = nOrdinal
        _dosis = dosis
        _fechaVacuna = fechaVacuna
        _fechaProxVacuna = fechaProxVacuna
        _correoEnviado = correoEnviado
    End Sub

    Public Property NumVacuna As Integer
        Get
            Return _numVacuna
        End Get
        Set(value As Integer)
            _numVacuna = value
        End Set
    End Property

    Public Property IdFicha As String
        Get
            Return _idFicha
        End Get
        Set(value As String)
            _idFicha = value
        End Set
    End Property

    Public Property Codproducto As Integer
        Get
            Return _codProducto
        End Get
        Set(value As Integer)
            _codProducto = value
        End Set
    End Property

    Public Property NOrdinal As Integer
        Get
            Return _nOrdinal
        End Get
        Set(value As Integer)
            _nOrdinal = value
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

    Public Property FechaVacuna As String
        Get
            Return _fechaVacuna
        End Get
        Set(value As String)
            _fechaVacuna = value
        End Set
    End Property

    Public Property FechaProxVacuna As String
        Get
            Return _fechaProxVacuna
        End Get
        Set(value As String)
            _fechaProxVacuna = value
        End Set
    End Property

    Public Property CorreoEnviado As Boolean
        Get
            Return _correoEnviado
        End Get
        Set(value As Boolean)
            _correoEnviado = value
        End Set
    End Property

End Class
