<%@ Page Title="" Language="C#" MasterPageFile="~/Formulario/Site.Master" AutoEventWireup="true" CodeBehind="frmregularidad.aspx.cs" Inherits="UI.Web.Formulario.frmregularidad" %>

<asp:Content ID="Content3" ContentPlaceHolderID="Contenidoprincipal" runat="server">
    <link href="../CSS/datagridview.css" rel="stylesheet" />
    <asp:GridView ID="gridview" runat="server" AutoGenerateColumns="False" CssClass="mGrid" PagerStyle-CssClass="pgr" GridLines="None"
        AllowPaging="True" AlternatingRowStyle-CssClass="alt" PageSize="80" OnSelectedIndexChanged="gridview_SelectedIndexChanged">
        <Columns>
            <asp:BoundField HeaderText="Codigo Inscripcion" DataField="IdInscripcion" />
            <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Comision" DataField="Desc_Comision" />
            <asp:BoundField HeaderText="Condicion" DataField="Condicion" />
            <asp:BoundField HeaderText="Codigo Curso" DataField="IdCurso" />
            <asp:BoundField HeaderText="Codigo Alumno" DataField="IdAlumnos" />
            <asp:CommandField HeaderText="Seleccionar" SelectText="Pasar Regularidad" ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
    <center>
        <asp:Panel ID="estiloPanal" Visible="true" runat="server">
            <br />
            <p class="corto">
            <asp:TextBox ID="txtidIscripto" runat="server" placeholder="Codigo Inscripto" CssClass="cajatexto" ReadOnly="True" Enabled="false"></asp:TextBox>                 
                 <asp:TextBox ID="txtidCurso" runat="server" CssClass="cajatexto" placeholder="Codigo Curso" ReadOnly="True" Enabled="false"></asp:TextBox>        
                 <asp:TextBox ID="txtidAlumno" runat="server" CssClass="cajatexto" ReadOnly="True" placeholder="Codigo Alumno" Enabled="false"></asp:TextBox>
                <asp:Label ID="LabelPlan" runat="server" Text="Condicion" CssClass="cajatexto" ReadOnly="True" Enabled="false"></asp:Label>              
                <asp:DropDownList ID="cblregular" runat="server" CssClass="cajatexto" Enabled="false">
                    <asp:ListItem>Seleccionar Condicion</asp:ListItem>
                    <asp:ListItem>Regular</asp:ListItem>
                    <asp:ListItem>Libre</asp:ListItem>
                </asp:DropDownList> 
                </p>
        </asp:Panel>
   </center>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <div>
        <asp:Button ID="btncancelar" runat="server" Text="Cancelar" CssClass="button" Visible="false"></asp:Button>
        <asp:Button ID="btnaceptar" runat="server" Text="Aceptar" CssClass="button" ValidationGroup="alta" Visible="false" OnClick="btnaceptar_Click"></asp:Button>
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="button" Visible="false"></asp:Button>
        <asp:Button ID="btnEditar" runat="server" Text="Editar" CssClass="button" Visible="false" OnClick="btnEditar_Click"></asp:Button>
        <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" CssClass="button" Visible="false"></asp:Button>

    </div>
    <br />
    <br />
    <br />
    <br />
    <div>
        <asp:Label ID="msgError" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txthorasemales" ErrorMessage="Debe ingresar la cantidad de hora semanal" ForeColor="Red" ValidationGroup="alta"></asp:RequiredFieldValidator>--%>
        <br />
    </div>
</asp:Content>
