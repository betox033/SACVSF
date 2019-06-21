Public Class Proveedor

    Protected _idProveedor As Integer
    Protected _nomProveedor As String
    Protected _fonoProveedor As String
    Protected _dirProveedor As String
    Protected _estado As Boolean

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(idProveedor As Integer, nomProveedor As String, fonoProveedor As String, dirproveedor As String,
                   estado As Boolean)
        MyBase.New()
        _idProveedor = idProveedor
        _nomProveedor = nomProveedor
        _fonoProveedor = fonoProveedor
        _dirProveedor = dirproveedor
        _estado = estado
    End Sub

    Public Property IdProveedor As Integer
        Get
            Return _idProveedor
        End Get
        Set(value As Integer)
            _idProveedor = value
        End Set
    End Property

    Public Property NomProveedor As String
        Get
            Return _nomProveedor
        End Get
        Set(value As String)
            _nomProveedor = value
        End Set
    End Property

    Public Property FonoProveedor As String
        Get
            Return _fonoProveedor
        End Get
        Set(value As String)
            _fonoProveedor = value
        End Set
    End Property

    Public Property DirProveedor As String
        Get
            Return _dirProveedor
        End Get
        Set(value As String)
            _dirProveedor = value
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
