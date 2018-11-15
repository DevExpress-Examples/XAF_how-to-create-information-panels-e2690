<!-- default file list -->
*Files to look at*:

* [InfoPanelViewControllerWeb.cs](./CS/InfoPanels.Module.Web/InfoPanelViewControllerWeb.cs) (VB: [InfoPanelViewControllerWeb.vb](./VB/InfoPanels.Module.Web/InfoPanelViewControllerWeb.vb))
* [InfoPanelViewControllerWin.cs](./CS/InfoPanels.Module.Win/InfoPanelViewControllerWin.cs) (VB: [InfoPanelViewControllerWin.vb](./VB/InfoPanels.Module.Win/InfoPanelViewControllerWin.vb))
* [Default.aspx](./CS/InfoPanels.Web/Default.aspx) (VB: [Default.aspx.vb](./VB/InfoPanels.Web/Default.aspx.vb))
* [Default.aspx.cs](./CS/InfoPanels.Web/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/InfoPanels.Web/Default.aspx.vb))
<!-- default file list end -->
# How to: Create Information Panels


<p>In certain scenarios you may be required to create additional functional regions in a UI to display specific data. This task can be solved by including additional controls into XAF templates and implementing the code that will supply data to the controls. To help you with the task, XAF offers built-in <strong>CustomizeTemplateViewControllerBase</strong> <a href="https://documentation.devexpress.com/xaf/CustomDocument2621.aspx"><u>Controller</u></a> and complete design-time support for built-in templates. Combined, these features allow you to easily implement information panels that can display <a href="https://documentation.devexpress.com/xaf/CustomDocument2622.aspx"><u>Actions</u></a>, <a href="https://documentation.devexpress.com/xaf/CustomDocument2611.aspx"><u>Views</u></a> and any kind of data accessible from a View Controller. This topic describes the steps you need to perform to create a simple information panel. For general information on template customization, refer to the <a href="https://documentation.devexpress.com/xaf/CustomDocument2696.aspx"><u>Template Customization</u></a> help topic.</p><p><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-create-information-panels-e2690/11.1.4+/media/ace213d6-dd13-4759-8f45-215502e2983a.png"><br />
<strong>Include Required Templates into the Application</strong></p><p>First, you need to decide which Templates you will customize. Different Templates are used in different parts of an application. To see a complete list of built-in Templates along with their descriptions, refer to the <a href="https://documentation.devexpress.com/xaf/CustomDocument2609.aspx"><u>Templates</u></a> topic. In this example, Windows Forms <strong>MainForm</strong> and <strong>DetailViewForm</strong> Templates will be customized as well as the ASP.NET <strong>DefaultVertical</strong> Template.</p><br />
<p><strong>- Windows Forms Templates</strong></p><p>Built-in Windows Forms Templates are regular classes located in the <i>DevExpress.ExpressApp.Win</i> assembly. To customize them, you need to include corresponding source code files into your solution and handle the <a href="https://documentation.devexpress.com/xaf/DevExpressExpressAppXafApplication_CreateCustomTemplatetopic.aspx"><u>XafApplication.CreateCustomTemplate</u></a><u> </u>event. To learn how to do this, refer to the <a href="https://documentation.devexpress.com/xaf/CustomDocument2618.aspx"><u>How to: Customize a Windows Forms Template</u></a> help topic.</p><p><strong>- ASP.NET Templates</strong></p><p>Built-in ASP.NET Templates are pages whose content is taken from <a href="http://msdn.microsoft.com/en-us/library/system.web.ui.usercontrol(v=vs.90).aspx"><u>User Controls</u></a> located in the <i>DevExpress.ExpressApp.Web</i> assembly. To customize them, you need to include corresponding source code files into your solution and modify the appropriate setting exposed via the <a href="https://documentation.devexpress.com/xaf/DevExpressExpressAppWebWebApplication_Settingstopic.aspx"><u>WebApplication.Settings</u></a> property. To learn how to do this, refer to the <a href="https://documentation.devexpress.com/xaf/CustomDocument3460.aspx"><u>How to: Customize an ASP.NET Template</u></a> help topic.</p><p>After all the required Templates are included in your solution, you can begin adding panel controls to them.</p><p><strong><br />
Add Panel Controls to Windows Forms Templates</strong></p><p>To add a panel control to the <strong>MainForm </strong>or the <strong>DetailViewForm </strong>Template, right-click the Template in the <strong>Solution Explorer</strong> and choose "View Designer".</p><p><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-create-information-panels-e2690/11.1.4+/media/3a139028-7e2c-4ce2-9922-ea0fa2c27cef.png"><br />
Locate the <strong>viewSitePanel </strong>control and change its <strong>Dock </strong>property from <strong>Fill </strong>to <strong>None</strong>.<br />
<img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-create-information-panels-e2690/11.1.4+/media/1926b8c0-b588-484a-a635-f758d3477f9f.png"></p><p>To ensure that the Template can be correctly resized, set the <strong>SplitContainerControl</strong>’s <strong>Dock </strong>property to <strong>Fill </strong>and the <strong>FixedPanel </strong>property to <strong>Panel2</strong>.<br />
<img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-create-information-panels-e2690/11.1.4+/media/6b77e4c5-7218-43ab-8b63-e8d8a1a6ec5e.png"><br />
To be able to fill the information panel with data, the <strong>SplitContainerControl </strong>must be externally visible. For this purpose, define an interface via which the information panel will be accessed. This will decouple data-supplying Controllers from particular Template types. Instead they will rely on the interface.</p><p></p>

