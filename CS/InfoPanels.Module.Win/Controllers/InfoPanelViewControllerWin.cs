using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.XtraEditors;
using DevExpress.ExpressApp.Templates;

namespace InfoPanels.Module.Win.Controllers {
   public interface IInfoPanelTemplateWin : IFrameTemplate {
        SplitContainerControl SplitContainer {
            get;
        }
    }
    public class InfoPanelViewControllerWin : CustomizeTemplateViewControllerBase<IInfoPanelTemplateWin> {
        LabelControl label;
        protected override void AddControlsToTemplateCore(IInfoPanelTemplateWin template) {
            if (label == null) {
                label = new LabelControl();
            }
            template.SplitContainer.Panel2.Controls.Add(label);
        }
        protected override void RemoveControlsFromTemplateCore(IInfoPanelTemplateWin template) {
            template.SplitContainer.Panel2.Controls.Remove(label);
            label = null;
        }
        protected override void UpdateControls(View view) {
            UpdateControls();
        }
        protected override void UpdateControls(object currentObject) {
            UpdateControls();
        }
        void UpdateControls() {
            label.Text = "The current View is " + View.Caption;
            if (View.CurrentObject != null) {
                label.Text += System.Environment.NewLine +
                    "The current object is " + View.CurrentObject.ToString();
            }
        }
    }
}
