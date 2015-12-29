Imports CCR.AnalisisxCuidad.BE
Imports System.Data.SqlClient

Public Class ErrorMedicionZonaDAO : Inherits ConnectionHelper
    Public Sub New()
    End Sub

    Public Function ListasErroresMedicionZona(ByVal idMedicionZona As Integer) As IList(Of ErrorMedicionZona)
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader

        Using sqlCn As SqlConnection = ObtenerInstancia()
            cmd = New SqlCommand()
            cmd.Connection = sqlCn
            cmd.CommandText = "PCCRCC_PCErrores_Sel"
            cmd.CommandType = CommandType.StoredProcedure

            Dim prmMestado As New SqlParameter()
            prmMestado.ParameterName = "@IdMedicionZona"
            prmMestado.DbType = DbType.Int32
            prmMestado.Value = idMedicionZona
            cmd.Parameters.Add(prmMestado)

            Dim retorna As New SqlParameter
            retorna.ParameterName = "@RETORNA"
            retorna.DbType = DbType.Int16
            retorna.Direction = ParameterDirection.Output
            cmd.Parameters.Add(retorna)

            Try
                sqlCn.Open()
                Dim listaErrores As New List(Of ErrorMedicionZona)
                reader = cmd.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        Dim errorZona As New ErrorMedicionZona
                        errorZona.Zona = reader.GetString(reader.GetOrdinal("Zona"))
                        errorZona.CodigoMedicion = reader.GetDateTime(reader.GetOrdinal("CodigoMedicion"))
                        'errorZona.CodigoMedicion = reader.GetInt32(reader.GetOrdinal("CodigoMedicion"))
                        errorZona.TotalErrores = reader.GetInt32(reader.GetOrdinal("TotalErrores"))
                        errorZona.NegociosTotal = reader.GetInt16(reader.GetOrdinal("NegociosTotal"))
                        errorZona.Indice = reader.GetDouble(reader.GetOrdinal("Indice"))
                        listaErrores.Add(errorZona)
                    End While
                End If
                Return listaErrores
            Catch ex As Exception
                Throw ex
            End Try
        End Using
    End Function
End Class
