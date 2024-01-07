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
    public partial class address : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void List_address(object sender, EventArgs e)
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
            string sqlstr = "select a.addressID, a.city, a.street, a.apartmentName, a.apartmentNumber, a.zipCode from address a, employee e, parent p, DISABLED_STUDENT ds " +
                "where (a.addressID=e.addressID or p.addressID=a.addressID) and p.parentID=ds.parentID group by a.addressID, a.city, a.street, a.street, a.apartmentName, a.apartmentNumber, a.zipCode";

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();

        }

        protected void List_parentAddress(object sender, EventArgs e)
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
            string sqlstr = "select a.addressID, p.firstName, p.lastName, a.city, a.street, a.apartmentName, a.apartmentNumber, a.zipCode from address a, parent p, DISABLED_STUDENT ds " +
                "where p.addressID=a.addressID and p.parentID= ds.parentID";


            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();

        }

        protected void List_employeeAddress(object sender, EventArgs e)
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
            string sqlstr = "select a.addressID, e.firstName, e.lastName, a.city, a.street, a.apartmentName, a.apartmentNumber, a.zipCode from address a, employee e where a.addressID=e.addressID";
            
            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();

        }

        protected void edit_address(object sender, EventArgs e)
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
            string sqlstr = "UPDATE address SET city = '" + TextBox1.Text + "' , street = '" + TextBox2.Text + "' , apartmentName = '" + TextBox3.Text + "' , apartmentNumber = " + TextBox4.Text + ", zipCode = " + TextBox5.Text + " WHERE addressID = " + TextBox6.Text;

            SqlDataAdapter da = new SqlDataAdapter(sqlstr, con);
            da.Fill(ds);

            con.Close();

        }


    }



}

