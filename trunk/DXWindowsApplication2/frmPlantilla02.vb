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
Imports CCR.AnalisisxCuidad.BE
Imports CCR.AnalisisxCuidad.BL


Public Class frmPlantilla02

    Dim ciPER As CultureInfo = New CultureInfo("es-PE")
    Dim ciSOL As CultureInfo = New CultureInfo("es-PE", False)

    Friend lIndicador As Indicadores = New Indicadores

    Sub New()
        frmPrincipal.siStatus.Caption = "Espere un momento por favor... cargando informacion ..."
        InitializeComponent()

        Try
            lIndicador = Indicador
            Me.Tag = giIndicador


            ' GridPrincipal 
            Me.GridPrincipal.DataSource = PCCRCC_GrillaPrincipal()

            ' GridSecundario 
            '' '' ''XpoDefault.ConnectionString = "XpoProvider=MSSqlServer;" & Global.CCRCCV2.My.MySettings.Default.BDPECCRCCConnectionString

            '' '' ''Dim session3 As Session = New Session()
            '' '' ''Dim classInfo2 As XPClassInfo

            '' '' ''classInfo2 = session3.GetClassInfo(GetType(GrillaSecundariaPlantilla02))

            '' '' ''Dim xpServerCollectionSource2 As XPServerCollectionSource = New XPServerCollectionSource(session3, classInfo2)

            '' '' ''Me.GridSecundario.DataSource = xpServerCollectionSource2

            '' '' ''Me.GridView2.OptionsView.ColumnAutoWidth = False
            '' '' ''GridView2.Columns("IdMedicionZona").FilterInfo = New ColumnFilterInfo("[IdMedicionZona] = " & giIdMedicionZona.ToString)
            Me.GridSecundario.DataSource = PCCRCC_GrillaSecundaria(0)

            gbRecargarGilla = False

            FCCRCC_RecuperaPlantillas(Me.Tag, Me.DockManager2, Me.GridView1, Me.GridView2)
            
        Catch ex As Exception
            frmPrincipal.siStatus.Caption = "Ocurrió un error durante la ejecución del proceso. " + ex.Message
        End Try
    End Sub


    Private Function PCCRCC_GrillaSecundaria(ByVal pId As Int64) As DataTable
        Dim cn As New SqlConnection(Global.CCRCCV2.My.MySettings.Default.BDPECCRCCConnectionString)
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        cmd.Connection = cn
        cmd.CommandText = lIndicador.SpSecundario
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 0
        cmd.Parameters.Add("@Id", SqlDbType.BigInt).Value = pId
        cmd.Parameters.Add("@piIndicador", SqlDbType.SmallInt).Value = lIndicador.IdIndicador
        da.SelectCommand = cmd
        da.Fill(dt)
        Return dt
    End Function


    Private Sub frmPlantilla02_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        gaIndicadoresBotones(Me.Tag) = lIndicador.EstadoUIPageButtonGroup
    End Sub

    Private Sub frmPlantilla02_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        PCCRCC_LimpiaPersonalizacion(Me.Tag)
    End Sub

    Private Sub frmPlantilla02_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Dim liIndicador As Integer = Me.Tag
        'Dim sNombreXml As String

        'sNombreXml = cPrefijoPlantillaDockMan & Microsoft.VisualBasic.Right("000000" & LTrim(giCodigoUsuario.ToString), 6) & "_I" & Microsoft.VisualBasic.Right("000" & LTrim(liIndicador.ToString), 6)

        'Me.DockManager2.SaveLayoutToXml(cCarpetaTrabajo & sNombreXml)

        FCCRCC_GuardaPlantillas(Me.Tag, Me.DockManager2, Me.GridView1, Me.GridView2)


    End Sub


    Private Sub frmPlantilla02_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.Text = Indicador.TituloIndicador
        'Me.DockSecundario.Text = Indicador.TituloIndicadorSecundario
        'Me.DockPrincipal.Text = "Indicador " & Indicador.IdIndicador.ToString & " " & Indicador.TituloIndicador & " " & gsNombreZona & "-" & giMedicion.ToString & "(" & Indicador.TituloIndicadorPrincipal & ")"


        'FCCRCC_RecuperaPlantillas(Me.Tag, Me.DockManager2, Me.GridView1, Me.GridView2)

        MODCCLocal_Todos(cBtnVariablesTodos)

        'If gbLoadSistema Then
        Me.DockSecundario.Text = Indicador.TituloIndicadorSecundario
        ' End If

        'Filtros Iniciales ...
        GridView1.Columns("Estado").FilterInfo = New ColumnFilterInfo("[Estado] = " & giSubIndicador.ToString)
        GridView1.Columns("TipoDato").FilterInfo = New ColumnFilterInfo("[TipoDato] = 2")

    End Sub



    Public Function PCCRCC_GrillaPrincipal() As DataTable

        Try
            Return New PlantillasBL().ObtenerDatosPlantilla(lIndicador.SpPrincipal, giIdMedicionZona, Me.Tag, giSubIndicador)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub frmPlantilla02_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        frmPrincipal.ActivarCintaOpciones(Me.Tag, lIndicador.EstadoUIPageButtonGroup)

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
                Dim iRowHandle As Integer
                Try

                    iRowHandle = (CType(GridPrincipal.FocusedView, DevExpress.XtraGrid.Views.Base.ColumnView)).FocusedRowHandle
                    oDataRowView = GridPrincipal.FocusedView.GetRow(iRowHandle)
                    sID = oDataRowView("CodigoMedicionZonaCanalCategoria")

                    'Nuevo
                    Me.GridSecundario.Tag = sID
                    Me.GridSecundario.DataSource = PCCRCC_GrillaSecundaria(sID)
                    ' '' '' ''GridView2.Columns("IdMedicionZonaCanalCategoria").FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("IdMedicionZonaCanalCategoria= " & sID & " ")
                    GridView2.Focus()

                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    'oDataRowView = Nothing
                End Try

            Case cBtnGrabar

                MsgBox("Esto es guardar LOCAL de PLANTILLA01 Indicador # " & Me.Tag.ToString)

            Case cBtnVenta
                ' Se evalua el primero, y se cambia el estado de acuerdo a este....
                Dim lbEstado As Boolean
                'Dim oCheck As Object

                'oCheck = frmPrincipal.rpItemCheckVenta

                lbEstado = True

                Dim isChecked = frmPrincipal.btnVenta.Checked
                If isChecked Then
                    lbEstado = False
                End If
                lIndicador.EstadoUIPageButtonGroup = PCCRCC_ReemplazaEstadoBoton(cadenaEstado, isChecked, cBtnVenta)

                GridView1.Columns("P0_SVta").Visible = Not lbEstado
                GridView1.Columns("P0_PVta").Visible = Not lbEstado
                GridView1.Columns("P0_VtaFac").Visible = Not lbEstado
                GridView1.Columns("P1_VtaFac").Visible = Not lbEstado
                GridView1.Columns("P2_VtaFac").Visible = Not lbEstado

                GridView2.Columns("P0_SVta").Visible = Not lbEstado
                GridView2.Columns("P0_PVta").Visible = Not lbEstado
                GridView2.Columns("P0_VtaFac").Visible = Not lbEstado
                GridView2.Columns("P1_VtaFac").Visible = Not lbEstado
                GridView2.Columns("P2_VtaFac").Visible = Not lbEstado

            Case cBtnCompra
                Dim lbEstado As Boolean
                lbEstado = True

                Dim isChecked = frmPrincipal.btnCompra.Checked
                lIndicador.EstadoUIPageButtonGroup = PCCRCC_ReemplazaEstadoBoton(cadenaEstado, isChecked, cBtnCompra)
                If isChecked Then
                    lbEstado = False
                End If
                'If frmPrincipal.btnVenta.EditValue = vb Then
                GridView1.Columns("P0_SCmp").Visible = Not lbEstado
                GridView1.Columns("P0_PCmp").Visible = Not lbEstado
                GridView1.Columns("P0_CmpFac").Visible = Not lbEstado
                GridView1.Columns("P1_CmpFac").Visible = Not lbEstado
                GridView1.Columns("P2_CmpFac").Visible = Not lbEstado

                GridView2.Columns("P0_SCmp").Visible = Not lbEstado
                GridView2.Columns("P0_PCmp").Visible = Not lbEstado
                GridView2.Columns("P0_CmpFac").Visible = Not lbEstado
                GridView2.Columns("P1_CmpFac").Visible = Not lbEstado
                GridView2.Columns("P2_CmpFac").Visible = Not lbEstado

            Case cBtnInventario
                Dim lbEstado As Boolean
                lbEstado = True
                Dim isChecked = frmPrincipal.btnInventarios.Checked
                lIndicador.EstadoUIPageButtonGroup = PCCRCC_ReemplazaEstadoBoton(cadenaEstado, isChecked, cBtnInventario)
                If isChecked Then
                    lbEstado = False
                End If
                'If frmPrincipal.btnVenta.EditValue = vb Then
                GridView1.Columns("P0_SInv").Visible = Not lbEstado
                GridView1.Columns("P0_PInv").Visible = Not lbEstado

                GridView1.Columns("P0_InvFac").Visible = Not lbEstado
                GridView1.Columns("P1_InvFac").Visible = Not lbEstado
                GridView1.Columns("P2_InvFac").Visible = Not lbEstado

                GridView1.Columns("P0_IAntFac").Visible = Not lbEstado
                GridView1.Columns("P1_IAntFac").Visible = Not lbEstado
                GridView1.Columns("P2_IAntFac").Visible = Not lbEstado

                GridView2.Columns("P0_SInv").Visible = Not lbEstado
                GridView2.Columns("P0_PInv").Visible = Not lbEstado
                GridView2.Columns("P0_InvFac").Visible = Not lbEstado
                GridView2.Columns("P1_InvFac").Visible = Not lbEstado
                GridView2.Columns("P2_InvFac").Visible = Not lbEstado

                GridView2.Columns("P0_IAntFac").Visible = Not lbEstado
                GridView2.Columns("P1_IAntFac").Visible = Not lbEstado
                GridView2.Columns("P2_IAntFac").Visible = Not lbEstado



            Case cBtnPrecio
                Dim lbEstado As Boolean
                lbEstado = True
                Dim isChecked = frmPrincipal.btnPrecio.Checked
                lIndicador.EstadoUIPageButtonGroup = PCCRCC_ReemplazaEstadoBoton(cadenaEstado, isChecked, cBtnPrecio)
                If isChecked Then
                    lbEstado = False
                End If
                'If frmPrincipal.btnVenta.EditValue = vb Then
                GridView1.Columns("P0_SPre").Visible = Not lbEstado
                GridView1.Columns("P0_PPre").Visible = Not lbEstado
                GridView1.Columns("P0_Precio").Visible = Not lbEstado
                GridView1.Columns("P1_Precio").Visible = Not lbEstado
                GridView1.Columns("P2_Precio").Visible = Not lbEstado

                GridView2.Columns("P0_SPre").Visible = Not lbEstado
                GridView2.Columns("P0_PPre").Visible = Not lbEstado
                GridView2.Columns("P0_Precio").Visible = Not lbEstado
                GridView2.Columns("P1_Precio").Visible = Not lbEstado
                GridView2.Columns("P2_Precio").Visible = Not lbEstado

            Case cBtnRegistros
                Dim lbEstado As Boolean
                lbEstado = True
                Dim isChecked = frmPrincipal.btnRegistros.Checked
                lIndicador.EstadoUIPageButtonGroup = PCCRCC_ReemplazaEstadoBoton(cadenaEstado, isChecked, cBtnRegistros)
                If isChecked Then
                    lbEstado = False
                End If
                'If frmPrincipal.btnVenta.EditValue = vb Then
                GridView1.Columns("P0_SNre").Visible = Not lbEstado
                GridView1.Columns("P0_PNre").Visible = Not lbEstado
                GridView1.Columns("P0_Regs").Visible = Not lbEstado
                GridView1.Columns("P1_Regs").Visible = Not lbEstado
                GridView1.Columns("P2_Regs").Visible = Not lbEstado

                GridView2.Columns("P0_SNre").Visible = Not lbEstado
                GridView2.Columns("P0_PNre").Visible = Not lbEstado
                GridView2.Columns("P0_Regs").Visible = Not lbEstado
                GridView2.Columns("P1_Regs").Visible = Not lbEstado
                GridView2.Columns("P2_Regs").Visible = Not lbEstado

            Case cBtnSemaforo
                Dim lbEstado As Boolean
                lbEstado = False

                'lbEstado = GridView1.Columns("P0_VtaFac").Visible

                lbEstado = GridView1.Columns("P0_SPre").Visible

                'If frmPrincipal.btnVenta.EditValue = vb Then
                GridView1.Columns("P0_SVta").Visible = Not lbEstado
                GridView1.Columns("P0_SCmp").Visible = Not lbEstado
                GridView1.Columns("P0_SInv").Visible = Not lbEstado
                GridView1.Columns("P0_SPre").Visible = Not lbEstado
                GridView1.Columns("P0_SNre").Visible = Not lbEstado

                GridView2.Columns("P0_SVta").Visible = Not lbEstado
                GridView2.Columns("P0_SCmp").Visible = Not lbEstado
                GridView2.Columns("P0_SInv").Visible = Not lbEstado
                GridView2.Columns("P0_SPre").Visible = Not lbEstado
                GridView2.Columns("P0_SNre").Visible = Not lbEstado

            Case cBtnVariacion

                Dim lbEstado As Boolean
                lbEstado = False

                'lbEstado = GridView1.Columns("P0_VtaFac").Visible

                lbEstado = GridView1.Columns("P0_PPre").Visible

                'If frmPrincipal.btnVenta.EditValue = vb Then
                GridView1.Columns("P0_PVta").Visible = Not lbEstado
                GridView1.Columns("P0_PCmp").Visible = Not lbEstado
                GridView1.Columns("P0_PInv").Visible = Not lbEstado
                GridView1.Columns("P0_PPre").Visible = Not lbEstado
                GridView1.Columns("P0_PNre").Visible = Not lbEstado

                GridView2.Columns("P0_PVta").Visible = Not lbEstado
                GridView2.Columns("P0_PCmp").Visible = Not lbEstado
                GridView2.Columns("P0_PInv").Visible = Not lbEstado
                GridView2.Columns("P0_PPre").Visible = Not lbEstado
                GridView2.Columns("P0_PNre").Visible = Not lbEstado

            Case cBtnRegistros

                Dim lbEstado As Boolean
                lbEstado = False

                'lbEstado = GridView1.Columns("P0_VtaFac").Visible

                lbEstado = GridView1.Columns("P0_Regs").Visible

                'If frmPrincipal.btnVenta.EditValue = vb Then
                GridView1.Columns("P0_SNre").Visible = Not lbEstado
                GridView1.Columns("P0_PNre").Visible = Not lbEstado
                GridView1.Columns("P0_Regs").Visible = Not lbEstado
                GridView1.Columns("P1_Regs").Visible = Not lbEstado
                GridView1.Columns("P2_Regs").Visible = Not lbEstado

                GridView2.Columns("P0_SNre").Visible = Not lbEstado
                GridView2.Columns("P0_PNre").Visible = Not lbEstado
                GridView2.Columns("P0_Regs").Visible = Not lbEstado
                GridView2.Columns("P1_Regs").Visible = Not lbEstado
                GridView2.Columns("P2_Regs").Visible = Not lbEstado


            Case cBtnVariablesTodos

                Dim lbEstado As Boolean
                lbEstado = True

                If frmPrincipal.btnVariablesTodos.Checked Then
                    frmPrincipal.btnVenta.Checked = lbEstado
                    frmPrincipal.btnCompra.Checked = lbEstado
                    frmPrincipal.btnPrecio.Checked = lbEstado
                    frmPrincipal.btnInventarios.Checked = lbEstado
                    frmPrincipal.btnRegistros.Checked = lbEstado
                    frmPrincipal.btnVariablesNinguno.Checked = False
                    frmPrincipal.btnVariablesTodos.Checked = False
                End If


            Case cBtnVariablesNinguno

                Dim lbEstado As Boolean
                lbEstado = False

                If frmPrincipal.btnVariablesNinguno.Checked Then
                    frmPrincipal.btnVenta.Checked = lbEstado
                    frmPrincipal.btnCompra.Checked = lbEstado
                    frmPrincipal.btnPrecio.Checked = lbEstado
                    frmPrincipal.btnInventarios.Checked = lbEstado
                    frmPrincipal.btnRegistros.Checked = lbEstado
                    frmPrincipal.btnVariablesTodos.Checked = False
                    frmPrincipal.btnVariablesNinguno.Checked = False
                End If

                '----- comun
            Case cBtnFrecuencia
                Dim lbEstado As Boolean
                lbEstado = False
                If giGridActivo = 1 Then
                    lbEstado = GridView1.Columns("Frecuencias").Visible
                    GridView1.Columns("Frecuencias").Visible = Not lbEstado
                Else
                    lbEstado = GridView2.Columns("Frecuencias").Visible
                    GridView2.Columns("Frecuencias").Visible = Not lbEstado
                End If

            Case cBtnSemaforoAlertas
                If giGridActivo = 1 Then
                    GridView1.Columns("P0_SFR").FilterInfo = New ColumnFilterInfo("[P0_SFR] = 2")
                Else
                    GridView2.Columns("P0_SFR").FilterInfo = New ColumnFilterInfo("[P0_SFR] = 2")
                End If


            Case cBtnSemaforoOk
                If giGridActivo = 1 Then
                    GridView1.Columns("P0_SFR").FilterInfo = New ColumnFilterInfo("[P0_SFR] <> 2")
                Else
                    GridView2.Columns("P0_SFR").FilterInfo = New ColumnFilterInfo("[P0_SFR] <> 2")
                End If

            Case cBtnSemaforoTodos
                If giGridActivo = 1 Then
                    GridView1.Columns("P0_SFR").FilterInfo = New ColumnFilterInfo("")
                Else
                    GridView2.Columns("P0_SFR").FilterInfo = New ColumnFilterInfo("")
                End If


                '<MP_FEN: Filtros de Estados de Negocios del 0 al 7 ...
                '----------------------------------------------
            Case cbtnCorrectos, cbtnPendientes, cBtnSupervisionResumen, cbtnEnSupervision, cBtnSupervisionValidar, cbtnValidados, cbtnAtipicos, cbtnNoProcesa
                If giGridActivo = 1 Then
                    GridView1.Columns("Estado").FilterInfo = New ColumnFilterInfo("[Estado] = " & (liBoton - 60).ToString)
                Else
                    GridView2.Columns("Estado").FilterInfo = New ColumnFilterInfo("[Estado] = " & (liBoton - 60).ToString)
                End If


            Case cbtnEstadoTodos
                If giGridActivo = 1 Then
                    GridView1.Columns("Estado").FilterInfo = New ColumnFilterInfo("")
                Else
                    GridView2.Columns("Estado").FilterInfo = New ColumnFilterInfo("")
                End If

            Case cBtnVerDatosCampo
                If giGridActivo = 1 Then
                    GridView1.Columns("TipoDato").FilterInfo = New ColumnFilterInfo("[TipoDato] = 0")
                Else
                    GridView2.Columns("TipoDato").FilterInfo = New ColumnFilterInfo("[TipoDato] = 0")
                End If

            Case cBtnVerDatosSupervision
                If giGridActivo = 1 Then
                    GridView1.Columns("TipoDato").FilterInfo = New ColumnFilterInfo("[TipoDato] = 1")
                Else
                    GridView2.Columns("TipoDato").FilterInfo = New ColumnFilterInfo("[TipoDato] = 1")
                End If

            Case cBtnVerDatosAjustados
                If giGridActivo = 1 Then
                    GridView1.Columns("TipoDato").FilterInfo = New ColumnFilterInfo("[TipoDato] = 2")
                Else
                    GridView2.Columns("TipoDato").FilterInfo = New ColumnFilterInfo("[TipoDato] = 2")
                End If

            Case cBtnVerTodos
                If giGridActivo = 1 Then
                    GridView1.Columns("TipoDato").FilterInfo = New ColumnFilterInfo("")
                Else
                    GridView2.Columns("TipoDato").FilterInfo = New ColumnFilterInfo("")
                End If

                '-----

            Case cbtnCambiarEstadoAtipico, cbtnCambiarEstadoNoProcesa, cbtnActivar

                '  PCCRCC_EncuestaCambiarEstadoMulti_Local(liBoton)

            Case cBtnReplicaEncuestaPromedio, cBtnReplicaEncuestaAnterior

                ' Debe estar ubicado en la Grilla a nivel de Listado de Negocios  ...
                If giGridActivo = 2 Then
                    PCCRCC_EncuestaReplicaEncuesta(liBoton)
                Else
                    MsgBox("Debe estar ubicado en la Ventana que contiene el listado de Negocios o Encuesta", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "CCRCC: Cambiar estado al negocio")
                    gbRecargarGilla = False
                End If
                '>MP_01_CV

            Case cbtnCongelar

                PCCRCC_CongelarColumnas(If(giGridActivo = 1, GridView1, GridView2))


            Case cbtnRecargar

                ReloadGridPrincipal()
                ReloadGridSecundario()

            Case cBtnSalir
                'Case cBtnVistaPrevia

                '    If Not GridPrincipal.IsPrintingAvailable Then
                '        MessageBox.Show("No se encuentra la libreria 'DevExpress.XtraPrinting' ", "Error")
                '        Return
                '    End If

                '    GridPrincipal.ShowPrintPreview()

                'Case cBtnImprimir

                '    If Not GridPrincipal.IsPrintingAvailable Then
                '        MessageBox.Show("No se encuentra la libreria 'DevExpress.XtraPrinting'", "Error")
                '        Return
                '    End If

                '    GridPrincipal.Print()

                'Case cBtnExportaXLS

                '    Dim SaveFileDialog1 As New System.Windows.Forms.SaveFileDialog
                '    SaveFileDialog1.Filter = "All Files (*.*) |*.*|ExcelFile (*.xls)|*.xls"

                '    If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                '        GridPrincipal.ExportToXls(SaveFileDialog1.FileName & ".xls")
                '    End If


                'Case cBtnSalir
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

    Private Sub ReloadGridPrincipal()
        Me.GridPrincipal.DataSource = PCCRCC_GrillaPrincipal()
        Me.GridPrincipal.RefreshDataSource()
    End Sub
    Private Sub ReloadGridSecundario()
        Dim sId As String
        If Me.GridSecundario.Tag > 0 Then
            sId = Me.GridSecundario.Tag.ToString
            Me.GridSecundario.DataSource = PCCRCC_GrillaSecundaria(sId)
        End If

    End Sub

    Private Sub GridPrincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridPrincipal.Click
        giGridActivo = 1
    End Sub

    Private Sub GridSecundario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridSecundario.Click
        giGridActivo = 2
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
            Dim plantilla As New PlantillasBL()
            plantilla.ReplicaEncuestaSeleccionada(sID, piBoton)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub PCCRCC_EncuestaCambiarEstadoMulti_Local(ByVal piBoton As Integer)
        Dim bRetorna As Boolean = False
        Dim sID As String
        Try
            sID = FCCRCC_FilasSeleccionadas(If(giGridActivo = 1, GridView1, GridView2))
            Dim plantilla As New PlantillasBL
            plantilla.CambiarEstadoMultiplesEncuestas(sID, If(piBoton = cbtnCambiarEstadoAtipico, 6, If(piBoton = cbtnCambiarEstadoNoProcesa, 7, 5)), Me.Tag, giGridActivo)
        Catch ex As Exception
            Throw ex
        Finally
            ReloadGridPrincipal()
        End Try
    End Sub

    Private Sub GridSecundario_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridSecundario.DoubleClick
        Dim rowHandle = GridView2.FocusedRowHandle
        Dim id = GridView2.GetRowCellValue(rowHandle, "IdMedicionZonaCanalNegocio")
        If id > 0 Then
            gstrCodigoNegocio = id
            giMostrarEncuesta = 1
            frmPanelControl.LlamaPlantillas(20, 0)
        Else
            giMostrarEncuesta = 0
        End If
    End Sub

    Private Sub GridPrincipal_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridPrincipal.DoubleClick
        MODCCLocal_Todos(cBtnSincronizar)
    End Sub

    Private Sub frmPlantilla02_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        gaIndicadoresBotones(Me.Tag) = lIndicador.EstadoUIPageButtonGroup
    End Sub
