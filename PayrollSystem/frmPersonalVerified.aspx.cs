using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class frmPersonnelVerified : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Grab all values from the frmPersonnel form and then display them in the text box.
        txtVerifiedInfo.Text = Request["txtFirstName"] +
            "\n" + Request["txtLastName"] +
            "\n" + Request["txtPayRate"] +
            "\n" + Request["txtStartDate"] +
            "\n" + Request["txtEndDate"];
    }
}
