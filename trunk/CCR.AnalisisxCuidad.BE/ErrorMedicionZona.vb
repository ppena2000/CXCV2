Public Class ErrorMedicionZona

    Private _zona As String
    Public Property Zona() As String
        Get
            Return _zona
        End Get
        Set(ByVal value As String)
            _zona = value
        End Set
    End Property

    Private _codigoMedicion As Date
    Public Property CodigoMedicion() As Date
        Get
            Return _codigoMedicion
        End Get
        Set(ByVal value As Date)
            'Set(ByVal value As Integer)
            _codigoMedicion = value
        End Set
    End Property

    Private _totalErrores As Integer
    Public Property TotalErrores() As Integer
        Get
            Return _totalErrores
        End Get
        Set(ByVal value As Integer)
            _totalErrores = value
        End Set
    End Property

    Private _negociosTotal As Integer
    Public Property NegociosTotal() As Integer
        Get
            Return _negociosTotal
        End Get
        Set(ByVal value As Integer)
            _negociosTotal = value
        End Set
    End Property

    Private _indice As Double
    Public Property Indice() As Double
        Get
            Return _indice
        End Get
        Set(ByVal value As Double)
            _indice = value
        End Set
    End Property
End Class
