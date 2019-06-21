Public Class Costo

    Protected _idCosto As Integer
    Protected _codAtencion As Integer
    Protected _descripcion As String
    Protected _costo As Integer

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(idCosto As Integer, codAtencion As Integer, descripcion As String, costo As Integer)
        MyBase.New()
        _idCosto = idCosto
        _codAtencion = codAtencion
        _descripcion = descripcion
        _costo = costo
    End Sub

    Public Property IdCosto As Integer
        Get
            Return _idCosto
        End Get
        Set(value As Integer)
            _idCosto = value
        End Set
    End Property

    Public Property CodAtencion As Integer
        Get
            Return _codAtencion
        End Get
        Set(value As Integer)
            _codAtencion = value
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

    Public Property Costo As Integer
        Get
            Return _costo
        End Get
        Set(value As Integer)
            _costo = value
        End Set
    End Property



End Class
