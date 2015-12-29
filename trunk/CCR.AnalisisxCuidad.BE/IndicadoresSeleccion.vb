Public Class IndicadoresSeleccion

    Private _idIndicador As Int16
    Public Property IdIndicador() As Int16
        Get
            Return _idIndicador
        End Get
        Set(ByVal value As Int16)
            _idIndicador = value
        End Set
    End Property

    Private _grupoTitulo As String
    Public Property GrupoTitulo() As String
        Get
            Return _grupoTitulo
        End Get
        Set(ByVal value As String)
            _grupoTitulo = value
        End Set
    End Property

    Private _tituloIndicador As String
    Public Property TituloIndicador() As String
        Get
            Return _tituloIndicador
        End Get
        Set(ByVal value As String)
            _tituloIndicador = value
        End Set
    End Property

    Private _e0Negocios As Integer
    Public Property E0Negocios() As Integer
        Get
            Return _e0Negocios
        End Get
        Set(ByVal value As Integer)
            _e0Negocios = value
        End Set
    End Property

    Private _e1Pendientes As Integer
    Public Property E1Pendientes() As Integer
        Get
            Return _e1Pendientes
        End Get
        Set(ByVal value As Integer)
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
