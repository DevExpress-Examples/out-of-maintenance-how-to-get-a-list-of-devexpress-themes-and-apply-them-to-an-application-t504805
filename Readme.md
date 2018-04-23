# How to get a list of DevExpress themes and apply them to an application


<p>In the sample, a web UserControl is created, which allows you to do the following:<br> </p>
<p>1. Get all DevExpress themes' names.</p>
<p>2. Choose what control (ASPxComboBox, ASPxMenu) to use for showing theme names. Use the UserControl.ControlType property.</p>
<p>3. Choose a request method(GET,POST) to reload a page and apply a new theme. Use the UserControl.RequestMethod property. </p>
<p><br>The selected theme is written to a cookie. The cookie value is got and applied in the Application.PreRequestHandlerExecute event handler.</p>

<br/>


