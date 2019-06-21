Public Class Mascota

    Protected _idFicha As String
    Protected _nomMascota As String
    Protected _idCliente As Integer
    Protected _fechaNacimiento As String
    Protected _idRaza As String
    Protected _sexo As Char
    Protected _color As String
    Protected _fechaIngreso As String
    Protected _status As Boolean
    Protected _idChip As String

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(idFicha As String, nomMascota As String, idCliente As Integer, fechaNacimiento As String, id_raza As Integer, sexo As String, color As String, fechaIngreso As String, status As Boolean, idChip As String)
        MyBase.New()
        _idFicha = idFicha
        _nomMascota = nomMascota
        _idCliente = idCliente
        _fechaNacimiento = fechaNacimiento
        _idRaza = id_raza
        _sexo = sexo
        _color = color
        _fechaIngreso = fechaIngreso
        _status = status
        _idChip = idChip
    End Sub

    Public Property IdFicha As String
        Get
            Return _idFicha
        End Get
        Set(value As String)
            _idFicha = value
        End Set
    End Property

    Public Property NomMascota As String
        Get
            Return _nomMascota
        End Get
        Set(value As String)
            _nomMascota = value
        End Set
    End Property

    Public Property IdCliente As Integer
        Get
            Return _idCliente
        End Get
        Set(value As Integer)
            _idCliente = value
        End Set
    End Property

    Public Property FechaNacimiento As String
        Get
            Return _fechaNacimiento
        End Get
        Set(value As String)
            _fechaNacimiento = value
        End Set
    End Property

    Public Property IdRaza As Integer
        Get
            Return _idRaza
        End Get
        Set(value As Integer)
            _idRaza = value
        End Set
    End Property

    Public Property Sexo As Char
        Get
            Return _sexo
        End Get
        Set(value As Char)
            _sexo = value
        End Set
    End Property

    Public Property Color As String
        Get
            Return _color
        End Get
        Set(value As String)
            _color = value
        End Set
    End Property

    Public Property FechaIngreso As String
        Get
            Return _fechaIngreso
        End Get
        Set(value As String)
            _fechaIngreso = value
        End Set
    End Property

    Public Property Status As Boolean
        Get
            Return _status
        End Get
        Set(value As Boolean)
            _status = value
        End Set
    End Property

    Public Property IdChip As String
        Get
            Return _idChip
        End Get
        Set(value As String)
            _idChip = value
        End Set
    End Property





End Class
