using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Colegio
{
    public partial class mision : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("workstation id=COLEGIO.mssql.somee.com;packet size=4096;user id=wfvillalba_SQLLogin_1;pwd=umk7o9frdk;data source=COLEGIO.mssql.somee.com;persist security info=False;initial catalog=COLEGIO");

        protected void Page_Load(object sender, EventArgs e)
        {
            buscar();
        }

        public void buscar()
        {
            string cadsql = "select mision from colegio";

            SqlCommand comando = new SqlCommand(cadsql, con);
            con.Open();

            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                Label1.Text = leer["mision"].ToString();

            }
            con.Close();
        }
    }
}