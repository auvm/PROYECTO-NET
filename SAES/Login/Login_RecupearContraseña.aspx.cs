using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SAES.Login
{
    public partial class Login_RecupearContraseña : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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
    }
}