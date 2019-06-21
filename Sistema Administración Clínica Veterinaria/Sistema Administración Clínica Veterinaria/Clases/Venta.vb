Public Class Venta

    Protected _codVenta As Integer
    Protected _numCliente As Integer
    Protected _fechaVenta As String
    Protected _total As Integer

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(codVenta As Integer, numCliente As Integer, fechaVenta As String, total As Integer)
        MyBase.New()
        _codVenta = codVenta
        _numCliente = numCliente
        _fechaVenta = fechaVenta
        _total = total
    End Sub

    Public Property CodVenta As Integer
        Get
            Return _codVenta
        End Get
        Set(value As Integer)
            _codVenta = value
        End Set
    End Property

    Public Property NumCliente As Integer
        Get
            Return _numCliente
        End Get
        Set(value As Integer)
            _numCliente = value
        End Set
    End Property

    Public Property FechaVenta As String
        Get
            Return _fechaVenta
        End Get
        Set(value As String)
            _fechaVenta = value
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


End Class
