using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        
        //Declares new dsUser
        dsUser dsUserLogin;

        //Declare local variable to handle security levels
        string SecurityLevel;

        //Instantiates the dsUser with the value(s) returned from VerifyUser in clsDatalayer
        dsUserLogin = clsDataLayer.VerifyUser(Server.MapPath("PayrollSystem_DB.mdb"),
                         Login1.UserName, Login1.Password);

        //If no value was returned from VerifyUser then dont authenticate
        if (dsUserLogin.tblUserLogin.Count < 1)
        {
            e.Authenticated = false;
            return;
        }

        //Gets the users security level
        SecurityLevel = dsUserLogin.tblUserLogin[0].SecurityLevel.ToString();

        //Checks SecurityLevel for the user and then sets the session accordingly
        //if no security level then don't authenticate
        switch (SecurityLevel)
        {

            case "A":
                //Sets authenticated to true and sets the securitylevel session variable to A
                e.Authenticated = true;
                Session["SecurityLevel"] = "A";
                break;
            case "U":
                //Sets authenticated to true and sets the securitylevel session variable to U
                e.Authenticated = true;
                Session["SecurityLevel"] = "U";
                break;
            default:
                e.Authenticated = false;
                break;
        }
    }
}