Public Class AlertasSupervision

    Private _codGrupoAlertas As Integer
    Public Property CodGrupoAlertas() As Integer
        Get
            Return _codGrupoAlertas
        End Get
        Set(ByVal value As Integer)
            _codGrupoAlertas = value
        End Set
    End Property

    Private _grupoAlertas As String
    Public Property GrupoAlertas() As String
        Get
            Return _grupoAlertas
        End Get
        Set(ByVal value As String)
            _grupoAlertas = value
        End Set
    End Property

    Private _e0Negocios As Int16
    Public Property E0Negocios() As Int16
        Get
            Return _e0Negocios
        End Get
        Set(ByVal value As Int16)
            _e0Negocios = value
        End Set
    End Property

    Private _e1Pendientes As Int16
    Public Property E1Pendientes() As Int16
        Get
            Return _e1Pendientes
        End Get
        Set(ByVal value As Int16)
            _e1Pendientes = value
        End Set
    End Property

    Private _e2NegociosEnSupervision As Integer
    Public Property E2NegociosEnSupervision() As Integer
        Get
            Return _e2NegociosEnSupervision
        End Get
        Set(ByVal value As Integer)
            _e2NegociosEnSupervision = value
        End Set
    End Property

    Private _e3NegociosSupervisados As Integer
    Public Property E3NegociosSupervisados() As Integer
        Get
            Return _e3NegociosSupervisados
        End Get
        Set(ByVal value As Integer)
            _e3NegociosSupervisados = value
        End Set
    End Property

    Private _e4NegociosCorrejidos As Integer
    Public Property E4NegociosCorrejidos() As Integer
        Get
            Return _e4NegociosCorrejidos
        End Get
        Set(ByVal value As Integer)
            _e4NegociosCorrejidos = value
        End Set
    End Property

    Private _e5 As Integer
    Public Property E5() As Integer
        Get
            Return _e5
        End Get
        Set(ByVal value As Integer)
            _e5 = value
        End Set
    End Property

End Class
