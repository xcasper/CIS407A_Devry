using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmPersonnel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Sets text color for the error label to red
        //In page load so that the code is not rerun on each button click.
        lblError.ForeColor = System.Drawing.Color.Red;
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //Reset text to nothing on each new submit button click
        lblError.Text = "";

        //Reset all textbox background color to white on each click. This way if the error is fixed, it will be white instead of still yellow.
        txtFirstName.BackColor = System.Drawing.Color.White;
        txtLastName.BackColor = System.Drawing.Color.White;
        txtPayRate.BackColor = System.Drawing.Color.White;
        txtStartDate.BackColor = System.Drawing.Color.White;
        txtEndDate.BackColor = System.Drawing.Color.White;

        //Attempt to assign entered date to DateTime variable
        try
        {
            DateTime startDate = DateTime.Parse(txtStartDate.Text);
            DateTime endDate = DateTime.Parse(txtEndDate.Text);

            //compare it to make sure the end date comes on the same day, or after, the start date.
            if(DateTime.Compare(startDate, endDate) > 0)
            {
                lblError.Text += "Start Date Must Be Before End Date";
            }
        }
        catch(FormatException)
        {
            lblError.Text += "Invalid Date Format";
        }

        //If no error message exists, create sessions and transfer user to Personal Verified Form.
        if(string.IsNullOrEmpty(lblError.Text))
        {
            Session["txtFirstName"] = txtFirstName.Text;
            Session["txtLastName"] = txtLastName.Text;
            Session["txtPayRate"] = txtPayRate.Text;
            Session["txtStartDate"] = txtStartDate.Text;
            Session["txtEndDate"] = txtEndDate.Text;
            Server.Transfer("frmPersonalVerified.aspx", true);
        }
    }
}
