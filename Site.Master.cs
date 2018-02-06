using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace IPrepPortal
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ////create global session for user
            //string useradminNo = "";
            //string displayname = "";
            //useradminNo = Session["adminNo"].ToString();

            //if (useradminNo != null)
            //{

            //    //Open database connection to get user details
            //    //Connection String
            //    string strConnString = ConfigurationManager.ConnectionStrings["IPrepConnString"].ConnectionString;

            //    //Create Sql Connection
            //    SqlConnection conn = new SqlConnection(strConnString);

            //    //SQL line query****

            //    SqlCommand commandfindadminNo = new SqlCommand("Select name, adminNo FROM studentInfo WHERE adminNo=@adminNo ", conn);


            //    //only taking name and checking admin number with session
            //    // cmd parameters addwithvalue
            //    commandfindadminNo.Parameters.AddWithValue("@adminNo", useradminNo.ToString());
            //    commandfindadminNo.Parameters.AddWithValue("@name", displayname.ToString());

            //    //Open SQL connection
            //    conn.Open();

            //    //read data into variable
            //    using (SqlDataReader reader = commandfindadminNo.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            displayname = reader[0].ToString();
            //        }
            //    }

            //    //SQL data adapter
            //    SqlDataAdapter sda = new SqlDataAdapter(commandfindadminNo);
            //    DataSet ds = new DataSet();
            //    sda.Fill(ds);
            //    conn.Close();

            //    //counter value
            //    int count = ds.Tables[0].Rows.Count;

            //    if (count == 1)
            //    {
                    


            //    }
            //    else
            //    {

            //    }
            //}
            //else
            //{
            //    Response.Redirect("loginPage.aspx");
            //}
        }

        protected void logout_ServerClick(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Session.RemoveAll();
            Response.Redirect("loginPage.aspx");
        }
    }
}