Public Class Cliente

    Protected _numCliente As Integer
    Protected _rut As String
    Protected _nombre As String
    Protected _direccionCliente As String
    Protected _fonoCliente As String
    Protected _correo As String
    Protected _estado As Boolean

    Public Sub New()
        MyBase.New()
        _estado = True
    End Sub

    Public Sub New(numCliente As Integer, rut As String, nombre As String, direccionCliente As String, fonoCliente As String, correo As String)
        MyBase.New()
        _numCliente = numCliente
        _rut = rut
        _nombre = nombre
        _direccionCliente = direccionCliente
        _fonoCliente = fonoCliente
        _correo = correo
        _estado = True
    End Sub

    Public Property NumCliente As Integer
        Get
            Return _numCliente
        End Get
        Set(value As Integer)
            _numCliente = value
        End Set
    End Property

    Public Property Rut As String
        Get
            Return _rut
        End Get
        Set(value As String)
            _rut = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property DireccionCliente As String
        Get
            Return _direccionCliente
        End Get
        Set(value As String)
            _direccionCliente = value
        End Set
    End Property

    Public Property FonoCliente As String
        Get
            Return _fonoCliente
        End Get
        Set(value As String)
            _fonoCliente = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
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
