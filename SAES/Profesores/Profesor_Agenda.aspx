<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profesor_Agenda.aspx.cs"
    Inherits="SAES.Profesores.Profesor_Agenda" 
    MasterPageFile="~/Master/MasterPageProfesores.Master"%>

<asp:Content runat="server" ID="ContentProfesoresAgenda" ContentPlaceHolderID="ContentPlaceHolder2">
    
    <main class ="ProfesoresMain">    
        <div class="OpcionesProfesoresMain">
            <ul>
                <li><asp:LinkButton ID="lbAgendaEscolar" runat="server" Text="Agenda Escolar" OnClick="lbAgendaEscolar_Click"></asp:LinkButton></li>
                <li><asp:LinkButton ID="lblCerrarSesion" runat="server" Text="Cerrar Sesión"></asp:LinkButton></li>
            </ul>
        </div>

        <div class="ContenidoProfesoresMain">            
            <asp:PlaceHolder ID="PlaceHolderContenido" runat="server"></asp:PlaceHolder>     

        </div>  


    </main>
</asp:Content>