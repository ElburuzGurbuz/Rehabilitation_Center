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
    public partial class educations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void THERAPY_SESSION_IN_ONE_WEEK(object sender, EventArgs e)
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
            string sqlstr = "select * from THERAPY_SESSION_IN_ONE_WEEK";

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();

        }

        protected void LISTING_STUDENT_ASSIGNED_INST(object sender, EventArgs e)
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
            string sqlstr = "select * from LISTING_STUDENT_ASSIGNED_INST";

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();

        }

        protected void LISTING_STUDENTS_ASSIGNED_TO_INSTRUCTOR(object sender, EventArgs e)
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
            string sqlstr = "select * from LISTING_STUDENTS_ASSIGNED_TO_INSTRUCTOR";

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();

        }

        protected void TOP_10_MOST_DISABLE(object sender, EventArgs e)
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
            string sqlstr = "select * from TOP_10_MOST_DISABLE";

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();

        }

        protected void add_therapy(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();

            SqlConnection con = new SqlConnection(connectionString);

            using (con)
            {
                using (SqlCommand cmd = new SqlCommand("sp_AddTherapy", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@therapyDescription", SqlDbType.VarChar).Value = TextBox6.Text;
                    cmd.Parameters.Add("@sessionDate", SqlDbType.VarChar).Value = TextBox1.Text;
                    cmd.Parameters.Add("@employeeID", SqlDbType.VarChar).Value = TextBox2.Text;
                    cmd.Parameters.Add("@studentID", SqlDbType.VarChar).Value = TextBox3.Text;

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
                        Label1.Text = "Terapi veritabanına başarıyla eklendi!";
                    }
                    else
                    {
                        Label1.Text = "Veritabanına ekleme esnasında hata!";
                    }
                    con.Close();
                }
            }

        }

        protected void sp_addInstructorList(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();

            SqlConnection con = new SqlConnection(connectionString);

            using (con)
            {
                using (SqlCommand cmd = new SqlCommand("sp_addInstructorList", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@studentID", SqlDbType.VarChar).Value = TextBox7.Text;
                    cmd.Parameters.Add("@employeeID", SqlDbType.VarChar).Value = TextBox8.Text;

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
                        Label3.Text = "Öğrenci-Eğitmen veritabanında başarıyla eşleştirildi!";
                    }
                    else
                    {
                        Label3.Text = "Veritabanın düzenlemesi esnasında hata!";
                    }
                    con.Close();
                }
            }

        }


        protected void sp_ListAppropriateInstructors(object sender, EventArgs e)
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
            string sqlstr = "declare @diagnosis nvarchar(50) select @diagnosis=hr.disabilityDiagnosis from REPORT_LIST rl, HEALTH_REPORT hr, DISABLED_STUDENT ds where rl.healthReportNumber=hr.healthReportNumber and rl.studentID=ds.studentID and ds.studentID=" + TextBox5.Text + " select e.employeeID, e.firstName, e.lastName,i.profession, e.gsm from INSTRUCTOR i, EMPLOYEE e where i.profession like '%' + @diagnosis +'%' and e.employeeID=i.employeeID";

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();

        }

        protected void delete_therapy(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conStr"].ToString();

            SqlConnection con = new SqlConnection(connectionString);

            using (con)
            {
                using (SqlCommand cmd = new SqlCommand("sp_DeleteTherapy", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@sessionID", SqlDbType.VarChar).Value = TextBox4.Text;

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
                        Label1.Text = "Terapi veritabanından başarıyla silindi!";
                    }
                    else
                    {
                        Label1.Text = "Veritabanından silme esnasında hata!";
                    }
                    con.Close();
                }
            }

        }

        protected void List_therapy(object sender, EventArgs e)
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
            string sqlstr = "select * from THERAPY_SESSIONS order by sessionDate";

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();

        }

        protected void List_student(object sender, EventArgs e)
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
            string sqlstr = "select * from DISABLED_STUDENT";

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();

        }

        protected void List_psychologist(object sender, EventArgs e)
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
            string sqlstr = "select e.employeeID, e.identityNumber, e.firstName + ' ' + e.lastName as fullName, e.gender, e.gsm, e.salary, e.addressID " +
                " from employee e, PSYCHOLOGIST p where p.employeeID=e.employeeID";

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();

        }






















    }



}

