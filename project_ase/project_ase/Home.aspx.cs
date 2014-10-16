using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class interior_design_Home : System.Web.UI.Page
{
    // string myconstring = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
    //static SqlConnection con = null;
    protected void Page_Load(object sender, EventArgs e)
    {

        /*string mystring="select Grocery_Store_Id,Grocery_Store_Picture from Grocery_Store";
        SqlDataAdapter da =new SqlDataAdapter();
        SqlCommand cmd=new SqlCommand(mystring,con);
        cmd.ExecuteNonQuery();
        da.SelectCommand=cmd;
        DataSet ds = new DataSet();
        da.Fill(ds);
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    
                    Rpt_databound.DataSource = ds;
                    Rpt_databound.DataBind();
                    
                    
                }*/

    }
}