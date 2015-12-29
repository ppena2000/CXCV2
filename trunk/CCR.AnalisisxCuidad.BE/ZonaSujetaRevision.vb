Public Class ZonaSujetaRevision

    Private _idTCCRCCAvance As Integer
    Public Property IdTCCRCCAvance() As Integer
        Get
            Return _idTCCRCCAvance
        End Get
        Set(ByVal value As Integer)
            _idTCCRCCAvance = value
        End Set
    End Property


    Private _zona As String
    Public Property Zona() As String
        Get
            Return _zona
        End Get
        Set(ByVal value As String)
            _zona = value
        End Set
    End Property


    Private _totalNegocios As Integer
    Public Property TotalNegocios() As Integer
        Get
            Return _totalNegocios
        End Get
        Set(ByVal value As Integer)
            _totalNegocios = value
        End Set
    End Property

    Private _avance As Int16
    Public Property Avance() As Int16
        Get
            Return _avance
        End Get
        Set(ByVal value As Int16)
            _avance = value
        End Set
    End Property

    Private _alertas As Int16
    Public Property Alertas() As Int16
        Get
            Return _alertas
        End Get
        Set(ByVal value As Int16)
            _alertas = value
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

    Private _estado As Byte
    Public Property Estado() As Byte
        Get
            Return _estado
        End Get
        Set(ByVal value As Byte)
            _estado = value
        End Set
    End Property

    Private _estadoEtiqueta As String
    Public Property EstadoEtiqueta() As String
        Get
            Return _estadoEtiqueta
        End Get
        Set(ByVal value As String)
            _estadoEtiqueta = value
        End Set
    End Property



    Private _codigoUsuario As Int16
    Public Property CodigoUsuario() As Int16
        Get
            Return _codigoUsuario
        End Get
        Set(ByVal value As Int16)
            _codigoUsuario = value
        End Set
    End Property


    Private _codigoUsuarioAnterior As Int16
    Public Property CodigoUsuarioAnterior() As Int16
        Get
            Return _codigoUsuarioAnterior
        End Get
        Set(ByVal value As Int16)
            _codigoUsuarioAnterior = value
        End Set
    End Property

    Private _usuario As String
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Private _usuarioAnterior As String
    Public Property UsuarioAnterior() As String
        Get
            Return _usuarioAnterior
        End Get
        Set(ByVal value As String)
            _usuarioAnterior = value
        End Set
    End Property

    Private _C_Desde As String
    Public Property C_Desde() As String
        Get
            Return _C_Desde
        End Get
        Set(ByVal value As String)
            _C_Desde = value
        End Set
    End Property

    Private _CC_Meta As String
    Public Property CC_Meta() As String
        Get
            Return _CC_Meta
        End Get
        Set(ByVal value As String)
            _CC_Meta = value
        End Set
    End Property

    Private _CC_MetaFecha As Date
    Public Property CC_MetaFecha() As Date
        Get
            Return _CC_MetaFecha
        End Get
        Set(ByVal value As Date)
            _CC_MetaFecha = value
        End Set
    End Property


    Private _C_Hasta As String
    Public Property C_Hasta() As String
        Get
            Return _C_Hasta
        End Get
        Set(ByVal value As String)
            _C_Hasta = value
        End Set
    End Property

    Private _C_Avance As String
    Public Property C_Avance() As String
        Get
            Return _C_Avance
        End Get
        Set(ByVal value As String)
            _C_Avance = value
        End Set
    End Property

    Private _CC_Avance As String
    Public Property CC_Avance() As String
        Get
            Return _CC_Avance
        End Get
        Set(ByVal value As String)
            _CC_Avance = value
        End Set
    End Property
End Class
