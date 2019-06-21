Public Class Atencion

    Protected _codAtencion As Integer
    Protected _idFicha As String
    Protected _numVeterinario As Integer
    Protected _fechaAtencion As String
    Protected _tipoAtencion As Char
    Protected _peso As Integer
    Protected _altura As Double
    Protected _temperatura As Double
    Protected _descripcion As String
    Protected _costo As Integer
    Protected _estado As Boolean
    Protected _correoEnviado As Boolean

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(codAtencion As Integer, idFicha As String, numVeterinario As Integer,
                   fechaAtencion As String, tipoAtencion As Char, peso As Integer, altura As Double,
                   temperatura As Double, descripcion As String, costo As Integer, estado As Boolean,
                   correoEnviado As Boolean)
        MyBase.New()
        _codAtencion = codAtencion
        _idFicha = idFicha
        _numVeterinario = numVeterinario
        _fechaAtencion = fechaAtencion
        _tipoAtencion = tipoAtencion
        _peso = peso
        _altura = altura
        _temperatura = temperatura
        _descripcion = descripcion
        _costo = costo
        _estado = estado
        _correoEnviado = correoEnviado
    End Sub

    Public Sub New(codAtencion As Integer, numVeterinario As Integer, fechaAtencion As String, peso As Integer, altura As Double, temperatura As Double, descripcion As String, costo As Integer)
        MyBase.New()
        _codAtencion = codAtencion
        _numVeterinario = numVeterinario
        _fechaAtencion = fechaAtencion
        _peso = peso
        _altura = altura
        _temperatura = temperatura
        _descripcion = descripcion
        _costo = costo
    End Sub

    Public Property CodAtencion As Integer
        Get
            Return _codAtencion
        End Get
        Set(value As Integer)
            _codAtencion = value
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

    Public Property NumVeterinario As Integer
        Get
            Return _numVeterinario
        End Get
        Set(value As Integer)
            _numVeterinario = value
        End Set
    End Property

    Public Property FechaAtencion As String
        Get
            Return _fechaAtencion
        End Get
        Set(value As String)
            _fechaAtencion = value
        End Set
    End Property

    Public Property TipoAtencion As Char
        Get
            Return _tipoAtencion
        End Get
        Set(value As Char)
            _tipoAtencion = value
        End Set
    End Property

    Public Property Peso As Integer
        Get
            Return _peso
        End Get
        Set(value As Integer)
            _peso = value
        End Set
    End Property

    Public Property Altura As Double
        Get
            Return _altura
        End Get
        Set(value As Double)
            _altura = value
        End Set
    End Property

    Public Property Temperatura As Double
        Get
            Return _temperatura
        End Get
        Set(value As Double)
            _temperatura = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Costo As String
        Get
            Return _costo
        End Get
        Set(value As String)
            _costo = value
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

    Public Property CorreoEnviado As Boolean
        Get
            Return _correoEnviado
        End Get
        Set(value As Boolean)
            _correoEnviado = value
        End Set
    End Property

End Class
