Public Class ListaBusqueda

    Protected _idFicha As String
    Protected _nomMascota As String
    Protected _especie As String
    Protected _raza As String
    Protected _cliente As String

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(idFicha As String, nomMascota As String, especie As String, raza As String, cliente As String)
        MyBase.New()
        _idFicha = idFicha
        _nomMascota = nomMascota
        _especie = especie
        _raza = raza
        _cliente = cliente
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

    Public Property Especie As String
        Get
            Return _especie
        End Get
        Set(value As String)
            _especie = value
        End Set
    End Property

    Public Property Raza As String
        Get
            Return _raza
        End Get
        Set(value As String)
            _raza = value
        End Set
    End Property

    Public Property Cliente As String
        Get
            Return _cliente
        End Get
        Set(value As String)
            _cliente = value
        End Set
    End Property

End Class
