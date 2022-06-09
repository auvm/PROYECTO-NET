using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SAES.Alumnos
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                Label lblTitulo = new Label();
                lblTitulo.Text = "<h3>Agenda Escolar</h3><br/>";
                PlaceHolderContenido.Controls.Add(lblTitulo);

                string cstr = @"server=VENTANAS10; database=SAES; integrated security = true";
                SqlConnection cnx = new SqlConnection(cstr);
                string query = "SELECT EVENTO AS 'EVENTO', FECHAINICIO AS 'FECHA DE INICIO', FECHAFIN AS 'FECHA FIN', SUSPENSIONLABORES'SUSPENSIÓN DE LABORES' FROM Agenda;";
                SqlDataAdapter adp = new SqlDataAdapter(query, cnx);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                cnx.Close();
                GridView gridView = new GridView();
                gridView.DataSource = ds.Tables[0];
                PlaceHolderContenido.Controls.Add((GridView)gridView);
                gridView.DataBind();
            }
        }

        protected void lbAgendaEscolar_Click(object sender, EventArgs e)
        {

            Response.Redirect("Alumno_Agenda_AgendaEscolar.aspx");
        }
    }
}