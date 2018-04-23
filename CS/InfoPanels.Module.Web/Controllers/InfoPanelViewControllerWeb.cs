using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.SystemModule;
using System.Web.UI;
using DevExpress.ExpressApp.Templates;

namespace InfoPanels.Module.Web.Controllers {
    public interface IInfoPanelTemplateWeb : IFrameTemplate {
        Control PlaceHolder {
            get;
        }
    }
    public class InfoPanelViewControllerWeb : CustomizeTemplateViewControllerBase<IInfoPanelTemplateWeb> {
        LiteralControl literal;
        protected override void AddControlsToTemplateCore(IInfoPanelTemplateWeb template) {
            if (literal == null) literal = new LiteralControl();
            if (template.PlaceHolder != null) {
                template.PlaceHolder.Controls.Add(literal);
            }
        }
        protected override void RemoveControlsFromTemplateCore(IInfoPanelTemplateWeb template) {
            if (template.PlaceHolder != null) {
                template.PlaceHolder.Controls.Remove(literal);
                literal = null;
            }
        }
        protected override void UpdateControls(View view) {
            UpdateControls();
        }
        protected override void UpdateControls(object currentObject) {
            UpdateControls();
        }
        void UpdateControls() {
            literal.Text = "The current View is " + View.Caption;
            if (View.CurrentObject != null) {
                literal.Text += "<br/>The current object is " + View.CurrentObject;
            }
        }
    }
}
