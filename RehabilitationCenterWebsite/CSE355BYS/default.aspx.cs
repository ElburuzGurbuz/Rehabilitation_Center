using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// 
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace CSE355BYS
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();

            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                con.Open();
            }
            catch (Exception)
            {
                con.Close();
                return;
                throw;
            }

            DataSet ds = new DataSet();
            String un = TextBox1.Text;
            string sqlstr = "select * from REHAB_CENTER rc where userName=" + un;
            sqlstr = "Select * from REHAB_CENTER where userName='" + un + "'";
            Console.WriteLine(un);

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            int rowcount = da.Fill(ds);

            if (rowcount == 0)
            {
                Label1.Text = "Invalid username";
                Response.AddHeader("REFRESH", "2;URL=default.aspx");
            }
            else
            {
                string name = ds.Tables[0].Rows[0]["generalManager"].ToString();
                string companyName = ds.Tables[0].Rows[0]["companyName"].ToString();
                string pass = ds.Tables[0].Rows[0]["user_password"].ToString();
                string enteredPass = TextBox2.Text;
                con.Close();

                Session["name"] = name;
                Session["companyName"] = companyName;

                if (String.Equals(pass, enteredPass))
                {
                    Response.Redirect("company.aspx");
                }
                else
                {
                    Label1.Text = "Invalid Password";
                    Response.AddHeader("REFRESH", "2;URL=default.aspx");
                }
            }






        }
    }
}