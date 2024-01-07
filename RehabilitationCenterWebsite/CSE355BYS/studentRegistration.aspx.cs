using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace CSE355BYS
{
    public partial class studentRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox15.ForeColor = Color.Gray;
        }

        protected void add_studentRegistration(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();

            SqlConnection con = new SqlConnection(connectionString);

            using (con)
            {
                using (SqlCommand cmd = new SqlCommand("sp_AddDisabledStudent", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@firstName", SqlDbType.VarChar).Value = TextBox1.Text;
                    cmd.Parameters.Add("@lastName", SqlDbType.VarChar).Value = TextBox2.Text;
                    cmd.Parameters.Add("@birthPlace", SqlDbType.VarChar).Value = TextBox3.Text;
                    cmd.Parameters.Add("@birthDate", SqlDbType.VarChar).Value = TextBox4.Text;
                    cmd.Parameters.Add("@parentFirstName", SqlDbType.VarChar).Value = TextBox5.Text;
                    cmd.Parameters.Add("@parentLastName", SqlDbType.VarChar).Value = TextBox6.Text;
                    cmd.Parameters.Add("@parentGender", SqlDbType.VarChar).Value = TextBox7.Text;
                    cmd.Parameters.Add("@parentGsm", SqlDbType.VarChar).Value = TextBox8.Text;
                    cmd.Parameters.Add("@city", SqlDbType.VarChar).Value = TextBox9.Text;
                    cmd.Parameters.Add("@street", SqlDbType.VarChar).Value = TextBox10.Text;
                    cmd.Parameters.Add("@apartmentName", SqlDbType.VarChar).Value = TextBox11.Text;
                    cmd.Parameters.Add("@apartmentNumber", SqlDbType.VarChar).Value = TextBox12.Text;
                    cmd.Parameters.Add("@zipCode", SqlDbType.VarChar).Value = TextBox13.Text;
                    cmd.Parameters.Add("@ramReportNumber", SqlDbType.VarChar).Value = TextBox14.Text;
                    cmd.Parameters.Add("@diagnosis", SqlDbType.VarChar).Value = TextBox15.Text;
                    cmd.Parameters.Add("@decisionDate", SqlDbType.VarChar).Value = TextBox16.Text;
                    cmd.Parameters.Add("@healthReportNumber", SqlDbType.VarChar).Value = TextBox17.Text;
                    cmd.Parameters.Add("@disabilityDiagnosis", SqlDbType.VarChar).Value = TextBox18.Text;
                    cmd.Parameters.Add("@applicatonDate", SqlDbType.VarChar).Value = TextBox19.Text;
                    cmd.Parameters.Add("@disabilityPercentage", SqlDbType.VarChar).Value = TextBox20.Text;

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
                        Label1.Text = TextBox1.Text + " " + TextBox2.Text + " veritabanına başarıyla eklendi!";
                    }
                    else
                    {
                        Label1.Text = "Veritabanına ekleme esnasında hata!";
                    }
                    con.Close();
                }
            }

        }

        protected void delete_studentRegistration(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();

            SqlConnection con = new SqlConnection(connectionString);

            using (con)
            {
                using (SqlCommand cmd = new SqlCommand("sp_DeleteStudent", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@stdID", SqlDbType.VarChar).Value = TextBox21.Text;

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
                        Label1.Text = TextBox21.Text + "id'li Öğrenci veritabanından çıkarıldı!";
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

