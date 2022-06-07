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
            <asp:Label ID="lblTitulo" runat="server" Text="Información personal"></asp:Label><br />
            <h3>Foto:</h3>
                <asp:Image ID="imgPefil" runat="server" alt="imagen" CssClass="img"/><br /><br />
                <asp:Label ID="lblNombre" runat="server" Text="Nombre: "></asp:Label><br />
                <asp:Label ID="lblFechaNacimiento" runat="server" Text="Fecha de Nacimiento: "></asp:Label><br />
                <asp:Label ID="lblTelefono" runat="server" Text="Teléfono: "></asp:Label><br />
                <asp:Label ID="lblCorreo" runat="server" Text="Correo electrónico: "></asp:Label><br />
                <asp:Label ID="lblDirección" runat="server" Text="Dirección: "></asp:Label><br />
                                    
        </div>  
    </main>
</asp:Content>



