Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.Xpo.Metadata
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils
Imports System.Globalization
Imports System.Linq
Imports System.Data
Imports System.Data.SqlClient
Imports CCR.AnalisisxCuidad.BL
Imports DevExpress.XtraTreeList.Nodes
Imports CCR.AnalisisxCuidad.BE
Imports CCR.AnalisisxCuidad.Support.Constants
Imports DevExpress.XtraGrid.Columns

Public Class frmPlantilla03

    Dim ciPER As CultureInfo = New CultureInfo("es-PE")
    Dim ciSOL As CultureInfo = New CultureInfo("es-PE", False)
  Friend lIndicador As Indicadores = New Indicadores
    Friend iIdFila As Integer = 0

#Region "Variables Locales"
    Dim listaIds As List(Of Integer)
    Dim lastId As Integer
    Dim encuestasQy As Integer
#End Region

    Sub New()
        frmPrincipal.siStatus.Caption = "Espere un momento por favor... cargando informacion ..."
        InitializeComponent()
        'FALTA MP: COMPLETAR lIndicador
        lIndicador = Indicador
        Me.Tag = cContratosSinReemplazo  ' era 20


    End Sub

    Private Sub frmPlantilla03_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        PCCRCC_LimpiaPersonalizacion(Me.Tag)
    End Sub

    Private Sub frmPlantilla03_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        'FCCRCC_GuardaPlantillas(Me.Tag, Me.DockManager2, Me.GridView1, Me.GridView2)

    End Sub

    Private Sub frmPlantilla03_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.Text = Indicador.TituloIndicador
        'Me.lblTituloIndicador.Text = "Indicador " & Indicador.IdIndicador.ToString & " " & Indicador.TituloIndicador & " " & gsNombreZona & "-" & giMedicion.ToString
        'Me.lblSubTituloIndicador.Text = "Errores Tipo " & giSubIndicador.ToString
        'Me.LayoutControlItemPrincipal.Text = Indicador.TituloIndicadorPrincipal
        ''Me.LayoutControlItemSecundario.Text = Indicador.TituloIndicadorSecundario

        'Me.Tag = giIndicador


    End Sub

    'HCHAVEZ
    Private Sub btnSincronizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSincronizar.Click
        Dim sID As String
        Dim oDataRowView As DataRowView
        ' Dim oDataRow As DataRow
        Dim iRowHandle As Integer
        Try
            iRowHandle = (CType(GridPrincipal.FocusedView, DevExpress.XtraGrid.Views.Base.ColumnView)).FocusedRowHandle
            oDataRowView = GridPrincipal.FocusedView.GetRow(iRowHandle)
            sID = oDataRowView("CodigoMedicionZonaCanalCategoria")

            'GridView2.Columns("CodigoMedicionZonaCanalCategoria").FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("CodigoMedicionZonaCanalCategoria='" & sID & "'")
            'GridView2.Columns("CodigoProducto").FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("CodigoProducto=90")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'oDataRowView = Nothing
        End Try
    End Sub
    'DATOS
    '    Public Function PCCRCC_GrillaPrincipalPlantilla03(ByVal iPeriodo As Integer, ByVal iCodigoZona As Integer, ByVal iIndicador As Integer, ByVal iSubIndicador As Integer) As DataTable
    Public Function PCCRCC_GrillaPrincipalPlantilla03() As DataTable

        ' Dim cn As New SqlConnection("Data Source=192.168.1.8;Initial Catalog=BDPECCRCC;User ID=sa;Password=123456789.,")

        Dim cn As New SqlConnection(Global.CCRCCV2.My.MySettings.Default.BDPECCRCCConnectionString)
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        cmd.Connection = cn
        'FALTA MP: COMPLETAR lIndicador
        'cmd.CommandText = Indicador.SpPrincipal
        cmd.CommandText = lIndicador.SpPrincipal
        'cmd.CommandText = Indicador.SpPrincipal

        'cmd.CommandText = "PCCRCC_GrillaPrincipalPlantilla03"
        'cmd.CommandText = Indicador.SpPrincipal
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 0
        cmd.Parameters.Add("@pintIdMedicionZona", SqlDbType.Int).Value = giIdMedicionZona
        ' cmd.Parameters.Add("@pintCodigozona", SqlDbType.SmallInt).Value = iCodigoZona
        cmd.Parameters.Add("@pintIdIndicador", SqlDbType.SmallInt).Value = Me.Tag
        cmd.Parameters.Add("@pintSubIndicador", SqlDbType.SmallInt).Value = giSubIndicador
        da.SelectCommand = cmd
        da.Fill(dt)

        Return dt
    End Function

    Function PCCRCC_GrillaSecundariaPlantilla03() As DataTable

        ' Dim cn As New SqlConnection("Data Source=192.168.1.8;Initial Catalog=BDPECCRCC;User ID=sa;Password=123456789.,")
        Dim cn As New SqlConnection(Global.CCRCCV2.My.MySettings.Default.BDPECCRCCConnectionString)
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        cmd.Connection = cn
        'cmd.CommandText = "PCCRCC_GrillaPrincipalPlantilla03"
        'FALTA MP: COMPLETAR lIndicador
        'cmd.CommandText = Indicador.SpPrincipal
        cmd.CommandText = lIndicador.SpSecundario
        'cmd.CommandText = Indicador.SpPrincipal

        'cmd.CommandText = Indicador.SpSecundario
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 0
        cmd.Parameters.Add("@pintIdMedicionZona", SqlDbType.Int).Value = giIdMedicionZona
        cmd.Parameters.Add("@pintIdIndicador", SqlDbType.SmallInt).Value = Me.Tag
        cmd.Parameters.Add("@pintSubIndicador", SqlDbType.SmallInt).Value = giSubIndicador
        da.SelectCommand = cmd
        da.Fill(dt)

        Return dt
    End Function

    Private Sub frmPlantilla03_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        frmPrincipal.siStatus.Caption = "Espere un momento por favor... Activando botones ..."
        frmPrincipal.ActivarCintaOpciones(Tag)
        frmPrincipal.siStatus.Caption = "Carga exitosa ..."
    End Sub

