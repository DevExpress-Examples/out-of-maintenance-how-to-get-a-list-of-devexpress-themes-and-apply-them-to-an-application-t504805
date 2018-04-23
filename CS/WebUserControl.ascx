<%@ Control Language="C#" AutoEventWireup="true" CodeFile="WebUserControl.ascx.cs" Inherits="WebUserControl" %>
<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<script type="text/javascript">
    function OnSelectedIndexChanged(s, e) {
        ASPxClientUtils.SetCookie('CurrentThemeCookieKey', s.GetValue());
        ProcessReqeust(s,e);
    }
    function OnItemClick(s, e) {
        ASPxClientUtils.SetCookie('CurrentThemeCookieKey', e.item.name); 
        ProcessReqeust(s,e);
    }

    function ProcessReqeust(s,e) {
        if (s.cp_RequestMethod == "GET") {
            window.location = window.location.href;
        }
        if (s.cp_RequestMethod == "POST") {
            e.processOnServer = true;
        }
    }

    function OnMenuInit(s, e) {
         s.SetSelectedItem(s.GetItemByName(ASPxClientUtils.GetCookie('CurrentThemeCookieKey')));
    }

    function OnComboInit(s, e) {
        s.SetSelectedItem(s.FindItemByValue(ASPxClientUtils.GetCookie('CurrentThemeCookieKey')));
    }
</script>
