using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SAES.Personal
{
    public partial class Personal_Agenda : System.Web.UI.Page
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

        protected void lbAgendaEscolar_Click(object sender, EventArgs e)
        {
            Label lblTitulo = new Label();
            lblTitulo.Text = "<h3>Agenda Escolar</h3><br/>";
            PlaceHolderContenido.Controls.Add(lblTitulo);
        }
    }
}