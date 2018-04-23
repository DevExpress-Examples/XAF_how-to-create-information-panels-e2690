using System;
using System.ComponentModel;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Win.Templates.ActionContainers;
using DevExpress.XtraBars;
using DevExpress.ExpressApp;
using InfoPanels.Module.Win.Controllers;

namespace InfoPanels.Module.Win {
    public partial class DetailViewForm : DevExpress.ExpressApp.Win.Templates.XtraFormTemplateBase, ISupportClassicToRibbonTransform, IInfoPanelTemplateWin {
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            CheckTransformToRibbon(false);
        }
        protected override IModelFormState GetFormStateNode() {
            if (View != null) {
                return TemplatesHelper.GetFormStateNode(View.Id);
            }
            else {
                return base.GetFormStateNode();
            }
        }
        public override void SetSettings(IModelTemplate modelTemplate) {
            base.SetSettings(modelTemplate);
            formStateModelSynchronizerComponent.Model = GetFormStateNode();
        }
        [Obsolete("Use the DetailViewForm() constructor"), Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public DetailViewForm(XafApplication application)
            : this() {
        }
        public DetailViewForm() {
            InitializeComponent();
        }
        public Bar MainMenuBar {
            get {
                return _mainMenuBar;
            }
        }
        public Bar ToolBar {
            get {
                return standardToolBar;
            }
        }
        public Bar ClassicStatusBar {
            get {
                return _statusBar;
            }
        }
        public DevExpress.XtraEditors.SplitContainerControl SplitContainer {
            get {
                return splitContainerControl1;
            }
        }
    }
}
