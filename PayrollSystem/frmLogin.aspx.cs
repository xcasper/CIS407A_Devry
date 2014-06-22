using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
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

            // Attempts to Send a message to notify of inncorrect login
            // If no problem occurs with sending the message
            // then this login failure message displays
            if (clsBusinessLayer.SendEmail("cgleckman@gmail.com",
            "aliedbaby@yahoo.com", "", "", "Login Incorrect",
            "The login failed for UserName: " + Login1.UserName +
            " Password: " + Login1.Password))
            {
                Login1.FailureText = Login1.FailureText + " Your incorrect login information was sent to receiver@receiverdomain.com";
            }
            else
            {
                Login1.FailureText = Login1.FailureText + " Your incorrect login information was sent to receiver@receiverdomain.com";
            }

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
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                Session["SecurityLevel"] = "A";
                break;
            case "U":
                //Sets authenticated to true and sets the securitylevel session variable to U
                e.Authenticated = true;
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                Session["SecurityLevel"] = "U";
                break;
            default:
                e.Authenticated = false;
                break;
        }
    }
}