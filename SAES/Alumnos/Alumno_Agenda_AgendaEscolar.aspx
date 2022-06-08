<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alumno_Agenda_AgendaEscolar.aspx.cs"
    Inherits="SAES.Alumnos.WebForm1"
    MasterPageFile="~/Master/MasterPageAlumnos.Master"%>

<asp:Content runat="server" ID="ContentAlumnosAgenda" ContentPlaceHolderID="ContentPlaceHolder1">
    
    <main class ="AlumnosMain">    
        <div class="OpcionesAlumnosMain">
            <ul>
                <li><asp:LinkButton ID="lbAgendaEscolar" runat="server" Text="Agenda Escolar" OnClick="lbAgendaEscolar_Click"></asp:LinkButton></li>
                <li><asp:LinkButton ID="lblCerrarSesion" runat="server" Text="Cerrar Sesión"></asp:LinkButton></li>
            </ul>
        </div>

        <div class="ContenidoAlumnosMain">            
            <asp:PlaceHolder ID="PlaceHolderContenido" runat="server"></asp:PlaceHolder>     

        </div>  


    </main>
</asp:Content>

