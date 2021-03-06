﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Formulario/Site.master" AutoEventWireup="true" CodeBehind="frmprofesor.aspx.cs" Inherits="UI.Web.Formulario.frmprofesor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenidoprincipal" runat="server">
    
    <link href="../JsDataPicker/bootstrap.min.css" rel="stylesheet" />
    <link href="../JsDataPicker/font-awesome.min.css" rel="stylesheet" />
    <link href="../JsDataPicker/prettify-1.0.css" rel="stylesheet" />
    <%--<link href="../JsDataPicker/base.css"rel="stylesheet" />--%>
    <link href="../JsDataPicker/bootstrap-datetimepicker.css" rel="stylesheet" />


    <script src="../JsDataPicker/jquery-2.1.1.min.js"></script>
    <script src="../JsDataPicker/bootstrap.min.js"></script>



    <script src="../JsDataPicker/moment-with-locales.js"></script>
    <script src="../JsDataPicker/bootstrap-datetimepicker.min.js"></script>


    <%--<link href="../CSS/csslogin.css" rel="stylesheet" />--%>
    <asp:Panel runat="server">
        <asp:TextBox ID="txtbuscar" runat="server" CssClass="cajatexto" placeholder="Buscar por Legajo"></asp:TextBox>
        <asp:Button ID="btnbuscar" runat="server" Text="Buscar" CssClass="button1" OnClick="btnbuscar_Click"></asp:Button>
    </asp:Panel>
    <link href="../CSS/datagridview.css" rel="stylesheet" />
    <asp:GridView ID="gridview" runat="server" AutoGenerateColumns="False" CssClass="mGrid" PagerStyle-CssClass="pgr" GridLines="None"
        AllowPaging="True" AlternatingRowStyle-CssClass="alt" PageSize="80" OnSelectedIndexChanged="gridview_SelectedIndexChanged">
        <Columns>
            <asp:BoundField HeaderText="Codigo" DataField="Codigo" />
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
            <asp:BoundField HeaderText="Direccion" DataField="Direccion" />
            <asp:BoundField HeaderText="E-Mail" DataField="Email" Visible="true" />
            <asp:BoundField HeaderText="Telefono" DataField="Telefono" Visible="true" />
            <asp:BoundField HeaderText="Fecha Nac" DataField="Fecha_Nac" Visible="true" />
            <asp:BoundField HeaderText="Legajo" DataField="Legajo" Visible="true" />
            <asp:BoundField HeaderText="Acesso" DataField="Tipo_Persona" Visible="true" />
            <asp:BoundField HeaderText="Codigo Plan" DataField="Id_Plan" Visible="true" />
            <asp:BoundField HeaderText="Sexo" DataField="Sexo" Visible="false" />
            <asp:CommandField HeaderText="Seleccionar" SelectText="Selecionar" ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
    <center>
    <asp:Panel ID="estiloPanal" Visible="true" runat="server">
        <br />
        <div >
        <p class="corto">
            <asp:TextBox ID="txtidPersona" runat="server" placeholder="Codigo Persona" CssClass="cajatexto" ReadOnly="True"></asp:TextBox>
            <asp:TextBox ID="txtnombre" runat="server" CssClass="cajatexto" placeholder="Nombre" Enabled="false"></asp:TextBox>
            <asp:TextBox ID="txtapellido" runat="server" CssClass="cajatexto" placeholder="Apellido" Enabled="false"></asp:TextBox>
            <asp:TextBox ID="txtdireccion" runat="server" CssClass="cajatexto" placeholder="Direccion" Enabled="false"></asp:TextBox>
            <asp:TextBox ID="txtE_mail" runat="server" CssClass="cajatexto" placeholder="E-mail" Enabled="false"></asp:TextBox>
            <asp:TextBox ID="txttelefono" runat="server" CssClass="cajatexto" placeholder="Telefono" Enabled="false"></asp:TextBox>      
             <asp:TextBox ID="fec" runat="server" CssClass="cajatexto" placeholder="E-mail" Visible="false"></asp:TextBox>
            <asp:TextBox ID="TxtLegajo" runat="server" CssClass="cajatexto" placeholder="Legajo" Enabled="false"></asp:TextBox>
           
            <asp:DropDownList ID="CblSexo" runat="server" CssClass="cajatexto" Enabled="false" Width="201px">
                <asp:ListItem>Elegir Sexo</asp:ListItem>
                <asp:ListItem>M</asp:ListItem>
                <asp:ListItem>F</asp:ListItem>
            </asp:DropDownList>
             <asp:DropDownList ID="cblPlan" runat="server" CssClass="cajatexto" Enabled="false" OnSelectedIndexChanged="cblPlan_SelectedIndexChanged" Height="23px" Width="200px"></asp:DropDownList>
        </p>
              <div class="container">
    <div class="row">
        <div class='col-sm-6'>
            &nbsp;<input type='text'  class="cajatexto" ClientIDMode="Static" runat="server" id='datetimepicker4'/></div>
        </div>

        <script type="text/javascript">
            $(function () {
                $('#datetimepicker4').datetimepicker({
                    // dateFormat: 'dd-mm-yy',
                    //format: 'DD/MM/YYYY HH:mm:ss',
                    // minDate: getFormattedDate(new Date())
                    defaultDate: new Date(),
                    format: 'DD/MM/YYYY HH:mm'
                });
                //$('#datepicker').datepicker('option', { dateFormat: 'dd/mm/yy' });
            });
            /* function getFormattedDate(date) {
                 var day = date.getDate();
                 var month = date.getMonth() + 1;
                 var year = date.getFullYear().toString().slice(2);
                 return day + '-' + month + '-' + year;
             }*/
        </script>
    <%--</div>--%>
