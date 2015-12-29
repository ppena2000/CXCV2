Imports CCR.AnalisisxCuidad.BE
Imports System.Data.SqlClient

Public Class AlertasSupervisionDAO : Inherits ConnectionHelper
    Public Sub New()
    End Sub

    Public Function ListarAlertasSupervision(ByVal idMedicionZona As Integer) As IList(Of AlertasSupervision)
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader

        Using sqlCn As SqlConnection = ObtenerInstancia()
            cmd = New SqlCommand()
            cmd.Connection = sqlCn
            cmd.CommandText = "PCCRCC_PCSupervision_Sel"
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
                Dim listaAlertas As New List(Of AlertasSupervision)
                reader = cmd.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        Dim alertas As New AlertasSupervision
                        alertas.CodGrupoAlertas = reader.GetInt32(reader.GetOrdinal("CodGrupoAlertas"))
                        alertas.GrupoAlertas = reader.GetString(reader.GetOrdinal("GrupoAlertas"))
                        alertas.E0Negocios = reader.GetInt32(reader.GetOrdinal("E0_Negocios"))
                        alertas.E1Pendientes = reader.GetInt32(reader.GetOrdinal("E1_Pendientes"))
                        alertas.E2NegociosEnSupervision = reader.GetInt32(reader.GetOrdinal("E2_NegociosEnSupervision"))
                        alertas.E3NegociosSupervisados = reader.GetInt32(reader.GetOrdinal("E3_NegociosSupervisados"))
                        alertas.E4NegociosCorrejidos = reader.GetInt32(reader.GetOrdinal("E4_NegociosCorregidos"))
                        alertas.E5 = reader.GetInt32(reader.GetOrdinal("E5"))
                        listaAlertas.Add(alertas)
                    End While
                End If
                Return listaAlertas
            Catch ex As Exception
                Throw ex
            End Try
        End Using
    End Function
End Class
