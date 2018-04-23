Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.BaseImpl

Namespace InfoPanels.Module
    Public Class Updater
        Inherits ModuleUpdater
        Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
            MyBase.New(objectSpace, currentDBVersion)
        End Sub
        Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
            MyBase.UpdateDatabaseAfterUpdateSchema()
            Dim mary As Person = ObjectSpace.FindObject(Of Person)(CriteriaOperator.Parse("FirstName == 'Mary' && LastName == 'Tellitson'"))
            If mary Is Nothing Then
                mary = ObjectSpace.CreateObject(Of Person)()
                mary.FirstName = "Mary"
                mary.LastName = "Tellitson"
                mary.Email = "mary_tellitson@md.com"
                mary.Birthday = New DateTime(1980, 11, 27)
                mary.Save()
            End If

            Dim john As Person = ObjectSpace.FindObject(Of Person)(CriteriaOperator.Parse("FirstName == 'John' && LastName == 'Nilsen'"))
            If john Is Nothing Then
                john = ObjectSpace.CreateObject(Of Person)()
                john.FirstName = "John"
                john.LastName = "Nilsen"
                john.Email = "john_nilsen@md.com"
                john.Birthday = New DateTime(1981, 10, 3)
                john.Save()
            End If
        End Sub
    End Class
End Namespace
