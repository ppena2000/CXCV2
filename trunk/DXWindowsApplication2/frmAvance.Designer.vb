<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAvance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAvance))
        Me.colCodigoUsuario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cbxMedicion = New System.Windows.Forms.ComboBox
        Me.btnAplicarMedicion = New DevExpress.XtraEditors.SimpleButton
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl
        Me.lblAsignacion = New System.Windows.Forms.Label
        Me.grdZonasAnalisis = New DevExpress.XtraGrid.GridControl
        Me.gvZonas = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIdTCCRCCAvance = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colZona = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpItemLinkZona = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        Me.colTotalNegocios = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAvance = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAlertas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTotalErrores = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpItemEstado = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colCodigoUsuarioAnterior = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUsuario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpItemUsuario = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colUsuarioAnterior = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colC_Desde = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colC_Hasta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colC_Avance = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCC_Avance = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCC_Meta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpDateMeta = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.SimpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.grdZonasAnalisis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvZonas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpItemLinkZona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpItemEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpItemUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpDateMeta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpDateMeta.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'colCodigoUsuario
        '
        Me.colCodigoUsuario.FieldName = "CodigoUsuario"
        Me.colCodigoUsuario.Name = "colCodigoUsuario"
        '
        'cbxMedicion
        '
        Me.cbxMedicion.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.cbxMedicion.FormattingEnabled = True
        Me.cbxMedicion.Location = New System.Drawing.Point(726, 39)
        Me.cbxMedicion.Name = "cbxMedicion"
        Me.cbxMedicion.Size = New System.Drawing.Size(135, 33)
        Me.cbxMedicion.TabIndex = 7
        '
        'btnAplicarMedicion
        '
        Me.btnAplicarMedicion.Location = New System.Drawing.Point(901, 304)
        Me.btnAplicarMedicion.Name = "btnAplicarMedicion"
        Me.btnAplicarMedicion.Size = New System.Drawing.Size(240, 22)
        Me.btnAplicarMedicion.StyleController = Me.LayoutControl1
        Me.btnAplicarMedicion.TabIndex = 5
        Me.btnAplicarMedicion.Text = "&Aplicar Medicion Actual"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.lblAsignacion)
        Me.LayoutControl1.Controls.Add(Me.cbxMedicion)
        Me.LayoutControl1.Controls.Add(Me.grdZonasAnalisis)
        Me.LayoutControl1.Controls.Add(Me.btnAplicarMedicion)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(2, 2)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsView.UseDefaultDragAndDropRendering = False
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1181, 738)
        Me.LayoutControl1.TabIndex = 6
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'lblAsignacion
        '
        Me.lblAsignacion.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblAsignacion.Location = New System.Drawing.Point(873, 176)
        Me.lblAsignacion.Name = "lblAsignacion"
        Me.lblAsignacion.Padding = New System.Windows.Forms.Padding(10)
        Me.lblAsignacion.Size = New System.Drawing.Size(296, 96)
        Me.lblAsignacion.TabIndex = 4
        Me.lblAsignacion.Text = "Copiar Asignación del mes anterior"
        Me.lblAsignacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grdZonasAnalisis
        '
        Me.grdZonasAnalisis.Location = New System.Drawing.Point(12, 92)
        Me.grdZonasAnalisis.MainView = Me.gvZonas
        Me.grdZonasAnalisis.Name = "grdZonasAnalisis"
        Me.grdZonasAnalisis.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpItemUsuario, Me.rpItemLinkZona, Me.rpDateMeta, Me.rpItemEstado})
        Me.grdZonasAnalisis.Size = New System.Drawing.Size(857, 610)
        Me.grdZonasAnalisis.TabIndex = 5
        Me.grdZonasAnalisis.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvZonas})
        '
        'gvZonas
        '
        Me.gvZonas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdTCCRCCAvance, Me.colZona, Me.colTotalNegocios, Me.colAvance, Me.colAlertas, Me.colTotalErrores, Me.colEstado, Me.colCodigoUsuario, Me.colCodigoUsuarioAnterior, Me.colUsuario, Me.colUsuarioAnterior, Me.colC_Desde, Me.colC_Hasta, Me.colC_Avance, Me.colCC_Avance, Me.colCC_Meta})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colCodigoUsuario
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = CType(0, Short)
        Me.gvZonas.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.gvZonas.GridControl = Me.grdZonasAnalisis
        Me.gvZonas.Name = "gvZonas"
        '
        'colIdTCCRCCAvance
        '
        Me.colIdTCCRCCAvance.Caption = "Id"
        Me.colIdTCCRCCAvance.FieldName = "IdTCCRCCAvance"
        Me.colIdTCCRCCAvance.Name = "colIdTCCRCCAvance"
        Me.colIdTCCRCCAvance.OptionsColumn.AllowEdit = False
        Me.colIdTCCRCCAvance.OptionsColumn.ReadOnly = True
        Me.colIdTCCRCCAvance.Visible = True
        Me.colIdTCCRCCAvance.VisibleIndex = 0
        Me.colIdTCCRCCAvance.Width = 27
        '
        'colZona
        '
        Me.colZona.Caption = "Cuidad"
        Me.colZona.ColumnEdit = Me.rpItemLinkZona
        Me.colZona.FieldName = "Zona"
        Me.colZona.Name = "colZona"
        Me.colZona.Visible = True
        Me.colZona.VisibleIndex = 1
        Me.colZona.Width = 134
        '
        'rpItemLinkZona
        '
        Me.rpItemLinkZona.AutoHeight = False
        Me.rpItemLinkZona.Name = "rpItemLinkZona"
        '
        'colTotalNegocios
        '
        Me.colTotalNegocios.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalNegocios.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTotalNegocios.Caption = "Total Negocios"
        Me.colTotalNegocios.FieldName = "TotalNegocios"
        Me.colTotalNegocios.Name = "colTotalNegocios"
        Me.colTotalNegocios.OptionsColumn.AllowEdit = False
        Me.colTotalNegocios.OptionsColumn.ReadOnly = True
        Me.colTotalNegocios.Visible = True
        Me.colTotalNegocios.VisibleIndex = 2
        Me.colTotalNegocios.Width = 37
        '
        'colAvance
        '
        Me.colAvance.AppearanceHeader.Options.UseTextOptions = True
        Me.colAvance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAvance.Caption = "Avance(%)"
        Me.colAvance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAvance.FieldName = "Avance"
        Me.colAvance.Name = "colAvance"
        Me.colAvance.OptionsColumn.AllowEdit = False
        Me.colAvance.OptionsColumn.ReadOnly = True
        Me.colAvance.Visible = True
        Me.colAvance.VisibleIndex = 3
        Me.colAvance.Width = 33
        '
        'colAlertas
        '
        Me.colAlertas.AppearanceHeader.Options.UseTextOptions = True
        Me.colAlertas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAlertas.Caption = "Alertas(%)"
        Me.colAlertas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAlertas.FieldName = "Alertas"
        Me.colAlertas.Name = "colAlertas"
        Me.colAlertas.OptionsColumn.AllowEdit = False
        Me.colAlertas.OptionsColumn.ReadOnly = True
        Me.colAlertas.Visible = True
        Me.colAlertas.VisibleIndex = 4
        Me.colAlertas.Width = 32
        '
        'colTotalErrores
        '
        Me.colTotalErrores.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalErrores.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTotalErrores.Caption = "Total"
        Me.colTotalErrores.FieldName = "TotalErrores"
        Me.colTotalErrores.Name = "colTotalErrores"
        Me.colTotalErrores.OptionsColumn.AllowEdit = False
        Me.colTotalErrores.OptionsColumn.ReadOnly = True
        Me.colTotalErrores.Visible = True
        Me.colTotalErrores.VisibleIndex = 5
        Me.colTotalErrores.Width = 29
        '
        'colEstado
        '
        Me.colEstado.AppearanceCell.Options.UseTextOptions = True
        Me.colEstado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstado.AppearanceHeader.Options.UseTextOptions = True
        Me.colEstado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstado.Caption = "Estado"
        Me.colEstado.ColumnEdit = Me.rpItemEstado
        Me.colEstado.FieldName = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 6
        Me.colEstado.Width = 59
        '
        'rpItemEstado
        '
        Me.rpItemEstado.AutoHeight = False
        Me.rpItemEstado.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpItemEstado.Name = "rpItemEstado"
        '
        'colCodigoUsuarioAnterior
        '
        Me.colCodigoUsuarioAnterior.FieldName = "CodigoUsuarioAnterior"
        Me.colCodigoUsuarioAnterior.Name = "colCodigoUsuarioAnterior"
        '
        'colUsuario
        '
        Me.colUsuario.Caption = "Asignar a"
        Me.colUsuario.ColumnEdit = Me.rpItemUsuario
        Me.colUsuario.FieldName = "CodigoUsuario"
        Me.colUsuario.Name = "colUsuario"
        Me.colUsuario.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.colUsuario.Visible = True
        Me.colUsuario.VisibleIndex = 7
        Me.colUsuario.Width = 150
        '
        'rpItemUsuario
        '
        Me.rpItemUsuario.AutoHeight = False
        Me.rpItemUsuario.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpItemUsuario.Name = "rpItemUsuario"
        '
        'colUsuarioAnterior
        '
        Me.colUsuarioAnterior.Caption = "Mes Anterior"
        Me.colUsuarioAnterior.FieldName = "UsuarioAnterior"
        Me.colUsuarioAnterior.Name = "colUsuarioAnterior"
        Me.colUsuarioAnterior.OptionsColumn.AllowEdit = False
        Me.colUsuarioAnterior.OptionsColumn.ReadOnly = True
        Me.colUsuarioAnterior.Visible = True
        Me.colUsuarioAnterior.VisibleIndex = 8
        Me.colUsuarioAnterior.Width = 150
        '
        'colC_Desde
        '
        Me.colC_Desde.Caption = "Campo Inicio"
        Me.colC_Desde.FieldName = "C_Desde"
        Me.colC_Desde.Name = "colC_Desde"
        Me.colC_Desde.OptionsColumn.AllowEdit = False
        Me.colC_Desde.OptionsColumn.ReadOnly = True
        Me.colC_Desde.Visible = True
        Me.colC_Desde.VisibleIndex = 9
        Me.colC_Desde.Width = 33
        '
        'colC_Hasta
        '
        Me.colC_Hasta.Caption = "Campo Fin "
        Me.colC_Hasta.FieldName = "C_Hasta"
        Me.colC_Hasta.Name = "colC_Hasta"
        Me.colC_Hasta.OptionsColumn.AllowEdit = False
        Me.colC_Hasta.OptionsColumn.ReadOnly = True
        Me.colC_Hasta.Visible = True
        Me.colC_Hasta.VisibleIndex = 10
        Me.colC_Hasta.Width = 33
        '
        'colC_Avance
        '
        Me.colC_Avance.Caption = "Campo Avance"
        Me.colC_Avance.FieldName = "C_Avance"
        Me.colC_Avance.Name = "colC_Avance"
        Me.colC_Avance.OptionsColumn.AllowEdit = False
        Me.colC_Avance.OptionsColumn.ReadOnly = True
        Me.colC_Avance.Visible = True
        Me.colC_Avance.VisibleIndex = 11
        Me.colC_Avance.Width = 33
        '
        'colCC_Avance
        '
        Me.colCC_Avance.Caption = "CC Avance"
        Me.colCC_Avance.FieldName = "CC_Avance"
        Me.colCC_Avance.Name = "colCC_Avance"
        Me.colCC_Avance.OptionsColumn.AllowEdit = False
        Me.colCC_Avance.OptionsColumn.ReadOnly = True
        Me.colCC_Avance.Visible = True
        Me.colCC_Avance.VisibleIndex = 12
        Me.colCC_Avance.Width = 33
        '
        'colCC_Meta
        '
        Me.colCC_Meta.Caption = "CC Meta"
        Me.colCC_Meta.ColumnEdit = Me.rpDateMeta
        Me.colCC_Meta.FieldName = "CC_Meta"
        Me.colCC_Meta.Name = "colCC_Meta"
        Me.colCC_Meta.Visible = True
        Me.colCC_Meta.VisibleIndex = 13
        Me.colCC_Meta.Width = 56
        '
        'rpDateMeta
        '
        Me.rpDateMeta.AutoHeight = False
        Me.rpDateMeta.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rpDateMeta.Name = "rpDateMeta"
        Me.rpDateMeta.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.SimpleLabelItem1, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.EmptySpaceItem2, Me.EmptySpaceItem1, Me.EmptySpaceItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1181, 738)
        Me.LayoutControlGroup1.Text = "Root"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem1.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LayoutControlItem1.Control = Me.grdZonasAnalisis
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 80)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(861, 614)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'SimpleLabelItem1
        '
        Me.SimpleLabelItem1.AllowHotTrack = False
        Me.SimpleLabelItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SimpleLabelItem1.AppearanceItemCaption.Options.UseFont = True
        Me.SimpleLabelItem1.CustomizationFormText = "CONSISTENCIA POR CIUDAD: Control de avance"
        Me.SimpleLabelItem1.Image = Global.CCRCCV2.My.Resources.Resources.icol_38_controldeavance
        Me.SimpleLabelItem1.ImageToTextDistance = 10
        Me.SimpleLabelItem1.Location = New System.Drawing.Point(0, 0)
        Me.SimpleLabelItem1.MaxSize = New System.Drawing.Size(0, 80)
        Me.SimpleLabelItem1.MinSize = New System.Drawing.Size(127, 80)
        Me.SimpleLabelItem1.Name = "SimpleLabelItem1"
        Me.SimpleLabelItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10)
        Me.SimpleLabelItem1.Size = New System.Drawing.Size(711, 80)
        Me.SimpleLabelItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.SimpleLabelItem1.Text = "CONSISTENCIA POR CIUDAD: Control de avance"
        Me.SimpleLabelItem1.TextSize = New System.Drawing.Size(434, 32)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem2.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LayoutControlItem2.Control = Me.cbxMedicion
        Me.LayoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.LayoutControlItem2.CustomizationFormText = "Medicion"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(711, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(150, 41)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(50, 41)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 10, 10, 10)
        Me.LayoutControlItem2.Size = New System.Drawing.Size(150, 80)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Medicion"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(434, 16)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.lblAsignacion
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(861, 164)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(300, 0)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(300, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(300, 100)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.btnAplicarMedicion
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(861, 264)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(30, 30, 30, 30)
        Me.LayoutControlItem5.Size = New System.Drawing.Size(300, 82)
        Me.LayoutControlItem5.Text = "LayoutControlItem5"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(861, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(300, 164)
        Me.EmptySpaceItem2.Text = "EmptySpaceItem2"
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 694)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(1161, 24)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(861, 346)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(300, 348)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LayoutControl1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1185, 742)
        Me.PanelControl2.TabIndex = 1
        '
        'frmAvance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 742)
        Me.Controls.Add(Me.PanelControl2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAvance"
        Me.Tag = "18"
        Me.Text = "Avance"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.grdZonasAnalisis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvZonas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpItemLinkZona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpItemEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpItemUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpDateMeta.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpDateMeta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cbxMedicion As System.Windows.Forms.ComboBox
    Friend WithEvents btnAplicarMedicion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblAsignacion As System.Windows.Forms.Label
    Friend WithEvents grdZonasAnalisis As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvZonas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIdTCCRCCAvance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colZona As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalNegocios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAvance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlertas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalErrores As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoUsuarioAnterior As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpItemUsuario As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colUsuarioAnterior As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpItemLinkZona As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Private WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colC_Desde As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colC_Hasta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colC_Avance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCC_Avance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCC_Meta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpDateMeta As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents rpItemEstado As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