#Region "Metodos Internos"
    Friend Sub MODCCLocal_Todos(ByVal liBoton As Integer)
        Dim cadenaEstado = lIndicador.EstadoUIPageButtonGroup
        Select Case liBoton
            Case cBtnSincronizar

                Dim sID As String
                Dim oDataRowView As DataRowView
                Dim oView As GridView
                ' Dim oDataRow As DataRow
                Dim iRowHandle As Integer
                Try
                    If giGridActivo = 1 Then
                        oView = Me.GridView1
                        gstrCodigoNegocio = FCCRCC_FilasSeleccionadas(oView)
                    End If
                    iRowHandle = (CType(GridPrincipal.FocusedView, DevExpress.XtraGrid.Views.Base.ColumnView)).FocusedRowHandle
                    oDataRowView = GridPrincipal.FocusedView.GetRow(iRowHandle)
                    sID = oDataRowView("CodigoMedicionZonaCanalCategoria")
                    gstrCodigoNegocio = sID
                    ucEncuestaSku.MODCCLocal_Todos(cBtnSincronizar)
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
                'If frmPrincipal.btnVenta.EditValue = vb Then

                GridView1.Columns("P0_SVta").Visible = Not lbEstado
                GridView1.Columns("P0_PVta").Visible = Not lbEstado
                GridView1.Columns("P0_VtaFac").Visible = Not lbEstado
                GridView1.Columns("P1_VtaFac").Visible = Not lbEstado
                GridView1.Columns("P2_VtaFac").Visible = Not lbEstado
                ucEncuestaSku.clP0_VtaFac.Visible = Not lbEstado
                ucEncuestaSku.clP1_VtaFac.Visible = Not lbEstado
                ucEncuestaSku.clP2_VtaFac.Visible = Not lbEstado

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

                ucEncuestaSku.clP0_CM1PFac.Visible = Not lbEstado
                ucEncuestaSku.clP0_CM2PFac.Visible = Not lbEstado
                ucEncuestaSku.clP1_CM1PFac.Visible = Not lbEstado
                ucEncuestaSku.clP1_CM2PFac.Visible = Not lbEstado
                ucEncuestaSku.clP2_CM1PFac.Visible = Not lbEstado
                ucEncuestaSku.clP2_CM2PFac.Visible = Not lbEstado

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

                ucEncuestaSku.clP0_INVFac.Visible = Not lbEstado
                ucEncuestaSku.clP0_IAntFac.Visible = Not lbEstado
                ucEncuestaSku.clP1_INVFac.Visible = Not lbEstado
                ucEncuestaSku.clP1_IANTFac.Visible = Not lbEstado
                ucEncuestaSku.clP2_INVFac.Visible = Not lbEstado
                ucEncuestaSku.clP2_IANTFac.Visible = Not lbEstado
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

                ucEncuestaSku.clP0_PREFac.Visible = Not lbEstado
                ucEncuestaSku.clP1_PREFac.Visible = Not lbEstado
                ucEncuestaSku.clP2_PREFac.Visible = Not lbEstado

            Case cBtnRegistros
                Dim lbEstado As Boolean
                lbEstado = True

                Dim isChecked = frmPrincipal.btnRegistros.Checked
                lIndicador.EstadoUIPageButtonGroup = PCCRCC_ReemplazaEstadoBoton(cadenaEstado, isChecked, cBtnRegistros)
                If isChecked Then
                    lbEstado = False
                End If
                GridView1.Columns("P0_SNre").Visible = Not lbEstado
                GridView1.Columns("P0_PNre").Visible = Not lbEstado
                GridView1.Columns("P0_Regs").Visible = Not lbEstado
                GridView1.Columns("P1_Regs").Visible = Not lbEstado
                GridView1.Columns("P2_Regs").Visible = Not lbEstado

                ucEncuestaSku.clP0_REG.Visible = Not lbEstado
                ucEncuestaSku.clP1_REG.Visible = Not lbEstado
                ucEncuestaSku.clP2_REG.Visible = Not lbEstado

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

            Case cBtnRegistros

                Dim lbEstado As Boolean
                lbEstado = False

                lbEstado = GridView1.Columns("P0_Regs").Visible

                GridView1.Columns("P0_SNre").Visible = Not lbEstado
                GridView1.Columns("P0_PNre").Visible = Not lbEstado
                GridView1.Columns("P0_Regs").Visible = Not lbEstado
                GridView1.Columns("P1_Regs").Visible = Not lbEstado
                GridView1.Columns("P2_Regs").Visible = Not lbEstado

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

            Case cBtnFrecuencia
                Dim lbEstado As Boolean
                lbEstado = False
                lbEstado = GridView1.Columns("Frecuencias").Visible
                'If frmPrincipal.btnVenta.EditValue = vb Then
                GridView1.Columns("Frecuencias").Visible = Not lbEstado
                ucEncuestaSku.clFrecuencia.Visible = Not lbEstado
            Case cBtnSemaforoAlertas
                GridView1.Columns("P0_SFR").FilterInfo = New ColumnFilterInfo("[P0_SFR] = 2")
            Case cBtnSemaforoOk
                GridView1.Columns("P0_SFR").FilterInfo = New ColumnFilterInfo("[P0_SFR] <> 2")
            Case cBtnSemaforoTodos
                GridView1.Columns("P0_SFR").FilterInfo = New ColumnFilterInfo("")
            Case cbtnCorrectos, cbtnPendientes, cBtnSupervisionResumen, cbtnEnSupervision, cBtnSupervisionValidar, cbtnValidados, cbtnAtipicos, cbtnNoProcesa
                GridView1.Columns("Estado").FilterInfo = New ColumnFilterInfo("[Estado] = " & (liBoton - 60).ToString)
            Case cBtnVerDatosCampo
                GridView1.Columns("TipoDato").FilterInfo = New ColumnFilterInfo("[TipoDato] = 0")
            Case cBtnVerDatosSupervision
                GridView1.Columns("TipoDato").FilterInfo = New ColumnFilterInfo("[TipoDato] = 1")
            Case cBtnVerDatosAjustados
                GridView1.Columns("TipoDato").FilterInfo = New ColumnFilterInfo("[TipoDato] = 2")
            Case cBtnVerTodos
                GridView1.Columns("TipoDato").FilterInfo = New ColumnFilterInfo("")
                'Case cbtnCambiarEstadoAtipico, cbtnCambiarEstadoNoProcesa, cbtnActivar
                '    PCCRCC_EncuestaCambiarEstadoMulti_Local(liBoton)
            Case cBtnReplicaEncuestaPromedio, cBtnReplicaEncuestaAnterior
        End Select
    End Sub