</div>
 </div>
    </asp:Panel>
    </center>
    <br />
    <br />

    <div>
        <asp:Button ID="btncancelar" runat="server" Text="Cancelar" CssClass="button" Visible="false" OnClick="btncancelar_Click"></asp:Button>
        <asp:Button ID="btnaceptar" runat="server" Text="Aceptar" CssClass="button" ValidationGroup="alta" Visible="false" OnClick="btnaceptar_Click"></asp:Button>
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="button" Visible="false" OnClick="btnEliminar_Click"></asp:Button>
        <asp:Button ID="btnEditar" runat="server" Text="Editar" CssClass="button" Visible="false" OnClick="btnEditar_Click"></asp:Button>
        <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" CssClass="button" OnClick="btnNuevo_Click"></asp:Button>
    </div>
    <br />
    <br />
    <br />
    <br />
    <div>
        <asp:Label ID="msgError" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Debe ingresar el nombre" ForeColor="Red" ValidationGroup="alta" ControlToValidate="txtnombre"></asp:RequiredFieldValidator><br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Debe ingresar el Apellido" ForeColor="Red" ValidationGroup="alta" ControlToValidate="txtapellido"></asp:RequiredFieldValidator><br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Debe ingresar la Direccion" ForeColor="Red" ValidationGroup="alta" ControlToValidate="txtdireccion"></asp:RequiredFieldValidator><br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Debe ingresar un Correo correcto" ForeColor="Red" ValidationGroup="alta" ControlToValidate="txtE_mail"></asp:RequiredFieldValidator><br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Debe ingresar el telefono" ForeColor="Red" ValidationGroup="alta" ControlToValidate="txttelefono"></asp:RequiredFieldValidator><br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Debe ingresar el Legajo" ForeColor="Red" ValidationGroup="alta" ControlToValidate="TxtLegajo"></asp:RequiredFieldValidator><br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Debe elegir el Plan" ForeColor="Red" ValidationGroup="alta" ControlToValidate="cblPlan"></asp:RequiredFieldValidator><br />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Ingresa un e_mail corecto como ese ejemplo&lt;d@.com&gt;" ForeColor="Red" ValidationGroup="alta" ControlToValidate="txtE_mail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <br />
    </div>
   
</asp:Content>
