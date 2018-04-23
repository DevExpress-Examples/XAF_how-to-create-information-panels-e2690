Imports System.Configuration

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Win
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl

Namespace InfoPanels.Win
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
#If EASYTEST Then
            DevExpress.ExpressApp.Win.EasyTest.EasyTestRemotingRegistration.Register()
#End If

            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            EditModelPermission.AlwaysGranted = System.Diagnostics.Debugger.IsAttached
            Dim winApplication As New InfoPanelsWindowsFormsApplication()
            AddHandler winApplication.CreateCustomTemplate, AddressOf winApplication_CreateCustomTemplate
            DevExpress.ExpressApp.Xpo.InMemoryDataStoreProvider.Register()
            winApplication.ConnectionString = DevExpress.ExpressApp.Xpo.InMemoryDataStoreProvider.ConnectionString
            Try
                winApplication.Setup()
                winApplication.Start()
            Catch e As Exception
                winApplication.HandleException(e)
            End Try
        End Sub
        Private Shared Sub winApplication_CreateCustomTemplate(ByVal sender As Object, ByVal e As CreateCustomTemplateEventArgs)
            If e.Context = TemplateContext.ApplicationWindow Then
                e.Template = New InfoPanels.Module.Win.MainForm()
            End If
            If e.Context = TemplateContext.View Then
                e.Template = New InfoPanels.Module.Win.DetailViewForm()
            End If
        End Sub
    End Class
End Namespace
