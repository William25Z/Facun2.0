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
    public partial class Login : System.Web.UI.Page
    {
        private static string Cadena = ConfigurationManager.ConnectionStrings["CadenaConexionPP2024"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Cadena))
            {
                //try
                //{
                //    //SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                //    //builder.DataSource = "BANGHO";
                //    //builder.InitialCatalog = "ABM_BIB";
                //    //builder.UserID = "sa";
                //    //builder.Password = "13213";

                //    string script = "SELECT USUARIO FROM USUARIOS WHERE USUARIO = '" + txtUsuario.Text + "' AND" +
                //        " PASS = '" + txtPassword.Text + "'";

                //    connection.Open();

                //    SqlCommand command = new SqlCommand(script, connection);

                //    //SqlDataReader reader = command.ExecuteReader();

                //    int filas = command.ExecuteNonQuery();

                //    connection.Close();

                //    if (filas < 0)
                //    {
                //        Session["Usuario"] = txtUsuario.Text;
                //        Page.Response.Redirect("Inicio.aspx");
                //        //Response.Redirect("Inicio.aspx", true);
                //    }
                //    //else
                //    //lblError.Text = "Usuario o Password incorrectos.";

                //    //reader.Close();


                //}
                //catch (Exception exception)
                //{
                //    Console.WriteLine(exception.Message);
                //}


                if (!String.IsNullOrEmpty(txtUsuario.Text) && !String.IsNullOrEmpty(txtDNI.Text))
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
           
                //Nombre del servidor o DataSource
                builder.DataSource = "DESKTOP-QSS2PVA\\SQLEXPRESS";
                //Nombre de la base de datos
                builder.InitialCatalog = "Facun2DB";
                //Indicamos que se trata de Seguridad Integrada
                builder.IntegratedSecurity = true;
                builder.PersistSecurityInfo = true;
                builder.ApplicationName = "Facun2DB";


                using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
                {
                    string script = String.Format("INSERT INTO LOGIN (Usuario, Contraseña, Email, DNI) VALUES('{0}', '{1}', {2}, '{3}')", txtUsuario.Text, txtContraseña.Text, txtEmail.Text, txtDNI.Text);

                    conn.Open();

                    SqlCommand command = new SqlCommand(script, conn);

                    int resp = command.ExecuteNonQuery(); ////// ERROR

                    if (resp > 0)
                    {
                        LabelUsuario.Text = "Se ha generado el usuario para " + txtUsuario.Text + " DNI: " + txtDNI.Text;
                        //LabelUsuario.ForeColor = Color.Green;
                        txtUsuario.Text = "";
                        txtContraseña.Text = "";
                        txtEmail.Text = "";
                        txtDNI.Text = "";
                    }
                    else
                    {
                        lblTexto.Text = "Ha ocurrido un error";
                        //lblTexto.ForeColor = Color.Red;
                    }

                    //if (reader.HasRows)
                    //{
                    //    while (reader.Read())
                    //    {
                    //        string id = reader.GetInt32(0).ToString();
                    //        string nombre = reader.GetString(1);
                    //        lblTexto.Text = "Se ha creado el usuario " + nombre;
                    //    }
                    //}

                    //reader.Close();
                    conn.Close();
                }

                //OdbcConnection cn = new OdbcConnection("DSN=NombreConexion;UID=sa;PWD=123456");
                //OdbcCommand cmd = new OdbcCommand("select minvalue,maxvalue from tblRDvalidRange");
                //cn.Open();
                //cmd.Connection = cn;
                //OdbcDataReader rd = cmd.ExecuteReader();

                //if (rd.Read())
                //{
                //    int minvalue = System.Convert.ToInt32(rd[0]);
                //    int maxvalue = System.Convert.ToInt32(rd[1]);
                //}

                //cn.Close();


                //lblTexto.Text = "Se ha generado el usuario para " + txtNombre.Text + " " + txtApellido.Text;
            }
            else
            {
                lblTexto.Text = "Todos los campos son obligatorios";
            }
        }
            }
        }
    }