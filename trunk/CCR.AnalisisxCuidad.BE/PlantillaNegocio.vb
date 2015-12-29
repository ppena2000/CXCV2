Public Class PlantillaNegocio
    Private _canal As String
    Public Property Canal() As String
        Get
            Return _canal
        End Get
        Set(ByVal value As String)
            _canal = value
        End Set
    End Property

    Private _categoria As String
    Public Property Categoria() As String
        Get
            Return _categoria
        End Get
        Set(ByVal value As String)
            _categoria = value
        End Set
    End Property

    Private _codigoProducto As Int16
    Public Property CodigoProducto() As Int16
        Get
            Return _codigoProducto
        End Get
        Set(ByVal value As Int16)
            _codigoProducto = value
        End Set
    End Property

    Private _frecuencia As Byte
    Public Property Frecuencia() As Byte
        Get
            Return _frecuencia
        End Get
        Set(ByVal value As Byte)
            _frecuencia = value
        End Set
    End Property

    Private _tipoDato As Byte
    Public Property TipoDato() As Byte
        Get
            Return _tipoDato
        End Get
        Set(ByVal value As Byte)
            _tipoDato = value
        End Set
    End Property

    Private _periodo As Byte
    Public Property Periodo() As Byte
        Get
            Return _periodo
        End Get
        Set(ByVal value As Byte)
            _periodo = value
        End Set
    End Property


    Private _cvvnta As Decimal
    Public Property CVVNTA() As Decimal
        Get
            Return _cvvnta
        End Get
        Set(ByVal value As Decimal)
            _cvvnta = value
        End Set
    End Property

    Private _intAntFac As Integer
    Public Property IntAntFac() As Integer
        Get
            Return _intAntFac
        End Get
        Set(ByVal value As Integer)
            _intAntFac = value
        End Set
    End Property

    Private _cmpFac As Integer
    Public Property CmpFac() As Integer
        Get
            Return _cmpFac
        End Get
        Set(ByVal value As Integer)
            _cmpFac = value
        End Set
    End Property

    Private _invFac As Integer
    Public Property InvFac() As Integer
        Get
            Return _invFac
        End Get
        Set(ByVal value As Integer)
            _invFac = value
        End Set
    End Property

    Private _pre As Integer
    Public Property Pre() As Integer
        Get
            Return _pre
        End Get
        Set(ByVal value As Integer)
            _pre = value
        End Set
    End Property

    Private _vtaFac As Integer
    Public Property VtaFac() As Integer
        Get
            Return _vtaFac
        End Get
        Set(ByVal value As Integer)
            _vtaFac = value
        End Set
    End Property

    Private _tot As Integer
    Public Property Tot() As Integer
        Get
            Return _tot
        End Get
        Set(ByVal value As Integer)
            _tot = value
        End Set
    End Property

End Class
