Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors


Public Class frmSkuEstadistica
    Friend siCodigoSku As Integer
    Friend siIdMedicionZona As Integer
    Friend ssCadenaIdSkus As String
    Friend siIndicadorOrigen As Integer
    Friend siIdEncuestaCategoriaSkuOrigen As Integer
    Friend ssSku As String
    Dim piCodigoSkuReemplazo As Integer
    Dim piIdSkuReemplazo As Integer
    Dim piPeso As Integer
    Dim piTipoAccion As Integer
    Dim pbCargoSkus As Boolean


    Private Sub frmSkuEstadistica_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        frmPrincipal.ActivarCintaOpciones(0)
    End Sub

    Private Sub frmSkuEstadistica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Cursor = Cursors.WaitCursor

        Me.GridPrincipal.DataSource = BDPECCR__PCCRCC_SKU_ListarDetalle()
        Me.GridPrincipal.Refresh()
        Me.GridSecundario.DataSource = PCCRCC_Sku_Estadisticas()
        Me.GridSecundario.Refresh()

        If gifrmPrincipalWidth > 0 Then
            Me.SplitContainerControl1.SplitterPosition = gifrmPrincipalWidth / 2
        End If

        ' cmbSkuCambioMasivo.SelectedIndex = 0

        cmbSkuCambioMasivo.Properties.Items.Clear()

        If siIdEncuestaCategoriaSkuOrigen > 0 Then
            lytSkuGrupoCambioMasivo.Text = "Cambio en la Encuesta el Sku (" & RTrim(LTrim(ssCadenaIdSkus)) & ")"
            cmbSkuCambioMasivo.Properties.Items.Add("Reemplazar SKU elegido")
            btnSkuContinuar.Enabled = True
            lytSkuParecidos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            lytSkuMuestra.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            btnSkuTodos.Enabled = True

        Else
            lytSkuGrupoCambioMasivo.Text = "Cambio Masivo de Skus  (" & RTrim(LTrim(ssCadenaIdSkus)) & ")"

            cmbSkuCambioMasivo.Properties.Items.Add("Reemplazar SKU elegido")
            cmbSkuCambioMasivo.Properties.Items.Add("Completar(Skus)")
            cmbSkuCambioMasivo.Properties.Items.Add("Poner No Procesar")
            cmbSkuCambioMasivo.Properties.Items.Add("Poner(Activo)")
            lytSkuParecidos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            btnSkuTodos.Text = If(Not btnSkuTodos.Checked, "Todos los Skus", "Skus Parecidos")

            SkuCambioMasivo_off()

        End If
        cmbSkuCambioMasivo.SelectedIndex = 0

        'lytSkuGrupoCambioMasivo.Text = "Cambio Masivo de Skus  (" & RTrim(LTrim(ssCadenaIdSkus)) & ")"

        pbCargoSkus = False

        'cargarListas(btnSkuTodos.Checked)

        piCodigoSkuReemplazo = 0
        piPeso = 0
        piTipoAccion = 0


        ' lookSkuReemplazo

        ' Me.cmbSkuReemplazo.DataBindings = 


        Me.Cursor = Cursors.Default

        Me.Tag = 22 'SKU

    End Sub

    Public Function BDPECCR__PCCRCC_SKU_ListarDetalle() As DataTable

        ' Dim cn As New SqlConnection("Data Source=192.168.1.8;Initial Catalog=BDPECCRCC;User ID=sa;Password=123456789.,")
        Dim cn As New SqlConnection(Global.CCRCCV2.My.MySettings.Default.BDPECCRCCConnectionString)
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        cmd.Connection = cn
        cmd.CommandText = "BDPECCR__PCCRCC_SKU_ListarDetalle"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 0
        cmd.Parameters.Add("@CSKU", SqlDbType.Int).Value = siCodigoSku
        da.SelectCommand = cmd
        da.Fill(dt)

        Return dt
    End Function

    Public Function PCCRCC_Sku_Estadisticas() As DataTable

        ' Dim cn As New SqlConnection("Data Source=192.168.1.8;Initial Catalog=BDPECCRCC;User ID=sa;Password=123456789.,")
        Dim cn As New SqlConnection(Global.CCRCCV2.My.MySettings.Default.BDPECCRCCConnectionString)
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        cmd.Connection = cn
        cmd.CommandText = "PCCRCC_SKU_Estadisticas"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 0
        cmd.Parameters.Add("@CodigoSku", SqlDbType.Int).Value = siCodigoSku
        cmd.Parameters.Add("@IdMedicionZona", SqlDbType.Int).Value = siIdMedicionZona
        da.SelectCommand = cmd
        da.Fill(dt)

        Return dt
    End Function

    Private Sub cargarListas(ByVal pbSoloParecidos As Boolean)

        Me.Cursor = Cursors.WaitCursor

        Dim oDatosTabla As DataTable = PCCRCC_Sku_Reemplazo_Sel(pbSoloParecidos)

        lookSkuReemplazo.Properties.DataSource = oDatosTabla
        lookSkuReemplazo.Properties.DisplayMember = "Sku"
        lookSkuReemplazo.Properties.ValueMember = "Id"


        Dim coll As LookUpColumnInfoCollection = lookSkuReemplazo.Properties.Columns


        lookSkuReemplazo.Properties.BestFitMode = BestFitMode.BestFit
        lookSkuReemplazo.AutoSizeInLayoutControl = True

        'Formateamos ancho de columna
        lookSkuReemplazo.Properties.ForceInitialize()
        lookSkuReemplazo.Properties.BestFit()
        Dim w As Integer = 0
        For Each ci As Controls.LookUpColumnInfo In lookSkuReemplazo.Properties.Columns
            w = w + ci.Width
        Next
        lookSkuReemplazo.Properties.PopupWidth = w + 4

        Me.Cursor = Cursors.Default

    End Sub

    Private Function PCCRCC_Sku_Reemplazo_Sel(ByVal pbSoloParecidos As Boolean) As DataTable

        ' Dim cn As New SqlConnection("Data Source=192.168.1.8;Initial Catalog=BDPECCRCC;User ID=sa;Password=123456789.,")
        Dim cn As New SqlConnection(Global.CCRCCV2.My.MySettings.Default.BDPECCRCCConnectionString)
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        cmd.Connection = cn
        cmd.CommandText = "PCCRCC_Sku_Reemplazo_Sel"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 0
        cmd.Parameters.Add("@CodigoSku", SqlDbType.Int).Value = siCodigoSku
        cmd.Parameters.Add("@IdMedicionZona", SqlDbType.Int).Value = siIdMedicionZona
        cmd.Parameters.Add("@bParecidos", SqlDbType.Bit).Value = pbSoloParecidos

        da.SelectCommand = cmd
        da.Fill(dt)

        Return dt
    End Function

    Private Sub cmbSkuCambioMasivo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSkuCambioMasivo.SelectedIndexChanged
        Dim sZonaCanal As String, sZona As String, sNacional As String

        sZonaCanal = LTrim(gsNombreZona) & " - Canal" '"Zona-Canal"
        sZona = gsNombreZona '"Zona"
        sNacional = "Peru"

        'lookSkuReemplazo.Visible = (cmbSkuCambioMasivo.SelectedIndex = 1)     'Sku Completar muestra

        SkuCambioMasivo_off()

        piTipoAccion = cmbSkuCambioMasivo.SelectedIndex

        cmbSkuANivel.Properties.Items.Clear()

        lblSkuMensajeAdvertencia.Text = ""

        Select Case piTipoAccion
            Case 0 'Reemplazar
                'cmbSkuANivel.Properties.Items.Add(sZonaCanal)

                If Not pbCargoSkus Then

                    cargarListas(Not btnSkuTodos.Checked)
                    pbCargoSkus = True

                End If
                If siIndicadorOrigen = 20 Or siIdEncuestaCategoriaSkuOrigen > 0 Then
                    cmbSkuANivel.Properties.Items.Add("Encuesta")
                Else
                    cmbSkuANivel.Properties.Items.Add(sZona)
                    cmbSkuANivel.Properties.Items.Add(sNacional)
                End If

                cmbSkuANivel.SelectedIndex = 0
                cmbSkuANivel.Enabled = True

                btnSkuContinuar.Enabled = True
                lytSkuParecidos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                lytSkuMuestra.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

                btnSkuTodos.Enabled = True

            Case 1 'Completar
                cmbSkuANivel.Properties.Items.Add(sZona)
                cmbSkuANivel.Properties.Items.Add(sZonaCanal)
                'cmbSkuANivel.Properties.Items.Add(sNacional)
                cmbSkuANivel.SelectedIndex = 0
                cmbSkuANivel.Enabled = True

                btnSkuContinuar.Enabled = True
                lytSkuParecidos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                lytSkuMuestra.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always



            Case 2, 3  'Atipo o No Procesar
                'cmbSkuANivel.Properties.Items.Add(sZonaCanal)
                cmbSkuANivel.Properties.Items.Add(sZona)
                cmbSkuANivel.Properties.Items.Add(sNacional)
                cmbSkuANivel.SelectedIndex = 0
                cmbSkuANivel.Enabled = True

                btnSkuContinuar.Enabled = True
                lytSkuParecidos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                lytSkuMuestra.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never


        End Select

        lblSkuMensajeAdvertencia_pinta(True)

    End Sub

    Private Sub SkuCambioMasivo_off()

        btnSkuContinuar.Enabled = False
        btnSkuTodos.Enabled = False
        cmbSkuANivel.Enabled = False
        lytSkuParecidos.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        lytSkuMuestra.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    End Sub

    Private Sub txtSkuPesoMuestra_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSkuPesoMuestra.EditValueChanged
        Dim bHabilita As Boolean = False

        If txtSkuPesoMuestra.Text > "" Then
            bHabilita = (txtSkuPesoMuestra.Text > 0)
            piPeso = CInt(txtSkuPesoMuestra.Text)
        End If

        'chkSkuNacional.Enabled = bHabilita
        btnSkuContinuar.Enabled = bHabilita

        lblSkuMensajeAdvertencia_pinta(True)

    End Sub

    Private Sub btnSkuContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSkuContinuar.Click
        Dim iNivel As Integer

        If MsgBox("Esta accion puede demorar " & vbCrLf & "Esta seguro(a) de continuar (Impacto a nivel: " & cmbSkuANivel.Text & ")", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Cambio Masivo de Skus") = MsgBoxResult.Yes Then

            'Procede con el Cambio 

            Me.Cursor = Cursors.WaitCursor

            piCodigoSkuReemplazo = piCodigoSkuReemplazo
            piPeso = piPeso
            piTipoAccion = piTipoAccion

            '   0:          Zona()
            '   1:          Nacional()
            '   2:      	Zona/Canal

            iNivel = cmbSkuANivel.SelectedIndex
            If piTipoAccion = 1 Then        'Completar
                iNivel = If(cmbSkuANivel.SelectedIndex = 1, 2, 0)
            End If

            PCCRCC_Sku_Reemplazo_Upd(siIdMedicionZona, ssCadenaIdSkus, piTipoAccion, piCodigoSkuReemplazo, piPeso, iNivel)

            'PCCRCC_Sku_Reemplazo_Upd(siIdMedicionZona, ssCadenaIdSkus, piTipoAccion, piCodigoSkuReemplazo, piPeso, iNivel)


            lblSkuMensajeAdvertencia.Text = "Accion realizada correctamente..."
            lblSkuMensajeAdvertencia.BackColor = Color.LightGreen

            gbRecargarGilla = True

            btnSkuContinuar.Enabled = False
            Me.Cursor = Cursors.Default

        End If
    End Sub

    Private Function PCCRCC_Sku_Reemplazo_Upd(ByVal lIdMedicionZona As Integer, ByVal ssCadenaIdSkus As String, ByVal piTipoAccion As Integer, ByVal piCodigoSkuReemplazo As Integer, ByVal piPeso As Integer, ByVal iNivel As Integer) As Boolean
        Dim cn As New SqlConnection(Global.CCRCCV2.My.MySettings.Default.BDPECCRCCConnectionString)
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim bRetorna As Boolean = False
        Dim sIndicadoresTipoEncuesta As String = ",4,5,6,7,16,19,20,"


        cmd.Connection = cn
        cmd.CommandText = "PCCRCC_Sku_Reemplazo_Upd"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 0
        cmd.Parameters.Add("@sCadenaIdSkus", SqlDbType.VarChar).Value = If(sIndicadoresTipoEncuesta.Contains("," & LTrim(siIndicadorOrigen.ToString) & ","), siCodigoSku.ToString, ssCadenaIdSkus)
        cmd.Parameters.Add("@IdMedicionZona", SqlDbType.Int).Value = siIdMedicionZona
        cmd.Parameters.Add("@TipoAccion", SqlDbType.Int).Value = piTipoAccion
        cmd.Parameters.Add("@CodigoSkuReemplazo", SqlDbType.Int).Value = piCodigoSkuReemplazo
        cmd.Parameters.Add("@Peso", SqlDbType.Int).Value = piPeso
        cmd.Parameters.Add("@Nivel", SqlDbType.Int).Value = iNivel
        cmd.Parameters.Add("@IndicadorOrigen", SqlDbType.Int).Value = siIndicadorOrigen
        cmd.Parameters.Add("@IdMedicionZonaCanalNegocio", SqlDbType.BigInt).Value = siIdEncuestaCategoriaSkuOrigen

        'siIdEncuestaCategoriaSkuOrigen
        Try
            da.SelectCommand = cmd
            da.Fill(dt)
            bRetorna = True
        Catch ex As Exception
            'Throw ex
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Skus")
        End Try
        Return bRetorna
    End Function

    Private Sub lblSkuMensajeAdvertencia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If lblSkuMensajeAdvertencia.Text > "" Then

            lblSkuMensajeAdvertencia.BackColor = Color.LightYellow

        End If
    End Sub

    Private Sub lookSkuReemplazo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookSkuReemplazo.EditValueChanged
        Dim bHabilita As Boolean = False, sSku As String

        bHabilita = True

        cmbSkuANivel.Enabled = bHabilita
        btnSkuContinuar.Enabled = bHabilita

        piCodigoSkuReemplazo = lookSkuReemplazo.Properties.GetDataSourceValue("CodigoSku", lookSkuReemplazo.ItemIndex)
        piIdSkuReemplazo = lookSkuReemplazo.Properties.GetDataSourceValue("Id", lookSkuReemplazo.ItemIndex)
        sSku = lookSkuReemplazo.Properties.GetDataSourceValue("Sku", lookSkuReemplazo.ItemIndex)

        lblSkuMensajeAdvertencia_pinta(True)

    End Sub

    Private Sub btnSkuTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSkuTodos.CheckedChanged
        'SkuCambioMasivo_off()
        ' btnSkuTodos.Enabled = True

        cargarListas(Not btnSkuTodos.Checked)

        btnSkuTodos.Text = If(btnSkuTodos.Checked, "Todos los Skus", "Skus Parecidos")

    End Sub

    Private Sub lblSkuMensajeAdvertencia_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSkuMensajeAdvertencia.EditValueChanged
        If lblSkuMensajeAdvertencia.Text > "" Then
            lblSkuMensajeAdvertencia.BackColor = Color.LightYellow
        Else
            lblSkuMensajeAdvertencia.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub cmbSkuANivel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSkuANivel.SelectedIndexChanged

        lblSkuMensajeAdvertencia_pinta(True)

    End Sub

    Private Sub lblSkuMensajeAdvertencia_pinta(ByVal bPinta As String)
        Dim sSku As String, sMensaje As String = ""

        If bPinta Then
            Select Case cmbSkuCambioMasivo.SelectedIndex
                Case 0
                    sSku = lookSkuReemplazo.Properties.GetDataSourceValue("Sku", lookSkuReemplazo.ItemIndex)
                    sMensaje = If(IsNothing(sSku), "", " el reemplazo del (los) Skus, por: " & piCodigoSkuReemplazo.ToString & " - " & sSku)
                Case 1
                    sMensaje = " El incremento de registros para lograr el Peso Indicado (Solo si estuviera por debajo) "
                Case 2
                    sMensaje = " la Suspension de los Skus Calificandolos como: NO PROCESA "
                Case 3
                    sMensaje = " la Suspension de los Skus Calificandolos como: ATIPICO"

            End Select
            lblSkuMensajeAdvertencia.Text = "ADVERTENCIA! Esta accion realizará a nivel " & cmbSkuANivel.Text & vbCrLf & sMensaje
        Else
            lblSkuMensajeAdvertencia.Text = ""
        End If


    End Sub

End Class