#End Region
    ' ''Private Sub PCCRCC_EncuestaCambiarEstadoMulti_Local(ByVal piBoton As Integer)

    ' ''    Dim bRetorna As Boolean = False
    ' ''    Dim iRetorna As Int16 = 0 'NO ES NECESARIO...

    ' ''    Dim sID As String
    ' ''    Dim oView As GridView

    ' ''    'Dim oDataRowView As DataRowView
    ' ''    ' Dim oDataRow As DataRow
    ' ''    ' Dim iRowHandle As Integer


    ' ''    Try
    ' ''        If giGridActivo = 1 Then
    ' ''            oView = Me.GridView1
    ' ''            sID = FCCRCC_FilasSeleccionadas(oView)
    ' ''        End If
    ' ''    Catch ex As Exception
    ' ''        MsgBox(ex.Message)
    ' ''    Finally
    ' ''        oView = Nothing
    ' ''        'RecargarGrillas
    ' ''    End Try
    ' ''End Sub

    Private Sub frmPlantilla03_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        gaIndicadoresBotones(Me.Tag) = lIndicador.EstadoUIPageButtonGroup
    End Sub
End Class

<Persistent("XXXEJEMPLOXXX")> _
Public Class GrillaSecundariaPlantilla03
    Inherits XPLiteObject
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    <Key(), DevExpress.Xpo.DisplayName("Id")> Public Id As System.Int32
    Public Title As String
    <DevExpress.Xpo.DisplayName("CodigoZona")> Public CodigoZona As Integer
    <DevExpress.Xpo.DisplayName("Codigo Producto")> Public CodigoProducto As Integer

    <DevExpress.Xpo.DisplayName("Canal")> Public Canal As String
    <DevExpress.Xpo.DisplayName("Categoria")> Public Categoria As String
    <DevExpress.Xpo.DisplayName("Nombre Comercial")> Public NombreComercial As String
    <DevExpress.Xpo.DisplayName("CodigoNegocio")> Public CodigoNegocio As Integer
    <DevExpress.Xpo.DisplayName("Tipo Dato")> Public TipoDato As Integer

    'Semaforos TOTAL
    <DevExpress.Xpo.DisplayName("P0_SFR")> Public P0_SFR As Decimal
    'Vta
    <DevExpress.Xpo.DisplayName("P0_SVta")> Public P0_SVta As Decimal
    <DevExpress.Xpo.DisplayName("P0_PVta")> Public P0_PVta As Decimal
    <DevExpress.Xpo.DisplayName("P0_VtaFac")> Public P0_VtaFac As Decimal
    <DevExpress.Xpo.DisplayName("P1_VtaFac")> Public P1_VtaFac As Decimal
    <DevExpress.Xpo.DisplayName("P2_VtaFac")> Public P2_VtaFac As Decimal
    'Cmp
    <DevExpress.Xpo.DisplayName("P0_SCmp")> Public P0_SCmp As Decimal
    <DevExpress.Xpo.DisplayName("P0_PCmp")> Public P0_PCmp As Decimal
    <DevExpress.Xpo.DisplayName("P0_CmpFac")> Public P0_CmpFac As Decimal
    <DevExpress.Xpo.DisplayName("P1_CmpFac")> Public P1_CmpFac As Decimal
    <DevExpress.Xpo.DisplayName("P2_CmpFac")> Public P2_CmpFac As Decimal

    'Inv
    <DevExpress.Xpo.DisplayName("P0_SInv")> Public P0_SInv As Decimal
    <DevExpress.Xpo.DisplayName("P0_PInv")> Public P0_PInv As Decimal
    <DevExpress.Xpo.DisplayName("P0_InvFac")> Public P0_InvFac As Decimal
    <DevExpress.Xpo.DisplayName("P1_InvFac")> Public P1_InvFac As Decimal
    <DevExpress.Xpo.DisplayName("P2_InvFac")> Public P2_InvFac As Decimal

    'Pre
    <DevExpress.Xpo.DisplayName("P0_SPre")> Public P0_SPre As Decimal
    <DevExpress.Xpo.DisplayName("P0_PPre")> Public P0_PPre As Decimal
    <DevExpress.Xpo.DisplayName("P0_Precio")> Public P0_Precio As Decimal
    <DevExpress.Xpo.DisplayName("P1_Precio")> Public P1_Precio As Decimal
    <DevExpress.Xpo.DisplayName("P2_Precio")> Public P2_Precio As Decimal

    'Regs
    <DevExpress.Xpo.DisplayName("P0_SNre")> Public P0_SNre As Decimal
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

    <DevExpress.Xpo.DisplayName("CodigoMedicionZonaCanalCategoria")> Public CodigoMedicionZonaCanalCategoria As String
End Class

