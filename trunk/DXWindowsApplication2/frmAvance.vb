Imports CCR.AnalisisxCuidad.BL
Imports System.Linq
Imports CCR.AnalisisxCuidad.BE
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraGrid.GridControl
Imports DevExpress.XtraGrid.Views.Grid
Imports CCR.AnalisisxCuidad.Support
Imports DevExpress.XtraEditors
Public Class frmAvance

#Region "Variables Globales"
    Private ultimasMediciones As New List(Of Medicion)
    Private perMesEstudio As Integer
    Private IsAdministrator As Boolean
#End Region

#Region "Manejo de Eventos"

    Private Sub AsignacionUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'respaldo el codigo idZona en el arreglo
            gaIndicadoresAbiertos(cControlDeAvance) = "1"
            gaIndicadoresParametros(cControlDeAvance) = giIdMedicionZona
            CargarMediciones()
            'Elegir la medicion zona antes usada  ...
            CargarGrilla(perMesEstudio)
            CargarEstados()
            'giIdMedicionZona
            If Not VerificaTipoUsuario() Then
                'cbxMedicion.Enabled = False
                'rpItemEstado.ReadOnly = True
                rpItemUsuario.ReadOnly = True
                btnAplicarMedicion.Enabled = False
                rpDateMeta.ReadOnly = True
            Else
                'cbxMedicion.Enabled = True
                'rpItemEstado.ReadOnly = False
                rpItemUsuario.ReadOnly = False
                btnAplicarMedicion.Enabled = True
                rpDateMeta.ReadOnly = False
            End If
        Catch ex As Exception
            frmPrincipal.siStatus.Caption = "Ocurrío un error en el proceso." + ex.Message
        End Try
    End Sub

    Private Sub cbxMedicion_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxMedicion.SelectionChangeCommitted
        Dim mesEstudio As Integer
        mesEstudio = Convert.ToInt32(cbxMedicion.SelectedValue.ToString())
        giMedicion = mesEstudio
        CargarGrilla(mesEstudio)
    End Sub

    Private Sub btnAplicarMedicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicarMedicion.Click
        If MsgBox("Esta accion anulara la asignación actual" & vbCrLf & "y se reemplazará con los usuarios asignados el segun el periodo anterior" & vbCrLf & "¿Desea continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Asignacion masiva de usuarios a las Zonas") = MsgBoxResult.Yes Then
            CopiarAsignacionMesAnterior()
        End If
    End Sub

    Private Sub rpItemUsuario_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rpItemUsuario.EditValueChanged
        Dim idTCCRAvance As New Integer
        Dim codigoUsuario As Int16
        Dim rowHandle = gvZonas.FocusedRowHandle
        idTCCRAvance = Convert.ToInt32(gvZonas.GetRowCellValue(rowHandle, colIdTCCRCCAvance))
        Dim valor As Object = TryCast(sender, LookUpEdit).EditValue
        codigoUsuario = Convert.ToInt16(valor)
        AsignaUsuarioACuidad(idTCCRAvance, codigoUsuario)
    End Sub

    Private Sub gvZonas_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles gvZonas.RowCellStyle
        Dim view As GridView = sender
        If e.Column.FieldName = colAlertas.FieldName Then
            Dim avance As Integer = view.GetRowCellValue(e.RowHandle, colAlertas)
            If avance > 0 Then
                e.Appearance.ForeColor = Color.Red
                e.Appearance.BackColor = Color.LightSalmon
            End If
        ElseIf e.Column.FieldName = colEstado.FieldName Then
            Dim etiqueta As String = view.GetRowCellValue(e.RowHandle, colEstado)
            Select Case etiqueta
                Case Constants.ESTADO_ASIGNACION_OK
                    e.Appearance.ForeColor = Color.Black
                    e.Appearance.BackColor = Color.LightSeaGreen
                Case Constants.ESTADO_ASIGNACION_PENDIENTE
                    e.Appearance.ForeColor = Color.Red
                    e.Appearance.BackColor = Color.LightYellow
                    e.Appearance.ForeColor = Color.Red
                Case Else
            End Select
        End If
    End Sub

    Private Sub rpItemLinkZona_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rpItemLinkZona.DoubleClick
        Dim rowHandle = gvZonas.FocusedRowHandle
        Me.Cursor = Cursors.WaitCursor
        Dim lVoveraCargar As Boolean = True
        'Captura de variables Globales 
        giIdMedicionZona = Convert.ToInt32(gvZonas.GetRowCellValue(rowHandle, colIdTCCRCCAvance))
        gsNombreZona = Convert.ToString(gvZonas.GetRowCellValue(rowHandle, colZona))
        If gaIndicadoresAbiertos(cPanelDeControl) = "1" Then
            'Recargar  con otra Ciudad
            For Each f As Form In Application.OpenForms
                If f.Tag = cPanelDeControl Then
                    If gaIndicadoresParametros(cPanelDeControl) = giIdMedicionZona Then
                        lVoveraCargar = False
                        Me.Cursor = Cursors.Default
                        f.Activate()
                    Else
                        If MsgBox("Tiene abierto el Panel de Control con otra Zona" & vbCrLf & "Desea Reemplazarlo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Panel de Control") = MsgBoxResult.Yes Then
                            f.Close()
                            lVoveraCargar = True
                        End If
                        Exit For
                    End If
                End If
            Next
        End If
        If lVoveraCargar Then
            Dim frmPanel As New frmPanelControl
            frmPanel.MdiParent = frmPrincipal
            frmPanel.Show()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub grdZonasAnalisis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdZonasAnalisis.Click
        Dim rowHandle = gvZonas.FocusedRowHandle
        'Captura de variables Globales 
        giIdMedicionZona = Convert.ToInt32(gvZonas.GetRowCellValue(rowHandle, colIdTCCRCCAvance))
        gsNombreZona = Convert.ToString(gvZonas.GetRowCellValue(rowHandle, colZona))
    End Sub

    Private Sub frmAvance_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        frmPrincipal.ActivarCintaOpciones(Me.Tag)
        giInidicadorActivo = Me.Tag  'cControlDeAvance
        gaIndicadoresAbiertos(Me.Tag) = "1"  '(cControlDeAvance - 1) = 1
        frmPrincipal.ActivarCintaOpciones(cControlDeAvance)
    End Sub

    Friend Sub MODCCLocal_Todos(ByVal liBoton As Integer)
        Select Case liBoton
            Case cBtnSincronizar
            Case cBtnGrabar
                MsgBox("Esto es guardar LOCAL de AVANCE")
            Case cBtnSalir
            Case Else
        End Select
    End Sub

    Private Sub frmAvance_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        PCCRCC_LimpiaPersonalizacion(Me.Tag)
    End Sub

    Private Sub rpDateMeta_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rpDateMeta.EditValueChanged
        Dim idTCCRAvance As New Integer
        Dim fechaObjetivo As DateTime
        Dim rowHandle = gvZonas.FocusedRowHandle
        giIdMedicionZona = Convert.ToInt32(gvZonas.GetRowCellValue(rowHandle, colIdTCCRCCAvance))
        fechaObjetivo = TryCast(sender, DateEdit).DateTime
        ModificarFechaObjetivo(giIdMedicionZona, fechaObjetivo)
    End Sub

    Private Sub rpItemEstado_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rpItemEstado.EditValueChanged
        Dim idTCCRAvance As New Integer
        Dim rowHandle = gvZonas.FocusedRowHandle
        giIdMedicionZona = Convert.ToInt32(gvZonas.GetRowCellValue(rowHandle, colIdTCCRCCAvance))
        Dim valor As Object = TryCast(sender, LookUpEdit).EditValue
        Select Case valor
            Case 0  '"pendiente"
                If MsgBox("Si edita algun registro, esta cambio de estado podria provocar cambios en los datos enviados al SYS" + vbCrLf + "Esta seguro(a) de volver a abrir la Zona?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Abrir zona") = MsgBoxResult.Yes Then
                    PCCRCC_MedicionZonaCambiaEstado(0, giIdMedicionZona)
                End If
            Case 1  '"programa envio y terminar"
                If MsgBox("esta accion enviara los negocios editados restantes a analisis y bloqueara envios posteriores." + vbCrLf + "esta seguro(a) de continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "cierre cxc de la zona") = MsgBoxResult.Yes Then
                    PCCRCC_MedicionZonaCambiaEstado(1, giIdMedicionZona)
                End If
            Case 2  '"enviar datos y terminar"
                If MsgBox("esta accion enviara los negocios restantes a analisis y bloqueara envios posteriores." + vbCrLf + "esta seguro(a) de continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "cierre cxc de la zona") = MsgBoxResult.Yes Then
                    'cpaturo la idmedicionzona y se dispara el cierre final...
                    PCCRCC_MedicionZonaCambiaEstado(2, giIdMedicionZona)
                    PCCRCC_Envio_a_SYS(giIdMedicionZona)
                End If
                'Case 3   ' terminado 
                ' este estado se crea automaticamente cuando culmina una de las acciones anteriores: estado 1 o 2, pasa a ser 3.
                ' estado 3 es terminado...
            Case Else
                MsgBox("debe seleccionar una de las opciones de la lista")
        End Select
    End Sub
#End Region

#Region "Metodos Internos"
    Private Sub CargarGrilla(ByVal perMesEstudio As Integer)
        Dim zonaSujetaRevisionBl As New ZonaSujetaRevisionBL
        Dim listaCounsultaZonas As New List(Of ZonaSujetaRevision)
        Try
            listaCounsultaZonas = zonaSujetaRevisionBl.ConsultaZonasSujetasRevision(perMesEstudio).ToList()
            If listaCounsultaZonas.Any() Then
                grdZonasAnalisis.DataSource = listaCounsultaZonas
                frmPrincipal.siStatus.Caption = "La información se cargó de manera exitosa"
                CargarUsuariosConsistencia()
            Else
                grdZonasAnalisis.DataSource = Nothing
                frmPrincipal.siStatus.Caption = "Usuario no corresponde al área de consistencia o no tiene tiene ninguna cuidad asignada"
            End If
        Catch ex As Exception
            frmPrincipal.siStatus.Caption = "Ocurrío un error en el proceso." + ex.Message
        End Try
    End Sub

    Private Function CargarUltimasMediciones() As List(Of Medicion)
        Dim zonaSujetaRevisionBl As New ZonaSujetaRevisionBL
        Try
            ultimasMediciones = zonaSujetaRevisionBl.ObtenerUltimasTresMediciones().ToList()
            perMesEstudio = ultimasMediciones.SingleOrDefault(Function(p) p.Estado = True).Medicion
        Catch ex As Exception
            frmPrincipal.siStatus.Caption = "El usuario no se encuentra asignado a una zona." + ex.Message
        End Try
        Return ultimasMediciones
    End Function

    Private Function ObtenerUltimaMedicion() As Integer
        Try
            If giIdMedicionZona > 0 Then
                Return New PlantillasBL().ObtenerUltimaMedicion(giIdMedicionZona)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub CargarMediciones()
        Try
            cbxMedicion.DataSource = CargarUltimasMediciones()
            cbxMedicion.ValueMember = "Medicion"
            cbxMedicion.DisplayMember = "Medicion"
            Dim ultimaMedicion = ObtenerUltimaMedicion()
            If ultimaMedicion > 0 Then
                cbxMedicion.SelectedValue = Convert.ToDecimal(ultimaMedicion)
            End If
            giMedicion = Convert.ToInt32(cbxMedicion.SelectedValue.ToString())
            perMesEstudio = giMedicion
        Catch ex As Exception
            frmPrincipal.siStatus.Caption = "Revisar los permisos asignados al usuario." + ex.Message
        End Try

    End Sub

    Private Sub CargarEstados()
        Dim zonaSujetaRevisionBL As New ZonaSujetaRevisionBL
        rpItemEstado.DataSource = zonaSujetaRevisionBL.ListaEstados()
        rpItemEstado.ValueMember = "CodigoEstado"
        rpItemEstado.DisplayMember = "Descripcion"
        rpItemEstado.BestFit()
    End Sub

    Private Sub AsignaUsuarioACuidad(ByVal idTCCRCC_Avance As Integer, ByVal codigoUsuario As Int16)
        Dim zonaSujetaRevisionBl As New ZonaSujetaRevisionBL
        Try
            Dim exito = zonaSujetaRevisionBl.ActualizaAvanceUsuario(giMedicion, idTCCRCC_Avance, codigoUsuario)
            If exito = 0 Then
                frmPrincipal.siStatus.Caption = "La asignación del usuario a la cuidad se realizó con éxito"
                CargarGrilla(giMedicion)
            Else
                frmPrincipal.siStatus.Caption = "No se pudo asignar el usuario a la cuidad."
            End If
        Catch ex As Exception
            frmPrincipal.siStatus.Caption = "Ocurrío un error en el proceso." + ex.Message
        End Try
    End Sub

    Private Sub CargarUsuariosConsistencia()
        Try
            Dim zonaSujetaRevisionBl As New ZonaSujetaRevisionBL
            rpItemUsuario.DataSource = zonaSujetaRevisionBl.ObtenerUsuarioConsistencia().ToList()
            rpItemUsuario.ValueMember = "CodigoUsuario"
            rpItemUsuario.DisplayMember = "NombreUsuario"
            rpItemUsuario.BestFit()
        Catch ex As Exception
            frmPrincipal.siStatus.Caption = "Ocurrío un error en el proceso." + ex.Message
        End Try
    End Sub

    Private Sub CopiarAsignacionMesAnterior()
        AsignaUsuarioACuidad(0, 0)
    End Sub

    Private Function VerificaTipoUsuario() As Boolean
        Try
            Dim panelControl As New PanelControlBL
            Return panelControl.VerificaTipoUsuario()
        Catch ex As Exception
            frmPrincipal.siStatus.Caption = "Ocurrío un error en el proceso." + ex.Message
        End Try
    End Function

    Private Sub ModificarFechaObjetivo(ByVal idMedicionZona As Integer, ByVal fechaObjetivo As DateTime)
        Dim zonaSujetaRevisionBl As New ZonaSujetaRevisionBL
        Try
            Dim exito = zonaSujetaRevisionBl.ActualizaFechaObjetivo(idMedicionZona, fechaObjetivo)
            'Dim exito = False
            If exito = 0 Then
                frmPrincipal.siStatus.Caption = "El cambio de la fecha objetivo se realizó con éxito"
                CargarGrilla(giMedicion)
            Else
                frmPrincipal.siStatus.Caption = "No se pudo realizar la actualización de la fecha."
            End If
        Catch ex As Exception
            frmPrincipal.siStatus.Caption = "Ocurrío durante el proceso de actualización." + ex.Message
        End Try
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub PCCRCC_Envio_a_SYS(ByRef piIdMedicionZona As Integer)
        Dim lbRetorno As Boolean = False, iRetorna As Int16 = 0, iRegistros As Integer = 0
        If Not piIdMedicionZona > 0 Then
            Exit Sub
        End If
        Dim aParametros(1, 2) As String
        aParametros(0, 0) = "@pintIdMedicionZona"
        aParametros(0, 1) = "Int"
        aParametros(0, 2) = piIdMedicionZona
        Try
            CCRCC_EjecutaProcedimiento("BDPECCR.DBO.PCCRCC_Envio_a_SYS", 1, aParametros, iRetorna)
            MsgBox("Se realizó el envio de negocios al CCRSys", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Cierre de Consistencia")
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Sub

    Private Sub PCCRCC_MedicionZonaCambiaEstado(ByRef piEstadoZona As Integer, ByRef piIdMedicionZona As Integer)
        Dim lbRetorno As Boolean = False, iRetorna As Int16 = 0, iRegistros As Integer = 0
        If Not piIdMedicionZona > 0 Then
            Exit Sub
        End If
        Dim aParametros(2, 2) As String
        aParametros(0, 0) = "@Estado"
        aParametros(0, 1) = "Int"
        aParametros(0, 2) = piEstadoZona
        aParametros(1, 0) = "@pintIdMedicionZona"
        aParametros(1, 1) = "Int"
        aParametros(1, 2) = piIdMedicionZona
        Try
            CCRCC_EjecutaProcedimiento("PCCRCC_MedicionZonaCambiaEstado", 2, aParametros, iRetorna)
            MsgBox("Se programo la Zona para su posterior Envio al CCRSYS y Cierre de CXC.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Cierre de Consistencia")
        Catch ex As Exception
            Throw ex
        Finally
        End Try
    End Sub
#End Region
End Class