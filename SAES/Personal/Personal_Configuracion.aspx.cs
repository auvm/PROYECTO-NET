using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SAES.Personal
{
    public partial class Personal_Configuracion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                Label msg = new Label();
                msg.Text = "<h2>Bienvenido</h2>";
                PlaceHolderContenido.Controls.Add(msg);
            }
        }

        protected void lbRecuperar_Click(object sender, EventArgs e)
        {
            Label lblTitulo = new Label();
            lblTitulo.Text = "<h3>Recuperar Contraseña</h3><br/>";
            PlaceHolderContenido.Controls.Add(lblTitulo);

            string descipcionRecuperar = "<p>Ingrese su nombre de usuario (Con el que ingresó al sistema) " +
                                         "luego presione 'Enviar', un correo" +
                                         "electrónido será enviado a la dirección de correo asociada a esta cuenta" +
                                         "con la información del usuario.</p>";
            Label lblDescipcionRecuperar = new Label();
            lblDescipcionRecuperar.Text = descipcionRecuperar;
            PlaceHolderContenido.Controls.Add(lblDescipcionRecuperar);

            Label lblUsuario = new Label();
            lblUsuario.Text = "Usuario: ";

            TextBox txtUsuario = new TextBox();

            Button btnEnviar = new Button();
            btnEnviar.Text = "Enviar";

            PlaceHolderContenido.Controls.Add((Label)lblUsuario);
            PlaceHolderContenido.Controls.Add(txtUsuario);
            PlaceHolderContenido.Controls.Add(btnEnviar);
            btnEnviar.OnClientClick = "alert('Se ha enviado el correo con su información')";


        }

        protected void lbCambiar_Click(object sender, EventArgs e)
        {
            Label lblTitulo = new Label();
            lblTitulo.Text = "<h3>Cambiar Contraseña</h3><br/>";
            PlaceHolderContenido.Controls.Add(lblTitulo);
            string descripcionCambiar = "<p>Ingrese su nombre de usuario y su contraseña actual (Con los que ingresó al sistema), " +
                                        "luego ingrese la nueva contraseña donde se le indica y a continuación presione 'Enviar'. " +
                                        "Podrá usar su nueva contraseña en su siguiente inicio de sesión.</p>";
            Label lblDescipcionCambiar = new Label();
            lblDescipcionCambiar.Text = descripcionCambiar;
            PlaceHolderContenido.Controls.Add(lblDescipcionCambiar);

            Label lblUsuario = new Label();
            lblUsuario.Text = "Usuario: ";
            TextBox txtUsuario = new TextBox();
            Label lblPassword = new Label();
            lblPassword.Text = "Contraseña: ";
            TextBox txtPassword = new TextBox();
            Label lblNewPassword = new Label();
            lblNewPassword.Text = "Nueva Contraseña: ";
            TextBox txtNewPassword = new TextBox();
            Button btnEnviar = new Button();
            btnEnviar.Text = "Enviar";
            PlaceHolderContenido.Controls.Add(lblUsuario);
            PlaceHolderContenido.Controls.Add(txtUsuario);
            PlaceHolderContenido.Controls.Add(lblPassword);
            PlaceHolderContenido.Controls.Add(txtPassword);
            PlaceHolderContenido.Controls.Add(lblNewPassword);
            PlaceHolderContenido.Controls.Add(txtNewPassword);
            PlaceHolderContenido.Controls.Add(btnEnviar);
            btnEnviar.OnClientClick = "alert('Se ha enviado el correo con su información')";

        }
    }
}