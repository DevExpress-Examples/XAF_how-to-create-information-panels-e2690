Imports Microsoft.VisualBasic
Imports System.Web.UI
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.SystemModule
Imports DevExpress.ExpressApp.Templates
Imports DevExpress.ExpressApp.Web.Templates

Namespace InfoPanels.Module.Web
    Public Interface IInfoPanelTemplateWeb
    Inherits IFrameTemplate
        ReadOnly Property PlaceHolder() As Control
    End Interface
    Public Class InfoPanelViewControllerWeb
        Inherits CustomizeTemplateViewControllerBase(Of IInfoPanelTemplateWeb)
        Private literal As LiteralControl
        Protected Overrides Sub AddControlsToTemplateCore(ByVal template As IInfoPanelTemplateWeb)
            If literal Is Nothing Then
                literal = New LiteralControl()
            End If
            template.PlaceHolder.Controls.Add(literal)
        End Sub
        Protected Overrides Sub RemoveControlsFromTemplateCore(ByVal template As IInfoPanelTemplateWeb)
            template.PlaceHolder.Controls.Remove(literal)
            literal = Nothing
        End Sub
        Protected Overrides Overloads Sub UpdateControls(ByVal view As View)
            UpdateControls()
        End Sub
        Protected Overrides Overloads Sub UpdateControls(ByVal currentObject As Object)
            UpdateControls()
        End Sub
        Private Overloads Sub UpdateControls()
            literal.Text = "The current View is " & View.Caption
            If View.CurrentObject IsNot Nothing Then
                literal.Text &= "<br/>The current object is " & View.CurrentObject.ToString()
            End If
        End Sub
    End Class
End Namespace
