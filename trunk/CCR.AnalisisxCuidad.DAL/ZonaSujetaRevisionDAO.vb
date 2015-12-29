Imports CCR.AnalisisxCuidad.BE
Imports System.Data.SqlClient
Imports CCR.AnalisisxCuidad.Support

Public Class ZonaSujetaRevisionDAO : Inherits ConnectionHelper
    Public Sub New()
    End Sub

    Public Function ConsultaZonasSujetasRevision(ByVal periodoMesEstudio As Integer) As IList(Of ZonaSujetaRevision)
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader

        Using sqlCn As SqlConnection = ObtenerInstancia()
            cmd = New SqlCommand()
            cmd.Connection = sqlCn
            cmd.CommandText = "PCCRCC_Avance_Sel"
            cmd.CommandType = CommandType.StoredProcedure
            'Agregamos el parametro a usarse
            Dim periodoMesEstudioPrm As New SqlParameter()
            periodoMesEstudioPrm.ParameterName = "@PMESTDO"
            periodoMesEstudioPrm.DbType = DbType.Int32
            periodoMesEstudioPrm.Value = periodoMesEstudio
            cmd.Parameters.Add(periodoMesEstudioPrm)

            Try
                sqlCn.Open()
                reader = cmd.ExecuteReader()
                Dim listaZonaSujetaRevision As New List(Of ZonaSujetaRevision)()

                If reader.HasRows Then
                    While reader.Read()
                        Dim zonaAnalisis As ZonaSujetaRevision = New ZonaSujetaRevision
                        zonaAnalisis.IdTCCRCCAvance = reader.GetInt32(reader.GetOrdinal("IdTCCRCC_Avance"))
                        zonaAnalisis.Zona = reader.GetString(reader.GetOrdinal("ZONA"))
                        zonaAnalisis.TotalNegocios = reader.GetInt32(reader.GetOrdinal("TotalNegocios"))
                        zonaAnalisis.Avance = reader.GetInt16(reader.GetOrdinal("Avance"))
                        zonaAnalisis.Alertas = reader.GetInt16(reader.GetOrdinal("Alertas"))
                        zonaAnalisis.TotalErrores = reader.GetInt32(reader.GetOrdinal("TotalErrores"))
                        zonaAnalisis.Estado = If(reader.IsDBNull(reader.GetOrdinal("Estado")), 0, reader.GetByte(reader.GetOrdinal("Estado")))
                        zonaAnalisis.EstadoEtiqueta = If(zonaAnalisis.Estado = True, Constants.ESTADO_ASIGNACION_OK, Constants.ESTADO_ASIGNACION_PENDIENTE)
                        zonaAnalisis.CodigoUsuario = If(reader.IsDBNull(reader.GetOrdinal("CodigoUsuario")), 0, reader.GetInt16(reader.GetOrdinal("CodigoUsuario")))
                        zonaAnalisis.CodigoUsuarioAnterior = If(reader.IsDBNull(reader.GetOrdinal("CodigoUsuarioAnterior")), 0, reader.GetInt16(reader.GetOrdinal("CodigoUsuarioAnterior")))
                        zonaAnalisis.Usuario = reader.GetString(reader.GetOrdinal("Usuario"))
                        zonaAnalisis.UsuarioAnterior = reader.GetString(reader.GetOrdinal("UsuarioAnterior"))
                        zonaAnalisis.C_Desde = If(reader.IsDBNull(reader.GetOrdinal("C_Desde")), "", reader.GetDateTime(reader.GetOrdinal("C_Desde")).ToShortDateString())
                        zonaAnalisis.C_Hasta = If(reader.IsDBNull(reader.GetOrdinal("C_Hasta")), "", reader.GetDateTime(reader.GetOrdinal("C_Hasta")).ToShortDateString())
                        zonaAnalisis.C_Avance = If(reader.IsDBNull(reader.GetOrdinal("C_Avance")), "", reader.GetDateTime(reader.GetOrdinal("C_Avance")).ToShortDateString())
                        zonaAnalisis.CC_Avance = If(reader.IsDBNull(reader.GetOrdinal("CC_Avance")), "", reader.GetDateTime(reader.GetOrdinal("CC_Avance")).ToShortDateString())
                        zonaAnalisis.CC_Meta = If(reader.IsDBNull(reader.GetOrdinal("CC_Meta")), "", reader.GetDateTime(reader.GetOrdinal("CC_Meta")).ToShortDateString())
                        listaZonaSujetaRevision.Add(zonaAnalisis)
                    End While
                End If
                Return listaZonaSujetaRevision
            Catch ex As Exception
                Throw ex
            End Try
        End Using

    End Function

    Public Function ActualizaAvanceUsuario(ByVal periodoMesEstudio As Integer, ByVal idTCCRCC_Avance As Integer, ByVal codigoUsuario As Int16) As Byte
        Dim cmd As SqlCommand

        Using sqlCn As SqlConnection = ObtenerInstancia()
            cmd = New SqlCommand()
            cmd.Connection = sqlCn
            cmd.CommandText = "PCCRCC_AsignaCiudad_Upd"
            cmd.CommandType = CommandType.StoredProcedure

            Dim periodoMesEstudioPrm As New SqlParameter()
            periodoMesEstudioPrm.ParameterName = "@PMESTDO"
            periodoMesEstudioPrm.DbType = DbType.Int32
            periodoMesEstudioPrm.Value = periodoMesEstudio
            cmd.Parameters.Add(periodoMesEstudioPrm)

            Dim idTCCAvancePrm As New SqlParameter()
            idTCCAvancePrm.ParameterName = "@IdTCCRCC_Avance"
            idTCCAvancePrm.DbType = DbType.Int32
            idTCCAvancePrm.Value = idTCCRCC_Avance
            cmd.Parameters.Add(idTCCAvancePrm)

            Dim codigoUsuarioPrm As New SqlParameter()
            codigoUsuarioPrm.ParameterName = "@CodigoUsuario"
            codigoUsuarioPrm.DbType = DbType.Int16
            codigoUsuarioPrm.Value = codigoUsuario
            cmd.Parameters.Add(codigoUsuarioPrm)

            Try
                sqlCn.Open()
                'Revisar retorno de valor 
                Return cmd.ExecuteScalar()
            Catch ex As Exception
                Throw ex
            End Try
        End Using
    End Function

    Public Function ActualizaFechaObjetivo(ByVal idMedicionZona As Integer, ByVal fechaUsuario As Date) As Int16
        Dim cmd As SqlCommand

        Using sqlCn As SqlConnection = ObtenerInstancia()
            cmd = New SqlCommand()
            cmd.Connection = sqlCn
            cmd.CommandText = "PCCRCC_PCCalendario_Upd"
            cmd.CommandType = CommandType.StoredProcedure

            Dim idMedicionZonaPrm As New SqlParameter()
            idMedicionZonaPrm.ParameterName = "@IdMedicionZona"
            idMedicionZonaPrm.DbType = DbType.Int32
            idMedicionZonaPrm.Value = idMedicionZona
            cmd.Parameters.Add(idMedicionZonaPrm)

            Dim codigoUsuarioPrm As New SqlParameter()
            codigoUsuarioPrm.ParameterName = "@FechaMeta"
            codigoUsuarioPrm.DbType = DbType.DateTime
            codigoUsuarioPrm.Value = fechaUsuario
            cmd.Parameters.Add(codigoUsuarioPrm)

            Dim retorna As New SqlParameter()
            retorna.ParameterName = "@RETORNA"
            retorna.DbType = DbType.Int16
            retorna.Direction = ParameterDirection.Output
            cmd.Parameters.Add(retorna)
            Try
                sqlCn.Open()
                'Revisar retorno de valor 
                cmd.ExecuteScalar()
                Return cmd.Parameters("@RETORNA").Value
                'Return Convert.ToInt16(retorna)
            Catch ex As Exception
                Throw ex
            End Try
        End Using
    End Function

    Public Function ObtenerUltimasTresMediciones() As IList(Of Medicion)
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader

        Using sqlCn As SqlConnection = ObtenerInstancia()
            cmd = New SqlCommand()
            cmd.Connection = sqlCn
            cmd.CommandText = "PCCRCC_MedicionesUltimas_Sel"
            cmd.CommandType = CommandType.StoredProcedure

            Try
                Dim listaMediciones As New List(Of Medicion)
                sqlCn.Open()
                reader = cmd.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        Dim medicion As New Medicion
                        medicion.Medicion = reader.GetDecimal(reader.GetOrdinal("PMESTDO"))
                        medicion.Estado = reader.GetInt32(reader.GetOrdinal("Estado"))
                        listaMediciones.Add(medicion)
                    End While
                End If
                Return listaMediciones
                'Revisar retorno de valor 
            Catch ex As Exception
                Throw ex
            End Try
        End Using
    End Function

    Public Function ObtenerUltimaMedicion(ByVal idMedicionZona) As Integer
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader
        Dim medicionActual As Integer

        Using sqlCn As SqlConnection = ObtenerInstancia()
            cmd = New SqlCommand()
            cmd.Connection = sqlCn
            cmd.CommandText = "PCCRCC_ObtenerUltimaMedicion"
            cmd.CommandType = CommandType.StoredProcedure

            Dim parameter As New SqlParameter
            parameter.ParameterName = "@idMedicionZona"
            parameter.DbType = DbType.Int32
            parameter.Value = idMedicionZona
            cmd.Parameters.Add(parameter)
            Try
                sqlCn.Open()
                reader = cmd.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        medicionActual = reader.GetInt32(reader.GetOrdinal("CodigoMedicion"))
                    End While
                End If
                Return medicionActual
            Catch ex As Exception
                Throw ex
            End Try
        End Using
    End Function

    Public Function ListaEstados() As IList(Of Estados)
        Dim lsEstados = New List(Of Estados)
        Dim estadoPendiente = New Estados()
        estadoPendiente.CodigoEstado = 0
        estadoPendiente.Descripcion = "Pendiente"
        Dim estadoPrograma = New Estados()
        estadoPrograma.CodigoEstado = 1
        estadoPrograma.Descripcion = "Programa Envio y Cierra Zona"
        Dim estadoEnvia = New Estados
        estadoEnvia.CodigoEstado = 2
        estadoEnvia.Descripcion = "Envia y Cierra Zona"
        Dim estadoTerminado = New Estados()
        estadoTerminado.CodigoEstado = 3
        estadoTerminado.Descripcion = "Terminado o Cerrado"
        lsEstados.Add(estadoPendiente)
        lsEstados.Add(estadoPrograma)
        lsEstados.Add(estadoEnvia)
        lsEstados.Add(estadoTerminado)
        Return lsEstados
    End Function

End Class
