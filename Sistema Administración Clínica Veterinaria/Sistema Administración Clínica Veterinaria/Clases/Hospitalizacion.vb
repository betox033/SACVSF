Public Class Hospitalizacion

    Protected _idHosp As Integer
    Protected _idFicha As String
    Protected _fechaHosp As Date
    Protected _fechaSalida As Date
    Protected _descripcion As String
    Protected _total As Integer
    Protected _valorConsulta As Integer
    Protected _estado As Boolean

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(idHosp As Integer, idFicha As String, fechaHosp As Date, fechaSalida As Date,
                   descripcion As String, total As Integer, valorConsulta As Integer, estado As Boolean)
        MyBase.New()
        _idHosp = idHosp
        _idFicha = idFicha
        _fechaHosp = fechaHosp
        _fechaSalida = fechaSalida
        _descripcion = descripcion
        _total = total
        _valorConsulta = valorConsulta
        _estado = estado
    End Sub

    Public Property IdHosp As Integer
        Get
            Return _idHosp
        End Get
        Set(value As Integer)
            _idHosp = value
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

    Public Property FechaHosp As Date
        Get
            Return _fechaHosp
        End Get
        Set(value As Date)
            _fechaHosp = Format(value, "yyyy-MM-dd")
        End Set
    End Property

    Public Property FechaSalida As Date
        Get
            Return _fechaSalida
        End Get
        Set(value As Date)
            _fechaSalida = Format(value, "yyyy-MM-dd")
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

    Public Property Total As Integer
        Get
            Return _total
        End Get
        Set(value As Integer)
            _total = value
        End Set
    End Property

    Public Property ValorConsulta As Integer
        Get
            Return _valorConsulta
        End Get
        Set(value As Integer)
            _valorConsulta = value
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
