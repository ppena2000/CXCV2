Imports CCR.AnalisisxCuidad.BE
Imports System.Data.SqlClient

Public Class CalendarioMedicionDAO : Inherits ConnectionHelper
    Public Sub New()
    End Sub

    Public Function ObtenerCalendarioMedicion(ByVal idMedicionZona As Integer) As IList(Of Calendario)
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader

        Using sqlCn As SqlConnection = ObtenerInstancia()
            cmd = New SqlCommand()
            cmd.Connection = sqlCn
            cmd.CommandText = "PCCRCC_PCCalendario_Sel"
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
                Dim listaCalendario As New List(Of Calendario)
                reader = cmd.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        Dim calendarioMedicion As New Calendario
                        'calendarioMedicion.CalendarioCDesde = reader.GetDateTime(reader.GetOrdinal("StartDate"))
                        'calendarioMedicion.CalendarioCHasta = reader.GetDateTime(reader.GetOrdinal("EndDate"))
                        'calendarioMedicion.CalendarioCRevisado = reader.GetDateTime(reader.GetOrdinal("CalendarioCRevisado"))
                        'calendarioMedicion.CalendarioCCRevisado = If(reader.IsDBNull(reader.GetOrdinal("CalendarioCCRevisado")), New DateTime, reader.GetDateTime(reader.GetOrdinal("CalendarioCCRevisado")))
                        'calendarioMedicion.CalendarioCCMeta = If(reader.IsDBNull(reader.GetOrdinal("CalendarioCCMeta")), New DateTime, reader.GetDateTime(reader.GetOrdinal("CalendarioCCMeta")))

                        calendarioMedicion.CalendarioCDesde = reader.GetDateTime(reader.GetOrdinal("StartDate"))
                        calendarioMedicion.CalendarioCHasta = reader.GetDateTime(reader.GetOrdinal("EndDate"))
                        calendarioMedicion.CalendarioCRevisado = reader.GetDateTime(reader.GetOrdinal("EndDate"))
                        calendarioMedicion.CalendarioCCRevisado = If(reader.IsDBNull(reader.GetOrdinal("EndDate")), New DateTime, reader.GetDateTime(reader.GetOrdinal("EndDate")))
                        calendarioMedicion.CalendarioCCMeta = If(reader.IsDBNull(reader.GetOrdinal("EndDate")), New DateTime, reader.GetDateTime(reader.GetOrdinal("EndDate")))

                        listaCalendario.Add(calendarioMedicion)
                    End While
                End If
                Return listaCalendario
            Catch ex As Exception
                Throw ex
            End Try
        End Using
    End Function

    Public Function ActualizaCalendarioMedicion(ByVal idMedicionZona As Integer, ByVal fechaObjetivo As Date) As Boolean
        Dim iRetorna As Int16 = 1 'Con algun error ...
        Dim aParametros(3, 2) As String
        Try
            aParametros(0, 0) = "@IdMedicionZona"
            aParametros(0, 1) = "Int"
            aParametros(0, 2) = idMedicionZona
            aParametros(1, 0) = "@FechaMeta"
            aParametros(1, 1) = "Date"
            aParametros(1, 2) = fechaObjetivo
            aParametros(2, 0) = "@RETORNA"
            aParametros(2, 1) = "SmallInt"
            aParametros(2, 2) = iRetorna
            CCRCC_EjecutaProcedimiento("PCCRCC_PCCalendario_Upd", 3, aParametros, iRetorna)
            If iRetorna = 0 Then
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CargarCalendario(ByVal idMedicionZona As Integer) As DataSet
        Try
            Dim iRetorna As Int16 = 0
            Dim connection = ObtenerInstancia()
            Dim appointmentsSelectCommand As New SqlCommand
            Dim appointmentsDataAdapter As New SqlDataAdapter
            Dim dsCalendario As New DataSet

            appointmentsSelectCommand.Connection = connection
            appointmentsSelectCommand.CommandText = "PCCRCC_PCCalendario_Sel"
            appointmentsSelectCommand.CommandType = CommandType.StoredProcedure
            appointmentsSelectCommand.Parameters.Add("@IdMedicionZona", SqlDbType.Int).Value = idMedicionZona
            appointmentsSelectCommand.Parameters.Add("@RETORNA", SqlDbType.SmallInt).Value = iRetorna

            appointmentsDataAdapter = New SqlDataAdapter(appointmentsSelectCommand)
            appointmentsDataAdapter.Fill(dsCalendario)
            Return dsCalendario
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
