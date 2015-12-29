Public Class Estados


    Private _codigoEstado As Byte
    Public Property CodigoEstado() As Byte
        Get
            Return _codigoEstado
        End Get
        Set(ByVal value As Byte)
            _codigoEstado = value
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


End Class
