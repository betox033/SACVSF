Public Class Veterinario

    Protected _numVeterinario As Integer
    Protected _rutVeterinario As String
    Protected _nomVeterinario As String
    Protected _fonoVeterinario As String
    Protected _estado As Boolean

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(numVeterinario As Integer, rutVeterinario As String, nomVeterinario As String,
                   fonoVeterinario As String, estado As Boolean)
        MyBase.New()
        _numVeterinario = numVeterinario
        _rutVeterinario = rutVeterinario
        _nomVeterinario = nomVeterinario
        _fonoVeterinario = fonoVeterinario
        _estado = estado
    End Sub

    Public Property NumVeterinario As Integer
        Get
            Return _numVeterinario
        End Get
        Set(value As Integer)
            _numVeterinario = value
        End Set
    End Property

    Public Property RutVeterinario As String
        Get
            Return _rutVeterinario
        End Get
        Set(value As String)
            _rutVeterinario = value
        End Set
    End Property

    Public Property NomVeterinario As String
        Get
            Return _nomVeterinario
        End Get
        Set(value As String)
            _nomVeterinario = value
        End Set
    End Property

    Public Property FonoVeterinario As String
        Get
            Return _fonoVeterinario
        End Get
        Set(value As String)
            _fonoVeterinario = value
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
