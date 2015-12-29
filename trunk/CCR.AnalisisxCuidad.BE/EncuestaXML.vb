Public Class EncuestaXML

    Private _id As Long
    Public Property Id() As Long
        Get
            Return _id
        End Get
        Set(ByVal value As Long)
            _id = value
        End Set
    End Property

    Private _parentId As Long
    Public Property ParentId() As Long
        Get
            Return _parentId
        End Get
        Set(ByVal value As Long)
            _parentId = value
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

    Private _IdTemporal As Long
    Public Property IdTemporal() As Long
        Get
            Return _IdTemporal
        End Get
        Set(ByVal value As Long)
            _IdTemporal = value
        End Set
    End Property

    Private _IdCCEncuestaCategoriaSkuDatos As Integer
    Public Property IdCCEncuestaCategoriaSkuDatos() As Integer
        Get
            Return _IdCCEncuestaCategoriaSkuDatos
        End Get
        Set(ByVal value As Integer)
            _IdCCEncuestaCategoriaSkuDatos = value
        End Set
    End Property

    Private _IdEncuestaCategoriaSku As Integer
    Public Property IdEncuestaCategoriaSku() As Integer
        Get
            Return _IdEncuestaCategoriaSku
        End Get
        Set(ByVal value As Integer)
            _IdEncuestaCategoriaSku = value
        End Set
    End Property

    Private _TipoActivo As Byte
    Public Property TipoActivo() As Byte
        Get
            Return _TipoActivo
        End Get
        Set(ByVal value As Byte)
            _TipoActivo = value
        End Set
    End Property

    Private _TipoDato As Byte
    Public Property TipoDato() As Byte
        Get
            Return _TipoDato
        End Get
        Set(ByVal value As Byte)
            _TipoDato = value
        End Set
    End Property

    Private _CodigoNegocio As Integer
    Public Property CodigoNegocio() As Integer
        Get
            Return _CodigoNegocio
        End Get
        Set(ByVal value As Integer)
            _CodigoNegocio = value
        End Set
    End Property

    Private _codigoNegocioSku As String
    Public Property CodigoNegocioSku() As String
        Get
            Return _codigoNegocioSku
        End Get
        Set(ByVal value As String)
            _codigoNegocioSku = value
        End Set
    End Property

    Private _Frecuencia As Byte
    Public Property Frecuencia() As Byte
        Get
            Return _Frecuencia
        End Get
        Set(ByVal value As Byte)
            _Frecuencia = value
        End Set
    End Property

    Private _P0_IAntFac As Integer
    Public Property P0_IAntFac() As Integer
        Get
            Return _P0_IAntFac
        End Get
        Set(ByVal value As Integer)
            _P0_IAntFac = value
        End Set
    End Property

    Private _P0_CM1PFac As Integer
    Public Property P0_CM1PFac() As Integer
        Get
            Return _P0_CM1PFac
        End Get
        Set(ByVal value As Integer)
            _P0_CM1PFac = value
        End Set
    End Property

    Private _P0_CM2PFac As Integer
    Public Property P0_CM2PFac() As Integer
        Get
            Return _P0_CM2PFac
        End Get
        Set(ByVal value As Integer)
            _P0_CM2PFac = value
        End Set
    End Property

    Private _P0_INVFac As Integer
    Public Property P0_INVFac() As Integer
        Get
            Return _P0_INVFac
        End Get
        Set(ByVal value As Integer)
            _P0_INVFac = value
        End Set
    End Property

    Private _P0_PREFac As Decimal
    Public Property P0_PREFac() As Decimal
        Get
            Return _P0_PREFac
        End Get
        Set(ByVal value As Decimal)
            _P0_PREFac = value
        End Set
    End Property

    Private _P0_REG As Integer
    Public Property P0_REG() As Integer
        Get
            Return _P0_REG
        End Get
        Set(ByVal value As Integer)
            _P0_REG = value
        End Set
    End Property

    Private _P1_IANTFac As Integer
    Public Property P1_IANTFac() As Integer
        Get
            Return _P1_IANTFac
        End Get
        Set(ByVal value As Integer)
            _P1_IANTFac = value
        End Set
    End Property

    Private _P1_CM1PFac As Integer
    Public Property P1_CM1PFac() As Integer
        Get
            Return _P1_CM1PFac
        End Get
        Set(ByVal value As Integer)
            _P1_CM1PFac = value
        End Set
    End Property

    Private _P1_CM2PFac As Integer
    Public Property P1_CM2PFac() As Integer
        Get
            Return _P1_CM2PFac
        End Get
        Set(ByVal value As Integer)
            _P1_CM2PFac = value
        End Set
    End Property

    Private _P1_INVFac As Integer
    Public Property P1_INVFac() As Integer
        Get
            Return _P1_INVFac
        End Get
        Set(ByVal value As Integer)
            _P1_INVFac = value
        End Set
    End Property

    Private _P1_PREFac As Decimal
    Public Property P1_PREFac() As Decimal
        Get
            Return _P1_PREFac
        End Get
        Set(ByVal value As Decimal)
            _P1_PREFac = value
        End Set
    End Property

    Private _P1_REG As Integer
    Public Property P1_REG() As Integer
        Get
            Return _P1_REG
        End Get
        Set(ByVal value As Integer)
            _P1_REG = value
        End Set
    End Property

    Private _P2_IANTFac As Integer
    Public Property P2_IANTFac() As Integer
        Get
            Return _P2_IANTFac
        End Get
        Set(ByVal value As Integer)
            _P2_IANTFac = value
        End Set
    End Property

    Private _P2_CM1PFac As Integer
    Public Property P2_CM1PFac() As Integer
        Get
            Return _P2_CM1PFac
        End Get
        Set(ByVal value As Integer)
            _P2_CM1PFac = value
        End Set
    End Property

    Private _P2_CM2PFac As Integer
    Public Property P2_CM2PFac() As Integer
        Get
            Return _P2_CM2PFac
        End Get
        Set(ByVal value As Integer)
            _P2_CM2PFac = value
        End Set
    End Property

    Private _P2_INVFac As Integer
    Public Property P2_INVFac() As Integer
        Get
            Return _P2_INVFac
        End Get
        Set(ByVal value As Integer)
            _P2_INVFac = value
        End Set
    End Property

    Private _P2_PREFac As Decimal
    Public Property P2_PREFac() As Decimal
        Get
            Return _P2_PREFac
        End Get
        Set(ByVal value As Decimal)
            _P2_PREFac = value
        End Set
    End Property

    Private _P2_REG As Integer
    Public Property P2_REG() As Integer
        Get
            Return _P2_REG
        End Get
        Set(ByVal value As Integer)
            _P2_REG = value
        End Set
    End Property

    Private _Comentarios As String
    Public Property Comentarios() As String
        Get
            Return _Comentarios
        End Get
        Set(ByVal value As String)
            _Comentarios = value
        End Set
    End Property

    Private _CodigoUsuario As Int16
    Public Property CodigoUsuario() As Int16
        Get
            Return _CodigoUsuario
        End Get
        Set(ByVal value As Int16)
            _CodigoUsuario = value
        End Set
    End Property

    Private _Estado As Byte
    Public Property Estado() As Byte
        Get
            Return _Estado
        End Get
        Set(ByVal value As Byte)
            _Estado = value
        End Set
    End Property

    Private _CodigoSku As Integer
    Public Property CodigoSku() As Integer
        Get
            Return _CodigoSku
        End Get
        Set(ByVal value As Integer)
            _CodigoSku = value
        End Set
    End Property
    Private _CodigoSkuOriginal As Integer
    Public Property CodigoSkuOriginal() As Integer
        Get
            Return _CodigoSkuOriginal
        End Get
        Set(ByVal value As Integer)
            _CodigoSkuOriginal = value
        End Set
    End Property

    Private _CodigoCategoriaAgrupada As Integer
    Public Property CodigoCategoriaAgrupada() As Integer
        Get
            Return _CodigoCategoriaAgrupada
        End Get
        Set(ByVal value As Integer)
            _CodigoCategoriaAgrupada = value
        End Set
    End Property

    Private _Sku As String
    Public Property Sku() As String
        Get
            Return _Sku
        End Get
        Set(ByVal value As String)
            _Sku = value
        End Set
    End Property

    Private _Editado As Byte
    Public Property Editado() As Byte
        Get
            Return _Editado
        End Get
        Set(ByVal value As Byte)
            _Editado = value
        End Set
    End Property

    Private _P0_VtaFac As Integer
    Public Property P0_VtaFac() As Integer
        Get
            Return _P0_VtaFac
        End Get
        Set(ByVal value As Integer)
            _P0_VtaFac = value
        End Set
    End Property

    Private _P1_VtaFac As Integer
    Public Property P1_VtaFac() As Integer
        Get
            Return _P1_VtaFac
        End Get
        Set(ByVal value As Integer)
            _P1_VtaFac = value
        End Set
    End Property

    Private _P2_VtaFac As Integer
    Public Property P2_VtaFac() As Integer
        Get
            Return _P2_VtaFac
        End Get
        Set(ByVal value As Integer)
            _P2_VtaFac = value
        End Set
    End Property

    Private _EditadoAnterior As Byte
    Public Property EditadoAnterior() As Byte
        Get
            Return _EditadoAnterior
        End Get
        Set(ByVal value As Byte)
            _EditadoAnterior = value
        End Set
    End Property


    Private _EstadoRegistro As Byte
    Public Property EstadoRegistro() As Byte
        Get
            Return _EstadoRegistro
        End Get
        Set(ByVal value As Byte)
            _EstadoRegistro = value
        End Set
    End Property

    Private _P0_PRE2Fac As Decimal
    Public Property P0_PRE2Fac() As Decimal
        Get
            Return _P0_PRE2Fac
        End Get
        Set(ByVal value As Decimal)
            _P0_PRE2Fac = value
        End Set
    End Property

    '+P Para incluir nuevos precios ...
    Private _P1_PRE2Fac As Decimal
    Public Property P1_PRE2Fac() As Decimal
        Get
            Return _P1_PRE2Fac
        End Get
        Set(ByVal value As Decimal)
            _P1_PRE2Fac = value
        End Set
    End Property

    Private _P2_PRE2Fac As Decimal
    Public Property P2_PRE2Fac() As Decimal
        Get
            Return _P2_PRE2Fac
        End Get
        Set(ByVal value As Decimal)
            _P2_PRE2Fac = value
        End Set
    End Property

    Private _TipoAjuste As Byte
    Public Property TipoAjuste() As Byte
        Get
            Return _TipoAjuste
        End Get
        Set(ByVal value As Byte)
            _TipoAjuste = value
        End Set
    End Property


    Private _TipoDistribucion As Int16
    Public Property TipoDistribucion() As Int16
        Get
            Return _TipoDistribucion
        End Get
        Set(ByVal value As Int16)
            _TipoDistribucion = value
        End Set
    End Property











End Class
