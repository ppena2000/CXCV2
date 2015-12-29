<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRangos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRangos))
        Me.gc_RU = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.dgRangos = New DevExpress.XtraGrid.GridControl
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.bdInicio = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.gc_IdRangos = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gc_IdMedicionZonaCanal = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gc_IdIndicador = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gc_Zona = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gc_TituloIndicador = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gc_Canal = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gc_CodigoProducto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.bdVentas = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.gc_VTA_PMinimo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gc_VTA_PMaximo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gc_VTA_FVariacion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gc_VTA_Referencia = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.gc_VTA_Semaforo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.bdCompras = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.gc_CMP_PMinimo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gc_CMP_PMaximo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gc_CMP_FVariacion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gc_CMP_Referencia = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gc_CMP_Semaforo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.bdInventarios = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.gc_INV_PMinimo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gc_INV_PMaximo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gc_INV_FVariacion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gc_INV_Semaforo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gc_INV_Referencia = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.bdPrecios = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.gc_PRE_PMinimo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gc_PRE_PMaximo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gc_PRE_FVariacion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gc_PRE_Referencia = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gc_PRE_Semaforo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.bdRegistros = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.gc_REG_PMinimo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gc_REG_PMaximo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gc_REG_FVariacion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gc_REG_Referencia = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gc_REG_Semaforo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.bdFinal = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.gc_Fecha = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gc_Semaforo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl
        Me.LayoutControl3 = New DevExpress.XtraLayout.LayoutControl
        Me.chkSemaforo = New DevExpress.XtraEditors.CheckEdit
        Me.cboReferencia = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtFactorVariacion = New DevExpress.XtraEditors.TextEdit
        Me.sbCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.chkGRVariable = New DevExpress.XtraEditors.CheckedListBoxControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.sbLimpia = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.rcRangos = New DevExpress.XtraEditors.RangeControl
        Me.NumericRangeControlClient1 = New DevExpress.XtraEditors.NumericRangeControlClient
        Me.sbAplica = New DevExpress.XtraEditors.SimpleButton
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem
        Me.lblMinimo = New DevExpress.XtraLayout.SimpleLabelItem
        Me.lblMaximo = New DevExpress.XtraLayout.SimpleLabelItem
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem
        Me.GridSplitContainer1 = New DevExpress.XtraGrid.GridSplitContainer
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.lblTituloRangos = New DevExpress.XtraLayout.SimpleLabelItem
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton9 = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.CheckedListBoxControl1 = New DevExpress.XtraEditors.CheckedListBoxControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
        CType(Me.dgRangos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl3.SuspendLayout()
        CType(Me.chkSemaforo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboReferencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFactorVariacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkGRVariable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMinimo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMaximo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridSplitContainer1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTituloRangos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckedListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gc_RU
        '
        Me.gc_RU.Caption = "RU"
        Me.gc_RU.FieldName = "RU"
        Me.gc_RU.Name = "gc_RU"
        Me.gc_RU.OptionsColumn.AllowMove = False
        Me.gc_RU.Width = 46
        '
        'dgRangos
        '
        Me.dgRangos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgRangos.Location = New System.Drawing.Point(0, 0)
        Me.dgRangos.MainView = Me.BandedGridView1
        Me.dgRangos.Name = "dgRangos"
        Me.dgRangos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1})
        Me.dgRangos.Size = New System.Drawing.Size(682, 644)
        Me.dgRangos.TabIndex = 0
        Me.dgRangos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BandedGridView1})
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Appearance.OddRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BandedGridView1.Appearance.OddRow.Options.UseBackColor = True
        Me.BandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.bdInicio, Me.bdVentas, Me.bdCompras, Me.bdInventarios, Me.bdPrecios, Me.bdRegistros, Me.bdFinal})
        Me.BandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.gc_IdRangos, Me.gc_IdMedicionZonaCanal, Me.gc_IdIndicador, Me.gc_Zona, Me.gc_TituloIndicador, Me.gc_Canal, Me.gc_CodigoProducto, Me.gc_CMP_PMinimo, Me.gc_CMP_PMaximo, Me.gc_CMP_FVariacion, Me.gc_CMP_Referencia, Me.gc_CMP_Semaforo, Me.gc_INV_PMinimo, Me.gc_INV_PMaximo, Me.gc_INV_FVariacion, Me.gc_INV_Referencia, Me.gc_INV_Semaforo, Me.gc_VTA_PMinimo, Me.gc_VTA_PMaximo, Me.gc_VTA_FVariacion, Me.gc_VTA_Referencia, Me.gc_VTA_Semaforo, Me.gc_PRE_PMinimo, Me.gc_PRE_PMaximo, Me.gc_PRE_FVariacion, Me.gc_PRE_Referencia, Me.gc_PRE_Semaforo, Me.gc_REG_PMinimo, Me.gc_REG_PMaximo, Me.gc_REG_FVariacion, Me.gc_REG_Referencia, Me.gc_REG_Semaforo, Me.gc_Semaforo, Me.gc_RU, Me.gc_Fecha})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.gc_RU
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = CType(1, Short)
        Me.BandedGridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.BandedGridView1.GridControl = Me.dgRangos
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.BandedGridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.BandedGridView1.OptionsBehavior.AutoExpandAllGroups = True
        Me.BandedGridView1.OptionsMenu.EnableColumnMenu = False
        Me.BandedGridView1.OptionsMenu.EnableFooterMenu = False
        Me.BandedGridView1.OptionsSelection.MultiSelect = True
        Me.BandedGridView1.OptionsView.ColumnAutoWidth = False
        Me.BandedGridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.BandedGridView1.OptionsView.EnableAppearanceOddRow = True
        Me.BandedGridView1.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.SmartTag
        Me.BandedGridView1.OptionsView.ShowAutoFilterRow = True
        Me.BandedGridView1.OptionsView.ShowGroupPanel = False
        '
        'bdInicio
        '
        Me.bdInicio.Columns.Add(Me.gc_IdRangos)
        Me.bdInicio.Columns.Add(Me.gc_IdMedicionZonaCanal)
        Me.bdInicio.Columns.Add(Me.gc_IdIndicador)
        Me.bdInicio.Columns.Add(Me.gc_Zona)
        Me.bdInicio.Columns.Add(Me.gc_TituloIndicador)
        Me.bdInicio.Columns.Add(Me.gc_Canal)
        Me.bdInicio.Columns.Add(Me.gc_CodigoProducto)
        Me.bdInicio.Name = "bdInicio"
        Me.bdInicio.Width = 457
        '
        'gc_IdRangos
        '
        Me.gc_IdRangos.Caption = "IdRangos"
        Me.gc_IdRangos.FieldName = "IdRangos"
        Me.gc_IdRangos.Name = "gc_IdRangos"
        Me.gc_IdRangos.OptionsColumn.AllowMove = False
        Me.gc_IdRangos.Width = 39
        '
        'gc_IdMedicionZonaCanal
        '
        Me.gc_IdMedicionZonaCanal.Caption = "IdMedicionZonaCanal"
        Me.gc_IdMedicionZonaCanal.FieldName = "IdMedicionZonaCanal"
        Me.gc_IdMedicionZonaCanal.Name = "gc_IdMedicionZonaCanal"
        Me.gc_IdMedicionZonaCanal.OptionsColumn.AllowMove = False
        Me.gc_IdMedicionZonaCanal.Width = 49
        '
        'gc_IdIndicador
        '
        Me.gc_IdIndicador.Caption = "Id"
        Me.gc_IdIndicador.FieldName = "IdIndicador"
        Me.gc_IdIndicador.Name = "gc_IdIndicador"
        Me.gc_IdIndicador.OptionsColumn.AllowMove = False
        Me.gc_IdIndicador.Visible = True
        Me.gc_IdIndicador.Width = 49
        '
        'gc_Zona
        '
        Me.gc_Zona.Caption = "Zona"
        Me.gc_Zona.FieldName = "Zona"
        Me.gc_Zona.Name = "gc_Zona"
        Me.gc_Zona.OptionsColumn.AllowEdit = False
        Me.gc_Zona.OptionsColumn.AllowMove = False
        Me.gc_Zona.OptionsColumn.ReadOnly = True
        Me.gc_Zona.Visible = True
        Me.gc_Zona.Width = 122
        '
        'gc_TituloIndicador
        '
        Me.gc_TituloIndicador.Caption = "Indicador"
        Me.gc_TituloIndicador.FieldName = "TituloIndicador"
        Me.gc_TituloIndicador.Name = "gc_TituloIndicador"
        Me.gc_TituloIndicador.OptionsColumn.AllowEdit = False
        Me.gc_TituloIndicador.OptionsColumn.AllowMove = False
        Me.gc_TituloIndicador.OptionsColumn.ReadOnly = True
        Me.gc_TituloIndicador.Visible = True
        Me.gc_TituloIndicador.Width = 177
        '
        'gc_Canal
        '
        Me.gc_Canal.Caption = "Canal"
        Me.gc_Canal.FieldName = "Canal"
        Me.gc_Canal.Name = "gc_Canal"
        Me.gc_Canal.OptionsColumn.AllowEdit = False
        Me.gc_Canal.OptionsColumn.AllowMove = False
        Me.gc_Canal.OptionsColumn.ReadOnly = True
        Me.gc_Canal.Visible = True
        Me.gc_Canal.Width = 109
        '
        'gc_CodigoProducto
        '
        Me.gc_CodigoProducto.Caption = "CodigoProducto"
        Me.gc_CodigoProducto.FieldName = "CodigoProducto"
        Me.gc_CodigoProducto.Name = "gc_CodigoProducto"
        Me.gc_CodigoProducto.OptionsColumn.AllowEdit = False
        Me.gc_CodigoProducto.OptionsColumn.AllowMove = False
        Me.gc_CodigoProducto.OptionsColumn.ReadOnly = True
        Me.gc_CodigoProducto.Width = 52
        '
        'bdVentas
        '
        Me.bdVentas.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bdVentas.AppearanceHeader.Options.UseFont = True
        Me.bdVentas.AppearanceHeader.Options.UseTextOptions = True
        Me.bdVentas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bdVentas.Caption = "Ventas"
        Me.bdVentas.Columns.Add(Me.gc_VTA_PMinimo)
        Me.bdVentas.Columns.Add(Me.gc_VTA_PMaximo)
        Me.bdVentas.Columns.Add(Me.gc_VTA_FVariacion)
        Me.bdVentas.Columns.Add(Me.gc_VTA_Referencia)
        Me.bdVentas.Columns.Add(Me.gc_VTA_Semaforo)
        Me.bdVentas.Name = "bdVentas"
        Me.bdVentas.OptionsBand.FixedWidth = True
        Me.bdVentas.ToolTip = "VTA"
        Me.bdVentas.Width = 230
        '
        'gc_VTA_PMinimo
        '
        Me.gc_VTA_PMinimo.Caption = "Minimo"
        Me.gc_VTA_PMinimo.DisplayFormat.FormatString = "p0"
        Me.gc_VTA_PMinimo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gc_VTA_PMinimo.FieldName = "VTA_PMinimo"
        Me.gc_VTA_PMinimo.Name = "gc_VTA_PMinimo"
        Me.gc_VTA_PMinimo.OptionsColumn.AllowMove = False
        Me.gc_VTA_PMinimo.Visible = True
        Me.gc_VTA_PMinimo.Width = 60
        '
        'gc_VTA_PMaximo
        '
        Me.gc_VTA_PMaximo.Caption = "Maximo"
        Me.gc_VTA_PMaximo.DisplayFormat.FormatString = "p0"
        Me.gc_VTA_PMaximo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gc_VTA_PMaximo.FieldName = "VTA_PMaximo"
        Me.gc_VTA_PMaximo.Name = "gc_VTA_PMaximo"
        Me.gc_VTA_PMaximo.OptionsColumn.AllowMove = False
        Me.gc_VTA_PMaximo.Visible = True
        Me.gc_VTA_PMaximo.Width = 60
        '
        'gc_VTA_FVariacion
        '
        Me.gc_VTA_FVariacion.Caption = "Variacion"
        Me.gc_VTA_FVariacion.FieldName = "VTA_FVariacion"
        Me.gc_VTA_FVariacion.Name = "gc_VTA_FVariacion"
        Me.gc_VTA_FVariacion.OptionsColumn.AllowMove = False
        Me.gc_VTA_FVariacion.Visible = True
        Me.gc_VTA_FVariacion.Width = 60
        '
        'gc_VTA_Referencia
        '
        Me.gc_VTA_Referencia.Caption = "Referencia"
        Me.gc_VTA_Referencia.ColumnEdit = Me.RepositoryItemComboBox1
        Me.gc_VTA_Referencia.FieldName = "VTA_Referencia"
        Me.gc_VTA_Referencia.Name = "gc_VTA_Referencia"
        Me.gc_VTA_Referencia.OptionsColumn.AllowMove = False
        Me.gc_VTA_Referencia.Width = 71
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'gc_VTA_Semaforo
        '
        Me.gc_VTA_Semaforo.Caption = "Semaforo"
        Me.gc_VTA_Semaforo.FieldName = "VTA_Semaforo"
        Me.gc_VTA_Semaforo.Name = "gc_VTA_Semaforo"
        Me.gc_VTA_Semaforo.OptionsColumn.AllowMove = False
        Me.gc_VTA_Semaforo.Visible = True
        Me.gc_VTA_Semaforo.Width = 50
        '
        'bdCompras
        '
        Me.bdCompras.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bdCompras.AppearanceHeader.Options.UseFont = True
        Me.bdCompras.AppearanceHeader.Options.UseTextOptions = True
        Me.bdCompras.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bdCompras.Caption = "Compras"
        Me.bdCompras.Columns.Add(Me.gc_CMP_PMinimo)
        Me.bdCompras.Columns.Add(Me.gc_CMP_PMaximo)
        Me.bdCompras.Columns.Add(Me.gc_CMP_FVariacion)
        Me.bdCompras.Columns.Add(Me.gc_CMP_Referencia)
        Me.bdCompras.Columns.Add(Me.gc_CMP_Semaforo)
        Me.bdCompras.Name = "bdCompras"
        Me.bdCompras.OptionsBand.FixedWidth = True
        Me.bdCompras.ToolTip = "CMP"
        Me.bdCompras.Width = 227
        '
        'gc_CMP_PMinimo
        '
        Me.gc_CMP_PMinimo.Caption = "Minimo"
        Me.gc_CMP_PMinimo.DisplayFormat.FormatString = "p0"
        Me.gc_CMP_PMinimo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gc_CMP_PMinimo.FieldName = "CMP_PMinimo"
        Me.gc_CMP_PMinimo.Name = "gc_CMP_PMinimo"
        Me.gc_CMP_PMinimo.OptionsColumn.AllowMove = False
        Me.gc_CMP_PMinimo.OptionsColumn.AllowShowHide = False
        Me.gc_CMP_PMinimo.Visible = True
        Me.gc_CMP_PMinimo.Width = 59
        '
        'gc_CMP_PMaximo
        '
        Me.gc_CMP_PMaximo.Caption = "Maximo"
        Me.gc_CMP_PMaximo.DisplayFormat.FormatString = "p0"
        Me.gc_CMP_PMaximo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gc_CMP_PMaximo.FieldName = "CMP_PMaximo"
        Me.gc_CMP_PMaximo.Name = "gc_CMP_PMaximo"
        Me.gc_CMP_PMaximo.OptionsColumn.AllowMove = False
        Me.gc_CMP_PMaximo.OptionsColumn.AllowShowHide = False
        Me.gc_CMP_PMaximo.Visible = True
        Me.gc_CMP_PMaximo.Width = 59
        '
        'gc_CMP_FVariacion
        '
        Me.gc_CMP_FVariacion.Caption = "Variacion"
        Me.gc_CMP_FVariacion.FieldName = "CMP_FVariacion"
        Me.gc_CMP_FVariacion.Name = "gc_CMP_FVariacion"
        Me.gc_CMP_FVariacion.OptionsColumn.AllowMove = False
        Me.gc_CMP_FVariacion.OptionsColumn.AllowShowHide = False
        Me.gc_CMP_FVariacion.Visible = True
        Me.gc_CMP_FVariacion.Width = 59
        '
        'gc_CMP_Referencia
        '
        Me.gc_CMP_Referencia.Caption = "Referencia"
        Me.gc_CMP_Referencia.ColumnEdit = Me.RepositoryItemComboBox1
        Me.gc_CMP_Referencia.FieldName = "CMP_Referencia"
        Me.gc_CMP_Referencia.Name = "gc_CMP_Referencia"
        Me.gc_CMP_Referencia.OptionsColumn.AllowMove = False
        Me.gc_CMP_Referencia.OptionsColumn.AllowShowHide = False
        Me.gc_CMP_Referencia.Width = 73
        '
        'gc_CMP_Semaforo
        '
        Me.gc_CMP_Semaforo.Caption = "Semaforo"
        Me.gc_CMP_Semaforo.FieldName = "CMP_Semaforo"
        Me.gc_CMP_Semaforo.Name = "gc_CMP_Semaforo"
        Me.gc_CMP_Semaforo.OptionsColumn.AllowMove = False
        Me.gc_CMP_Semaforo.OptionsColumn.AllowShowHide = False
        Me.gc_CMP_Semaforo.Visible = True
        Me.gc_CMP_Semaforo.Width = 50
        '
        'bdInventarios
        '
        Me.bdInventarios.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bdInventarios.AppearanceHeader.Options.UseFont = True
        Me.bdInventarios.AppearanceHeader.Options.UseTextOptions = True
        Me.bdInventarios.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bdInventarios.Caption = "Inventarios"
        Me.bdInventarios.Columns.Add(Me.gc_INV_PMinimo)
        Me.bdInventarios.Columns.Add(Me.gc_INV_PMaximo)
        Me.bdInventarios.Columns.Add(Me.gc_INV_FVariacion)
        Me.bdInventarios.Columns.Add(Me.gc_INV_Semaforo)
        Me.bdInventarios.Columns.Add(Me.gc_INV_Referencia)
        Me.bdInventarios.Name = "bdInventarios"
        Me.bdInventarios.OptionsBand.FixedWidth = True
        Me.bdInventarios.ToolTip = "INV"
        Me.bdInventarios.Width = 237
        '
        'gc_INV_PMinimo
        '
        Me.gc_INV_PMinimo.Caption = "Minimo"
        Me.gc_INV_PMinimo.DisplayFormat.FormatString = "p0"
        Me.gc_INV_PMinimo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gc_INV_PMinimo.FieldName = "INV_PMinimo"
        Me.gc_INV_PMinimo.Name = "gc_INV_PMinimo"
        Me.gc_INV_PMinimo.OptionsColumn.AllowMove = False
        Me.gc_INV_PMinimo.Visible = True
        Me.gc_INV_PMinimo.Width = 59
        '
        'gc_INV_PMaximo
        '
        Me.gc_INV_PMaximo.Caption = "Maximo"
        Me.gc_INV_PMaximo.DisplayFormat.FormatString = "p0"
        Me.gc_INV_PMaximo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gc_INV_PMaximo.FieldName = "INV_PMaximo"
        Me.gc_INV_PMaximo.Name = "gc_INV_PMaximo"
        Me.gc_INV_PMaximo.OptionsColumn.AllowMove = False
        Me.gc_INV_PMaximo.Visible = True
        Me.gc_INV_PMaximo.Width = 59
        '
        'gc_INV_FVariacion
        '
        Me.gc_INV_FVariacion.Caption = "Variacion"
        Me.gc_INV_FVariacion.FieldName = "INV_FVariacion"
        Me.gc_INV_FVariacion.Name = "gc_INV_FVariacion"
        Me.gc_INV_FVariacion.OptionsColumn.AllowMove = False
        Me.gc_INV_FVariacion.Visible = True
        Me.gc_INV_FVariacion.Width = 59
        '
        'gc_INV_Semaforo
        '
        Me.gc_INV_Semaforo.Caption = "Semaforo"
        Me.gc_INV_Semaforo.FieldName = "INV_Semaforo"
        Me.gc_INV_Semaforo.Name = "gc_INV_Semaforo"
        Me.gc_INV_Semaforo.OptionsColumn.AllowMove = False
        Me.gc_INV_Semaforo.Visible = True
        Me.gc_INV_Semaforo.Width = 60
        '
        'gc_INV_Referencia
        '
        Me.gc_INV_Referencia.Caption = "Referencia"
        Me.gc_INV_Referencia.FieldName = "INV_Referencia"
        Me.gc_INV_Referencia.Name = "gc_INV_Referencia"
        Me.gc_INV_Referencia.OptionsColumn.AllowMove = False
        Me.gc_INV_Referencia.Width = 88
        '
        'bdPrecios
        '
        Me.bdPrecios.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bdPrecios.AppearanceHeader.Options.UseFont = True
        Me.bdPrecios.AppearanceHeader.Options.UseTextOptions = True
        Me.bdPrecios.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bdPrecios.Caption = "Precios"
        Me.bdPrecios.Columns.Add(Me.gc_PRE_PMinimo)
        Me.bdPrecios.Columns.Add(Me.gc_PRE_PMaximo)
        Me.bdPrecios.Columns.Add(Me.gc_PRE_FVariacion)
        Me.bdPrecios.Columns.Add(Me.gc_PRE_Referencia)
        Me.bdPrecios.Columns.Add(Me.gc_PRE_Semaforo)
        Me.bdPrecios.Name = "bdPrecios"
        Me.bdPrecios.OptionsBand.FixedWidth = True
        Me.bdPrecios.ToolTip = "PRE"
        Me.bdPrecios.Width = 209
        '
        'gc_PRE_PMinimo
        '
        Me.gc_PRE_PMinimo.Caption = "Minimo"
        Me.gc_PRE_PMinimo.DisplayFormat.FormatString = "p0"
        Me.gc_PRE_PMinimo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gc_PRE_PMinimo.FieldName = "PRE_PMinimo"
        Me.gc_PRE_PMinimo.Name = "gc_PRE_PMinimo"
        Me.gc_PRE_PMinimo.OptionsColumn.AllowMove = False
        Me.gc_PRE_PMinimo.Visible = True
        Me.gc_PRE_PMinimo.Width = 53
        '
        'gc_PRE_PMaximo
        '
        Me.gc_PRE_PMaximo.Caption = "Maximo"
        Me.gc_PRE_PMaximo.DisplayFormat.FormatString = "p0"
        Me.gc_PRE_PMaximo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gc_PRE_PMaximo.FieldName = "PRE_PMaximo"
        Me.gc_PRE_PMaximo.Name = "gc_PRE_PMaximo"
        Me.gc_PRE_PMaximo.OptionsColumn.AllowMove = False
        Me.gc_PRE_PMaximo.Visible = True
        Me.gc_PRE_PMaximo.Width = 53
        '
        'gc_PRE_FVariacion
        '
        Me.gc_PRE_FVariacion.Caption = "Variacion"
        Me.gc_PRE_FVariacion.FieldName = "PRE_FVariacion"
        Me.gc_PRE_FVariacion.Name = "gc_PRE_FVariacion"
        Me.gc_PRE_FVariacion.OptionsColumn.AllowMove = False
        Me.gc_PRE_FVariacion.Visible = True
        Me.gc_PRE_FVariacion.Width = 53
        '
        'gc_PRE_Referencia
        '
        Me.gc_PRE_Referencia.Caption = "Referencia"
        Me.gc_PRE_Referencia.FieldName = "PRE_Referencia"
        Me.gc_PRE_Referencia.Name = "gc_PRE_Referencia"
        Me.gc_PRE_Referencia.OptionsColumn.AllowMove = False
        Me.gc_PRE_Referencia.Width = 69
        '
        'gc_PRE_Semaforo
        '
        Me.gc_PRE_Semaforo.Caption = "Semaforo"
        Me.gc_PRE_Semaforo.FieldName = "PRE_Semaforo"
        Me.gc_PRE_Semaforo.Name = "gc_PRE_Semaforo"
        Me.gc_PRE_Semaforo.OptionsColumn.AllowMove = False
        Me.gc_PRE_Semaforo.Visible = True
        Me.gc_PRE_Semaforo.Width = 50
        '
        'bdRegistros
        '
        Me.bdRegistros.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bdRegistros.AppearanceHeader.Options.UseFont = True
        Me.bdRegistros.AppearanceHeader.Options.UseTextOptions = True
        Me.bdRegistros.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bdRegistros.Caption = "Registros"
        Me.bdRegistros.Columns.Add(Me.gc_REG_PMinimo)
        Me.bdRegistros.Columns.Add(Me.gc_REG_PMaximo)
        Me.bdRegistros.Columns.Add(Me.gc_REG_FVariacion)
        Me.bdRegistros.Columns.Add(Me.gc_REG_Referencia)
        Me.bdRegistros.Columns.Add(Me.gc_REG_Semaforo)
        Me.bdRegistros.Name = "bdRegistros"
        Me.bdRegistros.OptionsBand.FixedWidth = True
        Me.bdRegistros.ToolTip = "REG"
        Me.bdRegistros.Width = 218
        '
        'gc_REG_PMinimo
        '
        Me.gc_REG_PMinimo.Caption = "Minimo"
        Me.gc_REG_PMinimo.DisplayFormat.FormatString = "p0"
        Me.gc_REG_PMinimo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gc_REG_PMinimo.FieldName = "REG_PMinimo"
        Me.gc_REG_PMinimo.Name = "gc_REG_PMinimo"
        Me.gc_REG_PMinimo.OptionsColumn.AllowMove = False
        Me.gc_REG_PMinimo.Visible = True
        Me.gc_REG_PMinimo.Width = 56
        '
        'gc_REG_PMaximo
        '
        Me.gc_REG_PMaximo.Caption = "Maximo"
        Me.gc_REG_PMaximo.DisplayFormat.FormatString = "p0"
        Me.gc_REG_PMaximo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gc_REG_PMaximo.FieldName = "REG_PMaximo"
        Me.gc_REG_PMaximo.Name = "gc_REG_PMaximo"
        Me.gc_REG_PMaximo.OptionsColumn.AllowMove = False
        Me.gc_REG_PMaximo.Visible = True
        Me.gc_REG_PMaximo.Width = 56
        '
        'gc_REG_FVariacion
        '
        Me.gc_REG_FVariacion.Caption = "Variacion"
        Me.gc_REG_FVariacion.FieldName = "REG_FVariacion"
        Me.gc_REG_FVariacion.Name = "gc_REG_FVariacion"
        Me.gc_REG_FVariacion.OptionsColumn.AllowMove = False
        Me.gc_REG_FVariacion.Visible = True
        Me.gc_REG_FVariacion.Width = 56
        '
        'gc_REG_Referencia
        '
        Me.gc_REG_Referencia.Caption = "Referencia"
        Me.gc_REG_Referencia.FieldName = "REG_Referencia"
        Me.gc_REG_Referencia.Name = "gc_REG_Referencia"
        Me.gc_REG_Referencia.OptionsColumn.AllowMove = False
        Me.gc_REG_Referencia.Width = 56
        '
        'gc_REG_Semaforo
        '
        Me.gc_REG_Semaforo.Caption = "Semaforo"
        Me.gc_REG_Semaforo.FieldName = "REG_Semaforo"
        Me.gc_REG_Semaforo.Name = "gc_REG_Semaforo"
        Me.gc_REG_Semaforo.OptionsColumn.AllowMove = False
        Me.gc_REG_Semaforo.Visible = True
        Me.gc_REG_Semaforo.Width = 50
        '
        'bdFinal
        '
        Me.bdFinal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.bdFinal.AppearanceHeader.Options.UseFont = True
        Me.bdFinal.AppearanceHeader.Options.UseTextOptions = True
        Me.bdFinal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bdFinal.Caption = "Total"
        Me.bdFinal.Columns.Add(Me.gc_Fecha)
        Me.bdFinal.Columns.Add(Me.gc_Semaforo)
        Me.bdFinal.Columns.Add(Me.gc_RU)
        Me.bdFinal.Name = "bdFinal"
        Me.bdFinal.OptionsBand.FixedWidth = True
        Me.bdFinal.Width = 50
        '
        'gc_Fecha
        '
        Me.gc_Fecha.Caption = "Fecha"
        Me.gc_Fecha.FieldName = "Fecha "
        Me.gc_Fecha.Name = "gc_Fecha"
        Me.gc_Fecha.OptionsColumn.AllowMove = False
        Me.gc_Fecha.Width = 58
        '
        'gc_Semaforo
        '
        Me.gc_Semaforo.Caption = "Semaforo"
        Me.gc_Semaforo.FieldName = "Semaforo"
        Me.gc_Semaforo.Name = "gc_Semaforo"
        Me.gc_Semaforo.OptionsColumn.AllowMove = False
        Me.gc_Semaforo.Visible = True
        Me.gc_Semaforo.Width = 50
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.LayoutControl3)
        Me.LayoutControl1.Controls.Add(Me.GridSplitContainer1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(290, 386, 250, 350)
        Me.LayoutControl1.OptionsView.UseDefaultDragAndDropRendering = False
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1020, 736)
        Me.LayoutControl1.TabIndex = 7
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LayoutControl3
        '
        Me.LayoutControl3.Controls.Add(Me.chkSemaforo)
        Me.LayoutControl3.Controls.Add(Me.cboReferencia)
        Me.LayoutControl3.Controls.Add(Me.txtFactorVariacion)
        Me.LayoutControl3.Controls.Add(Me.sbCancelar)
        Me.LayoutControl3.Controls.Add(Me.chkGRVariable)
        Me.LayoutControl3.Controls.Add(Me.LabelControl4)
        Me.LayoutControl3.Controls.Add(Me.LabelControl3)
        Me.LayoutControl3.Controls.Add(Me.sbLimpia)
        Me.LayoutControl3.Controls.Add(Me.PanelControl2)
        Me.LayoutControl3.Controls.Add(Me.sbAplica)
        Me.LayoutControl3.Location = New System.Drawing.Point(714, 64)
        Me.LayoutControl3.Name = "LayoutControl3"
        Me.LayoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(873, 486, 250, 350)
        Me.LayoutControl3.OptionsView.UseDefaultDragAndDropRendering = False
        Me.LayoutControl3.Root = Me.Root
        Me.LayoutControl3.Size = New System.Drawing.Size(294, 660)
        Me.LayoutControl3.TabIndex = 8
        Me.LayoutControl3.Text = "LayoutControl3"
        '
        'chkSemaforo
        '
        Me.chkSemaforo.EditValue = True
        Me.chkSemaforo.Location = New System.Drawing.Point(174, 261)
        Me.chkSemaforo.Name = "chkSemaforo"
        Me.chkSemaforo.Properties.Caption = "Semaforo"
        Me.chkSemaforo.Size = New System.Drawing.Size(108, 19)
        Me.chkSemaforo.StyleController = Me.LayoutControl3
        Me.chkSemaforo.TabIndex = 14
        '
        'cboReferencia
        '
        Me.cboReferencia.EditValue = ""
        Me.cboReferencia.Enabled = False
        Me.cboReferencia.Location = New System.Drawing.Point(121, 219)
        Me.cboReferencia.Name = "cboReferencia"
        Me.cboReferencia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboReferencia.Size = New System.Drawing.Size(148, 20)
        Me.cboReferencia.StyleController = Me.LayoutControl3
        Me.cboReferencia.TabIndex = 13
        '
        'txtFactorVariacion
        '
        Me.txtFactorVariacion.EditValue = "1"
        Me.txtFactorVariacion.Location = New System.Drawing.Point(121, 192)
        Me.txtFactorVariacion.Name = "txtFactorVariacion"
        Me.txtFactorVariacion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtFactorVariacion.Properties.Appearance.Options.UseFont = True
        Me.txtFactorVariacion.Properties.Appearance.Options.UseTextOptions = True
        Me.txtFactorVariacion.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtFactorVariacion.Properties.EditFormat.FormatString = "###.00"
        Me.txtFactorVariacion.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFactorVariacion.Properties.Mask.EditMask = "###.00"
        Me.txtFactorVariacion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtFactorVariacion.Size = New System.Drawing.Size(133, 20)
        Me.txtFactorVariacion.StyleController = Me.LayoutControl3
        Me.txtFactorVariacion.TabIndex = 12
        '
        'sbCancelar
        '
        Me.sbCancelar.Image = Global.CCRCCV2.My.Resources.Resources.Close_32x32
        Me.sbCancelar.Location = New System.Drawing.Point(87, 352)
        Me.sbCancelar.Name = "sbCancelar"
        Me.sbCancelar.Size = New System.Drawing.Size(88, 38)
        Me.sbCancelar.StyleController = Me.LayoutControl3
        Me.sbCancelar.TabIndex = 9
        Me.sbCancelar.Text = "Cancelar"
        '
        'chkGRVariable
        '
        Me.chkGRVariable.Location = New System.Drawing.Point(25, 246)
        Me.chkGRVariable.Name = "chkGRVariable"
        Me.chkGRVariable.Padding = New System.Windows.Forms.Padding(10)
        Me.chkGRVariable.Size = New System.Drawing.Size(132, 70)
        Me.chkGRVariable.StyleController = Me.LayoutControl3
        Me.chkGRVariable.TabIndex = 8
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(27, 167)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(240, 13)
        Me.LabelControl4.StyleController = Me.LayoutControl3
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Seleccione una o mas variables para su asignacion"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Location = New System.Drawing.Point(22, 22)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(166, 13)
        Me.LabelControl3.StyleController = Me.LayoutControl3
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Asignacion Masiva de Rangos"
        '
        'sbLimpia
        '
        Me.sbLimpia.Location = New System.Drawing.Point(12, 352)
        Me.sbLimpia.Name = "sbLimpia"
        Me.sbLimpia.Size = New System.Drawing.Size(71, 22)
        Me.sbLimpia.StyleController = Me.LayoutControl3
        Me.sbLimpia.TabIndex = 11
        Me.sbLimpia.Text = "Limpiar"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.rcRangos)
        Me.PanelControl2.Location = New System.Drawing.Point(15, 52)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(264, 86)
        Me.PanelControl2.TabIndex = 4
        '
        'rcRangos
        '
        Me.rcRangos.AnimateOnDataChange = True
        Me.rcRangos.Client = Me.NumericRangeControlClient1
        Me.rcRangos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rcRangos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rcRangos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rcRangos.Location = New System.Drawing.Point(2, 2)
        Me.rcRangos.Name = "rcRangos"
        Me.rcRangos.Size = New System.Drawing.Size(260, 82)
        Me.rcRangos.TabIndex = 0
        Me.rcRangos.Text = "RangeControl1"
        '
        'NumericRangeControlClient1
        '
        Me.NumericRangeControlClient1.Maximum = CType(60, Short)
        Me.NumericRangeControlClient1.Minimum = CType(-60, Short)
        Me.NumericRangeControlClient1.RangeControl = Nothing
        Me.NumericRangeControlClient1.RulerDelta = CType(10, Short)
        '
        'sbAplica
        '
        Me.sbAplica.Image = Global.CCRCCV2.My.Resources.Resources.Save_32x32
        Me.sbAplica.Location = New System.Drawing.Point(179, 352)
        Me.sbAplica.Name = "sbAplica"
        Me.sbAplica.Size = New System.Drawing.Size(103, 38)
        Me.sbAplica.StyleController = Me.LayoutControl3
        Me.sbAplica.TabIndex = 10
        Me.sbAplica.Text = "Aplica"
        '
        'Root
        '
        Me.Root.CustomizationFormText = "Root"
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem20, Me.LayoutControlItem18, Me.LayoutControlItem19, Me.LayoutControlItem21, Me.EmptySpaceItem3, Me.LayoutControlItem23, Me.LayoutControlItem24, Me.lblMinimo, Me.lblMaximo, Me.LayoutControlItem25, Me.EmptySpaceItem2, Me.LayoutControlItem22})
        Me.Root.Location = New System.Drawing.Point(0, 0)
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(294, 660)
        Me.Root.Text = "Root"
        Me.Root.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.PanelControl2
        Me.LayoutControlItem16.CustomizationFormText = "LayoutControlItem16"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 37)
        Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(0, 100)
        Me.LayoutControlItem16.MinSize = New System.Drawing.Size(50, 80)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem16.Size = New System.Drawing.Size(274, 96)
        Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem16.Text = "LayoutControlItem16"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextToControlDistance = 0
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.LabelControl3
        Me.LayoutControlItem17.CustomizationFormText = "LayoutControlItem17"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(274, 37)
        Me.LayoutControlItem17.Spacing = New DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10)
        Me.LayoutControlItem17.Text = "LayoutControlItem17"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextToControlDistance = 0
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.chkGRVariable
        Me.LayoutControlItem20.CustomizationFormText = "LayoutControlItem20"
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 231)
        Me.LayoutControlItem20.MaxSize = New System.Drawing.Size(0, 100)
        Me.LayoutControlItem20.MinSize = New System.Drawing.Size(54, 80)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Padding = New DevExpress.XtraLayout.Utils.Padding(15, 15, 5, 5)
        Me.LayoutControlItem20.Size = New System.Drawing.Size(162, 80)
        Me.LayoutControlItem20.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem20.Text = "LayoutControlItem20"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextToControlDistance = 0
        Me.LayoutControlItem20.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.LabelControl4
        Me.LayoutControlItem18.CustomizationFormText = "LayoutControlItem18"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 150)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(274, 27)
        Me.LayoutControlItem18.Spacing = New DevExpress.XtraLayout.Utils.Padding(15, 15, 5, 5)
        Me.LayoutControlItem18.Text = "LayoutControlItem18"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextToControlDistance = 0
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.sbCancelar
        Me.LayoutControlItem19.CustomizationFormText = "LayoutControlItem19"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(75, 340)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(92, 42)
        Me.LayoutControlItem19.Text = "LayoutControlItem19"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextToControlDistance = 0
        Me.LayoutControlItem19.TextVisible = False
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.sbAplica
        Me.LayoutControlItem21.CustomizationFormText = "LayoutControlItem21"
        Me.LayoutControlItem21.Location = New System.Drawing.Point(167, 340)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(107, 42)
        Me.LayoutControlItem21.Text = "LayoutControlItem21"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem21.TextToControlDistance = 0
        Me.LayoutControlItem21.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 311)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(274, 29)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.txtFactorVariacion
        Me.LayoutControlItem23.CustomizationFormText = "Factor de Variación"
        Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 177)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Padding = New DevExpress.XtraLayout.Utils.Padding(15, 30, 5, 2)
        Me.LayoutControlItem23.Size = New System.Drawing.Size(274, 27)
        Me.LayoutControlItem23.Text = "Factor de Variación"
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.cboReferencia
        Me.LayoutControlItem24.CustomizationFormText = "Con referencia a"
        Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 204)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Padding = New DevExpress.XtraLayout.Utils.Padding(15, 15, 5, 2)
        Me.LayoutControlItem24.Size = New System.Drawing.Size(274, 27)
        Me.LayoutControlItem24.Text = "Con referencia a"
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(92, 13)
        '
        'lblMinimo
        '
        Me.lblMinimo.AllowHotTrack = False
        Me.lblMinimo.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lblMinimo.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblMinimo.CustomizationFormText = "Minimo"
        Me.lblMinimo.Location = New System.Drawing.Point(0, 133)
        Me.lblMinimo.Name = "lblMinimo"
        Me.lblMinimo.Size = New System.Drawing.Size(162, 17)
        Me.lblMinimo.Text = "Minimo"
        Me.lblMinimo.TextSize = New System.Drawing.Size(92, 13)
        '
        'lblMaximo
        '
        Me.lblMaximo.AllowHotTrack = False
        Me.lblMaximo.AppearanceItemCaption.Options.UseTextOptions = True
        Me.lblMaximo.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblMaximo.CustomizationFormText = "Maximo"
        Me.lblMaximo.Location = New System.Drawing.Point(162, 133)
        Me.lblMaximo.Name = "lblMaximo"
        Me.lblMaximo.Size = New System.Drawing.Size(112, 17)
        Me.lblMaximo.Text = "Maximo"
        Me.lblMaximo.TextSize = New System.Drawing.Size(92, 13)
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.chkSemaforo
        Me.LayoutControlItem25.CustomizationFormText = "LayoutControlItem25"
        Me.LayoutControlItem25.Location = New System.Drawing.Point(162, 231)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 20, 2)
        Me.LayoutControlItem25.Size = New System.Drawing.Size(112, 80)
        Me.LayoutControlItem25.Text = "LayoutControlItem25"
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem25.TextToControlDistance = 0
        Me.LayoutControlItem25.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 382)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(274, 258)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.sbLimpia
        Me.LayoutControlItem22.CustomizationFormText = "LayoutControlItem22"
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 340)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(75, 42)
        Me.LayoutControlItem22.Text = "LayoutControlItem22"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem22.TextToControlDistance = 0
        Me.LayoutControlItem22.TextVisible = False
        '
        'GridSplitContainer1
        '
        Me.GridSplitContainer1.Grid = Me.dgRangos
        Me.GridSplitContainer1.Location = New System.Drawing.Point(20, 72)
        Me.GridSplitContainer1.Name = "GridSplitContainer1"
        Me.GridSplitContainer1.Panel1.Controls.Add(Me.dgRangos)
        Me.GridSplitContainer1.Size = New System.Drawing.Size(682, 644)
        Me.GridSplitContainer1.SplitterPosition = 200
        Me.GridSplitContainer1.TabIndex = 7
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.lblTituloRangos, Me.LayoutControlItem15})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1020, 736)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridSplitContainer1
        Me.LayoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10)
        Me.LayoutControlItem1.Size = New System.Drawing.Size(702, 664)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'lblTituloRangos
        '
        Me.lblTituloRangos.AllowHotTrack = False
        Me.lblTituloRangos.AppearanceItemCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTituloRangos.AppearanceItemCaption.Options.UseFont = True
        Me.lblTituloRangos.CustomizationFormText = "Control de Rangos: "
        Me.lblTituloRangos.Image = CType(resources.GetObject("lblTituloRangos.Image"), System.Drawing.Image)
        Me.lblTituloRangos.Location = New System.Drawing.Point(0, 0)
        Me.lblTituloRangos.Name = "lblTituloRangos"
        Me.lblTituloRangos.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10)
        Me.lblTituloRangos.Size = New System.Drawing.Size(1000, 52)
        Me.lblTituloRangos.Text = "Control de Rangos: "
        Me.lblTituloRangos.TextSize = New System.Drawing.Size(197, 32)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.LayoutControl3
        Me.LayoutControlItem15.CustomizationFormText = "LayoutControlItem15"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(702, 52)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(298, 664)
        Me.LayoutControlItem15.Text = "LayoutControlItem15"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextToControlDistance = 0
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.SimpleButton7)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton8)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton9)
        Me.LayoutControl2.Controls.Add(Me.LabelControl2)
        Me.LayoutControl2.Controls.Add(Me.PanelControl1)
        Me.LayoutControl2.Controls.Add(Me.CheckedListBoxControl1)
        Me.LayoutControl2.Controls.Add(Me.LabelControl1)
        Me.LayoutControl2.Location = New System.Drawing.Point(254, 131)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(869, 194, 250, 350)
        Me.LayoutControl2.OptionsView.UseDefaultDragAndDropRendering = False
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(469, 401)
        Me.LayoutControl2.TabIndex = 8
        Me.LayoutControl2.Text = "LayoutControl1"
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Location = New System.Drawing.Point(293, 367)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(80, 22)
        Me.SimpleButton7.StyleController = Me.LayoutControl2
        Me.SimpleButton7.TabIndex = 9
        Me.SimpleButton7.Text = "SimpleButton3"
        '
        'SimpleButton8
        '
        Me.SimpleButton8.Location = New System.Drawing.Point(377, 367)
        Me.SimpleButton8.Name = "SimpleButton8"
        Me.SimpleButton8.Size = New System.Drawing.Size(80, 22)
        Me.SimpleButton8.StyleController = Me.LayoutControl2
        Me.SimpleButton8.TabIndex = 8
        Me.SimpleButton8.Text = "SimpleButton2"
        '
        'SimpleButton9
        '
        Me.SimpleButton9.Location = New System.Drawing.Point(152, 367)
        Me.SimpleButton9.Name = "SimpleButton9"
        Me.SimpleButton9.Size = New System.Drawing.Size(137, 22)
        Me.SimpleButton9.StyleController = Me.LayoutControl2
        Me.SimpleButton9.TabIndex = 7
        Me.SimpleButton9.Text = "SimpleButton1"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(18, 177)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Padding = New System.Windows.Forms.Padding(5)
        Me.LabelControl2.Size = New System.Drawing.Size(66, 23)
        Me.LabelControl2.StyleController = Me.LayoutControl2
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "LabelControl2"
        '
        'PanelControl1
        '
        Me.PanelControl1.Location = New System.Drawing.Point(12, 55)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(445, 112)
        Me.PanelControl1.TabIndex = 4
        '
        'CheckedListBoxControl1
        '
        Me.CheckedListBoxControl1.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem(Nothing, "Venta"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(Nothing, "Compra"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(Nothing, "Registros"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(Nothing, "Precio")})
        Me.CheckedListBoxControl1.Location = New System.Drawing.Point(12, 210)
        Me.CheckedListBoxControl1.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.CheckedListBoxControl1.Name = "CheckedListBoxControl1"
        Me.CheckedListBoxControl1.Padding = New System.Windows.Forms.Padding(15, 10, 10, 10)
        Me.CheckedListBoxControl1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.CheckedListBoxControl1.Size = New System.Drawing.Size(445, 153)
        Me.CheckedListBoxControl1.StyleController = Me.LayoutControl2
        Me.CheckedListBoxControl1.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(20, 30)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(145, 13)
        Me.LabelControl1.StyleController = Me.LayoutControl2
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Cambio masivo de rangos"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Root"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.EmptySpaceItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(469, 401)
        Me.LayoutControlGroup2.Text = "Root"
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.CheckedListBoxControl1
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 198)
        Me.LayoutControlItem8.Name = "LayoutControlItem1"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(449, 157)
        Me.LayoutControlItem8.Text = "LayoutControlItem1"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextToControlDistance = 0
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.PanelControl1
        Me.LayoutControlItem9.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 43)
        Me.LayoutControlItem9.Name = "LayoutControlItem2"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(449, 116)
        Me.LayoutControlItem9.Text = "LayoutControlItem2"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextToControlDistance = 0
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem10.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem10.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem10.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlItem10.Control = Me.LabelControl1
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem10.Name = "LayoutControlItem3"
        Me.LayoutControlItem10.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 20, 10)
        Me.LayoutControlItem10.Size = New System.Drawing.Size(449, 43)
        Me.LayoutControlItem10.Text = "LayoutControlItem3"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextToControlDistance = 0
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.LabelControl2
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 159)
        Me.LayoutControlItem11.Name = "LayoutControlItem4"
        Me.LayoutControlItem11.Padding = New DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8)
        Me.LayoutControlItem11.Size = New System.Drawing.Size(449, 39)
        Me.LayoutControlItem11.Text = "LayoutControlItem4"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextToControlDistance = 0
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.SimpleButton9
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(140, 355)
        Me.LayoutControlItem12.Name = "LayoutControlItem5"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(141, 26)
        Me.LayoutControlItem12.Text = "LayoutControlItem5"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextToControlDistance = 0
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.SimpleButton8
        Me.LayoutControlItem13.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(365, 355)
        Me.LayoutControlItem13.Name = "LayoutControlItem6"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(84, 26)
        Me.LayoutControlItem13.Text = "LayoutControlItem6"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextToControlDistance = 0
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.SimpleButton7
        Me.LayoutControlItem14.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(281, 355)
        Me.LayoutControlItem14.Name = "LayoutControlItem7"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(84, 26)
        Me.LayoutControlItem14.Text = "LayoutControlItem7"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextToControlDistance = 0
        Me.LayoutControlItem14.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 355)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(140, 26)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmRangos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 736)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.LayoutControl2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRangos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "15"
        Me.Text = "Gestion de Rangos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgRangos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl3.ResumeLayout(False)
        CType(Me.chkSemaforo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboReferencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFactorVariacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkGRVariable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMinimo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMaximo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridSplitContainer1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTituloRangos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckedListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgRangos As DevExpress.XtraGrid.GridControl
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents gc_IdRangos As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_IdMedicionZonaCanal As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_IdIndicador As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_TituloIndicador As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_Zona As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_Canal As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_CodigoProducto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_CMP_PMinimo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_CMP_PMaximo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_CMP_FVariacion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_CMP_Referencia As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_CMP_Semaforo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_INV_PMinimo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_INV_PMaximo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_INV_FVariacion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_INV_Referencia As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_INV_Semaforo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_VTA_PMinimo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_VTA_PMaximo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_VTA_FVariacion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_VTA_Referencia As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_VTA_Semaforo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_PRE_PMinimo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_PRE_PMaximo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_PRE_FVariacion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_PRE_Referencia As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_PRE_Semaforo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_REG_PMinimo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_REG_PMaximo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_REG_FVariacion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_REG_Referencia As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_REG_Semaforo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_Fecha As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_Semaforo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gc_RU As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lblTituloRangos As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents GridSplitContainer1 As DevExpress.XtraGrid.GridSplitContainer
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton9 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents CheckedListBoxControl1 As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControl3 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkGRVariable As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents rcRangos As DevExpress.XtraEditors.RangeControl
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents sbLimpia As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbAplica As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cboReferencia As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtFactorVariacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents NumericRangeControlClient1 As DevExpress.XtraEditors.NumericRangeControlClient
    Friend WithEvents lblMinimo As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents lblMaximo As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents chkSemaforo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents bdInicio As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bdVentas As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bdCompras As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bdInventarios As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bdPrecios As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bdRegistros As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents bdFinal As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
End Class
