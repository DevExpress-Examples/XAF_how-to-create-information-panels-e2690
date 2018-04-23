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

namespace InfoPanels.Module.Win {
    public partial class MainForm : MainFormTemplateBase, IDockManagerHolder, ISupportMdiContainer, ISupportClassicToRibbonTransform, IInfoPanelTemplateWin
    {
        public override void SetSettings(IModelTemplate modelTemplate) {
            base.SetSettings(modelTemplate);
            navigation.Model = LocalizationHelper.GetNavBarCustomizationNode();
            formStateModelSynchronizerComponent.Model = GetFormStateNode();
            modelSynchronizationManager.ModelSynchronizableComponents.Add(new NavigationModelSynchronizer(dockPanelNavigation, (IModelTemplateWin)modelTemplate));
        }
        protected virtual void InitializeImages() {
            barMdiChildrenListItem.Glyph = ImageLoader.Instance.GetImageInfo("Action_WindowList").Image;
            barMdiChildrenListItem.LargeGlyph = ImageLoader.Instance.GetLargeImageInfo("Action_WindowList").Image;
            barSubItemPanels.Glyph = ImageLoader.Instance.GetImageInfo("Action_Navigation").Image;
            barSubItemPanels.LargeGlyph = ImageLoader.Instance.GetLargeImageInfo("Action_Navigation").Image;
        }
        [Obsolete("Use the MainForm() constructor"), Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public MainForm(XafApplication application) : this() { }
        public MainForm() {
            InitializeComponent();
            InitializeImages();
            UpdateMdiModeDependentProperties();
        }
        public Bar ClassicStatusBar {
            get { return _statusBar; }
        }
        public DockPanel DockPanelNavigation {
            get { return dockPanelNavigation; }
        }
        public DockManager DockManager {
            get { return mainDockManager; }
        }
        protected override void UpdateMdiModeDependentProperties() {
            base.UpdateMdiModeDependentProperties();
            bool isMdi = UIMode == UIMode.Mdi;
            //viewSitePanel.Visible = !isMdi;
            splitContainerControl1.Visible = !isMdi;
            if(isMdi) {
                barSubItemWindow.Visibility = BarItemVisibility.Always;
                barMdiChildrenListItem.Visibility = BarItemVisibility.Always;
            }
            else {
                barSubItemWindow.Visibility = BarItemVisibility.Never;
                barMdiChildrenListItem.Visibility = BarItemVisibility.Never;
            }
        }

        #region IInfoPanelTemplateWin Members

        public DevExpress.XtraEditors.SplitContainerControl SplitContainer {
            get { return splitContainerControl1; }
        }

        #endregion
    }
}