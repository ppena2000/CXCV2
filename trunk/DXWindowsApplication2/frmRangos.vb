Imports DevExpress.XtraEditors
Imports System.Data.SqlClient
Imports CCR.AnalisisxCuidad.Support
Imports CCR.AnalisisxCuidad.BE

'Imports Microsoft.VisualBasic.PowerPacks

Public Class frmRangos

    '  Private m_sConnectionString As String = "Data Source=192.168.1.8;Initial Catalog=BDPECCRCC;User ID=sa;Password=123456789.,"

    Private m_sConnectionString As String = Global.CCRCCV2.My.MySettings.Default.BDPECCRCCConnectionString


    Friend lIndicador As Indicadores = New Indicadores

    Dim bmodificarRegistro As Boolean = True
    Dim bExisteCambios As Boolean = False

#Region "Variables Globales"

    Public idMedicionZona As New Integer

#End Region

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'FALTA MP: COMPLETAR lIndicador
        lIndicador = Indicador
        Me.Tag = cGestionDeRangos

    End Sub

    Private Sub frmRangos_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

        ' alerta que la zona de estagrilla es diferente a la zona elegida en el control de avance...
        If idMedicionZona <> giIdMedicionZona Then
            lblTituloRangos.AppearanceItemCaption.BackColor = Color.Red
        Else
            lblTituloRangos.AppearanceItemCaption.BackColor = Color.FromArgb(0, 0, 0, 0)
        End If

        frmPrincipal.ActivarCintaOpciones(cBtnGestionRangos, lIndicador.EstadoUIPageButtonGroup)

        giInidicadorActivo = Me.Tag
        gaIndicadoresAbiertos(Me.Tag) = "1"



    End Sub

    Private Sub frmRangos_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        PCCRCC_LimpiaPersonalizacion(Me.Tag)
    End Sub

    'Private Sub frmRangos_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    '    ' PCCRCC_LimpiaPersonalizacion(Me.Tag)


    'End Sub

    Private Sub frmRangos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        PCCRCC_LimpiaPersonalizacion(Me.Tag)


    End Sub

    'Public Sub New(ByVal iIdMedicionZona As Long)

    '    ' Llamada necesaria para el Diseñador de Windows Forms.
    '    InitializeComponent()

    '    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    '    Me.m_iIdMedicionZona = iIdMedicionZona

    'End Sub

    Private Sub frmRangos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Formato

        'respaldo el codigo idZona en el arreglo
        gaIndicadoresParametros(cGestionDeRangos) = giIdMedicionZona

        formatearLista()
        cargarListas()
        'Visualizar Columnas x Defecto

        dgRangos.DataSource = PCCRCC_Rangos_Sel(giIdMedicionZona)

        'GridSplitContainer1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
        'GridSplitContainer1.SplitterPosition = GridSplitContainer1.Width / 3

        lblTituloRangos.Text = "Gestion de Rangos de " & gsNombreZona & " - " & giMedicion.ToString

        Dim numClient As NumericRangeControlClient = New NumericRangeControlClient()

        numClient.Maximum = 50.0R
        numClient.Minimum = -50.0R
        numClient.RulerDelta = 10.0R
        rcRangos.Client = numClient

        rcRangos.SelectedRange.Maximum = 20
        rcRangos.SelectedRange.Minimum = -20

        idMedicionZona = giIdMedicionZona

    End Sub

    Private Sub formatearLista()
        BandedGridView1.Columns("IdRangos").Visible = False
        BandedGridView1.Columns("IdMedicionZonaCanal").Visible = False
        BandedGridView1.Columns("IdIndicador").Visible = False
        ocultarColumnas()
    End Sub

    'control del Grupo Variables de la barra de herramientas
    Private Sub ocultarmostrarColumnas(ByVal iMedida As Byte, ByVal bEstado As Boolean)
        Dim sColumna As String = ""
        'Dim i As Byte
        '******
        '1-CMP
        '2-INV
        '3-VTA
        '4-PRE
        '5-REG
        '6-
        '******
        Select Case iMedida
            Case 1 : BandedGridView1.Bands("bdVentas").Visible = bEstado
            Case 2 : BandedGridView1.Bands("bdInventarios").Visible = bEstado
            Case 3 : BandedGridView1.Bands("bdPrecios").Visible = bEstado
            Case 4 : sColumna = ""
            Case 5 : BandedGridView1.Bands("bdCompras").Visible = bEstado
            Case Else : BandedGridView1.Bands("bdRegistros").Visible = bEstado
        End Select

    End Sub

    Private Sub ocultarColumnas()

        BandedGridView1.Bands("bdVentas").Visible = False
        BandedGridView1.Bands("bdCompras").Visible = False
        BandedGridView1.Bands("bdInventarios").Visible = False
        BandedGridView1.Bands("bdPrecios").Visible = False
        BandedGridView1.Bands("bdRegistros").Visible = False

    End Sub

    Public Function PCCRCC_Rangos_Sel(ByVal IdMedicionZona As Long) As DataTable
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim iRetorno As Integer
        Dim sqlCn As SqlConnection = New SqlConnection(m_sConnectionString)

        cmd.Connection = sqlCn
        cmd.CommandText = "PCCRCC_Rangos_Sel"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 0
        cmd.Parameters.Add("@IdMedicionZona", SqlDbType.VarChar).Value = IdMedicionZona
        cmd.Parameters.Add("@RETORNA", SqlDbType.SmallInt)
        cmd.Parameters("@RETORNA").Direction = ParameterDirection.Output

        da.SelectCommand = cmd
        da.Fill(dt)

        iRetorno = cmd.Parameters("@RETORNA").Value


        Return dt

        sqlCn.Close()
        sqlCn.Dispose()

    End Function

    Public Function PCCRCC_Rangos_Upd()
        Dim cmd As SqlCommand
        Dim sqlCn As SqlConnection = New SqlConnection(m_sConnectionString)
        Dim bRetorna As Boolean = True

        sqlCn.Open()

        For Each oRow As DataRow In CType(dgRangos.DataSource, DataTable).Select("RU")
            cmd = New SqlCommand
            cmd.Connection = sqlCn
            cmd.CommandText = "PCCRCC_Rangos_Upd"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandTimeout = 0

            cmd.Parameters.Add("@IdRangos", SqlDbType.BigInt).Value = oRow("IdRangos")
            cmd.Parameters.Add("@CMP_PMinimo", SqlDbType.Float).Value = oRow("CMP_PMinimo")
            cmd.Parameters.Add("@CMP_PMaximo", SqlDbType.Float).Value = oRow("CMP_PMaximo")
            cmd.Parameters.Add("@CMP_FVariacion", SqlDbType.Float).Value = oRow("CMP_FVariacion")
            cmd.Parameters.Add("@CMP_Referencia", SqlDbType.SmallInt).Value = oRow("CMP_Referencia")
            cmd.Parameters.Add("@CMP_Semaforo", SqlDbType.TinyInt).Value = oRow("CMP_Semaforo")
            cmd.Parameters.Add("@INV_PMinimo", SqlDbType.Float).Value = oRow("INV_PMinimo")
            cmd.Parameters.Add("@INV_PMaximo", SqlDbType.Float).Value = oRow("INV_PMaximo")
            cmd.Parameters.Add("@INV_FVariacion", SqlDbType.Float).Value = oRow("INV_FVariacion")
            cmd.Parameters.Add("@INV_Referencia", SqlDbType.SmallInt).Value = oRow("INV_Referencia")
            cmd.Parameters.Add("@INV_Semaforo", SqlDbType.TinyInt).Value = oRow("INV_Semaforo")
            cmd.Parameters.Add("@VTA_PMinimo", SqlDbType.Float).Value = oRow("VTA_PMinimo")
            cmd.Parameters.Add("@VTA_PMaximo", SqlDbType.Float).Value = oRow("VTA_PMaximo")
            cmd.Parameters.Add("@VTA_FVariacion", SqlDbType.Float).Value = oRow("VTA_FVariacion")
            cmd.Parameters.Add("@VTA_Referencia", SqlDbType.SmallInt).Value = oRow("VTA_Referencia")
            cmd.Parameters.Add("@VTA_Semaforo", SqlDbType.TinyInt).Value = oRow("VTA_Semaforo")
            cmd.Parameters.Add("@PRE_PMinimo", SqlDbType.Float).Value = oRow("PRE_PMinimo")
            cmd.Parameters.Add("@PRE_PMaximo", SqlDbType.Float).Value = oRow("PRE_PMaximo")
            cmd.Parameters.Add("@PRE_FVariacion", SqlDbType.Float).Value = oRow("PRE_FVariacion")
            cmd.Parameters.Add("@PRE_Referencia", SqlDbType.SmallInt).Value = oRow("PRE_Referencia")
            cmd.Parameters.Add("@PRE_Semaforo", SqlDbType.TinyInt).Value = oRow("PRE_Semaforo")
            cmd.Parameters.Add("@REG_PMinimo", SqlDbType.Float).Value = oRow("REG_PMinimo")
            cmd.Parameters.Add("@REG_PMaximo", SqlDbType.Float).Value = oRow("REG_PMaximo")
            cmd.Parameters.Add("@REG_FVariacion", SqlDbType.Float).Value = oRow("REG_FVariacion")
            cmd.Parameters.Add("@REG_Referencia", SqlDbType.SmallInt).Value = oRow("REG_Referencia")
            cmd.Parameters.Add("@REG_Semaforo", SqlDbType.TinyInt).Value = oRow("REG_Semaforo")
            cmd.Parameters.Add("@Semaforo", SqlDbType.Bit).Value = oRow("Semaforo")

            cmd.Parameters.Add("@RETORNA", SqlDbType.SmallInt)
            cmd.Parameters("@RETORNA").Direction = ParameterDirection.Output

            cmd.ExecuteNonQuery()

            If cmd.Parameters("@RETORNA").Value = 1 Then
                bRetorna = False

                'MsgBox("Error")
                Return bRetorna
                Exit Function

            End If

        Next

        sqlCn.Close()
        sqlCn.Dispose()

        Return bRetorna

    End Function

    'Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    ocultarmostrarColumnas(1, CType(SimpleButton1.Tag, Boolean))
    '    SimpleButton1.Tag = IIf(CType(SimpleButton1.Tag, Boolean), "False", "True")
    'End Sub

    'Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    ocultarmostrarColumnas(2, CType(SimpleButton1.Tag, Boolean))
    '    SimpleButton1.Tag = IIf(CType(SimpleButton1.Tag, Boolean), "False", "True")

    'End Sub

    'Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    ocultarmostrarColumnas(5, CType(SimpleButton1.Tag, Boolean))
    '    SimpleButton1.Tag = IIf(CType(SimpleButton1.Tag, Boolean), "False", "True")

    'End Sub

    'Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    ocultarmostrarColumnas(3, CType(SimpleButton1.Tag, Boolean))
    '    SimpleButton1.Tag = IIf(CType(SimpleButton1.Tag, Boolean), "False", "True")

    'End Sub

    'Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    ocultarmostrarColumnas(7, CType(SimpleButton1.Tag, Boolean))
    '    SimpleButton1.Tag = IIf(CType(SimpleButton1.Tag, Boolean), "False", "True")

    'End Sub

    Private Sub BandedGridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles BandedGridView1.CellValueChanged
        Try
            If Not bmodificarRegistro Then Exit Sub

            bmodificarRegistro = False
            With BandedGridView1.Bands("bdFinal").View
                .SetRowCellValue(.FocusedRowHandle, "RU", 1)
            End With
            bmodificarRegistro = True
            bExisteCambios = True
            frmPrincipal.btnGrabar.Enabled = True
            frmPrincipal.btnVaciar.Enabled = True
        Catch ex As Exception
            bmodificarRegistro = True
        End Try

    End Sub

    'Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
    '    PCCRCC_Rangos_Upd()
    'End Sub




    Private Sub rcRangos_RangeChanged(ByVal sender As Object, ByVal range As DevExpress.XtraEditors.RangeControlRangeEventArgs) Handles rcRangos.RangeChanged
        Dim Min As Integer
        Dim Max As Integer

        'If IsNothing(rcRangos.SelectedRange.Maximum) Then

        'End If
        'If IsNothing(rcRangos.SelectedRange.Minimum) Then

        'End If

        Min = If(IsNothing(rcRangos.SelectedRange.Minimum), 0, CInt(Fix(rcRangos.SelectedRange.Minimum)))
        Max = If(IsNothing(rcRangos.SelectedRange.Maximum), 0, CInt(Fix(rcRangos.SelectedRange.Maximum)))


        lblMinimo.Text = "Minimo " + CStr(Min)
        lblMaximo.Text = "Maximo " + CStr(Max)

    End Sub

    Private Sub sbLimpia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbLimpia.Click

        GRCambioMasivoDefault()

    End Sub
    Private Sub GRCambioMasivoDefault()

        txtFactorVariacion.Text = 1

        rcRangos.SelectedRange.Minimum = 0
        rcRangos.SelectedRange.Maximum = 20

        cboReferencia.Text = "No Aplica"

        chkGRVariable.Items(0).CheckState = CheckState.Checked
        chkGRVariable.Items(1).CheckState = CheckState.Unchecked
        chkGRVariable.Items(2).CheckState = CheckState.Unchecked
        chkGRVariable.Items(3).CheckState = CheckState.Unchecked
        chkGRVariable.Items(4).CheckState = CheckState.Unchecked
        chkGRVariable.Items(5).CheckState = CheckState.Unchecked

    End Sub
    Private Sub GRCambioMasivoGrabar()
        'Dim SNombreBanda As String
        Dim sVariable As String
        Dim bOk As Boolean
        bOk = False

        If txtFactorVariacion.Text > 0 And txtFactorVariacion.Text < 10 Then
            bOk = True
        End If

        If CInt(Fix(rcRangos.SelectedRange.Minimum)) > -90 And CInt(Fix(rcRangos.SelectedRange.Maximum)) < 100 Then
            bOk = True
        End If

        If InStr(UCase(cboReferencia.Text), "NO APLICA-VENTAS-COMPRAS-INVENTARIOS-REGISTROS") > 0 Then
            bOk = True
        End If

        bOk = (chkGRVariable.Items(0).CheckState + chkGRVariable.Items(1).CheckState + chkGRVariable.Items(2).CheckState + chkGRVariable.Items(3).CheckState + chkGRVariable.Items(4).CheckState + chkGRVariable.Items(5).CheckState)

        If bOk Then
            'Llama al procedimiento PCCRCC_GRCambioMasivo_upd CInt(Fix(rcRangos.SelectedRange.Minimum)), CInt(Fix(rcRangos.SelectedRange.Maximum)), cboReferencia.Text, chkGRVariable.Items(0).CheckState, chkGRVariable.Items(1).CheckState, chkGRVariable.Items(2).CheckState, chkGRVariable.Items(3).CheckState 

            With Me.BandedGridView1
                ' .SelectAll()
                Dim Rows() As Integer = .GetSelectedRows()
                .BeginUpdate()
                'Registros con filtro
                For i As Integer = 0 To Rows.Length - 1
                    'Las Bandas
                    For Each item As DevExpress.XtraEditors.Controls.CheckedListBoxItem In chkGRVariable.CheckedItems
                        Select Case item.Value
                            Case 1 : sVariable = "VTA"
                            Case 2 : sVariable = "INV"
                            Case 3 : sVariable = "PRE"
                            Case 5 : sVariable = "CMP"
                            Case Else : sVariable = "REG"
                        End Select
                        .SetRowCellValue(Rows(i), sVariable & "_PMinimo", Math.Round(rcRangos.SelectedRange.Minimum / 100.0, 2))
                        .SetRowCellValue(Rows(i), sVariable & "_PMaximo", Math.Round(rcRangos.SelectedRange.Maximum / 100.0, 2))
                        .SetRowCellValue(Rows(i), sVariable & "_FVariacion", txtFactorVariacion.Text)
                        .SetRowCellValue(Rows(i), sVariable & "_Referencia", cboReferencia.EditValue.Codigo)
                        .SetRowCellValue(Rows(i), sVariable & "_Semaforo", chkSemaforo.CheckState)
                        'SNombreBanda = "bd" & item.Description & IIf(Mid(item.Description, item.Description.Length, 1) = "S", "", "S")
                        '' CType(item, ComboBoxBE).Nombre & IIf(Mid(CType(item, ComboBoxBE).Nombre, item.Nombre.Length, 1) = "s", "", "s")
                        'With .Bands(SNombreBanda)
                        '    .View.SetRowCellValue(i, .ToolTip & "_PMinimo", rcRangos.SelectedRange.Minimum)
                        '    .View.SetRowCellValue(i, .ToolTip & "_PMaximo", rcRangos.SelectedRange.Maximum)
                        '    .View.SetRowCellValue(i, .ToolTip & "_FVariacion", txtFactorVariacion.Text)
                        '    .View.SetRowCellValue(i, .ToolTip & "_Referencia", CType(cboReferencia.EditValue, ComboBoxBE).Codigo)
                        '    .View.SetRowCellValue(i, .ToolTip & "_Semaforo", chkSemaforo.CheckState)
                        'End With
                    Next
                    .SetRowCellValue(Rows(i), "RU", 1)
                Next
                .EndUpdate()
            End With

            bExisteCambios = True

            frmPrincipal.btnGrabar.Enabled = bExisteCambios
            
        Else
            'Enviar mensaje de error ....


        End If


    End Sub

    Private Sub sbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbCancelar.Click
        If bExisteCambios Then
            If MsgBox("Esta seguro(a) que desea salir sin grabar los cambios?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CCRCC Gestion de Rangos") = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If




    End Sub

    Private Sub sbAplica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAplica.Click

        GRCambioMasivoGrabar()

    End Sub


    Private Sub cargarListas()
        Dim oDatosTabla As DataTable = PCCRCC_ConsultaVariables()




        chkGRVariable.Items.Clear()
        cboReferencia.Properties.Items.Clear()

        For Each oRow As DataRow In oDatosTabla.Rows
            chkGRVariable.Items.Add(oRow(0))
            chkGRVariable.Items(chkGRVariable.Items.Count - 1).Description = oRow(1)
        Next

        ' cboReferencia.Properties.Items.Add(New ComboBoxBE With {.Codigo = 0, .Nombre = "No Aplica"})
        For Each oRow As DataRow In oDatosTabla.Rows
            cboReferencia.Properties.Items.Add(New ComboBoxBE With {.Codigo = oRow(0), .Nombre = oRow(1)})

            RepositoryItemComboBox1.Items.Add(New ComboBoxBE With {.Nombre = oRow(1)})

        Next
        If cboReferencia.Properties.Items.Count > 0 Then
            cboReferencia.SelectedIndex = 0
        End If




    End Sub




    Public Function PCCRCC_ConsultaVariables() As DataTable
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim sqlCn As SqlConnection = New SqlConnection(m_sConnectionString)

        cmd.Connection = sqlCn
        cmd.CommandText = "PCCRCC_ConsultaVariables"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 0

        da.SelectCommand = cmd
        da.Fill(dt)

        Return dt

        sqlCn.Close()
        sqlCn.Dispose()

    End Function




    Friend Sub MODCCLocal_Todos(ByVal liBoton As Integer)
        Dim cadenaEstado = lIndicador.EstadoUIPageButtonGroup

        Select Case liBoton
            Case cBtnSincronizar

            Case cBtnGrabar

                If Not PCCRCC_Rangos_Upd() Then
                    MsgBox("ERROR:  No se pudo actualizar correctamente los cambios", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Gestion de Rangos: Actualizacion de Cambios")
                Else
                    'Se recarga la informacion desde la base de dats...
                    bExisteCambios = False
                    dgRangos.DataSource = PCCRCC_Rangos_Sel(giIdMedicionZona)
                    'bmodificarRegistro = False
                    dgRangos.RefreshDataSource()
                    dgRangos.Refresh()

                End If

            Case cBtnVenta

                'BandedGridView1.Bands("bdVentas").Visible = False
                'BandedGridView1.Bands("bdCompras").Visible = False
                'BandedGridView1.Bands("bdInventarios").Visible = False
                'BandedGridView1.Bands("bdPrecios").Visible = False
                'BandedGridView1.Bands("bdRegistros").Visible = False

                Dim isChecked = frmPrincipal.btnVenta.Checked
                lIndicador.EstadoUIPageButtonGroup = PCCRCC_ReemplazaEstadoBoton(cadenaEstado, isChecked, cBtnVenta)
                BandedGridView1.Bands("bdVentas").Visible = frmPrincipal.btnVenta.Checked


            Case cBtnCompra
                Dim isChecked = frmPrincipal.btnCompra.Checked
                lIndicador.EstadoUIPageButtonGroup = PCCRCC_ReemplazaEstadoBoton(cadenaEstado, isChecked, cBtnCompra)
                BandedGridView1.Bands("bdCompras").Visible = frmPrincipal.btnCompra.Checked

            Case cBtnInventario
                Dim isChecked = frmPrincipal.btnInventarios.Checked
                lIndicador.EstadoUIPageButtonGroup = PCCRCC_ReemplazaEstadoBoton(cadenaEstado, isChecked, cBtnInventario)
                BandedGridView1.Bands("bdInventarios").Visible = frmPrincipal.btnInventarios.Checked

            Case cBtnPrecio
                Dim isChecked = frmPrincipal.btnPrecio.Checked
                lIndicador.EstadoUIPageButtonGroup = PCCRCC_ReemplazaEstadoBoton(cadenaEstado, isChecked, cBtnPrecio)
                BandedGridView1.Bands("bdPrecios").Visible = frmPrincipal.btnPrecio.Checked

            Case cBtnRegistros
                Dim isChecked = frmPrincipal.btnRegistros.Checked
                lIndicador.EstadoUIPageButtonGroup = PCCRCC_ReemplazaEstadoBoton(cadenaEstado, isChecked, cBtnRegistros)
                BandedGridView1.Bands("bdRegistros").Visible = frmPrincipal.btnRegistros.Checked

            Case cBtnSemaforo

            Case cBtnVariacion

            Case cBtnVariablesTodos

                Dim lbEstado As Boolean

                lbEstado = True
                frmPrincipal.btnVenta.Checked = lbEstado
                frmPrincipal.btnCompra.Checked = lbEstado
                frmPrincipal.btnPrecio.Checked = lbEstado
                frmPrincipal.btnInventarios.Checked = lbEstado
                frmPrincipal.btnRegistros.Checked = lbEstado


            Case cBtnVariablesNinguno
                Dim lbEstado As Boolean

                lbEstado = False
                frmPrincipal.btnVenta.Checked = lbEstado
                frmPrincipal.btnCompra.Checked = lbEstado
                frmPrincipal.btnPrecio.Checked = lbEstado
                frmPrincipal.btnInventarios.Checked = lbEstado
                frmPrincipal.btnRegistros.Checked = lbEstado

            Case cBtnFrecuencia

            Case cBtnSemaforoAlertas

            Case cBtnSemaforoOk

            Case cBtnSemaforoTodos

            Case cBtnSalir


            Case Else

        End Select


    End Sub




    Private Sub chkGRVariable_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGRVariable.SelectedIndexChanged

    End Sub

    Private Sub frmRangos_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        gaIndicadoresBotones(Me.Tag) = lIndicador.EstadoUIPageButtonGroup
    End Sub

    Private Sub dgRangos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgRangos.Click

    End Sub

    Private Sub cboReferencia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboReferencia.SelectedIndexChanged

    End Sub
End Class

Public Class ComboBoxBE
    Private m_iCodigo As Long
    Private m_sNombre As String
    Private m_oObjeto As Object

    Public Property Codigo() As Long
        Get
            Return m_iCodigo
        End Get
        Set(ByVal Value As Long)
            m_iCodigo = Value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return m_sNombre
        End Get
        Set(ByVal Value As String)
            m_sNombre = Value
        End Set
    End Property

    Public Property Objecto() As Object
        Get
            Return m_oObjeto
        End Get
        Set(ByVal Value As Object)
            m_oObjeto = Value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Me.Nombre
    End Function

End Class
