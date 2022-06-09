<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Personal_Informacion_Personal.aspx.cs"
    Inherits="SAES.Personal.Personal_Informacion_Personal"
    MasterPageFile="~/Master/MasterPagePersonal.Master"%>

<asp:Content runat="server" ID="ContentAlumnosInfoPersonal" ContentPlaceHolderID="ContentPlaceHolder3">
    
    <main class ="PersonalMain">    
        <div class="OpcionesPersonalMain">
            <ul>
                <li><asp:LinkButton ID="lbInfoPersonal" runat="server" Text="Información Personal" OnClick="lbInfoPersonal_Click"></asp:LinkButton></li>
                <li><asp:LinkButton ID="lbPersonal" runat="server" Text="Personal" OnClick="lbPersonal_Click"></asp:LinkButton></li>
                <li><asp:LinkButton ID="lbProfesores" runat="server" Text="Profesores" OnClick="lbProfesores_Click"></asp:LinkButton></li>
                <li><asp:LinkButton ID="lblAlumnos" runat="server" Text="Alumnos" OnClick="lblAlumnos_Click"></asp:LinkButton></li>
                <li><asp:LinkButton ID="lblGrupos" runat="server" Text="Grupos" OnClick="lblGrupos_Click"></asp:LinkButton></li>
                
                <li><asp:LinkButton ID="lblCerrarSesion" runat="server" Text="Cerrar Sesión" OnClick="lblCerrarSesion_Click"></asp:LinkButton></li>
            </ul>
        </div>

        <div class="ContenidoPersonalMain">            
            <asp:PlaceHolder ID="PlaceHolderContenido" runat="server"></asp:PlaceHolder>     
        </div>  
    </main>
</asp:Content>
