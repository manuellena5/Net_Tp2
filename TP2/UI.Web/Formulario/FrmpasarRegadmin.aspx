<%@ Page Title="" Language="C#" MasterPageFile="~/Formulario/Site.Master" AutoEventWireup="true" CodeBehind="FrmpasarRegadmin.aspx.cs" Inherits="UI.Web.Formulario.FrmpasarRegadmin" %>

<asp:Content ID="Content3" ContentPlaceHolderID="Contenidoprincipal" runat="server">
     <link href="../CSS/admstylo.css" rel="stylesheet" />
    <br />
    <br />
    <br />
    <br />
    <center>
        <div class="login" >
            <br />
            <div class="login_form">
                 <br />
             <h1>Buscar Por el nombre</h1>
          
            <asp:DropDownList ID="cblBuscar" runat="server" CssClass="cajatexto1" Enabled="true" Visible="true"  ></asp:DropDownList> 
            <asp:TextBox ID="txtnombre" runat="server" placeholder="Por nombre o Legajo" CssClass="login_un" Visible="true"></asp:TextBox>                            
            <asp:Button ID="btnaceptar" runat="server" Text="Aceptar" CssClass="login_btn"  ValidationGroup="alta" Visible="true"  OnClick="btnaceptar_Click" ></asp:Button>  
             <%--<asp:Label ID="labeldata" runat="server" Text="Codigo" placeholder="Codfio" Visible="true"></asp:Label>--%>
            
           </div>
          </div>
   </center>

</asp:Content>
