<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profesor_Configuracion.aspx.cs"
    Inherits="SAES.Profesores.Profesor_Configuracion"
    MasterPageFile="~/Master/MasterPageProfesores.Master"%>

<asp:Content runat="server" ID="ContentProfesoresConfiguracion" ContentPlaceHolderID="ContentPlaceHolder2">
    
    <main class ="ProfesoresMain">    
        <div class="OpcionesProfesoresMain">
            <ul>
                <li><asp:LinkButton ID="lbRecuperar" runat="server" Text="Recuperar Contraseña" OnClick="lbRecuperar_Click"></asp:LinkButton></li>
                <li><asp:LinkButton ID="lbCambiar" runat="server" Text="Cambiar Contraseña" OnClick="lbCambiar_Click"></asp:LinkButton></li>
                <li><asp:LinkButton ID="lblCerrarSesion" runat="server" Text="Cerrar Sesión"></asp:LinkButton></li>
            </ul>
        </div>

        <div class="ContenidoProfesoresMain">            
            <asp:PlaceHolder ID="PlaceHolderContenido" runat="server"></asp:PlaceHolder>     
            
            
        </div>  
    </main>
</asp:Content>