Imports DevExpress.ExpressApp.Web
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.ExpressApp.Web.Templates

Partial Public Class DialogPage
	Inherits BaseXafPage
	Implements ILookupPopupFrameTemplate

	Private Sub window_PagePreRender(ByVal sender As Object, ByVal e As EventArgs)
		RemoveHandler CType(sender, WebWindow).PagePreRender, AddressOf window_PagePreRender
		If SearchActionContainer.HasActiveActions() AndAlso IsSearchEnabled Then
			TableCell1.Style("padding-bottom") = "30px"
		End If
	End Sub
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		ViewSiteControl = viewSiteControl_Renamed
		WebApplication.Instance.CreateControls(Me)
		Dim window As WebWindow = WebWindow.CurrentRequestWindow
		If window IsNot Nothing Then
'INSTANT VB NOTE: The variable clientScript was renamed since Visual Basic does not handle local variables named the same as class members well:
			Dim clientScript_Renamed As String = String.Format(" " & ControlChars.CrLf & "            var activePopupControl = GetActivePopupControl(window.parent);" & ControlChars.CrLf & "            if (activePopupControl != null){{" & ControlChars.CrLf & "                var viewImageControl = document.getElementById('{0}');" & ControlChars.CrLf & "                if (viewImageControl && viewImageControl.src != ''){{" & ControlChars.CrLf & "                    activePopupControl.SetHeaderImageUrl(viewImageControl.src);" & ControlChars.CrLf & "                }}" & ControlChars.CrLf & "                var viewCaptionControl = document.getElementById('{1}');" & ControlChars.CrLf & "                if (viewCaptionControl){{" & ControlChars.CrLf & "                    activePopupControl.SetHeaderText(viewCaptionControl.innerText);" & ControlChars.CrLf & "                }}" & ControlChars.CrLf & "            }}", viewImageControl.Control.ClientID, viewCaptionControl.Control.ClientID)
			window.RegisterStartupScript("UpdatePopupControlHeader", clientScript_Renamed, True)
			AddHandler window.PagePreRender, AddressOf window_PagePreRender
		End If
	End Sub
	Public Sub New()
	End Sub
	#Region "ILookupPopupFrameTemplate Members"

	Public Property IsSearchEnabled() As Boolean Implements ILookupPopupFrameTemplate.IsSearchEnabled
		Get
			Return SearchActionContainer.Visible
		End Get
		Set(ByVal value As Boolean)
			SearchActionContainer.Visible = value
		End Set
	End Property

	Public Sub SetStartSearchString(ByVal searchString As String) Implements ILookupPopupFrameTemplate.SetStartSearchString
	End Sub

	Public Sub FocusFindEditor() Implements ILookupPopupFrameTemplate.FocusFindEditor
	End Sub
	#End Region
End Class
