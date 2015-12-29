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

Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Preview

Imports System.Drawing
Imports System.IO
Imports CCR.AnalisisxCuidad.BE
Imports CCR.AnalisisxCuidad.BL


Public Class frmPlantilla09

    Dim ciPER As CultureInfo = New CultureInfo("es-PE")
    Dim ciSOL As CultureInfo = New CultureInfo("es-PE", False)

    Friend fiCodigoSKu As Integer
    Friend fsSKu As String
    Friend fsCategoria As String
    Friend fdFactorConversion As Decimal
    Friend fiIdMedicionZonaSku As Integer
    Friend fiIdDatosHistoria As Integer

    Friend lIndicador As Indicadores = New Indicadores

    Sub New()
        frmPrincipal.siStatus.Caption = "Espere un momento por favor... cargando informacion ..."
        InitializeComponent()
        XpoDefault.ConnectionString = "XpoProvider=MSSqlServer;" & Global.CCRCCV2.My.MySettings.Default.BDPECCRCCConnectionString
        lIndicador = Indicador
        Me.Tag = giIndicador
        ' Create a Session object.
        Dim session3 As Session = New Session()
        ' Create an XPClassInfo object corresponding to the Person_Contact class.
        Dim classInfo2 As XPClassInfo
        Try
            classInfo2 = session3.GetClassInfo(GetType(GrillaSecundariaPlantilla09))
            Me.GridPrincipal.DataSource = PCCRCC_GrillaPrincipal()
            Dim xpServerCollectionSource2 As XPServerCollectionSource = New XPServerCollectionSource(session3, classInfo2)
            Me.GridSecundario.DataSource = xpServerCollectionSource2
            Me.GridView2.OptionsView.ColumnAutoWidth = False
            Me.GridView1.ActiveFilterString = "[Estado] = " & giSubIndicador.ToString
        Catch ex As Exception
            frmPrincipal.siStatus.Caption = MensajeError(ERROR_MOSTRAR_ENCUESTA, ex.Message)
        End Try
    End Sub

    Private Sub frmPlantilla09_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        PCCRCC_LimpiaPersonalizacion(Me.Tag)
    End Sub

    Private Sub frmPlantilla09_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        FCCRCC_GuardaPlantillas(Me.Tag, Me.DockManager2, Me.GridView1, Me.GridView2)
    End Sub


    Private Sub frmPlantilla09_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Text = Indicador.TituloIndicador
        'Me.DockSecundario.Text = Indicador.TituloIndicadorSecundario
        'Me.DockSecundario.Tag = Indicador.TituloIndicadorSecundario
        'Me.DockPrincipal.Text = "Indicador " & Indicador.IdIndicador.ToString & " " & Indicador.TituloIndicador & " " & gsNombreZona & "-" & giMedicion.ToString & "(" & Indicador.TituloIndicadorPrincipal & ")"
        DockSkuEdicion.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
    End Sub

    Public Function PCCRCC_GrillaPrincipal() As DataTable
        Try
            Return New PlantillasBL().ObtenerDatosPlantilla(lIndicador.SpPrincipal, giIdMedicionZona, Me.Tag, giSubIndicador)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub frmPlantilla09_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        frmPrincipal.siStatus.Caption = "Espere un momento por favor... Activando botones ..."
        frmPrincipal.ActivarCintaOpciones(Tag)
        frmPrincipal.siStatus.Caption = "Carga exitosa ..."
        Me.Cursor = Cursors.Default
    End Sub

    Friend Sub MODCCLocal_Todos(ByVal liBoton As Integer)
        Dim cadenaEstado = lIndicador.EstadoUIPageButtonGroup
        Select Case liBoton
            Case cBtnSincronizar

                Dim sID As String
                Dim oDataRowView As DataRowView
                ' Dim oDataRow As DataRow
                Dim iRowHandle As Integer
                Try
                    iRowHandle = (CType(GridPrincipal.FocusedView, DevExpress.XtraGrid.Views.Base.ColumnView)).FocusedRowHandle
                    oDataRowView = GridPrincipal.FocusedView.GetRow(iRowHandle)
                    sID = oDataRowView("Id")

                    'Se guardan los datos para uso en edicion de skus
                    fiCodigoSKu = oDataRowView("CodigoSku")
                    fsSKu = oDataRowView("Sku")
                    fsCategoria = oDataRowView("Categoria")
                    fdFactorConversion = oDataRowView("FactorConversion")
                    fiIdMedicionZonaSku = sID
                    ' Se personaliza el titulo del Dock Secundario ---
                    DockSecundario.Text = DockSecundario.Tag & " (Codigo Sku:" & oDataRowView("CodigoSku") & " - Sku: " & oDataRowView("Sku") & ")"

                    GridView2.Columns("IdMedicionZonaSku").FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("IdMedicionZonaSku= " & sID & " ")
                    'GridView2.Columns("CodigoMedicionZonaCanalCategoria").FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo("CodigoMedicionZonaCanalCategoria='" & sID & "'")
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    'oDataRowView = Nothing
                End Try

                Me.Cursor = Cursors.Default

            Case cBtnGrabar

                MsgBox("Esto es guardar LOCAL de PLANTILLA05 Indicador # " & Me.Tag.ToString)

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
                lbEstado = GridView1.Columns("P0_PPre").Visible
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
                lbEstado = GridView1.Columns("P0_Regs").Visible
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

            Case cBtnFrecuencia
                Dim lbEstado As Boolean
                lbEstado = False

                'lbEstado = GridView1.Columns("P0_VtaFac").Visible

                lbEstado = GridView1.Columns("Frecuencias").Visible

                'If frmPrincipal.btnVenta.EditValue = vb Then
                GridView1.Columns("Frecuencias").Visible = Not lbEstado


                GridView2.Columns("Frecuencias").Visible = Not lbEstado


            Case cBtnSemaforoAlertas



                GridView1.Columns("P0_SFR").FilterInfo = New ColumnFilterInfo("[P0_SFR] = 2")

                GridView2.Columns("P0_SFR").FilterInfo = New ColumnFilterInfo("[P0_SFR] = 2")

            Case cBtnSemaforoOk

                GridView1.Columns("P0_SFR").FilterInfo = New ColumnFilterInfo("[P0_SFR] <> 2")

                GridView2.Columns("P0_SFR").FilterInfo = New ColumnFilterInfo("[P0_SFR] <> 2")


            Case cBtnSemaforoTodos



                GridView1.Columns("P0_SFR").FilterInfo = New ColumnFilterInfo("")

                GridView2.Columns("P0_SFR").FilterInfo = New ColumnFilterInfo("")

                'Case cBtnVistaPrevia

                '    If Not GridPrincipal.IsPrintingAvailable Then
                '        MessageBox.Show("No se encuentra la libreria 'DevExpress.XtraPrinting' ", "Error")
                '        Return
                '    End If

                '    MsgBox("stoy en plantilla 09")

                '    Me.PrintableComponentLink1.ShowPreview()

                '    'GridPrincipal.ShowPrintPreview()

                'Case cBtnImprimir

                '    If Not GridPrincipal.IsPrintingAvailable Then
                '        MessageBox.Show("No se encuentra la libreria 'DevExpress.XtraPrinting'", "Error")
                '        Return
                '    End If

                '    GridPrincipal.Print()

            Case cBtnSalir


            Case Else

        End Select

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub GridPrincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridPrincipal.Click
        giGridActivo = 1
    End Sub

    Private Sub GridSecundario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridSecundario.Click
        giGridActivo = 2
    End Sub

    Private Sub RepositoryItemButtoncolGSActualiza_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtoncolGSActualiza.ButtonClick
        If fiIdMedicionZonaSku > 0 Then
            DockSkuEdicion.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
            lblSkuSku.Text = "Sku: " & fsSKu
            lblSkuCategoria.Text = "Categoria: " & fsCategoria
            lblSkuIdMedicionZonaSku.Text = "Codigo Sku: " & fiCodigoSKu.ToString
            lblSkuFactorConversion.Text = "Factor Conv.: " & fdFactorConversion
            lblSkuIdMedicionZonaSku.Text = fiIdMedicionZonaSku.ToString
            txtInvAnterior.Text = GridView2.GetFocusedRowCellValue("P0_IAntFac")
            txtCompra1.Text = GridView2.GetFocusedRowCellValue("P0_CmpFac")
            txtCompra2.Text = GridView2.GetFocusedRowCellValue("P0_CmpFac")
            txtPrecio.Text = GridView2.GetFocusedRowCellValue("P0_Precio")
            txtInvFinal.Text = GridView2.GetFocusedRowCellValue("P0_InvFac")
            fiIdDatosHistoria = GridView2.GetFocusedRowCellValue("Id")   'Es el IdDatosHistoria de TCCRCC_DatosHistoria
            lblSkuIdMedicionZonaSku.Text = "Id: " & fiIdDatosHistoria.ToString
            txtCompra1.Focus()
        End If
    End Sub

    Private Sub btnSkuCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSkuCerrar.Click
        SkuEdicionLimpiar()
    End Sub

    Private Sub btnSkuGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSkuGrabar.Click
        Try
            Dim aParametros(7, 2) As String

            aParametros(0, 0) = "@IdDatosHistoria"
            aParametros(0, 1) = "Int"
            aParametros(0, 2) = fiIdDatosHistoria.ToString
            aParametros(1, 0) = "@Valor_IAnt"
            aParametros(1, 1) = "Int"
            aParametros(1, 2) = txtInvAnterior.Text
            aParametros(2, 0) = "@Valor_Cm1"
            aParametros(2, 1) = "Int"
            aParametros(2, 2) = txtCompra1.Text
            aParametros(3, 0) = "@Valor_Cm2"
            aParametros(3, 1) = "Int"
            aParametros(3, 2) = txtCompra2.Text
            aParametros(4, 0) = "@Valor_Inv"
            aParametros(4, 1) = "Int"
            aParametros(4, 2) = txtInvFinal.Text
            aParametros(5, 0) = "@Valor_Pre"
            aParametros(5, 1) = "Money"
            aParametros(5, 2) = txtPrecio.Text
            aParametros(6, 0) = "@Comentarios"
            aParametros(6, 1) = "Char"
            aParametros(6, 2) = "sin ningun comentario "
            CCRCC_EjecutaProcedimiento("PCCRCC_TMP_SkuEdicion_upd", 8, aParametros)
            'rEFRESCAR LA DATA DEL GRID SECUNDRIO..
            Me.GridSecundario.RefreshDataSource()
            'FALTA ...
        Catch ex As Exception
            frmPrincipal.siStatus.Caption = MensajeError(ERROR_MOSTRAR_ENCUESTA, ex.Message)
        End Try
    End Sub
    Private Sub SkuEdicionLimpiar()
        txtInvAnterior.Text = ""
        txtCompra1.Text = ""
        txtCompra2.Text = ""
        txtPrecio.Text = ""
        txtInvFinal.Text = ""

        lblSkuFactorConversion.Text = ""
        lblSkuSku.Text = ""
        lblSkuIdMedicionZonaSku.Text = ""
        lblSkuCategoria.Text = ""
        lblTituloEdicionSku.Text = ""
    End Sub

    Public Sub CCRCC_EjecutaProcedimiento(ByVal psNombreSP As String, ByVal piNumeroParametros As Integer, ByVal paParametros As Array)
        ' Dim strConnString As String = "Data Source=192.168.1.8;Initial Catalog=BDPECCRCC;User ID=sa;Password=123456789.,"
        Dim strConnString As String = Global.CCRCCV2.My.MySettings.Default.BDPECCRCCConnectionString

        Dim con As New SqlConnection(strConnString)
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure

        cmd.CommandText = psNombreSP

        'If Not IsNothing(paParametros.Length) Then
        For i As Integer = 1 To piNumeroParametros
            Select Case paParametros(i - 1, 1)
                Case "Int"
                    cmd.Parameters.Add(paParametros(i - 1, 0), SqlDbType.BigInt).Value = paParametros(i - 1, 2)
                Case "Char"
                    cmd.Parameters.Add(paParametros(i - 1, 0), SqlDbType.Char).Value = paParametros(i - 1, 2)
                Case "TinyInt"
                    cmd.Parameters.Add(paParametros(i - 1, 0), SqlDbType.TinyInt).Value = paParametros(i - 1, 2)
                Case "Real"
                    cmd.Parameters.Add(paParametros(i - 1, 0), SqlDbType.Real).Value = paParametros(i - 1, 2)
                Case "Decimal"
                    cmd.Parameters.Add(paParametros(i - 1, 0), SqlDbType.Decimal).Value = paParametros(i - 1, 2)
                Case "Money"
                    cmd.Parameters.Add(paParametros(i - 1, 0), SqlDbType.Money).Value = paParametros(i - 1, 2)
                Case "Bit"
                    cmd.Parameters.Add(paParametros(i - 1, 0), SqlDbType.Bit).Value = paParametros(i - 1, 2)
                Case "Date"
                    cmd.Parameters.Add(paParametros(i - 1, 0), SqlDbType.Date).Value = paParametros(i - 1, 2)
                Case "DateTime"
                    cmd.Parameters.Add(paParametros(i - 1, 0), SqlDbType.DateTime).Value = paParametros(i - 1, 2)
            End Select
        Next
        'End If
        cmd.Connection = con
        Try
            con.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            con.Close()
            con.Dispose()
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

    Private Sub frmPlantilla09_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        gaIndicadoresBotones(Me.Tag) = lIndicador.EstadoUIPageButtonGroup
    End Sub
End Class


<Persistent("vCCRCC_GrillaSecundariaPlantilla05")> _
Public Class GrillaSecundariaPlantilla09
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
    ', Frecuencias, CodigoFrecuencia, D.Historia, MZQN.Estado, MZQ.IdMedicionZona 
    <DevExpress.Xpo.DisplayName("Frecuencias")> Public Frecuencias As String
    <DevExpress.Xpo.DisplayName("CodigoFrecuencia")> Public CodigoFrecuencia As Integer
    <DevExpress.Xpo.DisplayName("Historia")> Public Historia As String
    <DevExpress.Xpo.DisplayName("Estado")> Public Estado As Integer
    <DevExpress.Xpo.DisplayName("IdMedicionZona")> Public IdMedicionZona As System.Int32

    <DevExpress.Xpo.DisplayName("IdMedicionZonaSku")> Public IdMedicionZonaSku As System.Int32 'Public CodigoMedicionZonaCanalCategoria As String
End Class

