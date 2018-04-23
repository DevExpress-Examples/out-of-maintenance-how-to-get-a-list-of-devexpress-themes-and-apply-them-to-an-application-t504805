Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Overrides Sub OnInit(ByVal e As EventArgs)
        MyBase.OnInit(e)

    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        uc.RequestMethod = If(ASPxRadioButtonList2.Value.ToString() = "GET", RequestMethod.GET, RequestMethod.POST)
        uc.ControlType = If(ASPxRadioButtonList1.Value.ToString() = "ASPxComboBox", CustomControlType.ASPxComboBox, CustomControlType.ASPxMenu)
        uc.PopulateControl()
    End Sub

End Class