Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web.UI
Imports DevExpress.ExpressApp.Templates
Imports DevExpress.ExpressApp.Web
Imports DevExpress.ExpressApp.Web.Templates
Imports DevExpress.ExpressApp.Web.Templates.ActionContainers

Partial Public Class [Default]
    Inherits BaseXafPage
    Implements InfoPanels.Module.Web.IInfoPanelTemplateWeb
    Private Sub Splitter_PreRender(ByVal sender As Object, ByVal e As EventArgs)
        RemoveHandler Splitter.PreRender, AddressOf Splitter_PreRender
        Splitter.Panes("Left").Visible = VerticalToolsActionContainer.HasActiveActions() Or DiagnosticActionContainer.HasActiveActions()
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        AddHandler Splitter.PreRender, AddressOf Splitter_PreRender
        WebApplication.Instance.CreateControls(Me)
    End Sub
    Protected Overrides Function CreateContextActionsMenu() As ContextActionsMenu
        Return New ContextActionsMenu(Me, "Edit", "RecordEdit", "ObjectsCreation", "ListView", "Reports")
    End Function
    Protected Overrides Function GetDefaultContainer() As IActionContainer
        Return ToolBar.FindActionContainerById("View")
    End Function
    Public Overrides Sub SetStatus(ByVal statusMessages As System.Collections.Generic.ICollection(Of String))
        InfoMessagesPanel.Text = String.Join("<br>", New List(Of String)(statusMessages).ToArray())
    End Sub

#Region "IInfoPanelTemplateWeb Members"

    Public ReadOnly Property SplitContainer() As DevExpress.Web.ASPxSplitter.ASPxSplitter Implements InfoPanels.Module.Web.IInfoPanelTemplateWeb.SplitContainer
        Get
            Return Splitter
        End Get
    End Property

#End Region

End Class
