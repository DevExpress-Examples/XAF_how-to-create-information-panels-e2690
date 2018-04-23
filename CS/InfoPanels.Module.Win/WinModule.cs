using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

using DevExpress.ExpressApp;

namespace InfoPanels.Module.Win {
    [ToolboxItemFilter("Xaf.Platform.Win")]
    public sealed partial class InfoPanelsWindowsFormsModule : ModuleBase {
        public InfoPanelsWindowsFormsModule() {
            InitializeComponent();
        }
    }
}
