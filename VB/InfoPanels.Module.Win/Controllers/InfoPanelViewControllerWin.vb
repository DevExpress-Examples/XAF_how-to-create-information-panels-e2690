Imports System.ComponentModel
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.SystemModule
Imports DevExpress.XtraEditors

Namespace InfoPanels.Module.Win.Controllers
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
		Protected Overrides Sub UpdateControls(ByVal view As View)
            UpdateControlsCore()
		End Sub
		Protected Overrides Sub UpdateControls(ByVal currentObject As Object)
            UpdateControlsCore()
		End Sub
        Private Sub UpdateControlsCore()
            label.Text = "The current View is " & View.Caption
            If View.CurrentObject IsNot Nothing Then
                label.Text &= System.Environment.NewLine & "The current object is " & View.CurrentObject.ToString()
            End If
        End Sub
	End Class
End Namespace
