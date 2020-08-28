<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register TagPrefix="uc" TagName="ThemeSelector" Src="~/WebUserControl.ascx" %>
<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.17.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>How to get a list of DevExpress themes and apply them to an application</title>
</head>
<body>
    <form id="form1" runat="server">
        <p>Choose a theme selector control</p>
        <dx:ASPxRadioButtonList ID="ASPxRadioButtonList1" runat="server" SelectedIndex="0">
            <Items>
                <dx:ListEditItem Text="ASPxComboBox" Value="ASPxComboBox" />
                <dx:ListEditItem Text="ASPxMenu" Value="ASPxMenu" />
            </Items>
        </dx:ASPxRadioButtonList>
        <p>Choose a request method</p>
        <dx:ASPxRadioButtonList ID="ASPxRadioButtonList2" runat="server" SelectedIndex="0">
            <Items>
                <dx:ListEditItem Text="POST" Value="POST" />
                <dx:ListEditItem Text="GET" Value="GET" />
            </Items>
        </dx:ASPxRadioButtonList>
        <dx:ASPxButton ID="ASPxButton1" runat="server" AutoPostBack="True" Text="Apply changes">
        </dx:ASPxButton>
        <div>
            <uc:ThemeSelector runat="server" ID="uc" />
        </div>
    </form>
</body>
</html>