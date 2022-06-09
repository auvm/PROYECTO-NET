<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Personal_Ayuda.aspx.cs"
    Inherits="SAES.Personal.Personal_Ayuda"
    MasterPageFile="~/Master/MasterPagePersonal.Master"%>

<asp:Content runat="server" ID="ContentPersonalAyuda" ContentPlaceHolderID="ContentPlaceHolder3">
    
    <main class ="PersonalMain">    
        <div class="OpcionesPersonalMain">
            <ul>
                
                <li><asp:LinkButton ID="lblCerrarSesion" runat="server" Text="Cerrar Sesión" OnClick="lblCerrarSesion_Click"></asp:LinkButton></li>
            </ul>
        </div>

        <div class="ContenidoPersonalMain">            
            <asp:PlaceHolder ID="PlaceHolderContenido" runat="server"></asp:PlaceHolder>     
                        
        </div>  
    </main>
</asp:Content>