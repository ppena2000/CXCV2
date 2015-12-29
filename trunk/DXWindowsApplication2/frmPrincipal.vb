Imports System.ComponentModel
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Helpers
Imports CCR.AnalisisxCuidad.Support
Imports CCR.AnalisisxCuidad.BE
Imports System.Linq
Imports CCR.AnalisisxCuidad.BL
Imports System.IO
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrintingLinks
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmPrincipal
    Private _EstadoIndicadores As List(Of Indicadores)
    Public Property EstadoIndicadores() As List(Of Indicadores)
        Get
            Return _EstadoIndicadores
        End Get
        Set(ByVal value As List(Of Indicadores))
            _EstadoIndicadores = value
        End Set
    End Property

    Sub New()
        InitSkins()
        InitializeComponent()
        Me.InitSkinGallery()
        giGridActivo = 0
        'giCodigoUsuario = 0
        giCodigoUsuario = FCCRCC_ObtenerCodigoUsuario()

    End Sub

    Sub InitSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        UserLookAndFeel.Default.SetSkinStyle("DevExpress Style")

    End Sub

    Private Sub InitSkinGallery()
        SkinHelper.InitSkinGallery(rgbSkins, True)
    End Sub

    Private Sub RecuperarUltimaSesion()

        Dim sgaIndicadoresAbiertos As String
        Dim sgaIndicadoresParametros As String
        Dim sgaIndicadoresFilaPrincipal As String
        Dim sgaIndicadoresFilaSecundaria As String
        Dim sgaIndicadoresBotones As String
        Dim iMedicionZona As Integer
        Dim lsZona As String
        Dim i As Integer, iTotalIndicadores As Integer = 0, iIndicador As Integer = 0
        Dim sNombreXML As String, sNombreReg As String

        gsSkinName = UserLookAndFeel.Default.ActiveSkinName

        sNombreReg = "Global_U" & Microsoft.VisualBasic.Right("000000" & LTrim(giCodigoUsuario.ToString), 6)

        sgaIndicadoresAbiertos = GetSetting(APP_NAME, sNombreReg, "gaIndicadoresAbiertos", "")
        sgaIndicadoresParametros = GetSetting(APP_NAME, sNombreReg, "gaIndicadoresParametros", "")
        sgaIndicadoresFilaPrincipal = GetSetting(APP_NAME, sNombreReg, "gaIndicadoresFilaPrincipal", "")
        sgaIndicadoresFilaSecundaria = GetSetting(APP_NAME, sNombreReg, "gaIndicadoresFilaSecundaria", "")
        sgaIndicadoresBotones = GetSetting(APP_NAME, sNombreReg, "gaIndicadoresBotones", "")

        'Activo la pestaña activa final
        gsSkinName = GetSetting(APP_NAME, sNombreReg, "gsSkinName", gsSkinName)
        giIndicador = CInt(GetSetting(APP_NAME, sNombreReg, "giIndicador", giIndicador))
        giIdMedicionZona = CInt(GetSetting(APP_NAME, sNombreReg, "giIdMedicionZona", giIdMedicionZona))

        If (File.Exists(cCarpetaTrabajo & cArchivoReset)) Then
            sgaIndicadoresAbiertos = ""
            giIdMedicionZona = 0
        End If

        If sgaIndicadoresAbiertos = "" Or giIdMedicionZona = 0 Then
            'Valores por defecto por ser primer ingreso para el usuario...
            sgaIndicadoresAbiertos = StrDup(21, "@0")
            sgaIndicadoresParametros = StrDup(21, "@0")
            sgaIndicadoresFilaPrincipal = StrDup(21, "@0")
            sgaIndicadoresFilaSecundaria = StrDup(21, "@0")
            sgaIndicadoresBotones = StrDup(21, "@0")
            giIndicador = 15 'Control de avance ...
            gsSkinName = "Blue"


        End If

        'Recuperar el ultimo estado del usuario..

        gaIndicadoresAbiertos = (Split(sgaIndicadoresAbiertos, "@"))
        gaIndicadoresParametros = (Split(sgaIndicadoresParametros, "@"))
        gaIndicadoresFilaPrincipal = (Split(sgaIndicadoresFilaPrincipal, "@"))
        gaIndicadoresFilaSecundaria = (Split(sgaIndicadoresFilaSecundaria, "@"))
        gaIndicadoresBotones = (Split(sgaIndicadoresBotones, "@"))

        If sgaIndicadoresAbiertos = StrDup(21, "@0") Then  'Se esta formzando....

            giIdMedicionZona = 0

        End If

        iMedicionZona = giIdMedicionZona
        lsZona = ""
        Me.Cursor = Cursors.WaitCursor
        'Habilito todas las pestañas activas
        If giIdMedicionZona <> 0 Then

            iTotalIndicadores = CuentaIndicadoresAbiertos(gaIndicadoresAbiertos)

            gsNombreZona = PCCRCC_Zona_Sel(giIdMedicionZona)
            lsZona = gsNombreZona

            'Se abre el Control de Avance...

            MODCC_ControlDeAvance(cControlDeAvance)

            'Se abre tambien el panel de control con el giIdMedicionZona

            MODCC_PanelDeControl(cPanelDeControl)

            ' LayoutControlPrincipal.Visible = True

            gbLoadSistema = True

            For i = 1 To gaIndicadoresAbiertos.Length - 1

                Me.bsiProgreso.Visibility = BarItemVisibility.Always
                Me.bsiProgreso.BeginUpdate()
                'Me.bsiProgreso.Refresh()
                Me.Cursor = Cursors.WaitCursor

                If gaIndicadoresAbiertos(i) = "1" And i <> cControlDeAvance And i <> cPanelDeControl Then
                    iIndicador = iIndicador + 1
                    'Abrimos la pestaña con la medicion ciudad que fue guardada...
                    EstadoIndicadoresGlobales.SingleOrDefault(Function(p) p.IdIndicador = i).EstadoUIPageButtonGroup = gaIndicadoresBotones(i)
                    giIdMedicionZona = IIf(gaIndicadoresParametros(i) > "", CInt(gaIndicadoresParametros(i)), iMedicionZona)

                    'If iMedicionZona <> giIdMedicionZona Then
                    '    gsNombreZona = PCCRCC_Zona_Sel(giIdMedicionZona)
                    'End If

                    Me.siStatus.Caption = "Cargando datos de ultima sesion del indicador " + iIndicador.ToString + " de " + iTotalIndicadores.ToString + ": " + EstadoIndicadoresGlobales.SingleOrDefault(Function(p) p.IdIndicador = i).TituloIndicador
                    Me.siStatus.Refresh()

                    'Me.Refresh()

                    frmPanelControl.LlamaPlantillas(i, 1)

                   

                End If

            Next

        End If
        gbLoadSistema = False

        Me.siStatus.Caption = "Carga exitosa "
        Me.bsiProgreso.EndUpdate()
        Me.bsiProgreso.Visibility = BarItemVisibility.Never

        Me.Cursor = Cursors.Default

        'LayoutControlPrincipal.Visible = False

        giIdMedicionZona = iMedicionZona
        gsNombreZona = lsZona

        sNombreXML = cPrefijoPlantillaRibbon & Microsoft.VisualBasic.Right("000000" & LTrim(giCodigoUsuario.ToString), 6) & "_I" & Microsoft.VisualBasic.Right("000", 3)

        If (File.Exists(cCarpetaTrabajo & sNombreXML)) And Not (File.Exists(cCarpetaTrabajo & cArchivoReset)) Then
            Me.ribbonControl.Toolbar.RestoreLayoutFromXml(cCarpetaTrabajo & sNombreXML)
        End If

    End Sub
    Private Function CuentaIndicadoresAbiertos(ByVal gaIndicadoresAbiertos As Array)
        Dim i As Integer, n As Integer = 0

        For i = 0 To gaIndicadoresAbiertos.Length - 1
            If gaIndicadoresAbiertos(i) = "1" Then
                n = n + 1
            End If
        Next
        Return n
    End Function
   

    Private Sub CargarParametrosConexion()
        Try
            Me.bitemUsuario.Caption = My.User.Name & " (" & LTrim(RTrim(giCodigoUsuario.ToString)) & ")"
            Dim conexionDB = New PanelControlBL().ObtenerDatosConexion()
            Me.bsiServidor.Caption = "Servidor : " + conexionDB.ServerName '+ "|"
            Me.bsiBD.Caption = "Base de datos: " + conexionDB.DataBaseName '+ "|"
        Catch ex As Exception
            Me.siStatus.Caption = "Ocurrió un error obteniendo los datos iniciales de conexión " + ex.Message
        End Try
    End Sub

    Private Function FCCRCC_ObtenerCodigoUsuario() As Integer
        Dim iCodigoUsuario As Int16 = 666

        Dim aParametros(1, 2) As String

        aParametros(0, 0) = "@RETORNA"
        aParametros(0, 1) = "SmallInt"
        aParametros(0, 2) = iCodigoUsuario

        Try

            CCRCC_EjecutaProcedimiento("PCCRCC_ObtenerCodigoUsuario", 1, aParametros, iCodigoUsuario)


        Catch ex As Exception
            Throw ex
        Finally

        End Try

        Return iCodigoUsuario
    End Function

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = cNombre_de_Sistema_y_Version




        giPrincipalLoad = 1

        gifrmPrincipalWidth = Me.Width

        gsSkinName = UserLookAndFeel.Default.ActiveSkinName
        'Dim skinName As String
        CargarEstadoIndicadores()
        ' CargaUltimaSesion()
        RecuperarUltimaSesion()

        CargarParametrosConexion()
        giPrincipalLoad = 0

        'Si no hay deafult de usuario...
        If giCodigoZona = 0 Then

            MODCC_ControlDeAvance(cControlDeAvance)

        End If

        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = gsSkinName

    End Sub

    'Borrar desde aqui

    Private Sub barBtnOpcion01_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim forma As New frmPlantillaNeg
        forma.MdiParent = Me
        forma.Text = "Titulo opcion 01"
        'forma.Label1.Text = "Forma 01"
        forma.Show()
        'splitContainerControl.Visible = False
    End Sub

    Private Sub barBtnOpcion02_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim forma As New frmPlantillaNeg
        'splitContainerControl.Visible = False
        forma.MdiParent = Me
        forma.Text = "Titulo opcion 02"
        'forma.Label1.Text = "Forma 02"
        forma.Show()
    End Sub

    Private Sub barBtnOpcion03_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim forma As New frmPlantillaNeg
        'splitContainerControl.Visible = False
        forma.MdiParent = Me
        forma.Text = "Titulo opcion 03"
        'forma.Label1.Text = "Forma 03"
        forma.Show()
    End Sub

    Private Sub bbtnPanel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        'splitContainerControl.Visible = True
    End Sub

    Private Sub BarMdiChildrenListItem1_ListItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ListItemClickEventArgs)
        'splitContainerControl.Visible = False
    End Sub

    Private Sub bbtnAnalisis_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim forma As New frmPlantillaEnc
        'splitContainerControl.Visible = False
        forma.MdiParent = Me
        'forma.Text = "Titulo opcion 03"
        forma.Text = "Forma Anaisis de Datos"
        forma.Show()
    End Sub

    Private Sub bbtnDash_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim forma As New frmPanelControl
        'splitContainerControl.Visible = False
        forma.MdiParent = Me
        'forma.Text = "Titulo opcion 03"
        forma.Text = "Forma diseño db"
        forma.Show()
    End Sub
    'Borrar hasta aqui
    Private Sub CargarEstadoIndicadores()
        Dim plantillas As New PlantillasBL
        Try
            EstadoIndicadores = plantillas.ConsultarEstadoIndicadores(0, 0).ToList()
            EstadoIndicadoresGlobales = EstadoIndicadores
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ActivarCintaOpciones(ByVal parametro As Integer, Optional ByVal cadenaEstado As String = "")
        If parametro = 0 Then
            cadenaEstado = StrDup(100, "0")
        End If

        Me.siStatus.Caption = "Espere un momento por favor... Activando botones ..."

        giInidicadorActivo = parametro

        Try
            If cadenaEstado = "" Then
                cadenaEstado = EstadoIndicadoresGlobales.SingleOrDefault(Function(p) p.IdIndicador = parametro).EstadoUIPageButtonGroup
            End If
            'Dim cadenaEstado = EstadoIndicadoresGlobales.SingleOrDefault(Function(p) p.IdIndicador = parametro).EstadoUIPageButtonGroup

            Dim checkReal As Integer = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnReal - 1, 1))
            btnReal.Enabled = If(checkReal > 0, True, False)
            rpItemCheckReal.ValueChecked = If(checkReal > 1, 1, 0)
            Dim checkAnalizado As Integer = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnAnalizada - 1, 1))
            btnAnalizada.Enabled = If(checkAnalizado > 0, True, False)
            rpItemCheckAnalizada.ValueChecked = If(checkAnalizado > 1, 1, 0)

            Dim checkVenta As Integer = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnVenta - 1, 1))

            btnVenta.Enabled = If(checkVenta > 0, True, False)
            btnVenta.Checked = (checkVenta > 1)

            rpItemCheckAnalizada.ValueChecked = If(checkVenta > 1, 1, 0)

            Dim checkCompra As Integer = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnCompra - 1, 1))
            btnCompra.Enabled = If(checkCompra > 0, True, False)
            btnCompra.Checked = If(checkCompra > 1, True, False)

            'rpItemCheckAnalizada.ValueChecked = If(checkCompra > 1, 1, 0)

            Dim checkInventario As Integer = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnInventario - 1, 1))
            btnInventarios.Enabled = If(checkInventario > 0, True, False)
            btnInventarios.Checked = If(checkInventario > 1, True, False)

            'rpItemCheckAnalizada.ValueChecked = If(checkInventario > 1, 1, 0)

            btnPrecio.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnPrecio - 1, 1))
            btnPrecio.Checked = (Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnPrecio - 1, 1)) > 1)

            btnSemaforo.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnSemaforo - 1, 1))
            btnVariacion.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnVariacion - 1, 1))
            btnSku.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnSku - 1, 1))
            btnFrecuencia.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnFrecuencia - 1, 1))
            btnSupervisionMarca.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnSupervisionMarca - 1, 1))
            btnSupervisionResumen.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnSupervisionResumen - 1, 1))
            btnActivarSupervision.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cbtnActivarSupervision - 1, 1))
            btnSupervisionValidar.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnSupervisionValidar - 1, 1))
            btnEstadistica.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnEstadistica - 1, 1))
            btnPropiedades.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnPropiedades - 1, 1))
            btnReplicarEncuesta.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnReplicaEncuestaAnterior - 1, 1))
            btnReplicarEncuestaPromedio.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnReplicaEncuestaPromedio - 1, 1))
            btnReplicarSkuPromedio.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnReplicaSkuPromedio - 1, 1))
            btnCancelarReplicas.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnCancelarReplicas - 1, 1))
            btnVerDatosValidos.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnVerDatosValidos - 1, 1))
            btnVerDatosCampo.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnVerDatosCampo - 1, 1))
            btnVerDatosSupervision.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnVerDatosSupervision - 1, 1))
            btnVerDatosAjustado.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnVerDatosAjustados - 1, 1))
            btnVerTodos.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnVerTodos - 1, 1))
            btnSemaforoAlertas.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnSemaforoAlertas - 1, 1))
            btnSemaforoOk.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnSemaforoOk - 1, 1))
            btnSemaforoTodos.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnSemaforoTodos - 1, 1))
            btnGestionRangos.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnGestionRangos - 1, 1))
            btnExportarExcel.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnExportaXLS - 1, 1))
            btnExportarPDF.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnExportaPDF - 1, 1))
            btnExportarCSV.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnExportaCSV - 1, 1))
            btnExportarXML.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnExportaXML - 1, 1))
            btnVistaPrevia.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnVistaPrevia - 1, 1))
            btnImprimir.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnImprimir - 1, 1))
            btnPanelControl.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnPanelControl - 1, 1))
            btnControlAvance.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnControlAvance - 1, 1))
            btnGrabar.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnGrabar - 1, 1))
            btnSincronizar.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnSincronizar - 1, 1))
            btnSalir.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnSalir - 1, 1))

            '0 Deshabilitado
            '1 Habilitado sin Chek
            '2 Habilitado con chek

            btnRegistros.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnRegistros - 1, 1))
            btnRegistros.Checked = (Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnRegistros - 1, 1)) > 1)

            btnVariablesTodos.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnVariablesTodos - 1, 1))
            btnVariablesTodos.Checked = (Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnVariablesTodos - 1, 1)) > 1)

            btnVariablesNinguno.Enabled = Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnVariablesNinguno - 1, 1))
            btnVariablesNinguno.Checked = (Convert.ToInt16(cadenaEstado.Substring(Constants.cBtnVariablesNinguno - 1, 1)) > 1)

            btnCambiarEstadoNoProcesa.Enabled = Convert.ToInt16(cadenaEstado.Substring(cbtnCambiarEstadoNoProcesa - 1, 1))
            btnCambiarEstado.Enabled = Convert.ToInt16(cadenaEstado.Substring(cbtnCambiarEstadoAtipico - 1, 1))
            btnAtipicos.Enabled = Convert.ToInt16(cadenaEstado.Substring(cbtnAtipicos - 1, 1))
            btnVaciar.Enabled = Convert.ToInt16(cadenaEstado.Substring(cbtnVaciar - 1, 1))
            btnActivar.Enabled = Convert.ToInt16(cadenaEstado.Substring(cbtnActivar - 1, 1))
            btnReplicaSKU.Enabled = Convert.ToInt16(cadenaEstado.Substring(cbtnReplicaSKU - 1, 1))
            btnCorrectos.Enabled = Convert.ToInt16(cadenaEstado.Substring(cbtnCorrectos - 1, 1))
            btnPendientes.Enabled = Convert.ToInt16(cadenaEstado.Substring(cbtnPendientes - 1, 1))
            btnEnSupervision.Enabled = Convert.ToInt16(cadenaEstado.Substring(cbtnEnSupervision - 1, 1))
            btnValidados.Enabled = Convert.ToInt16(cadenaEstado.Substring(cbtnValidados - 1, 1))
            btnNoProcesa.Enabled = Convert.ToInt16(cadenaEstado.Substring(cbtnNoProcesa - 1, 1))
            btnCongelar.Enabled = Convert.ToInt16(cadenaEstado.Substring(cbtnCongelar - 1, 1))
            btnEstadoTodos.Enabled = Convert.ToInt16(cadenaEstado.Substring(cbtnEstadoTodos - 1, 1))
            btnRecargar.Enabled = Convert.ToInt16(cadenaEstado.Substring(cbtnRecargar - 1, 1))


            btnSkuActivarRegistro.Enabled = Convert.ToInt16(cadenaEstado.Substring(cbtnSkuActivarRegistro - 1, 1))
            btnSkuPonerAtipico.Enabled = Convert.ToInt16(cadenaEstado.Substring(cbtnSkuPonerAtipico - 1, 1))
            btnSkuPonerNoProcesa.Enabled = Convert.ToInt16(cadenaEstado.Substring(cbtnSkuPonerNoProcesa - 1, 1))
            btnEnviaSupervision.Enabled = Convert.ToInt16(cadenaEstado.Substring(cbtnEnviaSupervision - 1, 1))
            btnGestionSupervision.Enabled = Convert.ToInt16(cadenaEstado.Substring(cbtnGestionSupervision - 1, 1))



            ' Solo si es un formulario de Encuesta, se fuerza el boton grabar ..

            Select Case giInidicadorActivo
                Case cEncuesta, cNegociosRegularesSindatos, cContratosSinReemplazo, cNegociosCategoriasFueradeRango, cNegociosCategoriasNSkus, cGestionDeSupervision
                    'FALTA  cResumenporCategorias y cGestionSupervision

                    gbEncuestaExistenCambios = (FCCRCC_EncuestaConsultaExistenciaTemporal() > 0)
                    btnGrabar.Enabled = gbEncuestaExistenCambios
                    btnVaciar.Enabled = btnGrabar.Enabled

            End Select
        


            Me.siStatus.Caption = "Carga exitosa ..."

        Catch ex As Exception
            Me.siStatus.Caption = "Ocurrío un error al activar la cinta de opciones " + ex.Message
        End Try
    End Sub

    Private Sub bbPanel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbPanel.ItemClick
        giIndicador = e.Item.Tag

        PanelControl(e.Item.Tag)

        'ActivarBotones(giIndicador)


    End Sub

    Private Sub PanelControl(ByVal IdIndicador As Integer)
        Dim frmPanel As New frmPanelControl
        'splitContainerControl.Visible = False
        frmPanel.MdiParent = Me
        frmPanel.Show()
    End Sub

    Private Sub bbAvance_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbAvance.ItemClick
        MODCC_ControlDeAvance(cControlDeAvance)
    End Sub

    Private Sub MODCC_ControlDeAvance(ByVal e As Integer)
        If gaIndicadoresAbiertos(e) <> "1" Or giPrincipalLoad = 1 Then

            giIndicador = e
            Dim frmAva As New frmAvance
            'splitContainerControl.Visible = False
            frmAva.MdiParent = Me
            frmAva.Tag = e
            frmAva.Show()

        Else
            'Activar el formulario existente...

        End If
    End Sub

    Private Sub bbIndicador01_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbIndicador01.ItemClick
        giIndicador = e.Item.Tag
        CapturaEncabezados()

        Dim frmIndicador01 As New frmPlantilla01
        frmIndicador01.MdiParent = Me
        'Me.BarEditItem.Visibility = BarItemVisibility.Never
        Me.siStatus.Caption = "Informacion cargada!"

        frmIndicador01.Show()

    End Sub

    Private Sub bbIndicador02_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbIndicador02.ItemClick
        giIndicador = e.Item.Tag
        Me.siStatus.Caption = "Cargando informacion ..."

        CapturaEncabezados()
        Dim frmIndicador02 As New frmPlantilla01
        frmIndicador02.MdiParent = Me

        'Me.BarEditItem.Visibility = BarItemVisibility.Never

        Me.siStatus.Caption = "Informacion cargada!"

        frmIndicador02.Show()
    End Sub

    Private Sub CapturaEncabezados()
        gsTituloIndicador = "01. Formulario Plantilla del Indicador " + giIndicador.ToString
        gsTituloIndicadorPrincipal = "Titulo Grilla Principal - Indicador  " + giIndicador.ToString
        gsTituloIndicadorSecundario = "Titulo Grilla Secundaria  - Indicador  " + giIndicador.ToString
        'splitContainerControl.Visible = False
    End Sub

    Private Sub bbIndicador03_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbIndicador03.ItemClick
        giIndicador = e.Item.Tag
        CapturaEncabezados()
        Dim frmIndicador03 As New frmPlantilla01
        frmIndicador03.MdiParent = Me
        Me.siStatus.Caption = "Informacion cargada!"
        frmIndicador03.Show()
    End Sub

    Private Sub btnSalir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSalir.ItemClick

        Me.Close()

    End Sub

    Private Sub frmPrincipal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim sNombreXML As String, sNombreReg As String
        Dim result As DialogResult = MessageBox.Show("¿Esta seguro(a) que desea salir del sistema?", "CCRCC Consistencia por Ciudad", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            gbCierreTotal = True

            'Agregar lógica
            'Dim value = giMedicion
            'Grabar estados de sesion del usuario..
            '---------------------------------------------------------------------------------------------------
            'Grabar XML de panel de control
            'Grabar todas las pestañas activas
            'Grabar Skin actual
            'Grabar variables de sesion: IdMedicionZona, Codigo Usuario, Pestaña activa, fecha de ultima sesion

            sNombreXML = cPrefijoPlantillaRibbon & Microsoft.VisualBasic.Right("000000" & LTrim(giCodigoUsuario.ToString), 6) & "_I" & Microsoft.VisualBasic.Right("000", 3)

            Me.ribbonControl.Toolbar.SaveLayoutToXml(cCarpetaTrabajo & sNombreXML)

            sNombreReg = "Global_U" & Microsoft.VisualBasic.Right("000000" & LTrim(giCodigoUsuario.ToString), 6)



            'Grabamos variables para ser recuperados posteriormente ...
            If Not Me.WindowState = 1 Then
                Call SaveSetting(APP_NAME, sNombreReg, "gsSkinName", UserLookAndFeel.Default.ActiveSkinName)
                Call SaveSetting(APP_NAME, sNombreReg, "giIndicador", giIndicador)
                Call SaveSetting(APP_NAME, sNombreReg, "giIdMedicionZona", giIdMedicionZona)

                Call SaveSetting(APP_NAME, sNombreReg, "gaIndicadoresAbiertos", Join(gaIndicadoresAbiertos, "@"))
                Call SaveSetting(APP_NAME, sNombreReg, "gaIndicadoresParametros", Join(gaIndicadoresParametros, "@"))
                Call SaveSetting(APP_NAME, sNombreReg, "gaIndicadoresFilaPrincipal", Join(gaIndicadoresFilaPrincipal, "@"))
                Call SaveSetting(APP_NAME, sNombreReg, "gaIndicadoresFilaSecundaria", Join(gaIndicadoresFilaSecundaria, "@"))
                Call SaveSetting(APP_NAME, sNombreReg, "gaIndicadoresBotones", Join(gaIndicadoresBotones, "@"))

            End If
        Else

            gbCierreTotal = False
            e.Cancel = True

        End If


    End Sub

    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub

    Private Sub bbRangos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbRangos.ItemClick
        MODCC_GestionDeRangos(cGestionDeRangos)
    End Sub

    Private Sub MODCC_GestionDeRangos(ByVal e As Integer)

        '+P Copiar esto en todos los MODCC
        If giIdMedicionZona = 0 Then
            MsgBox("Antes debe seleccionar una Zona especifica", MsgBoxStyle.Exclamation + MsgBoxStyle.DefaultButton1, "CCR CC - Mensaje de Advertencia")
        Else
            If gaIndicadoresAbiertos(e) <> "1" Or giPrincipalLoad = 1 Then
                Dim frmGestionRangos As New frmRangos
                frmGestionRangos.MdiParent = Me
                frmGestionRangos.idMedicionZona = giIdMedicionZona
                frmGestionRangos.Text = "Gestion de Rangos de " & gsNombreZona & " Medicion: " & giMedicion.ToString
                frmGestionRangos.Tag = e
                frmGestionRangos.Show()
            Else
                'Activar el formulario existente...

            End If
        End If

    End Sub

    Private Sub btnGrabar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGrabar.ItemClick
        InvocaModuloLocal(cBtnGrabar)
    End Sub

    Private Sub btnControlAvance_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnControlAvance.ItemClick
        MODCC_ControlDeAvance(cControlDeAvance)
    End Sub

    Private Sub btnPanelControl_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPanelControl.ItemClick
        MODCC_PanelDeControl(cPanelDeControl)
    End Sub

    Private Sub MODCC_PanelDeControl(ByVal e As Integer)
        If gaIndicadoresAbiertos(e) <> "1" Or giPrincipalLoad = 1 Then

            giIndicador = e
            Dim frmPanel As New frmPanelControl
            'splitContainerControl.Visible = False
            frmPanel.MdiParent = Me
            frmPanel.Tag = e
            frmPanel.Show()

        Else
            'Activar el formulario existente...

        End If


    End Sub

    Private Sub btnSincronizar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSincronizar.ItemClick
        InvocaModuloLocal(cBtnSincronizar)

    End Sub

    Private Sub btnPlantilla03_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPlantilla03.ItemClick
        Dim frmEncuesta As New frmPlantilla03
        'splitContainerControl.Visible = False
        frmEncuesta.MdiParent = Me

        frmEncuesta.WindowState = FormWindowState.Normal

        frmEncuesta.Show()
    End Sub

    Private Sub InvocaModuloLocal(ByVal liBoton As Integer)

        Dim frmActivo As Form = Me.ActiveMdiChild
        Dim sTitulo As String = ""
        Dim sSubTitulo As String = ""
        Dim liIndicador As Integer
        Dim lsId As String = ""                                     ',8,9,10,  ,11,12, Indicadores por Sku (listado de negocios de un sku, tampoco aplica
        '--+P V1.011 20150921 Dim sIndicadoresEncuesta As String = ",4,5,6,7,16,19,20,21, ,8,9,10,  ,11,12,"
        Dim sIndicadoresEncuesta As String = ",4,5,6,7,16,19,20,21, ,8,9,10, "
        Dim sBotonesEncuesta As String = ",11,48,16,17,74,75,80,"

        Dim grid As DevExpress.XtraGrid.GridControl
        Dim gridList As DevExpress.XtraTreeList.TreeList

        If Not gbLoadIndicador Then
            If giGridActivo = 2 And sIndicadoresEncuesta.Contains("," + frmActivo.Tag.ToString + ",") And sBotonesEncuesta.Contains("," + liBoton.ToString + ",") Then
                MsgBox("Los cambios de Estado de Negocio NO APLICA a nivel de Encuesta o Sku, vaya a Resumen", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "CCRCC: Cambio de Estado de Negocio")
                Exit Sub
            End If
           

        End If
        


        Try
            liIndicador = frmActivo.Tag

            Me.Cursor = Cursors.WaitCursor
            bsiProgreso.Visibility = BarItemVisibility.Always
            'bsiProgreso.Enabled = True

            If (Not frmActivo Is Nothing) Then

                Select Case frmActivo.Tag  ' Por Indicador o Plantilla   
                    Case cCategoriasCanalNuevos, cCategoriasCanalNRegs    ', cNegociosCategoriasFueradeRango

                        Dim f2 As frmPlantilla01 = CType(frmActivo, frmPlantilla01)

                        grid = If(giGridActivo = 1, f2.GridPrincipal, f2.GridSecundario)

                        sTitulo = f2.Text
                        sSubTitulo = If(giGridActivo = 1, f2.DockPrincipal.Text, f2.DockSecundario.Text)

                        'Aqui deben ir ... Acciones que requieren refrescar la Grilla..
                        Select Case liBoton
                            Case cBtnReplicaEncuestaAnterior, cBtnReplicaEncuestaPromedio

                                PCCRCC_EncuestaReplicaEncuesta_Multi(grid, gridList, liBoton, liIndicador)

                            Case cBtnSupervisionMarca   ', cBtnSupervisionValidar 'Es un eatdo del negocio

                                PCCRCC_EncuestaCambiarEstadoMulti(grid, gridList, liBoton, liIndicador)

                            Case cbtnCambiarEstadoAtipico, cbtnCambiarEstadoNoProcesa, cbtnActivar, cbtnActivarSupervision

                                PCCRCC_EncuestaCambiarEstadoMulti(grid, gridList, liBoton, liIndicador)

                        End Select

                        f2.MODCCLocal_Todos(liBoton)

                    Case cGestionDeRangos

                        Dim f2 As frmRangos = CType(frmActivo, frmRangos)
                        grid = f2.dgRangos

                        sTitulo = f2.Text
                        sSubTitulo = f2.dgRangos.Text

                        f2.MODCCLocal_Todos(liBoton)


                    Case cControlDeAvance

                        Dim f2 As frmAvance = CType(frmActivo, frmAvance)
                        grid = f2.grdZonasAnalisis

                        sTitulo = f2.Text
                        sSubTitulo = f2.grdZonasAnalisis.Text

                        f2.MODCCLocal_Todos(liBoton)


                    Case cMuestrasFueradeRango
                        Dim f2 As frmPlantilla02 = CType(frmActivo, frmPlantilla02)
                        grid = If(giGridActivo = 1, f2.GridPrincipal, f2.GridSecundario)

                        sTitulo = f2.Text
                        sSubTitulo = If(giGridActivo = 1, f2.DockPrincipal.Text, f2.DockSecundario.Text)

                        'Aqui deben ir ... Acciones que requieren refrescar la Grilla..
                        Select Case liBoton
                            Case cBtnReplicaEncuestaAnterior, cBtnReplicaEncuestaPromedio

                                PCCRCC_EncuestaReplicaEncuesta_Multi(grid, gridList, liBoton, liIndicador)

                            Case cBtnSupervisionMarca  ', cBtnSupervisionValidar

                                PCCRCC_EncuestaCambiarEstadoMulti(grid, gridList, liBoton, liIndicador)

                            Case cbtnCambiarEstadoAtipico, cbtnCambiarEstadoNoProcesa, cbtnActivar, cbtnActivarSupervision

                                PCCRCC_EncuestaCambiarEstadoMulti(grid, gridList, liBoton, liIndicador)
                        End Select


                        f2.MODCCLocal_Todos(liBoton)

                    Case cContratosSinReemplazo, cNegociosRegularesSindatos, cGestionDeSupervision, cErrores


                        Dim f2 As frmPlantillaEnc = CType(frmActivo, frmPlantillaEnc)

                        If giGridActivo = 1 Then
                            grid = f2.GridPrincipal
                        Else
                            gridList = f2.UcEncuestaNegocios1.gridSecundario
                            lsId = f2.UcEncuestaNegocios1.Tag
                        End If

                        sTitulo = f2.Text
                        sSubTitulo = If(giGridActivo = 1, f2.DockPrincipal.Text, f2.DockSecundario.Text)

                        ' ''sTitulo = f2.Text
                        ' ''sSubTitulo = If(giGridActivo = 1, f2.DockPrincipal.Text, f2.DockSecundario.Text)

                        '' ''Aqui deben ir ... Acciones que requieren refrescar la Grilla..
                        ' ''Select Case liBoton
                        ' ''    Case cBtnReplicaEncuestaAnterior, cBtnReplicaEncuestaPromedio

                        ' ''        PCCRCC_EncuestaReplicaEncuesta_Multi(grid, gridList, liBoton, liIndicador)

                        ' ''    Case cBtnSupervisionMarca, cbtnEnviaSupervision ', cBtnSupervisionValidar

                        ' ''        PCCRCC_EncuestaCambiarEstadoMulti(grid, gridList, liBoton, liIndicador)

                        ' ''    Case cbtnCambiarEstadoAtipico, cbtnCambiarEstadoNoProcesa, cbtnActivar

                        ' ''        PCCRCC_EncuestaCambiarEstadoMulti(grid, gridList, liBoton, liIndicador)
                        ' ''End Select




                        Select Case liBoton
                            Case cBtnSupervisionMarca, cbtnEnviaSupervision _
                                , cbtnCambiarEstadoAtipico, cbtnCambiarEstadoNoProcesa, cbtnActivar, cbtnActivarSupervision
                                If giGridActivo = 1 Then

                                    lsId = FCCRCC_FilasSeleccionadas(f2.GridPrincipal.Views(0))
                                Else

                                    If liBoton = cbtnEnviaSupervision Then
                                        lsId = ""  'NO APLICA ENVIO EN ENCUESTA, DEBE HACERLO DESDE EL RESUMEN DE NEGOCIOS
                                   
                                    End If

                                End If

                                'If giGridActivo = 1 Then
                                '    grid = f2.GridPrincipal
                                '    lsId = FCCRCC_FilasSeleccionadas(f2.GridPrincipal.Views(0))
                                'Else
                                '    gridList = f2.UcEncuestaNegocios1.gridSecundario
                                '    If liBoton = cbtnEnviaSupervision Then
                                '        lsId = ""  'NO APLICA ENVIO EN ENCUESTA, DEBE HACERLO DESDE EL RESUMEN DE NEGOCIOS
                                '    Else
                                '        lsId = f2.UcEncuestaNegocios1.Tag
                                '    End If

                                'End If
                                PCCRCC_EncuestaCambiarEstadoMulti_OK(lsId, liBoton, liIndicador)
                            Case cBtnReplicaEncuestaAnterior, cBtnReplicaEncuestaPromedio
                                If giGridActivo = 1 Then
                                    'grid = f2.GridPrincipal
                                    PCCRCC_EncuestaReplicaEncuesta_Multi(grid, gridList, liBoton, liIndicador)

                                End If

                        End Select


                        f2.MODCCLocal_Todos(liBoton)

                    Case cNegociosCategoriasFueradeRango, cNegociosCategoriasNSkus

                        Dim f2 As frmPlantillaNeg = CType(frmActivo, frmPlantillaNeg)

                        If giGridActivo = 1 Then
                            grid = f2.GridPrincipal
                        Else
                            gridList = f2.UcEncuestaNegocios1.gridSecundario
                        End If

                        sTitulo = f2.Text
                        sSubTitulo = "" 'If(giGridActivo = 1, f2.DockPrincipal.Text, f2.DockSecundario.Text)

                        'Aqui deben ir ... Acciones que requieren refrescar la Grilla..
                        Select Case liBoton
                            Case cBtnReplicaEncuestaAnterior, cBtnReplicaEncuestaPromedio

                                PCCRCC_EncuestaReplicaEncuesta_Multi(grid, gridList, liBoton, liIndicador)

                            Case cBtnSupervisionMarca  ', cBtnSupervisionValidar

                                PCCRCC_EncuestaCambiarEstadoMulti(grid, gridList, liBoton, liIndicador)

                            Case cbtnCambiarEstadoAtipico, cbtnCambiarEstadoNoProcesa, cbtnActivar, cbtnActivarSupervision

                                PCCRCC_EncuestaCambiarEstadoMulti(grid, gridList, liBoton, liIndicador)
                        End Select


                        f2.MODCCLocal_Todos(liBoton)



                    Case cSkusNuevos, cPosiblesSkusDescontinuados, cSkusSuspendidosConDatos
                        Dim f2 As frmPlantillaSku = CType(frmActivo, frmPlantillaSku)   'Era fromPlantilla05
                        grid = If(giGridActivo = 1, f2.GridPrincipal, f2.GridSecundario)

                        sTitulo = f2.Text
                        sSubTitulo = If(giGridActivo = 1, f2.DockPrincipal.Text, f2.DockSecundario.Text)

                        'Aqui deben ir ... Acciones que requieren refrescar la Grilla..
                        Select Case liBoton
                            Case cBtnReplicaEncuestaAnterior, cBtnReplicaEncuestaPromedio

                                '   PCCRCC_EncuestaReplicaEncuesta_Multi(grid, gridList, liBoton, liIndicador)

                            Case cBtnSupervisionMarca  ', cBtnSupervisionValidar

                                PCCRCC_EncuestaCambiarEstadoMulti(grid, gridList, liBoton, liIndicador)

                            Case cbtnCambiarEstadoAtipico, cbtnCambiarEstadoNoProcesa, cbtnActivar, cbtnActivarSupervision, cbtnEnviaSupervision, cbtnSkuActivarRegistro, cbtnActivarSupervision, cbtnSkuPonerAtipico, cbtnSkuPonerNoProcesa

                                PCCRCC_EncuestaCambiarEstadoMulti(grid, gridList, liBoton, liIndicador)

                        End Select



                        f2.MODCCLocal_Todos(liBoton)

                    Case cSkusFueraDeRango, cPreciosFueraDeRango
                        Dim f2 As frmPlantillaSkuCanal = CType(frmActivo, frmPlantillaSkuCanal)
                        grid = If(giGridActivo = 1, f2.GridPrincipal, f2.GridSecundario)

                        sTitulo = f2.Text
                        sSubTitulo = If(giGridActivo = 1, f2.DockPrincipal.Text, f2.DockSecundario.Text)

                        'Aqui deben ir ... Acciones que requieren refrescar la Grilla..
                        Select Case liBoton
                            Case cBtnReplicaEncuestaAnterior, cBtnReplicaEncuestaPromedio

                                '  PCCRCC_EncuestaReplicaEncuesta_Multi(grid, gridList, liBoton, liIndicador)

                            Case cBtnSupervisionMarca  ', cBtnSupervisionValidar

                                PCCRCC_EncuestaCambiarEstadoMulti(grid, gridList, liBoton, liIndicador)

                            Case cbtnCambiarEstadoAtipico, cbtnCambiarEstadoNoProcesa, cbtnActivar

                                PCCRCC_EncuestaCambiarEstadoMulti(grid, gridList, liBoton, liIndicador)

                            Case cbtnEditSkuCanal

                                PCCRCC_EditSkuCanal(grid, gridList, liBoton, liIndicador)

                        End Select


                        f2.MODCCLocal_Todos(liBoton)

                    Case cEncuesta

                        Dim f2 As frmPlantillaEnc = CType(frmActivo, frmPlantillaEnc)

                        If giGridActivo = 1 Then
                            grid = f2.GridPrincipal
                        Else
                            gridList = f2.UcEncuestaNegocios1.gridSecundario
                        End If

                        sTitulo = f2.Text
                        sSubTitulo = If(giGridActivo = 1, f2.DockPrincipal.Text, f2.DockSecundario.Text)

                        f2.MODCCLocal_Todos(liBoton)

                    Case cPanelDeControl

                        Dim f2 As frmPanelControl = CType(frmActivo, frmPanelControl)

                        sTitulo = f2.Text

                        f2.MODCCLocal_Todos(liBoton)

                    Case cCategorias ' cErrores, 
                        Dim f2 As frmPlantillaNeg = CType(frmActivo, frmPlantillaNeg)
                        'grid = If(giGridActivo = 1, f2.GridPrincipal, f2.GridSecundario)
                        grid = f2.GridPrincipal


                        sTitulo = f2.Text
                        sSubTitulo = ""

                        f2.MODCCLocal_Todos(liBoton)



                End Select
                Me.Cursor = Cursors.Default

                PrintableComponentLink1.ClearDocument()
                If (Not grid Is Nothing) Then
                    PrintableComponentLink1.Component = grid
                End If

                ' Solo para la encuesta
                If (Not gridList Is Nothing) Then
                    PrintableComponentLink1.Component = gridList
                End If

                If (Not grid Is Nothing) Or (Not gridList Is Nothing) Then


                    FormateoOpcionesdeImpresion(sTitulo, sSubTitulo)

                    Select Case liBoton
                        Case cBtnEstadistica, cBtnPropiedades

                            If ((giInidicadorActivo = cContratosSinReemplazo Or giInidicadorActivo = cNegociosRegularesSindatos Or _
                                 giInidicadorActivo = cNegociosCategoriasFueradeRango Or giInidicadorActivo = cNegociosCategoriasNSkus Or giInidicadorActivo = cEncuesta) And giGridActivo = 2) _
                                Or ((giInidicadorActivo = cSkusNuevos Or giInidicadorActivo = cPosiblesSkusDescontinuados _
                                    Or giInidicadorActivo = cSkusSuspendidosConDatos _
                                    Or giInidicadorActivo = cSkusFueraDeRango _
                                    Or giInidicadorActivo = cPreciosFueraDeRango) And giGridActivo = 1) _
                                Or ((giInidicadorActivo = cGestionDeSupervision) And giGridActivo = 2) _
                                Then
                                If liBoton = cBtnEstadistica Then
                                    PCCRCC_SkuEstadisticas(grid, gridList)
                                Else
                                    PCCRCC_SkuPropiedades(grid, gridList)
                                End If


                            Else
                                MsgBox("Las propiedades y estadisticas de Skus son solo visibles  " & vbCrLf & " en las ventanas y filas donde se encuentra un Sku especifico", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Skus: Propiedades y Estadisticas")

                            End If



                            'Case cBtnPropiedades

                            '    PCCRCC_SkuPropiedades(grid, gridList)

                        Case cBtnExportaXLS
                            Dim SaveFileDialog1 As New System.Windows.Forms.SaveFileDialog
                            SaveFileDialog1.Filter = "All Files (*.*) |*.*|ExcelFile (*.xls)|*.xls"

                            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                                PrintableComponentLink1.ExportToXls(SaveFileDialog1.FileName & ".xls")
                            End If

                        Case cBtnExportaXLSx
                            Dim SaveFileDialog1 As New System.Windows.Forms.SaveFileDialog
                            SaveFileDialog1.Filter = "All Files (*.*) |*.*|ExcelFile (*.xlsx)|*.xlsx"

                            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                                PrintableComponentLink1.ExportToXlsx(SaveFileDialog1.FileName & ".xlsx")
                            End If


                        Case cBtnExportaPDF
                            Dim SaveFileDialog1 As New System.Windows.Forms.SaveFileDialog
                            SaveFileDialog1.Filter = "All Files (*.*) |*.*|PDFFile (*.pdf)|*.pdf"

                            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                                PrintableComponentLink1.ExportToPdf(SaveFileDialog1.FileName & ".pdf")
                            End If

                        Case cBtnExportaCSV
                            Dim SaveFileDialog1 As New System.Windows.Forms.SaveFileDialog
                            SaveFileDialog1.Filter = "All Files (*.*) |*.*|CSVFile (*.csv)|*.csv"

                            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                                PrintableComponentLink1.ExportToCsv(SaveFileDialog1.FileName & ".csv")
                            End If

                        Case cBtnExportaXML

                            Dim SaveFileDialog1 As New System.Windows.Forms.SaveFileDialog
                            SaveFileDialog1.Filter = "All Files (*.*) |*.*|XMLFile (*.xml)|*.xml"

                            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                                PrintableComponentLink1.ExportToText(SaveFileDialog1.FileName & ".xml")

                            End If

                        Case cBtnVistaPrevia

                            'If Not grid.IsPrintingAvailable Then
                            '    MessageBox.Show("No se encuentra la libreria 'DevExpress.XtraPrinting' ", "Error")
                            '    Return
                            'End If

                            PrintableComponentLink1.ShowPreview()

                        Case cBtnImprimir
                            If Not grid.IsPrintingAvailable Then
                                MessageBox.Show("No se encuentra la libreria 'DevExpress.XtraPrinting'", "Error")
                                Return
                            End If

                            PrintableComponentLink1.PrintDlg()

                            'Case cBtnReplicaEncuestaAnterior, cBtnReplicaEncuestaPromedio

                            '    PCCRCC_EncuestaReplicaEncuesta_Multi(grid, gridList, liBoton, liIndicador)

                            'Case cBtnSupervisionMarca, cBtnSupervisionValidar

                            '    PCCRCC_EncuestaCambiarEstadoMulti(grid, gridList, liBoton, liIndicador)

                            'Case cbtnCambiarEstadoAtipico, cbtnCambiarEstadoNoProcesa, cbtnActivar

                            '    PCCRCC_EncuestaCambiarEstadoMulti(grid, gridList, liBoton, liIndicador)

                    End Select


                End If

            End If
            ' bsiProgreso.Enabled = flase

            bsiProgreso.Visibility = BarItemVisibility.Never
        Catch ex As Exception
            siStatus.Caption = "Ocurrío un error durante la ejecución del proceso. " + ex.Message
        End Try


    End Sub

    Private Sub FormateoOpcionesdeImpresion(ByVal sTitulo As String, ByVal sSubTitulo As String)

        Dim sNota01 As String = sTitulo
        Dim sNota02 As String = sSubTitulo
        Dim sNota03 As String = "Página: [Page # of Pages #]"

        Dim phf As PageHeaderFooter = _
            TryCast(PrintableComponentLink1.PageHeaderFooter, PageHeaderFooter)

        phf.Header.Content.Clear()

        phf.Header.Content.AddRange(New String() {sNota01, sNota02, sNota03})
        phf.Header.LineAlignment = BrickAlignment.Far

        sNota01 = "Usuario: [User Name]"
        sNota02 = ""
        sNota03 = "Fecha: [Date Printed]"

        phf.Footer.Content.AddRange(New String() {sNota01, sNota02, sNota03})
        phf.Footer.LineAlignment = BrickAlignment.Far

        PrintableComponentLink1.Landscape = True

    End Sub

    Private Sub rpItemCheckAnalizada_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rpItemCheckAnalizada.CheckedChanged
        InvocaModuloLocal(cBtnAnalizada)
    End Sub

    Private Sub rpItemCheckReal_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rpItemCheckReal.CheckedChanged
        InvocaModuloLocal(cBtnReal)
    End Sub

    Private Sub btnSemaforo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSemaforo.ItemClick
        InvocaModuloLocal(cBtnSemaforo)
    End Sub

    Private Sub btnVariacion_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVariacion.ItemClick
        InvocaModuloLocal(cBtnVariacion)
    End Sub

    Private Sub BarCheckItem1_CheckedChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVenta.CheckedChanged
        InvocaModuloLocal(cBtnVenta)
    End Sub

    Private Sub btnCompra_CheckedChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCompra.CheckedChanged
        InvocaModuloLocal(cBtnCompra)
    End Sub

    Private Sub btnInventarios_CheckedChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInventarios.CheckedChanged
        InvocaModuloLocal(cBtnInventario)
    End Sub

    Private Sub btnPrecio_CheckedChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrecio.CheckedChanged
        InvocaModuloLocal(cBtnPrecio)
    End Sub

    Private Sub btnRegistros_CheckedChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRegistros.CheckedChanged
        InvocaModuloLocal(cBtnRegistros)
    End Sub

    Private Sub btnVariablesTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVariablesTodos.CheckedChanged
        InvocaModuloLocal(cBtnVariablesTodos)
    End Sub

    Private Sub btnVariablesNinguno_CheckedChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVariablesNinguno.CheckedChanged
        InvocaModuloLocal(cBtnVariablesNinguno)
    End Sub

    Private Sub btnFrecuencia_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFrecuencia.ItemClick
        InvocaModuloLocal(cBtnFrecuencia)
    End Sub

    Private Sub btnSemaforoAlertas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSemaforoAlertas.ItemClick
        InvocaModuloLocal(cBtnSemaforoAlertas)
    End Sub

    Private Sub btnSemaforoOk_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSemaforoOk.ItemClick
        InvocaModuloLocal(cBtnSemaforoOk)
    End Sub

    Private Sub btnSemaforoTodos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSemaforoTodos.ItemClick
        InvocaModuloLocal(cBtnSemaforoTodos)
    End Sub

    Private Sub btnGestionRangos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGestionRangos.ItemClick
        frmPanelControl.LlamaPlantillas(cGestionDeRangos, 0)
    End Sub

    Private Sub btnVistaPrevia_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVistaPrevia.ItemClick
        InvocaModuloLocal(cBtnVistaPrevia)
    End Sub

    Private Sub btnExportarExcel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportarExcel.ItemClick
        InvocaModuloLocal(cBtnExportaXLS)
    End Sub

    Private Sub btnExportarPDF_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportarPDF.ItemClick
        InvocaModuloLocal(cBtnExportaPDF)
    End Sub

    Private Sub btnExportarCSV_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportarCSV.ItemClick
        InvocaModuloLocal(cBtnExportaCSV)
    End Sub

    Private Sub btnExportarXML_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportarXML.ItemClick
        InvocaModuloLocal(cBtnExportaXML)
    End Sub

    'Botones Encuesta
    Private Sub btnVaciar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVaciar.ItemClick
        InvocaModuloLocal(cbtnVaciar)
    End Sub

    Private Sub btnReplicarEncuesta_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReplicarEncuesta.ItemClick
        InvocaModuloLocal(cBtnReplicaEncuestaAnterior)
    End Sub

    Private Sub btnReplicarEncuestaPromedio_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReplicarEncuestaPromedio.ItemClick
        InvocaModuloLocal(cBtnReplicaEncuestaPromedio)
    End Sub

    Private Sub btnReplicarSkuPromedio_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReplicarSkuPromedio.ItemClick
        InvocaModuloLocal(cBtnReplicaSkuPromedio)
    End Sub

    Private Sub btnCancelarReplicas_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelarReplicas.ItemClick
        InvocaModuloLocal(cBtnCancelarReplicas)
    End Sub

    Private Sub btnVerDatosCampo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVerDatosCampo.ItemClick
        InvocaModuloLocal(cBtnVerDatosCampo)
    End Sub

    Private Sub btnVerDatosSupervision_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVerDatosSupervision.ItemClick
        InvocaModuloLocal(cBtnVerDatosSupervision)
    End Sub

    Private Sub btnVerDatosValidos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVerDatosValidos.ItemClick
        InvocaModuloLocal(cBtnVerDatosValidos)
    End Sub

    Private Sub btnEstadistica_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEstadistica.ItemClick

        InvocaModuloLocal(cBtnEstadistica)
    End Sub

    Private Sub btnPropiedades_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPropiedades.ItemClick
        InvocaModuloLocal(cBtnPropiedades)
    End Sub

    Private Sub btnVerDatosAjustado_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVerDatosAjustado.ItemClick
        InvocaModuloLocal(cBtnVerDatosAjustados)
    End Sub

    Private Sub btnVerTodos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVerTodos.ItemClick
        InvocaModuloLocal(cBtnVerTodos)
    End Sub

    Private Sub btnActivar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnActivar.ItemClick
        InvocaModuloLocal(cbtnActivar)
    End Sub

    Private Sub btnReplicaSKU_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReplicaSKU.ItemClick
        InvocaModuloLocal(cbtnReplicaSKU)
    End Sub

 

    Private Sub btnAcerca_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAcerca.ItemClick
        frmAcerca.ShowDialog()
    End Sub

    Private Sub btnCorrectos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCorrectos.ItemClick
        InvocaModuloLocal(cbtnCorrectos)
    End Sub

    Private Sub btnPendientes_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPendientes.ItemClick
        InvocaModuloLocal(cbtnPendientes)
    End Sub

    Private Sub btnSupervisionResumen_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSupervisionResumen.ItemClick
        InvocaModuloLocal(cBtnSupervisionResumen)



    End Sub

    Private Sub btnEnSupervision_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEnSupervision.ItemClick
        InvocaModuloLocal(cbtnEnSupervision)
    End Sub

    Private Sub btnSupervisionValidar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSupervisionValidar.ItemClick
        InvocaModuloLocal(cBtnSupervisionValidar)
    End Sub

    Private Sub btnValidados_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnValidados.ItemClick
        InvocaModuloLocal(cbtnValidados)
    End Sub

    Private Sub btnAtipicos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAtipicos.ItemClick
        InvocaModuloLocal(cbtnAtipicos)
    End Sub

    Private Sub btnNoProcesa_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNoProcesa.ItemClick
        InvocaModuloLocal(cbtnNoProcesa)
    End Sub

    Private Sub btnCongelar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCongelar.ItemClick
        InvocaModuloLocal(cbtnCongelar)
    End Sub

    Private Sub btnEstadoTodos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEstadoTodos.ItemClick
        InvocaModuloLocal(cbtnEstadoTodos)
    End Sub

    Private Sub btnRecargar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRecargar.ItemClick

        InvocaModuloLocal(cbtnRecargar)
    End Sub

    Private Sub btnCambiarEstado_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCambiarEstado.ItemClick
        InvocaModuloLocal(cbtnCambiarEstadoAtipico)
    End Sub

    Private Sub btnCambiarEstadoNoProcesa_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCambiarEstadoNoProcesa.ItemClick
        InvocaModuloLocal(cbtnCambiarEstadoNoProcesa)
    End Sub

    Private Sub btnSku_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSku.ItemClick
        InvocaModuloLocal(cBtnEstadistica)
    End Sub

    Private Sub btnSupervisionMarca_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSupervisionMarca.ItemClick
        InvocaModuloLocal(cBtnSupervisionMarca)

    End Sub

    Private Sub btnGestionSupervision_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGestionSupervision.ItemClick

        frmPanelControl.LlamaPlantillas(cGestionDeSupervision, 2)

    End Sub

    Private Sub btnEnviaSupervision_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEnviaSupervision.ItemClick
        InvocaModuloLocal(cbtnEnviaSupervision)
    End Sub

    Private Sub btnSkuActivarRegistro_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSkuActivarRegistro.ItemClick
        InvocaModuloLocal(cbtnSkuActivarRegistro)
    End Sub

    Private Sub btnSkuPonerAtipico_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSkuPonerAtipico.ItemClick
        InvocaModuloLocal(cbtnSkuPonerAtipico)
    End Sub

    Private Sub btnSkuPonerNoProcesa_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSkuPonerNoProcesa.ItemClick
        InvocaModuloLocal(cbtnSkuPonerNoProcesa)
    End Sub

    Private Sub btnActivarSupervision_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnActivarSupervision.ItemClick
        InvocaModuloLocal(cbtnActivarSupervision)

    End Sub

    Private Sub btnEditSkuCanal_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditSkuCanal.ItemClick
        InvocaModuloLocal(cbtnEditSkuCanal)
    End Sub
End Class