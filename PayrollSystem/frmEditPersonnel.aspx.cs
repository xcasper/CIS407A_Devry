using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmEditPersonnel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //If user does not have proper security level then sends them to login page
        if (Session["SecurityLevel"] != "A")
        {
            Server.Transfer("frmLogin.aspx", true);
        }
    }
}