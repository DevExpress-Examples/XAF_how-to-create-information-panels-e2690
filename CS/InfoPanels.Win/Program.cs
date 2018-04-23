using System;
using System.Configuration;
using System.Windows.Forms;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Win;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;

namespace InfoPanels.Win {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
#if EASYTEST
			DevExpress.ExpressApp.Win.EasyTest.EasyTestRemotingRegistration.Register();
#endif

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            EditModelPermission.AlwaysGranted = System.Diagnostics.Debugger.IsAttached;
            InfoPanelsWindowsFormsApplication winApplication = new InfoPanelsWindowsFormsApplication();
            winApplication.CreateCustomTemplate += winApplication_CreateCustomTemplate;
            DevExpress.ExpressApp.Xpo.InMemoryDataStoreProvider.Register();
            winApplication.ConnectionString = DevExpress.ExpressApp.Xpo.InMemoryDataStoreProvider.ConnectionString;
            try {
                winApplication.Setup();
                winApplication.Start();
            }
            catch (Exception e) {
                winApplication.HandleException(e);
            }
        }
        static void winApplication_CreateCustomTemplate(object sender, CreateCustomTemplateEventArgs e) {
            if (e.Context == TemplateContext.ApplicationWindow)
                e.Template = new InfoPanels.Module.Win.MainForm();
            if (e.Context == TemplateContext.View)
                e.Template = new InfoPanels.Module.Win.DetailViewForm();
        }
    }
}
