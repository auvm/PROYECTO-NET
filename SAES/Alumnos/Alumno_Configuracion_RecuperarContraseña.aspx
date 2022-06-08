<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alumno_Configuracion_RecuperarContraseña.aspx.cs"
    Inherits="SAES.Alumnos.Alumno_Configuracion_RecuperarContraseña"
    MasterPageFile="~/Master/MasterPageAlumnos.Master"%>

<asp:Content runat="server" ID="ContentAlumnosConfiguracion" ContentPlaceHolderID="ContentPlaceHolder1">
    
    <main class ="AlumnosMain">    
        <div class="OpcionesAlumnosMain">
            <ul>
                <li><asp:LinkButton ID="lbRecuperar" runat="server" Text="Recuperar Contraseña" OnClick="lbRecuperar_Click"></asp:LinkButton></li>
                <li><asp:LinkButton ID="lbCambiar" runat="server" Text="Cambiar Contraseña" OnClick="lbCambiar_Click"></asp:LinkButton></li>
                <li><asp:LinkButton ID="lblCerrarSesion" runat="server" Text="Cerrar Sesión"></asp:LinkButton></li>
            </ul>
        </div>

        <div class="ContenidoAlumnosMain">            
            <asp:PlaceHolder ID="PlaceHolderContenido" runat="server"></asp:PlaceHolder>     
            
            
        </div>  
    </main>
</asp:Content>