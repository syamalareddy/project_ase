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
    protected void LoginButton_Click(object sender, EventArgs e)
    {
       /* string uname="select User_Name from Login_User where User_Name='"+UserName+"'";
        if(uname!=null)
        {
            string pwd = "select Password from User where Login_User.User_Id=User.User_Id and Login_User.User_Name='" + uname + "'";
                if(string.Compare(pwd,Password))
                {
                    lbl_Home.text="welcome"+uname;
                    Response.Redirect(@"~\interior-design\Home.aspx");
                }
                else
                {
                    lbl_pwd.text="enter correct pwd";
                }
        }
        else
        {
            lbl_pwd="username doesnt exist";
        }
        */
        //Response.Redirect("Pricing.aspx");
    }
}