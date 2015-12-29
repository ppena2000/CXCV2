Public Class DatosConexion

    Private _DataBaseName As String
    Public Property DataBaseName() As String
        Get
            Return _DataBaseName
        End Get
        Set(ByVal value As String)
            _DataBaseName = value
        End Set
    End Property

    Private _ServerName As String
    Public Property ServerName() As String
        Get
            Return _ServerName
        End Get
        Set(ByVal value As String)
            _ServerName = value
        End Set
    End Property


End Class
