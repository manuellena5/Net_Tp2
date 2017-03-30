<%@ Page Title="" Language="C#" MasterPageFile="~/Formulario/Site.Master" AutoEventWireup="true" CodeBehind="frmdocentecurso.aspx.cs" Inherits="UI.Web.Formulario.frmdocentecurso" %>

<asp:Content ID="Content3" ContentPlaceHolderID="Contenidoprincipal" runat="server">
    <asp:Panel ID="gridPanel" runat="server">
        <link href="../CSS/datagridview.css" rel="stylesheet" />
        <asp:GridView ID="gridview" runat="server" AutoGenerateColumns="False" CssClass="mGrid" PagerStyle-CssClass="pgr" GridLines="None"
            AllowPaging="True" AlternatingRowStyle-CssClass="alt" PageSize="30" OnSelectedIndexChanged="gridview_SelectedIndexChanged">
            <Columns>
                <asp:BoundField HeaderText="Codigo Dictado" DataField="IdDictado" />
                <asp:BoundField HeaderText="Codigo Curso" DataField="IdCurso" />
                <asp:BoundField HeaderText="Codigo Docente" DataField="IdDocente" />
                <asp:BoundField HeaderText="Cargo" DataField="Cargo" />
                <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                <asp:BoundField HeaderText="Materia" DataField="Desc_Materia" />
                <asp:BoundField HeaderText="Comision" DataField="Desc_Comision" />
                <asp:CommandField HeaderText="Seleccionar" SelectText="Seleccionar" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>

        <asp:Panel ID="panelcaja" runat="server">
            <br />
            <br />
            
                <asp:Label ID="Lbldictado" runat="server" Text="Dictado" CssClass="cajatexto">
                    <asp:DropDownList ID="cblDictado" runat="server" Enabled="false">
                        <asp:ListItem>Cod Dictado</asp:ListItem>
                    </asp:DropDownList>
                    
                </asp:Label>
                <asp:Label ID="lblDocente" runat="server" Text="Docente" CssClass="cajatexto"></asp:Label>
                <asp:DropDownList ID="cblDocente" runat="server" CssClass="cajatexto" Enabled="false">
                </asp:DropDownList>

                <asp:Label ID="lblCurso" runat="server" Text="Curso" CssClass="cajatexto"></asp:Label>
                <asp:DropDownList ID="cblCurso" runat="server" CssClass="cajatexto" Enabled="false">
                </asp:DropDownList>

                <asp:Label ID="lblRol" runat="server" Text="Cargo" CssClass="cajatexto" ></asp:Label>
                <asp:DropDownList ID="cblCargo" runat="server"  CssClass="cajatexto"  Enabled="false">
                    <asp:ListItem>Titular</asp:ListItem>
                    <asp:ListItem>Auxiliar</asp:ListItem>
                    <asp:ListItem>JTP</asp:ListItem>
                </asp:DropDownList>
          
        </asp:Panel>


    </asp:Panel>
    <div>
        <br />
        <asp:Button ID="btncancelar" runat="server" Text="Cancelar" CssClass="button" Visible="false" OnClick="btncancelar_Click"></asp:Button>
        <asp:Button ID="btnaceptar" runat="server" Text="Aceptar" CssClass="button" ValidationGroup="alta" Visible="false" OnClick="btnaceptar_Click"></asp:Button>
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="button" Visible="false" OnClick="btnEliminar_Click"></asp:Button>
        <asp:Button ID="btnEditar" runat="server" Text="Editar" CssClass="button" Visible="false" OnClick="btnEditar_Click"></asp:Button>
        <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" CssClass="button" OnClick="btnNuevo_Click"></asp:Button>
    </div>
    <asp:Label ID="msgError" runat="server" ForeColor="Red"></asp:Label>
    <script type="text/javascript" src="../JSError/bootstrap.js"></script>
    <script type="text/javascript">
        $("[rel=tooltip]").tooltip();
        $(function () {
            $('.demo-cancel-click').click(function () { return false; });
        });
    </script>
</asp:Content>
