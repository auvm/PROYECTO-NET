<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Personal_Informacion_Personal.aspx.cs"
    Inherits="SAES.Personal.Personal_Informacion_Personal"
    MasterPageFile="~/Master/MasterPagePersonal.Master"%>

<asp:Content runat="server" ID="ContentPersonalInfoPersonal" ContentPlaceHolderID="ContentPlaceHolder3">
    
    <main class ="PersonalMain">    
        <div class="OpcionesPersonalMain">
            <ul>
                <li><asp:LinkButton ID="lbInfoPersonal" runat="server" Text="Información Personal" OnClick="lbInfoPersonal_Click"></asp:LinkButton></li>
                <li><asp:LinkButton ID="lbHorario" runat="server" Text="Horario" OnClick="lbHorario_Click"></asp:LinkButton></li>
                <li><asp:LinkButton ID="lbCalificaciones" runat="server" Text="Calificaciones" OnClick="lbCalificaciones_Click"></asp:LinkButton></li>
                <li><asp:LinkButton ID="lblCerrarSesion" runat="server" Text="Cerrar Sesión"></asp:LinkButton></li>
            </ul>
        </div>

        <div class="ContenidoPersonalMain">            
            <asp:PlaceHolder ID="PlaceHolderContenido" runat="server"></asp:PlaceHolder>     
        </div>  
    </main>
</asp:Content>



