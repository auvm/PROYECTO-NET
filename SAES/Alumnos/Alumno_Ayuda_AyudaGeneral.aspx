<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alumno_Ayuda_AyudaGeneral.aspx.cs"
    Inherits="SAES.Alumnos.Alumno_Ayuda_AyudaGeneral" 
    MasterPageFile="~/Master/MasterPageAlumnos.Master"%>

<asp:Content runat="server" ID="ContentAlumnosAyuda" ContentPlaceHolderID="ContentPlaceHolder1">
    
    <main class ="AlumnosMain">    
        <div class="OpcionesAlumnosMain">
            <ul>
                <li><asp:LinkButton ID="lbAyudaGeneral" runat="server" Text="Ayuda General" OnClick="lbAyudaGeneral_Click"></asp:LinkButton></li>
                <li><asp:LinkButton ID="lblCerrarSesion" runat="server" Text="Cerrar Sesión"></asp:LinkButton></li>
            </ul>
        </div>

        <div class="ContenidoAlumnosMain">            
            <asp:PlaceHolder ID="PlaceHolderContenido" runat="server"></asp:PlaceHolder>     
                        
        </div>  
    </main>
</asp:Content>