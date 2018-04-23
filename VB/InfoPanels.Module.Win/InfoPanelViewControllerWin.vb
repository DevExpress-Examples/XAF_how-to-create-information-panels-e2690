Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.SystemModule
Imports DevExpress.ExpressApp.Templates

Public Interface IInfoPanelTemplateWin
    Inherits IFrameTemplate
    ReadOnly Property SplitContainer() As SplitContainerControl
End Interface
Partial Public Class InfoPanelViewControllerWin
    Inherits CustomizeTemplateViewControllerBase(Of IInfoPanelTemplateWin)
    Private label As LabelControl
    Protected Overrides Sub AddControlsToTemplateCore(ByVal template As IInfoPanelTemplateWin)
        If label Is Nothing Then
            label = New LabelControl()
        End If
        template.SplitContainer.Panel2.Controls.Add(label)
    End Sub
    Protected Overrides Sub RemoveControlsFromTemplateCore(ByVal template As IInfoPanelTemplateWin)
        template.SplitContainer.Panel2.Controls.Remove(label)
        label = Nothing
    End Sub
    Protected Overloads Overrides Sub UpdateControls(ByVal view As View)
        UpdateControls()
    End Sub
    Protected Overloads Overrides Sub UpdateControls(ByVal currentObject As Object)
        UpdateControls()
    End Sub
    Private Overloads Sub UpdateControls()
        label.Text = "The current View is " & View.Caption
        If View.CurrentObject IsNot Nothing Then
            label.Text += System.Environment.NewLine & "The current object is " & View.CurrentObject.ToString()
        End If
    End Sub
End Class
