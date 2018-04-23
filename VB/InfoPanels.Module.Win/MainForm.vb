Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Model
Imports DevExpress.ExpressApp.Utils
Imports DevExpress.ExpressApp.Win.SystemModule
Imports DevExpress.ExpressApp.Win.Templates.ActionContainers
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.ExpressApp.Win.Templates


Partial Public Class MainForm
    Inherits MainFormTemplateBase
    Implements IDockManagerHolder, ISupportMdiContainer, ISupportClassicToRibbonTransform, IInfoPanelTemplateWin
    Public Overrides Sub SetSettings(ByVal modelTemplate As IModelTemplate)
        MyBase.SetSettings(modelTemplate)
        navigation.Model = TemplatesHelper.GetNavBarCustomizationNode()
        formStateModelSynchronizerComponent.Model = GetFormStateNode()
        modelSynchronizationManager.ModelSynchronizableComponents.Add(New NavigationModelSynchronizer(dockPanelNavigation_Renamed, CType(modelTemplate, IModelTemplateWin)))
    End Sub
    Protected Overridable Sub InitializeImages()
        barMdiChildrenListItem.Glyph = ImageLoader.Instance.GetImageInfo("Action_WindowList").Image
        barMdiChildrenListItem.LargeGlyph = ImageLoader.Instance.GetLargeImageInfo("Action_WindowList").Image
        barSubItemPanels.Glyph = ImageLoader.Instance.GetImageInfo("Action_Navigation").Image
        barSubItemPanels.LargeGlyph = ImageLoader.Instance.GetLargeImageInfo("Action_Navigation").Image
    End Sub
    <Obsolete("Use the MainForm() constructor"), Browsable(False), EditorBrowsable(EditorBrowsableState.Never)> _
    Public Sub New(ByVal application As XafApplication)
        Me.New()
    End Sub
    Public Sub New()
        InitializeComponent()
        InitializeImages()
        UpdateMdiModeDependentProperties()
    End Sub
    Public ReadOnly Property ClassicStatusBar() As Bar
        Get
            Return _statusBar
        End Get
    End Property
    Public ReadOnly Property DockPanelNavigation() As DockPanel
        Get
            Return dockPanelNavigation_Renamed
        End Get
    End Property
    Public ReadOnly Property DockManager() As DockManager Implements IDockManagerHolder.DockManager
        Get
            Return mainDockManager
        End Get
    End Property
    Protected Overrides Sub UpdateMdiModeDependentProperties()
        MyBase.UpdateMdiModeDependentProperties()
        Dim isMdi As Boolean = UIMode = UIMode.Mdi
        'viewSitePanel.Visible = Not isMdi
        SplitContainerControl1.Visible = Not isMdi
        'Do not replace with ? operator (problems with convertion to VB)
        If isMdi Then
            barSubItemWindow.Visibility = BarItemVisibility.Always
            barMdiChildrenListItem.Visibility = BarItemVisibility.Always
        Else
            barSubItemWindow.Visibility = BarItemVisibility.Never
            barMdiChildrenListItem.Visibility = BarItemVisibility.Never
        End If
    End Sub
    Public Overloads Property FormStyle() As RibbonFormStyle Implements ISupportClassicToRibbonTransform.FormStyle
        Get
            Return MyBase.FormStyle
        End Get
        Set(ByVal value As RibbonFormStyle)
            MyBase.FormStyle = value
        End Set
    End Property
    Public Overloads ReadOnly Property RibbonOptions() As IModelOptionsRibbon Implements ISupportClassicToRibbonTransform.RibbonOptions
        Get
            Dim _ribbonOptions As IModelOptionsRibbon = Nothing
            If ModelTemplate IsNot Nothing Then
                _ribbonOptions = TryCast(ModelTemplate.Application.Options, IModelOptionsWin).RibbonOptions
            End If
            Return _ribbonOptions
        End Get
    End Property

#Region "IInfoPanelTemplateWin Members"

    Public ReadOnly Property SplitContainer() As DevExpress.XtraEditors.SplitContainerControl Implements IInfoPanelTemplateWin.SplitContainer
        Get
            Return SplitContainerControl1
        End Get
    End Property

#End Region

End Class
