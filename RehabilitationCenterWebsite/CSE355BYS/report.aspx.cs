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
    public partial class report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }


        protected void editHealthReport(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();

            SqlConnection con = new SqlConnection(connectionString);

            using (con)
            {
                using (SqlCommand cmd = new SqlCommand("sp_EditHealthReport", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@healthReportNumber", SqlDbType.VarChar).Value = TextBox1.Text;
                    cmd.Parameters.Add("@disabilityDiagnosis", SqlDbType.VarChar).Value = TextBox2.Text;
                    cmd.Parameters.Add("@applicatonDate", SqlDbType.VarChar).Value = TextBox3.Text;
                    cmd.Parameters.Add("@disabilityPercentage", SqlDbType.VarChar).Value = TextBox4.Text;

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
                        Label2.Text = TextBox1.Text + " numaralı Sağlık raporu başarıyla güncellendi!";
                    }
                    else
                    {
                        Label2.Text = "Veritabanı güncellemesi esnasında hata!";
                    }
                    con.Close();
                }
            }

        }

        protected void editRamReport(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();

            SqlConnection con = new SqlConnection(connectionString);

            using (con)
            {
                using (SqlCommand cmd = new SqlCommand("sp_EditRamReport", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@ramReportNumber", SqlDbType.VarChar).Value = TextBox5.Text;
                    cmd.Parameters.Add("@diagnosis", SqlDbType.VarChar).Value = TextBox6.Text;
                    cmd.Parameters.Add("@decisionDate", SqlDbType.VarChar).Value = TextBox7.Text;

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
                        Label3.Text = TextBox5.Text + " numaralı Ram raporu başarıyla güncellendi!";
                    }
                    else
                    {
                        Label3.Text = "Veritabanı güncellemesi esnasında hata!";
                    }
                    con.Close();
                }
            }

        }

        protected void NOT_VALID_REPORT_FOR_STUDENT(object sender, EventArgs e)
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
            string sqlstr = "select * from NOT_VALID_REPORT_FOR_STUDENT";

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();

        }

        protected void list_report(object sender, EventArgs e)
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
            string sqlstr = "select ds.studentID as no, ds.firstName + ' ' + ds.lastName as İsim, rl.ramReportNumber as 'RR No', rr.diagnosis as Hastalık, rr.decisionDate, rl.healthReportNumber as 'SR No', hr.disabilityDiagnosis as Hastalık, hr.applicatonDate, hr.disabilityPercentage as '%', hr.severelyDisabled from REPORT_LIST rl, HEALTH_REPORT hr, RAM_REPORT rr, DISABLED_STUDENT ds where ds.studentID=rl.studentID and rl.ramReportNumber=rr.ramReportNumber and rl.healthReportNumber=hr.healthReportNumber";

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();

        }




    }
}

