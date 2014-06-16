using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmMain : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Sets the submit button, on the add new employee page, to visible(default)
        //if the user has administrator security level
        if (Session["SecurityLevel"] == "A")
        {
            linkbtnNewEmployee.Visible = true;
            imgbtnNewEmployee.Visible = true;
            linkbtnViewUserActivity.Visible = true;
            imgbtnViewUserActivity.Visible = true;
            linkbtnEditEmployees.Visible = true;
            imgbtnEditEmployees.Visible = true;
            linkbtnManageUsers.Visible = true;
            imgbtnManageUsers.Visible = true;
        }

        //Disables, by making invisible, and unclickable,
        //the submit button if the user does not have
        //administrator security privaleges.
        else
        {
            linkbtnNewEmployee.Visible = false;
            imgbtnNewEmployee.Visible = false;
            linkbtnViewUserActivity.Visible = false;
            imgbtnViewUserActivity.Visible = false;
            linkbtnEditEmployees.Visible = false;
            imgbtnEditEmployees.Visible = false;
            linkbtnManageUsers.Visible = false;
            imgbtnManageUsers.Visible = false;

        }

        //Make call to the class and save the user activity to the db
        clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.mdb"), "frmPersonnel");
    }
}
