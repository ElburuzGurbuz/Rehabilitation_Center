﻿using System;
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
    public partial class company : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Label1.Text = Session["name"] + " olarak giriş yaptınız!";
            /*
            if (IsPostBack == false)
            {
                Label1.Text = " Welcome " + Session["name"];

                string sqlstr;

                sqlstr = "select cCode,cName from COURSE where cCode " +
                " not in (select cCode from TRANSCRIPT where " +
                " studentID = " + Session["studentID"] + ")";

                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = sqlstr;
                        cmd.Connection = con;
                        con.Open();
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                ListItem item = new ListItem();
                                item.Text = sdr["cName"].ToString();
                                item.Value = sdr["cCode"].ToString();
                                item.Selected = false;
                                CheckBoxList1.Items.Add(item);
                            }
                        }
                        con.Close();
                    }


                }
            }

            */

        }
    }
}