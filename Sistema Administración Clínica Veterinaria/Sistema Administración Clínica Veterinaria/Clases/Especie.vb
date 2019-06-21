Public Class Especie

    Protected _idEspecie As Integer
    Protected _nomEspecie As String
    Protected _estado As Integer

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(idEspecie As Integer, nomEspecie As String, estado As Integer)
        MyBase.New()
        _idEspecie = idEspecie
        _nomEspecie = nomEspecie
        _estado = estado
    End Sub

    Public Property IdEspecie As Integer
        Get
            Return _idEspecie
        End Get
        Set(value As Integer)
            _idEspecie = value
        End Set
    End Property

    Public Property NomEspecie As String
        Get
            Return _nomEspecie
        End Get
        Set(value As String)
            _nomEspecie = value
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
