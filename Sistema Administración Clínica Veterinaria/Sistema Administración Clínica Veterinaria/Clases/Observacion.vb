Public Class Observacion

    Protected _numObservacion As Integer
    Protected _idFicha As String
    Protected _fechaObservacion As String
    Protected _descripcion As String

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(numObservacion As Integer, idFicha As String, fechaObservacion As String, descripcion As String)
        MyBase.New()
        _numObservacion = numObservacion
        _idFicha = idFicha
        _fechaObservacion = fechaObservacion
        _descripcion = descripcion
    End Sub

    Public Property NumObservacion As Integer
        Get
            Return _numObservacion
        End Get
        Set(value As Integer)
            _numObservacion = value
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

    Public Property FechaObservacion As String
        Get
            Return _fechaObservacion
        End Get
        Set(value As String)
            _fechaObservacion = value
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


End Class
