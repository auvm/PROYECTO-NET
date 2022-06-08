<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Personal_Agenda.aspx.cs"
    Inherits="SAES.Personal.Personal_Agenda"
    MasterPageFile="~/Master/MasterPagePersonal.Master"%>

<asp:Content runat="server" ID="ContentPersonalAgenda" ContentPlaceHolderID="ContentPlaceHolder3">
    
    <main class ="PersonalMain">    
        <div class="OpcionesPersonalMain">
            <ul>
                <li><asp:LinkButton ID="lbAgendaEscolar" runat="server" Text="Agenda Escolar" OnClick="lbAgendaEscolar_Click"></asp:LinkButton></li>
                <li><asp:LinkButton ID="lblCerrarSesion" runat="server" Text="Cerrar Sesión"></asp:LinkButton></li>
            </ul>
        </div>

        <div class="ContenidoPersonalMain">            
            <asp:PlaceHolder ID="PlaceHolderContenido" runat="server"></asp:PlaceHolder>     

        </div>  


    </main>
</asp:Content>