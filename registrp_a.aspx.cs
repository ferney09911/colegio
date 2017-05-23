using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Colegio
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("workstation id=COLEGIO.mssql.somee.com;packet size=4096;user id=wfvillalba_SQLLogin_1;pwd=umk7o9frdk;data source=COLEGIO.mssql.somee.com;persist security info=False;initial catalog=COLEGIO");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cadsql = "insert into curso values ('" + TextBox2.Text + "','" + TextBox3.Text + "')";

                SqlCommand comando = new SqlCommand(cadsql, con);
                con.Open();

                SqlDataReader leer = comando.ExecuteReader();

                con.Close();
                MessageBox.Show("REGISTRADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
               
                string cadsql = "insert into asignatura values ('" + TextBox18.Text + "','" + TextBox4.Text + "')";

                SqlCommand comando = new SqlCommand(cadsql, con);
                con.Open();

                SqlDataReader leer = comando.ExecuteReader();

                con.Close();
                MessageBox.Show("REGISTRADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected void CheckBoxList3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                string cadsql = "insert into asignatura_curso values ('" + lista1.Text + "','" + lista2.Text + "')";

                SqlCommand comando = new SqlCommand(cadsql, con);
                con.Open();

                SqlDataReader leer = comando.ExecuteReader();

                con.Close();
                MessageBox.Show("REGISTRADO");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

        }
    }
}
