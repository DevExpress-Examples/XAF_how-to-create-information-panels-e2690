Imports System.ComponentModel
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.SystemModule
Imports System.Web.UI
Imports DevExpress.ExpressApp.Templates

Namespace InfoPanels.Module.Web.Controllers
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
            If template.PlaceHolder IsNot Nothing Then
                template.PlaceHolder.Controls.Add(literal)
            End If
        End Sub
        Protected Overrides Sub RemoveControlsFromTemplateCore(ByVal template As IInfoPanelTemplateWeb)
            If template.PlaceHolder IsNot Nothing Then
                template.PlaceHolder.Controls.Remove(literal)
                literal = Nothing
            End If
        End Sub
        Protected Overrides Sub UpdateControls(ByVal view As View)
            UpdateControlsCore()
        End Sub
        Protected Overrides Sub UpdateControls(ByVal currentObject As Object)
            UpdateControlsCore()
        End Sub
        Private Sub UpdateControlsCore()
            literal.Text = "The current View is " & View.Caption
            If View.CurrentObject IsNot Nothing Then
                literal.Text &= "<br/>The current object is " & View.CurrentObject.ToString()
            End If
        End Sub
    End Class
End Namespace
