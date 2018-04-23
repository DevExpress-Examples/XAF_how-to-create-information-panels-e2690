Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraBars
Imports DevExpress.ExpressApp.Win.Templates

Partial Public Class MainForm
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.viewSitePanel = New DevExpress.XtraEditors.PanelControl
        Me.mainBarManager = New DevExpress.ExpressApp.Win.Templates.Controls.XafBarManager(Me.components)
        Me._mainMenuBar = New DevExpress.ExpressApp.Win.Templates.Controls.XafBar
        Me.barSubItemFile = New DevExpress.ExpressApp.Win.Templates.MainMenuItem
        Me.cObjectsCreation = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.cFile = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.cSave = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.cPrint = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.cExport = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.cExit = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.barSubItemEdit = New DevExpress.ExpressApp.Win.Templates.MainMenuItem
        Me.cUndoRedo = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.cEdit = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.cRecordEdit = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.cOpenObject = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.barSubItemView = New DevExpress.ExpressApp.Win.Templates.MainMenuItem
        Me.barSubItemPanels = New DevExpress.XtraBars.BarSubItem
        Me.cPanels = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem
        Me.cViewsHistoryNavigation = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.cViewsNavigation = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem
        Me.cRecordsNavigation = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.cView = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.cReports = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.cDefault = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.cSearch = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.cFilters = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.cFullTextSearch = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.cAppearance = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem
        Me.barSubItemTools = New DevExpress.ExpressApp.Win.Templates.MainMenuItem
        Me.cTools = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem
        Me.cOptions = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem
        Me.cDiagnostic = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem
        Me.barSubItemWindow = New DevExpress.ExpressApp.Win.Templates.MainMenuItem
        Me.cWindows = New DevExpress.ExpressApp.Win.Templates.ActionContainers.XafBarLinkContainerItem
        Me.barMdiChildrenListItem = New DevExpress.XtraBars.BarMdiChildrenListItem
        Me.Window = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.barSubItemHelp = New DevExpress.ExpressApp.Win.Templates.MainMenuItem
        Me.cAbout = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem
        Me.standardToolBar = New DevExpress.ExpressApp.Win.Templates.Controls.XafBar
        Me._statusBar = New DevExpress.ExpressApp.Win.Templates.Controls.XafBar
        Me.mainBarAndDockingController = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.mainDockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.dockPanelNavigation_Renamed = New DevExpress.XtraBars.Docking.DockPanel
        Me.dockPanelNavigation_Container = New DevExpress.XtraBars.Docking.ControlContainer
        Me.navigation = New DevExpress.ExpressApp.Win.Templates.ActionContainers.NavigationActionContainer
        Me.cMenu = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.formStateModelSynchronizerComponent = New DevExpress.ExpressApp.Win.Core.FormStateModelSynchronizer(Me.components)
        CType(Me.xafTabbedMdiManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.viewSitePanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mainBarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mainBarAndDockingController, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mainDockManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dockPanelNavigation_Renamed.SuspendLayout()
        Me.dockPanelNavigation_Container.SuspendLayout()
        Me.SuspendLayout()
        '
        'actionsContainersManager
        '
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cObjectsCreation)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cFile)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cSave)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cPrint)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cExport)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cExit)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cUndoRedo)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cEdit)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cRecordEdit)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cOpenObject)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cPanels)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cViewsHistoryNavigation)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cViewsNavigation)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cRecordsNavigation)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cView)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cReports)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cDefault)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cSearch)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cFilters)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cFullTextSearch)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cAppearance)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cTools)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cOptions)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cDiagnostic)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cAbout)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.navigation)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cMenu)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.Window)
        Me.actionsContainersManager.ContextMenuContainers.Add(Me.cObjectsCreation)
        Me.actionsContainersManager.ContextMenuContainers.Add(Me.cSave)
        Me.actionsContainersManager.ContextMenuContainers.Add(Me.cEdit)
        Me.actionsContainersManager.ContextMenuContainers.Add(Me.cRecordEdit)
        Me.actionsContainersManager.ContextMenuContainers.Add(Me.cOpenObject)
        Me.actionsContainersManager.ContextMenuContainers.Add(Me.cUndoRedo)
        Me.actionsContainersManager.ContextMenuContainers.Add(Me.cPrint)
        Me.actionsContainersManager.ContextMenuContainers.Add(Me.cView)
        Me.actionsContainersManager.ContextMenuContainers.Add(Me.cReports)
        Me.actionsContainersManager.ContextMenuContainers.Add(Me.cExport)
        Me.actionsContainersManager.ContextMenuContainers.Add(Me.cMenu)
        Me.actionsContainersManager.DefaultContainer = Me.cDefault
        '
        'modelSynchronizationManager
        '
        Me.modelSynchronizationManager.ModelSynchronizableComponents.Add(Me.formStateModelSynchronizerComponent)
        Me.modelSynchronizationManager.ModelSynchronizableComponents.Add(Me.mainBarManager)
        Me.modelSynchronizationManager.ModelSynchronizableComponents.Add(Me.mainBarManager)
        Me.modelSynchronizationManager.ModelSynchronizableComponents.Add(Me.mainBarManager)
        Me.modelSynchronizationManager.ModelSynchronizableComponents.Add(Me.mainBarManager)
        '
        'viewSiteManager
        '
        Me.viewSiteManager.ViewSiteControl = Me.viewSitePanel
        '
        'SplitContainerControl1
        '
        resources.ApplyResources(Me.SplitContainerControl1, "SplitContainerControl1")
        Me.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.viewSitePanel)
        resources.ApplyResources(Me.SplitContainerControl1.Panel1, "SplitContainerControl1.Panel1")
        resources.ApplyResources(Me.SplitContainerControl1.Panel2, "SplitContainerControl1.Panel2")
        Me.SplitContainerControl1.SplitterPosition = 146
        '
        'viewSitePanel
        '
        Me.viewSitePanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        resources.ApplyResources(Me.viewSitePanel, "viewSitePanel")
        Me.viewSitePanel.Name = "viewSitePanel"
        '
        'mainBarManager
        '
        Me.mainBarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me._mainMenuBar, Me.standardToolBar, Me._statusBar})
        Me.mainBarManager.Controller = Me.mainBarAndDockingController
        Me.mainBarManager.DockControls.Add(Me.barDockControlTop)
        Me.mainBarManager.DockControls.Add(Me.barDockControlBottom)
        Me.mainBarManager.DockControls.Add(Me.barDockControlLeft)
        Me.mainBarManager.DockControls.Add(Me.barDockControlRight)
        Me.mainBarManager.DockManager = Me.mainDockManager
        Me.mainBarManager.Form = Me
        Me.mainBarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barSubItemFile, Me.barSubItemEdit, Me.barSubItemView, Me.barSubItemTools, Me.barSubItemHelp, Me.cFile, Me.cObjectsCreation, Me.cPrint, Me.cExport, Me.cSave, Me.cEdit, Me.cOpenObject, Me.cUndoRedo, Me.cAppearance, Me.cReports, Me.cExit, Me.cRecordEdit, Me.cRecordsNavigation, Me.cViewsHistoryNavigation, Me.cSearch, Me.cFullTextSearch, Me.cFilters, Me.cView, Me.cDefault, Me.cTools, Me.cViewsNavigation, Me.cDiagnostic, Me.cOptions, Me.cAbout, Me.cWindows, Me.cPanels, Me.cMenu, Me.barSubItemWindow, Me.barMdiChildrenListItem, Me.Window, Me.barSubItemPanels})
        Me.mainBarManager.MainMenu = Me._mainMenuBar
        Me.mainBarManager.MaxItemId = 36
        Me.mainBarManager.StatusBar = Me._statusBar
        '
        '_mainMenuBar
        '
        Me._mainMenuBar.BarName = "Main Menu"
        Me._mainMenuBar.DockCol = 0
        Me._mainMenuBar.DockRow = 0
        Me._mainMenuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me._mainMenuBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItemFile), New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItemEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItemView), New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItemTools), New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItemWindow), New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItemHelp)})
        Me._mainMenuBar.OptionsBar.MultiLine = True
        Me._mainMenuBar.OptionsBar.UseWholeRow = True
        Me._mainMenuBar.TargetPageCategoryColor = System.Drawing.Color.Empty
        resources.ApplyResources(Me._mainMenuBar, "_mainMenuBar")
        '
        'barSubItemFile
        '
        resources.ApplyResources(Me.barSubItemFile, "barSubItemFile")
        Me.barSubItemFile.Id = 0
        Me.barSubItemFile.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cObjectsCreation, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cFile, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cSave, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cPrint, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cExport, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cExit, True)})
        Me.barSubItemFile.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barSubItemFile.Name = "barSubItemFile"
        Me.barSubItemFile.VisibleInRibbon = False
        '
        'cObjectsCreation
        '
        Me.cObjectsCreation.ApplicationMenuIndex = 1
        Me.cObjectsCreation.ApplicationMenuItem = True
        resources.ApplyResources(Me.cObjectsCreation, "cObjectsCreation")
        Me.cObjectsCreation.ContainerId = "ObjectsCreation"
        Me.cObjectsCreation.Id = 18
        Me.cObjectsCreation.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.cObjectsCreation.Name = "cObjectsCreation"
        Me.cObjectsCreation.TargetPageCategoryColor = System.Drawing.Color.Empty
        Me.cObjectsCreation.TargetPageGroupCaption = Nothing
        '
        'cFile
        '
        Me.cFile.ApplicationMenuIndex = 2
        Me.cFile.ApplicationMenuItem = True
        resources.ApplyResources(Me.cFile, "cFile")
        Me.cFile.ContainerId = "File"
        Me.cFile.Id = 5
        Me.cFile.MergeOrder = 2
        Me.cFile.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.cFile.Name = "cFile"
        Me.cFile.TargetPageCategoryColor = System.Drawing.Color.Empty
        Me.cFile.TargetPageGroupCaption = Nothing
        '
        'cSave
        '
        Me.cSave.ApplicationMenuIndex = 7
        Me.cSave.ApplicationMenuItem = True
        resources.ApplyResources(Me.cSave, "cSave")
        Me.cSave.ContainerId = "Save"
        Me.cSave.Id = 8
        Me.cSave.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.cSave.Name = "cSave"
        Me.cSave.TargetPageCategoryColor = System.Drawing.Color.Empty
        Me.cSave.TargetPageGroupCaption = Nothing
        '
        'cPrint
        '
        Me.cPrint.ApplicationMenuIndex = 11
        Me.cPrint.ApplicationMenuItem = True
        resources.ApplyResources(Me.cPrint, "cPrint")
        Me.cPrint.ContainerId = "Print"
        Me.cPrint.Id = 6
        Me.cPrint.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.cPrint.Name = "cPrint"
        Me.cPrint.TargetPageCategoryColor = System.Drawing.Color.Empty
        Me.cPrint.TargetPageGroupCaption = Nothing
        '
        'cExport
        '
        Me.cExport.ApplicationMenuIndex = 10
        Me.cExport.ApplicationMenuItem = True
        resources.ApplyResources(Me.cExport, "cExport")
        Me.cExport.ContainerId = "Export"
        Me.cExport.Id = 7
        Me.cExport.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.cExport.Name = "cExport"
        Me.cExport.TargetPageCategoryColor = System.Drawing.Color.Empty
        Me.cExport.TargetPageGroupCaption = Nothing
        '
        'cExit
        '
        Me.cExit.ApplicationMenuIndex = 900
        Me.cExit.ApplicationMenuItem = True
        resources.ApplyResources(Me.cExit, "cExit")
        Me.cExit.ContainerId = "Exit"
        Me.cExit.Id = 8
        Me.cExit.MergeOrder = 900
        Me.cExit.Name = "cExit"
        Me.cExit.TargetPageCategoryColor = System.Drawing.Color.Empty
        Me.cExit.TargetPageGroupCaption = Nothing
        '
        'barSubItemEdit
        '
        resources.ApplyResources(Me.barSubItemEdit, "barSubItemEdit")
        Me.barSubItemEdit.Id = 1
        Me.barSubItemEdit.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cUndoRedo, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cEdit, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cRecordEdit, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cOpenObject, True)})
        Me.barSubItemEdit.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barSubItemEdit.Name = "barSubItemEdit"
        Me.barSubItemEdit.VisibleInRibbon = False
        '
        'cUndoRedo
        '
        resources.ApplyResources(Me.cUndoRedo, "cUndoRedo")
        Me.cUndoRedo.ContainerId = "UndoRedo"
        Me.cUndoRedo.Id = 10
        Me.cUndoRedo.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.cUndoRedo.Name = "cUndoRedo"
        Me.cUndoRedo.TargetPageCategoryColor = System.Drawing.Color.Empty
        '
        'cEdit
        '
        resources.ApplyResources(Me.cEdit, "cEdit")
        Me.cEdit.ContainerId = "Edit"
        Me.cEdit.Id = 9
        Me.cEdit.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.cEdit.Name = "cEdit"
        Me.cEdit.TargetPageCategoryColor = System.Drawing.Color.Empty
        Me.cEdit.TargetPageGroupCaption = Nothing
        '
        'cRecordEdit
        '
        resources.ApplyResources(Me.cRecordEdit, "cRecordEdit")
        Me.cRecordEdit.ContainerId = "RecordEdit"
        Me.cRecordEdit.Id = 9
        Me.cRecordEdit.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.cRecordEdit.Name = "cRecordEdit"
        Me.cRecordEdit.TargetPageCategoryColor = System.Drawing.Color.Empty
        Me.cRecordEdit.TargetPageGroupCaption = Nothing
        '
        'cOpenObject
        '
        resources.ApplyResources(Me.cOpenObject, "cOpenObject")
        Me.cOpenObject.ContainerId = "OpenObject"
        Me.cOpenObject.Id = 9
        Me.cOpenObject.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.cOpenObject.Name = "cOpenObject"
        Me.cOpenObject.TargetPageCategoryColor = System.Drawing.Color.Empty
        Me.cOpenObject.TargetPageGroupCaption = Nothing
        '
        'barSubItemView
        '
        resources.ApplyResources(Me.barSubItemView, "barSubItemView")
        Me.barSubItemView.Id = 2
        Me.barSubItemView.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItemPanels, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cViewsHistoryNavigation, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cViewsNavigation, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cRecordsNavigation, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cView, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cReports, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cDefault, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cSearch, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, False, Me.cFilters, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, False, Me.cFullTextSearch, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cAppearance, True)})
        Me.barSubItemView.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barSubItemView.Name = "barSubItemView"
        '
        'barSubItemPanels
        '
        resources.ApplyResources(Me.barSubItemPanels, "barSubItemPanels")
        Me.barSubItemPanels.Id = 35
        Me.barSubItemPanels.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cPanels, True)})
        Me.barSubItemPanels.Name = "barSubItemPanels"
        '
        'cPanels
        '
        resources.ApplyResources(Me.cPanels, "cPanels")
        Me.cPanels.ContainerId = "Panels"
        Me.cPanels.Id = 16
        Me.cPanels.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.cPanels.Name = "cPanels"
        Me.cPanels.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        Me.cPanels.TargetPageCategoryColor = System.Drawing.Color.Empty
        Me.cPanels.TargetPageGroupCaption = Nothing
        '
        'cViewsHistoryNavigation
        '
        resources.ApplyResources(Me.cViewsHistoryNavigation, "cViewsHistoryNavigation")
        Me.cViewsHistoryNavigation.ContainerId = "ViewsHistoryNavigation"
        Me.cViewsHistoryNavigation.Id = 35
        Me.cViewsHistoryNavigation.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.cViewsHistoryNavigation.Name = "cViewsHistoryNavigation"
        Me.cViewsHistoryNavigation.TargetPageCategoryColor = System.Drawing.Color.Empty
        Me.cViewsHistoryNavigation.TargetPageGroupCaption = Nothing
        '
        'cViewsNavigation
        '
        resources.ApplyResources(Me.cViewsNavigation, "cViewsNavigation")
        Me.cViewsNavigation.ContainerId = "ViewsNavigation"
        Me.cViewsNavigation.Id = 14
        Me.cViewsNavigation.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.cViewsNavigation.Name = "cViewsNavigation"
        Me.cViewsNavigation.TargetPageCategoryColor = System.Drawing.Color.Empty
        Me.cViewsNavigation.TargetPageGroupCaption = Nothing
        '
        'cRecordsNavigation
        '
        resources.ApplyResources(Me.cRecordsNavigation, "cRecordsNavigation")
        Me.cRecordsNavigation.ContainerId = "RecordsNavigation"
        Me.cRecordsNavigation.Id = 10
        Me.cRecordsNavigation.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.cRecordsNavigation.Name = "cRecordsNavigation"
        Me.cRecordsNavigation.TargetPageCategoryColor = System.Drawing.Color.Empty
        Me.cRecordsNavigation.TargetPageGroupCaption = Nothing
        '
        'cView
        '
        resources.ApplyResources(Me.cView, "cView")
        Me.cView.ContainerId = "View"
        Me.cView.Id = 12
        Me.cView.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.cView.Name = "cView"
        Me.cView.TargetPageCategoryColor = System.Drawing.Color.Empty
        Me.cView.TargetPageGroupCaption = Nothing
        '
        'cReports
        '
        Me.cReports.ApplicationMenuIndex = 12
        Me.cReports.ApplicationMenuItem = True
        resources.ApplyResources(Me.cReports, "cReports")
        Me.cReports.ContainerId = "Reports"
        Me.cReports.Id = 11
        Me.cReports.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.cReports.Name = "cReports"
        Me.cReports.TargetPageCategoryColor = System.Drawing.Color.Empty
        '
        'cDefault
        '
        resources.ApplyResources(Me.cDefault, "cDefault")
        Me.cDefault.ContainerId = "Default"
        Me.cDefault.Id = 50
        Me.cDefault.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.cDefault.Name = "cDefault"
        Me.cDefault.TargetPageCategoryColor = System.Drawing.Color.Empty
        Me.cDefault.TargetPageGroupCaption = Nothing
        '
        'cSearch
        '
        resources.ApplyResources(Me.cSearch, "cSearch")
        Me.cSearch.ContainerId = "Search"
        Me.cSearch.Id = 11
        Me.cSearch.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.cSearch.Name = "cSearch"
        Me.cSearch.TargetPageCategoryColor = System.Drawing.Color.Empty
        Me.cSearch.TargetPageGroupCaption = Nothing
        '
        'cFilters
        '
        resources.ApplyResources(Me.cFilters, "cFilters")
        Me.cFilters.ContainerId = "Filters"
        Me.cFilters.Id = 26
        Me.cFilters.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.cFilters.Name = "cFilters"
        Me.cFilters.TargetPageCategoryColor = System.Drawing.Color.Empty
        Me.cFilters.TargetPageGroupCaption = Nothing
        '
        'cFullTextSearch
        '
        Me.cFullTextSearch.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        resources.ApplyResources(Me.cFullTextSearch, "cFullTextSearch")
        Me.cFullTextSearch.ContainerId = "FullTextSearch"
        Me.cFullTextSearch.Id = 12
        Me.cFullTextSearch.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.cFullTextSearch.Name = "cFullTextSearch"
        Me.cFullTextSearch.TargetPageCategoryColor = System.Drawing.Color.Empty
        Me.cFullTextSearch.TargetPageGroupCaption = Nothing
        '
        'cAppearance
        '
        resources.ApplyResources(Me.cAppearance, "cAppearance")
        Me.cAppearance.ContainerId = "Appearance"
        Me.cAppearance.Id = 9
        Me.cAppearance.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.cAppearance.Name = "cAppearance"
        Me.cAppearance.TargetPageCategoryColor = System.Drawing.Color.Empty
        Me.cAppearance.TargetPageGroupCaption = Nothing
        '
        'barSubItemTools
        '
        resources.ApplyResources(Me.barSubItemTools, "barSubItemTools")
        Me.barSubItemTools.Id = 3
        Me.barSubItemTools.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cTools, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cOptions, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cDiagnostic, True)})
        Me.barSubItemTools.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barSubItemTools.Name = "barSubItemTools"
        '
        'cTools
        '
        resources.ApplyResources(Me.cTools, "cTools")
        Me.cTools.ContainerId = "Tools"
        Me.cTools.Id = 13
        Me.cTools.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.cTools.Name = "cTools"
        Me.cTools.TargetPageCategoryColor = System.Drawing.Color.Empty
        Me.cTools.TargetPageGroupCaption = Nothing
        '
        'cOptions
        '
        resources.ApplyResources(Me.cOptions, "cOptions")
        Me.cOptions.ContainerId = "Options"
        Me.cOptions.Id = 14
        Me.cOptions.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.cOptions.Name = "cOptions"
        Me.cOptions.TargetPageCategoryColor = System.Drawing.Color.Empty
        Me.cOptions.TargetPageGroupCaption = Nothing
        '
        'cDiagnostic
        '
        resources.ApplyResources(Me.cDiagnostic, "cDiagnostic")
        Me.cDiagnostic.ContainerId = "Diagnostic"
        Me.cDiagnostic.Id = 16
        Me.cDiagnostic.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.cDiagnostic.Name = "cDiagnostic"
        Me.cDiagnostic.TargetPageCategoryColor = System.Drawing.Color.Empty
        Me.cDiagnostic.TargetPageGroupCaption = Nothing
        '
        'barSubItemWindow
        '
        resources.ApplyResources(Me.barSubItemWindow, "barSubItemWindow")
        Me.barSubItemWindow.Id = 32
        Me.barSubItemWindow.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cWindows), New DevExpress.XtraBars.LinkPersistInfo(Me.Window, True)})
        Me.barSubItemWindow.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barSubItemWindow.Name = "barSubItemWindow"
        '
        'cWindows
        '
        resources.ApplyResources(Me.cWindows, "cWindows")
        Me.cWindows.Id = 16
        Me.cWindows.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barMdiChildrenListItem)})
        Me.cWindows.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.cWindows.Name = "cWindows"
        Me.cWindows.TargetPageCategoryColor = System.Drawing.Color.Empty
        Me.cWindows.TargetPageGroupCaption = Nothing
        '
        'barMdiChildrenListItem
        '
        resources.ApplyResources(Me.barMdiChildrenListItem, "barMdiChildrenListItem")
        Me.barMdiChildrenListItem.Id = 37
        Me.barMdiChildrenListItem.Name = "barMdiChildrenListItem"
        '
        'Window
        '
        resources.ApplyResources(Me.Window, "Window")
        Me.Window.ContainerId = "Windows"
        Me.Window.Id = 34
        Me.Window.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.Window.Name = "Window"
        Me.Window.TargetPageCategoryColor = System.Drawing.Color.Empty
        '
        'barSubItemHelp
        '
        resources.ApplyResources(Me.barSubItemHelp, "barSubItemHelp")
        Me.barSubItemHelp.Id = 4
        Me.barSubItemHelp.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cAbout, True)})
        Me.barSubItemHelp.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barSubItemHelp.Name = "barSubItemHelp"
        Me.barSubItemHelp.VisibleInRibbon = False
        '
        'cAbout
        '
        Me.cAbout.ApplicationMenuIndex = 15
        Me.cAbout.ApplicationMenuItem = True
        resources.ApplyResources(Me.cAbout, "cAbout")
        Me.cAbout.ContainerId = "About"
        Me.cAbout.Id = 15
        Me.cAbout.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.cAbout.Name = "cAbout"
        Me.cAbout.TargetPageCategoryColor = System.Drawing.Color.Empty
        Me.cAbout.TargetPageGroupCaption = Nothing
        '
        'standardToolBar
        '
        Me.standardToolBar.BarName = "Main Toolbar"
        Me.standardToolBar.DockCol = 0
        Me.standardToolBar.DockRow = 1
        Me.standardToolBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.standardToolBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cViewsHistoryNavigation, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cObjectsCreation, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cSave, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cEdit, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cUndoRedo, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cRecordEdit, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cOpenObject), New DevExpress.XtraBars.LinkPersistInfo(Me.cView, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cReports), New DevExpress.XtraBars.LinkPersistInfo(Me.cDefault, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cRecordsNavigation, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cFilters, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cSearch, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cFullTextSearch)})
        Me.standardToolBar.OptionsBar.UseWholeRow = True
        Me.standardToolBar.TargetPageCategoryColor = System.Drawing.Color.Empty
        resources.ApplyResources(Me.standardToolBar, "standardToolBar")
        '
        '_statusBar
        '
        Me._statusBar.BarName = "StatusBar"
        Me._statusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me._statusBar.DockCol = 0
        Me._statusBar.DockRow = 0
        Me._statusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me._statusBar.OptionsBar.AllowQuickCustomization = False
        Me._statusBar.OptionsBar.DisableClose = True
        Me._statusBar.OptionsBar.DisableCustomization = True
        Me._statusBar.OptionsBar.DrawDragBorder = False
        Me._statusBar.OptionsBar.DrawSizeGrip = True
        Me._statusBar.OptionsBar.UseWholeRow = True
        Me._statusBar.TargetPageCategoryColor = System.Drawing.Color.Empty
        resources.ApplyResources(Me._statusBar, "_statusBar")
        '
        'mainBarAndDockingController
        '
        Me.mainBarAndDockingController.PropertiesBar.AllowLinkLighting = False
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        resources.ApplyResources(Me.barDockControlTop, "barDockControlTop")
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        resources.ApplyResources(Me.barDockControlBottom, "barDockControlBottom")
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        resources.ApplyResources(Me.barDockControlLeft, "barDockControlLeft")
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        resources.ApplyResources(Me.barDockControlRight, "barDockControlRight")
        '
        'mainDockManager
        '
        Me.mainDockManager.Controller = Me.mainBarAndDockingController
        Me.mainDockManager.Form = Me
        Me.mainDockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanelNavigation_Renamed})
        Me.mainDockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.ExpressApp.Win.Templates.Controls.XafRibbonControl", "DevExpress.XtraBars.Ribbon.RibbonStatusBar"})
        '
        'dockPanelNavigation_Renamed
        '
        Me.dockPanelNavigation_Renamed.Controls.Add(Me.dockPanelNavigation_Container)
        Me.dockPanelNavigation_Renamed.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.dockPanelNavigation_Renamed.FloatSize = New System.Drawing.Size(146, 428)
        Me.dockPanelNavigation_Renamed.ID = New System.Guid("24977e30-0ea6-44aa-8fa4-9abaeb178b5e")
        resources.ApplyResources(Me.dockPanelNavigation_Renamed, "dockPanelNavigation_Renamed")
        Me.dockPanelNavigation_Renamed.Name = "dockPanelNavigation_Renamed"
        Me.dockPanelNavigation_Renamed.Options.AllowDockBottom = False
        Me.dockPanelNavigation_Renamed.Options.AllowDockTop = False
        Me.dockPanelNavigation_Renamed.OriginalSize = New System.Drawing.Size(200, 200)
        Me.dockPanelNavigation_Renamed.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.dockPanelNavigation_Renamed.SavedIndex = 2
        Me.dockPanelNavigation_Renamed.TabStop = False
        '
        'dockPanelNavigation_Container
        '
        Me.dockPanelNavigation_Container.Controls.Add(Me.navigation)
        resources.ApplyResources(Me.dockPanelNavigation_Container, "dockPanelNavigation_Container")
        Me.dockPanelNavigation_Container.Name = "dockPanelNavigation_Container"
        '
        'navigation
        '
        resources.ApplyResources(Me.navigation, "navigation")
        Me.navigation.Model = Nothing
        Me.navigation.Name = "navigation"
        '
        'cMenu
        '
        resources.ApplyResources(Me.cMenu, "cMenu")
        Me.cMenu.ContainerId = "Menu"
        Me.cMenu.Id = 7
        Me.cMenu.Name = "cMenu"
        Me.cMenu.TargetPageCategoryColor = System.Drawing.Color.Empty
        Me.cMenu.TargetPageGroupCaption = Nothing
        '
        'formStateModelSynchronizerComponent
        '
        Me.formStateModelSynchronizerComponent.Form = Me
        Me.formStateModelSynchronizerComponent.Model = Nothing
        '
        'MainForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BarManager = Me.mainBarManager
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.dockPanelNavigation_Renamed)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IsMdiContainer = True
        Me.Name = "MainForm"
        CType(Me.xafTabbedMdiManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.viewSitePanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mainBarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mainBarAndDockingController, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mainDockManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dockPanelNavigation_Renamed.ResumeLayout(False)
        Me.dockPanelNavigation_Container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private barDockControlTop As DevExpress.XtraBars.BarDockControl
    Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Private barDockControlRight As DevExpress.XtraBars.BarDockControl
    Private _mainMenuBar As DevExpress.ExpressApp.Win.Templates.Controls.XafBar
    Private standardToolBar As DevExpress.ExpressApp.Win.Templates.Controls.XafBar
    Private _statusBar As DevExpress.ExpressApp.Win.Templates.Controls.XafBar
    Private cFile As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cObjectsCreation As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cPrint As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cExport As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cSave As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cUndoRedo As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cAppearance As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem
    Private cReports As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cEdit As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cExit As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cOpenObject As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private barSubItemFile As DevExpress.ExpressApp.Win.Templates.MainMenuItem
    Private barSubItemEdit As DevExpress.ExpressApp.Win.Templates.MainMenuItem
    Private barSubItemView As DevExpress.ExpressApp.Win.Templates.MainMenuItem
    Private barSubItemTools As DevExpress.ExpressApp.Win.Templates.MainMenuItem
    Private barSubItemHelp As DevExpress.ExpressApp.Win.Templates.MainMenuItem
    Private cViewsNavigation As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem
    Private cRecordEdit As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cRecordsNavigation As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cViewsHistoryNavigation As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cSearch As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cFullTextSearch As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cFilters As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cView As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cDefault As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cTools As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem
    Private cDiagnostic As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem
    Private cOptions As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem
    Private cAbout As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem
    Private cWindows As DevExpress.ExpressApp.Win.Templates.ActionContainers.XafBarLinkContainerItem
    Private cPanels As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem
    Private cMenu As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private barSubItemWindow As DevExpress.ExpressApp.Win.Templates.MainMenuItem
    Private barMdiChildrenListItem As DevExpress.XtraBars.BarMdiChildrenListItem

#End Region

    Protected navigation As DevExpress.ExpressApp.Win.Templates.ActionContainers.NavigationActionContainer
    Protected formStateModelSynchronizerComponent As DevExpress.ExpressApp.Win.Core.FormStateModelSynchronizer
    Private mainBarAndDockingController As BarAndDockingController
    Private mainDockManager As DevExpress.XtraBars.Docking.DockManager
    Protected mainBarManager As DevExpress.ExpressApp.Win.Templates.Controls.XafBarManager
    Private dockPanelNavigation_Renamed As DevExpress.XtraBars.Docking.DockPanel
    Private dockPanelNavigation_Container As DevExpress.XtraBars.Docking.ControlContainer
    Private viewSitePanel As DevExpress.XtraEditors.PanelControl
    Private Window As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private barSubItemPanels As BarSubItem
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
End Class