using System;
using System.Collections.Generic;
using System.Web.UI;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Web;
using DevExpress.ExpressApp.Web.Templates;
using DevExpress.ExpressApp.Web.Templates.ActionContainers;
using InfoPanels.Module.Web.Controllers;
using InfoPanels.Web;

public partial class Default : BaseXafPage, IInfoPanelTemplateWeb {
    public Control PlaceHolder {
        get {
            return TemplateContent is MyDefaultVerticalTemplateContent 
                ? ((MyDefaultVerticalTemplateContent)TemplateContent).PlaceHolder : null;
        }
    }
    protected override ContextActionsMenu CreateContextActionsMenu() {
        return new ContextActionsMenu(this, "Edit", "RecordEdit", "ObjectsCreation", "ListView", "Reports");
    }
    public override Control InnerContentPlaceHolder {
        get {
            return Content;
        }
    }
}
