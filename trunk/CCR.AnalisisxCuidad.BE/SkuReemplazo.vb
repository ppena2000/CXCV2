Public Class SkuReemplazo

    Private _lsCadenaIds As String
    Public Property LsCadenaIds() As String
        Get
            Return _lsCadenaIds
        End Get
        Set(ByVal value As String)
            _lsCadenaIds = value
        End Set
    End Property

    Private _idMedicionZona As Integer
    Public Property IdMedicionZona() As Integer
        Get
            Return _idMedicionZona
        End Get
        Set(ByVal value As Integer)
            _idMedicionZona = value
        End Set
    End Property

    Private _tipoAccion As Integer
    Public Property TipoAccion() As Integer
        Get
            Return _tipoAccion
        End Get
        Set(ByVal value As Integer)
            _tipoAccion = value
        End Set
    End Property

    Private _codigoSkuReemplazo As Integer
    Public Property CodigoSkuReemplazo() As Integer
        Get
            Return _codigoSkuReemplazo
        End Get
        Set(ByVal value As Integer)
            _codigoSkuReemplazo = value
        End Set
    End Property

    Private _peso As Integer
    Public Property Peso() As Integer
        Get
            Return _peso
        End Get
        Set(ByVal value As Integer)
            _peso = value
        End Set
    End Property

    Private _nivel As Integer
    Public Property Nivel() As Integer
        Get
            Return _nivel
        End Get
        Set(ByVal value As Integer)
            _nivel = value
        End Set
    End Property

    Private _indicadorOrigen As Integer
    Public Property IndicadorOrigen() As Integer
        Get
            Return _indicadorOrigen
        End Get
        Set(ByVal value As Integer)
            _indicadorOrigen = value
        End Set
    End Property

    Private _idMedicionZonaCanalNegocio As Long
    Public Property IdMedicionZonaCanalNegocio() As Long
        Get
            Return _idMedicionZonaCanalNegocio
        End Get
        Set(ByVal value As Long)
            _idMedicionZonaCanalNegocio = value
        End Set
    End Property


End Class
