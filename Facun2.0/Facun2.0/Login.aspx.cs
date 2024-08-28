﻿using System;
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
                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                    //EZE
                    builder.DataSource = "DESKTOP-QSS2PVA\\SQLEXPRESS";

                    //ESCUELA
                    //builder.DataSource = "DESKTOP-U48JRI6\\SQLEXPRESS";

                    //Nombre de la base de datos
                    builder.InitialCatalog = "Facun2DB";
                    //Indicamos que se trata de Seguridad Integrada
                    builder.IntegratedSecurity = true;
                    builder.PersistSecurityInfo = true;
                    builder.ApplicationName = "Facun2DB";

                    using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
                    {

                        string script = "SELECT COUNT(*) FROM LOGIN WHERE USUARIO = '" + txtUsuario.Text + "' AND" +
                                " CONTRASEÑA = '" + txtContraseña.Text + "'";

                        //connection.Open();
                        conn.Open();

                        SqlCommand command = new SqlCommand(script, conn);

                        //int filas = command.ExecuteNonQuery();
                        int count = (int)command.ExecuteScalar();

                        //if (filas < 0)
                        if (count > 0)
                        {
                            Session["Usuario"] = txtUsuario.Text;
                            Page.Response.Redirect("Inicio.aspx");
                            //Response.Redirect("Inicio.aspx", true);
                        }

                        else
                            lblTexto.Text = "Usuario o Contraseña incorrectos.";
                        lblTexto.ForeColor = System.Drawing.Color.Red;
                        lblTexto.Focus();
                        conn.Close();
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }

        }
    }
}