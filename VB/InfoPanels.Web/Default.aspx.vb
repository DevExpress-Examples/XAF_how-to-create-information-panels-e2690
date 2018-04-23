Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web.UI
Imports DevExpress.ExpressApp.Templates
Imports DevExpress.ExpressApp.Web
Imports DevExpress.ExpressApp.Web.Templates
Imports DevExpress.ExpressApp.Web.Templates.ActionContainers
Imports InfoPanels.Module.Web

Partial Public Class [Default]
    Inherits BaseXafPage
    Implements IInfoPanelTemplateWeb
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        ViewSiteControl = VSC
        WebApplication.Instance.CreateControls(Me)
    End Sub
    Protected Overrides Function CreateContextActionsMenu() As ContextActionsMenu
        Return New ContextActionsMenu(Me, "Edit", "RecordEdit", "ObjectsCreation", "ListView", "Reports")
    End Function
    Protected Overrides Function GetDefaultContainer() As IActionContainer
        Return TB.FindActionContainerById("View")
    End Function
    Public Overrides Sub SetStatus(ByVal statusMessages As System.Collections.Generic.ICollection(Of String))
        InfoMessagesPanel.Text = String.Join("<br>", New List(Of String)(statusMessages).ToArray())
    End Sub
    Public ReadOnly Property PlaceHolder() As Control Implements IInfoPanelTemplateWeb.PlaceHolder
        Get
            Return UPRight
        End Get
    End Property
End Class
