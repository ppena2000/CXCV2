
Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Reflection
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Blending
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Card
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraBars
Imports DevExpress.XtraExport
Imports DevExpress.XtraGrid.Export
Imports System.Data
Imports DevExpress.XtraBars.Ribbon

Namespace My

    ' Los siguientes eventos están disponibles para MyApplication:
    ' 
    ' Inicio: se desencadena cuando se inicia la aplicación, antes de que se cree el formulario de inicio.
    ' Apagado: generado después de cerrar todos los formularios de la aplicación. Este evento no se genera si la aplicación termina de forma anómala.
    ' UnhandledException: generado si la aplicación detecta una excepción no controlada.
    ' StartupNextInstance: se desencadena cuando se inicia una aplicación de instancia única y la aplicación ya está activa. 
    ' NetworkAvailabilityChanged: se desencadena cuando la conexión de red está conectada o desconectada.
    Partial Friend Class MyApplication

    End Class

    '    Public Class GridRibbonMenuManager
    '        Inherits RibbonMenuManager
    '        Private view As BaseView = Nothing
    '        Private blending As XtraGridBlending = Nothing
    '        Private bsiViewOptions, bsiSelectionOptions As BarSubItem
    '        Private bciAlphaBlendingUsing As BarCheckItem
    '        Private bbiAlphaBlendingAdjustment As BarButtonItem
    '        Private xapp As DevExpress.XtraGrid.Design.XAppearances = Nothing
    '        Public Sub New(ByVal form As RibbonMainForm)
    '            MyBase.New(form)
    '            CreateOptionsMenu(form.ReservGroup1, form.Ribbon)
    '            CreateBlendingMenu(form.ReservGroup2, form.Ribbon)
    '        End Sub
    '        Private Sub CreateBlendingMenu(ByVal ribbonPageGroup As RibbonPageGroup, ByVal ribbonControl As RibbonControl)
    '            ribbonPageGroup.Text = DevExpress.XtraGrid.Demos.Properties.Resources.AlphaBlending
    '            bciAlphaBlendingUsing = New CheckBarItem(Manager, DevExpress.XtraGrid.Demos.Properties.Resources.UsingString, New ItemClickEventHandler(AddressOf miUsing_Click))
    '            bbiAlphaBlendingAdjustment = New ButtonBarItem(Manager, DevExpress.XtraGrid.Demos.Properties.Resources.Adjustment, New ItemClickEventHandler(AddressOf miAdjustment_Click))
    '            bbiAlphaBlendingAdjustment.Glyph = DevExpress.Utils.ResourceImageHelper.CreateImageFromResources("Blending.png", GetType(frmMain).Assembly)
    '            ribbonPageGroup.ItemLinks.Add(bciAlphaBlendingUsing)
    '            ribbonPageGroup.ItemLinks.Add(bbiAlphaBlendingAdjustment)
    '        End Sub
    '        Private Sub CreateOptionsMenu(ByVal ribbonPageGroup As RibbonPageGroup, ByVal ribbonControl As RibbonControl)
    '            ribbonPageGroup.Text = DevExpress.XtraGrid.Demos.Properties.Resources.Options
    '            bsiViewOptions = New BarSubItem()
    '            bsiSelectionOptions = New BarSubItem()
    '            bsiViewOptions.Caption = DevExpress.XtraGrid.Demos.Properties.Resources.ViewOptions
    '            bsiSelectionOptions.Caption = DevExpress.XtraGrid.Demos.Properties.Resources.SelectionOptions
    '            MainFormHelper.SetBarButtonImage(bsiViewOptions, "View")
    '            MainFormHelper.SetBarButtonImage(bsiSelectionOptions, "LayoutOptions")
    '            ribbonControl.Items.Add(bsiViewOptions)
    '            ribbonControl.Items.Add(bsiSelectionOptions)
    '            ribbonPageGroup.ItemLinks.Add(bsiViewOptions)
    '            ribbonPageGroup.ItemLinks.Add(bsiSelectionOptions)
    '        End Sub
    '        Public ReadOnly Property XAppearances() As DevExpress.XtraGrid.Design.XAppearances
    '            Get
    '                If xapp Is Nothing Then
    '                    xapp = New DevExpress.XtraGrid.Design.XAppearances("System", True)
    '                End If
    '                Return xapp
    '            End Get
    '        End Property

    '        Private ReadOnly Property ViewOptions() As Object
    '            Get
    '                If TypeOf view Is GridView Then
    '                    Return (CType(view, GridView)).OptionsView
    '                End If
    '                If TypeOf view Is CardView Then
    '                    Return (CType(view, CardView)).OptionsView
    '                End If
    '                Return Nothing
    '            End Get
    '        End Property
    '        Private ReadOnly Property SelectionOptions() As Object
    '            Get
    '                If TypeOf view Is GridView Then
    '                    Return (CType(view, GridView)).OptionsSelection
    '                End If
    '                Return Nothing
    '            End Get
    '        End Property

    '        Private Sub miAdjustment_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
    '            If blending IsNot Nothing Then
    '                blending.ShowDialog()
    '            End If
    '        End Sub
    '    End Class



    '    Public Class CC_ControlExport
    '        'Inherits DevExpress.DXperience.Demos.TutorialControlBase
    '        Public ReadOnly Property GridRibbonMenuManager() As GridRibbonMenuManager
    '            Get
    '                Return TryCast(RibbonMenuManager, GridRibbonMenuManager)
    '            End Get
    '        End Property
    '        Protected Overrides Sub SetControlManager(ByVal ctrl As Control, ByVal manager As BarManager)
    '            Dim grid As DevExpress.XtraGrid.GridControl = TryCast(ctrl, DevExpress.XtraGrid.GridControl)
    '            If grid IsNot Nothing Then
    '                grid.MenuManager = manager
    '            End If
    '            Dim be As BaseEdit = TryCast(ctrl, BaseEdit)
    '            If be IsNot Nothing Then
    '                be.MenuManager = manager
    '            End If
    '        End Sub
    '        Protected Overrides Sub AllowExport()
    '            EnabledPrintExportActions(True, ExportFormats.PDF Or ExportFormats.HTML Or ExportFormats.MHT Or ExportFormats.XLS Or ExportFormats.RTF Or ExportFormats.Text Or ExportFormats.XLSX, False)
    '        End Sub
    '        Public Overrides ReadOnly Property AllowPrintOptions() As Boolean
    '            Get
    '                Return ExportView IsNot Nothing
    '            End Get
    '        End Property
    '        Public Overridable ReadOnly Property ExportView() As BaseView
    '            Get
    '                Return Nothing
    '            End Get
    '        End Property
    '        Public Overridable ReadOnly Property ShowViewOptions() As Boolean
    '            Get
    '                Return False
    '            End Get
    '        End Property
    '        Protected Overridable ReadOnly Property PaintViews() As PaintView()
    '            Get
    '                Return Nothing
    '            End Get
    '        End Property
    '#Region "InitData"
    '        Protected Overridable Sub InitNWindData()
    '            Dim DBFileName As String = String.Empty

    '            DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\nwind.mdb")
    '            If DBFileName <> String.Empty Then
    '                InitMDBData("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName)
    '            End If
    '        End Sub
    '        Protected Overridable Sub InitMDBData(ByVal connectionString As String)
    '        End Sub
    '        Protected Overridable Sub InitXMLData(ByVal dataFileName As String)
    '        End Sub

    '        Protected Overridable Sub InitMDBData(ByVal connectionString As String, ByVal ds As DataSet)
    '        End Sub
    '        Protected Overridable Sub InitXMLData(ByVal dataFileName As String, ByVal ds As DataSet)
    '        End Sub


    '#End Region
    '#Region "Print and Export"
    '        Protected Overrides Sub ExportToCore(ByVal filename As String, ByVal ext As String)
    '            If ExportView Is Nothing Then
    '                Return
    '            End If
    '            Dim currentCursor As Cursor = Cursor.Current
    '            Cursor.Current = Cursors.WaitCursor
    '            If ext = "rtf" Then
    '                ExportView.ExportToRtf(filename)
    '            End If
    '            If ext = "pdf" Then
    '                ExportView.ExportToPdf(filename)
    '            End If
    '            If ext = "mht" Then
    '                ExportView.ExportToMht(filename)
    '            End If
    '            If ext = "html" Then
    '                ExportView.ExportToHtml(filename)
    '            End If
    '            If ext = "txt" Then
    '                ExportView.ExportToText(filename)
    '            End If
    '            If ext = "xls" Then
    '                ExportView.ExportToXls(filename)
    '            End If
    '            If ext = "xlsx" Then
    '                ExportView.ExportToXlsx(filename)
    '            End If
    '            Cursor.Current = currentCursor
    '        End Sub
    '        Protected Overrides Sub ExportToPDF()
    '            ExportTo("pdf", DevExpress.XtraGrid.Demos.Properties.Resources.PDFFilter)
    '        End Sub
    '        Protected Overrides Sub ExportToHTML()
    '            ExportTo("html", DevExpress.XtraGrid.Demos.Properties.Resources.HTMLFilter)
    '        End Sub
    '        Protected Overrides Sub ExportToMHT()
    '            ExportTo("mht", DevExpress.XtraGrid.Demos.Properties.Resources.MHTFilter)
    '        End Sub
    '        Protected Overrides Sub ExportToXLS()
    '            ExportTo("xls", DevExpress.XtraGrid.Demos.Properties.Resources.XLSFilter)
    '        End Sub
    '        Protected Overrides Sub ExportToXLSX()
    '            ExportTo("xlsx", DevExpress.XtraGrid.Demos.Properties.Resources.XLSXFilter)
    '        End Sub
    '        Protected Overrides Sub ExportToRTF()
    '            ExportTo("rtf", DevExpress.XtraGrid.Demos.Properties.Resources.RTFFilter)
    '        End Sub
    '        Protected Overrides Sub ExportToText()
    '            ExportTo("txt", DevExpress.XtraGrid.Demos.Properties.Resources.TextFilter)
    '        End Sub
    '        Protected Overrides Sub PrintPreview()
    '            If Me.ExportView IsNot Nothing AndAlso Me.ExportView.GridControl IsNot Nothing Then
    '                If RibbonMenuManager.PrintOptions.ShowRibbonPreviewForm Then
    '                    Me.ExportView.GridControl.ShowRibbonPrintPreview()
    '                Else
    '                    Me.ExportView.GridControl.ShowPrintPreview()
    '                End If
    '            End If
    '        End Sub
    '#End Region
    '    End Class

End Namespace

