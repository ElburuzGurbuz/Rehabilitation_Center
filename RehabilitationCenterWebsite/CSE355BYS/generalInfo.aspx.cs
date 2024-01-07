using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CSE355BYS
{
    public partial class generalInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }


        protected void editCompanyInfo(object sender, EventArgs e)
        {
            if (!(TextBox1.Text.Equals("") || TextBox2.Text.Equals("") || TextBox3.Text.Equals("") || TextBox4.Text.Equals("")))
            {
                string connectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();

                SqlConnection con = new SqlConnection(connectionString);

                using (con)
                {
                    using (SqlCommand cmd = new SqlCommand("sp_EditCompanyInformation", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@taxNumber", SqlDbType.VarChar).Value = TextBox1.Text;
                        cmd.Parameters.Add("@companyName", SqlDbType.VarChar).Value = TextBox2.Text;
                        cmd.Parameters.Add("@generalManager", SqlDbType.VarChar).Value = TextBox3.Text;
                        cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = TextBox4.Text;

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


                        if (0 != cmd.ExecuteNonQuery())
                        {
                            Label1.Text = "Şirket Bilgileri başarıyla güncellendi!";
                        }
                        else
                        {
                            Label1.Text = "Veritabanı güncellemesi esnasında hata!";
                        }
                        con.Close();
                    }
                }
            }
            else
            {
                Label1.Text = "Lütfen tüm alanları eksiksiz doldurunuz!";
            }

        }


    }



}

