using System;
using System.Collections.Generic;
using System.Web.UI;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Web;
using DevExpress.ExpressApp.Web.Templates;
using DevExpress.ExpressApp.Web.Templates.ActionContainers;

public partial class Default : BaseXafPage, InfoPanels.Module.Web.IInfoPanelTemplateWeb {
    private void Splitter_PreRender(object sender, EventArgs e) {
        Splitter.PreRender -= new EventHandler(Splitter_PreRender);
        Splitter.Panes["Left"].Visible = VerticalToolsActionContainer.HasActiveActions() || DiagnosticActionContainer.HasActiveActions();
    }
	protected void Page_Load(object sender, EventArgs e) {
        Splitter.PreRender += new EventHandler(Splitter_PreRender);
        WebApplication.Instance.CreateControls(this);
    }    
    protected override ContextActionsMenu CreateContextActionsMenu() {
        return new ContextActionsMenu(this, "Edit", "RecordEdit", "ObjectsCreation", "ListView", "Reports");
    }
	protected override IActionContainer GetDefaultContainer() {
        return ToolBar.FindActionContainerById("View");
	}
	public override void SetStatus(System.Collections.Generic.ICollection<string> statusMessages) {
		InfoMessagesPanel.Text = string.Join("<br>", new List<string>(statusMessages).ToArray());
	}

    #region IInfoPanelTemplateWeb Members

    public DevExpress.Web.ASPxSplitter.ASPxSplitter SplitContainer {
        get { return Splitter; }
    }

    #endregion
}
