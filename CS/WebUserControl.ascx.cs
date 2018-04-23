using DevExpress.Web;
using DevExpress.Web.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public enum CustomControlType { ASPxComboBox, ASPxMenu }
public enum RequestMethod { GET, POST }
public partial class WebUserControl : System.Web.UI.UserControl {

    protected override void OnInit(EventArgs e) {
        base.OnInit(e);
        this.PopulateItems();
    }

    protected override void CreateChildControls() {
        base.CreateChildControls();
        this.PopulateControl();
    }

    Control control;
    public void PopulateControl() {
        if(control != null) this.Controls.Remove(control);
        if(ControlType == CustomControlType.ASPxComboBox) {
            control = this.CreateASPxComboBox();

        } else {
            control = this.CreateASPxMenu();
        }
    }

    private void Pass_CustomJSProperties(object sender, CustomJSPropertiesEventArgs e) {
        e.Properties["cp_RequestMethod"] = RequestMethod;
    }

    public ASPxMenu CreateASPxMenu() {
        ASPxMenu menu = new ASPxMenu();
        menu.ID = "menu";
        menu.AllowSelectItem = true;
        menu.CustomJSProperties += Pass_CustomJSProperties;
        this.Controls.Add(menu);
        menu.EnableClientSideAPI = true;
        menu.ClientSideEvents.SetEventHandler("ItemClick", "OnItemClick");
        menu.ClientSideEvents.SetEventHandler("Init", "OnMenuInit");
        DevExpress.Web.MenuItem item = menu.Items.Add("Select a theme");        
        for(int i = 0; i < Items.Count; i++) {
            item.Items.Add(Items[i].ToString(), Items[i].ToString());
        }
        return menu;
    }

    public ASPxComboBox CreateASPxComboBox() {
        ASPxComboBox combo = new ASPxComboBox();
        combo.ID = "combo";
        combo.CustomJSProperties += Pass_CustomJSProperties;
        this.Controls.Add(combo);
        for(int i = 0; i < Items.Count; i++) {
            combo.Items.Add(Items[i]);
        }
        combo.EnableClientSideAPI = true;
        combo.ClientSideEvents.SetEventHandler("SelectedIndexChanged", "OnSelectedIndexChanged");
        combo.ClientSideEvents.SetEventHandler("Init", "OnComboInit");
        return combo;

    }

    [System.ComponentModel.DefaultValue(RequestMethod.POST)]
    public RequestMethod RequestMethod { get; set; }

    [System.ComponentModel.DefaultValue(CustomControlType.ASPxComboBox)]
    public CustomControlType ControlType { get; set; }

    protected List<string> Items;
    public void PopulateItems() {
        Items = ThemesProvider.GetThemes();
    }

}