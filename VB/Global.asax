<%@ Application Language="vb" %>

<script runat="server">
    Protected Sub Application_PreRequestHandlerExecute(ByVal sender As Object, ByVal e As EventArgs)
        If Request.Cookies("CurrentThemeCookieKey") IsNot Nothing Then
            DevExpress.Web.ASPxWebControl.GlobalTheme = Request.Cookies("CurrentThemeCookieKey").Value
        End If
    End Sub

</script>