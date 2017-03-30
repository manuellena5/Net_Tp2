<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UI.Web.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:Panel ID="gridPanel" runat="server" >
        <asp:GridView ID="gridview" runat="server" AutoGenerateColumns="False" SelectedRowStyle-BackColor="Black"
            SelectedRowStyle-ForeColor="White" DataKeyNames="ID" HeaderStyle-BackColor="#99ccff" OnSelectedIndexChanged="gridview_SelectedIndexChanged">
            <Columns>
                <asp:BoundField HeaderText="Codigo" DataField="id_usuario" />
                <asp:BoundField HeaderText="Codigo persona" DataField="id_persona" />
                <asp:BoundField HeaderText="Usuario" DataField="nombre_usuario" />
                <asp:BoundField HeaderText="Clave" DataField="clave" />
                <asp:BoundField HeaderText="Habilidado" DataField="habilitado" />
                <asp:BoundField HeaderText="Cambia Clave" DataField="cambia_clave" />
                <%--<asp:BoundField HeaderText="Tipo persona" DataField="tipo_persona"/>--%>
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </asp:Panel>

    <asp:Panel ID="formPanal" Visible="False" runat="server">

        <asp:Label ID="CodigoLabel" runat="server" Text="Codigo"></asp:Label>
        <asp:TextBox ID="txtidUsuario" runat="server"></asp:TextBox>      

        <asp:Label ID="habilitadoLabel" runat="server" Text="Habilitado"></asp:Label>
        <asp:CheckBox ID="Habilitado" runat="server"></asp:CheckBox><br/>

        <asp:Label ID="nombreLabel" runat="server" Text="Nombre" ></asp:Label>
        <asp:TextBox ID="txtnombre" runat="server" Enabled="false"></asp:TextBox>

       <%--  <asp:RequiredFieldValidator ID="rfvcandidate" runat="server" ControlToValidate ="txtnombre" ErrorMessage="Please choose a candidate" InitialValue="Please choose a candidate">   
       </asp:RequiredFieldValidator>
        <asp:ValidationSummary runat="server" HeaderText="There were errors on the page:" />--%>

        <asp:Label ID="apellidoLabel" runat="server" Text="Apellido" ></asp:Label>
        <asp:TextBox ID="txtapellido" runat="server" Enabled="false"></asp:TextBox>
        <asp:Button  Text=".....txtbuscar" runat="server" Width="16px" Height="22px"/>
        <br/>
        <asp:Label ID="usuarioLabel" runat="server" Text="Usuario"></asp:Label>
        <asp:TextBox ID="txtusuario" runat="server"></asp:TextBox>

        <asp:Label ID="ClaveLabel" runat="server" Text="Clave"></asp:Label>
        <asp:TextBox ID="txtclave" TextMode="Password" runat="server"></asp:TextBox>

        <asp:Label ID="repetirClveLabel" runat="server" Text="Repetir Clave"></asp:Label>
        <asp:TextBox ID="txtRepetirClave" TextMode="Password" runat="server"></asp:TextBox>
    </asp:Panel>
    <br/>
    <asp:Panel ID="gridActionPanel" runat="server">
        <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>&nbsp;&nbsp;
        <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>&nbsp;&nbsp;
         <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
    </asp:Panel>
    <br/>
    <asp:Panel ID="formActionPanel" runat="server">
        <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>&nbsp;&nbsp;
        <asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
    </asp:Panel>
</asp:Content>
