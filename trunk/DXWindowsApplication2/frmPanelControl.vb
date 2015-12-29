Imports CCR.AnalisisxCuidad.BL
Imports DevExpress.XtraGauges
Imports System.Linq
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.GridControl
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraCharts
Imports CCR.AnalisisxCuidad.Support
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraScheduler

Public Class frmPanelControl
    Dim bCargaLoad As Boolean = False
    Dim dStart As Date, dEnd As Date, dAvance As Date, dNuevoFechaObjetivo As Date

    Private Sub frmPanelControl_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim liIndicador As Integer = Me.Tag
        Dim sNombreXml As String
        sNombreXml = cPrefijoPlantillaDockMan & Microsoft.VisualBasic.Right("000000" & LTrim(giCodigoUsuario.ToString), 6) & "_I" & Microsoft.VisualBasic.Right("000" & LTrim(liIndicador.ToString), 6)
        Me.DockManager2.SaveLayoutToXml(cCarpetaTrabajo & sNombreXml)
        PCCRCC_LimpiaPersonalizacion(Me.Tag)
    End Sub

    Private Sub frmPanelControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Tag = cPanelDeControl
            Dim frm As New frmPrincipal
            AppImageCollectionLarge = frm.AppImageCollectionLarge
            AppImageCollection = frm.AppImageCollection
            CargarInformacionInicial()
            Me.Text = "Panel de Control"
            gaIndicadoresAbiertos(Me.Tag) = "1"
            gaIndicadoresParametros(Me.Tag) = giIdMedicionZona
        Catch ex As Exception
            frmPrincipal.siStatus.Caption = "Panel de Control Load: Ocurrío un error durante la ejecución del proceso" + ex.Message
        End Try

    End Sub

    Private Sub CargarInformacionInicial()
        Try
            'FALTA MP  VER COMO AUITAR ESO...
            dNuevoFechaObjetivo = #1/1/2014#
            'bCargaLoad = False
            CargarCategorias()
            CargarCalendarioMedicion()
            CargarIndicadores()
            CargarAlertasSupervision()
            CargarEtiquetas()
            'Controles del Calendario de Campo y consistencia ..
            CargarCalendario()
            If Not bCargaLoad Then  'No es necesario cargar la data por cada recarga.
                CargarErroresMedicionZona()
            End If
            bCargaLoad = True
            Dim sNombreXML As String
            sNombreXML = cPrefijoPlantillaDockMan & Microsoft.VisualBasic.Right("000000" & LTrim(giCodigoUsuario.ToString), 6) & "_I" & Microsoft.VisualBasic.Right("000" & LTrim("17"), 6)
            If (File.Exists(cCarpetaTrabajo & sNombreXML)) Then
                Me.DockManager2.RestoreLayoutFromXml(cCarpetaTrabajo & sNombreXML)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarEtiquetas()
        Me.lblPCMedicion.Text = giMedicion
        Me.lblPCZona.Text = PCCRCC_Zona_Sel(giIdMedicionZona)
    End Sub

    Private Sub CargarAlertasSupervision()
        Dim panelControlManagerBL As New PanelControlBL
        Try
            Dim listaAlertas = panelControlManagerBL.ListarAlertasSupervision(giIdMedicionZona).ToList()
            If listaAlertas.Any() Then
                grdErrores.DataSource = listaAlertas
            Else
                frmPrincipal.siStatus.Caption = "Alertas Supervision: No se encontró información relacionada con la Medicion actual"
            End If
        Catch ex As Exception
            frmPrincipal.siStatus.Caption = "Ocurrió un error en el proceso. " + ex.Message
        End Try
    End Sub

    Private Sub CargarCategorias()
        Dim panelControlManagerBL As New PanelControlBL
        Try
            Dim listaCategorias = panelControlManagerBL.ListarCategorias(giIdMedicionZona).ToList()
            If listaCategorias.Any() Then
                grdCategorias.DataSource = listaCategorias
            Else
                frmPrincipal.siStatus.Caption = "Categorias: No se encontró información relacionada con la Medición actual"
            End If
        Catch ex As Exception
            frmPrincipal.siStatus.Caption = "Ocurrió un error en el proceso. " + ex.Message
        End Try
    End Sub

    Private Sub CargarCalendarioMedicion()
        Dim panelControlManagerBL As New PanelControlBL
        Try
            Dim calendarioMedicion = panelControlManagerBL.ObtenerCalendarioMedicion(giIdMedicionZona).ToList()
            If calendarioMedicion.Any() Then
                'ccCalendario.DataSource = calendarioMedicion
            Else
                frmPrincipal.siStatus.Caption = "Calendario: No se encontró información relacionada con la Medición actual"
            End If
        Catch ex As Exception
            frmPrincipal.siStatus.Caption = "Ocurrió un error en el proceso. " + ex.Message
        End Try
    End Sub

    Private Sub CargarErroresMedicionZona()
        Dim panelControlManagerBL As New PanelControlBL
        Try
            Dim listaErrores = panelControlManagerBL.ListasErroresMedicionZona(giIdMedicionZona).ToList()
            If listaErrores.Any() Then
                ccEvolucion.DataSource = listaErrores
                Dim series1 As New Series("Negocios", ViewType.Bar)
                Dim series2 As New Series("Errores", ViewType.Area)
                ' Dim series3 As New Series("Indice", ViewType.Line)
                ccEvolucion.Series.Add(series1)
                ccEvolucion.Series.Add(series2)
                ' ccEvolucion.Series.Add(series3)
                series1.ArgumentDataMember = "CodigoMedicion"
                series2.ArgumentDataMember = "CodigoMedicion"
                ' series3.ArgumentDataMember = "CodigoMedicion"
                series1.ValueDataMembers.AddRange(New String() {"NegociosTotal"})
                series2.ValueDataMembers.AddRange(New String() {"TotalErrores"})
                ' series3.ValueDataMembers.AddRange(New String() {"Indice"})
                Dim diagram As XYDiagram = TryCast(ccEvolucion.Diagram, XYDiagram)
                diagram.AxisX.DateTimeGridAlignment = DateTimeMeasurementUnit.Month
                diagram.AxisX.DateTimeMeasureUnit = DevExpress.XtraCharts.DateTimeMeasurementUnit.Month
                diagram.AxisX.GridSpacing = 1
                diagram.AxisX.DateTimeOptions.Format = DevExpress.XtraCharts.DateTimeFormat.MonthAndYear
            Else
                frmPrincipal.siStatus.Caption = "Errores: No se encontró información relacionada con la Medición actual"
            End If
        Catch ex As Exception
            frmPrincipal.siStatus.Caption = "Ocurrió un error en el proceso. " + ex.Message
        End Try
    End Sub

    Private Sub CargarIndicadores()
        Dim panelControlManagerBL As New PanelControlBL
        Try
            Dim listaIndicadores = panelControlManagerBL.ListaSeleccionIndicadores(giIdMedicionZona).ToList()
            If listaIndicadores.Any() Then
                grdResumenIndicador.DataSource = listaIndicadores
            Else
                frmPrincipal.siStatus.Caption = "Indicadores: No se encontró información relacionada con la Medición actual"
            End If
        Catch ex As Exception
            frmPrincipal.siStatus.Caption = "Ocurrió un error en el proceso. " + ex.Message
        End Try
    End Sub

    Private Sub frmPanelControl_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        frmPrincipal.ActivarCintaOpciones(cPanelDeControl)
        If dNuevoFechaObjetivo > #1/1/2014# Then
            frmPrincipal.btnGrabar.Enabled = True
        End If
    End Sub

    Private Sub rpHlkE0_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rpHlkE0.Click
        LlamaPlantillas(Convert.ToInt32(gvResumenIndicador.GetRowCellValue(gvResumenIndicador.FocusedRowHandle, colIdIndicador)), 0)
    End Sub

    Private Sub rpHlkE1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rpHlkE1.Click
        LlamaPlantillas(Convert.ToInt32(gvResumenIndicador.GetRowCellValue(gvResumenIndicador.FocusedRowHandle, colIdIndicador)), 1)
    End Sub

    Private Sub rpHlkE2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rpHlkE2.Click
        LlamaPlantillas(Convert.ToInt32(gvResumenIndicador.GetRowCellValue(gvResumenIndicador.FocusedRowHandle, colIdIndicador)), 2)
    End Sub

    Private Sub rpHlkE3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rpHlkE3.Click
        LlamaPlantillas(Convert.ToInt32(gvResumenIndicador.GetRowCellValue(gvResumenIndicador.FocusedRowHandle, colIdIndicador)), 3)
    End Sub

    Private Sub rpHlkE4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rpHlkE4.Click
        LlamaPlantillas(Convert.ToInt32(gvResumenIndicador.GetRowCellValue(gvResumenIndicador.FocusedRowHandle, colIdIndicador)), 4)
    End Sub

    Private Sub rpHlkE5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rpHlkE5.Click
        LlamaPlantillas(Convert.ToInt32(gvResumenIndicador.GetRowCellValue(gvResumenIndicador.FocusedRowHandle, colIdIndicador)), 5)
    End Sub

    Private Sub rpHlkNegE0_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rpHlkNegE0.Click
        LlamaPlantillas(cCategorias, 0)
    End Sub

    Private Sub rpHlkNegE1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rpHlkNegE1.Click
        LlamaPlantillas(cCategorias, 1)
    End Sub

    Private Sub rpHlkNegE2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rpHlkNegE2.Click
        LlamaPlantillas(cCategorias, 2)
    End Sub

    Private Sub rpHlkNegE3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rpHlkNegE3.Click
        LlamaPlantillas(cCategorias, 3)
    End Sub

    Private Sub rpHlkNegE4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rpHlkNegE4.Click
        LlamaPlantillas(cCategorias, 4)
    End Sub
    Private Sub rpHlkNegE5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rpHlkNegE5.Click
        LlamaPlantillas(cCategorias, 5)
    End Sub

    'Private Sub rpHlkNegE5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rpHlkNegE4.Click
    '    Dim rowHandle = gvCategorias.FocusedRowHandle
    '    Dim codigoProducto = gvCategorias.GetRowCellValue(rowHandle, colCodigoProducto)
    'End Sub

    Private Sub rpHErroresE0_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rphErroresE0.Click
        LlamaPlantillas(cErrores, 0)
    End Sub

    Private Sub rpHErroresE1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rphErroresE1.Click
        LlamaPlantillas(cErrores, 1)
    End Sub

    Private Sub rpHErroresE2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rphErroresE2.Click
        LlamaPlantillas(cErrores, 2)
    End Sub

    Private Sub rpHErroresE3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rphErroresE3.Click
        LlamaPlantillas(cErrores, 3)
    End Sub

    Private Sub rpHErroresE4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rphErroresE4.Click
        LlamaPlantillas(cErrores, 4)
    End Sub

    Private Sub rphErroresE5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rphErroresE5.Click
        LlamaPlantillas(cErrores, 5)
    End Sub

    Friend Sub LlamaPlantillas(ByVal piIndicador As Integer, ByVal piSubIndicador As Integer)
        Try
            Dim lVoveraCargar As Boolean
            Dim id = 0
            Dim rowHandle
            Me.Cursor = Cursors.WaitCursor

            gbLoadIndicador = True

            If piIndicador = cErrores Then
                rowHandle = gvErrores.FocusedRowHandle
                id = Convert.ToInt32(gvErrores.GetRowCellValue(rowHandle, clCodGrupoAlertas))
            ElseIf piIndicador = cCategorias Then
                rowHandle = gvCategorias.FocusedRowHandle
                id = Convert.ToInt32(gvCategorias.GetRowCellValue(rowHandle, colCodigoProducto))
            End If

            giIndicador = piIndicador
            giSubIndicador = piSubIndicador
            Indicador = EstadoIndicadoresGlobales.SingleOrDefault(Function(p) p.IdIndicador = piIndicador)
            lVoveraCargar = True
            If gaIndicadoresAbiertos(piIndicador) = "1" Then
                For Each f As Form In Application.OpenForms
                    If f.Tag = piIndicador Then
                        If gaIndicadoresParametros(piIndicador) = giIdMedicionZona And piIndicador <> cEncuesta Then
                            lVoveraCargar = False
                            f.Activate()
                        ElseIf piIndicador = cEncuesta Then
                            f.Close()
                            lVoveraCargar = True
                            Exit For
                        Else
                            Me.Cursor = Cursors.Default

                            f.Close()
                            Exit Sub
                        End If
                    End If
                Next
            End If
            If lVoveraCargar Then
                gaIndicadoresAbiertos(piIndicador) = "1"
                gaIndicadoresParametros(piIndicador) = giIdMedicionZona


                gsNombreZona = PCCRCC_Zona_Sel(giIdMedicionZona)



                Select Case Indicador.FrmPlantilla
                    Case "frmPlantilla01"

                        Dim frmIndicador01 As New frmPlantilla01
                        frmIndicador01.MdiParent = frmPrincipal
                        CargaUltimaPersonalizacion(frmIndicador01)
                        frmIndicador01.Text = Indicador.TituloIndicador

                        frmIndicador01.DockPrincipal.Text = Indicador.TituloIndicadorPrincipal & " (" & gsNombreZona.ToString & "-" & giMedicion.ToString & ")"
                        frmIndicador01.DockSecundario.Text = Indicador.TituloIndicadorSecundario


                        frmIndicador01.Show()

                    Case "frmPlantilla02"
                        Dim frmIndicador01 As New frmPlantilla02
                        frmIndicador01.MdiParent = frmPrincipal
                        CargaUltimaPersonalizacion(frmIndicador01)

                        frmIndicador01.Text = Indicador.TituloIndicador
                        frmIndicador01.DockPrincipal.Text = Indicador.TituloIndicadorPrincipal & " (" & gsNombreZona.ToString & "-" & giMedicion.ToString & ")"
                        frmIndicador01.DockSecundario.Text = Indicador.TituloIndicadorSecundario

                        frmIndicador01.Show()

                        'NO SE USA
                    Case "frmPlantilla04"
                        Dim frmIndicador01 As New frmPlantilla04
                        frmIndicador01.MdiParent = frmPrincipal
                        CargaUltimaPersonalizacion(frmIndicador01)

                        frmIndicador01.Text = Indicador.TituloIndicador
                        frmIndicador01.DockPrincipal.Text = Indicador.TituloIndicadorPrincipal & " (" & gsNombreZona.ToString & "-" & giMedicion.ToString & ")"
                        frmIndicador01.DockSecundario.Text = Indicador.TituloIndicadorSecundario


                        frmIndicador01.Show()

                    Case "frmPlantilla05"
                        Dim frmIndicador01 As New frmPlantilla05
                        frmIndicador01.MdiParent = frmPrincipal
                        CargaUltimaPersonalizacion(frmIndicador01)

                        frmIndicador01.Text = Indicador.TituloIndicador
                        frmIndicador01.DockPrincipal.Text = Indicador.TituloIndicadorPrincipal & " (" & gsNombreZona.ToString & "-" & giMedicion.ToString & ")"
                        frmIndicador01.DockSecundario.Text = Indicador.TituloIndicadorSecundario

                        frmIndicador01.Show()
                        ' Aumentar mas case por cada plantilla diferente ... segun la tabla TCCRCC_Indicadores ....

                    Case "frmPlantillaSku"
                        Dim frmIndicador01 As New frmPlantillaSku
                        frmIndicador01.MdiParent = frmPrincipal
                        CargaUltimaPersonalizacion(frmIndicador01)

                        frmIndicador01.Text = Indicador.TituloIndicador
                        frmIndicador01.DockPrincipal.Text = Indicador.TituloIndicadorPrincipal & " (" & gsNombreZona.ToString & "-" & giMedicion.ToString & ")"
                        frmIndicador01.DockSecundario.Text = Indicador.TituloIndicadorSecundario
                        frmIndicador01.DockSecundario.Tag = Indicador.TituloIndicadorSecundario

                        frmIndicador01.Show()
                        ' Aumentar mas case por cada plantilla diferente ... segun la tabla TCCRCC_Indicadores ....

                    Case "frmPlantillaSkuCanal"
                        Dim frmIndicador01 As New frmPlantillaSkuCanal
                        frmIndicador01.MdiParent = frmPrincipal
                        CargaUltimaPersonalizacion(frmIndicador01)

                        frmIndicador01.Text = Indicador.TituloIndicador
                        frmIndicador01.DockPrincipal.Text = Indicador.TituloIndicadorPrincipal & " (" & gsNombreZona.ToString & "-" & giMedicion.ToString & ")"
                        frmIndicador01.DockSecundario.Text = Indicador.TituloIndicadorSecundario
                        frmIndicador01.DockSecundario.Tag = Indicador.TituloIndicadorSecundario

                        frmIndicador01.Show()
                        ' Aumentar mas case por cada plantilla diferente ... segun la tabla TCCRCC_Indicadores ....



                    Case "frmPlantilla09"
                        Dim frmIndicador01 As New frmPlantilla09
                        frmIndicador01.MdiParent = frmPrincipal
                        CargaUltimaPersonalizacion(frmIndicador01)

                        frmIndicador01.Text = Indicador.TituloIndicador
                        frmIndicador01.DockPrincipal.Text = Indicador.TituloIndicadorPrincipal & " (" & gsNombreZona.ToString & "-" & giMedicion.ToString & ")"
                        frmIndicador01.DockSecundario.Text = Indicador.TituloIndicadorSecundario

                        frmIndicador01.Show()

                    Case "frmRangos"
                        Dim frmIndicador01 As New frmRangos
                        frmIndicador01.MdiParent = frmPrincipal
                        CargaUltimaPersonalizacion(frmIndicador01)


                        frmIndicador01.Text = Indicador.TituloIndicador
                        frmIndicador01.Show()

                    Case "frmPlantillaEnc"
                        Dim frmIndicador01 As New frmPlantillaEnc
                        frmIndicador01.MdiParent = frmPrincipal
                        CargaUltimaPersonalizacion(frmIndicador01)
                        ' frmIndicador01.FCCRCC_Local_RecuperaPlantillas()
                        frmIndicador01.Text = Indicador.TituloIndicador
                        frmIndicador01.DockPrincipal.Text = Indicador.TituloIndicadorPrincipal & " (" & gsNombreZona.ToString & "-" & giMedicion.ToString & ")"
                        frmIndicador01.DockSecundario.Text = Indicador.TituloIndicadorSecundario

                        frmIndicador01.UcEncuestaNegocios1.lstrCodigoNegocio = gstrCodigoNegocio

                        frmIndicador01.iIdFila = id
                        frmIndicador01.Show()

                    Case "frmPlantillaNeg"
                        Dim frmIndicador01 As New frmPlantillaNeg
                        frmIndicador01.MdiParent = frmPrincipal
                        ' CargaUltimaPersonalizacion(frmIndicador01)

                        frmIndicador01.Text = Indicador.TituloIndicador
                        frmIndicador01.LayoutPrincipal.Text = Indicador.TituloIndicadorPrincipal & IIf(giIndicador = cErrores, " Gravedad", " Categorias") & " (" & gsNombreZona.ToString & "-" & giMedicion.ToString & ")"

                        'frmIndicador01.Text = Indicador.TituloIndicador
                        'frmIndicador01.LayoutPrincipal.Text = "Resumen de Errores por " & IIf(giIndicador = cErrores, " Gravedad", " Categorias")

                        frmIndicador01.UcEncuestaNegocios1.lstrCodigoNegocio = gstrCodigoNegocio

                        frmIndicador01.iIdFila = id
                        frmIndicador01.Show()

                    Case Else
                        Dim frmIndicador01 As New frmPlantilla01
                        frmIndicador01.MdiParent = frmPrincipal
                        CargaUltimaPersonalizacion(frmIndicador01)

                        frmIndicador01.Text = Indicador.TituloIndicador
                        frmIndicador01.DockPrincipal.Text = Indicador.TituloIndicadorPrincipal & " (" & gsNombreZona.ToString & "-" & giMedicion.ToString & ")"
                        frmIndicador01.DockSecundario.Text = Indicador.TituloIndicadorSecundario

                        frmIndicador01.Show()
                End Select
            End If
            gbLoadIndicador = False
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            gbLoadIndicador = False
            frmPrincipal.siStatus.Caption = "Ocurrió un error al ejecutar el proceso" + ex.Message
        End Try

    End Sub

    Private Sub CargaUltimaPersonalizacion(ByRef frm As Object)
        Try
            Dim liIndicadorFrm As Integer
            Dim sNombreXml As String
            liIndicadorFrm = CInt(frm.Tag)
            sNombreXml = cPrefijoPlantillaDockMan & Microsoft.VisualBasic.Right("000000" & LTrim(giCodigoUsuario.ToString), 6) & "_I" & Microsoft.VisualBasic.Right("000" & LTrim(liIndicadorFrm.ToString), 6)

            If (File.Exists(cCarpetaTrabajo & sNombreXml)) Then
                frm.DockManager2.RestoreLayoutFromXml(cCarpetaTrabajo & sNombreXml)
            End If
        Catch ex As FileNotFoundException
            Throw ex
        End Try
    End Sub


    Private Sub CargarCalendario()
        Try
            Dim dsCalendario = New PanelControlBL().CargarCalendario(giIdMedicionZona)

            Dim iFilas1 As Integer, iFilas2 As Integer
            iFilas1 = dsCalendario.Tables(0).Rows.Count
            iFilas2 = dsCalendario.Tables(1).Rows.Count


            If IsDBNull(dsCalendario.Tables(0).Rows(0).Item(2)) Or IsDBNull(dsCalendario.Tables(0).Rows(0).Item(3)) Then
                MessageBox.Show("La cuidad debe tener asignada las fechas de Inicio y fin de revisión.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                dStart = dsCalendario.Tables(0).Rows(0).Item(2)
                dEnd = dsCalendario.Tables(0).Rows(0).Item(3)
                dAvance = dsCalendario.Tables(0).Rows(0).Item(15)
                'If IsDBNull(dsCalendario.Tables(0).Rows(0).Item(2)) Then
                '    dAvance = dsCalendario.Tables(0).Rows(0).Item(15)
                'End If
                lblUltimaActualizacion.Text = dsCalendario.Tables(0).Rows(0).Item(16).ToString

                Dim SchedulerStorage1 As SchedulerStorage = New SchedulerStorage
                SchedulerControl1.Storage = SchedulerStorage1

                Dim appointmentMappings As AppointmentMappingInfo = New AppointmentMappingInfo
                appointmentMappings = SchedulerStorage1.Appointments.Mappings

                appointmentMappings.Start = "StartDate"
                appointmentMappings.End = "EndDate"
                appointmentMappings.Subject = "Subject"
                appointmentMappings.Description = "Description"
                appointmentMappings.Location = "Location"
                appointmentMappings.Label = "Label"
                appointmentMappings.ResourceId = "ResourceId"
                appointmentMappings.Status = "Status"
                appointmentMappings.AllDay = "AllDay"
                appointmentMappings.ReminderInfo = "ReminderInfo"
                appointmentMappings.RecurrenceInfo = "RecurrenceInfo"
                appointmentMappings.PercentComplete = "PercentComplete"
                appointmentMappings.Type = "EventType"
                appointmentMappings.AppointmentId = "UniqueId"

                SchedulerStorage1.Appointments.ResourceSharing = True

                SchedulerStorage1.Appointments.DataSource = dsCalendario.Tables(0)

                Dim resourcesMappings As ResourceMappingInfo = New ResourceMappingInfo
                resourcesMappings = SchedulerStorage1.Resources.Mappings

                resourcesMappings.Caption = "Description"
                resourcesMappings.Color = "Color"
                resourcesMappings.Id = "Id"
                resourcesMappings.Image = "Image"
                resourcesMappings.ParentId = "ParentId"

                SchedulerStorage1.Resources.DataSource = dsCalendario.Tables(1)

                SchedulerControl1.Storage = SchedulerStorage1

                SchedulerStorage1.Appointments.CommitIdToDataSource = False

                SchedulerControl1.ActiveViewType = SchedulerViewType.Gantt
                SchedulerControl1.GroupType = SchedulerGroupType.Resource
                SchedulerControl1.GanttView.ShowResourceHeaders = True
                SchedulerControl1.ResourceNavigator.Visibility = ResourceNavigatorVisibility.Never
                SchedulerControl1.OptionsView.FirstDayOfWeek = Microsoft.VisualBasic.FirstDayOfWeek.Monday

                SchedulerControl1.OptionsCustomization.AllowAppointmentCopy = UsedAppointmentType.None
                SchedulerControl1.OptionsCustomization.AllowAppointmentDelete = UsedAppointmentType.None
                SchedulerControl1.OptionsCustomization.AllowAppointmentDragBetweenResources = UsedAppointmentType.None
                SchedulerControl1.OptionsCustomization.AllowAppointmentDrag = UsedAppointmentType.None
                SchedulerControl1.OptionsCustomization.AllowDisplayAppointmentDependencyForm = AllowDisplayAppointmentDependencyForm.Never

                SchedulerControl1.OptionsCustomization.AllowAppointmentMultiSelect = False
                'SchedulerControl1.OptionsCustomization.AllowAppointmentEdit = UsedAppointmentType.None
                SchedulerControl1.OptionsCustomization.AllowAppointmentCreate = UsedAppointmentType.None
                SchedulerControl1.OptionsCustomization.AllowInplaceEditor = UsedAppointmentType.None
                SchedulerControl1.OptionsCustomization.AllowAppointmentCreate = UsedAppointmentType.None

                'SchedulerControl1.LimitInterval = New DevExpress.XtraScheduler.TimeInterval(New DateTime(2015, 4, 26), New DateTime(2015, 5, 24))
                SchedulerControl1.LimitInterval = New DevExpress.XtraScheduler.TimeInterval(dStart, dEnd)
                ' SchedulerControl1.GoToDate(IIf(dEnd < Now(), dEnd, Now()))


                'FormateaControlCalendario
                '-------------------------------------------------------------------------------
                SchedulerControl1.Dock = DockStyle.Fill

                SchedulerControl1.Views.GanttView.Scales(0).Enabled = False 'Año
                SchedulerControl1.Views.GanttView.Scales(1).Enabled = False 'Tri
                SchedulerControl1.Views.GanttView.Scales(2).Enabled = True 'Mes
                SchedulerControl1.Views.GanttView.Scales(3).Enabled = False 'Sem
                SchedulerControl1.Views.GanttView.Scales(4).Enabled = True 'Dia
                SchedulerControl1.Views.GanttView.Scales(5).Enabled = False 'hra
                SchedulerControl1.Views.GanttView.Scales(6).Enabled = False 'min

                SchedulerControl1.Views.GanttView.Scales(0).Visible = False 'Año
                SchedulerControl1.Views.GanttView.Scales(1).Visible = False 'Tri
                SchedulerControl1.Views.GanttView.Scales(2).Visible = True 'Mes
                SchedulerControl1.Views.GanttView.Scales(3).Visible = False 'Sem
                SchedulerControl1.Views.GanttView.Scales(4).Visible = True 'Dia
                SchedulerControl1.Views.GanttView.Scales(5).Visible = False 'hra
                SchedulerControl1.Views.GanttView.Scales(6).Visible = False 'min

                SchedulerControl1.Views.GanttView.Scales(4).DisplayFormat = "dd"
                SchedulerControl1.Views.GanttView.NavigationButtonVisibility = NavigationButtonVisibility.Never
                SchedulerControl1.Views.GanttView.ShowMoreButtons = False
                SchedulerControl1.Views.GanttView.ShowResourceHeaders = True

                SchedulerControl1.GoToDate(IIf(dEnd < Now(), dEnd, Now()))
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SchedulerControl1_AppointmentResized(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.AppointmentResizeEventArgs) Handles SchedulerControl1.AppointmentResized
        Dim sMensajeError As String, i As Integer = 0
        Dim dFechaMinima As Date, dFechaMaxima As Date

        dFechaMaxima = dAvance
        dFechaMinima = dStart
        dFechaMaxima = IIf(dFechaMaxima < Now(), dFechaMaxima, Now())
        sMensajeError = "Error en la definicion de la fecha Objetivo de Consistencia. " & vbCrLf & " Porque: " & vbCrLf

        If e.SourceAppointment.Start = e.EditedAppointment.Start And _
            (e.EditedAppointment.End >= dFechaMinima And e.EditedAppointment.End <= dFechaMaxima) And e.SourceAppointment.Id = 2 Then
            'OK
            dNuevoFechaObjetivo = e.EditedAppointment.End
            frmPrincipal.btnGrabar.Enabled = True
            e.SourceAppointment.LabelId = 5
            e.Allow = True
            e.Handled = True

            frmPrincipal.Enabled = True

        Else

            If e.SourceAppointment.Id <> 2 Then
                sMensajeError += " - Esta intentando editar un recurso que no es Consistencia" & vbCrLf
                i += 1
            End If
            If e.SourceAppointment.Start <> e.EditedAppointment.Start Then
                sMensajeError += "- Esta intentando editar la fecha de Inicio" & vbCrLf
                i += 1
            End If
            If i = 0 Then
                sMensajeError += "- Esta intentando definir una fecha objetivo fuera de: " & dFechaMinima.ToString & " - " & dFechaMaxima.ToString
            End If

            MsgBox(sMensajeError, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "CCRCC: Nuevo Objetivo de Trabajo de Consistencia")
            'frmPrincipal.Enabled = False
            e.Allow = False
            e.Handled = True


        End If
    End Sub

    Private Sub SchedulerControl1_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SchedulerControl1.SizeChanged
        If bCargaLoad Then
            SchedulerControl1.Views.GanttView.Scales(4).Width = (SchedulerControl1.Width - 80) / SchedulerControl1.LimitInterval.Duration.Days

        End If
    End Sub

    Friend Sub MODCCLocal_Todos(ByVal liBoton As Integer)
        Try
            Select Case liBoton
                Case cBtnSincronizar
                    'NO APLICA

                Case cbtnRecargar

                    'CODIGODE RECALCULO DE INDICADORES...
                    frmPrincipal.bsiProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    frmPrincipal.siStatus.Caption = "RECALCULANDO INDICADORES: Este proceso puede demorar, por favor espere..."
                    RecalculaIndicadores()
                    frmPrincipal.bsiProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    frmPrincipal.siStatus.Caption = "Indicadores recalculados exitosaamente..."
                    'Recarga los indicadores ...
                    CargarInformacionInicial()
                    frmPrincipal.btnGrabar.Enabled = False


                Case cBtnGrabar

                    If Not GrabarCambios() Then
                        MsgBox("ERROR:  No se pudo actualizar correctamente los cambios", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Calendario CC: Actualizacion de Cambios")
                        'Vuelve al estado inicial ...

                    Else
                        'Ejecuta el proceso de recalculo de los indicadores 

                        'CODIGODE RECALCULO DE INDICADORES...
                        frmPrincipal.bsiProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        frmPrincipal.siStatus.Caption = "RECALCULANDO INDICADORES: Este proceso puede demorar, por favor espere..."
                        RecalculaIndicadores()
                        frmPrincipal.bsiProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                        frmPrincipal.siStatus.Caption = "Indicadores recalculados exitosaamente..."
                    End If
                    'Recarga los indicadores ...
                    CargarInformacionInicial()
                    frmPrincipal.btnGrabar.Enabled = False
                Case cBtnFrecuencia
                Case cBtnSemaforoAlertas
                Case cBtnSemaforoOk
                Case cBtnSemaforoTodos
                Case cBtnSalir
                Case Else
            End Select
        Catch ex As Exception
            frmPrincipal.siStatus.Caption = "Ocurrió un error en la ejecucición del proceso" + ex.Message
        End Try

    End Sub

    Function GrabarCambios() As Boolean
        Dim bRetorna As Boolean = False
        Try
            Dim panelControl As New PanelControlBL
            bRetorna = panelControl.ActualizaCalendarioMedicion(giIdMedicionZona, dNuevoFechaObjetivo)
            Return bRetorna
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Private Sub RecalculaIndicadores()
        Try
            Dim panelControl As New PanelControlBL
            panelControl.RecalculaIndicadoresMedicion(giIdMedicionZona)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub SchedulerControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchedulerControl1.Click

    End Sub
End Class