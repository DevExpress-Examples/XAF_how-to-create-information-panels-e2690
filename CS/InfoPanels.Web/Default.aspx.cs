using System;
using System.Collections.Generic;
using System.Web.UI;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Web;
using DevExpress.ExpressApp.Web.Templates;
using DevExpress.ExpressApp.Web.Templates.ActionContainers;
using InfoPanels.Module.Web;

public partial class Default : BaseXafPage, IInfoPanelTemplateWeb {
    protected void Page_Load(object sender, EventArgs e) {
        ViewSiteControl = VSC;
        WebApplication.Instance.CreateControls(this);
    }
    protected override ContextActionsMenu CreateContextActionsMenu() {
        return new ContextActionsMenu(this, "Edit", "RecordEdit", "ObjectsCreation", "ListView", "Reports");
    }
    protected override IActionContainer GetDefaultContainer() {
        return TB.FindActionContainerById("View");
    }
    public override void SetStatus(System.Collections.Generic.ICollection<string> statusMessages) {
        InfoMessagesPanel.Text = string.Join("<br>", new List<string>(statusMessages).ToArray());
    }
    public Control PlaceHolder {
        get {
            return UPRight;
        }
    }
}
