<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alumno_Información Personal.aspx.cs"
    Inherits="SAES.Alumnos.Alumno_Información_Personal" 
    MasterPageFile="~/Master/MasterPageAlumnos.Master"%>

<asp:Content runat="server" ID="ContentAlumnosInfoPersonal" ContentPlaceHolderID="ContentPlaceHolder1">
    
    <main class ="AlumnosMain">    
        <div class="OpcionesAlumnosMain">
            <ul>
                <%--<li><a href="#">Información Personal</a></li>
                <li><a href="#">Horario</a></li>
                <li><a href="#">Calificaiones</a></li>
                <li><a href="#">Cerrar Sesión</a></li>--%>
                <li><asp:LinkButton ID="lbInfoPersonal" runat="server" Text="Información Personal" OnClick="lbInfoPersonal_Click"></asp:LinkButton></li>
                <li><asp:LinkButton ID="lbHorario" runat="server" Text="Horario" OnClick="lbHorario_Click"></asp:LinkButton></li>
                <li><asp:LinkButton ID="lbCalificaciones" runat="server" Text="Calificaciones" OnClick="lbCalificaciones_Click"></asp:LinkButton></li>
                <li><asp:LinkButton ID="lblCerrarSesion" runat="server" Text="Cerrar Sesión"></asp:LinkButton></li>
            </ul>
        </div>

        <div class="ContenidoAlumnosMain">            
            <asp:PlaceHolder ID="PlaceHolderContenido" runat="server"></asp:PlaceHolder>     
        </div>  
    </main>
</asp:Content>



