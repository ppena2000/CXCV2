Imports DevExpress.XtraTreeList.Nodes
Imports CCR.AnalisisxCuidad.BE
Imports CCR.AnalisisxCuidad.Support.Constants
Imports CCR.AnalisisxCuidad.BL
Imports System.Linq
Imports DevExpress.XtraTreeList

Public Class ucEncuestaNegocios

#Region "Variables Locales"
    Dim listaIds As List(Of Int64)
    Dim lastId As Int64
    Friend lstrCodigoNegocio As String
    'Dim encuestasQy As Integer
#End Region

#Region "Metodos Internos"

    Public Sub GenerarArbolEncuestas()
        '#T518F20150713
        gstrCodigoNegocio = lstrCodigoNegocio
        Try
            gridSecundario.Nodes.Clear()
            Dim listaEncuestas = New PlantillasBL().ObtenerEncuesta(gstrCodigoNegocio)
            If listaEncuestas.Any() Then
                gridSecundario.DataSource = listaEncuestas.ToList()
                'gridSecundario.BestFitColumns()
                gridSecundario.ExpandAll()
            Else
                gridSecundario.DataSource = Nothing
                frmPrincipal.siStatus.Caption = NO_SE_ENCONTRO_INFORMACION
            End If
            '+P ResaltarUltimoNodoseleccionado()
        Catch ex As Exception
            frmPrincipal.siStatus.Caption = MensajeError(ERROR_MOSTRAR_ENCUESTA, ex.Message)
        End Try
    End Sub

    Private Sub ResaltarUltimoNodoseleccionado()
        Try
            For Each negocios As TreeListNode In gridSecundario.Nodes
                For Each categorias As TreeListNode In negocios.Nodes
                    For Each skus As TreeListNode In categorias.Nodes
                        If lastId <> 0 Then
                            If Convert.ToInt64(skus.GetValue(clIdTemporal)).Equals(lastId) Then
                                negocios.ExpandAll()
                                categorias.ExpandAll()
                                skus.Selected = True
                                Return
                            End If
                        End If
                    Next
                Next
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function DevuelveIdEncuestaCategoriasSeleccionadas() As String
        Try
            Dim idsEncuestaSku As String = String.Empty
            listaIds = New List(Of Int64)()
            For Each node As TreeListNode In gridSecundario.Nodes
                For Each childNode As TreeListNode In node.Nodes
                    For Each encuestaNode As TreeListNode In childNode.Nodes
                        If encuestaNode.CheckState = CheckState.Checked Then
                            idsEncuestaSku = idsEncuestaSku + "," + encuestaNode.GetValue(clIdTemporal).ToString()
                            listaIds.Add(Convert.ToInt32(encuestaNode.GetValue(clIdTemporal)))
                        End If
                    Next
                Next
            Next
            If listaIds.Any() Then
                lastId = listaIds.Last()
                idsEncuestaSku = idsEncuestaSku.Remove(0, 1)
            End If
            Return idsEncuestaSku
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub ActualizaEncuestas()
        Try
            Dim plantillaBL As New PlantillasBL()
            Dim retorno = plantillaBL.ActualizarEncuestaEditada()
            If retorno Then
                frmPrincipal.siStatus.Caption = ENCUESTA_ACTUALIZACION_EXITO
                MsgBox("Los cambios se han guardado con Exito, se volvera a cargar la Encuesta", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Actualización de Encuesta")
                MODCCLocal_Todos(cBtnSincronizar)
            End If
        Catch ex As Exception
            frmPrincipal.siStatus.Caption = MensajeError(ERROR_ACTUALIZAR_ENCUESTA, ex.Message)
        End Try
    End Sub

    Private Sub ActualizarValoresEncuesta(ByVal e As DevExpress.XtraTreeList.CellValueChangedEventArgs)
        Try
            Dim encuesta = New EncuestaXML()
            encuesta.P0_CM1PFac = Convert.ToInt32(e.Node.GetValue(clP0_CM1PFac))
            encuesta.P0_CM2PFac = Convert.ToInt32(e.Node.GetValue(clP0_CM2PFac))
            encuesta.P0_IAntFac = Convert.ToInt32(e.Node.GetValue(clP0_IAntFac))
            encuesta.P0_INVFac = Convert.ToInt32(e.Node.GetValue(clP0_INVFac))
            encuesta.P0_PREFac = Convert.ToDecimal(e.Node.GetValue(clP0_PREFac))
            encuesta.P0_PRE2Fac = Convert.ToDecimal(e.Node.GetValue(clP0_PRE2Fac))
            encuesta.P0_REG = Convert.ToInt32(e.Node.GetValue(clP0_REG))
            encuesta.IdTemporal = Convert.ToInt32(e.Node.GetValue(clIdTemporal))
            encuesta.Comentarios = Convert.ToString(e.Node.GetValue(clComentarios)).Trim()
            Dim plantilla As New PlantillasBL
            plantilla.ActualizaEncuestaTemporal(encuesta)
            frmPrincipal.siStatus.Caption = ENCUESTA_ACTUALIZACION_EXITO
            lastId = encuesta.IdTemporal
            '+P ResaltarUltimoNodoseleccionado()
        Catch ex As Exception
            frmPrincipal.siStatus.Caption = MensajeError(ERROR_ACTUALIZAR_ENCUESTA, ex.Message)
        End Try
    End Sub

    Public Sub CambiarEstado(ByVal estado As Short)
        Try
            Dim idsEncuestaSku As String = DevuelveIdEncuestaCategoriasSeleccionadas()
            If idsEncuestaSku.Trim().Length > 0 Then
                Dim plantilla As New PlantillasBL()
                plantilla.CambiaEstado(idsEncuestaSku, estado)
                GenerarArbolEncuestas()
                gbEncuestaExistenCambios = True
                frmPrincipal.btnGrabar.Enabled = gbEncuestaExistenCambios
                frmPrincipal.btnVaciar.Enabled = frmPrincipal.btnGrabar.Enabled
            Else
                MessageBox.Show(SELECCIONAR_REGISTRO)
            End If
        Catch ex As Exception
            frmPrincipal.siStatus.Caption = MensajeError(ERROR_ACTUALIZAR_ENCUESTA, ex.Message)
        End Try
    End Sub


    Public Sub ReplicaEncuesta(ByVal tipoReplica As Int16)
        Dim idsEncuesta = DevuelveIdEncuestaCategoriasSeleccionadas()
        Try
            If listaIds.Any() Then
                Dim result As DialogResult = MessageBox.Show("¿El sistema realizara el ajuste de " + listaIds.Count.ToString() + " registros, Esta seguro de continuar?", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If result = DialogResult.Yes Then
                    Dim plantilla As New PlantillasBL()
                    Dim retorno = plantilla.ReplicaEncuesta(idsEncuesta, tipoReplica)

                    If retorno Then
                        GenerarArbolEncuestas()
                        frmPrincipal.siStatus.Caption = ENCUESTA_REPLICA_EXITO
                    Else
                        frmPrincipal.siStatus.Caption = ENCUESTA_REPLICA_ERROR
                    End If
                End If
            Else
                MessageBox.Show(SELECCIONAR_REGISTRO)
            End If
        Catch ex As Exception
            frmPrincipal.siStatus.Caption = MensajeError(ERROR_ACTUALIZAR_ENCUESTA, ex.Message)
        End Try
    End Sub

    Public Sub ReplicaSku(ByVal tipoReplica As Int16)
        Try
            Dim idsEncuesta = DevuelveIdEncuestaCategoriasSeleccionadas()
            If listaIds.Any() Then
                Dim result As DialogResult = MessageBox.Show("¿El sistema realizara el ajuste de " + listaIds.Count.ToString() + " registros, Esta seguro de continuar?", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If result = DialogResult.Yes Then
                    Dim plantilla As New PlantillasBL()
                    Dim retorno = plantilla.ReplicaSku(idsEncuesta, tipoReplica)

                    If retorno Then
                        GenerarArbolEncuestas()
                        frmPrincipal.siStatus.Caption = SKU_REPLICA_EXITO
                    Else
                        frmPrincipal.siStatus.Caption = SKU_REPLICA_ERROR
                    End If
                End If
            Else
                MessageBox.Show(SELECCIONAR_REGISTRO)
            End If
        Catch ex As Exception
            frmPrincipal.siStatus.Caption = MensajeError(ERROR_ACTUALIZAR_ENCUESTA, ex.Message)
        End Try
    End Sub

    Public Sub VaciarCarpetaTrabajo()
        Try
            Dim result As DialogResult = MessageBox.Show("¿Desea eliminar los cambios realizados hasta el momento?", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = DialogResult.Yes Then
                Dim plantilla As New PlantillasBL()
                Dim respuesta = plantilla.VaciarEncuestaEditada()
                If respuesta Then
                    frmPrincipal.siStatus.Caption = VACIAR_CARPETA_TRABAJO
                    gridSecundario.DataSource = Nothing
                    gridSecundario.Nodes.Clear()
                    gbEncuestaExistenCambios = False
                    frmPrincipal.btnGrabar.Enabled = gbEncuestaExistenCambios
                    frmPrincipal.btnVaciar.Enabled = frmPrincipal.btnGrabar.Enabled
                Else
                    frmPrincipal.siStatus.Caption = ACCION_INTERRUMPIDA
                End If
            End If
        Catch ex As Exception
            frmPrincipal.siStatus.Caption = MensajeError(ERROR_ACTUALIZAR_ENCUESTA, ex.Message)
        End Try
    End Sub

    Friend Sub MODCCLocal_Todos(ByVal liBoton As Integer)
        ' Dim fc01 As FilterCondition, fc02 As FilterCondition
        'cbtnSkuActivarRegistro, cbtnSkuPonerAtipico, cbtnSkuPonerNoProcesa
        Select Case liBoton
            Case cbtnSkuActivarRegistro 'cbtnActivar
                CambiarEstado(0)
            Case cbtnSkuPonerAtipico 'cbtnAtipicos, cbtnCambiarEstadoAtipico
                CambiarEstado(1)
            Case cbtnSkuPonerNoProcesa 'cbtnCambiarEstadoNoProcesa
                CambiarEstado(2)
            Case cbtnVaciar
                VaciarCarpetaTrabajo()
            Case cBtnGrabar
                ActualizaEncuestas()
            Case cBtnReplicaEncuestaAnterior
                ReplicaEncuesta(0)
            Case cbtnReplicaSKU
                ReplicaSku(0)
            Case cBtnReplicaEncuestaPromedio
                ReplicaEncuesta(1)
            Case cBtnReplicaSkuPromedio
                ReplicaSku(1)
            Case cBtnSincronizar
                GenerarArbolEncuestas()
            Case cbtnVaciar
                VaciarCarpetaTrabajo()
                '' '' ''Case cbtnCorrectos, cbtnPendientes, cBtnSupervisionResumen, cbtnEnSupervision, cBtnSupervisionValidar, cbtnValidados, cbtnAtipicos, cbtnNoProcesa
                '' '' ''    'Aqui se ouede hacer el filtro por estado de negocios para todos..
                '' '' ''    Me.gridSecundario.OptionsBehavior.EnableFiltering = True
                '' '' ''    fc02 = New FilterCondition(FilterConditionEnum.Equals, Me.gridSecundario.Columns("Estado"), liBoton - 60)
                '' '' ''    Me.gridSecundario.FilterConditions.Add(fc02)
                '' '' ''Case cbtnEstadoTodos
                '' '' ''    Me.gridSecundario.OptionsBehavior.EnableFiltering = False

                '' '' ''Case cBtnVerDatosCampo, cBtnVerDatosSupervision, cBtnVerDatosAjustados
                '' '' ''    'Me.gridSecundario.OptionsBehavior.EnableFiltering = False
                '' '' ''    'Me.gridSecundario.ClearColumnFilter(Me.gridSecundario.Columns(5))
                '' '' ''    Me.gridSecundario.OptionsBehavior.EnableFiltering = True
                '' '' ''    fc01 = New FilterCondition(FilterConditionEnum.Equals, Me.gridSecundario.Columns("TipoDato"), liBoton - 21)
                '' '' ''    Me.gridSecundario.FilterConditions.Add(fc01)
                '' '' ''Case cBtnVerTodos
                '' '' ''    Me.gridSecundario.OptionsBehavior.EnableFiltering = False
        End Select
        gbEncuestaExistenCambios = (FCCRCC_EncuestaConsultaExistenciaTemporal() > 0)
        frmPrincipal.btnGrabar.Enabled = gbEncuestaExistenCambios
        frmPrincipal.btnVaciar.Enabled = frmPrincipal.btnGrabar.Enabled
    End Sub
#End Region

#Region "Manejo de Eventos"
    Private Sub ucEncuestaNegocios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If giMostrarEncuesta = 1 Then
            'MsgBox("Existen  " + FCCRCC_EncuestaConsultaExistenciaTemporal().ToString + " Regs en Tenmporal", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            MODCCLocal_Todos(cBtnSincronizar)
            giMostrarEncuesta = 0
            'Verificar si existen datos en el temporal, para activar los botones Grabar y Vaciar.
            'Si existe plantilla, se recupera...
        End If
    End Sub

    Private Sub gridSecundario_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridSecundario.Click
        giGridActivo = 2
    End Sub

    Private Sub gridSecundario_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridSecundario.DoubleClick
        Dim oGrid As New DevExpress.XtraGrid.GridControl
        PCCRCC_SkuEstadisticas(oGrid, gridSecundario)
    End Sub

    Private Sub gridSecundario_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.CellValueChangedEventArgs) Handles gridSecundario.CellValueChanged
        If e.Node.Level = 2 Then
            Dim iId As Long, iNegSku As Long
            iId = Convert.ToInt64(e.Node.GetValue(clId))
            iNegSku = gridSecundario.FocusedNode.Id
            ActualizarValoresEncuesta(e)
            gbEncuestaExistenCambios = True
            frmPrincipal.btnGrabar.Enabled = gbEncuestaExistenCambios
            frmPrincipal.btnVaciar.Enabled = frmPrincipal.btnGrabar.Enabled
            ' ''+P  Se comenta porue no es necesario volver a cargar si la data ya esta actualizada.... en BD y grid
            ''GenerarArbolEncuestas()
            ''Iralnodoultimo(iNegSku)
        End If
    End Sub

    Private Sub Iralnodoultimo(ByVal iId As Long)
        gridSecundario.ExpandAll()
        'Dim node As TreeListNode = gridSecundario.FindNodeByFieldValue("CodigoNegocioSku", iId)
        Dim node As TreeListNode = gridSecundario.FindNodeByID(iId)
        If node IsNot Nothing Then
            gridSecundario.FocusedNode = node 'gridSecundario.Nodes(2)
        End If
        'gridSecundario.SetFocusedNode = node
    End Sub
#End Region
End Class
