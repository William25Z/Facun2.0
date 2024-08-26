using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Facun2._0
{
    public partial class Login1 : System.Web.UI.Page
    {
        private static string Cadena = ConfigurationManager.ConnectionStrings["CadenaConexionPP2024"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                try
                {
                    //SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                    //builder.DataSource = "BANGHO";
                    //builder.InitialCatalog = "ABM_BIB";
                    //builder.UserID = "sa";
                    //builder.Password = "13213";

                    string script = "SELECT USUARIO FROM LOGIN WHERE USUARIO = '" + txtUsuario.Text + "' AND" +
                        " CONTRASEÑA = '" + txtContraseña.Text + "'";

                    connection.Open();

                    SqlCommand command = new SqlCommand(script, connection);

                    //SqlDataReader reader = command.ExecuteReader();

                    int filas = command.ExecuteNonQuery();

                    connection.Close();

                    if (filas < 0)
                    {
                        Session["Usuario"] = txtUsuario.Text;
                        Page.Response.Redirect("Inicio.aspx");
                        //Response.Redirect("Inicio.aspx", true);
                    }
                    //else
                    //    lblTexto.Text = "Usuario o Contraseña incorrectos.";

                    //reader.Close();


                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }

        }
    }
}