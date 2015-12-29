Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Helpers


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits RibbonForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.navbarImageCollectionLarge = New DevExpress.Utils.ImageCollection(Me.components)
        Me.navbarImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl
        Me.appMenu = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.popupControlContainer2xxxx = New DevExpress.XtraBars.PopupControlContainer(Me.components)
        Me.buttonEdit = New DevExpress.XtraEditors.ButtonEdit
        Me.popupControlContainer1xxxx = New DevExpress.XtraBars.PopupControlContainer(Me.components)
        Me.someLabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.someLabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.AppImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.btnSemaforo = New DevExpress.XtraBars.BarButtonItem
        Me.btnVariacion = New DevExpress.XtraBars.BarButtonItem
        Me.btnSku = New DevExpress.XtraBars.BarButtonItem
        Me.btnFrecuencia = New DevExpress.XtraBars.BarButtonItem
        Me.btnSupervisionMarca = New DevExpress.XtraBars.BarButtonItem
        Me.btnSupervisionResumen = New DevExpress.XtraBars.BarButtonItem
        Me.btnSupervisionValidar = New DevExpress.XtraBars.BarButtonItem
        Me.btnEstadistica = New DevExpress.XtraBars.BarButtonItem
        Me.btnPropiedades = New DevExpress.XtraBars.BarButtonItem
        Me.btnReplicarEncuesta = New DevExpress.XtraBars.BarButtonItem
        Me.btnReplicarEncuestaPromedio = New DevExpress.XtraBars.BarButtonItem
        Me.btnReplicarSkuPromedio = New DevExpress.XtraBars.BarButtonItem
        Me.btnCancelarReplicas = New DevExpress.XtraBars.BarButtonItem
        Me.btnVerDatosValidos = New DevExpress.XtraBars.BarButtonItem
        Me.btnVerDatosCampo = New DevExpress.XtraBars.BarButtonItem
        Me.btnVerDatosSupervision = New DevExpress.XtraBars.BarButtonItem
        Me.btnVerDatosAjustado = New DevExpress.XtraBars.BarButtonItem
        Me.btnVerTodos = New DevExpress.XtraBars.BarButtonItem
        Me.btnSemaforoAlertas = New DevExpress.XtraBars.BarCheckItem
        Me.btnSemaforoOk = New DevExpress.XtraBars.BarCheckItem
        Me.btnSemaforoTodos = New DevExpress.XtraBars.BarCheckItem
        Me.btnGestionRangos = New DevExpress.XtraBars.BarButtonItem
        Me.btnExportarExcel = New DevExpress.XtraBars.BarButtonItem
        Me.btnExportarPDF = New DevExpress.XtraBars.BarButtonItem
        Me.btnExportarCSV = New DevExpress.XtraBars.BarButtonItem
        Me.btnExportarXML = New DevExpress.XtraBars.BarButtonItem
        Me.btnVistaPrevia = New DevExpress.XtraBars.BarButtonItem
        Me.btnImprimir = New DevExpress.XtraBars.BarButtonItem
        Me.btnPanelControl = New DevExpress.XtraBars.BarButtonItem
        Me.btnControlAvance = New DevExpress.XtraBars.BarButtonItem
        Me.btnGrabar = New DevExpress.XtraBars.BarButtonItem
        Me.btnSalir = New DevExpress.XtraBars.BarButtonItem
        Me.btnReal = New DevExpress.XtraBars.BarEditItem
        Me.rpItemCheckReal = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.btnAnalizada = New DevExpress.XtraBars.BarEditItem
        Me.rpItemCheckAnalizada = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.bbPanel = New DevExpress.XtraBars.BarButtonItem
        Me.bbAvance = New DevExpress.XtraBars.BarButtonItem
        Me.bbIndicador01 = New DevExpress.XtraBars.BarButtonItem
        Me.bbIndicador02 = New DevExpress.XtraBars.BarButtonItem
        Me.siStatus = New DevExpress.XtraBars.BarStaticItem
        Me.bbIndicador03 = New DevExpress.XtraBars.BarButtonItem
        Me.bbIndicador04 = New DevExpress.XtraBars.BarButtonItem
        Me.bbIndicador05 = New DevExpress.XtraBars.BarButtonItem
        Me.bbIndicador06 = New DevExpress.XtraBars.BarButtonItem
        Me.bbIndicador07 = New DevExpress.XtraBars.BarButtonItem
        Me.bbIndicador08 = New DevExpress.XtraBars.BarButtonItem
        Me.bbIndicador09 = New DevExpress.XtraBars.BarButtonItem
        Me.bbIndicador10 = New DevExpress.XtraBars.BarButtonItem
        Me.bbIndicador11 = New DevExpress.XtraBars.BarButtonItem
        Me.bbIndicador12 = New DevExpress.XtraBars.BarButtonItem
        Me.bbEncuesta = New DevExpress.XtraBars.BarButtonItem
        Me.bbRangos = New DevExpress.XtraBars.BarButtonItem
        Me.btnAcerca = New DevExpress.XtraBars.BarButtonItem
        Me.bitemUsuario = New DevExpress.XtraBars.BarButtonItem
        Me.bsiServidor = New DevExpress.XtraBars.BarStaticItem
        Me.bsiBD = New DevExpress.XtraBars.BarStaticItem
        Me.rgbSkins = New DevExpress.XtraBars.RibbonGalleryBarItem
        Me.btnSincronizar = New DevExpress.XtraBars.BarButtonItem
        Me.btnPlantilla03 = New DevExpress.XtraBars.BarButtonItem
        Me.btnVenta = New DevExpress.XtraBars.BarCheckItem
        Me.btnCompra = New DevExpress.XtraBars.BarCheckItem
        Me.btnInventarios = New DevExpress.XtraBars.BarCheckItem
        Me.btnPrecio = New DevExpress.XtraBars.BarCheckItem
        Me.btnRegistros = New DevExpress.XtraBars.BarCheckItem
        Me.btnVariablesTodos = New DevExpress.XtraBars.BarCheckItem
        Me.btnVariablesNinguno = New DevExpress.XtraBars.BarCheckItem
        Me.btnCambiarEstado = New DevExpress.XtraBars.BarButtonItem
        Me.btnVaciar = New DevExpress.XtraBars.BarButtonItem
        Me.btnReplicaSKU = New DevExpress.XtraBars.BarButtonItem
        Me.btnActivar = New DevExpress.XtraBars.BarButtonItem
        Me.bsiProgreso = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemMarqueeProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar
        Me.btnCorrectos = New DevExpress.XtraBars.BarButtonItem
        Me.btnPendientes = New DevExpress.XtraBars.BarButtonItem
        Me.btnEnSupervision = New DevExpress.XtraBars.BarButtonItem
        Me.btnValidados = New DevExpress.XtraBars.BarButtonItem
        Me.btnAtipicos = New DevExpress.XtraBars.BarButtonItem
        Me.btnNoProcesa = New DevExpress.XtraBars.BarButtonItem
        Me.btnCongelar = New DevExpress.XtraBars.BarButtonItem
        Me.btnEstadoTodos = New DevExpress.XtraBars.BarButtonItem
        Me.btnRecargar = New DevExpress.XtraBars.BarButtonItem
        Me.btnCambiarEstadoNoProcesa = New DevExpress.XtraBars.BarButtonItem
        Me.btnGestionSupervision = New DevExpress.XtraBars.BarButtonItem
        Me.btnEnviaSupervision = New DevExpress.XtraBars.BarButtonItem
        Me.btnSkuPonerAtipico = New DevExpress.XtraBars.BarButtonItem
        Me.btnSkuPonerNoProcesa = New DevExpress.XtraBars.BarButtonItem
        Me.btnSkuActivarRegistro = New DevExpress.XtraBars.BarButtonItem
        Me.btnActivarSupervision = New DevExpress.XtraBars.BarButtonItem
        Me.AppImageCollectionLarge = New DevExpress.Utils.ImageCollection(Me.components)
        Me.ribbonCategorySupervision = New DevExpress.XtraBars.Ribbon.RibbonPageCategory
        Me.ribbonPageSupervision = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.rpgGestionSupervision = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpgGestionSupervisionEncuesta = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpgGestionSupervisionEstadoNegocio = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RibbonPageCategory1 = New DevExpress.XtraBars.Ribbon.RibbonPageCategory
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.groupRangos = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RibbonPageCategory2 = New DevExpress.XtraBars.Ribbon.RibbonPageCategory
        Me.RibbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.groupImprimir = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.groupExportar = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RibbonPageCategoryGallery = New DevExpress.XtraBars.Ribbon.RibbonPageCategory
        Me.RibbonPage7 = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.rpgGaleria = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RibbonPageCategoryAcerca = New DevExpress.XtraBars.Ribbon.RibbonPageCategory
        Me.RibbonPage6 = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rbCintaOpcionesEncuesta = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.groupVariables = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.groupIndicadores = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.groupSemaforo = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.groupSupervision = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpgEstado = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.groupEstandar = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RibbonPage5 = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.groupAjusteEncuesta = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.groupSKU = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.groupFiltros = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.groupData = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.groupVarios = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.groupPanelControlAvance = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.rpItemCheckVenta = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.rpItemCheckCompra = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.rpItemCheckInventarios = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.rpItemCheckPrecios = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.rStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.skinsRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.exitRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.formatRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.fileRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.btnEditSkuCanal = New DevExpress.XtraBars.BarButtonItem
        CType(Me.navbarImageCollectionLarge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.navbarImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.appMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupControlContainer2xxxx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popupControlContainer2xxxx.SuspendLayout()
        CType(Me.buttonEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupControlContainer1xxxx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popupControlContainer1xxxx.SuspendLayout()
        CType(Me.AppImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpItemCheckReal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpItemCheckAnalizada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMarqueeProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppImageCollectionLarge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpItemCheckVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpItemCheckCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpItemCheckInventarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpItemCheckPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'navbarImageCollectionLarge
        '
        Me.navbarImageCollectionLarge.ImageStream = CType(resources.GetObject("navbarImageCollectionLarge.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.navbarImageCollectionLarge.TransparentColor = System.Drawing.Color.Transparent
        Me.navbarImageCollectionLarge.Images.SetKeyName(0, "Mail_16x16.png")
        Me.navbarImageCollectionLarge.Images.SetKeyName(1, "Organizer_16x16.png")
        '
        'navbarImageCollection
        '
        Me.navbarImageCollection.ImageStream = CType(resources.GetObject("navbarImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.navbarImageCollection.TransparentColor = System.Drawing.Color.Transparent
        Me.navbarImageCollection.Images.SetKeyName(0, "Inbox_16x16.png")
        Me.navbarImageCollection.Images.SetKeyName(1, "Outbox_16x16.png")
        Me.navbarImageCollection.Images.SetKeyName(2, "Drafts_16x16.png")
        Me.navbarImageCollection.Images.SetKeyName(3, "Trash_16x16.png")
        Me.navbarImageCollection.Images.SetKeyName(4, "Calendar_16x16.png")
        Me.navbarImageCollection.Images.SetKeyName(5, "Tasks_16x16.png")
        '
        'ribbonControl
        '
        Me.ribbonControl.ApplicationButtonDropDownControl = Me.appMenu
        Me.ribbonControl.ApplicationButtonText = Nothing
        Me.ribbonControl.ApplicationIcon = CType(resources.GetObject("ribbonControl.ApplicationIcon"), System.Drawing.Bitmap)
        Me.ribbonControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Images = Me.AppImageCollection
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.btnSemaforo, Me.btnVariacion, Me.btnSku, Me.btnFrecuencia, Me.btnSupervisionMarca, Me.btnSupervisionResumen, Me.btnSupervisionValidar, Me.btnEstadistica, Me.btnPropiedades, Me.btnReplicarEncuesta, Me.btnReplicarEncuestaPromedio, Me.btnReplicarSkuPromedio, Me.btnCancelarReplicas, Me.btnVerDatosValidos, Me.btnVerDatosCampo, Me.btnVerDatosSupervision, Me.btnVerDatosAjustado, Me.btnVerTodos, Me.btnSemaforoAlertas, Me.btnSemaforoOk, Me.btnSemaforoTodos, Me.btnGestionRangos, Me.btnExportarExcel, Me.btnExportarPDF, Me.btnExportarCSV, Me.btnExportarXML, Me.btnVistaPrevia, Me.btnImprimir, Me.btnPanelControl, Me.btnControlAvance, Me.btnGrabar, Me.btnSalir, Me.btnReal, Me.btnAnalizada, Me.bbPanel, Me.bbAvance, Me.bbIndicador01, Me.bbIndicador02, Me.siStatus, Me.bbIndicador03, Me.bbIndicador04, Me.bbIndicador05, Me.bbIndicador06, Me.bbIndicador07, Me.bbIndicador08, Me.bbIndicador09, Me.bbIndicador10, Me.bbIndicador11, Me.bbIndicador12, Me.bbEncuesta, Me.bbRangos, Me.btnAcerca, Me.bitemUsuario, Me.bsiServidor, Me.bsiBD, Me.rgbSkins, Me.btnSincronizar, Me.btnPlantilla03, Me.btnVenta, Me.btnCompra, Me.btnInventarios, Me.btnPrecio, Me.btnRegistros, Me.btnVariablesTodos, Me.btnVariablesNinguno, Me.btnCambiarEstado, Me.btnVaciar, Me.btnReplicaSKU, Me.btnActivar, Me.bsiProgreso, Me.btnCorrectos, Me.btnPendientes, Me.btnEnSupervision, Me.btnValidados, Me.btnAtipicos, Me.btnNoProcesa, Me.btnCongelar, Me.btnEstadoTodos, Me.btnRecargar, Me.btnCambiarEstadoNoProcesa, Me.btnGestionSupervision, Me.btnEnviaSupervision, Me.btnSkuPonerAtipico, Me.btnSkuPonerNoProcesa, Me.btnSkuActivarRegistro, Me.btnActivarSupervision, Me.btnEditSkuCanal})
        Me.ribbonControl.LargeImages = Me.AppImageCollectionLarge
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.MaxItemId = 208
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() {Me.ribbonCategorySupervision, Me.RibbonPageCategory1, Me.RibbonPageCategory2, Me.RibbonPageCategoryGallery, Me.RibbonPageCategoryAcerca})
        Me.ribbonControl.PageHeaderItemLinks.Add(Me.btnSku)
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rbCintaOpcionesEncuesta, Me.RibbonPage5, Me.RibbonPage1})
        Me.ribbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpItemCheckReal, Me.rpItemCheckAnalizada, Me.rpItemCheckVenta, Me.rpItemCheckCompra, Me.rpItemCheckInventarios, Me.RepositoryItemCheckEdit1, Me.rpItemCheckPrecios, Me.RepositoryItemCheckEdit2, Me.RepositoryItemCheckEdit3, Me.RepositoryItemMarqueeProgressBar1})
        Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice
        Me.ribbonControl.Size = New System.Drawing.Size(1366, 134)
        Me.ribbonControl.StatusBar = Me.rStatusBar
        Me.ribbonControl.Tag = "1"
        Me.ribbonControl.Toolbar.ItemLinks.Add(Me.btnSemaforoAlertas)
        Me.ribbonControl.Toolbar.ItemLinks.Add(Me.btnVenta)
        Me.ribbonControl.Toolbar.ItemLinks.Add(Me.btnVariacion)
        Me.ribbonControl.Toolbar.ItemLinks.Add(Me.btnReplicarEncuesta)
        Me.ribbonControl.Toolbar.ItemLinks.Add(Me.btnSincronizar)
        Me.ribbonControl.Toolbar.ItemLinks.Add(Me.btnSupervisionMarca)
        Me.ribbonControl.Toolbar.ItemLinks.Add(Me.btnGrabar)
        '
        'appMenu
        '
        Me.appMenu.BottomPaneControlContainer = Me.popupControlContainer2xxxx
        Me.appMenu.Name = "appMenu"
        Me.appMenu.Ribbon = Me.ribbonControl
        Me.appMenu.RightPaneControlContainer = Me.popupControlContainer1xxxx
        Me.appMenu.ShowRightPane = True
        '
        'popupControlContainer2xxxx
        '
        Me.popupControlContainer2xxxx.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.popupControlContainer2xxxx.Appearance.Options.UseBackColor = True
        Me.popupControlContainer2xxxx.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.popupControlContainer2xxxx.Controls.Add(Me.buttonEdit)
        Me.popupControlContainer2xxxx.Location = New System.Drawing.Point(238, 289)
        Me.popupControlContainer2xxxx.Name = "popupControlContainer2xxxx"
        Me.popupControlContainer2xxxx.Ribbon = Me.ribbonControl
        Me.popupControlContainer2xxxx.Size = New System.Drawing.Size(118, 28)
        Me.popupControlContainer2xxxx.TabIndex = 7
        Me.popupControlContainer2xxxx.Visible = False
        '
        'buttonEdit
        '
        Me.buttonEdit.EditValue = "Some Text"
        Me.buttonEdit.Location = New System.Drawing.Point(3, 5)
        Me.buttonEdit.MenuManager = Me.ribbonControl
        Me.buttonEdit.Name = "buttonEdit"
        Me.buttonEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.buttonEdit.Size = New System.Drawing.Size(100, 20)
        Me.buttonEdit.TabIndex = 0
        '
        'popupControlContainer1xxxx
        '
        Me.popupControlContainer1xxxx.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.popupControlContainer1xxxx.Appearance.Options.UseBackColor = True
        Me.popupControlContainer1xxxx.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.popupControlContainer1xxxx.Controls.Add(Me.someLabelControl2)
        Me.popupControlContainer1xxxx.Controls.Add(Me.someLabelControl1)
        Me.popupControlContainer1xxxx.Location = New System.Drawing.Point(111, 197)
        Me.popupControlContainer1xxxx.Name = "popupControlContainer1xxxx"
        Me.popupControlContainer1xxxx.Ribbon = Me.ribbonControl
        Me.popupControlContainer1xxxx.Size = New System.Drawing.Size(76, 70)
        Me.popupControlContainer1xxxx.TabIndex = 6
        Me.popupControlContainer1xxxx.Visible = False
        '
        'someLabelControl2
        '
        Me.someLabelControl2.Location = New System.Drawing.Point(3, 57)
        Me.someLabelControl2.Name = "someLabelControl2"
        Me.someLabelControl2.Size = New System.Drawing.Size(49, 13)
        Me.someLabelControl2.TabIndex = 0
        Me.someLabelControl2.Text = "Some Info"
        '
        'someLabelControl1
        '
        Me.someLabelControl1.Location = New System.Drawing.Point(3, 3)
        Me.someLabelControl1.Name = "someLabelControl1"
        Me.someLabelControl1.Size = New System.Drawing.Size(49, 13)
        Me.someLabelControl1.TabIndex = 0
        Me.someLabelControl1.Text = "Some Info"
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
        Me.AppImageCollection.Images.SetKeyName(79, "icos_79.png")
        Me.AppImageCollection.Images.SetKeyName(80, "icos_80.png")
        Me.AppImageCollection.Images.SetKeyName(81, "icos_85.png")
        '
        'btnSemaforo
        '
        Me.btnSemaforo.Caption = "Semáforo"
        Me.btnSemaforo.Id = 80
        Me.btnSemaforo.ImageIndex = 7
        Me.btnSemaforo.LargeImageIndex = 7
        Me.btnSemaforo.Name = "btnSemaforo"
        Me.btnSemaforo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnVariacion
        '
        Me.btnVariacion.Caption = "Variaciones"
        Me.btnVariacion.Id = 81
        Me.btnVariacion.ImageIndex = 8
        Me.btnVariacion.LargeImageIndex = 8
        Me.btnVariacion.Name = "btnVariacion"
        Me.btnVariacion.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
        '
        'btnSku
        '
        Me.btnSku.Caption = "Estadisticas Sku"
        Me.btnSku.Id = 82
        Me.btnSku.ImageIndex = 9
        Me.btnSku.LargeImageIndex = 9
        Me.btnSku.Name = "btnSku"
        Me.btnSku.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'btnFrecuencia
        '
        Me.btnFrecuencia.Caption = "Frecuencia"
        Me.btnFrecuencia.Id = 83
        Me.btnFrecuencia.ImageIndex = 10
        Me.btnFrecuencia.LargeImageIndex = 10
        Me.btnFrecuencia.Name = "btnFrecuencia"
        Me.btnFrecuencia.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'btnSupervisionMarca
        '
        Me.btnSupervisionMarca.Caption = "Marca para Supervision"
        Me.btnSupervisionMarca.Id = 84
        Me.btnSupervisionMarca.ImageIndex = 62
        Me.btnSupervisionMarca.LargeImageIndex = 62
        Me.btnSupervisionMarca.Name = "btnSupervisionMarca"
        '
        'btnSupervisionResumen
        '
        Me.btnSupervisionResumen.Caption = "E2-Marcados p Supervision"
        Me.btnSupervisionResumen.Id = 85
        Me.btnSupervisionResumen.ImageIndex = 12
        Me.btnSupervisionResumen.LargeImageIndex = 12
        Me.btnSupervisionResumen.Name = "btnSupervisionResumen"
        Me.btnSupervisionResumen.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
                    Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btnSupervisionValidar
        '
        Me.btnSupervisionValidar.Caption = "E4-Supervisiones por Validar"
        Me.btnSupervisionValidar.Id = 86
        Me.btnSupervisionValidar.ImageIndex = 64
        Me.btnSupervisionValidar.LargeImageIndex = 64
        Me.btnSupervisionValidar.Name = "btnSupervisionValidar"
        Me.btnSupervisionValidar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
        Me.btnSupervisionValidar.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
                    Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btnEstadistica
        '
        Me.btnEstadistica.Caption = "Estadistica Sku"
        Me.btnEstadistica.Id = 87
        Me.btnEstadistica.ImageIndex = 9
        Me.btnEstadistica.LargeImageIndex = 9
        Me.btnEstadistica.Name = "btnEstadistica"
        '
        'btnPropiedades
        '
        Me.btnPropiedades.Caption = "Propiedades"
        Me.btnPropiedades.Id = 88
        Me.btnPropiedades.ImageIndex = 15
        Me.btnPropiedades.LargeImageIndex = 15
        Me.btnPropiedades.Name = "btnPropiedades"
        Me.btnPropiedades.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnReplicarEncuesta
        '
        Me.btnReplicarEncuesta.Caption = "Replicar Anterior"
        Me.btnReplicarEncuesta.Id = 89
        Me.btnReplicarEncuesta.ImageIndex = 16
        Me.btnReplicarEncuesta.LargeImageIndex = 16
        Me.btnReplicarEncuesta.Name = "btnReplicarEncuesta"
        '
        'btnReplicarEncuestaPromedio
        '
        Me.btnReplicarEncuestaPromedio.Caption = "Replicar promedio"
        Me.btnReplicarEncuestaPromedio.Id = 90
        Me.btnReplicarEncuestaPromedio.ImageIndex = 17
        Me.btnReplicarEncuestaPromedio.LargeImageIndex = 17
        Me.btnReplicarEncuestaPromedio.Name = "btnReplicarEncuestaPromedio"
        '
        'btnReplicarSkuPromedio
        '
        Me.btnReplicarSkuPromedio.Caption = "Replicar Promedio"
        Me.btnReplicarSkuPromedio.Id = 91
        Me.btnReplicarSkuPromedio.ImageIndex = 18
        Me.btnReplicarSkuPromedio.LargeImageIndex = 18
        Me.btnReplicarSkuPromedio.Name = "btnReplicarSkuPromedio"
        '
        'btnCancelarReplicas
        '
        Me.btnCancelarReplicas.Caption = "Cancelar Ultimo Ajuste"
        Me.btnCancelarReplicas.Id = 92
        Me.btnCancelarReplicas.ImageIndex = 19
        Me.btnCancelarReplicas.LargeImageIndex = 19
        Me.btnCancelarReplicas.Name = "btnCancelarReplicas"
        Me.btnCancelarReplicas.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnVerDatosValidos
        '
        Me.btnVerDatosValidos.Caption = "Datos Válidos"
        Me.btnVerDatosValidos.Id = 93
        Me.btnVerDatosValidos.ImageIndex = 20
        Me.btnVerDatosValidos.LargeImageIndex = 20
        Me.btnVerDatosValidos.Name = "btnVerDatosValidos"
        Me.btnVerDatosValidos.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        Me.btnVerDatosValidos.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnVerDatosCampo
        '
        Me.btnVerDatosCampo.Caption = "Campo"
        Me.btnVerDatosCampo.Description = "Tipo de dato actualizado o registrado por el Auditor. (Datos Reales)"
        Me.btnVerDatosCampo.Id = 94
        Me.btnVerDatosCampo.ImageIndex = 21
        Me.btnVerDatosCampo.LargeImageIndex = 21
        Me.btnVerDatosCampo.Name = "btnVerDatosCampo"
        Me.btnVerDatosCampo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
        '
        'btnVerDatosSupervision
        '
        Me.btnVerDatosSupervision.Caption = "Supervisión"
        Me.btnVerDatosSupervision.Description = "Tipo de dato actualizado o registrado por el Area de Supervision"
        Me.btnVerDatosSupervision.Id = 95
        Me.btnVerDatosSupervision.ImageIndex = 22
        Me.btnVerDatosSupervision.LargeImageIndex = 22
        Me.btnVerDatosSupervision.Name = "btnVerDatosSupervision"
        Me.btnVerDatosSupervision.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
        '
        'btnVerDatosAjustado
        '
        Me.btnVerDatosAjustado.Caption = "Consistencia"
        Me.btnVerDatosAjustado.Description = "Tipo de dato manipulado por el Area de Consistencia y valido para los procesos."
        Me.btnVerDatosAjustado.Id = 96
        Me.btnVerDatosAjustado.ImageIndex = 23
        Me.btnVerDatosAjustado.LargeImageIndex = 23
        Me.btnVerDatosAjustado.Name = "btnVerDatosAjustado"
        Me.btnVerDatosAjustado.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnVerTodos
        '
        Me.btnVerTodos.Caption = "Todos"
        Me.btnVerTodos.Id = 97
        Me.btnVerTodos.ImageIndex = 24
        Me.btnVerTodos.LargeImageIndex = 24
        Me.btnVerTodos.Name = "btnVerTodos"
        '
        'btnSemaforoAlertas
        '
        Me.btnSemaforoAlertas.Caption = "Alertas"
        Me.btnSemaforoAlertas.Id = 99
        Me.btnSemaforoAlertas.ImageIndex = 25
        Me.btnSemaforoAlertas.LargeImageIndex = 25
        Me.btnSemaforoAlertas.Name = "btnSemaforoAlertas"
        '
        'btnSemaforoOk
        '
        Me.btnSemaforoOk.Caption = "Ok"
        Me.btnSemaforoOk.Id = 100
        Me.btnSemaforoOk.ImageIndex = 26
        Me.btnSemaforoOk.LargeImageIndex = 26
        Me.btnSemaforoOk.Name = "btnSemaforoOk"
        '
        'btnSemaforoTodos
        '
        Me.btnSemaforoTodos.Caption = "Todos"
        Me.btnSemaforoTodos.Id = 101
        Me.btnSemaforoTodos.ImageIndex = 27
        Me.btnSemaforoTodos.LargeImageIndex = 27
        Me.btnSemaforoTodos.Name = "btnSemaforoTodos"
        '
        'btnGestionRangos
        '
        Me.btnGestionRangos.Caption = "Gestión de Rangos"
        Me.btnGestionRangos.Id = 102
        Me.btnGestionRangos.ImageIndex = 28
        Me.btnGestionRangos.Name = "btnGestionRangos"
        Me.btnGestionRangos.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
                    Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Caption = "Excel"
        Me.btnExportarExcel.Id = 103
        Me.btnExportarExcel.ImageIndex = 29
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.btnExportarExcel.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
                    Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btnExportarPDF
        '
        Me.btnExportarPDF.Caption = "PDF"
        Me.btnExportarPDF.Id = 104
        Me.btnExportarPDF.ImageIndex = 30
        Me.btnExportarPDF.Name = "btnExportarPDF"
        Me.btnExportarPDF.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
                    Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btnExportarCSV
        '
        Me.btnExportarCSV.Caption = "CSV"
        Me.btnExportarCSV.Id = 105
        Me.btnExportarCSV.ImageIndex = 31
        Me.btnExportarCSV.LargeImageIndex = 31
        Me.btnExportarCSV.Name = "btnExportarCSV"
        Me.btnExportarCSV.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
                    Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btnExportarXML
        '
        Me.btnExportarXML.Caption = "XML"
        Me.btnExportarXML.Id = 106
        Me.btnExportarXML.ImageIndex = 32
        Me.btnExportarXML.LargeImageIndex = 2
        Me.btnExportarXML.Name = "btnExportarXML"
        '
        'btnVistaPrevia
        '
        Me.btnVistaPrevia.Caption = "Vista Previa"
        Me.btnVistaPrevia.Id = 107
        Me.btnVistaPrevia.ImageIndex = 35
        Me.btnVistaPrevia.LargeImageIndex = 35
        Me.btnVistaPrevia.Name = "btnVistaPrevia"
        '
        'btnImprimir
        '
        Me.btnImprimir.Caption = "Imprimir"
        Me.btnImprimir.Id = 108
        Me.btnImprimir.ImageIndex = 36
        Me.btnImprimir.LargeImageIndex = 36
        Me.btnImprimir.Name = "btnImprimir"
        '
        'btnPanelControl
        '
        Me.btnPanelControl.Caption = "Panel de Control"
        Me.btnPanelControl.Id = 109
        Me.btnPanelControl.ImageIndex = 37
        Me.btnPanelControl.Name = "btnPanelControl"
        Me.btnPanelControl.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
                    Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btnControlAvance
        '
        Me.btnControlAvance.Caption = "Control Avance"
        Me.btnControlAvance.Id = 110
        Me.btnControlAvance.ImageIndex = 0
        Me.btnControlAvance.LargeImageIndex = 0
        Me.btnControlAvance.Name = "btnControlAvance"
        Me.btnControlAvance.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnGrabar
        '
        Me.btnGrabar.Caption = "&Grabar Cambios"
        Me.btnGrabar.Id = 111
        Me.btnGrabar.ImageIndex = 40
        Me.btnGrabar.LargeImageIndex = 40
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnSalir
        '
        Me.btnSalir.Caption = "Salir"
        Me.btnSalir.Id = 112
        Me.btnSalir.ImageIndex = 41
        Me.btnSalir.LargeImageIndex = 41
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
                    Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btnReal
        '
        Me.btnReal.Caption = "Real"
        Me.btnReal.Edit = Me.rpItemCheckReal
        Me.btnReal.Id = 116
        Me.btnReal.ImageIndex = 1
        Me.btnReal.LargeImageIndex = 1
        Me.btnReal.Name = "btnReal"
        '
        'rpItemCheckReal
        '
        Me.rpItemCheckReal.AutoHeight = False
        Me.rpItemCheckReal.Name = "rpItemCheckReal"
        '
        'btnAnalizada
        '
        Me.btnAnalizada.Caption = "Analizada"
        Me.btnAnalizada.Edit = Me.rpItemCheckAnalizada
        Me.btnAnalizada.Id = 121
        Me.btnAnalizada.ImageIndex = 19
        Me.btnAnalizada.LargeImageIndex = 19
        Me.btnAnalizada.Name = "btnAnalizada"
        Me.btnAnalizada.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'rpItemCheckAnalizada
        '
        Me.rpItemCheckAnalizada.AutoHeight = False
        Me.rpItemCheckAnalizada.Name = "rpItemCheckAnalizada"
        '
        'bbPanel
        '
        Me.bbPanel.Caption = "Panel de Control"
        Me.bbPanel.Id = 129
        Me.bbPanel.Name = "bbPanel"
        Me.bbPanel.Tag = 14
        '
        'bbAvance
        '
        Me.bbAvance.Caption = "Avance"
        Me.bbAvance.Id = 130
        Me.bbAvance.Name = "bbAvance"
        Me.bbAvance.Tag = 15
        '
        'bbIndicador01
        '
        Me.bbIndicador01.Caption = "Indicador 01"
        Me.bbIndicador01.Id = 131
        Me.bbIndicador01.Name = "bbIndicador01"
        Me.bbIndicador01.Tag = 1
        '
        'bbIndicador02
        '
        Me.bbIndicador02.Caption = "Indicador 02"
        Me.bbIndicador02.Id = 132
        Me.bbIndicador02.Name = "bbIndicador02"
        Me.bbIndicador02.Tag = 2
        '
        'siStatus
        '
        Me.siStatus.Caption = "Espere un momento, se esta cargando la informacion ..."
        Me.siStatus.Id = 133
        Me.siStatus.ImageIndex = 70
        Me.siStatus.LargeImageIndex = 70
        Me.siStatus.Name = "siStatus"
        Me.siStatus.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'bbIndicador03
        '
        Me.bbIndicador03.Caption = "Indicador 03"
        Me.bbIndicador03.Id = 135
        Me.bbIndicador03.Name = "bbIndicador03"
        Me.bbIndicador03.Tag = 3
        '
        'bbIndicador04
        '
        Me.bbIndicador04.Caption = "Indicador 04"
        Me.bbIndicador04.Id = 136
        Me.bbIndicador04.Name = "bbIndicador04"
        Me.bbIndicador04.Tag = 4
        '
        'bbIndicador05
        '
        Me.bbIndicador05.Caption = "Indicador 05"
        Me.bbIndicador05.Id = 137
        Me.bbIndicador05.Name = "bbIndicador05"
        '
        'bbIndicador06
        '
        Me.bbIndicador06.Caption = "Indicador 06"
        Me.bbIndicador06.Id = 138
        Me.bbIndicador06.Name = "bbIndicador06"
        '
        'bbIndicador07
        '
        Me.bbIndicador07.Caption = "Indicador 07"
        Me.bbIndicador07.Id = 139
        Me.bbIndicador07.Name = "bbIndicador07"
        '
        'bbIndicador08
        '
        Me.bbIndicador08.Caption = "Indicador 08"
        Me.bbIndicador08.Id = 140
        Me.bbIndicador08.Name = "bbIndicador08"
        '
        'bbIndicador09
        '
        Me.bbIndicador09.Caption = "Indicador 09"
        Me.bbIndicador09.Id = 141
        Me.bbIndicador09.Name = "bbIndicador09"
        '
        'bbIndicador10
        '
        Me.bbIndicador10.Caption = "Indicador 10"
        Me.bbIndicador10.Id = 142
        Me.bbIndicador10.Name = "bbIndicador10"
        '
        'bbIndicador11
        '
        Me.bbIndicador11.Caption = "Indicador 11"
        Me.bbIndicador11.Id = 143
        Me.bbIndicador11.Name = "bbIndicador11"
        '
        'bbIndicador12
        '
        Me.bbIndicador12.Caption = "Indicador 12"
        Me.bbIndicador12.Id = 144
        Me.bbIndicador12.Name = "bbIndicador12"
        '
        'bbEncuesta
        '
        Me.bbEncuesta.Caption = "Encuesta"
        Me.bbEncuesta.Id = 145
        Me.bbEncuesta.Name = "bbEncuesta"
        Me.bbEncuesta.Tag = 17
        '
        'bbRangos
        '
        Me.bbRangos.Caption = "Gestion de Rangos"
        Me.bbRangos.Id = 146
        Me.bbRangos.ImageIndex = 28
        Me.bbRangos.LargeImageIndex = 28
        Me.bbRangos.Name = "bbRangos"
        Me.bbRangos.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        Me.bbRangos.Tag = 16
        '
        'btnAcerca
        '
        Me.btnAcerca.Caption = "Acerca de ..."
        Me.btnAcerca.Id = 166
        Me.btnAcerca.ImageIndex = 42
        Me.btnAcerca.LargeImageIndex = 42
        Me.btnAcerca.Name = "btnAcerca"
        Me.btnAcerca.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
                    Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'bitemUsuario
        '
        Me.bitemUsuario.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.bitemUsuario.Caption = "Usuario"
        Me.bitemUsuario.Description = "Usuario de sesion"
        Me.bitemUsuario.Hint = "Nombre del usuario logeado en esta sesion"
        Me.bitemUsuario.Id = 168
        Me.bitemUsuario.ImageIndex = 50
        Me.bitemUsuario.Name = "bitemUsuario"
        Me.bitemUsuario.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'bsiServidor
        '
        Me.bsiServidor.Caption = "Servidor : "
        Me.bsiServidor.Id = 169
        Me.bsiServidor.ImageIndex = 52
        Me.bsiServidor.Name = "bsiServidor"
        Me.bsiServidor.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'bsiBD
        '
        Me.bsiBD.Caption = "Base de datos: "
        Me.bsiBD.Id = 170
        Me.bsiBD.ImageIndex = 51
        Me.bsiBD.Name = "bsiBD"
        Me.bsiBD.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'rgbSkins
        '
        Me.rgbSkins.Caption = "Mascaras"
        '
        '
        '
        Me.rgbSkins.Gallery.AllowHoverImages = True
        Me.rgbSkins.Gallery.ColumnCount = 10
        Me.rgbSkins.Gallery.FixedHoverImageSize = False
        Me.rgbSkins.Gallery.ImageSize = New System.Drawing.Size(32, 32)
        Me.rgbSkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top
        Me.rgbSkins.Gallery.MinimumColumnCount = 8
        Me.rgbSkins.Gallery.RowCount = 5
        Me.rgbSkins.Id = 172
        Me.rgbSkins.Name = "rgbSkins"
        '
        'btnSincronizar
        '
        Me.btnSincronizar.Caption = "&Ver mas..."
        Me.btnSincronizar.Id = 173
        Me.btnSincronizar.ImageIndex = 39
        Me.btnSincronizar.LargeImageIndex = 39
        Me.btnSincronizar.Name = "btnSincronizar"
        Me.btnSincronizar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        Me.btnSincronizar.Tag = CType(39, Short)
        '
        'btnPlantilla03
        '
        Me.btnPlantilla03.Caption = "Encuesta"
        Me.btnPlantilla03.Id = 173
        Me.btnPlantilla03.Name = "btnPlantilla03"
        '
        'btnVenta
        '
        Me.btnVenta.Caption = "Venta"
        Me.btnVenta.Id = 177
        Me.btnVenta.Name = "btnVenta"
        '
        'btnCompra
        '
        Me.btnCompra.Caption = "Compra"
        Me.btnCompra.Id = 178
        Me.btnCompra.Name = "btnCompra"
        '
        'btnInventarios
        '
        Me.btnInventarios.Caption = "Inventario"
        Me.btnInventarios.Id = 179
        Me.btnInventarios.Name = "btnInventarios"
        '
        'btnPrecio
        '
        Me.btnPrecio.Caption = "Precio"
        Me.btnPrecio.Id = 180
        Me.btnPrecio.Name = "btnPrecio"
        '
        'btnRegistros
        '
        Me.btnRegistros.Caption = "Registros"
        Me.btnRegistros.Id = 181
        Me.btnRegistros.Name = "btnRegistros"
        Me.btnRegistros.Tag = "43"
        '
        'btnVariablesTodos
        '
        Me.btnVariablesTodos.Caption = "Todos"
        Me.btnVariablesTodos.Id = 182
        Me.btnVariablesTodos.Name = "btnVariablesTodos"
        Me.btnVariablesTodos.Tag = "44"
        '
        'btnVariablesNinguno
        '
        Me.btnVariablesNinguno.Caption = "Ninguno"
        Me.btnVariablesNinguno.Id = 183
        Me.btnVariablesNinguno.Name = "btnVariablesNinguno"
        Me.btnVariablesNinguno.Tag = "45"
        '
        'btnCambiarEstado
        '
        Me.btnCambiarEstado.Caption = "Poner Atipico"
        Me.btnCambiarEstado.Id = 184
        Me.btnCambiarEstado.ImageIndex = 46
        Me.btnCambiarEstado.LargeImageIndex = 46
        Me.btnCambiarEstado.Name = "btnCambiarEstado"
        Me.btnCambiarEstado.Tag = "46"
        '
        'btnVaciar
        '
        Me.btnVaciar.Caption = "Vaciar Cambios"
        Me.btnVaciar.Id = 185
        Me.btnVaciar.ImageIndex = 47
        Me.btnVaciar.LargeImageIndex = 47
        Me.btnVaciar.Name = "btnVaciar"
        Me.btnVaciar.Tag = "47"
        '
        'btnReplicaSKU
        '
        Me.btnReplicaSKU.Caption = "Replicar Anterior"
        Me.btnReplicaSKU.Id = 186
        Me.btnReplicaSKU.ImageIndex = 18
        Me.btnReplicaSKU.LargeImageIndex = 18
        Me.btnReplicaSKU.Name = "btnReplicaSKU"
        '
        'btnActivar
        '
        Me.btnActivar.Caption = "Activar Negocio"
        Me.btnActivar.Id = 187
        Me.btnActivar.ImageIndex = 20
        Me.btnActivar.LargeImageIndex = 20
        Me.btnActivar.Name = "btnActivar"
        Me.btnActivar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'bsiProgreso
        '
        Me.bsiProgreso.Caption = "Cargando..."
        Me.bsiProgreso.Edit = Me.RepositoryItemMarqueeProgressBar1
        Me.bsiProgreso.Glyph = Global.CCRCCV2.My.Resources.Resources.process
        Me.bsiProgreso.Id = 188
        Me.bsiProgreso.Name = "bsiProgreso"
        Me.bsiProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing
        Me.bsiProgreso.Width = 300
        '
        'RepositoryItemMarqueeProgressBar1
        '
        Me.RepositoryItemMarqueeProgressBar1.Name = "RepositoryItemMarqueeProgressBar1"
        '
        'btnCorrectos
        '
        Me.btnCorrectos.Caption = "E0-Correcto"
        Me.btnCorrectos.Id = 189
        Me.btnCorrectos.ImageIndex = 60
        Me.btnCorrectos.LargeImageIndex = 60
        Me.btnCorrectos.Name = "btnCorrectos"
        Me.btnCorrectos.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
                    Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btnPendientes
        '
        Me.btnPendientes.Caption = "E1-Pendiente"
        Me.btnPendientes.Id = 190
        Me.btnPendientes.ImageIndex = 61
        Me.btnPendientes.LargeImageIndex = 61
        Me.btnPendientes.Name = "btnPendientes"
        Me.btnPendientes.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
                    Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btnEnSupervision
        '
        Me.btnEnSupervision.Caption = "E3-En Supervision"
        Me.btnEnSupervision.Id = 191
        Me.btnEnSupervision.ImageIndex = 63
        Me.btnEnSupervision.LargeImageIndex = 63
        Me.btnEnSupervision.Name = "btnEnSupervision"
        Me.btnEnSupervision.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
                    Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btnValidados
        '
        Me.btnValidados.Caption = "E5-Validado"
        Me.btnValidados.Id = 192
        Me.btnValidados.ImageIndex = 65
        Me.btnValidados.LargeImageIndex = 65
        Me.btnValidados.Name = "btnValidados"
        Me.btnValidados.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
                    Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btnAtipicos
        '
        Me.btnAtipicos.Caption = "E6-Atipico"
        Me.btnAtipicos.Id = 193
        Me.btnAtipicos.ImageIndex = 46
        Me.btnAtipicos.LargeImageIndex = 46
        Me.btnAtipicos.Name = "btnAtipicos"
        Me.btnAtipicos.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
                    Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btnNoProcesa
        '
        Me.btnNoProcesa.Caption = "E7-No Procesa"
        Me.btnNoProcesa.Id = 194
        Me.btnNoProcesa.ImageIndex = 67
        Me.btnNoProcesa.LargeImageIndex = 67
        Me.btnNoProcesa.Name = "btnNoProcesa"
        Me.btnNoProcesa.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
                    Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btnCongelar
        '
        Me.btnCongelar.Caption = "Congelar Col"
        Me.btnCongelar.Description = "Congelar columnas"
        Me.btnCongelar.Id = 195
        Me.btnCongelar.ImageIndex = 71
        Me.btnCongelar.LargeImageIndex = 71
        Me.btnCongelar.Name = "btnCongelar"
        Me.btnCongelar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnEstadoTodos
        '
        Me.btnEstadoTodos.Caption = "Todos"
        Me.btnEstadoTodos.Description = "Muestra Todos los estados"
        Me.btnEstadoTodos.Id = 198
        Me.btnEstadoTodos.ImageIndex = 72
        Me.btnEstadoTodos.LargeImageIndex = 72
        Me.btnEstadoTodos.Name = "btnEstadoTodos"
        Me.btnEstadoTodos.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
                    Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btnRecargar
        '
        Me.btnRecargar.Caption = "Re-actualizar datos"
        Me.btnRecargar.Id = 199
        Me.btnRecargar.ImageIndex = 73
        Me.btnRecargar.LargeImageIndex = 73
        Me.btnRecargar.Name = "btnRecargar"
        '
        'btnCambiarEstadoNoProcesa
        '
        Me.btnCambiarEstadoNoProcesa.Caption = "Poner No Procesa"
        Me.btnCambiarEstadoNoProcesa.Id = 200
        Me.btnCambiarEstadoNoProcesa.ImageIndex = 67
        Me.btnCambiarEstadoNoProcesa.LargeImageIndex = 67
        Me.btnCambiarEstadoNoProcesa.Name = "btnCambiarEstadoNoProcesa"
        '
        'btnGestionSupervision
        '
        Me.btnGestionSupervision.Caption = "Gestion de Supervision"
        Me.btnGestionSupervision.Description = "Abre la pestaña para Gestionar los negocios de cara a supervision"
        Me.btnGestionSupervision.Hint = "Gestion de Supervision"
        Me.btnGestionSupervision.Id = 201
        Me.btnGestionSupervision.ImageIndex = 79
        Me.btnGestionSupervision.LargeImageIndex = 79
        Me.btnGestionSupervision.Name = "btnGestionSupervision"
        Me.btnGestionSupervision.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnEnviaSupervision
        '
        Me.btnEnviaSupervision.Caption = "Envia a Supervision"
        Me.btnEnviaSupervision.Hint = "Envia a Supervision"
        Me.btnEnviaSupervision.Id = 202
        Me.btnEnviaSupervision.ImageIndex = 80
        Me.btnEnviaSupervision.LargeImageIndex = 80
        Me.btnEnviaSupervision.Name = "btnEnviaSupervision"
        Me.btnEnviaSupervision.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnSkuPonerAtipico
        '
        Me.btnSkuPonerAtipico.Caption = "Poner Atipico"
        Me.btnSkuPonerAtipico.Id = 203
        Me.btnSkuPonerAtipico.ImageIndex = 46
        Me.btnSkuPonerAtipico.LargeImageIndex = 46
        Me.btnSkuPonerAtipico.Name = "btnSkuPonerAtipico"
        '
        'btnSkuPonerNoProcesa
        '
        Me.btnSkuPonerNoProcesa.Caption = "Poner No Procesa"
        Me.btnSkuPonerNoProcesa.Id = 204
        Me.btnSkuPonerNoProcesa.ImageIndex = 67
        Me.btnSkuPonerNoProcesa.LargeImageIndex = 67
        Me.btnSkuPonerNoProcesa.Name = "btnSkuPonerNoProcesa"
        '
        'btnSkuActivarRegistro
        '
        Me.btnSkuActivarRegistro.Caption = "Activar Registro"
        Me.btnSkuActivarRegistro.Id = 205
        Me.btnSkuActivarRegistro.ImageIndex = 20
        Me.btnSkuActivarRegistro.LargeImageIndex = 20
        Me.btnSkuActivarRegistro.Name = "btnSkuActivarRegistro"
        '
        'btnActivarSupervision
        '
        Me.btnActivarSupervision.Caption = "Activa Supervision"
        Me.btnActivarSupervision.Description = "Activa la encuesta editada por Supervision"
        Me.btnActivarSupervision.Id = 206
        Me.btnActivarSupervision.ImageIndex = 20
        Me.btnActivarSupervision.LargeImageIndex = 20
        Me.btnActivarSupervision.Name = "btnActivarSupervision"
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
        Me.AppImageCollectionLarge.Images.SetKeyName(71, "icol_71_congelar.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(72, "icol_72_Estado_todos.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(73, "icol_73_recargar.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(74, "icol_74.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(75, "icol_75_poner_atipico.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(76, "icol_76.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(77, "icol_77.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(78, "icol_78.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(79, "icol_79.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(80, "icol_80.png")
        Me.AppImageCollectionLarge.Images.SetKeyName(81, "icol_85.png")
        '
        'ribbonCategorySupervision
        '
        Me.ribbonCategorySupervision.Color = System.Drawing.Color.Empty
        Me.ribbonCategorySupervision.Name = "ribbonCategorySupervision"
        Me.ribbonCategorySupervision.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPageSupervision})
        Me.ribbonCategorySupervision.Text = "Gestion Supervision"
        '
        'ribbonPageSupervision
        '
        Me.ribbonPageSupervision.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgGestionSupervision, Me.rpgGestionSupervisionEncuesta, Me.rpgGestionSupervisionEstadoNegocio})
        Me.ribbonPageSupervision.Name = "ribbonPageSupervision"
        Me.ribbonPageSupervision.Text = "Gestion Supervision"
        '
        'rpgGestionSupervision
        '
        Me.rpgGestionSupervision.ItemLinks.Add(Me.btnGestionSupervision)
        Me.rpgGestionSupervision.Name = "rpgGestionSupervision"
        Me.rpgGestionSupervision.Text = "Gestion Supervision Grupo"
        '
        'rpgGestionSupervisionEncuesta
        '
        Me.rpgGestionSupervisionEncuesta.ItemLinks.Add(Me.btnEnviaSupervision)
        Me.rpgGestionSupervisionEncuesta.ItemLinks.Add(Me.btnActivarSupervision)
        Me.rpgGestionSupervisionEncuesta.ItemLinks.Add(Me.btnActivar)
        Me.rpgGestionSupervisionEncuesta.ItemLinks.Add(Me.btnCambiarEstadoNoProcesa)
        Me.rpgGestionSupervisionEncuesta.ItemLinks.Add(Me.btnCambiarEstado)
        Me.rpgGestionSupervisionEncuesta.Name = "rpgGestionSupervisionEncuesta"
        Me.rpgGestionSupervisionEncuesta.Text = "Negocio"
        Me.rpgGestionSupervisionEncuesta.Visible = False
        '
        'rpgGestionSupervisionEstadoNegocio
        '
        Me.rpgGestionSupervisionEstadoNegocio.ItemLinks.Add(Me.btnCorrectos)
        Me.rpgGestionSupervisionEstadoNegocio.ItemLinks.Add(Me.btnPendientes)
        Me.rpgGestionSupervisionEstadoNegocio.ItemLinks.Add(Me.btnSupervisionResumen)
        Me.rpgGestionSupervisionEstadoNegocio.ItemLinks.Add(Me.btnEnSupervision)
        Me.rpgGestionSupervisionEstadoNegocio.ItemLinks.Add(Me.btnSupervisionValidar)
        Me.rpgGestionSupervisionEstadoNegocio.ItemLinks.Add(Me.btnValidados)
        Me.rpgGestionSupervisionEstadoNegocio.ItemLinks.Add(Me.btnAtipicos)
        Me.rpgGestionSupervisionEstadoNegocio.ItemLinks.Add(Me.btnNoProcesa)
        Me.rpgGestionSupervisionEstadoNegocio.ItemLinks.Add(Me.btnEstadoTodos)
        Me.rpgGestionSupervisionEstadoNegocio.Name = "rpgGestionSupervisionEstadoNegocio"
        Me.rpgGestionSupervisionEstadoNegocio.Text = "Filtro Estado del Negocio"
        Me.rpgGestionSupervisionEstadoNegocio.Visible = False
        '
        'RibbonPageCategory1
        '
        Me.RibbonPageCategory1.Color = System.Drawing.Color.Empty
        Me.RibbonPageCategory1.Name = "RibbonPageCategory1"
        Me.RibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage3})
        Me.RibbonPageCategory1.Text = "Gestion de Rangos"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.groupRangos})
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "Rangos"
        '
        'groupRangos
        '
        Me.groupRangos.ItemLinks.Add(Me.btnGestionRangos)
        Me.groupRangos.Name = "groupRangos"
        Me.groupRangos.Text = "Rangos"
        '
        'RibbonPageCategory2
        '
        Me.RibbonPageCategory2.Color = System.Drawing.Color.Empty
        Me.RibbonPageCategory2.Name = "RibbonPageCategory2"
        Me.RibbonPageCategory2.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage4})
        Me.RibbonPageCategory2.Text = "Exportar Datos"
        '
        'RibbonPage4
        '
        Me.RibbonPage4.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.groupImprimir, Me.groupExportar})
        Me.RibbonPage4.Name = "RibbonPage4"
        Me.RibbonPage4.Text = "Exportar"
        '
        'groupImprimir
        '
        Me.groupImprimir.ItemLinks.Add(Me.btnVistaPrevia)
        Me.groupImprimir.ItemLinks.Add(Me.btnImprimir)
        Me.groupImprimir.Name = "groupImprimir"
        Me.groupImprimir.Text = "Imprimir"
        '
        'groupExportar
        '
        Me.groupExportar.ItemLinks.Add(Me.btnExportarExcel)
        Me.groupExportar.ItemLinks.Add(Me.btnExportarPDF)
        Me.groupExportar.ItemLinks.Add(Me.btnExportarCSV)
        Me.groupExportar.ItemLinks.Add(Me.btnExportarXML)
        Me.groupExportar.Name = "groupExportar"
        Me.groupExportar.Text = "Exportar"
        '
        'RibbonPageCategoryGallery
        '
        Me.RibbonPageCategoryGallery.Color = System.Drawing.Color.Empty
        Me.RibbonPageCategoryGallery.Name = "RibbonPageCategoryGallery"
        Me.RibbonPageCategoryGallery.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage7})
        Me.RibbonPageCategoryGallery.Text = "Galerias"
        '
        'RibbonPage7
        '
        Me.RibbonPage7.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgGaleria})
        Me.RibbonPage7.Name = "RibbonPage7"
        Me.RibbonPage7.Text = "Galerias"
        '
        'rpgGaleria
        '
        Me.rpgGaleria.ItemLinks.Add(Me.rgbSkins)
        Me.rpgGaleria.Name = "rpgGaleria"
        Me.rpgGaleria.Text = "Galeria de Mascaras"
        '
        'RibbonPageCategoryAcerca
        '
        Me.RibbonPageCategoryAcerca.Color = System.Drawing.Color.Empty
        Me.RibbonPageCategoryAcerca.Name = "RibbonPageCategoryAcerca"
        Me.RibbonPageCategoryAcerca.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage6})
        Me.RibbonPageCategoryAcerca.Text = "Acerca"
        '
        'RibbonPage6
        '
        Me.RibbonPage6.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
        Me.RibbonPage6.ImageIndex = 42
        Me.RibbonPage6.Name = "RibbonPage6"
        Me.RibbonPage6.Text = "Acerca de.."
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnAcerca)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Acerca de"
        '
        'rbCintaOpcionesEncuesta
        '
        Me.rbCintaOpcionesEncuesta.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup4, Me.groupVariables, Me.groupIndicadores, Me.groupSemaforo, Me.groupSupervision, Me.RibbonPageGroup3, Me.rpgEstado, Me.groupEstandar})
        Me.rbCintaOpcionesEncuesta.Name = "rbCintaOpcionesEncuesta"
        Me.rbCintaOpcionesEncuesta.Text = "Estandar"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnRecargar)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnSincronizar)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Datos"
        '
        'groupVariables
        '
        Me.groupVariables.ItemLinks.Add(Me.btnVenta)
        Me.groupVariables.ItemLinks.Add(Me.btnCompra)
        Me.groupVariables.ItemLinks.Add(Me.btnInventarios)
        Me.groupVariables.ItemLinks.Add(Me.btnPrecio)
        Me.groupVariables.ItemLinks.Add(Me.btnRegistros)
        Me.groupVariables.ItemLinks.Add(Me.btnVariablesTodos)
        Me.groupVariables.ItemLinks.Add(Me.btnVariablesNinguno)
        Me.groupVariables.Name = "groupVariables"
        Me.groupVariables.Text = "Variables"
        '
        'groupIndicadores
        '
        Me.groupIndicadores.ItemLinks.Add(Me.btnSemaforo)
        Me.groupIndicadores.ItemLinks.Add(Me.btnVariacion)
        Me.groupIndicadores.ItemLinks.Add(Me.btnSku)
        Me.groupIndicadores.ItemLinks.Add(Me.btnFrecuencia)
        Me.groupIndicadores.Name = "groupIndicadores"
        Me.groupIndicadores.Text = "Indicadores"
        '
        'groupSemaforo
        '
        Me.groupSemaforo.ItemLinks.Add(Me.btnSemaforoAlertas)
        Me.groupSemaforo.ItemLinks.Add(Me.btnSemaforoOk)
        Me.groupSemaforo.ItemLinks.Add(Me.btnSemaforoTodos)
        Me.groupSemaforo.Name = "groupSemaforo"
        Me.groupSemaforo.Text = "Semáforo"
        '
        'groupSupervision
        '
        Me.groupSupervision.ItemLinks.Add(Me.btnSupervisionMarca)
        Me.groupSupervision.ItemLinks.Add(Me.btnSupervisionResumen)
        Me.groupSupervision.ItemLinks.Add(Me.btnSupervisionValidar)
        Me.groupSupervision.Name = "groupSupervision"
        Me.groupSupervision.Text = "Supervisión"
        Me.groupSupervision.Visible = False
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnVerDatosCampo)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnVerDatosSupervision)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnVerDatosAjustado)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnVerTodos)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Filtro po Tipo de Dato"
        '
        'rpgEstado
        '
        Me.rpgEstado.ItemLinks.Add(Me.btnCorrectos)
        Me.rpgEstado.ItemLinks.Add(Me.btnPendientes)
        Me.rpgEstado.ItemLinks.Add(Me.btnSupervisionResumen)
        Me.rpgEstado.ItemLinks.Add(Me.btnEnSupervision)
        Me.rpgEstado.ItemLinks.Add(Me.btnSupervisionValidar)
        Me.rpgEstado.ItemLinks.Add(Me.btnValidados)
        Me.rpgEstado.ItemLinks.Add(Me.btnAtipicos)
        Me.rpgEstado.ItemLinks.Add(Me.btnNoProcesa)
        Me.rpgEstado.ItemLinks.Add(Me.btnEstadoTodos)
        Me.rpgEstado.Name = "rpgEstado"
        Me.rpgEstado.Text = "Filtro Estado del Negocio"
        '
        'groupEstandar
        '
        Me.groupEstandar.ItemLinks.Add(Me.btnCongelar)
        Me.groupEstandar.ItemLinks.Add(Me.btnGrabar)
        Me.groupEstandar.ItemLinks.Add(Me.btnSalir)
        Me.groupEstandar.Name = "groupEstandar"
        Me.groupEstandar.Text = "Estándar"
        '
        'RibbonPage5
        '
        Me.RibbonPage5.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.groupAjusteEncuesta, Me.groupSKU, Me.groupFiltros, Me.groupData, Me.groupVarios})
        Me.RibbonPage5.Name = "RibbonPage5"
        Me.RibbonPage5.Text = "Negocio"
        '
        'groupAjusteEncuesta
        '
        Me.groupAjusteEncuesta.ItemLinks.Add(Me.btnReplicarEncuesta)
        Me.groupAjusteEncuesta.ItemLinks.Add(Me.btnReplicarEncuestaPromedio)
        Me.groupAjusteEncuesta.ItemLinks.Add(Me.btnCambiarEstado)
        Me.groupAjusteEncuesta.ItemLinks.Add(Me.btnCambiarEstadoNoProcesa)
        Me.groupAjusteEncuesta.ItemLinks.Add(Me.btnActivar)
        Me.groupAjusteEncuesta.ItemLinks.Add(Me.btnSupervisionMarca)
        Me.groupAjusteEncuesta.ItemLinks.Add(Me.btnEnviaSupervision)
        Me.groupAjusteEncuesta.Name = "groupAjusteEncuesta"
        Me.groupAjusteEncuesta.Text = " Negocio"
        '
        'groupSKU
        '
        Me.groupSKU.ItemLinks.Add(Me.btnReplicaSKU)
        Me.groupSKU.ItemLinks.Add(Me.btnReplicarSkuPromedio)
        Me.groupSKU.ItemLinks.Add(Me.btnEstadistica)
        Me.groupSKU.ItemLinks.Add(Me.btnPropiedades)
        Me.groupSKU.ItemLinks.Add(Me.btnSkuPonerAtipico)
        Me.groupSKU.ItemLinks.Add(Me.btnSkuPonerNoProcesa)
        Me.groupSKU.ItemLinks.Add(Me.btnSkuActivarRegistro)
        Me.groupSKU.Name = "groupSKU"
        Me.groupSKU.Text = "Sku"
        '
        'groupFiltros
        '
        Me.groupFiltros.ItemLinks.Add(Me.btnVerDatosValidos)
        Me.groupFiltros.ItemLinks.Add(Me.btnVerDatosCampo)
        Me.groupFiltros.ItemLinks.Add(Me.btnVerDatosSupervision)
        Me.groupFiltros.ItemLinks.Add(Me.btnVerDatosAjustado)
        Me.groupFiltros.ItemLinks.Add(Me.btnVerTodos)
        Me.groupFiltros.Name = "groupFiltros"
        Me.groupFiltros.Text = "Filtros"
        '
        'groupData
        '
        Me.groupData.ItemLinks.Add(Me.btnReal)
        Me.groupData.ItemLinks.Add(Me.btnAnalizada)
        Me.groupData.Name = "groupData"
        Me.groupData.Text = "Tipo de Dato"
        Me.groupData.Visible = False
        '
        'groupVarios
        '
        Me.groupVarios.ItemLinks.Add(Me.btnEditSkuCanal)
        Me.groupVarios.ItemLinks.Add(Me.btnVaciar)
        Me.groupVarios.ItemLinks.Add(Me.btnGrabar)
        Me.groupVarios.Name = "groupVarios"
        Me.groupVarios.Text = "Otros"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.groupPanelControlAvance, Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Plantillas"
        Me.RibbonPage1.Visible = False
        '
        'groupPanelControlAvance
        '
        Me.groupPanelControlAvance.ItemLinks.Add(Me.btnPanelControl)
        Me.groupPanelControlAvance.ItemLinks.Add(Me.btnControlAvance)
        Me.groupPanelControlAvance.Name = "groupPanelControlAvance"
        Me.groupPanelControlAvance.ShowCaptionButton = False
        Me.groupPanelControlAvance.Text = "Panel de Control de Avance"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbPanel)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbAvance)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbIndicador01)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbIndicador02)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbIndicador03)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbIndicador04)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbIndicador05)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbIndicador06)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbIndicador07)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbIndicador08)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbIndicador09)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbIndicador10)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbIndicador11)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbIndicador12)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbEncuesta)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbRangos)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnPlantilla03)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "RibbonPageGroup1"
        '
        'rpItemCheckVenta
        '
        Me.rpItemCheckVenta.AutoHeight = False
        Me.rpItemCheckVenta.Name = "rpItemCheckVenta"
        '
        'rpItemCheckCompra
        '
        Me.rpItemCheckCompra.AutoHeight = False
        Me.rpItemCheckCompra.Name = "rpItemCheckCompra"
        '
        'rpItemCheckInventarios
        '
        Me.rpItemCheckInventarios.AutoHeight = False
        Me.rpItemCheckInventarios.Name = "rpItemCheckInventarios"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'rpItemCheckPrecios
        '
        Me.rpItemCheckPrecios.AutoHeight = False
        Me.rpItemCheckPrecios.Name = "rpItemCheckPrecios"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.AutoHeight = False
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        '
        'rStatusBar
        '
        Me.rStatusBar.ItemLinks.Add(Me.bsiServidor)
        Me.rStatusBar.ItemLinks.Add(Me.bsiBD)
        Me.rStatusBar.ItemLinks.Add(Me.siStatus)
        Me.rStatusBar.ItemLinks.Add(Me.bsiProgreso)
        Me.rStatusBar.ItemLinks.Add(Me.bitemUsuario)
        Me.rStatusBar.Location = New System.Drawing.Point(0, 744)
        Me.rStatusBar.Name = "rStatusBar"
        Me.rStatusBar.Ribbon = Me.ribbonControl
        Me.rStatusBar.Size = New System.Drawing.Size(1366, 31)
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'skinsRibbonPageGroup
        '
        Me.skinsRibbonPageGroup.Name = "skinsRibbonPageGroup"
        Me.skinsRibbonPageGroup.ShowCaptionButton = False
        Me.skinsRibbonPageGroup.Text = "Skins"
        '
        'exitRibbonPageGroup
        '
        Me.exitRibbonPageGroup.Name = "exitRibbonPageGroup"
        Me.exitRibbonPageGroup.Text = "Exit"
        '
        'formatRibbonPageGroup
        '
        Me.formatRibbonPageGroup.Name = "formatRibbonPageGroup"
        Me.formatRibbonPageGroup.Text = "Format"
        '
        'fileRibbonPageGroup
        '
        Me.fileRibbonPageGroup.Name = "fileRibbonPageGroup"
        Me.fileRibbonPageGroup.Text = "File"
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'PrintableComponentLink1
        '
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Landscape = True
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(30, 30, 50, 50)
        Me.PrintableComponentLink1.Owner = Nothing
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'btnEditSkuCanal
        '
        Me.btnEditSkuCanal.Caption = "Edicion Especial Sku Canal"
        Me.btnEditSkuCanal.Id = 207
        Me.btnEditSkuCanal.ImageIndex = 81
        Me.btnEditSkuCanal.LargeImageIndex = 81
        Me.btnEditSkuCanal.Name = "btnEditSkuCanal"
        '
        'frmPrincipal
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 775)
        Me.Controls.Add(Me.popupControlContainer1xxxx)
        Me.Controls.Add(Me.popupControlContainer2xxxx)
        Me.Controls.Add(Me.rStatusBar)
        Me.Controls.Add(Me.ribbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmPrincipal"
        Me.Ribbon = Me.ribbonControl
        Me.StatusBar = Me.rStatusBar
        Me.Text = "CCR CC Consistencia por Ciudad"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.navbarImageCollectionLarge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.navbarImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.appMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupControlContainer2xxxx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popupControlContainer2xxxx.ResumeLayout(False)
        CType(Me.buttonEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupControlContainer1xxxx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popupControlContainer1xxxx.ResumeLayout(False)
        Me.popupControlContainer1xxxx.PerformLayout()
        CType(Me.AppImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpItemCheckReal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpItemCheckAnalizada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMarqueeProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppImageCollectionLarge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpItemCheckVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpItemCheckCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpItemCheckInventarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpItemCheckPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents appMenu As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Private WithEvents popupControlContainer1xxxx As DevExpress.XtraBars.PopupControlContainer
    Private WithEvents someLabelControl2 As DevExpress.XtraEditors.LabelControl
    Private WithEvents someLabelControl1 As DevExpress.XtraEditors.LabelControl
    Private WithEvents popupControlContainer2xxxx As DevExpress.XtraBars.PopupControlContainer
    Private WithEvents buttonEdit As DevExpress.XtraEditors.ButtonEdit
    Private WithEvents rStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Private WithEvents navbarImageCollection As DevExpress.Utils.ImageCollection
    Private WithEvents navbarImageCollectionLarge As DevExpress.Utils.ImageCollection
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Private WithEvents skinsRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents exitRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents formatRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents fileRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbCintaOpcionesEncuesta As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents groupData As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents groupVariables As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents groupIndicadores As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents groupSupervision As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents groupSKU As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents groupFiltros As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents groupSemaforo As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents groupRangos As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents groupExportar As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents groupImprimir As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents groupPanelControlAvance As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnVariacion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSku As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSupervisionMarca As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSupervisionResumen As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSupervisionValidar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEstadistica As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPropiedades As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnReplicarEncuesta As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnReplicarEncuestaPromedio As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnReplicarSkuPromedio As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents groupEstandar As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnCancelarReplicas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnVerDatosValidos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnVerDatosCampo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnVerDatosSupervision As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnVerDatosAjustado As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnVerTodos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSemaforoAlertas As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents btnSemaforoOk As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents btnSemaforoTodos As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents btnGestionRangos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExportarExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExportarPDF As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExportarCSV As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExportarXML As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnVistaPrevia As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPanelControl As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnControlAvance As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnGrabar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSalir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnReal As DevExpress.XtraBars.BarEditItem
    Friend WithEvents rpItemCheckReal As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents rpItemCheckAnalizada As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents rpItemCheckVenta As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents rpItemCheckCompra As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btnAnalizada As DevExpress.XtraBars.BarEditItem
    Friend WithEvents rpItemCheckPrecios As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents bbPanel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbAvance As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbIndicador01 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbIndicador02 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbIndicador03 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbIndicador04 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbIndicador05 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbIndicador06 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbIndicador07 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbIndicador08 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbIndicador09 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbIndicador10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbIndicador11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbIndicador12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbEncuesta As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbRangos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPage5 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents btnAcerca As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage6 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bitemUsuario As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsiServidor As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bsiBD As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents rgbSkins As DevExpress.XtraBars.RibbonGalleryBarItem
    Private WithEvents rpgGaleria As DevExpress.XtraBars.Ribbon.RibbonPageGroup

    Friend WithEvents btnSincronizar As DevExpress.XtraBars.BarButtonItem

    Friend WithEvents btnPlantilla03 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents rpItemCheckInventarios As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btnVenta As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents btnCompra As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents btnInventarios As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents btnPrecio As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents btnRegistros As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents btnVariablesTodos As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents btnVariablesNinguno As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents btnCambiarEstado As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnVaciar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnReplicaSKU As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnActivar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents groupAjusteEncuesta As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents groupVarios As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bsiProgreso As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemMarqueeProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar
    Friend WithEvents AppImageCollection As DevExpress.Utils.ImageCollection
    Public WithEvents AppImageCollectionLarge As DevExpress.Utils.ImageCollection
    Friend WithEvents btnCorrectos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPendientes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEnSupervision As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnValidados As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAtipicos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnNoProcesa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgEstado As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage7 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnCongelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEstadoTodos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRecargar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnCambiarEstadoNoProcesa As DevExpress.XtraBars.BarButtonItem
    Public WithEvents siStatus As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents btnFrecuencia As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSemaforo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnGestionSupervision As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEnviaSupervision As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ribbonCategorySupervision As DevExpress.XtraBars.Ribbon.RibbonPageCategory
    Friend WithEvents ribbonPageSupervision As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rpgGestionSupervision As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgGestionSupervisionEstadoNegocio As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgGestionSupervisionEncuesta As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageCategoryGallery As DevExpress.XtraBars.Ribbon.RibbonPageCategory
    Friend WithEvents RibbonPageCategoryAcerca As DevExpress.XtraBars.Ribbon.RibbonPageCategory
    Friend WithEvents RibbonPageCategory2 As DevExpress.XtraBars.Ribbon.RibbonPageCategory
    Friend WithEvents RibbonPageCategory1 As DevExpress.XtraBars.Ribbon.RibbonPageCategory
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents btnSkuPonerAtipico As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSkuPonerNoProcesa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSkuActivarRegistro As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnActivarSupervision As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditSkuCanal As DevExpress.XtraBars.BarButtonItem


End Class
