Imports CCR.AnalisisxCuidad.BE
Imports System.Data.SqlClient
Imports System.Xml

Public Class EncuestaDAO : Inherits ConnectionHelper
    Public Sub New()
    End Sub

    Public Function ObtenerEncuesta(ByVal lsIdMedicionZonaCanalNegocios As String) As IList(Of EncuestaXML)
        Dim cmd As SqlCommand
        'Dim reader As XmlReader

        Using sqlCn As SqlConnection = ObtenerInstancia()
            cmd = New SqlCommand()
            cmd.Connection = sqlCn
            cmd.CommandText = "PCCRCC_ConsultaEncuestasXML_V2"
            cmd.CommandType = CommandType.StoredProcedure

            Dim prmIdsMedicionZonaCanalNegocios As New SqlParameter()
            prmIdsMedicionZonaCanalNegocios.ParameterName = "@sIdMedicionZonaCanalNegocios"
            prmIdsMedicionZonaCanalNegocios.DbType = DbType.String
            prmIdsMedicionZonaCanalNegocios.Value = lsIdMedicionZonaCanalNegocios
            cmd.Parameters.Add(prmIdsMedicionZonaCanalNegocios)

            Try
                sqlCn.Open()
                Dim listaEncuestas As New List(Of EncuestaXML)
                Using reader = cmd.ExecuteXmlReader()
                    While reader.Read()
                        Dim encuestaXML As New EncuestaXML
                        If (reader.NodeType = XmlNodeType.Element And "Encuesta" = reader.LocalName) Then
                            encuestaXML.Id = Convert.ToInt64(reader.GetAttribute("Id"))
                            encuestaXML.ParentId = Convert.ToInt64(reader.GetAttribute("ParentId"))
                            encuestaXML.Descripcion = Convert.ToString(reader.GetAttribute("Descripcion"))
                            encuestaXML.IdEncuestaCategoriaSku = Convert.ToInt32(reader.GetAttribute("IdEncuestaCategoriaSku"))
                            encuestaXML.IdTemporal = Convert.ToInt32(reader.GetAttribute("IdTemporal"))
                            encuestaXML.TipoActivo = Convert.ToByte(reader.GetAttribute("TipoActivo"))
                            encuestaXML.TipoDato = Convert.ToByte(reader.GetAttribute("TipoDato"))
                            encuestaXML.CodigoNegocio = Convert.ToInt32(reader.GetAttribute("CodigoNegocio"))
                            encuestaXML.Frecuencia = Convert.ToByte(reader.GetAttribute("Frecuencia"))
                            encuestaXML.P0_IAntFac = Convert.ToInt32(reader.GetAttribute("P0_IAntFac"))
                            encuestaXML.P0_CM1PFac = Convert.ToInt32(reader.GetAttribute("P0_CM1Fac"))
                            encuestaXML.P0_CM2PFac = Convert.ToInt32(reader.GetAttribute("P0_CM2Fac"))
                            encuestaXML.P0_INVFac = Convert.ToInt32(reader.GetAttribute("P0_INVFac"))
                            encuestaXML.P0_PREFac = Convert.ToDecimal(reader.GetAttribute("P0_PREFac"))
                            encuestaXML.P0_REG = Convert.ToInt32(reader.GetAttribute("P0_REG"))
                            encuestaXML.P1_IANTFac = Convert.ToInt32(reader.GetAttribute("P1_IANTFac"))
                            encuestaXML.P1_CM1PFac = Convert.ToInt32(reader.GetAttribute("P1_CM1Fac"))
                            encuestaXML.P1_CM2PFac = Convert.ToInt32(reader.GetAttribute("P1_CM2Fac"))
                            encuestaXML.P1_INVFac = Convert.ToInt32(reader.GetAttribute("P1_INVFac"))
                            encuestaXML.P1_PREFac = Convert.ToDecimal(reader.GetAttribute("P1_PREFac"))
                            encuestaXML.P1_REG = Convert.ToInt32(reader.GetAttribute("P1_REG"))
                            encuestaXML.P2_IANTFac = Convert.ToInt32(reader.GetAttribute("P2_IANTFac"))
                            encuestaXML.P2_CM1PFac = Convert.ToInt32(reader.GetAttribute("P2_CM1Fac"))
                            encuestaXML.P2_CM2PFac = Convert.ToInt32(reader.GetAttribute("P2_CM2Fac"))
                            encuestaXML.P2_INVFac = Convert.ToInt32(reader.GetAttribute("P2_INVFac"))
                            encuestaXML.P2_PREFac = Convert.ToDecimal(reader.GetAttribute("P2_PREFac"))
                            encuestaXML.P2_REG = Convert.ToInt32(reader.GetAttribute("P2_REG"))
                            encuestaXML.Comentarios = Convert.ToString(reader.GetAttribute("Comentario"))
                            encuestaXML.CodigoUsuario = Convert.ToInt16(reader.GetAttribute("CodigoUsuario"))
                            encuestaXML.Estado = Convert.ToByte(reader.GetAttribute("Estado"))
                            encuestaXML.CodigoSku = Convert.ToInt32(reader.GetAttribute("CodigoSku"))
                            encuestaXML.CodigoSkuOriginal = Convert.ToInt32(reader.GetAttribute("CodigoSkuOriginal"))
                            'encuestaXML.CodigoNegocioSku = reader.GetAttribute("CodigoNegocioSku").ToString()
                            encuestaXML.CodigoCategoriaAgrupada = Convert.ToInt32(reader.GetAttribute("CodigoCategoriaAgrupada"))
                            encuestaXML.Sku = Convert.ToString(reader.GetAttribute("Sku"))
                            encuestaXML.Editado = Convert.ToByte(reader.GetAttribute("Editado"))
                            encuestaXML.P0_VtaFac = Convert.ToInt32(reader.GetAttribute("P0_VtaFac"))
                            encuestaXML.P1_VtaFac = Convert.ToInt32(reader.GetAttribute("P1_VtaFac"))
                            encuestaXML.P2_VtaFac = Convert.ToInt32(reader.GetAttribute("P2_VtaFac"))
                            'ppm
                            encuestaXML.EditadoAnterior = Convert.ToByte(reader.GetAttribute("EditadoAnterior"))
                            encuestaXML.EstadoRegistro = Convert.ToByte(reader.GetAttribute("EstadoRegistro"))

                            encuestaXML.P0_PRE2Fac = Convert.ToDecimal(reader.GetAttribute("P0_PRE2Fac"))
                            encuestaXML.P1_PRE2Fac = Convert.ToDecimal(reader.GetAttribute("P1_PRE2Fac"))
                            encuestaXML.P2_PRE2Fac = Convert.ToDecimal(reader.GetAttribute("P2_PRE2Fac"))
                            encuestaXML.TipoAjuste = Convert.ToDecimal(reader.GetAttribute("TipoAjuste"))
                            encuestaXML.TipoDistribucion = Convert.ToInt16(reader.GetAttribute("TipoDistribucion"))

                            listaEncuestas.Add(encuestaXML)
                        End If
                    End While
                End Using
                Return listaEncuestas
            Catch ex As Exception
                Throw ex
            End Try
        End Using
    End Function

    Public Function ReplicaSku(ByVal codigosNegocio As String, ByVal tipoReplica As Int16) As Boolean
        Dim encuestaRepuesta As Boolean
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader

        Using sqlCn As SqlConnection = ObtenerInstancia()
            cmd = New SqlCommand() With { _
             .Connection = sqlCn, _
             .CommandText = "PCCRCC_EncuestaReplicaSku", _
             .CommandType = CommandType.StoredProcedure _
            }
            cmd.Parameters.Add(New SqlParameter() With { _
             .ParameterName = "@sCodigoNegocioSku", _
             .DbType = DbType.String, _
             .Value = codigosNegocio, _
             .Size = 2500})
            cmd.Parameters.Add(New SqlParameter() With { _
             .ParameterName = "@iTipoReplica", _
             .DbType = DbType.Int16, _
             .Value = tipoReplica})

            Try
                sqlCn.Open()
                reader = cmd.ExecuteReader()

                If reader.HasRows Then
                    While reader.Read()
                        encuestaRepuesta = reader.GetBoolean(reader.GetOrdinal("registroStatus"))
                    End While
                End If
                Return encuestaRepuesta
            Catch ex As Exception
                Throw ex
            End Try
        End Using
    End Function

    Public Function ReplicaEncuesta(ByVal codigosNegocio As String, ByVal tipoReplica As Int16) As Boolean
        Dim encuestaRepuesta As Boolean
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader

        Using sqlCn As SqlConnection = ObtenerInstancia()
            cmd = New SqlCommand() With { _
             .Connection = sqlCn, _
             .CommandText = "PCCRCC_EncuestaReplicaEncuesta", _
             .CommandType = CommandType.StoredProcedure _
            }
            cmd.Parameters.Add(New SqlParameter() With { _
             .ParameterName = "@sCodigosNegocios", _
             .DbType = DbType.String, _
             .Value = codigosNegocio, _
             .Size = 2500 _
            })
            cmd.Parameters.Add(New SqlParameter() With { _
             .ParameterName = "@iTipoReplica", _
             .DbType = DbType.Int16, _
             .Value = tipoReplica})

            Try
                sqlCn.Open()
                reader = cmd.ExecuteReader()

                If reader.HasRows Then
                    While reader.Read()
                        encuestaRepuesta = reader.GetBoolean(reader.GetOrdinal("registroStatus"))
                    End While
                End If
                Return encuestaRepuesta
            Catch ex As Exception
                Throw ex
            End Try
        End Using
    End Function

    Public Sub CambiaEstado(ByVal lsidEncuestaCategoriaSku As String, ByVal estado As Int16)
        Dim cmd As SqlCommand

        Using sqlCn As SqlConnection = ObtenerInstancia()
            cmd = New SqlCommand() With { _
             .Connection = sqlCn, _
             .CommandText = "PCCRCC_EncuestaCambiarEstado", _
             .CommandType = CommandType.StoredProcedure _
            }

            Dim prmEncuestaIdLs = New SqlParameter
            prmEncuestaIdLs.ParameterName = "@sCodigoNegocioSku"
            prmEncuestaIdLs.DbType = DbType.String
            prmEncuestaIdLs.Value = lsidEncuestaCategoriaSku
            cmd.Parameters.Add(prmEncuestaIdLs)

            Dim prmEstado As New SqlParameter

            prmEstado.ParameterName = "@estado"
            prmEstado.DbType = DbType.Int16
            prmEstado.Value = estado
            cmd.Parameters.Add(prmEstado)

            Try
                sqlCn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Throw ex
            End Try
        End Using
    End Sub

    Public Function ActualizarEncuestaEditada() As Boolean
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader
        Dim encuestaRepuesta As Boolean

        Using sqlCn As SqlConnection = ObtenerInstancia()
            cmd = New SqlCommand() With { _
             .Connection = sqlCn, _
             .CommandText = "PCCRCC_EncuestasEditadasGrabar", _
             .CommandType = CommandType.StoredProcedure _
            }
            Try
                sqlCn.Open()
                reader = cmd.ExecuteReader()

                If reader.HasRows Then
                    While reader.Read()
                        encuestaRepuesta = reader.GetBoolean(reader.GetOrdinal("registroStatus"))
                    End While
                End If
                Return encuestaRepuesta
            Catch ex As Exception
                MsgBox("ERROR en la Grabacion de Datos. Comuniquese con Sistemas!" + vbCrLf + "Mensaje de Error: " + ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "CCRCXC Grabacion de datos Editados")
                Throw ex
            End Try
        End Using
    End Function

    Public Sub ActualizaEncuestaTemporal(ByVal encuesta As EncuestaXML)
        Dim cmd As SqlCommand

        Using sqlCn As SqlConnection = ObtenerInstancia()
            cmd = New SqlCommand() With { _
             .Connection = sqlCn, _
             .CommandText = "PCCRCC_EncuestaActualizaTemporal", _
             .CommandType = CommandType.StoredProcedure _
            }
            cmd.Parameters.Add(New SqlParameter() With { _
             .ParameterName = "@IdTemporal", _
             .DbType = DbType.Int32, _
             .Value = encuesta.IdTemporal _
            })
            cmd.Parameters.Add(New SqlParameter() With { _
             .ParameterName = "@P0_IAntFac", _
             .DbType = DbType.Int32, _
             .Value = encuesta.P0_IAntFac _
            })
            cmd.Parameters.Add(New SqlParameter() With { _
             .ParameterName = "@P0_CM1Fac", _
             .DbType = DbType.Int32, _
             .Value = encuesta.P0_CM1PFac _
            })
            cmd.Parameters.Add(New SqlParameter() With { _
             .ParameterName = "@P0_CM2Fac", _
             .DbType = DbType.Int32, _
             .Value = encuesta.P0_CM2PFac _
            })
            cmd.Parameters.Add(New SqlParameter() With { _
             .ParameterName = "@P0_INVFac", _
             .DbType = DbType.Int32, _
             .Value = encuesta.P0_INVFac _
            })
            cmd.Parameters.Add(New SqlParameter() With { _
             .ParameterName = "@P0_PREFac", _
             .DbType = DbType.Currency, _
             .Value = encuesta.P0_PREFac _
            })
            cmd.Parameters.Add(New SqlParameter() With { _
             .ParameterName = "@Comentarios", _
             .DbType = DbType.String, _
             .Value = encuesta.Comentarios _
            })
            cmd.Parameters.Add(New SqlParameter() With { _
            .ParameterName = "@P0_PRE2Fac", _
            .DbType = DbType.Currency, _
            .Value = encuesta.P0_PRE2Fac _
           })


            Try
                sqlCn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Throw ex
            End Try
        End Using
    End Sub

    Public Function VaciarEncuestaEditada() As Boolean
        Dim encuestaRepuesta As Boolean
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader

        Using sqlCn As SqlConnection = ObtenerInstancia()
            cmd = New SqlCommand() With { _
             .Connection = sqlCn, _
             .CommandText = "PCCRCC_VaciarCarpetaTrabajo", _
             .CommandType = CommandType.StoredProcedure _
            }
            Try
                sqlCn.Open()
                reader = cmd.ExecuteReader()

                If reader.HasRows Then
                    While reader.Read()
                        encuestaRepuesta = reader.GetBoolean(reader.GetOrdinal("registroStatus"))
                    End While
                End If
                Return encuestaRepuesta
            Catch ex As Exception
                Throw ex
            End Try
        End Using
    End Function

    Public Sub ReplicaEncuestaSeleccionada(ByVal strIdsMedicionZona As String, ByVal boton As Integer)
        Dim iRetorna As Int16 = 0
        Try
            Dim aParametros(2, 2) As String
            aParametros(0, 0) = "@sIdMedicionZonaCanalNegocio"
            aParametros(0, 1) = "Char"
            aParametros(0, 2) = strIdsMedicionZona
            aParametros(1, 0) = "@iTipoReplica"
            aParametros(1, 1) = "SmallInt"
            aParametros(1, 2) = boton
            CCRCC_EjecutaProcedimiento("PCCRCC_CambiarEstadoNegocios_upd", 2, aParametros, iRetorna)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CambiarEstadoMultiplesEncuestas(ByVal lsIds As String, ByVal estadoBoton As Integer, ByVal indicador As Integer, ByVal grdActivo As Integer)
        Dim iRetorna As Int16 = 0
        Try
            Dim aParametros(4, 2) As String
            aParametros(0, 0) = "@lsIds"
            aParametros(0, 1) = "Char"
            aParametros(0, 2) = lsIds
            aParametros(1, 0) = "@Estado"
            aParametros(1, 1) = "SmallInt"
            ' aParametros(1, 2) = If(piBoton = cbtnAtipico, 6, If(piBoton = cbtnNoProcesa, 7, 5))
            aParametros(1, 2) = estadoBoton
            aParametros(2, 0) = "pintIdIndicador"
            aParametros(2, 1) = "SmallInt"
            aParametros(2, 2) = indicador
            aParametros(3, 0) = "@IdGrilla"
            aParametros(3, 1) = "SmallInt"
            aParametros(3, 2) = grdActivo
            CCRCC_EjecutaProcedimiento("PCCRCC_EncuestaCambiarEstadoMulti_Upd", 4, aParametros, iRetorna)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ActualizaSkuNegocioInventario(ByVal encuestaReemplazo As SkuReemplazo)
        Dim cmd As SqlCommand

        Using sqlCn As SqlConnection = ObtenerInstancia()
            cmd = New SqlCommand() With { _
             .Connection = sqlCn, _
             .CommandText = "PCCRCC_SKU_Reemplazo_Nivel_Negocios", _
             .CommandType = CommandType.StoredProcedure _
            }
            cmd.Parameters.Add(New SqlParameter() With { _
             .ParameterName = "@sCadenaIdSkus", _
             .DbType = DbType.String, _
             .Value = encuestaReemplazo.LsCadenaIds _
            })
            cmd.Parameters.Add(New SqlParameter() With { _
             .ParameterName = "@IdMedicionZona", _
             .DbType = DbType.Int32, _
             .Value = encuestaReemplazo.IdMedicionZona _
            })
            cmd.Parameters.Add(New SqlParameter() With { _
             .ParameterName = "@TipoAccion", _
             .DbType = DbType.Int32, _
             .Value = encuestaReemplazo.TipoAccion _
            })
            cmd.Parameters.Add(New SqlParameter() With { _
             .ParameterName = "@CodigoSkuReemplazo", _
             .DbType = DbType.Int32, _
             .Value = encuestaReemplazo.CodigoSkuReemplazo _
            })
            cmd.Parameters.Add(New SqlParameter() With { _
             .ParameterName = "@Peso", _
             .DbType = DbType.Int32, _
             .Value = encuestaReemplazo.Peso _
            })
            cmd.Parameters.Add(New SqlParameter() With { _
             .ParameterName = "@Nivel", _
             .DbType = DbType.Int32, _
             .Value = encuestaReemplazo.Nivel _
            })
            cmd.Parameters.Add(New SqlParameter() With { _
             .ParameterName = "@IndicadorOrigen", _
             .DbType = DbType.Int32, _
             .Value = encuestaReemplazo.IndicadorOrigen _
            })
            cmd.Parameters.Add(New SqlParameter() With { _
             .ParameterName = "@IdMedicionZonaCanalNegocio", _
             .DbType = DbType.Int32, _
             .Value = encuestaReemplazo.IdMedicionZonaCanalNegocio _
            })

            Try
                sqlCn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Throw ex
            End Try
        End Using
    End Sub
End Class
