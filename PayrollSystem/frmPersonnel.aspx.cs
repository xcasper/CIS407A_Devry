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

        //Check to see which boxes are null or empty(spaces)
        if (string.IsNullOrEmpty(txtFirstName.Text) || txtFirstName.Text.Trim().Length == 0)
        {
            txtFirstName.BackColor = System.Drawing.Color.Yellow;
            lblError.Text += "First Name May Not Be Empty.";
        }

        if (string.IsNullOrEmpty(txtLastName.Text) || txtLastName.Text.Trim().Length == 0)
        {
            txtLastName.BackColor = System.Drawing.Color.Yellow;
            lblError.Text += "Last Name May Not Be Empty.";
        }

        if (string.IsNullOrEmpty(txtPayRate.Text) || txtPayRate.Text.Trim().Length == 0)
        {
            txtPayRate.BackColor = System.Drawing.Color.Yellow;
            lblError.Text += "Pay Rate May Not Be Empty.";
        }

        if (string.IsNullOrEmpty(txtStartDate.Text) || txtStartDate.Text.Trim().Length == 0)
        {
            txtStartDate.BackColor = System.Drawing.Color.Yellow;
            lblError.Text += "Start Date May Not Be Empty.";
        }

        if (string.IsNullOrEmpty(txtEndDate.Text) || txtEndDate.Text.Trim().Length == 0)
        {
            txtEndDate.BackColor = System.Drawing.Color.Yellow;
            lblError.Text += "End Date May Not Be Empty.";
        }

        //Attempt to assign entered date to DateTime variable and then compare it to make sure the end date comes on the same day, or after, the start date.
        try
        {
            DateTime startDate = DateTime.Parse(txtStartDate.Text);
            DateTime endDate = DateTime.Parse(txtEndDate.Text);

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
