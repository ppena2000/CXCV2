<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsignacionUsuarios
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

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
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar
        Me.sisStatus = New DevExpress.XtraBars.BarStaticItem
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.cbxMedicion = New System.Windows.Forms.ComboBox
        Me.lblMedicion = New System.Windows.Forms.Label
        Me.btnAplicarMedicion = New DevExpress.XtraEditors.SimpleButton
        Me.lblAsignacion = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.grdZonasAnalisis = New DevExpress.XtraGrid.GridControl
        Me.gvZonas = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIdTCCRCCAvance = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colZona = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTotalNegocios = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAvance = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAlertas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTotalErrores = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoUsuario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoUsuarioAnterior = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUsuario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rpItemUsuario = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colUsuarioAnterior = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cbxUsuarioItem = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.siStatus = New DevExpress.XtraBars.BarStaticItem
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.grdZonasAnalisis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvZonas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpItemUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxUsuarioItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.ItemLinks.Add(Me.sisStatus)
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 540)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1252, 31)
        '
        'sisStatus
        '
        Me.sisStatus.Caption = "Texto de status"
        Me.sisStatus.Id = 1
        Me.sisStatus.Name = "sisStatus"
        Me.sisStatus.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.sisStatus})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 2
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(1252, 144)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "RibbonPageGroup1"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cbxMedicion)
        Me.PanelControl1.Controls.Add(Me.lblMedicion)
        Me.PanelControl1.Controls.Add(Me.btnAplicarMedicion)
        Me.PanelControl1.Controls.Add(Me.lblAsignacion)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 144)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1252, 64)
        Me.PanelControl1.TabIndex = 7
        '
        'cbxMedicion
        '
        Me.cbxMedicion.FormattingEnabled = True
        Me.cbxMedicion.Location = New System.Drawing.Point(725, 26)
        Me.cbxMedicion.Name = "cbxMedicion"
        Me.cbxMedicion.Size = New System.Drawing.Size(135, 21)
        Me.cbxMedicion.TabIndex = 3
        '
        'lblMedicion
        '
        Me.lblMedicion.AutoSize = True
        Me.lblMedicion.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblMedicion.Location = New System.Drawing.Point(664, 30)
        Me.lblMedicion.Name = "lblMedicion"
        Me.lblMedicion.Size = New System.Drawing.Size(54, 14)
        Me.lblMedicion.TabIndex = 2
        Me.lblMedicion.Text = "Medición"
        '
        'btnAplicarMedicion
        '
        Me.btnAplicarMedicion.Location = New System.Drawing.Point(434, 24)
        Me.btnAplicarMedicion.Name = "btnAplicarMedicion"
        Me.btnAplicarMedicion.Size = New System.Drawing.Size(140, 23)
        Me.btnAplicarMedicion.TabIndex = 1
        Me.btnAplicarMedicion.Text = "&Aplicar Medicion Actual"
        '
        'lblAsignacion
        '
        Me.lblAsignacion.AutoSize = True
        Me.lblAsignacion.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblAsignacion.Location = New System.Drawing.Point(225, 30)
        Me.lblAsignacion.Name = "lblAsignacion"
        Me.lblAsignacion.Size = New System.Drawing.Size(193, 14)
        Me.lblAsignacion.TabIndex = 0
        Me.lblAsignacion.Text = "Copiar Asignación del mes anterior"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 208)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1252, 332)
        Me.Panel1.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.grdZonasAnalisis)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1252, 332)
        Me.Panel2.TabIndex = 0
        '
        'grdZonasAnalisis
        '
        Me.grdZonasAnalisis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdZonasAnalisis.Location = New System.Drawing.Point(0, 0)
        Me.grdZonasAnalisis.MainView = Me.gvZonas
        Me.grdZonasAnalisis.MenuManager = Me.RibbonControl
        Me.grdZonasAnalisis.Name = "grdZonasAnalisis"
        Me.grdZonasAnalisis.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbxUsuarioItem, Me.rpItemUsuario})
        Me.grdZonasAnalisis.Size = New System.Drawing.Size(1252, 332)
        Me.grdZonasAnalisis.TabIndex = 4
        Me.grdZonasAnalisis.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvZonas})
        '
        'gvZonas
        '
        Me.gvZonas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdTCCRCCAvance, Me.colZona, Me.colTotalNegocios, Me.colAvance, Me.colAlertas, Me.colTotalErrores, Me.colEstado, Me.colCodigoUsuario, Me.colCodigoUsuarioAnterior, Me.colUsuario, Me.colUsuarioAnterior})
        Me.gvZonas.GridControl = Me.grdZonasAnalisis
        Me.gvZonas.Name = "gvZonas"
        '
        'colIdTCCRCCAvance
        '
        Me.colIdTCCRCCAvance.FieldName = "IdTCCRCCAvance"
        Me.colIdTCCRCCAvance.Name = "colIdTCCRCCAvance"
        '
        'colZona
        '
        Me.colZona.Caption = "Cuidad"
        Me.colZona.ColumnEdit = Me.RepositoryItemHyperLinkEdit1
        Me.colZona.FieldName = "Zona"
        Me.colZona.Name = "colZona"
        Me.colZona.Visible = True
        Me.colZona.VisibleIndex = 0
        '
        'colTotalNegocios
        '
        Me.colTotalNegocios.Caption = "Total Negocios"
        Me.colTotalNegocios.FieldName = "TotalNegocios"
        Me.colTotalNegocios.Name = "colTotalNegocios"
        Me.colTotalNegocios.OptionsColumn.AllowEdit = False
        Me.colTotalNegocios.OptionsColumn.ReadOnly = True
        Me.colTotalNegocios.Visible = True
        Me.colTotalNegocios.VisibleIndex = 1
        '
        'colAvance
        '
        Me.colAvance.Caption = "Avance(%)"
        Me.colAvance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAvance.FieldName = "Avance"
        Me.colAvance.Name = "colAvance"
        Me.colAvance.OptionsColumn.AllowEdit = False
        Me.colAvance.OptionsColumn.ReadOnly = True
        Me.colAvance.Visible = True
        Me.colAvance.VisibleIndex = 2
        '
        'colAlertas
        '
        Me.colAlertas.Caption = "Alertas(%)"
        Me.colAlertas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAlertas.FieldName = "Alertas"
        Me.colAlertas.Name = "colAlertas"
        Me.colAlertas.Visible = True
        Me.colAlertas.VisibleIndex = 3
        '
        'colTotalErrores
        '
        Me.colTotalErrores.Caption = "Total"
        Me.colTotalErrores.FieldName = "TotalErrores"
        Me.colTotalErrores.Name = "colTotalErrores"
        Me.colTotalErrores.OptionsColumn.AllowEdit = False
        Me.colTotalErrores.OptionsColumn.ReadOnly = True
        Me.colTotalErrores.Visible = True
        Me.colTotalErrores.VisibleIndex = 4
        '
        'colEstado
        '
        Me.colEstado.Caption = "Terminado"
        Me.colEstado.FieldName = "EstadoEtiqueta"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.OptionsColumn.AllowEdit = False
        Me.colEstado.OptionsColumn.ReadOnly = True
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 5
        '
        'colCodigoUsuario
        '
        Me.colCodigoUsuario.FieldName = "CodigoUsuario"
        Me.colCodigoUsuario.Name = "colCodigoUsuario"
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
        Me.colUsuario.VisibleIndex = 6
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
        Me.colUsuarioAnterior.VisibleIndex = 7
        '
        'cbxUsuarioItem
        '
        Me.cbxUsuarioItem.AutoHeight = False
        Me.cbxUsuarioItem.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbxUsuarioItem.Name = "cbxUsuarioItem"
        '
        'siStatus
        '
        Me.siStatus.Caption = "Ingrese algun texto"
        Me.siStatus.Id = 31
        Me.siStatus.Name = "siStatus"
        Me.siStatus.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "Some Status Info"
        Me.BarStaticItem1.Id = 31
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = "Some Status Info"
        Me.BarStaticItem2.Id = 31
        Me.BarStaticItem2.Name = "BarStaticItem2"
        Me.BarStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'AsignacionUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1252, 571)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "AsignacionUsuarios"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "AsignacionUsuarios"
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.grdZonasAnalisis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvZonas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpItemUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxUsuarioItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblAsignacion As System.Windows.Forms.Label
    Friend WithEvents lblMedicion As System.Windows.Forms.Label
    Friend WithEvents btnAplicarMedicion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbxMedicion As System.Windows.Forms.ComboBox
    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents siStatus As DevExpress.XtraBars.BarStaticItem
    Private WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Private WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents sisStatus As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
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
    Friend WithEvents colUsuarioAnterior As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbxUsuarioItem As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents rpItemUsuario As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit


End Class
