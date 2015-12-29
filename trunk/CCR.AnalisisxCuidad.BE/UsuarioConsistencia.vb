Public Class UsuarioConsistencia

    Private _codigoUsuario As Int16
    Public Property CodigoUsuario() As Int16
        Get
            Return _codigoUsuario
        End Get
        Set(ByVal value As Int16)
            _codigoUsuario = value
        End Set
    End Property


    Private _nombreUsuario As String
    Public Property NombreUsuario() As String
        Get
            Return _nombreUsuario
        End Get
        Set(ByVal value As String)
            _nombreUsuario = value
        End Set
    End Property


    Private _rowNumber As Long
    Public Property RowNumber() As Long
        Get
            Return _rowNumber
        End Get
        Set(ByVal value As Long)
            _rowNumber = value
        End Set
    End Property


End Class
