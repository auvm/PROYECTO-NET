<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profesor_Informacion_Personal.aspx.cs"
    Inherits="SAES.Profesores.Profesor_Profesor"
    MasterPageFile="~/Master/MasterPageProfesores.Master"%>

<asp:Content runat="server" ID="ContentProfesores" ContentPlaceHolderID="ContentPlaceHolder2">
    
    <main class ="ProfesoresMain">    
        <div class="OpcionesProfesoresMain">
            <ul>
                <li><asp:LinkButton ID="lbInfoPersonal" runat="server" Text="Información Personal" OnClick="lbInfoPersonal_Click"></asp:LinkButton></li>
                <li><asp:LinkButton ID="lbHorario" runat="server" Text="Horario" OnClick="lbHorario_Click"></asp:LinkButton></li>
                <li><asp:LinkButton ID="lbGrupos" runat="server" Text="Grupos" OnClick="lbGrupos_Click"></asp:LinkButton></li>
                <li><asp:LinkButton ID="lbCalificaciones" runat="server" Text="Calificaciones" OnClick="lbCalificaciones_Click"></asp:LinkButton></li>
                <li><asp:LinkButton ID="lblCerrarSesion" runat="server" Text="Cerrar Sesión"></asp:LinkButton></li>
            </ul>
        </div>

        <div class="ContenidoProfesoresMain">            
            <asp:PlaceHolder ID="PlaceHolderContenido" runat="server"></asp:PlaceHolder>     
        </div>  
    </main>
</asp:Content>
