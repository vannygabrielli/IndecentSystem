<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lista_Usuario.aspx.cs" Inherits="WebApplication1.Paginas.Lista_Usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style3
        {
            height: 290px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table  width="800px">
    <tr>
        <td>
           <div style="border: thin solid #808080; width: 800px; text-align: center; height: 50px; ">
    <h1>
    Lista de Usuario
    </h1>
    </div>

            </td>
    </tr>
    <tr>
        <td class="style3">
            <asp:GridView ID="gv_lista_usu" runat="server" CellPadding="4" 
                Width="557px" DataSourceID="EntityDataSource1" Height="253px" 
                PageIndex="10" AutoGenerateColumns="False" ForeColor="#333333" 
                GridLines="None" DataKeyNames="ID">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" 
                        SortExpression="ID" />
                    <asp:BoundField DataField="LOGIN" HeaderText="LOGIN" SortExpression="LOGIN" />
                    <asp:BoundField DataField="PWD" HeaderText="PWD" SortExpression="PWD" />
                    <asp:BoundField DataField="DESCRIPCION" HeaderText="DESCRIPCION" 
                        SortExpression="DESCRIPCION" />
                    <asp:BoundField DataField="NOMBRES" HeaderText="NOMBRES" 
                        SortExpression="NOMBRES" />
                    <asp:BoundField DataField="ESTADO" HeaderText="ESTADO" 
                        SortExpression="ESTADO" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle ForeColor="#333333" BackColor="#F7F6F3" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <asp:EntityDataSource ID="EntityDataSource1" runat="server" 
                ConnectionString="name=DBProyectoEntities" 
                DefaultContainerName="DBProyectoEntities" EnableDelete="True" 
                EnableFlattening="False" EnableUpdate="True" EntitySetName="CO_USUARIO">
            </asp:EntityDataSource>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="btn_nuevo" runat="server" onclick="btn_nuevo_Click" 
                Text="Nuevo Usuario..." />
        </td>
    </tr>
</table>
</asp:Content>
