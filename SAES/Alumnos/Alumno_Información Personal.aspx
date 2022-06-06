<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alumno_Información Personal.aspx.cs"
    Inherits="SAES.Alumnos.Alumno_Información_Personal" 
    MasterPageFile="~/Master/MasterPageAlumnos.Master"%>

<asp:Content runat="server" ID="ContentAlumnosInfoPersonal" ContentPlaceHolderID="ContentPlaceHolder1">
    <main class ="AlumnosMain">
        <div class="OpcionesAlumnosMain">
            <ul>
                <li><a href="#">Información Personal</a></li>
                <li><a href="#">Horario</a></li>
                <li><a href="#">Calificaiones</a></li>
                <li><a href="#">Cerrar Sesión</a></li>
            </ul>
        </div>
        <div class="ContenidoAlumnosMain">
            <h2>Contenido principal</h2>
        </div>
    </main>
</asp:Content>



