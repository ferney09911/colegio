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
using System.Timers;

namespace Colegio
{
    public partial class registroestudiante : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("workstation id=COLEGIO.mssql.somee.com;packet size=4096;user id=wfvillalba_SQLLogin_1;pwd=umk7o9frdk;data source=COLEGIO.mssql.somee.com;persist security info=False;initial catalog=COLEGIO");
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cadsql = "insert into estudiante values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox20.Text + "')";

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
                string cadsql = "insert into acudiente values ('" + TextBox10.Text + "','" + TextBox18.Text + "','" + TextBox19.Text + "','" + TextBox11.Text + "','" + TextBox12.Text + "','" + TextBox13.Text + "')";

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
   }
}
