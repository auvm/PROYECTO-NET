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
    public partial class Personal_Informacion_Personal : System.Web.UI.Page
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

        protected void lbInfoPersonal_Click(object sender, EventArgs e)
        {
            Label lblTitulo = new Label();
            lblTitulo.Text = "<h3>Información Personal</h3><br/>";
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
            
            string cstr = @"server=VENTANAS10; database=SAES; integrated security = true";
            SqlConnection cnx = new SqlConnection(cstr);
            string query = "SELECT * FROM administrativo;";
            SqlDataAdapter adp = new SqlDataAdapter(query, cnx);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            cnx.Close();

            lblNombre.Text = "<br/>Nombre: " + nombre + ds.Tables[0].Rows[0]["Nombre"] + " "
                                                      + ds.Tables[0].Rows[0]["ApellidoP"] + " "
                                                      + ds.Tables[0].Rows[0]["ApellidoM"] + " "
                            + "<br/>";

            lblFechaNacimiento.Text = "Fecha de Nacimiento: " + fechaNacimiento + ds.Tables[0].Rows[0]["FechaNacimiento"] + "<br/>";
            lblTelefono.Text = "Teléfono: " + telefono + ds.Tables[0].Rows[0]["Telefono"] + "<br/>";
            lblCorreo.Text = "Correo Electrónico: " + correo + ds.Tables[0].Rows[0]["Correo"] + "<br/>";
            lblDireccion.Text = "Dirección: " + direccion + ds.Tables[0].Rows[0]["Direccion"] + "<br/>";

            PlaceHolderContenido.Controls.Add(lblNombre);
            PlaceHolderContenido.Controls.Add(lblFechaNacimiento);
            PlaceHolderContenido.Controls.Add(lblTelefono);
            PlaceHolderContenido.Controls.Add(lblCorreo);
            PlaceHolderContenido.Controls.Add(lblDireccion);

        }


        protected void lbPersonal_Click(object sender, EventArgs e)
        {
            Label lblTitulo = new Label();
            lblTitulo.Text = "<h3>Personal</h3><br/>";
            PlaceHolderContenido.Controls.Add(lblTitulo);
        }

        protected void lbProfesores_Click(object sender, EventArgs e)
        {
            Label lblTitulo = new Label();
            lblTitulo.Text = "<h3>Profesores</h3><br/>";
            PlaceHolderContenido.Controls.Add(lblTitulo);
        }

        protected void lblAlumnos_Click(object sender, EventArgs e)
        {
            Label lblTitulo = new Label();
            lblTitulo.Text = "<h3>Alumnos</h3><br/>";
            PlaceHolderContenido.Controls.Add(lblTitulo);
        }

        public void lblGrupos_Click(object sender, EventArgs e)
        {
            Label lblTitulo = new Label();
            lblTitulo.Text = "<h3>Grupos</h3><br/>";
            PlaceHolderContenido.Controls.Add(lblTitulo);

            Label lblDescripcion = new Label();
            lblDescripcion.Text = "<p>Para crear un nuevo grupo ingrese los siguientes datos, luego " +
                                            "presione 'Crear'.</p></br>";
            PlaceHolderContenido.Controls.Add(lblDescripcion);

            Label lblSecuencia = new Label();
            lblSecuencia.Text = "Secuencia: ";
            PlaceHolderContenido.Controls.Add(lblSecuencia);
            TextBox txtSecuencia = new TextBox();
            PlaceHolderContenido.Controls.Add(txtSecuencia);

            Label lblNombreSecuencia = new Label();
            lblNombreSecuencia.Text = "  Nombre de la Materia: ";
            PlaceHolderContenido.Controls.Add(lblNombreSecuencia);
            TextBox txtNombreSecuencia = new TextBox();
            PlaceHolderContenido.Controls.Add(txtNombreSecuencia);

            Button btnCrear = new Button()
            {
                Text = "Crear"
                
            };
                       

            //void Enviar(){
            //    string nombreSecuencia = txtSecuencia.Text;
            //    string nombreMateria = txtNombreSecuencia.Text;
            //    string query2 = $"INSERT INTO Grupos(Secuencia, Materia) VALUES ( '{nombreSecuencia}', '{nombreMateria}');";
            //    string cstr2 = @"server=VENTANAS10; database=Base; integrated security = true";
            //    SqlConnection cnx2 = new SqlConnection(cstr2);
            //    cnx2.Open();
            //    SqlCommand cmd = new SqlCommand(query2, cnx);
            //    cmd.ExecuteNonQuery();
            //    cnx2.Close();
            //}


            PlaceHolderContenido.Controls.Add((Button)btnCrear);
            //TODO: Conextar a la BD, tomar la secuencia y el nombre del grupo a crear
            //de los texbox y mandar a crear el grupo en la BD.

            
                
            


            //------------Parte Modificar grupo

            Label lblDescripcion2 = new Label();
            lblDescripcion2.Text = "</br><p>Para asignar alumnos y un profesor al grupo creado, primero selecione un grupo" +
                                  "luego en 'Modificar'.</p></br>";
            PlaceHolderContenido.Controls.Add(lblDescripcion2);

            DropDownList ddlGrupos = new DropDownList();

            string cstr = @"server=VENTANAS10; database=SAES; integrated security = true";
            SqlConnection cnx = new SqlConnection(cstr);
            string query = "SELECT * FROM Grupos;";
            SqlDataAdapter adp = new SqlDataAdapter(query, cnx);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            cnx.Close();

            int num = ds.Tables[0].Rows.Count;
            for(int i = 0; i < num; i++)
            {
                string cadena = ds.Tables[0].Rows[i]["Secuencia"] + " - " + ds.Tables[0].Rows[i]["Materia"];
                ddlGrupos.Items.Add(new ListItem(cadena));
            }
                        
            PlaceHolderContenido.Controls.Add(ddlGrupos);

            Button btnModificar = new Button();
            btnModificar.Text = "Modificar";
            PlaceHolderContenido.Controls.Add((Button)btnModificar);

            //TODO: Conecatar a la BD, tomar el grupo seleccionado del dropdownlist y mostrarlo a un
            //data gridview, con opción de modificar y eliminar alumnos y el profesor mostrarlo en un 
            //campo aparte 

            

        }

        protected void lbHorario_Click(object sender, EventArgs e)
        {

        }

        protected void lbCalificaciones_Click(object sender, EventArgs e)
        {

        }

        protected void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login/Login.aspx");
        }
    }
}