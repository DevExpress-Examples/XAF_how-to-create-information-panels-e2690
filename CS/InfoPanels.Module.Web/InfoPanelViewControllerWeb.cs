using System.Web.UI;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;

namespace InfoPanels.Module.Web {
    public interface IInfoPanelTemplateWeb : IFrameTemplate {
        DevExpress.Web.ASPxSplitter.ASPxSplitter SplitContainer { get; }
    }
    public class InfoPanelViewControllerWeb : CustomizeTemplateViewControllerBase<IInfoPanelTemplateWeb> {
        LiteralControl literal;        
        protected override void AddControlsToTemplateCore(IInfoPanelTemplateWeb template) {
            if(literal == null) {
                literal = new LiteralControl();                                
            }
            template.SplitContainer.GetPaneByName("Right").Controls.Add(literal);
        }
        protected override void RemoveControlsFromTemplateCore(IInfoPanelTemplateWeb template) {
            template.SplitContainer.GetPaneByName("Right").Controls.Remove(literal);
            literal = null;
        }
        protected override void UpdateControls(View view) {
            UpdateControls();
        }
        protected override void UpdateControls(object currentObject) {
            UpdateControls();
        }
        void UpdateControls() {
            literal.Text = "The current View is " + View.Caption;
            if(View.CurrentObject != null) {
                literal.Text += "<br/>The current object is " + View.CurrentObject.ToString();
            }
        }
    }
}
