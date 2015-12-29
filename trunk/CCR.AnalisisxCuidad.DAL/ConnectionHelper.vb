Imports System.Configuration
Imports System.Data.SqlClient
Imports CCR.AnalisisxCuidad.Support

Public Class ConnectionHelper
    Private _ccrConnectionString As String
    Public Property CCRConnectionString() As String
        Get
            Return _ccrConnectionString
        End Get
        Set(ByVal value As String)
            _ccrConnectionString = value
        End Set
    End Property

    Public Sub New()
        CCRConnectionString = ConfigurationManager.ConnectionStrings(Constants.CADENA_CONEXION_KEY).ConnectionString
    End Sub

    Public Function ObtenerInstancia() As SqlConnection
        Return New SqlConnection(CCRConnectionString)
    End Function

    Public Sub CCRCC_EjecutaProcedimiento(ByVal psNombreSP As String, ByVal piNumeroParametros As Integer, ByVal paParametros As Array, ByRef piRetorno As Int16)
        ' Dim strConnString As String = "Data Source=192.168.1.8;Initial Catalog=BDPECCRCC;User ID=sa;Password=123456789.,"
        Dim con = ObtenerInstancia()
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure

        cmd.CommandText = psNombreSP
        cmd.CommandTimeout = 5 * 60 ' HASTA 5 minutos

        'If Not IsNothing(paParametros.Length) Then
        For i As Integer = 1 To piNumeroParametros
            Select Case paParametros(i - 1, 1)
                Case "BigInt"
                    cmd.Parameters.Add(paParametros(i - 1, 0), SqlDbType.BigInt).Value = paParametros(i - 1, 2)
                Case "Int"
                    cmd.Parameters.Add(paParametros(i - 1, 0), SqlDbType.Int).Value = paParametros(i - 1, 2)
                Case "SmallInt"
                    cmd.Parameters.Add(paParametros(i - 1, 0), SqlDbType.SmallInt).Value = paParametros(i - 1, 2)
                Case "Char"
                    cmd.Parameters.Add(paParametros(i - 1, 0), SqlDbType.Char).Value = paParametros(i - 1, 2)
                Case "TinyInt"
                    cmd.Parameters.Add(paParametros(i - 1, 0), SqlDbType.TinyInt).Value = paParametros(i - 1, 2)
                Case "Real"
                    cmd.Parameters.Add(paParametros(i - 1, 0), SqlDbType.Real).Value = paParametros(i - 1, 2)
                Case "Decimal"
                    cmd.Parameters.Add(paParametros(i - 1, 0), SqlDbType.Decimal).Value = paParametros(i - 1, 2)
                Case "Money"
                    cmd.Parameters.Add(paParametros(i - 1, 0), SqlDbType.Money).Value = paParametros(i - 1, 2)
                Case "Bit"
                    cmd.Parameters.Add(paParametros(i - 1, 0), SqlDbType.Bit).Value = paParametros(i - 1, 2)
                Case "Date"
                    cmd.Parameters.Add(paParametros(i - 1, 0), SqlDbType.Date).Value = paParametros(i - 1, 2)
                Case "DateTime"
                    cmd.Parameters.Add(paParametros(i - 1, 0), SqlDbType.DateTime).Value = paParametros(i - 1, 2)
            End Select

        Next
        If piRetorno > 0 Then
            cmd.Parameters("@RETORNA").Direction = ParameterDirection.Output
        End If

        'End If
        Using (con)
            Try
                con.Open()
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                If piRetorno > 0 Then
                    piRetorno = cmd.Parameters("@RETORNA").Value
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Using
    End Sub

End Class
