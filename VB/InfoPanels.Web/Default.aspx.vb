Imports System.Web.UI
Imports DevExpress.ExpressApp.Templates
Imports DevExpress.ExpressApp.Web
Imports DevExpress.ExpressApp.Web.Templates
Imports DevExpress.ExpressApp.Web.Templates.ActionContainers
Imports InfoPanels.Module.Web.Controllers
Imports InfoPanels.Web

Partial Public Class [Default]
    Inherits BaseXafPage
    Implements IInfoPanelTemplateWeb

     Public ReadOnly Property PlaceHolder() As Control Implements IInfoPanelTemplateWeb.PlaceHolder
        Get
            Return If(TypeOf TemplateContent Is MyDefaultVerticalTemplateContent, _
            CType(TemplateContent, MyDefaultVerticalTemplateContent).PlaceHolder, Nothing)
        End Get
    End Property
    Protected Overrides Function CreateContextActionsMenu() As ContextActionsMenu
        Return New ContextActionsMenu(Me, "Edit", "RecordEdit", "ObjectsCreation", "ListView", "Reports")
    End Function
    Public Overrides ReadOnly Property InnerContentPlaceHolder() As Control
        Get
            Return Content
        End Get
    End Property
End Class
