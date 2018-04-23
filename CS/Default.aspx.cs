using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page {

    protected override void OnInit(EventArgs e) {
        base.OnInit(e);

    }


    protected void Page_Load(object sender, EventArgs e) {
        uc.RequestMethod = ASPxRadioButtonList2.Value.ToString() == "GET" ? RequestMethod.GET : RequestMethod.POST;
        uc.ControlType = ASPxRadioButtonList1.Value.ToString() == "ASPxComboBox" ? CustomControlType.ASPxComboBox : CustomControlType.ASPxMenu;
        uc.PopulateControl();
    }

}