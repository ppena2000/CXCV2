<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucEncuestaNegocios
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim StyleFormatCondition1 As DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition = New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition = New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition
        Dim StyleFormatCondition3 As DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition = New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition
        Dim StyleFormatCondition4 As DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition = New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition
        Dim StyleFormatCondition5 As DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition = New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucEncuestaNegocios))
        Me.clP0_PREFac = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clEditado = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clEditadoAnterior = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.gridSecundario = New DevExpress.XtraTreeList.TreeList
        Me.clId = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clDescripcion = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clIdEncuestaCategoriaSku = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clIdTemporal = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clTipoActivo = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clTipoDato = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.TipoDatoItemComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Me.AppImageCollectionLarge = New DevExpress.Utils.ImageCollection(Me.components)
        Me.AppImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.clCodigoNegocio = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clFrecuencia = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clTipoDistribucion = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clP0_VtaFac = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clP1_VtaFac = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clP2_VtaFac = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clP0_IAntFac = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clP1_IANTFac = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clP2_IANTFac = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clP0_CM1PFac = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clP0_CM2PFac = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clP1_CM1PFac = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clP1_CM2PFac = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clP2_CM1PFac = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clP2_CM2PFac = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clP0_INVFac = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clP1_INVFac = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clP2_INVFac = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clP1_PREFac = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clP2_PREFac = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clP0_REG = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clP1_REG = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clP2_REG = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clComentarios = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.clCodigoUsuario = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clEstado = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.estadoItemComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Me.clCodigoSku = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clCodigoSkuOriginal = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clCodigoNegocioSku = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clCodigoCategoriaAgrupada = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clSku = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clEstadoNegocio = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.estadoNegocio = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Me.clP0_PRE2Fac = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clP1_PRE2Fac = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.clP2_PRE2Fac = New DevExpress.XtraTreeList.Columns.TreeListColumn
        CType(Me.gridSecundario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoDatoItemComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppImageCollectionLarge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.estadoItemComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.estadoNegocio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'clP0_PREFac
        '
        Me.clP0_PREFac.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.clP0_PREFac.AppearanceCell.Options.UseFont = True
        Me.clP0_PREFac.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.clP0_PREFac.AppearanceHeader.Options.UseFont = True
        Me.clP0_PREFac.AppearanceHeader.Options.UseTextOptions = True
        Me.clP0_PREFac.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clP0_PREFac.Caption = "PreAc"
        Me.clP0_PREFac.FieldName = "P0_PREFac"
        Me.clP0_PREFac.Format.FormatString = "c2"
        Me.clP0_PREFac.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clP0_PREFac.MinWidth = 40
        Me.clP0_PREFac.Name = "clP0_PREFac"
        Me.clP0_PREFac.Width = 60
        '
        'clEditado
        '
        Me.clEditado.Caption = "Editado"
        Me.clEditado.FieldName = "Editado"
        Me.clEditado.Name = "clEditado"
        Me.clEditado.OptionsColumn.AllowEdit = False
        Me.clEditado.OptionsColumn.ReadOnly = True
        Me.clEditado.Width = 38
        '
        'clEditadoAnterior
        '
        Me.clEditadoAnterior.Caption = "EditadoAnterior"
        Me.clEditadoAnterior.FieldName = "EditadoAnterior"
        Me.clEditadoAnterior.Name = "clEditadoAnterior"
        Me.clEditadoAnterior.OptionsColumn.AllowEdit = False
        Me.clEditadoAnterior.OptionsColumn.ReadOnly = True
        Me.clEditadoAnterior.Width = 38
        '
        'gridSecundario
        '
        Me.gridSecundario.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridSecundario.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Navy
        Me.gridSecundario.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gridSecundario.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gridSecundario.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.clId, Me.clDescripcion, Me.clTipoDato, Me.clTipoActivo, Me.clIdEncuestaCategoriaSku, Me.clIdTemporal, Me.clCodigoNegocio, Me.clFrecuencia, Me.clTipoDistribucion, Me.clP0_VtaFac, Me.clP1_VtaFac, Me.clP2_VtaFac, Me.clP0_IAntFac, Me.clP1_IANTFac, Me.clP2_IANTFac, Me.clP0_CM1PFac, Me.clP0_CM2PFac, Me.clP1_CM1PFac, Me.clP1_CM2PFac, Me.clP2_CM1PFac, Me.clP2_CM2PFac, Me.clP0_INVFac, Me.clP1_INVFac, Me.clP2_INVFac, Me.clP0_PREFac, Me.clP1_PREFac, Me.clP2_PREFac, Me.clP0_REG, Me.clP1_REG, Me.clP2_REG, Me.clComentarios, Me.clCodigoUsuario, Me.clEstado, Me.clCodigoSku, Me.clCodigoSkuOriginal, Me.clCodigoNegocioSku, Me.clCodigoCategoriaAgrupada, Me.clSku, Me.clEditado, Me.clEditadoAnterior, Me.clEstadoNegocio, Me.clP0_PRE2Fac, Me.clP1_PRE2Fac, Me.clP2_PRE2Fac})
        Me.gridSecundario.Dock = System.Windows.Forms.DockStyle.Fill
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Column = Me.clP0_PREFac
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition1.Expression = "[P0_PREFac]< [P1_PREFac]"
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Column = Me.clP0_PREFac
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition2.Expression = "[P0_PREFac]> [P1_PREFac]"
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.Column = Me.clP0_PREFac
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.LessOrEqual
        StyleFormatCondition4.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition4.Appearance.Options.UseBackColor = True
        StyleFormatCondition4.ApplyToRow = True
        StyleFormatCondition4.Column = Me.clEditado
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition4.Value1 = True
        StyleFormatCondition5.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        StyleFormatCondition5.Appearance.Options.UseBackColor = True
        StyleFormatCondition5.ApplyToRow = True
        StyleFormatCondition5.Column = Me.clEditadoAnterior
        StyleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition5.Value1 = CType(1, Byte)
        Me.gridSecundario.FormatConditions.AddRange(New DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3, StyleFormatCondition4, StyleFormatCondition5})
        Me.gridSecundario.KeyFieldName = "Id"
        Me.gridSecundario.Location = New System.Drawing.Point(0, 0)
        Me.gridSecundario.Name = "gridSecundario"
        Me.gridSecundario.OptionsBehavior.AllowRecursiveNodeChecking = True
        Me.gridSecundario.OptionsBehavior.EnableFiltering = True
        Me.gridSecundario.OptionsBehavior.PopulateServiceColumns = True
        Me.gridSecundario.OptionsFilter.AllowColumnMRUFilterList = False
        Me.gridSecundario.OptionsFilter.AllowMRUFilterList = False
        Me.gridSecundario.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Smart
        Me.gridSecundario.OptionsFind.AllowFindPanel = True
        Me.gridSecundario.OptionsFind.AlwaysVisible = True
        Me.gridSecundario.OptionsSelection.MultiSelect = True
        Me.gridSecundario.OptionsView.AutoWidth = False
        Me.gridSecundario.OptionsView.EnableAppearanceEvenRow = True
        Me.gridSecundario.OptionsView.ShowAutoFilterRow = True
        Me.gridSecundario.OptionsView.ShowCheckBoxes = True
        Me.gridSecundario.OptionsView.ShowFilterPanelMode = DevExpress.XtraTreeList.ShowFilterPanelMode.ShowAlways
        Me.gridSecundario.ParentFieldName = "ParentId"
        Me.gridSecundario.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.estadoItemComboBox, Me.TipoDatoItemComboBox, Me.estadoNegocio, Me.RepositoryItemMemoExEdit1})
        Me.gridSecundario.Size = New System.Drawing.Size(1500, 477)
        Me.gridSecundario.TabIndex = 0
        '
        'clId
        '
        Me.clId.Caption = "Id"
        Me.clId.FieldName = "Id"
        Me.clId.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left
        Me.clId.Name = "clId"
        '
        'clDescripcion
        '
        Me.clDescripcion.AppearanceHeader.Options.UseTextOptions = True
        Me.clDescripcion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clDescripcion.Caption = "Tienda/Categoria/SKU"
        Me.clDescripcion.FieldName = "Descripcion"
        Me.clDescripcion.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left
        Me.clDescripcion.MinWidth = 32
        Me.clDescripcion.Name = "clDescripcion"
        Me.clDescripcion.OptionsColumn.AllowEdit = False
        Me.clDescripcion.OptionsColumn.ReadOnly = True
        Me.clDescripcion.Visible = True
        Me.clDescripcion.VisibleIndex = 0
        Me.clDescripcion.Width = 330
        '
        'clIdEncuestaCategoriaSku
        '
        Me.clIdEncuestaCategoriaSku.AppearanceHeader.Options.UseTextOptions = True
        Me.clIdEncuestaCategoriaSku.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clIdEncuestaCategoriaSku.Caption = "IdEncuestaCategoriaSku"
        Me.clIdEncuestaCategoriaSku.FieldName = "IdEncuestaCategoriaSku"
        Me.clIdEncuestaCategoriaSku.Name = "clIdEncuestaCategoriaSku"
        '
        'clIdTemporal
        '
        Me.clIdTemporal.AppearanceHeader.Options.UseTextOptions = True
        Me.clIdTemporal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clIdTemporal.Caption = "IdTemporal"
        Me.clIdTemporal.FieldName = "IdTemporal"
        Me.clIdTemporal.Name = "clIdTemporal"
        Me.clIdTemporal.OptionsColumn.AllowEdit = False
        Me.clIdTemporal.OptionsColumn.ReadOnly = True
        '
        'clTipoActivo
        '
        Me.clTipoActivo.AppearanceHeader.Options.UseTextOptions = True
        Me.clTipoActivo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clTipoActivo.Caption = "TipoActivo"
        Me.clTipoActivo.FieldName = "TipoActivo"
        Me.clTipoActivo.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left
        Me.clTipoActivo.MinWidth = 16
        Me.clTipoActivo.Name = "clTipoActivo"
        Me.clTipoActivo.OptionsColumn.AllowEdit = False
        Me.clTipoActivo.OptionsColumn.ReadOnly = True
        Me.clTipoActivo.Visible = True
        Me.clTipoActivo.VisibleIndex = 2
        Me.clTipoActivo.Width = 49
        '
        'clTipoDato
        '
        Me.clTipoDato.AppearanceHeader.Options.UseTextOptions = True
        Me.clTipoDato.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clTipoDato.Caption = "TipoDato"
        Me.clTipoDato.ColumnEdit = Me.TipoDatoItemComboBox
        Me.clTipoDato.FieldName = "TipoDato"
        Me.clTipoDato.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left
        Me.clTipoDato.MinWidth = 16
        Me.clTipoDato.Name = "clTipoDato"
        Me.clTipoDato.OptionsColumn.AllowEdit = False
        Me.clTipoDato.OptionsColumn.ReadOnly = True
        Me.clTipoDato.Visible = True
        Me.clTipoDato.VisibleIndex = 1
        Me.clTipoDato.Width = 40
        '
        'TipoDatoItemComboBox
        '
        Me.TipoDatoItemComboBox.AutoHeight = False
        Me.TipoDatoItemComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)})
        Me.TipoDatoItemComboBox.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TipoDatoItemComboBox.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Campo", CType(0, Byte), 21), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Supervisión", CType(1, Byte), 22), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Consistencia", CType(2, Byte), 23)})
        Me.TipoDatoItemComboBox.LargeImages = Me.AppImageCollectionLarge
        Me.TipoDatoItemComboBox.Name = "TipoDatoItemComboBox"
        Me.TipoDatoItemComboBox.SmallImages = Me.AppImageCollection
        '
        'AppImageCollectionLarge
        '
        Me.AppImageCollectionLarge.ImageSize = New System.Drawing.Size(32, 32)
        Me.AppImageCollectionLarge.ImageStream = CType(resources.GetObject("AppImageCollectionLarge.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.AppImageCollectionLarge.Images.SetKeyName(0, "avances.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(1, "icol_01_real.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(2, "icol_02_analizado.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(3, "icol_03_vacio.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(4, "icol_04_vacio.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(5, "icol_05_vacio.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(6, "icol_06_vacio.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(7, "icol_07_semaforo.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(8, "icol_08_variaciones.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(9, "icol_09_sku.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(10, "icol_10_frecuencia.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(11, "icol_11_marcaparasupervision.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(12, "icol_12_resumendemarcas.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(13, "icol_13_supervicionesporvalidar.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(14, "icol_14_estadistica.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(15, "icol_15_propiedades.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(16, "icol_16_replicarencuesta.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(17, "icol_17_encuestapromedio.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(18, "icol_18_skuconpromedio.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(19, "icol_19_cancelaractualizar.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(20, "icol_20_datos.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(21, "icol_21_campo.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(22, "icol_22_supervicion.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(23, "icol_23_ajustado.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(24, "icol_24_todos.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(25, "icol_25_alertas.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(26, "icol_26_ok.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(27, "icol_27_todos.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(28, "icol_28_gestionderangos.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(29, "icol_29_exel.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(30, "icol_30_pdf.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(31, "icol_31_csv.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(32, "icol_32_xml.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(33, "icol_33_vacio.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(34, "icol_34_vacio.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(35, "icol_35_vistaprevia.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(36, "icol_36_imprimir.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(37, "icol_37_paneldecontrol.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(38, "icol_38_controldeavance.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(39, "icol_39_refresca.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(40, "icol_40_grabar.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(41, "icol_41_salir.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(42, "icol_42_AcercaDe.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(43, "icol_43.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(44, "icol_44.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(45, "icol_45.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(46, "icol_46.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(47, "icol_47.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(48, "icol_48.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(49, "icol_49.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(50, "icol_50.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(51, "icol_51.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(52, "icol_52.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(53, "icol_53.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(54, "icol_54.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(55, "icol_55.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(56, "icol_56.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(57, "icol_57_alerta.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(58, "icol_58_ok.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(59, "icol_59.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(60, "icol_60.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(61, "icol_61.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(62, "icol_62.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(63, "icol_63.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(64, "icol_64.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(65, "icol_65.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(66, "icol_66.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(67, "icol_67.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(68, "icol_68.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(69, "icol_69.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(70, "icol_70.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(71, "icol_71_Estado_Correcto.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(72, "icol_72_Estado_incompleto.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(73, "icol_73_Estado_MSupervision.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(74, "icol_74_Estado_ASupervision.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(75, "icol_75_Estado_Supervision.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(76, "icol_76_Estado_Validado.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(77, "icol_77_Estado_Atipico.png")
        '
        'AppImageCollection
        '
        Me.AppImageCollection.ImageStream = CType(resources.GetObject("AppImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.AppImageCollection.Images.SetKeyName(0, "avances.png")
        Me.AppImageCollection.Images.SetKeyName(1, "icos_01_real.png")
        Me.AppImageCollection.Images.SetKeyName(2, "icos_02_analizado.png")
        Me.AppImageCollection.Images.SetKeyName(3, "icos_03_vacio.png")
        Me.AppImageCollection.Images.SetKeyName(4, "icos_04_vacio.png")
        Me.AppImageCollection.Images.SetKeyName(5, "icos_05_vacio.png")
        Me.AppImageCollection.Images.SetKeyName(6, "icos_06_vacio.png")
        Me.AppImageCollection.Images.SetKeyName(7, "icos_07_semaforo.png")
        Me.AppImageCollection.Images.SetKeyName(8, "icos_08_variaciones.png")
        Me.AppImageCollection.Images.SetKeyName(9, "icos_09_sku.png")
        Me.AppImageCollection.Images.SetKeyName(10, "icos_10_frecuencia.png")
        Me.AppImageCollection.Images.SetKeyName(11, "icos_11_marcaparasupervision.png")
        Me.AppImageCollection.Images.SetKeyName(12, "icos_12_resumendemarcas.png")
        Me.AppImageCollection.Images.SetKeyName(13, "icos_13_supervicionesporvalidar.png")
        Me.AppImageCollection.Images.SetKeyName(14, "icos_14_estadistica.png")
        Me.AppImageCollection.Images.SetKeyName(15, "icos_15_propiedades.png")
        Me.AppImageCollection.Images.SetKeyName(16, "icos_16_replicarencuesta.png")
        Me.AppImageCollection.Images.SetKeyName(17, "icos_17_encuestapromedio.png")
        Me.AppImageCollection.Images.SetKeyName(18, "icos_18_skuconpromedio.png")
        Me.AppImageCollection.Images.SetKeyName(19, "icos_19_cancelaractualizar.png")
        Me.AppImageCollection.Images.SetKeyName(20, "icos_20_datos.png")
        Me.AppImageCollection.Images.SetKeyName(21, "icos_21_campo.png")
        Me.AppImageCollection.Images.SetKeyName(22, "icos_22_supervicion.png")
        Me.AppImageCollection.Images.SetKeyName(23, "icos_23_ajustado.png")
        Me.AppImageCollection.Images.SetKeyName(24, "icos_24_todos.png")
        Me.AppImageCollection.Images.SetKeyName(25, "icos_25_alertas.png")
        Me.AppImageCollection.Images.SetKeyName(26, "icos_26_ok.png")
        Me.AppImageCollection.Images.SetKeyName(27, "icos_27_todos.png")
        Me.AppImageCollection.Images.SetKeyName(28, "icos_28_gestionderangos.png")
        Me.AppImageCollection.Images.SetKeyName(29, "icos_29_exel.png")
        Me.AppImageCollection.Images.SetKeyName(30, "icos_30_pdf.png")
        Me.AppImageCollection.Images.SetKeyName(31, "icos_31_csv.png")
        Me.AppImageCollection.Images.SetKeyName(32, "icos_32_xml.png")
        Me.AppImageCollection.Images.SetKeyName(33, "icos_33_vacio.png")
        Me.AppImageCollection.Images.SetKeyName(34, "icos_34.png")
        Me.AppImageCollection.Images.SetKeyName(35, "icos_35_vistaprevia.png")
        Me.AppImageCollection.Images.SetKeyName(36, "icos_36_imprimir.png")
        Me.AppImageCollection.Images.SetKeyName(37, "icos_37_paneldecontro.png")
        Me.AppImageCollection.Images.SetKeyName(38, "icos_38_controldeavance.png")
        Me.AppImageCollection.Images.SetKeyName(39, "icos_39_refresca.png")
        Me.AppImageCollection.Images.SetKeyName(40, "icos_40_grabar.png")
        Me.AppImageCollection.Images.SetKeyName(41, "icos_41_salir.png")
        Me.AppImageCollection.Images.SetKeyName(42, "icos_42_AcercaDe.png")
        Me.AppImageCollection.Images.SetKeyName(43, "icos_43.png")
        Me.AppImageCollection.Images.SetKeyName(44, "icos_44.png")
        Me.AppImageCollection.Images.SetKeyName(45, "icos_45.png")
        Me.AppImageCollection.Images.SetKeyName(46, "icos_46.png")
        Me.AppImageCollection.Images.SetKeyName(47, "icos_47.png")
        Me.AppImageCollection.Images.SetKeyName(48, "icos_48.png")
        Me.AppImageCollection.Images.SetKeyName(49, "icos_49.png")
        Me.AppImageCollection.Images.SetKeyName(50, "icos_50_usuario.png")
        Me.AppImageCollection.Images.SetKeyName(51, "icos_51_bd.png")
        Me.AppImageCollection.Images.SetKeyName(52, "icos_52_servidor.png")
        Me.AppImageCollection.Images.SetKeyName(53, "icos_53.png")
        Me.AppImageCollection.Images.SetKeyName(54, "icos_54.png")
        Me.AppImageCollection.Images.SetKeyName(55, "icos_55.png")
        Me.AppImageCollection.Images.SetKeyName(56, "icos_56.png")
        Me.AppImageCollection.Images.SetKeyName(57, "icos_57_alerta.png")
        Me.AppImageCollection.Images.SetKeyName(58, "icos_58_ok.png")
        Me.AppImageCollection.Images.SetKeyName(59, "icos_59.png")
        Me.AppImageCollection.Images.SetKeyName(60, "icos_60.png")
        Me.AppImageCollection.Images.SetKeyName(61, "icos_61.png")
        Me.AppImageCollection.Images.SetKeyName(62, "icos_62.png")
        Me.AppImageCollection.Images.SetKeyName(63, "icos_63.png")
        Me.AppImageCollection.Images.SetKeyName(64, "icos_64.png")
        Me.AppImageCollection.Images.SetKeyName(65, "icos_65.png")
        Me.AppImageCollection.Images.SetKeyName(66, "icos_66.png")
        Me.AppImageCollection.Images.SetKeyName(67, "icos_67.png")
        Me.AppImageCollection.Images.SetKeyName(68, "icos_68.png")
        Me.AppImageCollection.Images.SetKeyName(69, "icos_69.png")
        Me.AppImageCollection.Images.SetKeyName(70, "icos_70.png")
        Me.AppImageCollection.Images.SetKeyName(71, "icos_71_congelar.png")
        Me.AppImageCollection.Images.SetKeyName(72, "icos_72_Estado_todos.png")
        Me.AppImageCollection.Images.SetKeyName(73, "icos_73_recargar.png")
        Me.AppImageCollection.Images.SetKeyName(74, "icos_74.png")
        Me.AppImageCollection.Images.SetKeyName(75, "icos_75.png")
        Me.AppImageCollection.Images.SetKeyName(76, "icos_76.png")
        Me.AppImageCollection.Images.SetKeyName(77, "icos_77.png")
        Me.AppImageCollection.Images.SetKeyName(78, "icos_78.png")
        '
        'clCodigoNegocio
        '
        Me.clCodigoNegocio.AppearanceHeader.Options.UseTextOptions = True
        Me.clCodigoNegocio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clCodigoNegocio.Caption = "CodigoNegocio"
        Me.clCodigoNegocio.FieldName = "CodigoNegocio"
        Me.clCodigoNegocio.MinWidth = 30
        Me.clCodigoNegocio.Name = "clCodigoNegocio"
        Me.clCodigoNegocio.OptionsColumn.AllowEdit = False
        Me.clCodigoNegocio.OptionsColumn.ReadOnly = True
        Me.clCodigoNegocio.Width = 30
        '
        'clFrecuencia
        '
        Me.clFrecuencia.AppearanceHeader.Options.UseTextOptions = True
        Me.clFrecuencia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clFrecuencia.Caption = "Frecuencia"
        Me.clFrecuencia.FieldName = "Frecuencia"
        Me.clFrecuencia.MinWidth = 30
        Me.clFrecuencia.Name = "clFrecuencia"
        Me.clFrecuencia.OptionsColumn.AllowEdit = False
        Me.clFrecuencia.OptionsColumn.ReadOnly = True
        Me.clFrecuencia.Width = 51
        '
        'clTipoDistribucion
        '
        Me.clTipoDistribucion.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.clTipoDistribucion.AppearanceHeader.Options.UseFont = True
        Me.clTipoDistribucion.AppearanceHeader.Options.UseTextOptions = True
        Me.clTipoDistribucion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clTipoDistribucion.Caption = "TD"
        Me.clTipoDistribucion.FieldName = "TipoDistribucion"
        Me.clTipoDistribucion.Format.FormatString = "#"
        Me.clTipoDistribucion.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clTipoDistribucion.Name = "clTipoDistribucion"
        Me.clTipoDistribucion.ToolTip = "Tipo de Distribucion (0:No Aplica 1:Directa 2:Indirecta 3:Mixta"
        Me.clTipoDistribucion.Visible = True
        Me.clTipoDistribucion.VisibleIndex = 4
        Me.clTipoDistribucion.Width = 30
        '
        'clP0_VtaFac
        '
        Me.clP0_VtaFac.AppearanceHeader.Options.UseTextOptions = True
        Me.clP0_VtaFac.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clP0_VtaFac.Caption = "VtaAc"
        Me.clP0_VtaFac.FieldName = "P0_VtaFac"
        Me.clP0_VtaFac.Format.FormatString = "#,###"
        Me.clP0_VtaFac.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clP0_VtaFac.Name = "clP0_VtaFac"
        Me.clP0_VtaFac.OptionsColumn.AllowEdit = False
        Me.clP0_VtaFac.OptionsColumn.ReadOnly = True
        Me.clP0_VtaFac.Width = 55
        '
        'clP1_VtaFac
        '
        Me.clP1_VtaFac.AppearanceHeader.Options.UseTextOptions = True
        Me.clP1_VtaFac.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clP1_VtaFac.Caption = "VtaAn"
        Me.clP1_VtaFac.FieldName = "P1_VtaFac"
        Me.clP1_VtaFac.Format.FormatString = "#,###"
        Me.clP1_VtaFac.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clP1_VtaFac.Name = "clP1_VtaFac"
        Me.clP1_VtaFac.OptionsColumn.AllowEdit = False
        Me.clP1_VtaFac.OptionsColumn.ReadOnly = True
        Me.clP1_VtaFac.Width = 55
        '
        'clP2_VtaFac
        '
        Me.clP2_VtaFac.AppearanceHeader.Options.UseTextOptions = True
        Me.clP2_VtaFac.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clP2_VtaFac.Caption = "VtaTr"
        Me.clP2_VtaFac.FieldName = "P2_VtaFac"
        Me.clP2_VtaFac.Format.FormatString = "#,###"
        Me.clP2_VtaFac.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clP2_VtaFac.Name = "clP2_VtaFac"
        Me.clP2_VtaFac.OptionsColumn.AllowEdit = False
        Me.clP2_VtaFac.OptionsColumn.ReadOnly = True
        Me.clP2_VtaFac.Width = 55
        '
        'clP0_IAntFac
        '
        Me.clP0_IAntFac.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.clP0_IAntFac.AppearanceCell.Options.UseFont = True
        Me.clP0_IAntFac.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.clP0_IAntFac.AppearanceHeader.Options.UseFont = True
        Me.clP0_IAntFac.AppearanceHeader.Options.UseTextOptions = True
        Me.clP0_IAntFac.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clP0_IAntFac.Caption = "IIAct"
        Me.clP0_IAntFac.FieldName = "P0_IAntFac"
        Me.clP0_IAntFac.Format.FormatString = "#,###"
        Me.clP0_IAntFac.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clP0_IAntFac.MinWidth = 30
        Me.clP0_IAntFac.Name = "clP0_IAntFac"
        Me.clP0_IAntFac.Width = 55
        '
        'clP1_IANTFac
        '
        Me.clP1_IANTFac.AppearanceHeader.Options.UseTextOptions = True
        Me.clP1_IANTFac.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clP1_IANTFac.Caption = "IIAnt"
        Me.clP1_IANTFac.FieldName = "P1_IANTFac"
        Me.clP1_IANTFac.Format.FormatString = "#,###"
        Me.clP1_IANTFac.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clP1_IANTFac.MinWidth = 30
        Me.clP1_IANTFac.Name = "clP1_IANTFac"
        Me.clP1_IANTFac.OptionsColumn.AllowEdit = False
        Me.clP1_IANTFac.OptionsColumn.ReadOnly = True
        Me.clP1_IANTFac.Width = 55
        '
        'clP2_IANTFac
        '
        Me.clP2_IANTFac.AppearanceHeader.Options.UseTextOptions = True
        Me.clP2_IANTFac.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clP2_IANTFac.Caption = "IITra"
        Me.clP2_IANTFac.FieldName = "P2_IANTFac"
        Me.clP2_IANTFac.Format.FormatString = "#,###"
        Me.clP2_IANTFac.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clP2_IANTFac.MinWidth = 30
        Me.clP2_IANTFac.Name = "clP2_IANTFac"
        Me.clP2_IANTFac.OptionsColumn.AllowEdit = False
        Me.clP2_IANTFac.OptionsColumn.ReadOnly = True
        Me.clP2_IANTFac.Width = 55
        '
        'clP0_CM1PFac
        '
        Me.clP0_CM1PFac.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.clP0_CM1PFac.AppearanceCell.Options.UseFont = True
        Me.clP0_CM1PFac.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.clP0_CM1PFac.AppearanceHeader.Options.UseFont = True
        Me.clP0_CM1PFac.AppearanceHeader.Options.UseTextOptions = True
        Me.clP0_CM1PFac.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clP0_CM1PFac.Caption = "CM1Ac"
        Me.clP0_CM1PFac.FieldName = "P0_CM1PFac"
        Me.clP0_CM1PFac.Format.FormatString = "#,###"
        Me.clP0_CM1PFac.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clP0_CM1PFac.MinWidth = 30
        Me.clP0_CM1PFac.Name = "clP0_CM1PFac"
        Me.clP0_CM1PFac.Width = 55
        '
        'clP0_CM2PFac
        '
        Me.clP0_CM2PFac.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.clP0_CM2PFac.AppearanceCell.Options.UseFont = True
        Me.clP0_CM2PFac.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.clP0_CM2PFac.AppearanceHeader.Options.UseFont = True
        Me.clP0_CM2PFac.AppearanceHeader.Options.UseTextOptions = True
        Me.clP0_CM2PFac.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clP0_CM2PFac.Caption = "CM2Ac"
        Me.clP0_CM2PFac.FieldName = "P0_CM2PFac"
        Me.clP0_CM2PFac.Format.FormatString = "#,###"
        Me.clP0_CM2PFac.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clP0_CM2PFac.MinWidth = 30
        Me.clP0_CM2PFac.Name = "clP0_CM2PFac"
        Me.clP0_CM2PFac.Width = 55
        '
        'clP1_CM1PFac
        '
        Me.clP1_CM1PFac.AppearanceHeader.Options.UseTextOptions = True
        Me.clP1_CM1PFac.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clP1_CM1PFac.Caption = "CM1An"
        Me.clP1_CM1PFac.FieldName = "P1_CM1PFac"
        Me.clP1_CM1PFac.Format.FormatString = "#,###"
        Me.clP1_CM1PFac.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clP1_CM1PFac.MinWidth = 30
        Me.clP1_CM1PFac.Name = "clP1_CM1PFac"
        Me.clP1_CM1PFac.OptionsColumn.AllowEdit = False
        Me.clP1_CM1PFac.OptionsColumn.ReadOnly = True
        Me.clP1_CM1PFac.Width = 55
        '
        'clP1_CM2PFac
        '
        Me.clP1_CM2PFac.AppearanceHeader.Options.UseTextOptions = True
        Me.clP1_CM2PFac.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clP1_CM2PFac.Caption = "CM2An"
        Me.clP1_CM2PFac.FieldName = "P1_CM2PFac"
        Me.clP1_CM2PFac.Format.FormatString = "#,###"
        Me.clP1_CM2PFac.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clP1_CM2PFac.MinWidth = 30
        Me.clP1_CM2PFac.Name = "clP1_CM2PFac"
        Me.clP1_CM2PFac.OptionsColumn.AllowEdit = False
        Me.clP1_CM2PFac.OptionsColumn.ReadOnly = True
        Me.clP1_CM2PFac.Width = 55
        '
        'clP2_CM1PFac
        '
        Me.clP2_CM1PFac.AppearanceHeader.Options.UseTextOptions = True
        Me.clP2_CM1PFac.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clP2_CM1PFac.Caption = "CM1Tr"
        Me.clP2_CM1PFac.FieldName = "P2_CM1PFac"
        Me.clP2_CM1PFac.Format.FormatString = "#,###"
        Me.clP2_CM1PFac.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clP2_CM1PFac.MinWidth = 30
        Me.clP2_CM1PFac.Name = "clP2_CM1PFac"
        Me.clP2_CM1PFac.OptionsColumn.AllowEdit = False
        Me.clP2_CM1PFac.OptionsColumn.ReadOnly = True
        Me.clP2_CM1PFac.Width = 55
        '
        'clP2_CM2PFac
        '
        Me.clP2_CM2PFac.AppearanceHeader.Options.UseTextOptions = True
        Me.clP2_CM2PFac.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clP2_CM2PFac.Caption = "CM2Tr"
        Me.clP2_CM2PFac.FieldName = "P2_CM2PFac"
        Me.clP2_CM2PFac.Format.FormatString = "#,###"
        Me.clP2_CM2PFac.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clP2_CM2PFac.MinWidth = 30
        Me.clP2_CM2PFac.Name = "clP2_CM2PFac"
        Me.clP2_CM2PFac.OptionsColumn.AllowEdit = False
        Me.clP2_CM2PFac.OptionsColumn.ReadOnly = True
        Me.clP2_CM2PFac.Width = 55
        '
        'clP0_INVFac
        '
        Me.clP0_INVFac.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.clP0_INVFac.AppearanceCell.Options.UseFont = True
        Me.clP0_INVFac.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.clP0_INVFac.AppearanceHeader.Options.UseFont = True
        Me.clP0_INVFac.AppearanceHeader.Options.UseTextOptions = True
        Me.clP0_INVFac.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clP0_INVFac.Caption = "IAct"
        Me.clP0_INVFac.FieldName = "P0_INVFac"
        Me.clP0_INVFac.Format.FormatString = "#,###"
        Me.clP0_INVFac.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clP0_INVFac.MinWidth = 30
        Me.clP0_INVFac.Name = "clP0_INVFac"
        Me.clP0_INVFac.Width = 55
        '
        'clP1_INVFac
        '
        Me.clP1_INVFac.AppearanceHeader.Options.UseTextOptions = True
        Me.clP1_INVFac.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clP1_INVFac.Caption = "IAnt"
        Me.clP1_INVFac.FieldName = "P1_INVFac"
        Me.clP1_INVFac.Format.FormatString = "#,###"
        Me.clP1_INVFac.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clP1_INVFac.MinWidth = 30
        Me.clP1_INVFac.Name = "clP1_INVFac"
        Me.clP1_INVFac.OptionsColumn.AllowEdit = False
        Me.clP1_INVFac.OptionsColumn.ReadOnly = True
        Me.clP1_INVFac.Width = 55
        '
        'clP2_INVFac
        '
        Me.clP2_INVFac.AppearanceHeader.Options.UseTextOptions = True
        Me.clP2_INVFac.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clP2_INVFac.Caption = "ITra"
        Me.clP2_INVFac.FieldName = "P2_INVFac"
        Me.clP2_INVFac.Format.FormatString = "#,###"
        Me.clP2_INVFac.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clP2_INVFac.MinWidth = 30
        Me.clP2_INVFac.Name = "clP2_INVFac"
        Me.clP2_INVFac.OptionsColumn.AllowEdit = False
        Me.clP2_INVFac.OptionsColumn.ReadOnly = True
        Me.clP2_INVFac.Width = 55
        '
        'clP1_PREFac
        '
        Me.clP1_PREFac.AppearanceHeader.Options.UseTextOptions = True
        Me.clP1_PREFac.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clP1_PREFac.Caption = "PreAn"
        Me.clP1_PREFac.FieldName = "P1_PREFac"
        Me.clP1_PREFac.Format.FormatString = "c2"
        Me.clP1_PREFac.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clP1_PREFac.MinWidth = 40
        Me.clP1_PREFac.Name = "clP1_PREFac"
        Me.clP1_PREFac.OptionsColumn.AllowEdit = False
        Me.clP1_PREFac.OptionsColumn.ReadOnly = True
        Me.clP1_PREFac.Width = 60
        '
        'clP2_PREFac
        '
        Me.clP2_PREFac.AppearanceHeader.Options.UseTextOptions = True
        Me.clP2_PREFac.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clP2_PREFac.Caption = "PreTr"
        Me.clP2_PREFac.FieldName = "P2_PREFac"
        Me.clP2_PREFac.Format.FormatString = "c2"
        Me.clP2_PREFac.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clP2_PREFac.MinWidth = 40
        Me.clP2_PREFac.Name = "clP2_PREFac"
        Me.clP2_PREFac.OptionsColumn.AllowEdit = False
        Me.clP2_PREFac.OptionsColumn.ReadOnly = True
        Me.clP2_PREFac.Width = 60
        '
        'clP0_REG
        '
        Me.clP0_REG.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.clP0_REG.AppearanceCell.Options.UseFont = True
        Me.clP0_REG.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.clP0_REG.AppearanceHeader.Options.UseFont = True
        Me.clP0_REG.AppearanceHeader.Options.UseTextOptions = True
        Me.clP0_REG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clP0_REG.Caption = "RegAc"
        Me.clP0_REG.FieldName = "P0_REG"
        Me.clP0_REG.Format.FormatString = "#,###"
        Me.clP0_REG.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clP0_REG.MinWidth = 70
        Me.clP0_REG.Name = "clP0_REG"
        Me.clP0_REG.OptionsColumn.AllowFocus = False
        Me.clP0_REG.OptionsColumn.ReadOnly = True
        Me.clP0_REG.Width = 70
        '
        'clP1_REG
        '
        Me.clP1_REG.AppearanceHeader.Options.UseTextOptions = True
        Me.clP1_REG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clP1_REG.Caption = "RegAn"
        Me.clP1_REG.FieldName = "P1_REG"
        Me.clP1_REG.Format.FormatString = "#,###"
        Me.clP1_REG.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clP1_REG.MinWidth = 70
        Me.clP1_REG.Name = "clP1_REG"
        Me.clP1_REG.OptionsColumn.AllowEdit = False
        Me.clP1_REG.OptionsColumn.ReadOnly = True
        Me.clP1_REG.Width = 70
        '
        'clP2_REG
        '
        Me.clP2_REG.AppearanceHeader.Options.UseTextOptions = True
        Me.clP2_REG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clP2_REG.Caption = "RegTr"
        Me.clP2_REG.FieldName = "P2_REG"
        Me.clP2_REG.Format.FormatString = "#,###"
        Me.clP2_REG.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clP2_REG.MinWidth = 70
        Me.clP2_REG.Name = "clP2_REG"
        Me.clP2_REG.OptionsColumn.AllowEdit = False
        Me.clP2_REG.OptionsColumn.ReadOnly = True
        Me.clP2_REG.Width = 70
        '
        'clComentarios
        '
        Me.clComentarios.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.clComentarios.AppearanceCell.Options.UseFont = True
        Me.clComentarios.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.clComentarios.AppearanceHeader.Options.UseFont = True
        Me.clComentarios.AppearanceHeader.Options.UseTextOptions = True
        Me.clComentarios.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clComentarios.Caption = "Comentarios"
        Me.clComentarios.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.clComentarios.FieldName = "Comentarios"
        Me.clComentarios.MinWidth = 70
        Me.clComentarios.Name = "clComentarios"
        Me.clComentarios.Visible = True
        Me.clComentarios.VisibleIndex = 6
        Me.clComentarios.Width = 150
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'clCodigoUsuario
        '
        Me.clCodigoUsuario.AppearanceHeader.Options.UseTextOptions = True
        Me.clCodigoUsuario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clCodigoUsuario.Caption = "CodigoUsuario"
        Me.clCodigoUsuario.FieldName = "CodigoUsuario"
        Me.clCodigoUsuario.MinWidth = 70
        Me.clCodigoUsuario.Name = "clCodigoUsuario"
        Me.clCodigoUsuario.OptionsColumn.AllowEdit = False
        Me.clCodigoUsuario.OptionsColumn.ReadOnly = True
        Me.clCodigoUsuario.Width = 70
        '
        'clEstado
        '
        Me.clEstado.AppearanceHeader.Options.UseTextOptions = True
        Me.clEstado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clEstado.Caption = "Registro"
        Me.clEstado.ColumnEdit = Me.estadoItemComboBox
        Me.clEstado.FieldName = "EstadoRegistro"
        Me.clEstado.MinWidth = 70
        Me.clEstado.Name = "clEstado"
        Me.clEstado.OptionsColumn.AllowEdit = False
        Me.clEstado.OptionsColumn.ReadOnly = True
        Me.clEstado.Visible = True
        Me.clEstado.VisibleIndex = 5
        Me.clEstado.Width = 70
        '
        'estadoItemComboBox
        '
        Me.estadoItemComboBox.AutoHeight = False
        Me.estadoItemComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)})
        Me.estadoItemComboBox.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.estadoItemComboBox.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Activo", CType(0, Byte), 65), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Atipico", CType(1, Byte), 46), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("No Procesa", CType(2, Byte), 66)})
        Me.estadoItemComboBox.LargeImages = Me.AppImageCollectionLarge
        Me.estadoItemComboBox.Name = "estadoItemComboBox"
        Me.estadoItemComboBox.SmallImages = Me.AppImageCollection
        '
        'clCodigoSku
        '
        Me.clCodigoSku.AppearanceHeader.Options.UseTextOptions = True
        Me.clCodigoSku.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clCodigoSku.Caption = "Codigo de Sku"
        Me.clCodigoSku.FieldName = "CodigoSku"
        Me.clCodigoSku.MinWidth = 70
        Me.clCodigoSku.Name = "clCodigoSku"
        Me.clCodigoSku.OptionsColumn.AllowEdit = False
        Me.clCodigoSku.OptionsColumn.ReadOnly = True
        Me.clCodigoSku.Width = 70
        '
        'clCodigoSkuOriginal
        '
        Me.clCodigoSkuOriginal.AppearanceHeader.Options.UseTextOptions = True
        Me.clCodigoSkuOriginal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clCodigoSkuOriginal.Caption = "Cod de SkuOriginal"
        Me.clCodigoSkuOriginal.FieldName = "CodigoSkuOriginal"
        Me.clCodigoSkuOriginal.MinWidth = 70
        Me.clCodigoSkuOriginal.Name = "clCodigoSkuOriginal"
        Me.clCodigoSkuOriginal.OptionsColumn.AllowEdit = False
        Me.clCodigoSkuOriginal.OptionsColumn.ReadOnly = True
        Me.clCodigoSkuOriginal.Width = 70
        '
        'clCodigoNegocioSku
        '
        Me.clCodigoNegocioSku.AppearanceHeader.Options.UseTextOptions = True
        Me.clCodigoNegocioSku.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clCodigoNegocioSku.Caption = "Codigo de Negocio"
        Me.clCodigoNegocioSku.FieldName = "CodigoNegocioSku"
        Me.clCodigoNegocioSku.MinWidth = 70
        Me.clCodigoNegocioSku.Name = "clCodigoNegocioSku"
        Me.clCodigoNegocioSku.OptionsColumn.AllowEdit = False
        Me.clCodigoNegocioSku.OptionsColumn.ReadOnly = True
        Me.clCodigoNegocioSku.Width = 70
        '
        'clCodigoCategoriaAgrupada
        '
        Me.clCodigoCategoriaAgrupada.AppearanceHeader.Options.UseTextOptions = True
        Me.clCodigoCategoriaAgrupada.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clCodigoCategoriaAgrupada.Caption = "CodigoCategoriaAgrupada"
        Me.clCodigoCategoriaAgrupada.FieldName = "CodigoCategoriaAgrupada"
        Me.clCodigoCategoriaAgrupada.MinWidth = 70
        Me.clCodigoCategoriaAgrupada.Name = "clCodigoCategoriaAgrupada"
        Me.clCodigoCategoriaAgrupada.OptionsColumn.AllowEdit = False
        Me.clCodigoCategoriaAgrupada.OptionsColumn.ReadOnly = True
        Me.clCodigoCategoriaAgrupada.Width = 70
        '
        'clSku
        '
        Me.clSku.Caption = "Sku"
        Me.clSku.FieldName = "Sku"
        Me.clSku.Name = "clSku"
        Me.clSku.OptionsColumn.AllowEdit = False
        Me.clSku.OptionsColumn.ReadOnly = True
        Me.clSku.Width = 38
        '
        'clEstadoNegocio
        '
        Me.clEstadoNegocio.AppearanceHeader.Options.UseTextOptions = True
        Me.clEstadoNegocio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clEstadoNegocio.Caption = "Estado"
        Me.clEstadoNegocio.ColumnEdit = Me.estadoNegocio
        Me.clEstadoNegocio.FieldName = "Estado"
        Me.clEstadoNegocio.Name = "clEstadoNegocio"
        Me.clEstadoNegocio.OptionsColumn.AllowEdit = False
        Me.clEstadoNegocio.OptionsColumn.ReadOnly = True
        Me.clEstadoNegocio.Visible = True
        Me.clEstadoNegocio.VisibleIndex = 3
        Me.clEstadoNegocio.Width = 50
        '
        'estadoNegocio
        '
        Me.estadoNegocio.AutoHeight = False
        Me.estadoNegocio.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.estadoNegocio.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.estadoNegocio.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Correcto", CType(0, Byte), 60), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Pendiente", CType(1, Byte), 61), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Marcado", CType(2, Byte), 62), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("En Supervision", CType(3, Byte), 63), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Supervisado", CType(4, Byte), 64), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Validado", CType(5, Byte), 65), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Atipico", CType(6, Byte), 66), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("No Procesa", CType(7, Byte), 67)})
        Me.estadoNegocio.LargeImages = Me.AppImageCollectionLarge
        Me.estadoNegocio.Name = "estadoNegocio"
        Me.estadoNegocio.SmallImages = Me.AppImageCollection
        '
        'clP0_PRE2Fac
        '
        Me.clP0_PRE2Fac.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.clP0_PRE2Fac.AppearanceCell.Options.UseFont = True
        Me.clP0_PRE2Fac.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.clP0_PRE2Fac.AppearanceHeader.Options.UseFont = True
        Me.clP0_PRE2Fac.AppearanceHeader.Options.UseTextOptions = True
        Me.clP0_PRE2Fac.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clP0_PRE2Fac.Caption = "Pre2Ac"
        Me.clP0_PRE2Fac.FieldName = "P0_PRE2Fac"
        Me.clP0_PRE2Fac.Format.FormatString = "c2"
        Me.clP0_PRE2Fac.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clP0_PRE2Fac.MinWidth = 40
        Me.clP0_PRE2Fac.Name = "clP0_PRE2Fac"
        Me.clP0_PRE2Fac.Visible = True
        Me.clP0_PRE2Fac.VisibleIndex = 7
        Me.clP0_PRE2Fac.Width = 50
        '
        'clP1_PRE2Fac
        '
        Me.clP1_PRE2Fac.AppearanceHeader.Options.UseTextOptions = True
        Me.clP1_PRE2Fac.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clP1_PRE2Fac.Caption = "Pre2An"
        Me.clP1_PRE2Fac.FieldName = "P1_PRE2Fac"
        Me.clP1_PRE2Fac.Format.FormatString = "c2"
        Me.clP1_PRE2Fac.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clP1_PRE2Fac.MinWidth = 40
        Me.clP1_PRE2Fac.Name = "clP1_PRE2Fac"
        Me.clP1_PRE2Fac.OptionsColumn.AllowEdit = False
        Me.clP1_PRE2Fac.OptionsColumn.ReadOnly = True
        Me.clP1_PRE2Fac.Visible = True
        Me.clP1_PRE2Fac.VisibleIndex = 8
        Me.clP1_PRE2Fac.Width = 50
        '
        'clP2_PRE2Fac
        '
        Me.clP2_PRE2Fac.AppearanceHeader.Options.UseTextOptions = True
        Me.clP2_PRE2Fac.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clP2_PRE2Fac.Caption = "Pre2Tr"
        Me.clP2_PRE2Fac.FieldName = "P2_PRE2Fac"
        Me.clP2_PRE2Fac.Format.FormatString = "c2"
        Me.clP2_PRE2Fac.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clP2_PRE2Fac.MinWidth = 40
        Me.clP2_PRE2Fac.Name = "clP2_PRE2Fac"
        Me.clP2_PRE2Fac.OptionsColumn.AllowEdit = False
        Me.clP2_PRE2Fac.OptionsColumn.ReadOnly = True
        Me.clP2_PRE2Fac.Width = 50
        '
        'ucEncuestaNegocios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gridSecundario)
        Me.Name = "ucEncuestaNegocios"
        Me.Size = New System.Drawing.Size(1500, 477)
        CType(Me.gridSecundario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoDatoItemComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppImageCollectionLarge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.estadoItemComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.estadoNegocio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridSecundario As DevExpress.XtraTreeList.TreeList
    Friend WithEvents clId As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clDescripcion As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clIdEncuestaCategoriaSku As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clIdTemporal As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clTipoActivo As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clTipoDato As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clCodigoNegocio As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clFrecuencia As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clP0_IAntFac As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clP0_CM1PFac As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clP0_CM2PFac As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clP0_INVFac As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clP0_PREFac As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clP0_REG As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clP1_IANTFac As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clP1_CM1PFac As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clP1_CM2PFac As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clP1_INVFac As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clP1_PREFac As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clP1_REG As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clP2_IANTFac As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clP2_CM1PFac As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clP2_CM2PFac As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clP2_INVFac As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clP2_PREFac As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clP2_REG As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clComentarios As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clCodigoUsuario As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clEstado As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clCodigoSku As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clCodigoSkuOriginal As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clCodigoNegocioSku As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clCodigoCategoriaAgrupada As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clSku As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clEditado As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clP0_VtaFac As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clP1_VtaFac As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clP2_VtaFac As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents estadoItemComboBox As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Private WithEvents AppImageCollectionLarge As DevExpress.Utils.ImageCollection
    Private WithEvents AppImageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents TipoDatoItemComboBox As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents clEditadoAnterior As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clEstadoNegocio As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents estadoNegocio As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents clP0_PRE2Fac As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clP1_PRE2Fac As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clP2_PRE2Fac As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents clTipoDistribucion As DevExpress.XtraTreeList.Columns.TreeListColumn

End Class
