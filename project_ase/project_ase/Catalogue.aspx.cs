using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class interior_design_Default2 : System.Web.UI.Page
{
   //int Product_Id = Request.QueryString["ItemId"] != null ? Request.QueryString["ItemId"].ToString() : null;
  ///  static string myconstring = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
   //  static    SqlConnection con = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        /*string mystring="select Item_Id,Item_Picture from Item_Desc where Grocery_Store.Grocery_Store_Id=Item_Desc.Grocery_Store_Id";
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

                RptContent.DataSource = ds;
                RptContent.DataBind();


            }
        }*/

    }
}