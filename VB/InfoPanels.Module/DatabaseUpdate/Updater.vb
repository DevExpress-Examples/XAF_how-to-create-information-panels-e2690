Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.ExpressApp.Security

Namespace InfoPanels.Module.DatabaseUpdate
    Public Class Updater
        Inherits ModuleUpdater

        Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
            MyBase.New(objectSpace, currentDBVersion)
        End Sub
        Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
            MyBase.UpdateDatabaseAfterUpdateSchema()
            Dim personMary As Person = ObjectSpace.FindObject(Of Person)(CriteriaOperator.Parse("FirstName == 'Mary' && LastName == 'Tellitson'"))
            If personMary Is Nothing Then
                personMary = ObjectSpace.CreateObject(Of Person)()
                personMary.FirstName = "Mary"
                personMary.LastName = "Tellitson"
                personMary.Email = "tellitson@example.com"
                personMary.Birthday = New Date(1980, 11, 27)
            End If
            Dim personJohn As Person = ObjectSpace.FindObject(Of Person)(CriteriaOperator.Parse("FirstName == 'John' && LastName == 'Nilsen'"))
            If personJohn Is Nothing Then
                personJohn = ObjectSpace.CreateObject(Of Person)()
                personJohn.FirstName = "John"
                personJohn.LastName = "Nilsen"
                personJohn.Email = "NilsenJ@example.com"
                personJohn.Birthday = New Date(1981, 11, 27)
            End If
        End Sub
    End Class
End Namespace
