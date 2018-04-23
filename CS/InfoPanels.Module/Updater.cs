using System;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;

namespace InfoPanels.Module {
    public class Updater : ModuleUpdater {
        public Updater(ObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            Person mary = ObjectSpace.FindObject<Person>(CriteriaOperator.Parse("FirstName == 'Mary' && LastName == 'Tellitson'"));
            if(mary == null) {
                mary = ObjectSpace.CreateObject<Person>();
                mary.FirstName = "Mary";
                mary.LastName = "Tellitson";
                mary.Email = "mary_tellitson@md.com";
                mary.Birthday = new DateTime(1980, 11, 27);
                mary.Save();
            }

            Person john = ObjectSpace.FindObject<Person>(CriteriaOperator.Parse("FirstName == 'John' && LastName == 'Nilsen'"));
            if(john == null) {
                john = ObjectSpace.CreateObject<Person>();
                john.FirstName = "John";
                john.LastName = "Nilsen";
                john.Email = "john_nilsen@md.com";
                john.Birthday = new DateTime(1981, 10, 3);
                john.Save();
            }
        }
    }
}
