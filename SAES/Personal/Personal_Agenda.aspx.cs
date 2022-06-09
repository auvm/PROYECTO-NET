using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

            Label lblDescripcion = new Label();
            lblDescripcion.Text = "<p>Para crear un nuevo evento escolar ingrese los datos solicitados a" +
                                  "continuación, luego de click en 'Enviar'.</p></br>";
            PlaceHolderContenido.Controls.Add(lblDescripcion);

            Label lblNombreEvento = new Label();
            lblNombreEvento.Text = "Nombre del evento: ";
            PlaceHolderContenido.Controls.Add((Label)lblNombreEvento);
            TextBox txtNombreEvento = new TextBox();
            PlaceHolderContenido.Controls.Add(txtNombreEvento);
            
            //------------------------------Selecciona Fechas
            Label lblFecha = new Label();
            lblFecha.Text = "</br></br><i>¡Seleccione una fecha de inicio!</i></br>";
            PlaceHolderContenido.Controls.Add(lblFecha);

            Label lblDia = new Label();
            lblDia.Text = " Día: ";
            DropDownList ddlDia = new DropDownList();
            ListItem item;
            for (int i = 1; i <= 31; i++)
            {
                item = new ListItem(i.ToString());
                ddlDia.Items.Add(item);
            }
            PlaceHolderContenido.Controls.Add(lblDia);
            PlaceHolderContenido.Controls.Add(ddlDia);


            Label lblMes = new Label();
            lblMes.Text = " Mes: ";
            DropDownList ddlMes = new DropDownList();
            for (int i = 1; i <= 12; i++)
            {
                item = new ListItem(i.ToString());
                ddlMes.Items.Add(item);
            }
            PlaceHolderContenido.Controls.Add(lblMes);
            PlaceHolderContenido.Controls.Add(ddlMes);

            Label lblAnio = new Label();
            lblAnio.Text = " Anio: ";
            DropDownList ddlAnio = new DropDownList();
            PlaceHolderContenido.Controls.Add(lblAnio);
            PlaceHolderContenido.Controls.Add(ddlAnio);
            for (int i = 2022; i <= 2030; i++)
            {
                item = new ListItem(i.ToString());
                ddlAnio.Items.Add(item);
            }

            Label lblFechaFin = new Label();
            lblFechaFin.Text = "</br></br><i>¡Seleccione una fecha de fin!</i></br>";

            PlaceHolderContenido.Controls.Add(lblFechaFin);

            Label lblDiaFin = new Label();
            lblDiaFin.Text = " Día: ";
            DropDownList ddlDiaFin = new DropDownList();
            
            for (int i = 1; i <= 31; i++)
            {
                item = new ListItem(i.ToString());
                ddlDiaFin.Items.Add(item);
            }
            PlaceHolderContenido.Controls.Add(lblDiaFin);
            PlaceHolderContenido.Controls.Add(ddlDiaFin);


            Label lblMesFin = new Label();
            lblMesFin.Text = " Mes: ";
            DropDownList ddlMesFin = new DropDownList();
            for (int i = 1; i <= 12; i++)
            {
                item = new ListItem(i.ToString());
                ddlMesFin.Items.Add(item);
            }
            PlaceHolderContenido.Controls.Add(lblMesFin);
            PlaceHolderContenido.Controls.Add(ddlMesFin);

            Label lblAnioFin = new Label();
            lblAnioFin.Text = " Anio: ";
            DropDownList ddlAnioFin = new DropDownList();
            for (int i = 2022; i <= 2030; i++)
            {
                item = new ListItem(i.ToString());
                ddlAnioFin.Items.Add(item);
            }
            PlaceHolderContenido.Controls.Add(lblAnioFin);
            PlaceHolderContenido.Controls.Add(ddlAnioFin);

            Button btnEnviar = new Button();
            btnEnviar.Text = "Enviar";
            PlaceHolderContenido.Controls.Add(btnEnviar);

            Label lblTitulo2 = new Label();
            lblTitulo2.Text = "</br><h3>Agenda de eventos</h3></br>";
            PlaceHolderContenido.Controls.Add(lblTitulo2);

            //TODO: conectarse a la DB y obtener la tabla de 
            //eventos existentes, después mostrarlo en un gridview
            GridView gridView = new GridView()
            {
                AutoGenerateDeleteButton = true,
                AutoGenerateEditButton = true,
                
            };
            
            string cstr = @"server=VENTANAS10; database=SAES; integrated security = true";
            SqlConnection cnx = new SqlConnection(cstr);
            string query = "SELECT EVENTO AS 'EVENTO', FECHAINICIO AS 'FECHA DE INICIO', FECHAFIN AS 'FECHA FIN', SUSPENSIONLABORES'SUSPENSIÓN DE LABORES' FROM Agenda;";
            SqlDataAdapter adp = new SqlDataAdapter(query, cnx);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            cnx.Close();

            gridView.DataSource = ds.Tables[0];
            PlaceHolderContenido.Controls.Add((GridView)gridView);
            gridView.DataBind();

            
        }

        protected void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login/Login.aspx");
        }
    }
}