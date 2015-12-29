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


Public Class frmPlantillaNeg

    Dim ciPER As CultureInfo = New CultureInfo("es-PE")
    Dim ciSOL As CultureInfo = New CultureInfo("es-PE", False)
    Dim bLoad As Boolean = True

    Friend lIndicador As Indicadores = New Indicadores
    Friend iIdFila As Integer = 0
    Dim bEstuveFuera As Boolean = False
    Dim lstrCodigoNegocio As String = ""

    Sub New()

        frmPrincipal.siStatus.Caption = "Espere un momento por favor... cargando informacion ..."
        frmPrincipal.siStatus.Refresh()
        InitializeComponent()
        lIndicador = Indicador
        Me.Tag = lIndicador.IdIndicador

        Me.GridPrincipal.DataSource = PCCRCC_GrillaPrincipal()
        GridPrincipal.Visible = True

        gbRecargarGilla = False

        gaIndicadoresParametros(Me.Tag) = giIdMedicionZona

        FCCRCC_Local_RecuperaPlantillas(Me.Tag, Me.GridView1, UcEncuestaNegocios1.gridSecundario)


    End Sub

    Private Sub frmPlantillaNeg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        If bEstuveFuera Then
            frmPrincipal.ActivarCintaOpciones(Me.Tag, lIndicador.EstadoUIPageButtonGroup)
            bEstuveFuera = False

        End If
    End Sub

    Private Sub frmPlantillaNeg_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        PCCRCC_LimpiaPersonalizacion(Me.Tag)
    End Sub

    Private Sub frmPlantillaNeg_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        FCCRCC_Local_GuardaPlantillas(Me.Tag, Me.GridView1, UcEncuestaNegocios1.gridSecundario)

    End Sub

    Private Sub frmPlantillaNeg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sCadena As String
        Me.Text = Indicador.TituloIndicador
        lstrCodigoNegocio = gstrCodigoNegocio

        If GridPrincipal.Visible Then
            If giSubIndicador.ToString = "1" Then
                sCadena = "[P0_SFR] = " & IIf(giSubIndicador.ToString = "1", "2", "0")
                GridView1.Columns("P0_SFR").FilterInfo = New ColumnFilterInfo(sCadena)
            Else
                sCadena = "[Estado] = " & giSubIndicador.ToString
                GridView1.Columns("Estado").FilterInfo = New ColumnFilterInfo(sCadena)
            End If
         
            GridView1.Columns("TipoDato").FilterInfo = New ColumnFilterInfo("[TipoDato] = 2")
        Else

            '#T518F20150713
            UcEncuestaNegocios1.lstrCodigoNegocio = gstrCodigoNegocio

        End If

        MODCCLocal_Todos(cBtnVariablesTodos)

        Me.Cursor = Cursors.Default
        frmPrincipal.bsiProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

        bLoad = False
    End Sub

    

    Public Function FCCRCC_Local_GuardaPlantillas(ByVal liIndicador As Integer, ByRef oView1 As GridView, ByRef oView2 As DevExpress.XtraTreeList.TreeList) As Boolean
        Dim sNombreXml As String

        'sNombreXml = cPrefijoPlantillaDockMan & Microsoft.VisualBasic.Right("000000" & LTrim(giCodigoUsuario.ToString), 6) & "_I" & Microsoft.VisualBasic.Right("000" & LTrim(liIndicador.ToString), 6)
        'oDM.SaveLayoutToXml(cCarpetaTrabajo & sNombreXml)

        sNombreXml = cPrefijoPlantillaG01 & Microsoft.VisualBasic.Right("000000" & LTrim(giCodigoUsuario.ToString), 6) & "_I" & Microsoft.VisualBasic.Right("000" & LTrim(liIndicador.ToString), 6)
        oView1.SaveLayoutToXml(cCarpetaTrabajo & sNombreXml)

        sNombreXml = cPrefijoPlantillaG02 & Microsoft.VisualBasic.Right("000000" & LTrim(giCodigoUsuario.ToString), 6) & "_I" & Microsoft.VisualBasic.Right("000" & LTrim(liIndicador.ToString), 6)
        oView2.SaveLayoutToXml(cCarpetaTrabajo & sNombreXml)
        'PPM20150605 PCCRCC_LimpiaPersonalizacion(liIndicador)
        Return True
    End Function

    Public Function FCCRCC_Local_RecuperaPlantillas(ByVal liIndicador As Integer, ByRef oView1 As GridView, ByRef oView2 As DevExpress.XtraTreeList.TreeList) As Boolean
        Dim sNombreXml As String

        'sNombreXml = cPrefijoPlantillaDockMan & Microsoft.VisualBasic.Right("000000" & LTrim(giCodigoUsuario.ToString), 6) & "_I" & Microsoft.VisualBasic.Right("000", 3)
        'If (File.Exists(cCarpetaTrabajo & sNombreXml)) And Not (File.Exists(cCarpetaTrabajo & cArchivoReset)) Then
        '    oDM.RestoreLayoutFromXml(cCarpetaTrabajo & sNombreXml)
        'End If

        sNombreXml = cPrefijoPlantillaG01 & Microsoft.VisualBasic.Right("000000" & LTrim(giCodigoUsuario.ToString), 6) & "_I" & Microsoft.VisualBasic.Right("000" & LTrim(liIndicador.ToString), 6)
        If (File.Exists(cCarpetaTrabajo & sNombreXml)) And Not (File.Exists(cCarpetaTrabajo & cArchivoReset)) Then
            oView1.RestoreLayoutFromXml(cCarpetaTrabajo & sNombreXml)
        End If

        ' sNombreXml = cPrefijoPlantillaG02 & Microsoft.VisualBasic.Right("000000" & LTrim(giCodigoUsuario.ToString), 6) & "_I" & Microsoft.VisualBasic.Right("000" & LTrim(liIndicador.ToString), 6)
        sNombreXml = cPrefijoPlantillaG02 & Microsoft.VisualBasic.Right("000000" & LTrim(giCodigoUsuario.ToString), 6) & "_I" & Microsoft.VisualBasic.Right("000" & LTrim("20"), 6)
        If (File.Exists(cCarpetaTrabajo & sNombreXml)) And Not (File.Exists(cCarpetaTrabajo & cArchivoReset)) Then
            oView2.RestoreLayoutFromXml(cCarpetaTrabajo & sNombreXml)
        End If

        Return True
    End Function

    Public Function PCCRCC_GrillaPrincipal() As DataTable
        Dim cn As New SqlConnection(Global.CCRCCV2.My.MySettings.Default.BDPECCRCCConnectionString)
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        cmd.Connection = cn
        cmd.CommandText = lIndicador.SpPrincipal
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 0
        cmd.Parameters.Add("@pintIdMedicionZona", SqlDbType.Int).Value = giIdMedicionZona
        cmd.Parameters.Add("@pintIdIndicador", SqlDbType.SmallInt).Value = Me.Tag
        cmd.Parameters.Add("@pintSubIndicador", SqlDbType.SmallInt).Value = giSubIndicador
        da.SelectCommand = cmd
        da.Fill(dt)
        Return dt
    End Function

    Private Sub frmPlantillaNeg_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        frmPrincipal.ActivarCintaOpciones(Me.Tag, lIndicador.EstadoUIPageButtonGroup)
        Me.Cursor = Cursors.Default
        frmPrincipal.bsiProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

        If gbRecargarGilla Then
            If giGridActivo = 1 Then
                ReloadGridPrincipal()
            Else
                ReloadGridSecundario()
            End If
            gbRecargarGilla = False
        End If


        ''#T518F20150713
        'gstrCodigoNegocio = gaIndicadoresAbiertosEncuesta(lIndicador.IdIndicador)

    End Sub


    Friend Sub MODCCLocal_Todos(ByVal liBoton As Integer)
        Dim cadenaEstado = lIndicador.EstadoUIPageButtonGroup

        Me.Cursor = Cursors.WaitCursor
        frmPrincipal.bsiProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

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
                    sID = oDataRowView("IdMedicionZonaCanalNegocio")   ' Es el equivalente a IdMedicionZonaCanalNegocio de DatosHistoria
                    gstrCodigoNegocio = sID
                    UcEncuestaNegocios1.Tag = sID

                    '#T518F20150713
                    UcEncuestaNegocios1.lstrCodigoNegocio = sID

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

                If GridPrincipal.Visible And giGridActivo = 1 Then
                    GridView1.Columns("P0_SVta").Visible = Not lbEstado
                    GridView1.Columns("P0_PVta").Visible = Not lbEstado
                    GridView1.Columns("P0_VtaFac").Visible = Not lbEstado
                    GridView1.Columns("P1_VtaFac").Visible = Not lbEstado
                    GridView1.Columns("P2_VtaFac").Visible = Not lbEstado
                End If

                If giGridActivo = 2 Then
                    UcEncuestaNegocios1.clP0_VtaFac.Visible = Not lbEstado
                    UcEncuestaNegocios1.clP1_VtaFac.Visible = Not lbEstado
                    UcEncuestaNegocios1.clP2_VtaFac.Visible = Not lbEstado
                End If
          


            Case cBtnCompra
                Dim lbEstado As Boolean
                lbEstado = True
                Dim isChecked = frmPrincipal.btnCompra.Checked
                lIndicador.EstadoUIPageButtonGroup = PCCRCC_ReemplazaEstadoBoton(cadenaEstado, isChecked, cBtnCompra)
                If isChecked Then
                    lbEstado = False
                End If

                If GridPrincipal.Visible And giGridActivo = 1 Then
                    GridView1.Columns("P0_SCmp").Visible = Not lbEstado
                    GridView1.Columns("P0_PCmp").Visible = Not lbEstado
                    GridView1.Columns("P0_CmpFac").Visible = Not lbEstado
                    GridView1.Columns("P1_CmpFac").Visible = Not lbEstado
                    GridView1.Columns("P2_CmpFac").Visible = Not lbEstado
                End If

                If giGridActivo = 2 Then
                    UcEncuestaNegocios1.clP0_CM1PFac.Visible = Not lbEstado
                    UcEncuestaNegocios1.clP0_CM2PFac.Visible = Not lbEstado
                    UcEncuestaNegocios1.clP1_CM1PFac.Visible = Not lbEstado
                    UcEncuestaNegocios1.clP1_CM2PFac.Visible = Not lbEstado
                    UcEncuestaNegocios1.clP2_CM1PFac.Visible = Not lbEstado
                    UcEncuestaNegocios1.clP2_CM2PFac.Visible = Not lbEstado
                End If
           
            Case cBtnInventario
                Dim lbEstado As Boolean
                lbEstado = True
                Dim isChecked = frmPrincipal.btnInventarios.Checked
                lIndicador.EstadoUIPageButtonGroup = PCCRCC_ReemplazaEstadoBoton(cadenaEstado, isChecked, cBtnInventario)
                If isChecked Then
                    lbEstado = False
                End If

                If GridPrincipal.Visible And giGridActivo = 1 Then
                    GridView1.Columns("P0_SInv").Visible = Not lbEstado
                    GridView1.Columns("P0_PInv").Visible = Not lbEstado

                    GridView1.Columns("P0_InvFac").Visible = Not lbEstado
                    GridView1.Columns("P1_InvFac").Visible = Not lbEstado
                    GridView1.Columns("P2_InvFac").Visible = Not lbEstado

                    GridView1.Columns("P0_IAntFac").Visible = Not lbEstado
                    GridView1.Columns("P1_IAntFac").Visible = Not lbEstado
                    GridView1.Columns("P2_IAntFac").Visible = Not lbEstado
                End If
                'If GridPrincipal.Visible Then

                'End If

                If giGridActivo = 2 Then
                    UcEncuestaNegocios1.clP0_INVFac.Visible = Not lbEstado
                    UcEncuestaNegocios1.clP0_IAntFac.Visible = Not lbEstado
                    UcEncuestaNegocios1.clP1_INVFac.Visible = Not lbEstado
                    UcEncuestaNegocios1.clP1_IANTFac.Visible = Not lbEstado
                    UcEncuestaNegocios1.clP2_INVFac.Visible = Not lbEstado
                    UcEncuestaNegocios1.clP2_IANTFac.Visible = Not lbEstado
                End If



            Case cBtnPrecio
                Dim lbEstado As Boolean
                lbEstado = True
                Dim isChecked = frmPrincipal.btnPrecio.Checked
                lIndicador.EstadoUIPageButtonGroup = PCCRCC_ReemplazaEstadoBoton(cadenaEstado, isChecked, cBtnPrecio)
                If isChecked Then
                    lbEstado = False
                End If
                If GridPrincipal.Visible And giGridActivo = 1 Then
                    GridView1.Columns("P0_SPre").Visible = Not lbEstado
                    GridView1.Columns("P0_PPre").Visible = Not lbEstado
                    GridView1.Columns("P0_Precio").Visible = Not lbEstado
                    GridView1.Columns("P1_Precio").Visible = Not lbEstado
                    GridView1.Columns("P2_Precio").Visible = Not lbEstado
                End If

                If giGridActivo = 2 Then
                    UcEncuestaNegocios1.clP0_PREFac.Visible = Not lbEstado
                    UcEncuestaNegocios1.clP1_PREFac.Visible = Not lbEstado
                    UcEncuestaNegocios1.clP2_PREFac.Visible = Not lbEstado
                End If
        

            Case cBtnRegistros
                Dim lbEstado As Boolean
                lbEstado = True
                Dim isChecked = frmPrincipal.btnRegistros.Checked
                lIndicador.EstadoUIPageButtonGroup = PCCRCC_ReemplazaEstadoBoton(cadenaEstado, isChecked, cBtnRegistros)
                If isChecked Then
                    lbEstado = False
                End If

                If GridPrincipal.Visible And giGridActivo = 1 Then
                    'If frmPrincipal.btnVenta.EditValue = vb Then
                    GridView1.Columns("P0_SNre").Visible = Not lbEstado
                    GridView1.Columns("P0_PNre").Visible = Not lbEstado
                    GridView1.Columns("P0_Regs").Visible = Not lbEstado
                    GridView1.Columns("P1_Regs").Visible = Not lbEstado
                    GridView1.Columns("P2_Regs").Visible = Not lbEstado
                End If

            Case cBtnSemaforo
                Dim lbEstado As Boolean
                lbEstado = False

                If giGridActivo = 1 Then
                    lbEstado = GridView1.Columns("P0_SVta").Visible

                    'If frmPrincipal.btnVenta.EditValue = vb Then
                    GridView1.Columns("P0_SVta").Visible = Not lbEstado
                    GridView1.Columns("P0_SCmp").Visible = Not lbEstado
                    GridView1.Columns("P0_SInv").Visible = Not lbEstado
                    GridView1.Columns("P0_SPre").Visible = Not lbEstado
                    GridView1.Columns("P0_SNre").Visible = Not lbEstado

                End If

                'If giGridActivo = 2 Then

                '    lbEstado = GridView2.Columns("P0_SVta").Visible  'frmPrincipal.btnSemaforo.Down

                '    GridView2.Columns("P0_SVta").Visible = Not lbEstado
                '    GridView2.Columns("P0_SCmp").Visible = Not lbEstado
                '    GridView2.Columns("P0_SInv").Visible = Not lbEstado
                '    GridView2.Columns("P0_SPre").Visible = Not lbEstado
                '    GridView2.Columns("P0_SNre").Visible = Not lbEstado

                'End If





            Case cBtnVariacion

                Dim lbEstado As Boolean
                lbEstado = False

                If giGridActivo = 1 Then

                    lbEstado = GridView1.Columns("P0_PVta").Visible  ' frmPrincipal.btnVariacion.Down

                    GridView1.Columns("P0_PVta").Visible = Not lbEstado
                    GridView1.Columns("P0_PCmp").Visible = Not lbEstado
                    GridView1.Columns("P0_PInv").Visible = Not lbEstado
                    GridView1.Columns("P0_PPre").Visible = Not lbEstado
                    GridView1.Columns("P0_PNre").Visible = Not lbEstado

                End If

                'If giGridActivo = 2 Then

                '    lbEstado = GridView2.Columns("P0_PVta").Visible ' frmPrincipal.btnVariacion.Down

                '    GridView2.Columns("P0_PVta").Visible = Not lbEstado
                '    GridView2.Columns("P0_PCmp").Visible = Not lbEstado
                '    GridView2.Columns("P0_PInv").Visible = Not lbEstado
                '    GridView2.Columns("P0_PPre").Visible = Not lbEstado
                '    GridView2.Columns("P0_PNre").Visible = Not lbEstado
                'End If




            Case cBtnVariablesTodos

                Dim lbEstado As Boolean
                lbEstado = True

                If frmPrincipal.btnVariablesTodos.Checked Then
                    frmPrincipal.btnVenta.Checked = lbEstado
                    frmPrincipal.btnCompra.Checked = lbEstado
                    frmPrincipal.btnInventarios.Checked = lbEstado
                    frmPrincipal.btnPrecio.Checked = lbEstado
                    frmPrincipal.btnRegistros.Checked = lbEstado
                    frmPrincipal.btnVariablesNinguno.Checked = False
                    frmPrincipal.btnVariablesTodos.Checked = False
                    UcEncuestaNegocios1.clComentarios.Visible = True
                End If
            Case cBtnVariablesNinguno
                Dim lbEstado As Boolean
                lbEstado = False
                If frmPrincipal.btnVariablesNinguno.Checked Then
                    frmPrincipal.btnVenta.Checked = lbEstado
                    frmPrincipal.btnCompra.Checked = lbEstado
                    frmPrincipal.btnInventarios.Checked = lbEstado
                    frmPrincipal.btnPrecio.Checked = lbEstado
                    frmPrincipal.btnRegistros.Checked = lbEstado
                    frmPrincipal.btnVariablesTodos.Checked = False
                    frmPrincipal.btnVariablesNinguno.Checked = False
                    UcEncuestaNegocios1.clComentarios.Visible = True
                End If
            Case cBtnFrecuencia
                Dim lbEstado As Boolean
                lbEstado = False

                If giGridActivo = 1 Then
                    lbEstado = GridView1.Columns("Frecuencias").Visible
                    GridView1.Columns("Frecuencias").Visible = Not lbEstado
                Else

                    'UcEncuestaNegocios1.clFrecuencia.Visible = Not lbEstado
                End If



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



                'Case cBtnReplicaEncuestaAnterior, cBtnReplicaEncuestaPromedio, cbtnCambiarEstadoAtipico, cbtnCambiarEstadoNoProcesa, cbtnActivar, cbtnReplicaSKU, cBtnReplicaSkuPromedio, cbtnVaciar, cBtnGrabar
                '    'PCCRCC_EncuestaCambiarEstadoMulti(liBoton)
                '    If giGridActivo = 2 Then
                '        UcEncuestaNegocios1.MODCCLocal_Todos(liBoton)
                '    End If

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
                End If


            Case cbtnEstadoTodos
                If giGridActivo = 1 Then
                    GridView1.Columns("Estado").FilterInfo = New ColumnFilterInfo("")
                Else
                    '  GridView2.Columns("Estado").FilterInfo = New ColumnFilterInfo("")
                End If

            Case cBtnVerDatosCampo
                If giGridActivo = 1 Then
                    GridView1.Columns("TipoDato").FilterInfo = New ColumnFilterInfo("[TipoDato] = 0")
                Else
                    '  GridView2.Columns("TipoDato").FilterInfo = New ColumnFilterInfo("[TipoDato] = 0")
                End If

            Case cBtnVerDatosSupervision
                If giGridActivo = 1 Then
                    GridView1.Columns("TipoDato").FilterInfo = New ColumnFilterInfo("[TipoDato] = 1")
                Else
                    '  GridView2.Columns("TipoDato").FilterInfo = New ColumnFilterInfo("[TipoDato] = 1")
                End If

            Case cBtnVerDatosAjustados
                If giGridActivo = 1 Then
                    GridView1.Columns("TipoDato").FilterInfo = New ColumnFilterInfo("[TipoDato] = 2")
                Else

                    '  GridView2.Columns("TipoDato").FilterInfo = New ColumnFilterInfo("[TipoDato] = 2")
                End If

            Case cBtnVerTodos
                If giGridActivo = 1 Then
                    GridView1.Columns("TipoDato").FilterInfo = New ColumnFilterInfo("")
                Else
                    '  GridView2.Columns("TipoDato").FilterInfo = New ColumnFilterInfo("")
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

                'ReloadGridPrincipal()
                'ReloadGridSecundario()

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


        Me.Cursor = Cursors.Default
        frmPrincipal.bsiProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never



    End Sub



    ' '' ''Friend Sub MODCCLocal_Todos(ByVal liBoton As Integer)
    ' '' ''    Dim cadenaEstado = lIndicador.EstadoUIPageButtonGroup
    ' '' ''    Select Case liBoton
    ' '' ''        Case cBtnSincronizar

    ' '' ''            Dim sID As String
    ' '' ''            'Dim oDataRowView As DataRowView
    ' '' ''            'Dim oView As GridView
    ' '' ''            'Dim iRowHandle As Integer
    ' '' ''            Try
    ' '' ''                'If giGridActivo = 1 Then
    ' '' ''                '    oView = Me.GridView1
    ' '' ''                '    gstrCodigoNegocio = FCCRCC_FilasSeleccionadas(oView)
    ' '' ''                'End If


    ' '' ''                'iRowHandle = (CType(GridPrincipal.FocusedView, DevExpress.XtraGrid.Views.Base.ColumnView)).FocusedRowHandle
    ' '' ''                'oDataRowView = GridPrincipal.FocusedView.GetRow(iRowHandle)
    ' '' ''                'sID = oDataRowView("IdMedicionZonaCanalNegocio")   'IdMedicionZonaCanalNegocio
    ' '' ''                'gstrCodigoNegocio = sID
    ' '' ''                'UcEncuestaNegocios1.MODCCLocal_Todos(cBtnSincronizar)


    ' '' ''                Dim rowHandle = GridView1.FocusedRowHandle
    ' '' ''                sID = GridView1.GetRowCellValue(rowHandle, "IdMedicionZonaCanalNegocio")
    ' '' ''                If sID > 0 Then
    ' '' ''                    gstrCodigoNegocio = sID
    ' '' ''                    giMostrarEncuesta = 1
    ' '' ''                    '                        frmPanelControl.LlamaPlantillas(20, 0)
    ' '' ''                    UcEncuestaNegocios1.MODCCLocal_Todos(cBtnSincronizar)
    ' '' ''                Else
    ' '' ''                    giMostrarEncuesta = 0
    ' '' ''                End If

    ' '' ''            Catch ex As Exception
    ' '' ''                MsgBox(ex.Message)
    ' '' ''            Finally
    ' '' ''                'oDataRowView = Nothing
    ' '' ''            End Try
    ' '' ''        Case cBtnGrabar
    ' '' ''            MsgBox("Esto es guardar LOCAL de PLANTILLAenc Indicador # " & Me.Tag.ToString)

    ' '' ''        Case cBtnVenta
    ' '' ''            ' Se evalua el primero, y se cambia el estado de acuerdo a este....
    ' '' ''            Dim lbEstado As Boolean = True
    ' '' ''            Dim isChecked = frmPrincipal.btnVenta.Checked
    ' '' ''            If isChecked Then
    ' '' ''                lbEstado = False
    ' '' ''            End If
    ' '' ''            lIndicador.EstadoUIPageButtonGroup = PCCRCC_ReemplazaEstadoBoton(cadenaEstado, isChecked, cBtnVenta)

    ' '' ''            UcEncuestaNegocios1.clP0_VtaFac.Visible = Not lbEstado
    ' '' ''            UcEncuestaNegocios1.clP1_VtaFac.Visible = Not lbEstado
    ' '' ''            UcEncuestaNegocios1.clP2_VtaFac.Visible = Not lbEstado
    ' '' ''        Case cBtnCompra
    ' '' ''            Dim lbEstado As Boolean
    ' '' ''            lbEstado = True
    ' '' ''            Dim isChecked = frmPrincipal.btnCompra.Checked
    ' '' ''            lIndicador.EstadoUIPageButtonGroup = PCCRCC_ReemplazaEstadoBoton(cadenaEstado, isChecked, cBtnCompra)
    ' '' ''            If isChecked Then
    ' '' ''                lbEstado = False
    ' '' ''            End If
    ' '' ''            'If GridPrincipal.Visible Then
    ' '' ''            '    GridView1.Columns("P0_SCmp").Visible = Not lbEstado
    ' '' ''            '    GridView1.Columns("P0_PCmp").Visible = Not lbEstado
    ' '' ''            '    GridView1.Columns("P0_CmpFac").Visible = Not lbEstado
    ' '' ''            '    GridView1.Columns("P1_CmpFac").Visible = Not lbEstado
    ' '' ''            '    GridView1.Columns("P2_CmpFac").Visible = Not lbEstado
    ' '' ''            'End If

    ' '' ''            'frmPrincipal.btnVariablesNinguno.Checked = False
    ' '' ''            UcEncuestaNegocios1.clP0_CM1PFac.Visible = Not lbEstado
    ' '' ''            UcEncuestaNegocios1.clP0_CM2PFac.Visible = Not lbEstado
    ' '' ''            UcEncuestaNegocios1.clP1_CM1PFac.Visible = Not lbEstado
    ' '' ''            UcEncuestaNegocios1.clP1_CM2PFac.Visible = Not lbEstado
    ' '' ''            UcEncuestaNegocios1.clP2_CM1PFac.Visible = Not lbEstado
    ' '' ''            UcEncuestaNegocios1.clP2_CM2PFac.Visible = Not lbEstado
    ' '' ''        Case cBtnInventario
    ' '' ''            Dim lbEstado As Boolean
    ' '' ''            lbEstado = True
    ' '' ''            Dim isChecked = frmPrincipal.btnInventarios.Checked
    ' '' ''            lIndicador.EstadoUIPageButtonGroup = PCCRCC_ReemplazaEstadoBoton(cadenaEstado, isChecked, cBtnInventario)
    ' '' ''            If isChecked Then
    ' '' ''                lbEstado = False
    ' '' ''            End If
    ' '' ''            'If GridPrincipal.Visible Then
    ' '' ''            '    GridView1.Columns("P0_SInv").Visible = Not lbEstado
    ' '' ''            '    GridView1.Columns("P0_PInv").Visible = Not lbEstado

    ' '' ''            '    GridView1.Columns("P0_InvFac").Visible = Not lbEstado
    ' '' ''            '    GridView1.Columns("P1_InvFac").Visible = Not lbEstado
    ' '' ''            '    GridView1.Columns("P2_InvFac").Visible = Not lbEstado

    ' '' ''            '    GridView1.Columns("P0_IAntFac").Visible = Not lbEstado
    ' '' ''            '    GridView1.Columns("P1_IAntFac").Visible = Not lbEstado
    ' '' ''            '    GridView1.Columns("P2_IAntFac").Visible = Not lbEstado
    ' '' ''            'End If


    ' '' ''            UcEncuestaNegocios1.clP0_INVFac.Visible = Not lbEstado
    ' '' ''            UcEncuestaNegocios1.clP0_IAntFac.Visible = Not lbEstado
    ' '' ''            UcEncuestaNegocios1.clP1_INVFac.Visible = Not lbEstado
    ' '' ''            UcEncuestaNegocios1.clP1_IANTFac.Visible = Not lbEstado
    ' '' ''            UcEncuestaNegocios1.clP2_INVFac.Visible = Not lbEstado
    ' '' ''            UcEncuestaNegocios1.clP2_IANTFac.Visible = Not lbEstado


    ' '' ''        Case cBtnPrecio
    ' '' ''            Dim lbEstado As Boolean
    ' '' ''            lbEstado = True
    ' '' ''            Dim isChecked = frmPrincipal.btnPrecio.Checked
    ' '' ''            lIndicador.EstadoUIPageButtonGroup = PCCRCC_ReemplazaEstadoBoton(cadenaEstado, isChecked, cBtnPrecio)
    ' '' ''            If isChecked Then
    ' '' ''                lbEstado = False
    ' '' ''            End If
    ' '' ''            'If GridPrincipal.Visible Then
    ' '' ''            '    GridView1.Columns("P0_SPre").Visible = Not lbEstado
    ' '' ''            '    GridView1.Columns("P0_PPre").Visible = Not lbEstado
    ' '' ''            '    GridView1.Columns("P0_Precio").Visible = Not lbEstado
    ' '' ''            '    GridView1.Columns("P1_Precio").Visible = Not lbEstado
    ' '' ''            '    GridView1.Columns("P2_Precio").Visible = Not lbEstado
    ' '' ''            'End If


    ' '' ''            UcEncuestaNegocios1.clP0_PREFac.Visible = Not lbEstado
    ' '' ''            UcEncuestaNegocios1.clP1_PREFac.Visible = Not lbEstado
    ' '' ''            UcEncuestaNegocios1.clP2_PREFac.Visible = Not lbEstado

    ' '' ''        Case cBtnRegistros
    ' '' ''            Dim lbEstado As Boolean
    ' '' ''            lbEstado = True
    ' '' ''            Dim isChecked = frmPrincipal.btnRegistros.Checked
    ' '' ''            lIndicador.EstadoUIPageButtonGroup = PCCRCC_ReemplazaEstadoBoton(cadenaEstado, isChecked, cBtnRegistros)
    ' '' ''            If isChecked Then
    ' '' ''                lbEstado = False
    ' '' ''            End If
    ' '' ''            'If GridPrincipal.Visible Then
    ' '' ''            '    'If frmPrincipal.btnVenta.EditValue = vb Then
    ' '' ''            '    GridView1.Columns("P0_SNre").Visible = Not lbEstado
    ' '' ''            '    GridView1.Columns("P0_PNre").Visible = Not lbEstado
    ' '' ''            '    GridView1.Columns("P0_Regs").Visible = Not lbEstado
    ' '' ''            '    GridView1.Columns("P1_Regs").Visible = Not lbEstado
    ' '' ''            '    GridView1.Columns("P2_Regs").Visible = Not lbEstado
    ' '' ''            'End If




    ' '' ''        Case cBtnSemaforo
    ' '' ''            Dim lbEstado As Boolean
    ' '' ''            lbEstado = False

    ' '' ''            'lbEstado = GridView1.Columns("P0_VtaFac").Visible

    ' '' ''            'lbEstado = GridView1.Columns("P0_SPre").Visible
    ' '' ''            'If GridPrincipal.Visible Then
    ' '' ''            '    'If frmPrincipal.btnVenta.EditValue = vb Then
    ' '' ''            '    GridView1.Columns("P0_SVta").Visible = Not lbEstado
    ' '' ''            '    GridView1.Columns("P0_SCmp").Visible = Not lbEstado
    ' '' ''            '    GridView1.Columns("P0_SInv").Visible = Not lbEstado
    ' '' ''            '    GridView1.Columns("P0_SPre").Visible = Not lbEstado
    ' '' ''            '    GridView1.Columns("P0_SNre").Visible = Not lbEstado
    ' '' ''            'End If


    ' '' ''        Case cBtnVariacion
    ' '' ''            Dim lbEstado As Boolean
    ' '' ''            lbEstado = False
    ' '' ''            'If GridPrincipal.Visible Then
    ' '' ''            '    lbEstado = GridView1.Columns("P0_PPre").Visible
    ' '' ''            '    GridView1.Columns("P0_PVta").Visible = Not lbEstado
    ' '' ''            '    GridView1.Columns("P0_PCmp").Visible = Not lbEstado
    ' '' ''            '    GridView1.Columns("P0_PInv").Visible = Not lbEstado
    ' '' ''            '    GridView1.Columns("P0_PPre").Visible = Not lbEstado
    ' '' ''            '    GridView1.Columns("P0_PNre").Visible = Not lbEstado
    ' '' ''            'End If


    ' '' ''        Case cBtnRegistros

    ' '' ''            Dim lbEstado As Boolean
    ' '' ''            lbEstado = False
    ' '' ''            'If GridPrincipal.Visible Then
    ' '' ''            '    lbEstado = GridView1.Columns("P0_Regs").Visible
    ' '' ''            '    GridView1.Columns("P0_SNre").Visible = Not lbEstado
    ' '' ''            '    GridView1.Columns("P0_PNre").Visible = Not lbEstado
    ' '' ''            '    GridView1.Columns("P0_Regs").Visible = Not lbEstado
    ' '' ''            '    GridView1.Columns("P1_Regs").Visible = Not lbEstado
    ' '' ''            '    GridView1.Columns("P2_Regs").Visible = Not lbEstado
    ' '' ''            'End If

    ' '' ''            'UcEncuestaNegocios1.clP0_REG.Visible = Not lbEstado
    ' '' ''            'UcEncuestaNegocios1.clP1_REG.Visible = Not lbEstado
    ' '' ''            'UcEncuestaNegocios1.clP2_REG.Visible = Not lbEstado

    ' '' ''        Case cBtnVariablesTodos

    ' '' ''            Dim lbEstado As Boolean
    ' '' ''            lbEstado = True

    ' '' ''            If frmPrincipal.btnVariablesTodos.Checked Then
    ' '' ''                frmPrincipal.btnVenta.Checked = lbEstado
    ' '' ''                frmPrincipal.btnCompra.Checked = lbEstado
    ' '' ''                frmPrincipal.btnPrecio.Checked = lbEstado
    ' '' ''                frmPrincipal.btnInventarios.Checked = lbEstado
    ' '' ''                frmPrincipal.btnRegistros.Checked = lbEstado
    ' '' ''                frmPrincipal.btnVariablesNinguno.Checked = False
    ' '' ''                frmPrincipal.btnVariablesTodos.Checked = False
    ' '' ''            End If


    ' '' ''        Case cBtnVariablesNinguno

    ' '' ''            Dim lbEstado As Boolean
    ' '' ''            lbEstado = False

    ' '' ''            If frmPrincipal.btnVariablesNinguno.Checked Then
    ' '' ''                frmPrincipal.btnVenta.Checked = lbEstado
    ' '' ''                frmPrincipal.btnCompra.Checked = lbEstado
    ' '' ''                frmPrincipal.btnPrecio.Checked = lbEstado
    ' '' ''                frmPrincipal.btnInventarios.Checked = lbEstado
    ' '' ''                frmPrincipal.btnRegistros.Checked = lbEstado
    ' '' ''                frmPrincipal.btnVariablesTodos.Checked = False
    ' '' ''                frmPrincipal.btnVariablesNinguno.Checked = False
    ' '' ''            End If
    ' '' ''        Case cBtnFrecuencia
    ' '' ''            Dim lbEstado As Boolean
    ' '' ''            lbEstado = False
    ' '' ''            'If GridPrincipal.Visible Then
    ' '' ''            '    lbEstado = GridView1.Columns("Frecuencias").Visible
    ' '' ''            '    GridView1.Columns("Frecuencias").Visible = Not lbEstado
    ' '' ''            'End If

    ' '' ''            UcEncuestaNegocios1.clFrecuencia.Visible = Not lbEstado

    ' '' ''        Case cBtnSemaforoAlertas
    ' '' ''            'If GridPrincipal.Visible Then
    ' '' ''            '    GridView1.Columns("P0_SFR").FilterInfo = New ColumnFilterInfo("[P0_SFR] = 2")
    ' '' ''            'End If


    ' '' ''        Case cBtnSemaforoOk
    ' '' ''            'If GridPrincipal.Visible Then
    ' '' ''            '    GridView1.Columns("P0_SFR").FilterInfo = New ColumnFilterInfo("[P0_SFR] <> 2")
    ' '' ''            'End If


    ' '' ''        Case cBtnSemaforoTodos
    ' '' ''            'If GridPrincipal.Visible Then
    ' '' ''            '    GridView1.Columns("P0_SFR").FilterInfo = New ColumnFilterInfo("")
    ' '' ''            'End If
    ' '' ''        Case cBtnSalir
    ' '' ''        Case Else
    ' '' ''    End Select
    ' '' ''End Sub

    Private Sub PCCRCC_EncuestaReplicaEncuesta(ByVal piBoton As Integer)
        'Dim bRetorna As Boolean = False
        'Dim iRetorna As Int16 = 0 'NO ES NECESARIO...
        'Dim sID As String
        'Dim oDataRowView As DataRowView
        '' Dim oDataRow As DataRow
        'Dim iRowHandle As Integer
        'Try
        '    iRowHandle = (CType(GridSecundario.FocusedView, DevExpress.XtraGrid.Views.Base.ColumnView)).FocusedRowHandle
        '    oDataRowView = GridSecundario.FocusedView.GetRow(iRowHandle)
        '    sID = oDataRowView("IdMedicionZonaCanalNegocio")
        '    'FALTA MP  Capturar todos los Id seleccionados y ponerlos en una cadena para pasarlo al SP.
        '    Dim aParametros(2, 2) As String
        '    aParametros(0, 0) = "@sIdMedicionZonaCanalNegocio"
        '    aParametros(0, 1) = "Char"
        '    aParametros(0, 2) = sID
        '    aParametros(1, 0) = "@iTipoReplica"
        '    aParametros(1, 1) = "SmallInt"
        '    aParametros(1, 2) = piBoton
        '    CCRCC_EjecutaProcedimiento("PCCRCC_CambiarEstadoNegocios_upd", 2, aParametros, iRetorna)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'Finally
        '    'oDataRowView = Nothing
        'End Try
    End Sub



    Private Sub GridPrincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        giGridActivo = 1
    End Sub

    'Private Sub GridSecundario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridSecundario.Click
    '    giGridActivo = 2
    'End Sub

    Private Sub UcEncuestaNegocios1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UcEncuestaNegocios1.Click
        giGridActivo = 2
        '#T518F20150713
        'gstrCodigoNegocio = gaIndicadoresAbiertosEncuesta(lIndicador.IdIndicador)
    End Sub


    Private Sub frmPlantillaNeg_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        gaIndicadoresBotones(Me.Tag) = lIndicador.EstadoUIPageButtonGroup
        bEstuveFuera = True

    End Sub


    Private Sub GridPrincipal_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridPrincipal.DoubleClick
        giGridActivo = 1
        MODCCLocal_Todos(cBtnSincronizar)

    End Sub

    Private Sub UcEncuestaNegocios1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles UcEncuestaNegocios1.DoubleClick

        bEstuveFuera = True

        'MODCCLocal_Todos(cBtnSincronizar)

        PCCRCC_SkuEstadisticas(GridPrincipal, UcEncuestaNegocios1.gridSecundario)

    End Sub

    Private Sub ReloadGridPrincipal()
        If GridPrincipal.Visible Then

            Me.GridPrincipal.DataSource = PCCRCC_GrillaPrincipal()
            Me.GridPrincipal.RefreshDataSource()

        End If

    End Sub
    Private Sub ReloadGridSecundario()
        Dim sId As String
        '  sId = UcEncuestaNegocios1.Tag
       
        sId = lstrCodigoNegocio
        UcEncuestaNegocios1.MODCCLocal_Todos(cBtnSincronizar)

    End Sub

    Private Sub GridPrincipal_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridPrincipal.Click
        giGridActivo = 1
    End Sub

    Private Sub GridPrincipal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridPrincipal.GotFocus
        giGridActivo = 1
        ''#T518F20150713
        'gstrCodigoNegocio = gaIndicadoresAbiertosEncuesta(lIndicador.IdIndicador)
    End Sub

    Private Sub btnSplitHorizontal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSplitHorizontal.Click
        SplitContainerControl1.Horizontal = Not SplitContainerControl1.Horizontal
        btnSplitHorizontal.Text = If(SplitContainerControl1.Horizontal, "Organizar Horizontal", "Organizar Vertical")
    End Sub
