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

public partial class frmSalaryCalculator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        double annualhours = Convert.ToDouble(txtAnnualHours.Text);
        double rate = Convert.ToDouble(txtRate.Text);
        double salary = annualhours * rate;
        lblSalary.Text = "$" + salary.ToString();
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
}
