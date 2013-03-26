<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reg_Usuario.aspx.cs" Inherits="WebApplication1.Paginas.Reg_Usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
    {
        width: 36%;
        height: 127px;
    }
    .style3
    {
            width: 193px;
        }
        .style4
        {
            text-align: left;
            font-weight: bold;
            width: 134px;
        }
        .style5
        {
            text-align: left;
            font-weight: bold;
            height: 31px;
            width: 134px;
        }
        .style6
        {
            width: 193px;
            height: 31px;
        }
        .style7
        {
            height: 50px;
        }
        .style8
        {
            height: 41px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div style="border: thin solid #808080; width: 800px; text-align: center; height: 50px; ">
    <h1>
    Registro de Usuario
    </h1>
    </div>
    <p></p>
    <div style="padding: 20px; border: thin solid #808080; width: 760px; text-align: center; height: 200px; ">

    <table class="style1">
    <tr>
        <td class="style4">
            Login</td>
        <td class="style3">
            <asp:TextBox ID="txt_login" runat="server" style="margin-left: 0px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style4">
            Password</td>
        <td class="style3">
            <asp:TextBox ID="txt_pwd" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style4">
            Confirmar Pwd</td>
        <td class="style3">
            <asp:TextBox ID="txt_pwd2" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style5">
            Descripcion</td>
        <td class="style6">
            <asp:TextBox ID="txt_des" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style5">
            Nombres</td>
        <td class="style6">
            <asp:TextBox ID="txt_nombres" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2" style="text-align: center" class="style7">
            <asp:Button ID="btn_Aceptar" runat="server" onclick="btn_Aceptar_Click" 
                Text="Aceptar" Width="89px" />
            <asp:Button ID="btn_cancelar" runat="server" Text="Cancelar" 
                onclick="btn_cancelar_Click" Width="85px" />
        </td>
    </tr>
    <tr>
        <td colspan="2" style="text-align: center" class="style8">
            <asp:Label ID="lbl_Mensaje" runat="server" ForeColor="Red"></asp:Label>
        </td>
    </tr>
</table>

</div>
</asp:Content>
