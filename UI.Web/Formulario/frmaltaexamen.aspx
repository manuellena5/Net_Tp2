<%@ Page Title="" Language="C#" MasterPageFile="~/Formulario/Site.Master" AutoEventWireup="true" CodeBehind="frmaltaexamen.aspx.cs" Inherits="UI.Web.Formulario.frmaltaexamen" %>
<asp:Content ID="Content3" ContentPlaceHolderID="Contenidoprincipal" runat="server">
     <center><h3> Elegir una comision</h3></center>
    <asp:GridView ID="gridview" runat="server" AutoGenerateColumns="False" CssClass="mGrid" PagerStyle-CssClass="pgr" GridLines="None"
        AllowPaging="True" AlternatingRowStyle-CssClass="alt" PageSize="80" OnSelectedIndexChanged="gridview_SelectedIndexChanged">
        <Columns>
            <asp:BoundField HeaderText="Codigo Curso" DataField="IdCurso" />
            <asp:BoundField HeaderText="Comision" DataField="Desc_Comision" />
            <%--   <asp:BoundField HeaderText="Codigo Comision" DataField="IdComision"/>
                 <asp:BoundField HeaderText="Comision" DataField="Desc_comision"/>
                <asp:BoundField HeaderText="Año Calendario" DataField="AnioCalendario"/>
                <asp:BoundField HeaderText="Cupo" DataField="Cupo"/>--%>
            <asp:CommandField HeaderText="Seleccionar" SelectText="Inscribir" ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
</asp:Content>