End Class




'<Persistent("vCCRCC_GrillaNegociosCategorias")> _
'Public Class GrillaPrincipalPlantillaNeg
'    Inherits XPLiteObject
'    Public Sub New(ByVal session As Session)
'        MyBase.New(session)
'    End Sub
'    <Key(), DevExpress.Xpo.DisplayName("Id")> Public Id As System.Int32
'    <DevExpress.Xpo.DisplayName("Codigo Producto")> Public CodigoProducto As Integer

'    <DevExpress.Xpo.DisplayName("Canal")> Public Canal As String
'    <DevExpress.Xpo.DisplayName("Categoria")> Public Categoria As String
'    <DevExpress.Xpo.DisplayName("Nombre Comercial")> Public NombreComercial As String
'    <DevExpress.Xpo.DisplayName("CodigoNegocio")> Public CodigoNegocio As Integer
'    <DevExpress.Xpo.DisplayName("Tipo Dato")> Public TipoDato As Integer

'    'Semaforos TOTAL
'    <DevExpress.Xpo.DisplayName("P0_SFR")> Public P0_SFR As Integer
'    'Vta
'    <DevExpress.Xpo.DisplayName("P0_SVta")> Public P0_SVta As Integer
'    <DevExpress.Xpo.DisplayName("P0_PVta")> Public P0_PVta As Decimal
'    <DevExpress.Xpo.DisplayName("P0_VtaFac")> Public P0_VtaFac As Decimal
'    <DevExpress.Xpo.DisplayName("P1_VtaFac")> Public P1_VtaFac As Decimal
'    <DevExpress.Xpo.DisplayName("P2_VtaFac")> Public P2_VtaFac As Decimal
'    'Cmp
'    <DevExpress.Xpo.DisplayName("P0_SCmp")> Public P0_SCmp As Integer
'    <DevExpress.Xpo.DisplayName("P0_PCmp")> Public P0_PCmp As Decimal
'    <DevExpress.Xpo.DisplayName("P0_CmpFac")> Public P0_CmpFac As Decimal
'    <DevExpress.Xpo.DisplayName("P1_CmpFac")> Public P1_CmpFac As Decimal
'    <DevExpress.Xpo.DisplayName("P2_CmpFac")> Public P2_CmpFac As Decimal

