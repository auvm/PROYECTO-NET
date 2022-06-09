<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Personal_Configuracion.aspx.cs"
    Inherits="SAES.Personal.Personal_Configuracion"
    MasterPageFile="~/Master/MasterPagePersonal.Master"%>

<asp:Content runat="server" ID="ContentPersonalConfiguracion" ContentPlaceHolderID="ContentPlaceHolder3">
    
    <main class ="PersonalMain">    
        <div class="OpcionesPersonalMain">
            <ul>
                <li><asp:LinkButton ID="lbRecuperar" runat="server" Text="Recuperar Contraseña" OnClick="lbRecuperar_Click"></asp:LinkButton></li>
                <li><asp:LinkButton ID="lbCambiar" runat="server" Text="Cambiar Contraseña" OnClick="lbCambiar_Click"></asp:LinkButton></li>
                <li><asp:LinkButton ID="lblCerrarSesion" runat="server" Text="Cerrar Sesión" OnClick="lblCerrarSesion_Click"></asp:LinkButton></li>
            </ul>
        </div>

        <div class="ContenidoPersonalMain">            
            <asp:PlaceHolder ID="PlaceHolderContenido" runat="server"></asp:PlaceHolder>     
            
            
        </div>  
    </main>
</asp:Content>