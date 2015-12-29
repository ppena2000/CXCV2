Public Class Medicion

    Private _medicion As Decimal
    Public Property Medicion() As Decimal
        Get
            Return _medicion
        End Get
        Set(ByVal value As Decimal)
            _medicion = value
        End Set
    End Property

    Private _estado As Boolean
    Public Property Estado() As Boolean
        Get
            Return _estado
        End Get
        Set(ByVal value As Boolean)
            _estado = value
        End Set
    End Property



End Class
