<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs"
    Inherits="SAES.Login.Login"
    MasterPageFile="~/Login/MasterPageLogin.Master"%>

<asp:Content runat="server" ID="ContentLoginInfoLogin" ContentPlaceHolderID="ContentPlaceHolder4">
    
    <main class ="LoginMain">    
        <div class="OpcionesLoginMain">
            <asp:Label ID="lblTitulo" runat="server" Text="Inicio de sesión"></asp:Label><br />
            <asp:Label ID="lblUsuario" runat="server" Text="Usuario: "></asp:Label><br />
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
            <asp:Label ID="lblPasswd" runat="server" Text="Contraseña: "></asp:Label><br />
            <asp:TextBox ID="txtpasswd" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnLogin" runat="server" Text="Iniciar Sesión" OnClick="btnLogin_Click"/><br />

            <asp:LinkButton ID="lbRecuperar" runat="server" Text="Recuperar Contraseña" OnClick="lbRecuperar_Click"></asp:LinkButton>
        </div>

        <div class="ContenidoLoginMain">            
            <asp:PlaceHolder ID="PlaceHolderContenido" runat="server"></asp:PlaceHolder>     
        </div>  
    </main>
</asp:Content>