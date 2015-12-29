Imports CCR.AnalisisxCuidad.BE
Imports System.Data.SqlClient

Public Class PlantillaResumenDAO : Inherits ConnectionHelper
    Public Sub New()
    End Sub

    Public Function ConsultarPlantillaResumen(ByVal periodo As Integer, ByVal codigoZona As Int16, ByVal idIndicador As Int16, ByVal SubIndicador As Int16) As IList(Of PlantillaResumen)
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader

        Using sqlCn As SqlConnection = ObtenerInstancia()
            cmd = New SqlCommand()
            cmd.Connection = sqlCn
            cmd.CommandText = "PCCRCC_DatosPantillaRES01"
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
                Dim plantillasResumen As New List(Of PlantillaResumen)
                reader = cmd.ExecuteReader()


                If reader.HasRows Then
                    While reader.Read()
                        Dim plantilla As New PlantillaResumen
                        plantilla.Canal = reader.GetString(reader.GetOrdinal("Canal"))
                        plantilla.Categoria = reader.GetString(reader.GetOrdinal("Categoria"))
                        plantilla.CodigoProducto = reader.GetInt16(reader.GetOrdinal("CodigoProducto"))
                        plantilla.Frecuencia = reader.GetByte(reader.GetOrdinal("Frecuencia"))
                        plantilla.TipoDato = reader.GetByte(reader.GetOrdinal("TipoDato"))
                        plantilla.Periodo = reader.GetByte(reader.GetOrdinal("Periodo"))
                        plantilla.Etiqueta = reader.GetString(reader.GetOrdinal("Etiqueta"))
                        plantilla.CVVNTA = reader.GetDecimal(reader.GetOrdinal("CCVNTA"))
                        plantilla.IntAntFac = reader.GetInt32(reader.GetOrdinal("IAntFac"))
                        plantilla.CmpFac = reader.GetInt32(reader.GetOrdinal("CmpFac"))
                        plantilla.InvFac = reader.GetInt32(reader.GetOrdinal("InvFac"))
                        plantilla.Pre = reader.GetInt32(reader.GetOrdinal("Pre"))
                        plantilla.VtaFac = reader.GetInt32(reader.GetOrdinal("VtaFac"))
                        plantilla.Tot = reader.GetInt32(reader.GetOrdinal("Tot"))
                        plantillasResumen.Add(plantilla)
                    End While
                End If
                Return plantillasResumen
            Catch ex As Exception
                Throw ex
            End Try
        End Using
    End Function
End Class
