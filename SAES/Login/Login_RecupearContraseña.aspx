<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login_RecupearContraseña.aspx.cs"
    Inherits="SAES.Login.Login_RecupearContraseña" 
    MasterPageFile="~/Login/MasterPageLogin.Master"%>

<asp:Content runat="server" ID="ContentLoginInfoLogin" ContentPlaceHolderID="ContentPlaceHolder4">
    
    <main class ="LoginMain">    
        <div class="OpcionesLoginMain">
                
        </div>

        <div class="ContenidoLoginMain">            
            <asp:PlaceHolder ID="PlaceHolderContenido" runat="server"></asp:PlaceHolder>     
        </div>  
    </main>
</asp:Content>