'    'Inv
'    <DevExpress.Xpo.DisplayName("P0_SInv")> Public P0_SInv As Integer
'    <DevExpress.Xpo.DisplayName("P0_PInv")> Public P0_PInv As Decimal
'    <DevExpress.Xpo.DisplayName("P0_InvFac")> Public P0_InvFac As Decimal
'    <DevExpress.Xpo.DisplayName("P1_InvFac")> Public P1_InvFac As Decimal
'    <DevExpress.Xpo.DisplayName("P2_InvFac")> Public P2_InvFac As Decimal

'    'Pre
'    <DevExpress.Xpo.DisplayName("P0_SPre")> Public P0_SPre As Integer
'    <DevExpress.Xpo.DisplayName("P0_PPre")> Public P0_PPre As Decimal
'    <DevExpress.Xpo.DisplayName("P0_Precio")> Public P0_Precio As Decimal
'    <DevExpress.Xpo.DisplayName("P1_Precio")> Public P1_Precio As Decimal
'    <DevExpress.Xpo.DisplayName("P2_Precio")> Public P2_Precio As Decimal

'    'Regs
'    <DevExpress.Xpo.DisplayName("P0_SNre")> Public P0_SNre As Integer
'    <DevExpress.Xpo.DisplayName("P0_PNre")> Public P0_PNre As Decimal
'    <DevExpress.Xpo.DisplayName("P0_Regs")> Public P0_Regs As Decimal
'    <DevExpress.Xpo.DisplayName("P1_Regs")> Public P1_Regs As Decimal
'    <DevExpress.Xpo.DisplayName("P2_Regs")> Public P2_Regs As Decimal

