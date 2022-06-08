<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profesor_Ayuda.aspx.cs"
    Inherits="SAES.Profesores.Profesor_Ayuda" 
    MasterPageFile="~/Master/MasterPageProfesores.Master"%>

<asp:Content runat="server" ID="ContentProfesoresAyuda" ContentPlaceHolderID="ContentPlaceHolder2">
    
    <main class ="ProfesoresMain">    
        <div class="OpcionesProfesoresMain">
            <ul>
                <li><asp:LinkButton ID="lbAyudaGeneral" runat="server" Text="Ayuda General" OnClick="lbAyudaGeneral_Click"></asp:LinkButton></li>
                <li><asp:LinkButton ID="lblCerrarSesion" runat="server" Text="Cerrar Sesión"></asp:LinkButton></li>
            </ul>
        </div>

        <div class="ContenidoProfesoresMain">            
            <asp:PlaceHolder ID="PlaceHolderContenido" runat="server"></asp:PlaceHolder>     
                        
        </div>  
    </main>
</asp:Content>