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
    public partial class staff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_staff(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();

            SqlConnection con = new SqlConnection(connectionString);

            using (con)
            {
                using (SqlCommand cmd = new SqlCommand("sp_AddStaff", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@city", SqlDbType.VarChar).Value = TextBox7.Text;
                    cmd.Parameters.Add("@street", SqlDbType.VarChar).Value = TextBox8.Text;
                    cmd.Parameters.Add("@apartmentName", SqlDbType.VarChar).Value = TextBox9.Text;
                    cmd.Parameters.Add("@apartmentNumber", SqlDbType.VarChar).Value = TextBox10.Text;
                    cmd.Parameters.Add("@zipCode", SqlDbType.VarChar).Value = TextBox11.Text;
                    cmd.Parameters.Add("@jobField", SqlDbType.VarChar).Value = TextBox12.Text;
                    cmd.Parameters.Add("@identityNumber", SqlDbType.VarChar).Value = TextBox6.Text;
                    cmd.Parameters.Add("@firstName", SqlDbType.VarChar).Value = TextBox1.Text;
                    cmd.Parameters.Add("@lastName", SqlDbType.VarChar).Value = TextBox2.Text;
                    cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = TextBox3.Text;
                    cmd.Parameters.Add("@gsm", SqlDbType.VarChar).Value = TextBox4.Text;
                    cmd.Parameters.Add("@salary", SqlDbType.VarChar).Value = TextBox5.Text;

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

                    try
                    {
                        if (0 != cmd.ExecuteNonQuery())
                        {
                            Label1.Text = TextBox1.Text + " " + TextBox2.Text + " veritabanına başarıyla eklendi!";
                        }
                        else
                        {
                            Label1.Text = "Veritabanına ekleme esnasında hata!";
                        }
                    }
                    catch
                    {
                        Label1.Text = "Bilgilerinizi lütfen kontrol edin.";
                    }
                    con.Close();
                }
            }

        }

        protected void delete_staff(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();

            SqlConnection con = new SqlConnection(connectionString);

            using (con)
            {
                using (SqlCommand cmd = new SqlCommand("sp_DeleteStaff", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@employeeID", SqlDbType.VarChar).Value = TextBox13.Text;

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
                        Label1.Text = TextBox13.Text + "id'li işçi veritabanından çıkarıldı!";
                    }
                    else
                    {
                        Label1.Text = "Veritabanına ekleme esnasında hata!";
                    }

                    con.Close();
                }
            }

        }

    }



}

