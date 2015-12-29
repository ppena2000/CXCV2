Imports System.Data.SqlClient
Imports CCR.AnalisisxCuidad.BE

Public Class IndicadoresDAO : Inherits ConnectionHelper
    Public Sub New()
    End Sub

    Public Function ConsultarEstadoIndicadores(ByVal pMestado As Decimal, ByVal codigoZona As Int16) As IList(Of Indicadores)
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader

        Using sqlCn As SqlConnection = ObtenerInstancia()
            cmd = New SqlCommand()
            cmd.Connection = sqlCn
            cmd.CommandText = "PCCRCC_Indicadores_Sel"
            cmd.CommandType = CommandType.StoredProcedure

            Dim prmMestado As New SqlParameter()
            prmMestado.ParameterName = "@PMESTDO"
            prmMestado.DbType = DbType.Int32
            prmMestado.Value = pMestado
            'cmd.Parameters.Add(prmMestado)

            Dim pIntCodigoZona As New SqlParameter
            pIntCodigoZona.ParameterName = "@CodigZona"
            pIntCodigoZona.DbType = DbType.Int16
            pIntCodigoZona.Value = codigoZona
            'cmd.Parameters.Add(pIntCodigoZona)

            Try
                sqlCn.Open()
                Dim listaIndicadores As New List(Of Indicadores)
                reader = cmd.ExecuteReader()

                If reader.HasRows Then
                    While reader.Read()
                        Dim indicador As New Indicadores
                        indicador.GrupoTitulo = reader.GetString(reader.GetOrdinal("GrupoTitulo"))
                        indicador.IdIndicador = reader.GetInt16(reader.GetOrdinal("IdIndicador"))
                        indicador.TituloIndicador = reader.GetString(reader.GetOrdinal("TituloIndicador"))
                        indicador.Descripcion = If(reader.IsDBNull(reader.GetOrdinal("Descripcion")), "", reader.GetString(reader.GetOrdinal("Descripcion")))
                        indicador.TituloIndicadorPrincipal = If(reader.IsDBNull(reader.GetOrdinal("TituloIndicadorPrincipal")), "", reader.GetString(reader.GetOrdinal("TituloIndicadorPrincipal")))
                        indicador.TituloIndicadorSecundario = If(reader.IsDBNull(reader.GetOrdinal("TituloIndicadorSecundario")), "", reader.GetString(reader.GetOrdinal("TituloIndicadorSecundario")))
                        indicador.EstadoUIPageButtonGroup = reader.GetString(reader.GetOrdinal("EstadoUIPageGroupButton"))
                        indicador.SpPrincipal = reader.GetString(reader.GetOrdinal("SPPrincipal"))
                        indicador.SpSecundario = reader.GetString(reader.GetOrdinal("SPSecundario"))
                        indicador.XmlGridPrincipal = If(reader.IsDBNull(reader.GetOrdinal("XMLGridPrincipal")), "", reader.GetString(reader.GetOrdinal("XMLGridPrincipal")))
                        indicador.XmlGridSecundario = If(reader.IsDBNull(reader.GetOrdinal("XMLGridSecundario")), "", reader.GetString(reader.GetOrdinal("XMLGridSecundario")))
                        indicador.FrmPlantilla = reader.GetString(reader.GetOrdinal("frmPlantilla"))
                        listaIndicadores.Add(indicador)
                    End While
                End If
                Return listaIndicadores
            Catch ex As Exception

                MsgBox(ex.Message + vbCrLf + "Póngase en contacto con el Administrador del Sistema", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "CCRCC - Inicio de Sesion")
                Throw ex
            End Try
        End Using
    End Function

    Public Function ListaSeleccionIndicadores(ByVal idMedicionZona As Integer) As IList(Of IndicadoresSeleccion)
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader

        Using sqlCn As SqlConnection = ObtenerInstancia()
            cmd = New SqlCommand()
            cmd.Connection = sqlCn
            cmd.CommandText = "PCCRCC_PCIndicadores_Sel"
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
                Dim listaIndicadores As New List(Of IndicadoresSeleccion)
                reader = cmd.ExecuteReader()

                If reader.HasRows Then
                    While reader.Read()
                        Dim indicador As New IndicadoresSeleccion
                        indicador.IdIndicador = reader.GetInt16(reader.GetOrdinal("IdIndicador"))
                        indicador.GrupoTitulo = reader.GetString(reader.GetOrdinal("GrupoTitulo"))
                        indicador.TituloIndicador = reader.GetString(reader.GetOrdinal("TituloIndicador"))
                        indicador.E0Negocios = reader.GetInt32(reader.GetOrdinal("E0_Negocios"))
                        indicador.E1Pendientes = reader.GetInt32(reader.GetOrdinal("E1_Pendientes"))
                        indicador.E2NegociosEnSupervision = reader.GetInt32(reader.GetOrdinal("E2_NegociosEnSupervision"))
                        indicador.E3NegociosSupervisados = reader.GetInt32(reader.GetOrdinal("E3_NegociosSupervisados"))
                        indicador.E4NegociosCorrejidos = reader.GetInt32(reader.GetOrdinal("E4_NegociosCorregidos"))
                        indicador.E5 = reader.GetInt32(reader.GetOrdinal("E5"))
                        listaIndicadores.Add(indicador)
                    End While
                End If
                Return listaIndicadores
            Catch ex As Exception
                Throw ex
            End Try
        End Using
    End Function

    Public Sub RecalculaIndicadoresMedicion(ByVal idMedicionZona As Integer)
        Try
            Dim bRetorna As Boolean = False
            Dim iRetorna As Int16 = 0 'NO ES NECESARIO...
            Dim aParametros(1, 2) As String

            aParametros(0, 0) = "@pintIdMedicionZona"
            aParametros(0, 1) = "Int"
            aParametros(0, 2) = idMedicionZona
            CCRCC_EjecutaProcedimiento("PCCRCC_RecalcularIndicadores_upd", 1, aParametros, iRetorna)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
