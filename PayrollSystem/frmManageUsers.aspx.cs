using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmManageUsers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //If user does not have proper security level then sends them to login page
        if (Session["SecurityLevel"] != "A")
        {
            Server.Transfer("frmLogin.aspx", true);
        }

    }
    protected void btnAddUser_Click(object sender, EventArgs e)
    {
        //Reset text to nothing on each new submit button click
        lblResult.Text = "";

        //create sessions
        Session["txtUserName"] = txtUserName.Text;
        Session["txtPassword"] = txtPassword.Text;
        Session["ddlSecurityLevel"] = ddlSecurityLevel.Text;

        //Saves the User Login data to the database
        if (clsDataLayer.SaveUserLogin(Server.MapPath("PayrollSystem_DB.mdb"),
            Session["txtUserName"].ToString(),
            Session["txtPassword"].ToString(),
            Session["ddlSecurityLevel"].ToString()))
        {
            //sets label text for success
            lblResult.Text = "The User Was Sucessfully Created";

        }
        else
        {   
            //sets label text for failure
            lblResult.Text = "The User Was NOT Created";
        }

        //refreshes the grid view so it shows the newly added user
        grdManageUsers.DataBind();

    }
}