End Class

<Persistent("vCCRCC_GrillaSecundariaPlantilla01")> _
Public Class GrillaSecundariaPlantilla02
    Inherits XPLiteObject
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    <Key(), DevExpress.Xpo.DisplayName("Id")> Public Id As System.Int32
    ' Public Title As String
    '<DevExpress.Xpo.DisplayName("CodigoZona")> Public CodigoZona As Integer
    <DevExpress.Xpo.DisplayName("Codigo Producto")> Public CodigoProducto As Integer

    <DevExpress.Xpo.DisplayName("Canal")> Public Canal As String
    <DevExpress.Xpo.DisplayName("Categoria")> Public Categoria As String
    <DevExpress.Xpo.DisplayName("Nombre Comercial")> Public NombreComercial As String
    <DevExpress.Xpo.DisplayName("CodigoNegocio")> Public CodigoNegocio As Integer
    <DevExpress.Xpo.DisplayName("Tipo Dato")> Public TipoDato As Byte

    'Semaforos TOTAL
    <DevExpress.Xpo.DisplayName("P0_SFR")> Public P0_SFR As Integer
    'Vta
    <DevExpress.Xpo.DisplayName("P0_SVta")> Public P0_SVta As Integer
    <DevExpress.Xpo.DisplayName("P0_PVta")> Public P0_PVta As Decimal
    <DevExpress.Xpo.DisplayName("P0_VtaFac")> Public P0_VtaFac As Decimal
    <DevExpress.Xpo.DisplayName("P1_VtaFac")> Public P1_VtaFac As Decimal
    <DevExpress.Xpo.DisplayName("P2_VtaFac")> Public P2_VtaFac As Decimal
    'Cmp
    <DevExpress.Xpo.DisplayName("P0_SCmp")> Public P0_SCmp As Integer
    <DevExpress.Xpo.DisplayName("P0_PCmp")> Public P0_PCmp As Decimal
    <DevExpress.Xpo.DisplayName("P0_CmpFac")> Public P0_CmpFac As Decimal
    <DevExpress.Xpo.DisplayName("P1_CmpFac")> Public P1_CmpFac As Decimal
    <DevExpress.Xpo.DisplayName("P2_CmpFac")> Public P2_CmpFac As Decimal

    'Inv
    <DevExpress.Xpo.DisplayName("P0_SInv")> Public P0_SInv As Integer
    <DevExpress.Xpo.DisplayName("P0_PInv")> Public P0_PInv As Decimal
    <DevExpress.Xpo.DisplayName("P0_InvFac")> Public P0_InvFac As Decimal
    <DevExpress.Xpo.DisplayName("P1_InvFac")> Public P1_InvFac As Decimal
    <DevExpress.Xpo.DisplayName("P2_InvFac")> Public P2_InvFac As Decimal

    'Pre
    <DevExpress.Xpo.DisplayName("P0_SPre")> Public P0_SPre As Integer
    <DevExpress.Xpo.DisplayName("P0_PPre")> Public P0_PPre As Decimal
    <DevExpress.Xpo.DisplayName("P0_Precio")> Public P0_Precio As Decimal
    <DevExpress.Xpo.DisplayName("P1_Precio")> Public P1_Precio As Decimal
    <DevExpress.Xpo.DisplayName("P2_Precio")> Public P2_Precio As Decimal

    'Regs
    <DevExpress.Xpo.DisplayName("P0_SNre")> Public P0_SNre As Integer
    <DevExpress.Xpo.DisplayName("P0_PNre")> Public P0_PNre As Decimal
    <DevExpress.Xpo.DisplayName("P0_Regs")> Public P0_Regs As Decimal
    <DevExpress.Xpo.DisplayName("P1_Regs")> Public P1_Regs As Decimal
    <DevExpress.Xpo.DisplayName("P2_Regs")> Public P2_Regs As Decimal

    'Porcentajes
    'Semaforos
    'Valores Periodo Actual
    <DevExpress.Xpo.DisplayName("P0_IAntFac")> Public P0_IAntFac As Decimal
    'Valores Periodo Anterior
    <DevExpress.Xpo.DisplayName("P1_IAntFac")> Public P1_IAntFac As Decimal
    'Valores Periodo Tras Anterior 
    <DevExpress.Xpo.DisplayName("P2_IAntFac")> Public P2_IAntFac As Decimal
    ', Frecuencias, CodigoFrecuencia, D.Historia, MZQN.Estado, MZQ.IdMedicionZona 
    <DevExpress.Xpo.DisplayName("Frecuencias")> Public Frecuencias As String
    <DevExpress.Xpo.DisplayName("CodigoFrecuencia")> Public CodigoFrecuencia As Integer
    <DevExpress.Xpo.DisplayName("Historia")> Public Historia As String
    <DevExpress.Xpo.DisplayName("Estado")> Public Estado As Integer
    <DevExpress.Xpo.DisplayName("IdMedicionZona")> Public IdMedicionZona As System.Int32

    <DevExpress.Xpo.DisplayName("IdMedicionZonaCanalCategoria")> Public IdMedicionZonaCanalCategoria As System.Int32 'Public CodigoMedicionZonaCanalCategoria As String
    <DevExpress.Xpo.DisplayName("IdMedicionZonaCanalNegocio")> Public IdMedicionZonaCanalNegocio As System.Int32
End Class

