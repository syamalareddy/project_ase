using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class interior_design_Default : System.Web.UI.Page
{
    static string myconstring = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
    static SqlConnection con = null;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_upload_Click(object sender, EventArgs e)
    {
        using (con = new SqlConnection(myconstring))
        {
            try
            {
                int i = 1;
                con.Open();
                string grcstring = "select Grocery_Store_Id from Grocery_Store where Grocery_Store_Name='" + txt_Grocery_Store + "'";
                SqlCommand cmd1 = new SqlCommand(grcstring, con);
                int gr_id = (int)cmd1.ExecuteScalar();
                if (gr_id == null)
                    Console.WriteLine("Error");
                string mystring = "insert into Item_Desc(Item_Id,Item_Name,Item_Status,Grocery_Store_Id) values("+i+",'" + txt_Name + "'," + txt_Price + "," + "'yes'" + "," + gr_id + ")";
                SqlCommand cmd = new SqlCommand(mystring, con);

                cmd.ExecuteNonQuery();
                i++;
                con.Close();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("error");

            }
        }
    }
}