using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SAES.Alumnos
{
    public partial class Alumno_Información_Personal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbInfoPersonal_Click(object sender, EventArgs e)
        {
            Label lblTitulo = new Label();
            lblTitulo.Text = "Información Personal<br/>";
            PlaceHolderContenido.Controls.Add(lblTitulo);
         
            //TODO: AGREGAR IMAGEN de la base de datos
            //< h3 > Foto:</ h3 >
            //< asp:Image ID = "imgPefil" runat = "server" alt = "imagen" CssClass = "img" />< br />< br />
            Image imgPerfil = new Image();
            imgPerfil.ImageUrl = @"../Imagenes-BorrarAlFinal/fotoMujer.PNG";
            imgPerfil.Width = 100;
            imgPerfil.Height = 100;
            PlaceHolderContenido.Controls.Add((Image)imgPerfil);

            //TODO: ASIGNAR LOS DATOS(NOMBRE, FECHA, ETC...) DE LA BASE DE DATOS
            string nombre = " ";
            string fechaNacimiento = " ";
            string telefono = " ";
            string correo = " ";
            string direccion = " ";

            Label lblNombre = new Label();
            Label lblFechaNacimiento = new Label();
            Label lblTelefono = new Label();
            Label lblCorreo = new Label();
            Label lblDireccion = new Label();

            lblNombre.Text = "<br/>Nombre: " + nombre + "<br/>";
            lblFechaNacimiento.Text = "Fecha de Nacimiento: " + fechaNacimiento + "<br/>";
            lblTelefono.Text = "Teléfono: " + telefono + "<br/>";
            lblCorreo.Text = "Correo Electrónico: " + correo + "<br/>";    
            lblDireccion.Text = "Dirección: " + direccion + "<br/>";

            PlaceHolderContenido.Controls.Add(lblNombre);
            PlaceHolderContenido.Controls.Add(lblFechaNacimiento);
            PlaceHolderContenido.Controls.Add(lblTelefono);
            PlaceHolderContenido.Controls.Add(lblCorreo);
            PlaceHolderContenido.Controls.Add(lblDireccion);

        }

        protected void lbHorario_Click(object sender, EventArgs e)
        {
            Label lblTitulo = new Label();
            lblTitulo.Text = "Horario<br/>";
            PlaceHolderContenido.Controls.Add(lblTitulo);
        }

        protected void lbCalificaciones_Click(object sender, EventArgs e)
        {
            Label lblTitulo = new Label();
            lblTitulo.Text = "Calificaciones<br/>";
            PlaceHolderContenido.Controls.Add(lblTitulo);
        }
    }
}