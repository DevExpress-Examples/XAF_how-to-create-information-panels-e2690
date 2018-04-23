Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Model
Imports DevExpress.ExpressApp.Win.Templates.ActionContainers
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.ExpressApp.Win.SystemModule
Imports InfoPanels.Module.Win.Controllers

Namespace InfoPanels.Module.Win
    Partial Public Class DetailViewForm
        Inherits DevExpress.ExpressApp.Win.Templates.XtraFormTemplateBase
        Implements ISupportClassicToRibbonTransform, IInfoPanelTemplateWin
        Public ReadOnly Property SplitContainer() As DevExpress.XtraEditors.SplitContainerControl _
        Implements IInfoPanelTemplateWin.SplitContainer
            Get
                Return splitContainerControl1
            End Get
        End Property

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            CheckTransformToRibbon(False)
        End Sub
        Protected Overrides Function GetFormStateNode() As IModelFormState
            If View IsNot Nothing Then
                Return TemplatesHelper.GetFormStateNode(View.Id)
            Else
                Return MyBase.GetFormStateNode()
            End If
        End Function
        Public Overrides Sub SetSettings(ByVal modelTemplate As IModelTemplate)
            MyBase.SetSettings(modelTemplate)
            formStateModelSynchronizerComponent.Model = GetFormStateNode()
        End Sub
        <Obsolete("Use the DetailViewForm() constructor"), Browsable(False), EditorBrowsable(EditorBrowsableState.Never)> _
        Public Sub New(ByVal application As XafApplication)
            Me.New()
        End Sub
        Public Sub New()
            InitializeComponent()
        End Sub
        Public ReadOnly Property MainMenuBar() As Bar
            Get
                Return _mainMenuBar
            End Get
        End Property
        Public ReadOnly Property ToolBar() As Bar
            Get
                Return standardToolBar
            End Get
        End Property
        Public ReadOnly Property ClassicStatusBar() As Bar
            Get
                Return _statusBar
            End Get
        End Property
#Region "ISupportClassicToRibbonTransform Members"
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
#End Region
    End Class
End Namespace

