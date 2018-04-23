Imports System.Text
Imports DevExpress.ExpressApp.Web
Imports DevExpress.ExpressApp.Web.Templates
Imports System.Web.UI
Imports DevExpress.ExpressApp.Web.Templates.ActionContainers
Imports DevExpress.ExpressApp.Templates

Namespace InfoPanels.Web
    Partial Public Class MyDefaultVerticalTemplateContent
        Inherits TemplateContent

        Public ReadOnly Property PlaceHolder() As Control
            Get
                Return UPRight
            End Get
        End Property
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            If WebWindow.CurrentRequestWindow IsNot Nothing Then
                AddHandler WebWindow.CurrentRequestWindow.PagePreRender, AddressOf CurrentRequestWindow_PagePreRender
            End If
        End Sub
        Protected Overrides Sub OnUnload(ByVal e As EventArgs)
            If WebWindow.CurrentRequestWindow IsNot Nothing Then
                RemoveHandler WebWindow.CurrentRequestWindow.PagePreRender, AddressOf CurrentRequestWindow_PagePreRender
            End If
            MyBase.OnUnload(e)
        End Sub
        Private Sub CurrentRequestWindow_PagePreRender(ByVal sender As Object, ByVal e As EventArgs)
            WebWindow.CurrentRequestWindow.RegisterStartupScript("OnLoadCore", String.Format("Init(""{0}"", ""VerticalCS"");OnLoadCore(""LPcell"", ""separatorCell"", ""separatorImage"", true, true);", BaseXafPage.CurrentTheme), True)
            UpdateTRPVisibility()
        End Sub
        Private Sub UpdateTRPVisibility()
            Dim isVisible As Boolean = False
            For Each control As Control In TRP.Controls
                If TypeOf control Is ActionContainerHolder Then
                    If CType(control, ActionContainerHolder).HasActiveActions() Then
                        isVisible = True
                        Exit For
                    End If
                End If
            Next control
            TRP.Visible = isVisible
        End Sub
        Public Overrides ReadOnly Property DefaultContainer() As IActionContainer
            Get
                If TB IsNot Nothing Then
                    Return TB.FindActionContainerById("View")
                End If
                Return Nothing
            End Get
        End Property
        Public Overrides Sub SetStatus(ByVal statusMessages As ICollection(Of String))
            InfoMessagesPanel.Text = String.Join("<br>", (New List(Of String)(statusMessages)).ToArray())
        End Sub
        Public Overrides ReadOnly Property ViewSiteControl() As Object
            Get
                Return VSC
            End Get
        End Property
    End Class
End Namespace
