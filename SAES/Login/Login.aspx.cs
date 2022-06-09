using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SAES.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string cstr = @"server=VENTANAS10; database=SAES; integrated security = true";
            string query = $"SELECT * FROM CREDENCIALES WHERE Boleta = '{txtUsuario.Text}' AND Contraseña = '{txtpasswd.Text}'";
            SqlConnection cnx = new SqlConnection(cstr);
            cnx.Open();
            SqlCommand cmd = new SqlCommand(query, cnx);
            string boleta = (string)cmd.ExecuteScalar();
            cnx.Close();

            if(boleta == txtUsuario.Text) {
                if (txtUsuario.Text.StartsWith("2019"))
                {
                    Response.Redirect("../Personal/Personal_Informacion_Personal.aspx");
                }
                else if (txtUsuario.Text.StartsWith("2010"))
                {
                    Response.Redirect("../Profesores/Profesor_Informacion_Personal.aspx");
                }
                else if(txtUsuario.Text.StartsWith("2000"))
                {
                    Response.Redirect("../Alumnos/Alumno_Información Personal.aspx");
                }
                
            }

        }

        protected void lbRecuperar_Click(object sender, EventArgs e)
        {

        }
    }
}