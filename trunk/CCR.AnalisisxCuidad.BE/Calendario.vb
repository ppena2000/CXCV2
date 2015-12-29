Public Class Calendario

    Private _calendarioCDesde As DateTime
    Public Property CalendarioCDesde() As DateTime
        Get
            Return _calendarioCDesde
        End Get
        Set(ByVal value As DateTime)
            _calendarioCDesde = value
        End Set
    End Property

    Private _calendarioCHasta As DateTime
    Public Property CalendarioCHasta() As DateTime
        Get
            Return _calendarioCHasta
        End Get
        Set(ByVal value As DateTime)
            _calendarioCHasta = value
        End Set
    End Property

    Private _calendarioCRevisado As DateTime
    Public Property CalendarioCRevisado() As DateTime
        Get
            Return _calendarioCRevisado
        End Get
        Set(ByVal value As DateTime)
            _calendarioCRevisado = value
        End Set
    End Property

    Private _calendarioCCRevisado As DateTime
    Public Property CalendarioCCRevisado() As DateTime
        Get
            Return _calendarioCCRevisado
        End Get
        Set(ByVal value As DateTime)
            _calendarioCCRevisado = value
        End Set
    End Property

    Private _calendarioCCMeta As DateTime
    Public Property CalendarioCCMeta() As DateTime
        Get
            Return _calendarioCCMeta
        End Get
        Set(ByVal value As DateTime)
            _calendarioCCMeta = value
        End Set
    End Property
End Class
