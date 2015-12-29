Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.Xpo.Metadata
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils
Imports System.Globalization

Imports System.Data
Imports System.Data.SqlClient
Imports CCR.AnalisisxCuidad.Support
Imports DevExpress.XtraGrid.Columns
Imports System.IO
Imports CCR.AnalisisxCuidad.BE
Imports CCR.AnalisisxCuidad.BL
Imports DevExpress.XtraTreeList


Public Class frmPlantillaEnc

    Dim ciPER As CultureInfo = New CultureInfo("es-PE")
    Dim ciSOL As CultureInfo = New CultureInfo("es-PE", False)
    Dim bLoad As Boolean = True

    Friend lIndicador As Indicadores = New Indicadores
    Friend iIdFila As Integer = 0
    Dim lstrCodigoNegocio As String = ""
    Dim bEstuveFuera As Boolean = False

    Sub New()
        ' Dim sCadena As String
        frmPrincipal.siStatus.Caption = "Espere un momento por favor... cargando informacion ..."
        InitializeComponent()
        lIndicador = Indicador
        Me.Tag = lIndicador.IdIndicador
        gbRecargarGilla = False

        'Me.Tag = lIndicador.IdIndicador
        'If Not String.IsNullOrEmpty(lIndicador.SpPrincipal) Then
        '    ' Me.DockPrincipal.Text = "Indicador " & Indicador.IdIndicador.ToString & " " & Indicador.TituloIndicador & " " & gsNombreZona & "-" & giMedicion.ToString & "(" & Indicador.TituloIndicadorPrincipal & ")"
        '    FCCRCC_Local_RecuperaPlantillas(Me.Tag, Me.DockManager2, Me.GridView1, UcEncuestaNegocios1.gridSecundario)
        'End If
        'GridSecundario.Visible = False


        If String.IsNullOrEmpty(lIndicador.SpPrincipal) Then
            Me.GridPrincipal.Visible = False
            DockPrincipal.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            DockSecundario.Text = Indicador.TituloIndicadorSecundario
            DockSecundario.Tabbed = True
        Else
            Me.GridPrincipal.DataSource = PCCRCC_GrillaPrincipal()
            'FCCRCC_Local_RecuperaPlantillas(Me.Tag, Me.DockManager2, Me.GridView1, UcEncuestaNegocios1.gridSecundario)
            GridPrincipal.Visible = True
            'sCadena = "[P0_SFR] = " & IIf(giSubIndicador.ToString = "1", "2", "0")
            'GridView1.Columns("P0_SFR").FilterInfo = New ColumnFilterInfo(sCadena)
            'GridView1.Columns("TipoDato").FilterInfo = New ColumnFilterInfo("[TipoDato] = 2")
        End If
        FCCRCC_Local_RecuperaPlantillas(Me.Tag, Me.DockManager2, Me.GridView1, UcEncuestaNegocios1.gridSecundario)
        GridSecundario.Visible = False
        gaIndicadoresParametros(Me.Tag) = giIdMedicionZona
    End Sub

    Private Sub frmPlantillaEnc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        If bEstuveFuera Then
            frmPrincipal.ActivarCintaOpciones(Me.Tag, lIndicador.EstadoUIPageButtonGroup)
            bEstuveFuera = False
            'gstrCodigoNegocio = gaIndicadoresAbiertosEncuesta(lIndicador.IdIndicador)
        End If
    End Sub

    Private Sub frmPlantillaEnc_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        'gaIndicadoresBotones(Me.Tag) = lIndicador.EstadoUIPageButtonGroup
        gaIndicadoresBotones(Me.Tag) = lIndicador.EstadoUIPageButtonGroup
        If lIndicador.IdIndicador = cGestionDeSupervision Then
            frmPrincipal.rpgGestionSupervisionEncuesta.Visible = False
            frmPrincipal.rpgGestionSupervisionEstadoNegocio.Visible = False
        End If

    End Sub

    Private Sub frmPlantillaEnc_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        PCCRCC_LimpiaPersonalizacion(Me.Tag)
    End Sub

    Private Sub frmPlantillaEnc_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        FCCRCC_Local_GuardaPlantillas(Me.Tag, Me.DockManager2, Me.GridView1, UcEncuestaNegocios1.gridSecundario)
    End Sub

    Private Sub frmPlantillaEnc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sCadena As String

        lstrCodigoNegocio = gstrCodigoNegocio
        '+P
        'gbRecargarGilla = False
        'Me.Text = Indicador.TituloIndicador
        'Me.DockSecundario.Text = Indicador.TituloIndicadorSecundario

        '' ''Me.Tag = lIndicador.IdIndicador
        '' ''If Not String.IsNullOrEmpty(lIndicador.SpPrincipal) Then
        '' ''    ' Me.DockPrincipal.Text = "Indicador " & Indicador.IdIndicador.ToString & " " & Indicador.TituloIndicador & " " & gsNombreZona & "-" & giMedicion.ToString & "(" & Indicador.TituloIndicadorPrincipal & ")"
        '' ''    FCCRCC_Local_RecuperaPlantillas(Me.Tag, Me.DockManager2, Me.GridView1, UcEncuestaNegocios1.gridSecundario)
        '' ''End If
        '' ''GridSecundario.Visible = False
        'Mostrar todas las columnas..
        MODCCLocal_Todos(cBtnVariablesTodos)

        If GridPrincipal.Visible Then

            Select Case lIndicador.IdIndicador
                Case cErrores
                    sCadena = "[Estado] = " & IIf(giSubIndicador > 4, "5", giSubIndicador.ToString)
                    GridView1.Columns("Estado").FilterInfo = New ColumnFilterInfo(sCadena)
                    GridView1.Columns("TipoDato").FilterInfo = New ColumnFilterInfo("[TipoDato] = 2")
                    sCadena = "[CodGrupoAlertas] = " & IIf(Me.iIdFila = -1, "", Me.iIdFila.ToString())   '-1 mUESTRA TODOS LOS NEGOCIOS
                    GridView1.Columns("CodGrupoAlertas").FilterInfo = New ColumnFilterInfo(sCadena)

                Case cGestionDeSupervision
                    sCadena = "[Estado] = " & giSubIndicador.ToString
                    GridView1.Columns("Estado").FilterInfo = New ColumnFilterInfo(sCadena)
                    GridView1.Columns("TipoDato").FilterInfo = New ColumnFilterInfo("[TipoDato] = 2")

                Case cCategorias

                    'sCadena = "[Estado] = " & giSubIndicador.ToString
                    'GridView1.Columns("Estado").FilterInfo = New ColumnFilterInfo(sCadena)
                    'GridView1.Columns("TipoDato").FilterInfo = New ColumnFilterInfo("[TipoDato] = 2")
                    'sCadena = "[CodGrupoAlertas] = " & IIf(Me.iIdFila = -1, "", Me.iIdFila.ToString())   '-1 mUESTRA TODOS LOS NEGOCIOS
                    'GridView1.Columns("CodGrupoAlertas").FilterInfo = New ColumnFilterInfo(sCadena)

                Case Else
                    sCadena = "[P0_SFR] = " & IIf(giSubIndicador.ToString = "1", "2", "0")
                    GridView1.Columns("P0_SFR").FilterInfo = New ColumnFilterInfo(sCadena)
                    GridView1.Columns("TipoDato").FilterInfo = New ColumnFilterInfo("[TipoDato] = 2")
            End Select


        End If
    End Sub

    Public Function FCCRCC_Local_GuardaPlantillas(ByVal liIndicador As Integer, ByRef oDM As DevExpress.XtraBars.Docking.DockManager, ByRef oView1 As GridView, ByRef oView2 As DevExpress.XtraTreeList.TreeList) As Boolean
        Dim sNombreXml As String


        sNombreXml = cPrefijoPlantillaDockMan & Microsoft.VisualBasic.Right("000000" & LTrim(giCodigoUsuario.ToString), 6) & "_I" & Microsoft.VisualBasic.Right("000" & LTrim(liIndicador.ToString), 6)
        oDM.SaveLayoutToXml(cCarpetaTrabajo & sNombreXml)

        If Not String.IsNullOrEmpty(lIndicador.SpPrincipal) Then
            sNombreXml = cPrefijoPlantillaG01 & Microsoft.VisualBasic.Right("000000" & LTrim(giCodigoUsuario.ToString), 6) & "_I" & Microsoft.VisualBasic.Right("000" & LTrim(liIndicador.ToString), 6)
            oView1.SaveLayoutToXml(cCarpetaTrabajo & sNombreXml)
        End If

        sNombreXml = cPrefijoPlantillaG02 & Microsoft.VisualBasic.Right("000000" & LTrim(giCodigoUsuario.ToString), 6) & "_I" & Microsoft.VisualBasic.Right("000" & LTrim(liIndicador.ToString), 6)
        oView2.SaveLayoutToXml(cCarpetaTrabajo & sNombreXml)
        'PPM20150605 PCCRCC_LimpiaPersonalizacion(liIndicador)
        Return True
    End Function

    Public Function FCCRCC_Local_RecuperaPlantillas(ByVal liIndicador As Integer, ByRef oDM As DevExpress.XtraBars.Docking.DockManager, ByRef oView1 As GridView, ByRef oView2 As DevExpress.XtraTreeList.TreeList) As Boolean
        Dim sNombreXml As String


        sNombreXml = cPrefijoPlantillaDockMan & Microsoft.VisualBasic.Right("000000" & LTrim(giCodigoUsuario.ToString), 6) & "_I" & Microsoft.VisualBasic.Right("000", 3)
        If (File.Exists(cCarpetaTrabajo & sNombreXml)) And Not (File.Exists(cCarpetaTrabajo & cArchivoReset)) Then
            oDM.RestoreLayoutFromXml(cCarpetaTrabajo & sNombreXml)
        End If

        If Not String.IsNullOrEmpty(lIndicador.SpPrincipal) Then
            sNombreXml = cPrefijoPlantillaG01 & Microsoft.VisualBasic.Right("000000" & LTrim(giCodigoUsuario.ToString), 6) & "_I" & Microsoft.VisualBasic.Right("000" & LTrim(liIndicador.ToString), 6)
            If (File.Exists(cCarpetaTrabajo & sNombreXml)) And Not (File.Exists(cCarpetaTrabajo & cArchivoReset)) Then
                oView1.RestoreLayoutFromXml(cCarpetaTrabajo & sNombreXml)
            End If
        End If


        sNombreXml = cPrefijoPlantillaG02 & Microsoft.VisualBasic.Right("000000" & LTrim(giCodigoUsuario.ToString), 6) & "_I" & Microsoft.VisualBasic.Right("000" & LTrim(liIndicador.ToString), 6)
        If (File.Exists(cCarpetaTrabajo & sNombreXml)) And Not (File.Exists(cCarpetaTrabajo & cArchivoReset)) Then
            oView2.RestoreLayoutFromXml(cCarpetaTrabajo & sNombreXml)
        End If

        Return True
    End Function

    Public Function PCCRCC_GrillaPrincipal() As DataTable
        Try
            Return New PlantillasBL().ObtenerDatosPlantilla(lIndicador.SpPrincipal, giIdMedicionZona, Me.Tag, giSubIndicador)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub frmPlantillaEnc_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        frmPrincipal.ActivarCintaOpciones(Me.Tag, lIndicador.EstadoUIPageButtonGroup)
        '#T518F20150713
        'gstrCodigoNegocio = gaIndicadoresAbiertosEncuesta(lIndicador.IdIndicador)

        If lIndicador.IdIndicador = cGestionDeSupervision Then
            frmPrincipal.rpgGestionSupervisionEncuesta.Visible = True
            frmPrincipal.rpgGestionSupervisionEstadoNegocio.Visible = True

        End If

        If gbRecargarGilla Then
            If giGridActivo = 1 Then
                ReloadGridPrincipal()
            Else
                ReloadGridSecundario()
            End If
            gbRecargarGilla = False
        End If


    End Sub
    Friend Sub MODCCLocal_Todos(ByVal liBoton As Integer)
        Dim cadenaEstado = lIndicador.EstadoUIPageButtonGroup
        

        Select Case liBoton
            Case cBtnSincronizar

                Dim sID As String
                Dim oDataRowView As DataRowView
                Dim oView As GridView
                Dim iRowHandle As Integer
                Try
                    If giGridActivo = 1 Then
                        oView = Me.GridView1
                        gstrCodigoNegocio = FCCRCC_FilasSeleccionadas(oView)
                    End If
                    iRowHandle = (CType(GridPrincipal.FocusedView, DevExpress.XtraGrid.Views.Base.ColumnView)).FocusedRowHandle
                    oDataRowView = GridPrincipal.FocusedView.GetRow(iRowHandle)
                    sID = oDataRowView("Id")   ' Es el equivalente a IdMedicionZonaCanalNegocio de DatosHistoria
                    gstrCodigoNegocio = sID
                    UcEncuestaNegocios1.Tag = sID

                    '#T518F20150713
                    UcEncuestaNegocios1.lstrCodigoNegocio = sID
                    'gaIndicadoresAbiertosEncuesta(lIndicador.IdIndicador) = sID

                    UcEncuestaNegocios1.MODCCLocal_Todos(cBtnSincronizar)
                    UcEncuestaNegocios1.Focus()

                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    'oDataRowView = Nothing
                End Try
            Case cBtnVenta
                ' Se evalua el primero, y se cambia el estado de acuerdo a este....
                Dim lbEstado As Boolean
                lbEstado = True

                Dim isChecked = frmPrincipal.btnVenta.Checked
                If isChecked Then
                    lbEstado = False
                End If

                lIndicador.EstadoUIPageButtonGroup = PCCRCC_ReemplazaEstadoBoton(cadenaEstado, isChecked, cBtnVenta)

                'If GridPrincipal.Visible Then
                '    GridView1.Columns("P0_SVta").Visible = Not lbEstado
                '    GridView1.Columns("P0_PVta").Visible = Not lbEstado
                '    GridView1.Columns("P0_VtaFac").Visible = Not lbEstado
                '    GridView1.Columns("P1_VtaFac").Visible = Not lbEstado
                '    GridView1.Columns("P2_VtaFac").Visible = Not lbEstado
                'End If
                frmPrincipal.btnVariablesNinguno.Checked = False
                UcEncuestaNegocios1.clP0_VtaFac.Visible = Not lbEstado
                UcEncuestaNegocios1.clP1_VtaFac.Visible = Not lbEstado
                UcEncuestaNegocios1.clP2_VtaFac.Visible = Not lbEstado
            Case cBtnCompra
                Dim lbEstado As Boolean
                lbEstado = True
                Dim isChecked = frmPrincipal.btnCompra.Checked
                lIndicador.EstadoUIPageButtonGroup = PCCRCC_ReemplazaEstadoBoton(cadenaEstado, isChecked, cBtnCompra)
                If isChecked Then
                    lbEstado = False
                End If

                'If GridPrincipal.Visible Then
                '    GridView1.Columns("P0_SCmp").Visible = Not lbEstado
                '    GridView1.Columns("P0_PCmp").Visible = Not lbEstado
                '    GridView1.Columns("P0_CmpFac").Visible = Not lbEstado
                '    GridView1.Columns("P1_CmpFac").Visible = Not lbEstado
                '    GridView1.Columns("P2_CmpFac").Visible = Not lbEstado
                'End If

                'frmPrincipal.btnVariablesNinguno.Checked = False
                UcEncuestaNegocios1.clP0_CM1PFac.Visible = Not lbEstado
                UcEncuestaNegocios1.clP0_CM2PFac.Visible = Not lbEstado
                UcEncuestaNegocios1.clP1_CM1PFac.Visible = Not lbEstado
                UcEncuestaNegocios1.clP1_CM2PFac.Visible = Not lbEstado
                UcEncuestaNegocios1.clP2_CM1PFac.Visible = Not lbEstado
                UcEncuestaNegocios1.clP2_CM2PFac.Visible = Not lbEstado
            Case cBtnInventario
                Dim lbEstado As Boolean
                lbEstado = True
                Dim isChecked = frmPrincipal.btnInventarios.Checked
                lIndicador.EstadoUIPageButtonGroup = PCCRCC_ReemplazaEstadoBoton(cadenaEstado, isChecked, cBtnInventario)
                If isChecked Then
                    lbEstado = False
                End If

                'If GridPrincipal.Visible Then
                '    GridView1.Columns("P0_SInv").Visible = Not lbEstado
                '    GridView1.Columns("P0_PInv").Visible = Not lbEstado

                '    GridView1.Columns("P0_InvFac").Visible = Not lbEstado
                '    GridView1.Columns("P1_InvFac").Visible = Not lbEstado
                '    GridView1.Columns("P2_InvFac").Visible = Not lbEstado

                '    GridView1.Columns("P0_IAntFac").Visible = Not lbEstado
                '    GridView1.Columns("P1_IAntFac").Visible = Not lbEstado
                '    GridView1.Columns("P2_IAntFac").Visible = Not lbEstado
                'End If


                UcEncuestaNegocios1.clP0_INVFac.Visible = Not lbEstado
                UcEncuestaNegocios1.clP0_IAntFac.Visible = Not lbEstado
                UcEncuestaNegocios1.clP1_INVFac.Visible = Not lbEstado
                UcEncuestaNegocios1.clP1_IANTFac.Visible = Not lbEstado
                UcEncuestaNegocios1.clP2_INVFac.Visible = Not lbEstado
                UcEncuestaNegocios1.clP2_IANTFac.Visible = Not lbEstado


            Case cBtnPrecio
                Dim lbEstado As Boolean
                lbEstado = True
                Dim isChecked = frmPrincipal.btnPrecio.Checked
                lIndicador.EstadoUIPageButtonGroup = PCCRCC_ReemplazaEstadoBoton(cadenaEstado, isChecked, cBtnPrecio)
                If isChecked Then
                    lbEstado = False
                End If
                'If GridPrincipal.Visible Then
                '    GridView1.Columns("P0_SPre").Visible = Not lbEstado
                '    GridView1.Columns("P0_PPre").Visible = Not lbEstado
                '    GridView1.Columns("P0_Precio").Visible = Not lbEstado
                '    GridView1.Columns("P1_Precio").Visible = Not lbEstado
                '    GridView1.Columns("P2_Precio").Visible = Not lbEstado
                'End If


                UcEncuestaNegocios1.clP0_PREFac.Visible = Not lbEstado
                UcEncuestaNegocios1.clP1_PREFac.Visible = Not lbEstado
                UcEncuestaNegocios1.clP2_PREFac.Visible = Not lbEstado

            Case cBtnRegistros
                Dim lbEstado As Boolean
                lbEstado = True
                Dim isChecked = frmPrincipal.btnRegistros.Checked
                lIndicador.EstadoUIPageButtonGroup = PCCRCC_ReemplazaEstadoBoton(cadenaEstado, isChecked, cBtnRegistros)
                If isChecked Then
                    lbEstado = False
                End If
                'If GridPrincipal.Visible Then
                '    'If frmPrincipal.btnVenta.EditValue = vb Then
                '    GridView1.Columns("P0_SNre").Visible = Not lbEstado
                '    GridView1.Columns("P0_PNre").Visible = Not lbEstado
                '    GridView1.Columns("P0_Regs").Visible = Not lbEstado
                '    GridView1.Columns("P1_Regs").Visible = Not lbEstado
                '    GridView1.Columns("P2_Regs").Visible = Not lbEstado
                'End If




            Case cBtnSemaforo
                If giGridActivo = 1 Then
                    GridView1.Columns("P0_SFR").Visible = Not GridView1.Columns("P0_SFR").Visible
                End If


            Case cBtnVariacion



            Case cBtnRegistros

                Dim lbEstado As Boolean
                lbEstado = False
                'If GridPrincipal.Visible Then
                '    lbEstado = GridView1.Columns("P0_Regs").Visible
                '    GridView1.Columns("P0_SNre").Visible = Not lbEstado
                '    GridView1.Columns("P0_PNre").Visible = Not lbEstado
                '    GridView1.Columns("P0_Regs").Visible = Not lbEstado
                '    GridView1.Columns("P1_Regs").Visible = Not lbEstado
                '    GridView1.Columns("P2_Regs").Visible = Not lbEstado
                'End If

                'UcEncuestaNegocios1.clP0_REG.Visible = Not lbEstado
                'UcEncuestaNegocios1.clP1_REG.Visible = Not lbEstado
                'UcEncuestaNegocios1.clP2_REG.Visible = Not lbEstado

            Case cBtnVariablesTodos

                Dim lbEstado As Boolean
                lbEstado = True

                UcEncuestaNegocios1.clP0_VtaFac.Visible = lbEstado
                UcEncuestaNegocios1.clP1_VtaFac.Visible = lbEstado
                UcEncuestaNegocios1.clP2_VtaFac.Visible = lbEstado

                UcEncuestaNegocios1.clP0_CM1PFac.Visible = lbEstado
                UcEncuestaNegocios1.clP0_CM2PFac.Visible = lbEstado
                UcEncuestaNegocios1.clP1_CM1PFac.Visible = lbEstado
                UcEncuestaNegocios1.clP1_CM2PFac.Visible = lbEstado
                UcEncuestaNegocios1.clP2_CM1PFac.Visible = lbEstado
                UcEncuestaNegocios1.clP2_CM2PFac.Visible = lbEstado

                UcEncuestaNegocios1.clP0_INVFac.Visible = lbEstado
                UcEncuestaNegocios1.clP0_IAntFac.Visible = lbEstado
                UcEncuestaNegocios1.clP1_INVFac.Visible = lbEstado
                UcEncuestaNegocios1.clP1_IANTFac.Visible = lbEstado
                UcEncuestaNegocios1.clP2_INVFac.Visible = lbEstado
                UcEncuestaNegocios1.clP2_IANTFac.Visible = lbEstado

                UcEncuestaNegocios1.clP0_PREFac.Visible = lbEstado
                UcEncuestaNegocios1.clP1_PREFac.Visible = lbEstado
                UcEncuestaNegocios1.clP2_PREFac.Visible = lbEstado

                '' If frmPrincipal.btnVariablesTodos.Checked Then
                'frmPrincipal.btnVenta.Checked = lbEstado
                'frmPrincipal.btnCompra.Checked = lbEstado
                'frmPrincipal.btnInventarios.Checked = lbEstado
                'frmPrincipal.btnPrecio.Checked = lbEstado
                'frmPrincipal.btnRegistros.Checked = lbEstado
                'frmPrincipal.btnVariablesNinguno.Checked = lbEstado
                'frmPrincipal.btnVariablesTodos.Checked = lbEstado
                'UcEncuestaNegocios1.clComentarios.Visible = lbEstado
                '  End If
            Case cBtnVariablesNinguno
                Dim lbEstado As Boolean
                lbEstado = False

                UcEncuestaNegocios1.clP0_VtaFac.Visible = lbEstado
                UcEncuestaNegocios1.clP1_VtaFac.Visible = lbEstado
                UcEncuestaNegocios1.clP2_VtaFac.Visible = lbEstado

                UcEncuestaNegocios1.clP0_CM1PFac.Visible = lbEstado
                UcEncuestaNegocios1.clP0_CM2PFac.Visible = lbEstado
                UcEncuestaNegocios1.clP1_CM1PFac.Visible = lbEstado
                UcEncuestaNegocios1.clP1_CM2PFac.Visible = lbEstado
                UcEncuestaNegocios1.clP2_CM1PFac.Visible = lbEstado
                UcEncuestaNegocios1.clP2_CM2PFac.Visible = lbEstado

                UcEncuestaNegocios1.clP0_INVFac.Visible = lbEstado
                UcEncuestaNegocios1.clP0_IAntFac.Visible = lbEstado
                UcEncuestaNegocios1.clP1_INVFac.Visible = lbEstado
                UcEncuestaNegocios1.clP1_IANTFac.Visible = lbEstado
                UcEncuestaNegocios1.clP2_INVFac.Visible = lbEstado
                UcEncuestaNegocios1.clP2_IANTFac.Visible = lbEstado

                UcEncuestaNegocios1.clP0_PREFac.Visible = lbEstado
                UcEncuestaNegocios1.clP1_PREFac.Visible = lbEstado
                UcEncuestaNegocios1.clP2_PREFac.Visible = lbEstado



                '' If frmPrincipal.btnVariablesNinguno.Checked Then

                'frmPrincipal.btnVenta.Checked = lbEstado
                'frmPrincipal.btnCompra.Checked = lbEstado
                'frmPrincipal.btnInventarios.Checked = lbEstado
                'frmPrincipal.btnPrecio.Checked = lbEstado
                'frmPrincipal.btnRegistros.Checked = lbEstado
                'frmPrincipal.btnVariablesTodos.Checked = lbEstado
                'frmPrincipal.btnVariablesNinguno.Checked = lbEstado

                UcEncuestaNegocios1.clComentarios.Visible = Not lbEstado
                '  End If
            Case cBtnFrecuencia
                Dim lbEstado As Boolean
                lbEstado = False
                'If GridPrincipal.Visible Then
                '    lbEstado = GridView1.Columns("Frecuencias").Visible
                '    GridView1.Columns("Frecuencias").Visible = Not lbEstado
                'End If

                UcEncuestaNegocios1.clFrecuencia.Visible = Not lbEstado

            Case cBtnSemaforoAlertas
                If GridPrincipal.Visible Then
                    GridView1.Columns("P0_SFR").FilterInfo = New ColumnFilterInfo("[P0_SFR] = 2")
                End If


            Case cBtnSemaforoOk
                If GridPrincipal.Visible Then
                    GridView1.Columns("P0_SFR").FilterInfo = New ColumnFilterInfo("[P0_SFR] <> 2")
                End If


            Case cBtnSemaforoTodos
                If GridPrincipal.Visible Then
                    GridView1.Columns("P0_SFR").FilterInfo = New ColumnFilterInfo("")
                End If



            Case cBtnReplicaEncuestaAnterior, cBtnReplicaEncuestaPromedio, cbtnReplicaSKU, cBtnReplicaSkuPromedio, cbtnVaciar, cBtnGrabar, _
                    cbtnSkuActivarRegistro, cbtnSkuPonerAtipico, cbtnSkuPonerNoProcesa
                'Case cBtnReplicaEncuestaAnterior, cBtnReplicaEncuestaPromedio, cbtnCambiarEstadoAtipico, cbtnCambiarEstadoNoProcesa, cbtnActivar, cbtnReplicaSKU, cBtnReplicaSkuPromedio, cbtnVaciar, cBtnGrabar


                If giGridActivo = 2 Then
                    UcEncuestaNegocios1.MODCCLocal_Todos(liBoton)
                End If


                '<MP_FEN: Filtros de Estados de Negocios del 0 al 7 ...
                '----------------------------------------------
            Case cbtnCorrectos, cbtnPendientes, cBtnSupervisionResumen, cbtnEnSupervision, cBtnSupervisionValidar, cbtnValidados, cbtnAtipicos, cbtnNoProcesa
                If giGridActivo = 1 Then
                    GridView1.Columns("Estado").FilterInfo = New ColumnFilterInfo("[Estado] = " & (liBoton - 60).ToString)
                Else
                    ' GridView2.Columns("Estado").FilterInfo = New ColumnFilterInfo("[Estado] = " & (liBoton - 60).ToString)
                    UcEncuestaNegocios1.MODCCLocal_Todos(liBoton)
                End If


            Case cbtnEstadoTodos
                If giGridActivo = 1 Then
                    GridView1.Columns("Estado").FilterInfo = New ColumnFilterInfo("")
                Else
                    '  GridView2.Columns("Estado").FilterInfo = New ColumnFilterInfo("")
                    UcEncuestaNegocios1.MODCCLocal_Todos(liBoton)
                End If

            Case cBtnVerDatosCampo, cBtnVerDatosSupervision, cBtnVerDatosAjustados
                If giGridActivo = 1 Then
                    GridView1.Columns("TipoDato").FilterInfo = New ColumnFilterInfo("[TipoDato] = " & (liBoton - 21).ToString)
                Else
                    UcEncuestaNegocios1.MODCCLocal_Todos(liBoton)
                End If


            Case cBtnVerTodos
                If giGridActivo = 1 Then
                    GridView1.Columns("TipoDato").FilterInfo = New ColumnFilterInfo("")
                Else
                    UcEncuestaNegocios1.MODCCLocal_Todos(liBoton)
                End If






            Case cbtnCongelar
                If giGridActivo = 1 Then
                    PCCRCC_CongelarColumnas(GridView1)
                End If



            Case cbtnRecargar
                If giGridActivo = 1 Then
                    ReloadGridPrincipal()
                End If

                If giGridActivo = 2 Then
                    ReloadGridSecundario()
                End If


            Case cBtnSalir
            Case Else
        End Select

        If gbRecargarGilla Then
            If giGridActivo = 1 Then
                ReloadGridPrincipal()
            Else
                ReloadGridSecundario()
            End If
            gbRecargarGilla = False
        End If



    End Sub

    Private Sub PCCRCC_EncuestaReplicaEncuesta(ByVal piBoton As Integer)
        Dim bRetorna As Boolean = False
        Dim iRetorna As Int16 = 0 'NO ES NECESARIO...
        Dim sID As String
        Dim oDataRowView As DataRowView
        ' Dim oDataRow As DataRow
        Dim iRowHandle As Integer
        Try
            iRowHandle = (CType(GridSecundario.FocusedView, DevExpress.XtraGrid.Views.Base.ColumnView)).FocusedRowHandle
            oDataRowView = GridSecundario.FocusedView.GetRow(iRowHandle)
            sID = oDataRowView("IdMedicionZonaCanalNegocio")
            'FALTA MP  Capturar todos los Id seleccionados y ponerlos en una cadena para pasarlo al SP.
            Dim aParametros(2, 2) As String
            aParametros(0, 0) = "@sIdMedicionZonaCanalNegocio"
            aParametros(0, 1) = "Char"
            aParametros(0, 2) = sID
            aParametros(1, 0) = "@iTipoReplica"
            aParametros(1, 1) = "SmallInt"
            aParametros(1, 2) = piBoton
            CCRCC_EjecutaProcedimiento("PCCRCC_CambiarEstadoNegocios_upd", 2, aParametros, iRetorna)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'oDataRowView = Nothing
        End Try
    End Sub

    Private Sub PCCRCC_EncuestaCambiarEstadoMulti_Local(ByVal piBoton As Integer)
        Dim bRetorna As Boolean = False
        Dim iRetorna As Int16 = 0 'NO ES NECESARIO...
        Dim sID As String
        Try
            'sID = FCCRCC_FilasSeleccionadas(If(giGridActivo = 1, GridView1, GridView2))
            sID = FCCRCC_FilasSeleccionadas(GridView1)
            Dim aParametros(4, 2) As String
            aParametros(0, 0) = "@lsIds"
            aParametros(0, 1) = "Char"
            aParametros(0, 2) = sID
            aParametros(1, 0) = "@pBoton"
            aParametros(1, 1) = "SmallInt"
            ' aParametros(1, 2) = If(piBoton = cbtnAtipico, 6, If(piBoton = cbtnNoProcesa, 7, 5))
            aParametros(1, 2) = piBoton '= cbtnCambiarEstadoAtipico, 6, If(piBoton = cbtnCambiarEstadoNoProcesa, 7, 5))
            aParametros(2, 0) = "pintIdIndicador"
            aParametros(2, 1) = "SmallInt"
            aParametros(2, 2) = Me.Tag
            aParametros(3, 0) = "@IdGrilla"
            aParametros(3, 1) = "SmallInt"
            aParametros(3, 2) = giGridActivo
            CCRCC_EjecutaProcedimiento("PCCRCC_EncuestaCambiarEstadoMulti_Upd", 4, aParametros, iRetorna)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ReloadGridPrincipal()
        End Try
    End Sub

    Private Sub GridPrincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridPrincipal.Click
        giGridActivo = 1
    End Sub

    Private Sub GridSecundario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridSecundario.Click
        giGridActivo = 2
    End Sub

    Private Sub UcEncuestaNegocios1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UcEncuestaNegocios1.Click
        giGridActivo = 2
    End Sub

    Private Sub frmPlantillaEnc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        gaIndicadoresBotones(Me.Tag) = lIndicador.EstadoUIPageButtonGroup
        bEstuveFuera = True
    End Sub

    Private Sub UcEncuestaNegocios1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles UcEncuestaNegocios1.DoubleClick
        bEstuveFuera = True

        'MODCCLocal_Todos(cBtnSincronizar)

        PCCRCC_SkuEstadisticas(GridPrincipal, UcEncuestaNegocios1.gridSecundario)

    End Sub

    Private Sub GridPrincipal_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridPrincipal.DoubleClick
        MODCCLocal_Todos(cBtnSincronizar)
    End Sub

    Private Sub ReloadGridPrincipal()
        If GridPrincipal.Visible Then

            Me.GridPrincipal.DataSource = PCCRCC_GrillaPrincipal()
            Me.GridPrincipal.RefreshDataSource()

        End If

    End Sub
    Private Sub ReloadGridSecundario()
        Dim sId As String
        'sId = UcEncuestaNegocios1.Tag
        sId = lstrCodigoNegocio
        UcEncuestaNegocios1.MODCCLocal_Todos(cBtnSincronizar)

    End Sub
End Class
