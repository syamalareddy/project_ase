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
    static string myconstring = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
    static SqlConnection con = null;
    
        
        protected void Page_Load(object sender, EventArgs e)
        {
            byte[] picary;
            try
            {
                //byte[] my_pic_ary;
                if (!string.IsNullOrEmpty(Request.QueryString["Id"]))
                {
                    if (!string.IsNullOrEmpty(Request.QueryString["size"]))
                    {
                        con.Open();
                        string mystring="select Grocery_Store_Picture from Grocery_Store where Grocery_Store_Id='"+Request.QueryString["Id"]+"'";
                        SqlCommand cmd = new SqlCommand(mystring, con);
                      
                        picary = (byte[])cmd.ExecuteScalar();
                        picary = WorkWithImage.ResizeImage(new System.Drawing.Bitmap(new System.IO.MemoryStream(picary, 0, picary.Length)), 227);
                      //  my_pic_ary = SelectQuery.GetProductImage(Request.QueryString["Id"]);
                       // my_pic_ary = BisunessLayer.WorkWithImage.ResizeImage(new System.Drawing.Bitmap(new MemoryStream(my_pic_ary, 0, my_pic_ary.Length)), 100);
                        Response.BinaryWrite(picary);
                    }
                    
                }
                
            }
            catch (Exception ex)
            {
            }
        }

    }


