using System;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Security;

namespace InfoPanels.Module.DatabaseUpdate {
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) {
        }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            Person personMary = ObjectSpace.FindObject<Person>(
            CriteriaOperator.Parse("FirstName == 'Mary' && LastName == 'Tellitson'"));
            if (personMary == null) {
                personMary = ObjectSpace.CreateObject<Person>();
                personMary.FirstName = "Mary";
                personMary.LastName = "Tellitson";
                personMary.Email = "tellitson@example.com";
                personMary.Birthday = new DateTime(1980, 11, 27);
            }
            Person personJohn = ObjectSpace.FindObject<Person>(
CriteriaOperator.Parse("FirstName == 'John' && LastName == 'Nilsen'"));
            if (personJohn == null) {
                personJohn = ObjectSpace.CreateObject<Person>();
                personJohn.FirstName = "John";
                personJohn.LastName = "Nilsen";
                personJohn.Email = "NilsenJ@example.com";
                personJohn.Birthday = new DateTime(1981, 11, 27);
            }
        }
    }
}