'    'Porcentajes
'    'Semaforos
'    'Valores Periodo Actual
'    <DevExpress.Xpo.DisplayName("P0_IAntFac")> Public P0_IAntFac As Decimal
'    'Valores Periodo Anterior
'    <DevExpress.Xpo.DisplayName("P1_IAntFac")> Public P1_IAntFac As Decimal
'    'Valores Periodo Tras Anterior 
'    <DevExpress.Xpo.DisplayName("P2_IAntFac")> Public P2_IAntFac As Decimal
'    ', Frecuencias, CodigoFrecuencia, D.Historia, MZQN.Estado, MZQ.IdMedicionZona 
'    <DevExpress.Xpo.DisplayName("Frecuencias")> Public Frecuencias As String
'    <DevExpress.Xpo.DisplayName("CodigoFrecuencia")> Public CodigoFrecuencia As Integer
'    <DevExpress.Xpo.DisplayName("Historia")> Public Historia As String
'    <DevExpress.Xpo.DisplayName("Estado")> Public Estado As Integer
'    <DevExpress.Xpo.DisplayName("IdMedicionZona")> Public IdMedicionZona As System.Int32

'    <DevExpress.Xpo.DisplayName("IdMedicionZonaCanalCategoria")> Public IdMedicionZonaCanalCategoria As System.Int32 'Public CodigoMedicionZonaCanalCategoria As String
'    <DevExpress.Xpo.DisplayName("IdMedicionZonaCanalNegocio")> Public IdMedicionZonaCanalNegocio As System.Int32
'    <DevExpress.Xpo.DisplayName("CodGrupoAlertas")> Public CodGrupoAlertas As System.Int32
'    <DevExpress.Xpo.DisplayName("AlertasTotal")> Public AlertasTotal As System.Int32

'End Class



