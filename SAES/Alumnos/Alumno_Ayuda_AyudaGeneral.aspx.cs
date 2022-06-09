using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SAES.Alumnos
{
    public partial class Alumno_Ayuda_AyudaGeneral : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                Label lblTitulo = new Label();
                lblTitulo.Text = "<h3>Ayuda General</h3><br/>";
                PlaceHolderContenido.Controls.Add(lblTitulo);

                string descripcion = "<p><h4>¿Qué es este sitio?</h4> Este es el sitio de administración escolar, aquí podrás ver " +
                                     "información general sobre tu escuela como eventos, ceremonias, " +
                                     "proyetos de la dirección, entre otros. Esto en la sección <b><u>'Agenda'</b></u>. " +
                                     "También podrás consultar tu horario con las materias que tienes asignadas " +
                                     "y las calificaciones que vas obteniendo en cada una de ellas a lo largo " +
                                     "del periodo escolar en la sección <b><u>'Alumno'</b></u>. Si en agún momento decides cambiar " +
                                     "la contraseña que tienes asignada para igresar al sistema, dirigete a la sección " +
                                     "<b><u>'Configuración'</b></u>, en caso de perderla en el apartado de recuperar se te indicarán " +
                                     "los pasos a seguir para recuperarla.</p>";
                Label lblDescripcion = new Label();
                lblDescripcion.Text = descripcion;
                PlaceHolderContenido.Controls.Add(lblDescripcion);
            }
        }

        protected void lbAyudaGeneral_Click(object sender, EventArgs e)
        {
            Response.Redirect("Alumno_Ayuda_AyudaGeneral.aspx");
        }
    }
}