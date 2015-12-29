<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSkuEstadistica
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSkuEstadistica))
        Me.colValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl
        Me.btnSkuTodos = New DevExpress.XtraEditors.CheckButton
        Me.cmbSkuANivel = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lblSkuMensajeAdvertencia = New DevExpress.XtraEditors.MemoEdit
        Me.lookSkuReemplazo = New DevExpress.XtraEditors.LookUpEdit
        Me.txtSkuPesoMuestra = New DevExpress.XtraEditors.TextEdit
        Me.cmbSkuCambioMasivo = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.lblSku = New DevExpress.XtraEditors.LabelControl
        Me.btnSkuContinuar = New DevExpress.XtraEditors.SimpleButton
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.GridPrincipal = New DevExpress.XtraGrid.GridControl
        Me.gvResumenSku = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colGrupo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAtributo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridSecundario = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.lytSkuGrupoCambioMasivo = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
        Me.lytSkuMuestra = New DevExpress.XtraLayout.LayoutControlGroup
        Me.lblSkuMuestra = New DevExpress.XtraLayout.SimpleLabelItem
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem
        Me.lytSkuParecidos = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cmbSkuANivel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSkuMensajeAdvertencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookSkuReemplazo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSkuPesoMuestra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSkuCambioMasivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GridPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvResumenSku, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridSecundario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytSkuGrupoCambioMasivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytSkuMuestra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSkuMuestra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytSkuParecidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colValor
        '
        Me.colValor.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colValor.AppearanceCell.Options.UseBackColor = True
        Me.colValor.AppearanceCell.Options.UseTextOptions = True
        Me.colValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colValor.AppearanceHeader.Options.UseTextOptions = True
        Me.colValor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colValor.Caption = "Valor"
        Me.colValor.FieldName = "VALOR"
        Me.colValor.Name = "colValor"
        Me.colValor.OptionsColumn.AllowEdit = False
        Me.colValor.OptionsColumn.ReadOnly = True
        Me.colValor.ToolTip = "Valor de taributo o detalle del Sku"
        Me.colValor.Visible = True
        Me.colValor.VisibleIndex = 1
        Me.colValor.Width = 300
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.btnSkuTodos)
        Me.LayoutControl1.Controls.Add(Me.cmbSkuANivel)
        Me.LayoutControl1.Controls.Add(Me.lblSkuMensajeAdvertencia)
        Me.LayoutControl1.Controls.Add(Me.lookSkuReemplazo)
        Me.LayoutControl1.Controls.Add(Me.txtSkuPesoMuestra)
        Me.LayoutControl1.Controls.Add(Me.cmbSkuCambioMasivo)
        Me.LayoutControl1.Controls.Add(Me.LabelControl2)
        Me.LayoutControl1.Controls.Add(Me.LabelControl1)
        Me.LayoutControl1.Controls.Add(Me.lblSku)
        Me.LayoutControl1.Controls.Add(Me.btnSkuContinuar)
        Me.LayoutControl1.Controls.Add(Me.SplitContainerControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(691, 312, 250, 350)
        Me.LayoutControl1.OptionsView.UseDefaultDragAndDropRendering = False
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1306, 679)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'btnSkuTodos
        '
        Me.btnSkuTodos.Location = New System.Drawing.Point(1212, 102)
        Me.btnSkuTodos.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.btnSkuTodos.Name = "btnSkuTodos"
        Me.btnSkuTodos.Size = New System.Drawing.Size(70, 22)
        Me.btnSkuTodos.StyleController = Me.LayoutControl1
        Me.btnSkuTodos.TabIndex = 17
        Me.btnSkuTodos.Text = "Todos Skus"
        '
        'cmbSkuANivel
        '
        Me.cmbSkuANivel.Location = New System.Drawing.Point(369, 102)
        Me.cmbSkuANivel.Name = "cmbSkuANivel"
        Me.cmbSkuANivel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSkuANivel.Properties.Items.AddRange(New Object() {"Zona/Canal", "Zona", "Nacional"})
        Me.cmbSkuANivel.Size = New System.Drawing.Size(50, 20)
        Me.cmbSkuANivel.StyleController = Me.LayoutControl1
        Me.cmbSkuANivel.TabIndex = 16
        '
        'lblSkuMensajeAdvertencia
        '
        Me.lblSkuMensajeAdvertencia.Location = New System.Drawing.Point(948, 102)
        Me.lblSkuMensajeAdvertencia.Name = "lblSkuMensajeAdvertencia"
        Me.lblSkuMensajeAdvertencia.Properties.ReadOnly = True
        Me.lblSkuMensajeAdvertencia.Size = New System.Drawing.Size(169, 26)
        Me.lblSkuMensajeAdvertencia.StyleController = Me.LayoutControl1
        Me.lblSkuMensajeAdvertencia.TabIndex = 15
        '
        'lookSkuReemplazo
        '
        Me.lookSkuReemplazo.Location = New System.Drawing.Point(464, 102)
        Me.lookSkuReemplazo.Name = "lookSkuReemplazo"
        Me.lookSkuReemplazo.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lookSkuReemplazo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookSkuReemplazo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Sku", "Sku"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodigoSku", 150, "CodigoSku"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FC", "Fac. Conv.", 30, DevExpress.Utils.FormatType.Numeric, "##.000", True, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrecioModa", "Moda", 20, DevExpress.Utils.FormatType.Numeric, "#,###.00", True, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Venta", "Venta", 20, DevExpress.Utils.FormatType.Numeric, "#,###", True, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Negocios", "# Negs", 30, DevExpress.Utils.FormatType.Numeric, "#,###", True, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Categoria", "Categoria"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Parecido", "Parecido", 20, DevExpress.Utils.FormatType.Numeric, "#", True, DevExpress.Utils.HorzAlignment.[Default])})
        Me.lookSkuReemplazo.Properties.DropDownRows = 50
        Me.lookSkuReemplazo.Size = New System.Drawing.Size(264, 20)
        Me.lookSkuReemplazo.StyleController = Me.LayoutControl1
        Me.lookSkuReemplazo.TabIndex = 14
        '
        'txtSkuPesoMuestra
        '
        Me.txtSkuPesoMuestra.Location = New System.Drawing.Point(826, 105)
        Me.txtSkuPesoMuestra.Name = "txtSkuPesoMuestra"
        Me.txtSkuPesoMuestra.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSkuPesoMuestra.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSkuPesoMuestra.Properties.DisplayFormat.FormatString = "##"
        Me.txtSkuPesoMuestra.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSkuPesoMuestra.Properties.EditFormat.FormatString = "##"
        Me.txtSkuPesoMuestra.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSkuPesoMuestra.Properties.Mask.BeepOnError = True
        Me.txtSkuPesoMuestra.Properties.Mask.EditMask = "##"
        Me.txtSkuPesoMuestra.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSkuPesoMuestra.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSkuPesoMuestra.Properties.MaxLength = 2
        Me.txtSkuPesoMuestra.Size = New System.Drawing.Size(15, 20)
        Me.txtSkuPesoMuestra.StyleController = Me.LayoutControl1
        Me.txtSkuPesoMuestra.TabIndex = 12
        '
        'cmbSkuCambioMasivo
        '
        Me.cmbSkuCambioMasivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbSkuCambioMasivo.Location = New System.Drawing.Point(42, 102)
        Me.cmbSkuCambioMasivo.Name = "cmbSkuCambioMasivo"
        Me.cmbSkuCambioMasivo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSkuCambioMasivo.Properties.Items.AddRange(New Object() {"Reemplazar SKU elegido", "Completar Skus", "Poner No Procesar", "Poner Activo"})
        Me.cmbSkuCambioMasivo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbSkuCambioMasivo.Size = New System.Drawing.Size(250, 20)
        Me.cmbSkuCambioMasivo.StyleController = Me.LayoutControl1
        Me.cmbSkuCambioMasivo.TabIndex = 7
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Location = New System.Drawing.Point(324, 175)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(958, 13)
        Me.LabelControl2.StyleController = Me.LayoutControl1
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Estadisticas"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Location = New System.Drawing.Point(24, 175)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(296, 13)
        Me.LabelControl1.StyleController = Me.LayoutControl1
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Propiedades"
        '
        'lblSku
        '
        Me.lblSku.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSku.Appearance.Image = Global.CCRCCV2.My.Resources.Resources.icol_09_sku
        Me.lblSku.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblSku.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.lblSku.Location = New System.Drawing.Point(12, 12)
        Me.lblSku.Name = "lblSku"
        Me.lblSku.Size = New System.Drawing.Size(1282, 55)
        Me.lblSku.StyleController = Me.LayoutControl1
        Me.lblSku.TabIndex = 0
        Me.lblSku.Text = "Propiedades y Estadisticas del Sku"
        '
        'btnSkuContinuar
        '
        Me.btnSkuContinuar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSkuContinuar.Appearance.Options.UseFont = True
        Me.btnSkuContinuar.Location = New System.Drawing.Point(1129, 102)
        Me.btnSkuContinuar.Name = "btnSkuContinuar"
        Me.btnSkuContinuar.Size = New System.Drawing.Size(63, 22)
        Me.btnSkuContinuar.StyleController = Me.LayoutControl1
        Me.btnSkuContinuar.TabIndex = 8
        Me.btnSkuContinuar.Text = "Continuar"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Location = New System.Drawing.Point(24, 192)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GridPrincipal)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GridSecundario)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1258, 463)
        Me.SplitContainerControl1.SplitterPosition = 408
        Me.SplitContainerControl1.TabIndex = 4
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GridPrincipal
        '
        Me.GridPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.GridPrincipal.MainView = Me.gvResumenSku
        Me.GridPrincipal.Name = "GridPrincipal"
        Me.GridPrincipal.Size = New System.Drawing.Size(408, 463)
        Me.GridPrincipal.TabIndex = 1
        Me.GridPrincipal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvResumenSku})
        '
        'gvResumenSku
        '
        Me.gvResumenSku.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.gvResumenSku.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGrupo, Me.colAtributo, Me.colValor})
        Me.gvResumenSku.FixedLineWidth = 1
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.White
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Appearance.Options.UseTextOptions = True
        StyleFormatCondition1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colValor
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Expression = "[VALOR]='SUSPENDIDO'"
        StyleFormatCondition1.Value1 = "SUSPENDIDO"
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Lime
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.White
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colValor
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "ACTIVO"
        Me.gvResumenSku.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.gvResumenSku.GridControl = Me.GridPrincipal
        Me.gvResumenSku.GroupCount = 1
        Me.gvResumenSku.GroupRowHeight = 10
        Me.gvResumenSku.Name = "gvResumenSku"
        Me.gvResumenSku.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvResumenSku.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvResumenSku.OptionsBehavior.AutoExpandAllGroups = True
        Me.gvResumenSku.OptionsBehavior.Editable = False
        Me.gvResumenSku.OptionsBehavior.ReadOnly = True
        Me.gvResumenSku.OptionsCustomization.AllowColumnMoving = False
        Me.gvResumenSku.OptionsCustomization.AllowColumnResizing = False
        Me.gvResumenSku.OptionsCustomization.AllowFilter = False
        Me.gvResumenSku.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvResumenSku.OptionsCustomization.AllowSort = False
        Me.gvResumenSku.OptionsDetail.AllowExpandEmptyDetails = True
        Me.gvResumenSku.OptionsLayout.Columns.AddNewColumns = False
        Me.gvResumenSku.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvResumenSku.OptionsSelection.MultiSelect = True
        Me.gvResumenSku.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.gvResumenSku.OptionsView.EnableAppearanceOddRow = True
        Me.gvResumenSku.OptionsView.ShowColumnHeaders = False
        Me.gvResumenSku.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvResumenSku.OptionsView.ShowGroupPanel = False
        Me.gvResumenSku.RowHeight = 10
        Me.gvResumenSku.RowSeparatorHeight = 5
        Me.gvResumenSku.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colGrupo, DevExpress.Data.ColumnSortOrder.Descending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colAtributo, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colGrupo
        '
        Me.colGrupo.Caption = "Grupo"
        Me.colGrupo.FieldName = "GRUPO"
        Me.colGrupo.Name = "colGrupo"
        Me.colGrupo.OptionsColumn.AllowEdit = False
        Me.colGrupo.OptionsColumn.ReadOnly = True
        Me.colGrupo.Visible = True
        Me.colGrupo.VisibleIndex = 0
        Me.colGrupo.Width = 180
        '
        'colAtributo
        '
        Me.colAtributo.Caption = "Descripcion"
        Me.colAtributo.FieldName = "ATRIBUTO"
        Me.colAtributo.Name = "colAtributo"
        Me.colAtributo.OptionsColumn.AllowEdit = False
        Me.colAtributo.OptionsColumn.ReadOnly = True
        Me.colAtributo.ToolTip = "Atributo"
        Me.colAtributo.Visible = True
        Me.colAtributo.VisibleIndex = 0
        Me.colAtributo.Width = 150
        '
        'GridSecundario
        '
        Me.GridSecundario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridSecundario.Location = New System.Drawing.Point(0, 0)
        Me.GridSecundario.MainView = Me.GridView1
        Me.GridSecundario.Name = "GridSecundario"
        Me.GridSecundario.Size = New System.Drawing.Size(845, 463)
        Me.GridSecundario.TabIndex = 2
        Me.GridSecundario.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
        Me.GridView1.FixedLineWidth = 1
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.White
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.Appearance.Options.UseFont = True
        StyleFormatCondition3.Appearance.Options.UseForeColor = True
        StyleFormatCondition3.Appearance.Options.UseTextOptions = True
        StyleFormatCondition3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition3.Expression = "[ALERTA_2] > 0"
        StyleFormatCondition3.Value1 = 0
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition3})
        Me.GridView1.GridControl = Me.GridSecundario
        Me.GridView1.GroupCount = 2
        Me.GridView1.GroupRowHeight = 10
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AutoExpandAllGroups = True
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsCustomization.AllowColumnMoving = False
        Me.GridView1.OptionsCustomization.AllowColumnResizing = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowQuickHideColumns = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GridView1.OptionsLayout.Columns.AddNewColumns = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowColumnHeaders = False
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.RowHeight = 10
        Me.GridView1.RowSeparatorHeight = 5
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn4, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Zona"
        Me.GridColumn4.FieldName = "ZONA"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Grupo"
        Me.GridColumn1.FieldName = "GRUPO"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 180
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Descripcion"
        Me.GridColumn2.FieldName = "ATRIBUTO"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.ToolTip = "Atributo"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 150
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridColumn3.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Valor"
        Me.GridColumn3.FieldName = "VALOR"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.ToolTip = "Valor de taributo o detalle del Sku"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 300
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.lytSkuGrupoCambioMasivo, Me.LayoutControlGroup3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1306, 679)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlItem2.Control = Me.lblSku
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(70, 50)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1286, 59)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'lytSkuGrupoCambioMasivo
        '
        Me.lytSkuGrupoCambioMasivo.CustomizationFormText = "Cambio Masivo de Skus"
        Me.lytSkuGrupoCambioMasivo.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.lytSkuMuestra, Me.lytSkuParecidos, Me.LayoutControlItem7, Me.LayoutControlItem9, Me.LayoutControlItem11, Me.LayoutControlItem6})
        Me.lytSkuGrupoCambioMasivo.Location = New System.Drawing.Point(0, 59)
        Me.lytSkuGrupoCambioMasivo.Name = "lytSkuGrupoCambioMasivo"
        Me.lytSkuGrupoCambioMasivo.Size = New System.Drawing.Size(1286, 73)
        Me.lytSkuGrupoCambioMasivo.Text = "Cambio Masivo de Skus"
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmbSkuCambioMasivo
        Me.LayoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(300, 50)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(154, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(20, 20, 2, 0)
        Me.LayoutControlItem5.Size = New System.Drawing.Size(290, 30)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "Cambio masivo de Skus"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'lytSkuMuestra
        '
        Me.lytSkuMuestra.CustomizationFormText = "lytSkuMuestra"
        Me.lytSkuMuestra.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lblSkuMuestra, Me.LayoutControlItem10})
        Me.lytSkuMuestra.Location = New System.Drawing.Point(708, 0)
        Me.lytSkuMuestra.Name = "lytSkuMuestra"
        Me.lytSkuMuestra.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.lytSkuMuestra.Size = New System.Drawing.Size(216, 30)
        Me.lytSkuMuestra.Text = "lytSkuMuestra"
        Me.lytSkuMuestra.TextVisible = False
        Me.lytSkuMuestra.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'lblSkuMuestra
        '
        Me.lblSkuMuestra.AllowHotTrack = False
        Me.lblSkuMuestra.CustomizationFormText = "de la muestra"
        Me.lblSkuMuestra.Location = New System.Drawing.Point(110, 0)
        Me.lblSkuMuestra.MaxSize = New System.Drawing.Size(100, 17)
        Me.lblSkuMuestra.MinSize = New System.Drawing.Size(100, 17)
        Me.lblSkuMuestra.Name = "lblSkuMuestra"
        Me.lblSkuMuestra.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 2, 2, 2)
        Me.lblSkuMuestra.Size = New System.Drawing.Size(100, 24)
        Me.lblSkuMuestra.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lblSkuMuestra.Text = "% de la muestra"
        Me.lblSkuMuestra.TextSize = New System.Drawing.Size(79, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem10.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem10.Control = Me.txtSkuPesoMuestra
        Me.LayoutControlItem10.CustomizationFormText = "En el"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(131, 24)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(110, 24)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
        Me.LayoutControlItem10.Size = New System.Drawing.Size(110, 24)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.Text = "En el"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(79, 13)
        '
        'lytSkuParecidos
        '
        Me.lytSkuParecidos.Control = Me.lookSkuReemplazo
        Me.lytSkuParecidos.CustomizationFormText = "Por "
        Me.lytSkuParecidos.Location = New System.Drawing.Point(399, 0)
        Me.lytSkuParecidos.Name = "lytSkuParecidos"
        Me.lytSkuParecidos.Size = New System.Drawing.Size(309, 30)
        Me.lytSkuParecidos.Spacing = New DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 0)
        Me.lytSkuParecidos.Text = "Por "
        Me.lytSkuParecidos.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.lytSkuParecidos.TextSize = New System.Drawing.Size(30, 13)
        Me.lytSkuParecidos.TextToControlDistance = 1
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.lblSkuMensajeAdvertencia
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(924, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(173, 30)
        Me.LayoutControlItem7.Text = "LayoutControlItem7"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextToControlDistance = 0
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmbSkuANivel
        Me.LayoutControlItem9.CustomizationFormText = "A nivel "
        Me.LayoutControlItem9.Location = New System.Drawing.Point(290, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(109, 30)
        Me.LayoutControlItem9.Text = "A nivel "
        Me.LayoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(50, 20)
        Me.LayoutControlItem9.TextToControlDistance = 5
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.btnSkuTodos
        Me.LayoutControlItem11.ControlAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(1180, 0)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(120, 26)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(82, 26)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
        Me.LayoutControlItem11.Size = New System.Drawing.Size(82, 30)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.Text = "LayoutControlItem11"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextToControlDistance = 0
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.btnSkuContinuar
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(1097, 0)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(100, 26)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(83, 26)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 2, 2)
        Me.LayoutControlItem6.Size = New System.Drawing.Size(83, 30)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "LayoutControlItem6"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "Propiedades y Estadisticas"
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem4, Me.LayoutControlItem3})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 132)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(1286, 527)
        Me.LayoutControlGroup3.Text = "Propiedades y Estadisticas"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.SplitContainerControl1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 17)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1262, 467)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.LabelControl2
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(300, 0)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(70, 17)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(962, 17)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Right
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.LabelControl1
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(300, 17)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(70, 17)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(300, 17)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'frmSkuEstadistica
        '
        Me.Appearance.Image = Global.CCRCCV2.My.Resources.Resources.icos_09_sku
        Me.Appearance.Options.UseImage = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1306, 679)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSkuEstadistica"
        Me.Text = "Sku:"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cmbSkuANivel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSkuMensajeAdvertencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookSkuReemplazo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSkuPesoMuestra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSkuCambioMasivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GridPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvResumenSku, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridSecundario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytSkuGrupoCambioMasivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytSkuMuestra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSkuMuestra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytSkuParecidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents lblSku As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridPrincipal As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvResumenSku As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colGrupo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAtributo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridSecundario As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbSkuCambioMasivo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnSkuContinuar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lytSkuGrupoCambioMasivo As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtSkuPesoMuestra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblSkuMuestra As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents lytSkuMuestra As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lookSkuReemplazo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lytSkuParecidos As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblSkuMensajeAdvertencia As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmbSkuANivel As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnSkuTodos As DevExpress.XtraEditors.CheckButton
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
End Class
