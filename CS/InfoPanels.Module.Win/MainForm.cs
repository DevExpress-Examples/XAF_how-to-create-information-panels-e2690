using System;
using System.ComponentModel;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Utils;
using DevExpress.ExpressApp.Win.SystemModule;
using DevExpress.ExpressApp.Win.Templates.ActionContainers;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.ExpressApp.Win.Templates;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Templates;
using InfoPanels.Module.Win.Controllers;

namespace InfoPanels.Module.Win {
    public partial class MainForm : MainFormTemplateBase, IDockManagerHolder, ISupportClassicToRibbonTransform, IInfoPanelTemplateWin {
        public override void SetSettings(IModelTemplate modelTemplate) {
            base.SetSettings(modelTemplate);
            navigation.Model = TemplatesHelper.GetNavBarCustomizationNode();
            formStateModelSynchronizerComponent.Model = GetFormStateNode();
            modelSynchronizationManager.ModelSynchronizableComponents.Add(navigation);
        }
        protected virtual void InitializeImages() {
            barMdiChildrenListItem.Glyph = ImageLoader.Instance.GetImageInfo("Action_WindowList").Image;
            barMdiChildrenListItem.LargeGlyph = ImageLoader.Instance.GetLargeImageInfo("Action_WindowList").Image;
            barSubItemPanels.Glyph = ImageLoader.Instance.GetImageInfo("Action_Navigation").Image;
            barSubItemPanels.LargeGlyph = ImageLoader.Instance.GetLargeImageInfo("Action_Navigation").Image;
        }
        [Obsolete("Use the MainForm() constructor"), Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public MainForm(XafApplication application)
            : this() {
        }
        public MainForm() {
            InitializeComponent();
            InitializeImages();
            UpdateMdiModeDependentProperties();
            documentManager.BarAndDockingController = mainBarAndDockingController;
            documentManager.MenuManager = mainBarManager;
            if (TemplateCreated != null) {
                TemplateCreated(this, EventArgs.Empty);
            }
        }
        public Bar ClassicStatusBar {
            get {
                return _statusBar;
            }
        }
        public DockPanel DockPanelNavigation {
            get {
                return dockPanelNavigation;
            }
        }
        public DockManager DockManager {
            get {
                return mainDockManager;
            }
        }
        protected override void UpdateMdiModeDependentProperties() {
            base.UpdateMdiModeDependentProperties();
            bool isMdi = UIType == UIType.StandardMDI || UIType == UIType.TabbedMDI;
            //viewSitePanel.Visible = !isMdi;
            splitContainerControl1.Visible = !isMdi;
            //Do not replace with ? operator (problems with convertion to VB)
            if (isMdi) {
                barSubItemWindow.Visibility = BarItemVisibility.Always;
                barMdiChildrenListItem.Visibility = BarItemVisibility.Always;
            }
            else {
                barSubItemWindow.Visibility = BarItemVisibility.Never;
                barMdiChildrenListItem.Visibility = BarItemVisibility.Never;
            }
        }
        private void mainBarManager_Disposed(object sender, System.EventArgs e) {
            if (this.mainBarManager != null) {
                this.mainBarManager.Disposed -= new System.EventHandler(mainBarManager_Disposed);
            }
            modelSynchronizationManager.ModelSynchronizableComponents.Remove(barManager);
            this.barManager = null;
            this.mainBarManager = null;
            this._mainMenuBar = null;
            this._statusBar = null;
            this.standardToolBar = null;
            this.barDockControlBottom = null;
            this.barDockControlLeft = null;
            this.barDockControlRight = null;
            this.barDockControlTop = null;
        }
        public static event EventHandler<EventArgs> TemplateCreated;

        private void MainForm_Load(object sender, EventArgs e) {

        }

        private void viewSitePanel_Paint(object sender, System.Windows.Forms.PaintEventArgs e) {

        }
        public DevExpress.XtraEditors.SplitContainerControl SplitContainer {
            get {
                return splitContainerControl1;
            }
        }
    }
}
