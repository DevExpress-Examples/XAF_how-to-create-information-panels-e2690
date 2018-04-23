Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp.Win.Templates
Partial Public Class DetailViewForm
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
            Me.mainBarManager = Nothing
            Me.barDockControlBottom = Nothing
            Me.barDockControlLeft = Nothing
            Me.barDockControlRight = Nothing
            Me.barDockControlTop = Nothing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetailViewForm))
        Me.mainBarManager = New DevExpress.ExpressApp.Win.Templates.Controls.XafBarManager(Me.components)
        Me._mainMenuBar = New DevExpress.ExpressApp.Win.Templates.Controls.XafBar
        Me.barSubItemFile = New DevExpress.ExpressApp.Win.Templates.MainMenuItem
        Me.cObjectsCreation = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.cFile = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.cClose = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.cSave = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.cExport = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.cPrint = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.barSubItemEdit = New DevExpress.ExpressApp.Win.Templates.MainMenuItem
        Me.cUndoRedo = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.cEdit = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.cRecordEdit = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.cOpenObject = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.barSubItemView = New DevExpress.ExpressApp.Win.Templates.MainMenuItem
        Me.cRecordsNavigation = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.cView = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.cReports = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.cSearch = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.cFullTextSearch = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.cFilters = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.barSubItemTools = New DevExpress.ExpressApp.Win.Templates.MainMenuItem
        Me.cTools = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem
        Me.cOptions = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem
        Me.cDiagnostic = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem
        Me.barSubItemHelp = New DevExpress.ExpressApp.Win.Templates.MainMenuItem
        Me.cAbout = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem
        Me.standardToolBar = New DevExpress.ExpressApp.Win.Templates.Controls.XafBar
        Me._statusBar = New DevExpress.ExpressApp.Win.Templates.Controls.XafBar
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.cMenu = New DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
        Me.viewSitePanel = New DevExpress.XtraEditors.PanelControl
        Me.formStateModelSynchronizerComponent = New DevExpress.ExpressApp.Win.Core.FormStateModelSynchronizer(Me.components)
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        CType(Me.mainBarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewSitePanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'actionsContainersManager
        '
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cObjectsCreation)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cFile)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cClose)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cSave)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cExport)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cPrint)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cUndoRedo)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cEdit)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cRecordEdit)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cOpenObject)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cRecordsNavigation)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cView)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cReports)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cSearch)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cFullTextSearch)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cFilters)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cTools)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cOptions)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cDiagnostic)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cAbout)
        Me.actionsContainersManager.ActionContainerComponents.Add(Me.cMenu)
        Me.actionsContainersManager.ContextMenuContainers.Add(Me.cObjectsCreation)
        Me.actionsContainersManager.ContextMenuContainers.Add(Me.cSave)
        Me.actionsContainersManager.ContextMenuContainers.Add(Me.cEdit)
        Me.actionsContainersManager.ContextMenuContainers.Add(Me.cOpenObject)
        Me.actionsContainersManager.ContextMenuContainers.Add(Me.cUndoRedo)
        Me.actionsContainersManager.ContextMenuContainers.Add(Me.cReports)
        Me.actionsContainersManager.ContextMenuContainers.Add(Me.cClose)
        Me.actionsContainersManager.ContextMenuContainers.Add(Me.cRecordEdit)
        Me.actionsContainersManager.ContextMenuContainers.Add(Me.cView)
        Me.actionsContainersManager.ContextMenuContainers.Add(Me.cPrint)
        Me.actionsContainersManager.ContextMenuContainers.Add(Me.cExport)
        Me.actionsContainersManager.ContextMenuContainers.Add(Me.cMenu)
        Me.actionsContainersManager.DefaultContainer = Me.cView
        '
        'modelSynchronizationManager
        '
        Me.modelSynchronizationManager.ModelSynchronizableComponents.Add(Me.formStateModelSynchronizerComponent)
        Me.modelSynchronizationManager.ModelSynchronizableComponents.Add(Me.mainBarManager)
        Me.modelSynchronizationManager.ModelSynchronizableComponents.Add(Me.mainBarManager)
        '
        'viewSiteManager
        '
        Me.viewSiteManager.ViewSiteControl = Me.viewSitePanel
        '
        'mainBarManager
        '
        Me.mainBarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me._mainMenuBar, Me.standardToolBar, Me._statusBar})
        Me.mainBarManager.DockControls.Add(Me.barDockControlTop)
        Me.mainBarManager.DockControls.Add(Me.barDockControlBottom)
        Me.mainBarManager.DockControls.Add(Me.barDockControlLeft)
        Me.mainBarManager.DockControls.Add(Me.barDockControlRight)
        Me.mainBarManager.Form = Me
        Me.mainBarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barSubItemFile, Me.barSubItemEdit, Me.barSubItemView, Me.barSubItemTools, Me.barSubItemHelp, Me.cFile, Me.cObjectsCreation, Me.cClose, Me.cSave, Me.cEdit, Me.cOpenObject, Me.cUndoRedo, Me.cReports, Me.cPrint, Me.cExport, Me.cMenu, Me.cRecordEdit, Me.cRecordsNavigation, Me.cSearch, Me.cFullTextSearch, Me.cFilters, Me.cView, Me.cTools, Me.cOptions, Me.cDiagnostic, Me.cAbout})
        Me.mainBarManager.MainMenu = Me._mainMenuBar
        Me.mainBarManager.MaxItemId = 23
        Me.mainBarManager.StatusBar = Me._statusBar
        '
        '_mainMenuBar
        '
        Me._mainMenuBar.BarName = "Main Menu"
        Me._mainMenuBar.DockCol = 0
        Me._mainMenuBar.DockRow = 0
        Me._mainMenuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me._mainMenuBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItemFile), New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItemEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItemView), New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItemTools), New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItemHelp)})
        Me._mainMenuBar.OptionsBar.MultiLine = True
        Me._mainMenuBar.OptionsBar.UseWholeRow = True
        Me._mainMenuBar.TargetPageCategoryColor = System.Drawing.Color.Empty
        resources.ApplyResources(Me._mainMenuBar, "_mainMenuBar")
        '
        'barSubItemFile
        '
        resources.ApplyResources(Me.barSubItemFile, "barSubItemFile")
        Me.barSubItemFile.Id = 0
        Me.barSubItemFile.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cObjectsCreation, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cFile, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cClose, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cSave, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cExport, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cPrint, True)})
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
        Me.cObjectsCreation.Id = 17
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
        'cClose
        '
        Me.cClose.ApplicationMenuIndex = 2
        Me.cClose.ApplicationMenuItem = True
        resources.ApplyResources(Me.cClose, "cClose")
        Me.cClose.ContainerId = "Close"
        Me.cClose.Id = 18
        Me.cClose.MergeOrder = 2
        Me.cClose.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.cClose.Name = "cClose"
        Me.cClose.TargetPageCategoryColor = System.Drawing.Color.Empty
        Me.cClose.TargetPageGroupCaption = Nothing
        '
        'cSave
        '
        Me.cSave.ApplicationMenuIndex = 7
        Me.cSave.ApplicationMenuItem = True
        resources.ApplyResources(Me.cSave, "cSave")
        Me.cSave.ContainerId = "Save"
        Me.cSave.Id = 17
        Me.cSave.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.cSave.Name = "cSave"
        Me.cSave.TargetPageCategoryColor = System.Drawing.Color.Empty
        Me.cSave.TargetPageGroupCaption = Nothing
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
        Me.cUndoRedo.Id = 19
        Me.cUndoRedo.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.cUndoRedo.Name = "cUndoRedo"
        Me.cUndoRedo.TargetPageCategoryColor = System.Drawing.Color.Empty
        '
        'cEdit
        '
        resources.ApplyResources(Me.cEdit, "cEdit")
        Me.cEdit.ContainerId = "Edit"
        Me.cEdit.Id = 18
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
        Me.cOpenObject.Id = 20
        Me.cOpenObject.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.cOpenObject.Name = "cOpenObject"
        Me.cOpenObject.TargetPageCategoryColor = System.Drawing.Color.Empty
        Me.cOpenObject.TargetPageGroupCaption = Nothing
        '
        'barSubItemView
        '
        resources.ApplyResources(Me.barSubItemView, "barSubItemView")
        Me.barSubItemView.Id = 2
        Me.barSubItemView.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cRecordsNavigation, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cView, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cReports, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cSearch, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, False, Me.cFullTextSearch, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, False, Me.cFilters, True)})
        Me.barSubItemView.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barSubItemView.Name = "barSubItemView"
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
        resources.ApplyResources(Me.cReports, "cReports")
        Me.cReports.ContainerId = "Reports"
        Me.cReports.Id = 20
        Me.cReports.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.cReports.Name = "cReports"
        Me.cReports.TargetPageCategoryColor = System.Drawing.Color.Empty
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
        Me.standardToolBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cObjectsCreation, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cSave, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cEdit, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cUndoRedo, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cRecordEdit, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cOpenObject), New DevExpress.XtraBars.LinkPersistInfo(Me.cView, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cReports), New DevExpress.XtraBars.LinkPersistInfo(Me.cRecordsNavigation, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cClose, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cFilters, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cSearch, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cFullTextSearch)})
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
        'cMenu
        '
        resources.ApplyResources(Me.cMenu, "cMenu")
        Me.cMenu.ContainerId = "Menu"
        Me.cMenu.Id = 8
        Me.cMenu.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.cMenu.Name = "cMenu"
        Me.cMenu.TargetPageCategoryColor = System.Drawing.Color.Empty
        Me.cMenu.TargetPageGroupCaption = Nothing
        '
        'viewSitePanel
        '
        Me.viewSitePanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        resources.ApplyResources(Me.viewSitePanel, "viewSitePanel")
        Me.viewSitePanel.Name = "viewSitePanel"
        '
        'formStateModelSynchronizerComponent
        '
        Me.formStateModelSynchronizerComponent.Form = Me
        Me.formStateModelSynchronizerComponent.Model = Nothing
        '
        'SplitContainerControl1
        '
        resources.ApplyResources(Me.SplitContainerControl1, "SplitContainerControl1")
        Me.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.viewSitePanel)
        resources.ApplyResources(Me.SplitContainerControl1.Panel1, "SplitContainerControl1.Panel1")
        resources.ApplyResources(Me.SplitContainerControl1.Panel2, "SplitContainerControl1.Panel2")
        Me.SplitContainerControl1.SplitterPosition = 178
        '
        'DetailViewForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BarManager = Me.mainBarManager
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "DetailViewForm"
        CType(Me.mainBarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewSitePanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
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
    Private cClose As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cSave As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cEdit As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cOpenObject As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cUndoRedo As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cReports As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cPrint As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cExport As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cMenu As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private barSubItemFile As DevExpress.ExpressApp.Win.Templates.MainMenuItem
    Private barSubItemEdit As DevExpress.ExpressApp.Win.Templates.MainMenuItem
    Private barSubItemView As DevExpress.ExpressApp.Win.Templates.MainMenuItem
    Private barSubItemTools As DevExpress.ExpressApp.Win.Templates.MainMenuItem
    Private barSubItemHelp As DevExpress.ExpressApp.Win.Templates.MainMenuItem
    Private cRecordEdit As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cRecordsNavigation As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cSearch As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cFullTextSearch As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cFilters As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cView As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem
    Private cTools As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem
    Private cOptions As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem
    Private cAbout As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem
    Private cDiagnostic As DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerMenuBarItem
#End Region
    Protected mainBarManager As DevExpress.ExpressApp.Win.Templates.Controls.XafBarManager
    Protected viewSitePanel As DevExpress.XtraEditors.PanelControl
    Protected formStateModelSynchronizerComponent As DevExpress.ExpressApp.Win.Core.FormStateModelSynchronizer
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
End Class
