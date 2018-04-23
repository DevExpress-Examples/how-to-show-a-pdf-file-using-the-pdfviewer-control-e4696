Imports Microsoft.VisualBasic
Imports System
Namespace PdfViewerSample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.pdfViewer1 = New DevExpress.XtraPdfViewer.PdfViewer()
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.pdfBarAndDockingController1 = New DevExpress.XtraPdfViewer.Bars.PdfBarAndDockingController(Me.components)
			Me.pdfBarController1 = New DevExpress.XtraPdfViewer.Bars.PdfBarController()
			Me.pdfFileRibbonPageGroup1 = New DevExpress.XtraPdfViewer.Bars.PdfFileRibbonPageGroup()
			Me.pdfRibbonPage1 = New DevExpress.XtraPdfViewer.Bars.PdfRibbonPage()
			Me.pdfFileOpenBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem()
			Me.pdfNavigationRibbonPageGroup1 = New DevExpress.XtraPdfViewer.Bars.PdfNavigationRibbonPageGroup()
			Me.pdfPreviousPageBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem()
			Me.pdfNextPageBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem()
			Me.pdfZoomRibbonPageGroup1 = New DevExpress.XtraPdfViewer.Bars.PdfZoomRibbonPageGroup()
			Me.pdfZoomOutBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem()
			Me.pdfZoomInBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem()
			Me.pdfExactZoomListBarSubItem1 = New DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem()
			Me.pdfZoom10CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem()
			Me.pdfZoom25CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem()
			Me.pdfZoom50CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem()
			Me.pdfZoom75CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem()
			Me.pdfZoom100CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem()
			Me.pdfZoom125CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem()
			Me.pdfZoom150CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem()
			Me.pdfZoom200CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem()
			Me.pdfZoom400CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem()
			Me.pdfZoom500CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem()
			Me.pdfSetActualSizePageModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetActualSizePageModeCheckItem()
			Me.pdfSetPageLevelPageModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelPageModeCheckItem()
			Me.pdfSetPageWidthPageModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetPageWidthPageModeCheckItem()
			Me.pdfSetTextWidthPageModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetTextWidthPageModeCheckItem()
			Me.pdfViewer1.SuspendLayout()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pdfBarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pdfBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pdfViewer1
			' 
			Me.pdfViewer1.Controls.Add(Me.ribbonControl1)
			Me.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pdfViewer1.Location = New System.Drawing.Point(0, 0)
			Me.pdfViewer1.Name = "pdfViewer1"
			Me.pdfViewer1.Size = New System.Drawing.Size(1000, 600)
			Me.pdfViewer1.TabIndex = 0
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.Controller = Me.pdfBarAndDockingController1
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.pdfFileOpenBarItem1, Me.pdfPreviousPageBarItem1, Me.pdfNextPageBarItem1, Me.pdfZoomOutBarItem1, Me.pdfZoomInBarItem1, Me.pdfExactZoomListBarSubItem1, Me.pdfZoom10CheckItem1, Me.pdfZoom25CheckItem1, Me.pdfZoom50CheckItem1, Me.pdfZoom75CheckItem1, Me.pdfZoom100CheckItem1, Me.pdfZoom125CheckItem1, Me.pdfZoom150CheckItem1, Me.pdfZoom200CheckItem1, Me.pdfZoom400CheckItem1, Me.pdfZoom500CheckItem1, Me.pdfSetActualSizePageModeCheckItem1, Me.pdfSetPageLevelPageModeCheckItem1, Me.pdfSetPageWidthPageModeCheckItem1, Me.pdfSetTextWidthPageModeCheckItem1})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 21
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.pdfRibbonPage1})
			Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
			Me.ribbonControl1.Size = New System.Drawing.Size(1000, 142)
			Me.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above
			' 
			' pdfBarAndDockingController1
			' 
			Me.pdfBarAndDockingController1.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
			Me.pdfBarAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
			' 
			' pdfBarController1
			' 
			Me.pdfBarController1.BarItems.Add(Me.pdfFileOpenBarItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfPreviousPageBarItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfNextPageBarItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfZoomOutBarItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfZoomInBarItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfExactZoomListBarSubItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfZoom10CheckItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfZoom25CheckItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfZoom50CheckItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfZoom75CheckItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfZoom100CheckItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfZoom125CheckItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfZoom150CheckItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfZoom200CheckItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfZoom400CheckItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfZoom500CheckItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfSetActualSizePageModeCheckItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfSetPageLevelPageModeCheckItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfSetPageWidthPageModeCheckItem1)
			Me.pdfBarController1.BarItems.Add(Me.pdfSetTextWidthPageModeCheckItem1)
			Me.pdfBarController1.Control = Me.pdfViewer1
			' 
			' pdfFileRibbonPageGroup1
			' 
			Me.pdfFileRibbonPageGroup1.ItemLinks.Add(Me.pdfFileOpenBarItem1)
			Me.pdfFileRibbonPageGroup1.Name = "pdfFileRibbonPageGroup1"
			' 
			' pdfRibbonPage1
			' 
			Me.pdfRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.pdfFileRibbonPageGroup1, Me.pdfNavigationRibbonPageGroup1, Me.pdfZoomRibbonPageGroup1})
			Me.pdfRibbonPage1.Name = "pdfRibbonPage1"
			' 
			' pdfFileOpenBarItem1
			' 
			Me.pdfFileOpenBarItem1.Id = 1
			Me.pdfFileOpenBarItem1.Name = "pdfFileOpenBarItem1"
			' 
			' pdfNavigationRibbonPageGroup1
			' 
			Me.pdfNavigationRibbonPageGroup1.ItemLinks.Add(Me.pdfPreviousPageBarItem1)
			Me.pdfNavigationRibbonPageGroup1.ItemLinks.Add(Me.pdfNextPageBarItem1)
			Me.pdfNavigationRibbonPageGroup1.Name = "pdfNavigationRibbonPageGroup1"
			' 
			' pdfPreviousPageBarItem1
			' 
			Me.pdfPreviousPageBarItem1.Id = 2
			Me.pdfPreviousPageBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.PageUp)
			Me.pdfPreviousPageBarItem1.Name = "pdfPreviousPageBarItem1"
			' 
			' pdfNextPageBarItem1
			' 
			Me.pdfNextPageBarItem1.Id = 3
			Me.pdfNextPageBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.PageDown)
			Me.pdfNextPageBarItem1.Name = "pdfNextPageBarItem1"
			' 
			' pdfZoomRibbonPageGroup1
			' 
			Me.pdfZoomRibbonPageGroup1.ItemLinks.Add(Me.pdfZoomOutBarItem1)
			Me.pdfZoomRibbonPageGroup1.ItemLinks.Add(Me.pdfZoomInBarItem1)
			Me.pdfZoomRibbonPageGroup1.ItemLinks.Add(Me.pdfExactZoomListBarSubItem1)
			Me.pdfZoomRibbonPageGroup1.Name = "pdfZoomRibbonPageGroup1"
			' 
			' pdfZoomOutBarItem1
			' 
			Me.pdfZoomOutBarItem1.Id = 4
			Me.pdfZoomOutBarItem1.Name = "pdfZoomOutBarItem1"
			' 
			' pdfZoomInBarItem1
			' 
			Me.pdfZoomInBarItem1.Id = 5
			Me.pdfZoomInBarItem1.Name = "pdfZoomInBarItem1"
			' 
			' pdfExactZoomListBarSubItem1
			' 
			Me.pdfExactZoomListBarSubItem1.Id = 6
			Me.pdfExactZoomListBarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom10CheckItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom25CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom50CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom75CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom100CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom125CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom150CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom200CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom400CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom500CheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pdfSetActualSizePageModeCheckItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.pdfSetPageLevelPageModeCheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pdfSetPageWidthPageModeCheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.pdfSetTextWidthPageModeCheckItem1)})
			Me.pdfExactZoomListBarSubItem1.Name = "pdfExactZoomListBarSubItem1"
			Me.pdfExactZoomListBarSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
			' 
			' pdfZoom10CheckItem1
			' 
			Me.pdfZoom10CheckItem1.Id = 7
			Me.pdfZoom10CheckItem1.Name = "pdfZoom10CheckItem1"
			' 
			' pdfZoom25CheckItem1
			' 
			Me.pdfZoom25CheckItem1.Id = 8
			Me.pdfZoom25CheckItem1.Name = "pdfZoom25CheckItem1"
			' 
			' pdfZoom50CheckItem1
			' 
			Me.pdfZoom50CheckItem1.Id = 9
			Me.pdfZoom50CheckItem1.Name = "pdfZoom50CheckItem1"
			' 
			' pdfZoom75CheckItem1
			' 
			Me.pdfZoom75CheckItem1.Id = 10
			Me.pdfZoom75CheckItem1.Name = "pdfZoom75CheckItem1"
			' 
			' pdfZoom100CheckItem1
			' 
			Me.pdfZoom100CheckItem1.Id = 11
			Me.pdfZoom100CheckItem1.Name = "pdfZoom100CheckItem1"
			' 
			' pdfZoom125CheckItem1
			' 
			Me.pdfZoom125CheckItem1.Id = 12
			Me.pdfZoom125CheckItem1.Name = "pdfZoom125CheckItem1"
			' 
			' pdfZoom150CheckItem1
			' 
			Me.pdfZoom150CheckItem1.Id = 13
			Me.pdfZoom150CheckItem1.Name = "pdfZoom150CheckItem1"
			' 
			' pdfZoom200CheckItem1
			' 
			Me.pdfZoom200CheckItem1.Id = 14
			Me.pdfZoom200CheckItem1.Name = "pdfZoom200CheckItem1"
			' 
			' pdfZoom400CheckItem1
			' 
			Me.pdfZoom400CheckItem1.Id = 15
			Me.pdfZoom400CheckItem1.Name = "pdfZoom400CheckItem1"
			' 
			' pdfZoom500CheckItem1
			' 
			Me.pdfZoom500CheckItem1.Id = 16
			Me.pdfZoom500CheckItem1.Name = "pdfZoom500CheckItem1"
			' 
			' pdfSetActualSizePageModeCheckItem1
			' 
			Me.pdfSetActualSizePageModeCheckItem1.Id = 17
			Me.pdfSetActualSizePageModeCheckItem1.Name = "pdfSetActualSizePageModeCheckItem1"
			' 
			' pdfSetPageLevelPageModeCheckItem1
			' 
			Me.pdfSetPageLevelPageModeCheckItem1.Id = 18
			Me.pdfSetPageLevelPageModeCheckItem1.Name = "pdfSetPageLevelPageModeCheckItem1"
			' 
			' pdfSetPageWidthPageModeCheckItem1
			' 
			Me.pdfSetPageWidthPageModeCheckItem1.Id = 19
			Me.pdfSetPageWidthPageModeCheckItem1.Name = "pdfSetPageWidthPageModeCheckItem1"
			' 
			' pdfSetTextWidthPageModeCheckItem1
			' 
			Me.pdfSetTextWidthPageModeCheckItem1.Id = 20
			Me.pdfSetTextWidthPageModeCheckItem1.Name = "pdfSetTextWidthPageModeCheckItem1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1000, 600)
			Me.Controls.Add(Me.pdfViewer1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.pdfViewer1.ResumeLayout(False)
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pdfBarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pdfBarController1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pdfViewer1 As DevExpress.XtraPdfViewer.PdfViewer
		Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
		Private pdfBarAndDockingController1 As DevExpress.XtraPdfViewer.Bars.PdfBarAndDockingController
		Private pdfFileOpenBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem
		Private pdfPreviousPageBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem
		Private pdfNextPageBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem
		Private pdfZoomOutBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem
		Private pdfZoomInBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem
		Private pdfExactZoomListBarSubItem1 As DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem
		Private pdfZoom10CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem
		Private pdfZoom25CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem
		Private pdfZoom50CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem
		Private pdfZoom75CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem
		Private pdfZoom100CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem
		Private pdfZoom125CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem
		Private pdfZoom150CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem
		Private pdfZoom200CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem
		Private pdfZoom400CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem
		Private pdfZoom500CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem
		Private pdfSetActualSizePageModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetActualSizePageModeCheckItem
		Private pdfSetPageLevelPageModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelPageModeCheckItem
		Private pdfSetPageWidthPageModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetPageWidthPageModeCheckItem
		Private pdfSetTextWidthPageModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetTextWidthPageModeCheckItem
		Private pdfRibbonPage1 As DevExpress.XtraPdfViewer.Bars.PdfRibbonPage
		Private pdfFileRibbonPageGroup1 As DevExpress.XtraPdfViewer.Bars.PdfFileRibbonPageGroup
		Private pdfNavigationRibbonPageGroup1 As DevExpress.XtraPdfViewer.Bars.PdfNavigationRibbonPageGroup
		Private pdfZoomRibbonPageGroup1 As DevExpress.XtraPdfViewer.Bars.PdfZoomRibbonPageGroup
		Private pdfBarController1 As DevExpress.XtraPdfViewer.Bars.PdfBarController

	End Class
End Namespace