```cs
public interface IInfoPanelTemplateWin : IFrameTemplate {        
    DevExpress.XtraEditors.SplitContainerControl SplitContainer { get; }
}


```

<p>Then, implement the interface in the Templates.<br />
</p>

```cs
public partial class MainForm : MainFormTemplateBase, IDockManagerHolder, 
    ISupportClassicToRibbonTransform, IInfoPanelTemplateWin {
    //... 
    public DevExpress.XtraEditors.SplitContainerControl SplitContainer {
        get { return splitContainerControl1; }
    }
}

```

<p><strong>Add Panel Controls to ASP.NET Web Templates</strong></p><p>To add a panel control to the <strong>DefaultVertical </strong>Template, right-click the ASCX file that you have added as a replacement for the standard <strong>DefaultVertical </strong>content and choose "View Markup".</p><p><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-create-information-panels-e2690/11.1.4+/media/ad57e0bd-5e73-4e54-964d-339ee6dde7a1.png"></p><p>Add the following two cells to the <strong>MRC</strong> table.</p><p></p>

```aspx
<td id="RS" style="width: 6px; border-bottom-style: none; border-top-style: none"
class="dxsplVSeparator_<%= BaseXafPage.CurrentTheme %> 
dxsplPane_<%= BaseXafPage.CurrentTheme %>">
    <div id="RSB" class="dxsplVSeparatorButton_<%= BaseXafPage.CurrentTheme %>"
    onmouseover="OnMouseEnter('RSB')"
    onmouseout="OnMouseLeave('RSB')" onclick="OnClick('Right', 'RSI')">
        <div id="RSI" style="width: 6px;" 
        class="dxWeb_splVCollapseForwardButton_<%= BaseXafPage.CurrentTheme %>"/>
    </div>
</td>
<td id="Right" width="250px" style="vertical-align: top">
    <cc3:XafUpdatePanel ID="UPRight" runat="server" />
</td>

```

<p>The <strong>UPRight</strong> control in this markup will represent the information panel.</p><p>Open the code-behind file of your ASCX - right click the file and choose <strong>View Code</strong>.</p><p><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-create-information-panels-e2690/11.1.4+/media/91de9f4a-cb74-4d72-a841-25cb4077bf7f.png"><br />
Expose the protected <strong>UPRight </strong>control via the public property.<br />
</p>

```cs
public partial class MyDefaultVerticalTemplateContent : TemplateContent {
    public Control PlaceHolder {
        get { return UPRight; }
    }
    // ... 
}

```

<p>In the ASP.NET module project, define an interface via which the information panel will be accessed from controllers.<br />
</p>

```cs
public interface IInfoPanelTemplateWeb : IFrameTemplate {
    Control PlaceHolder { get; }
}

```

<p>Implement this interface in the <strong>Default </strong>template - edit the <i>Default.aspx.cs</i> file located in the ASP.NET application project.<br />
</p>

```cs
public partial class Default : BaseXafPage, IInfoPanelTemplateWeb {
    public Control PlaceHolder {
        get {
            return TemplateContent is MyDefaultVerticalTemplateContent 
                ? ((MyDefaultVerticalTemplateContent)TemplateContent).PlaceHolder : null;
        }
    }
    // ... 
}

```

<p>Now you need to implement Windows Forms and ASP.NET Web View Controllers that will supply panel controls with actual data. To simplify this task, XAF provides the <strong>CustomizeTemplateViewControllerBase<TemplateType></strong> Controller to inherit from. For convenience, the <strong>TemplateType </strong>generic parameter can be either a template type or an interface implemented by templates. <strong>CustomizeTemplateViewControllerBase </strong>already provides template access logic, so all that you should do is implement four protected abstract methods.</p><br />
<p>- <strong>AddControlsToTemplateCore(TemplateType template) - c</strong>alled when a Controller is activated. This method must instantiate required controls and add them to an information panel.</p><p><strong>- RemoveControlsFromTemplateCore(TemplateType template) - c</strong>alled when a Controller is deactivated. This method must remove previously added controls from the information panel.</p><p><strong>- UpdateControls(View view) - </strong>called when the current View is changed. This method must update information panel controls with View-specific information, if required.</p><p><strong>- UpdateControls(object currentObject) - </strong>called when a currently displayed object is changed. This method must update information panel controls with data specific to the currently displayed object, if required.</p><p>The implementations of WinForms and ASP.NET controllers are demonstrated in the <i>InfoPanelViewControllerWin.cs</i> and <i>InfoPanelViewControllerWeb.cs</i> files of this example.</p><p><strong><i>Note: </i></strong><i>Alternatively, you can access the XAF template and customize it to implement a standard ASP.NET technique for your task (for example, </i><a href="http://msdn.microsoft.com/en-us/library/ms972953.aspx"><i><u>Serving Dynamic Content with HTTP Handlers</u></i></a><i>)</i><i>.</i><i><br />
</i></p>

<br/>


