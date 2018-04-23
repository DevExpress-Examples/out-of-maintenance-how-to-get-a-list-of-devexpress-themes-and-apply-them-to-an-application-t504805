Imports DevExpress.Web
Imports DevExpress.Web.Internal
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Public Enum CustomControlType
    ASPxComboBox
    ASPxMenu
End Enum
Public Enum RequestMethod
    [GET]
    POST
End Enum
Partial Public Class WebUserControl
    Inherits System.Web.UI.UserControl

    Protected Overrides Sub OnInit(ByVal e As EventArgs)
        MyBase.OnInit(e)
        Me.PopulateItems()
    End Sub

    Protected Overrides Sub CreateChildControls()
        MyBase.CreateChildControls()
        Me.PopulateControl()
    End Sub

    Private control As Control
    Public Sub PopulateControl()
        If control IsNot Nothing Then
            Me.Controls.Remove(control)
        End If
        If ControlType = CustomControlType.ASPxComboBox Then
            control = Me.CreateASPxComboBox()

        Else
            control = Me.CreateASPxMenu()
        End If
    End Sub

    Private Sub Pass_CustomJSProperties(ByVal sender As Object, ByVal e As CustomJSPropertiesEventArgs)
        e.Properties("cp_RequestMethod") = RequestMethod
    End Sub

    Public Function CreateASPxMenu() As ASPxMenu
        Dim menu As New ASPxMenu()
        menu.ID = "menu"
        menu.AllowSelectItem = True
        AddHandler menu.CustomJSProperties, AddressOf Pass_CustomJSProperties
        Me.Controls.Add(menu)
        menu.EnableClientSideAPI = True
        menu.ClientSideEvents.SetEventHandler("ItemClick", "OnItemClick")
        menu.ClientSideEvents.SetEventHandler("Init", "OnMenuInit")
        Dim item As DevExpress.Web.MenuItem = menu.Items.Add("Select a theme")
        For i As Integer = 0 To Items.Count - 1
            item.Items.Add(Items(i).ToString(), Items(i).ToString())
        Next i
        Return menu
    End Function

    Public Function CreateASPxComboBox() As ASPxComboBox
        Dim combo As New ASPxComboBox()
        combo.ID = "combo"
        AddHandler combo.CustomJSProperties, AddressOf Pass_CustomJSProperties
        Me.Controls.Add(combo)
        For i As Integer = 0 To Items.Count - 1
            combo.Items.Add(Items(i))
        Next i
        combo.EnableClientSideAPI = True
        combo.ClientSideEvents.SetEventHandler("SelectedIndexChanged", "OnSelectedIndexChanged")
        combo.ClientSideEvents.SetEventHandler("Init", "OnComboInit")
        Return combo

    End Function

    <System.ComponentModel.DefaultValue(RequestMethod.POST)> _
    Public Property RequestMethod() As RequestMethod

    <System.ComponentModel.DefaultValue(CustomControlType.ASPxComboBox)> _
    Public Property ControlType() As CustomControlType

    Protected Items As List(Of String)
    Public Sub PopulateItems()
        Items = ThemesProvider.GetThemes()
    End Sub

End Class