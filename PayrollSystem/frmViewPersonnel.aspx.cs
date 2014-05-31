using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmViewPersonnel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //Declare the DataSet
            dsPersonnel myDataSet = new dsPersonnel();
            
            string personnelSearch = Request["txtSearch"];

            //Fill the dataset with what is returned from the function
            myDataSet = clsDataLayer.dsGetPersonnel(Server.MapPath("PayrollSystem_DB.mdb"), personnelSearch);

            //Set the DataGrid to the DataSource based on the table
            grdViewPersonnel.DataSource = myDataSet.Tables["tblPersonnel"];

            //Bind the DataGrid
            grdViewPersonnel.DataBind();
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}