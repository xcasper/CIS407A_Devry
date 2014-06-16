using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//Allows the user of the specific functions of System
using System.Data.OleDb;
using System.Net;
using System.Data;

/// <summary>
/// Gets and saves User Activity and IP Address
/// </summary>
public class clsDataLayer
{
    // This function saves the personnel data
    public static bool SaveUserLogin(string Database, string username, string password, string securityLevel)
    {

        bool recordSaved;

        //Declares new OleDbTransaction for updating database and instantiates it as null
        OleDbTransaction myTransaction = null;

        try
        {
            //Declares and instantiates a new OleDBConnection
            OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
                                                       "Data Source=" + Database);
            conn.Open();
            OleDbCommand command = conn.CreateCommand();
            string strSQL;

            //Sets myTransaction to a new transaction using the db connection
            myTransaction = conn.BeginTransaction();
            command.Transaction = myTransaction;

            //Instantiates strSQL with the database insert string, for use later
            strSQL = strSQL = "Insert into tblUserLogin " +
                     "(UserName, UserPassword, SecurityLevel) values ('" +
                     username + "', '" + password + "', '" + securityLevel + "')";

            //Determines how the command text is interpreted and assigns the insert string to it
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;

            //executes a sql statement against the connect and returns # of rows affected
            command.ExecuteNonQuery();

            //Commits all the changes from the transaction to the database to make it show on the live database.
            myTransaction.Commit();

            //Close the connection
            conn.Close();

            recordSaved = true;
        }
        catch (Exception ex)
        {
            //Takes the database back to the previous state if an error occurs
            myTransaction.Rollback();

            recordSaved = false;

        }

        return recordSaved;
    }
    // This function verifies a user in the tblUser table
    public static dsUser VerifyUser(string Database, string UserName, string UserPassword)
    {
        //Declare local variables
        dsUser DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;

        //Instantiates the connection to the database
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
                                      "Data Source=" + Database);

        //Instantiates a new data adapter and checks db username and password for verification
        sqlDA = new OleDbDataAdapter("Select SecurityLevel from tblUserLogin " +
                                      "where UserName like '" + UserName + "' " +
                                      "and UserPassword like '" + UserPassword + "'", sqlConn);

        //Instantiates a new dsUser for returning the value, if any,
        //from querying the database to check the username and password
        //of the user
        DS = new dsUser();

        //Adds rows to the database and refreshes rows already in database
        sqlDA.Fill(DS.tblUserLogin);

        //returns the user
        return DS;

    }

    // This function saves the personnel data
    public static bool SavePersonnel(string Database, string FirstName, string LastName,
                                     string PayRate, string StartDate, string EndDate)
    {

        bool recordSaved;

        //Declares new OleDbTransaction for updating database and instantiates it as null
        OleDbTransaction myTransaction = null;

        try
        {
            //Declares and instantiates a new OleDBConnection
            OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
                                                       "Data Source=" + Database);
            conn.Open();
            OleDbCommand command = conn.CreateCommand();
            string strSQL;

            //Sets myTransaction to a new transaction using the db connection
            myTransaction = conn.BeginTransaction();
            command.Transaction = myTransaction;

            //Instantiates strSQL with the database insert string, for use later
            strSQL = strSQL = "Insert into tblPersonnel " +
                     "(FirstName, LastName) values ('" +
                     FirstName + "', '" + LastName + "')";

            //Determines how the command text is interpreted and assigns the insert string to it
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;

            //executes a sql statement against the connect and returns # of rows affected
            command.ExecuteNonQuery();

            //Sets strSQL to database update string, for use later
            strSQL = "Update tblPersonnel " +
                     "Set PayRate=" + PayRate + ", " +
                     "StartDate='" + StartDate + "', " +
                     "EndDate='" + EndDate + "' " +
                     "Where ID=(Select Max(ID) From tblPersonnel)";

            //Determines how the command text is interpreted and assigns the update string to it
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;

            //executes a sql statement against the connect and returns # of rows affected
            command.ExecuteNonQuery();

            //Commits all the changes from the transaction to the database to make it show on the live database.
            myTransaction.Commit();

            //Close the connection
            conn.Close();
            recordSaved = true;
        }
        catch (Exception ex)
        {
            //Takes the database back to the previous state if an error occurs
            myTransaction.Rollback();

            recordSaved = false;

        }

        return recordSaved;
    }

    //This function gets all User Activity from the tblPersonnel
    public static dsPersonnel dsGetPersonnel(string Database, string strSearch)
    {
        dsPersonnel DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;

        //Creates the connection to the database
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
            "Data Source=" + Database);

        //Checks if strSearch is empty or not. If not it runs the adapter with a where statement
        if(strSearch == null || strSearch.Trim().Length == 0)
        {
            //Instantiates new data adapter
            sqlDA = new OleDbDataAdapter("select * from tblPersonnel", sqlConn);
        }
        else
        {
            //Instantiates new data adapter 
            sqlDA = new OleDbDataAdapter("select * from tblPersonnel where LastName = '" + strSearch + "'", sqlConn);
        }
        
        //Instantiates new dsUserActivity
        DS = new dsPersonnel();

        //Adds rows to te database and refreshes rows already in database
        sqlDA.Fill(DS.tblPersonnel);

        
        return DS;
    }
    // This function gets the user activity from the tblUserActivity
    public static dsUserActivity GetUserActivity(string Database)
    {
        //Declare local variables 
        dsUserActivity DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;

        //Creates the connect to the database
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
            "Data Source=" + Database);

        //Instantiates new data adapter
        sqlDA = new OleDbDataAdapter("select * from tblUserActivity", sqlConn);

        //Instantiates new dsUserActivity object
        DS = new dsUserActivity();

        //Adds rows to database and refreshes rows already in database
        sqlDA.Fill(DS.tblUserActivity);

        //returns the user's activity dataset
        return DS;
    }

    // This function saves the user activity
    public static void SaveUserActivity(string Database, string FormAccessed)
    {
        //Declares and instantiates a new OleDBConnection
        OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
            "Data Source=" + Database);
        conn.Open();
        OleDbCommand command = conn.CreateCommand();
        string strSQL;

        strSQL = "Insert into tblUserActivity (UserIP, FormAccessed) values ('" +
            GetIP4Address() + "', '" + FormAccessed + "')";

        command.CommandType = CommandType.Text;
        command.CommandText = strSQL;
        command.ExecuteNonQuery();
        conn.Close();
    }

    // This function gets the IP Address
    public static string GetIP4Address()
    {
        string IP4Address = string.Empty;

        foreach (IPAddress IPA in
                    Dns.GetHostAddresses(HttpContext.Current.Request.UserHostAddress))
        {
            if (IPA.AddressFamily.ToString() == "InterNetwork")
            {
                IP4Address = IPA.ToString();
                break;
            }
        }

        if (IP4Address != string.Empty)
        {
            return IP4Address;
        }

        foreach (IPAddress IPA in Dns.GetHostAddresses(Dns.GetHostName()))
        {
            if (IPA.AddressFamily.ToString() == "InterNetwork")
            {
                IP4Address = IPA.ToString();
                break;
            }
        }

        return IP4Address;
    }

	public clsDataLayer()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}