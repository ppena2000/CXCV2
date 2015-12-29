Public Class Indicadores

    Private _grupoTitulo As String
    Public Property GrupoTitulo() As String
        Get
            Return _grupoTitulo
        End Get
        Set(ByVal value As String)
            _grupoTitulo = value
        End Set
    End Property

    Private _idIndicador As Integer
    Public Property IdIndicador() As Integer
        Get
            Return _idIndicador
        End Get
        Set(ByVal value As Integer)
            _idIndicador = value
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

    Private _alerta0 As Integer
    Public Property Alerta0() As Integer
        Get
            Return _alerta0
        End Get
        Set(ByVal value As Integer)
            _alerta0 = value
        End Set
    End Property

    Private _alerta1 As Integer
    Public Property Alerta1() As Integer
        Get
            Return _alerta1
        End Get
        Set(ByVal value As Integer)
            _alerta1 = value
        End Set
    End Property

    Private _alerta2 As Integer
    Public Property Alerta2() As Integer
        Get
            Return _alerta2
        End Get
        Set(ByVal value As Integer)
            _alerta2 = value
        End Set
    End Property

    Private _alerta3 As Integer
    Public Property Alerta3() As Integer
        Get
            Return _alerta3
        End Get
        Set(ByVal value As Integer)
            _alerta3 = value
        End Set
    End Property

    Private _alerta4 As Integer
    Public Property Alerta4() As Integer
        Get
            Return _alerta4
        End Get
        Set(ByVal value As Integer)
            _alerta4 = value
        End Set
    End Property

    Private _descripcion As String
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Private _tituloIndicadorPrincipal As String
    Public Property TituloIndicadorPrincipal() As String
        Get
            Return _tituloIndicadorPrincipal
        End Get
        Set(ByVal value As String)
            _tituloIndicadorPrincipal = value
        End Set
    End Property

    Private _tituloIndicadorSecundario As String
    Public Property TituloIndicadorSecundario() As String
        Get
            Return _tituloIndicadorSecundario
        End Get
        Set(ByVal value As String)
            _tituloIndicadorSecundario = value
        End Set
    End Property

    Private _estadoUIPageButtonGroup As String
    Public Property EstadoUIPageButtonGroup() As String
        Get
            Return _estadoUIPageButtonGroup
        End Get
        Set(ByVal value As String)
            _estadoUIPageButtonGroup = value
        End Set
    End Property

    Private _spPrincipal As String
    Public Property SpPrincipal() As String
        Get
            Return _spPrincipal
        End Get
        Set(ByVal value As String)
            _spPrincipal = value
        End Set
    End Property

    Private _spSecundario As String
    Public Property SpSecundario() As String
        Get
            Return _spSecundario
        End Get
        Set(ByVal value As String)
            _spSecundario = value
        End Set
    End Property

    Private _xmlGridPrincipal As String
    Public Property XmlGridPrincipal() As String
        Get
            Return _xmlGridPrincipal
        End Get
        Set(ByVal value As String)
            _xmlGridPrincipal = value
        End Set
    End Property

    Private _xmlGridSecundario As String
    Public Property XmlGridSecundario() As String
        Get
            Return _xmlGridSecundario
        End Get
        Set(ByVal value As String)
            _xmlGridSecundario = value
        End Set
    End Property

    Private _frmPlantilla As String
    Public Property FrmPlantilla() As String
        Get
            Return _frmPlantilla
        End Get
        Set(ByVal value As String)
            _frmPlantilla = value
        End Set
    End Property

End Class
