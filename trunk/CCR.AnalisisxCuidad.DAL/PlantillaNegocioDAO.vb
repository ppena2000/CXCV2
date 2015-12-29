Imports CCR.AnalisisxCuidad.BE
Imports System.Data.SqlClient

Public Class PlantillaNegocioDAO : Inherits ConnectionHelper
    Public Sub New()
    End Sub

    Public Function ConsultaPlantillaNegocio(ByVal periodo As Integer, ByVal codigoZona As Int16, ByVal idIndicador As Int16, ByVal SubIndicador As Int16) As IList(Of PlantillaNegocio)
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader

        Using sqlCn As SqlConnection = ObtenerInstancia()
            cmd = New SqlCommand()
            cmd.Connection = sqlCn
            cmd.CommandText = "PCCRCC_DatosPantillaNEG01"
            cmd.CommandType = CommandType.StoredProcedure
            'Agregamos el parametro a usarse
            Dim pIntPeriodo As New SqlParameter()
            pIntPeriodo.ParameterName = "@pintPeriodo"
            pIntPeriodo.DbType = DbType.Int32
            pIntPeriodo.Value = periodo
            cmd.Parameters.Add(pIntPeriodo)

            Dim pIntCodigoZona As New SqlParameter
            pIntCodigoZona.ParameterName = "@pintCodigozona"
            pIntCodigoZona.DbType = DbType.Int16
            cmd.Parameters.Add(pIntCodigoZona)

            Dim pIntIdIndicador As New SqlParameter
            pIntIdIndicador.ParameterName = "@pintIdIndicador"
            pIntIdIndicador.DbType = DbType.Int16
            cmd.Parameters.Add(pIntIdIndicador)

            Dim pIntSubIndicador As New SqlParameter
            pIntSubIndicador.ParameterName = "@pintSubIndicador"
            pIntSubIndicador.DbType = DbType.Int16
            cmd.Parameters.Add(pIntSubIndicador)

            Try
                sqlCn.Open()
                Dim plantillaNegocios As New List(Of PlantillaNegocio)
                reader = cmd.ExecuteReader()


                If reader.HasRows Then
                    While reader.Read()
                        Dim plantilla As New PlantillaNegocio
                        plantilla.Canal = reader.GetString(reader.GetOrdinal("Canal"))
                        plantilla.Categoria = reader.GetString(reader.GetOrdinal("Categoria"))
                        plantilla.CodigoProducto = reader.GetInt16(reader.GetOrdinal("CodigoProducto"))
                        plantilla.Frecuencia = reader.GetByte(reader.GetOrdinal("Frecuencia"))
                        plantilla.TipoDato = reader.GetByte(reader.GetOrdinal("TipoDato"))
                        plantilla.Periodo = reader.GetByte(reader.GetOrdinal("Periodo"))
                        plantilla.CVVNTA = reader.GetDecimal(reader.GetOrdinal("CCVNTA"))
                        plantilla.IntAntFac = reader.GetInt32(reader.GetOrdinal("IAntFac"))
                        plantilla.CmpFac = reader.GetInt32(reader.GetOrdinal("CmpFac"))
                        plantilla.InvFac = reader.GetInt32(reader.GetOrdinal("InvFac"))
                        plantilla.Pre = reader.GetInt32(reader.GetOrdinal("Pre"))
                        plantilla.VtaFac = reader.GetInt32(reader.GetOrdinal("VtaFac"))
                        plantilla.Tot = reader.GetInt32(reader.GetOrdinal("Tot"))
                        plantillaNegocios.Add(plantilla)
                    End While
                End If
                Return plantillaNegocios
            Catch ex As Exception
                Throw ex
            End Try
        End Using
    End Function

    Public Function ObtenerDatosPlantilla(ByVal spPlantilla As String, ByVal idMedicionZona As Integer, ByVal indicador As Integer, ByVal subIndicador As Integer) As DataTable
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Try
            Using sqlCn As SqlConnection = ObtenerInstancia()
                cmd.Connection = sqlCn
                'FALTA MP: COMPLETAR lIndicador
                cmd.CommandText = spPlantilla
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandTimeout = 0
                cmd.Parameters.Add("@pintIdMedicionZona", SqlDbType.Int).Value = idMedicionZona
                cmd.Parameters.Add("@pintIdIndicador", SqlDbType.SmallInt).Value = indicador
                cmd.Parameters.Add("@pintSubIndicador", SqlDbType.SmallInt).Value = subIndicador
                da.SelectCommand = cmd
                da.Fill(dt)

                Return dt
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
