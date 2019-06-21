Public Class Raza

    Protected _idRaza As Integer
    Protected _idEspecie As Integer
    Protected _nomRaza As String
    Protected _estado As Integer

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(idRaza As Integer, idEspecie As Integer, nomRaza As String, estado As Integer)
        MyBase.New()
        _idRaza = idRaza
        _idEspecie = idEspecie
        _nomRaza = nomRaza
        _estado = estado
    End Sub

    Public Property IdRaza As Integer
        Get
            Return _idRaza
        End Get
        Set(value As Integer)
            _idRaza = value
        End Set
    End Property

    Public Property IdEspecie As Integer
        Get
            Return _idEspecie
        End Get
        Set(value As Integer)
            _idEspecie = value
        End Set
    End Property

    Public Property NomRaza As String
        Get
            Return _nomRaza
        End Get
        Set(value As String)
            _nomRaza = value
        End Set
    End Property

    Public Property Estado As Integer
        Get
            Return _estado
        End Get
        Set(value As Integer)
            _estado = value
        End Set
    End Property

End Class
