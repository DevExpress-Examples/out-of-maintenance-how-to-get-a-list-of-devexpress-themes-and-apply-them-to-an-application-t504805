<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
* [Global.asax](./CS/Global.asax) (VB: [Global.asax](./VB/Global.asax))
* [WebUserControl.ascx](./CS/WebUserControl.ascx) (VB: [WebUserControl.ascx](./VB/WebUserControl.ascx))
* [WebUserControl.ascx.cs](./CS/WebUserControl.ascx.cs) (VB: [WebUserControl.ascx.vb](./VB/WebUserControl.ascx.vb))
<!-- default file list end -->
# How to get a list of DevExpress themes and apply them to an application
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t504805/)**
<!-- run online end -->


<p>In the sample, a web UserControl is created, which allows you to do the following:<br> </p>
<p>1. Get all DevExpress themes' names.</p>
<p>2. Choose what control (ASPxComboBox, ASPxMenu) to use for showing theme names. Use the UserControl.ControlType property.</p>
<p>3. Choose a request method(GET,POST) to reload a page and apply a new theme. Use the UserControl.RequestMethod property. </p>
<p><br>The selected theme is written to a cookie. The cookie value is got and applied in the Application.PreRequestHandlerExecute event handler.</p>

<br/>


