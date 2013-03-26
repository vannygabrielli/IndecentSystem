<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CO_MA_Deudor.aspx.cs" Inherits="WebApplication1.Ficheros.CO_MA_Deudor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style2
        {
            width: 109px;
            text-align: left;
        }
        .style5
        {
            width: 147px;
        }
        .style7
        {
            width: 86px;
            text-align: left;
        }
        .style9
        {
            width: 109px;
            text-align: left;
            height: 31px;
        }
        .style10
        {
            width: 147px;
            height: 31px;
        }
        .style11
        {
            width: 86px;
            text-align: left;
            height: 31px;
        }
        .style13
        {
            height: 31px;
        }
        .style14
        {
            width: 78px;
            text-align: left;
            height: 31px;
        }
        .style15
        {
            width: 78px;
            text-align: left;
        }
    .style17
    {
        color: #FFFFFF;
    }
        .style19
        {
            width: 72px;
        }
        .style20
        {
            width: 92px;
        }
        .style21
        {
            width: 106px;
        }
        .style22
        {
            height: 30px;
        }
        .style23
        {
            width: 109px;
            text-align: left;
            height: 33px;
        }
        .style24
        {
            width: 147px;
            height: 33px;
        }
        .style25
        {
            width: 86px;
            text-align: left;
            height: 33px;
        }
        .style26
        {
            width: 78px;
            text-align: left;
            height: 33px;
        }
        .style27
        {
            height: 33px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="ContenedorPrin">
    
    <div class="TituloPaginas">Datos Generales del Deudor</div>
    <br />
    <table border="0" style="width: 800px"  cellpadding="0" cellspacing="0" >
    <tr>
        <td class="style21"> <strong> Ingrese DNI :   </strong> </td>
        <td class="style19"><asp:TextBox ID="txt_dni" runat="server" Width="96px" 
                style="margin-left: 0px"></asp:TextBox>        </td>
        <td class="style20"><asp:Button ID="btn_Consultar" runat="server" Text="Consultar" 
                onclick="btn_Consultar_Click" />        </td>
                <td style="text-align: right">  
                <strong>
                    <asp:Label ID="lbl_mensaje" runat="server"></asp:Label>   
                </strong>
                        </td>
    </tr>
    <tr><td colspan="4">
    <hr />
    </td>
    </tr>
    </table>

    

    <table width ="800px">
     <tr>
    <td colspan ="6" class="style17"> .
                    <asp:Label ID="lbl_aviso" runat="server" Font-Bold="True" 
                        Font-Size="Medium" ForeColor="Red"></asp:Label>   
            </td>
    </tr>

        <tr>
            <td class="style9">
                Cartera</td>
            <td class="style10">
                <asp:TextBox ID="txt_cartera" runat="server" Width="72px" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="style11">
                Grupo</td>
            <td class="style10">
                <asp:TextBox ID="txt_grupo" runat="server" Width="58px" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="style14">
                Nro.Cuenta</td>
            <td class="style13">
                <asp:TextBox ID="txt_iddeuda" runat="server" Width="57px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Nro. Cuenta</td>
            <td class="style5">
                <asp:TextBox ID="txt_nro_cta" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="style7">
                Titular</td>
            <td class="style5">
                <asp:TextBox ID="txt_titular" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="style15">
                Cliente</td>
            <td>
                <asp:TextBox ID="txt_cliente" runat="server" Width="94px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Conyuge</td>
            <td class="style5">
                <asp:TextBox ID="txt_conyuge" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="style7">
                Est. Juducial</td>
            <td class="style5">
                <asp:TextBox ID="txt_est_judi" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="style15">
                Fec. Modif.</td>
            <td>
                <asp:TextBox ID="txt_fec_mod" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Situacion Deudor</td>
            <td class="style5">
                <asp:TextBox ID="txt_situ_deudor" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="style7">
                Situ. Deuda</td>
            <td class="style5">
                <asp:TextBox ID="txt_situ_deuda" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="style15">
                Calificacion</td>
            <td>
                <asp:TextBox ID="txt_calificacion" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style23">
                Aval</td>
            <td class="style24">
                <asp:TextBox ID="txt_aval" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="style25">
                </td>
            <td class="style24">
                </td>
            <td class="style26">
                Deuda Total</td>
            <td class="style27">
                <asp:TextBox ID="txt_deuda_total" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan = "6" align ="center">

            <table  cellpadding="2"  cellspacing ="0" width = "100%" border = "1"><tr>
                <td align="center" class="style22">
                <asp:Button ID="btn_deudas" runat="server" Text="Deudas" Width="90px" 
                    onclick="btn_deudas_Click" />
            
                <asp:Button ID="btn_pagos" runat="server" Text="Pagos" Width="90px" 
                    onclick="btn_pagos_Click" />
            
                <asp:Button ID="btn_telefono" runat="server" Text="Telefonos" Width="90px" 
                    onclick="btn_telefono_Click" />
            
                <asp:Button ID="btn_dir" runat="server" Text="Direcciones" Width="90px" 
                    onclick="btn_dir_Click" />
            
                <asp:Button ID="btn_llamadas" runat="server" Text="Llamadas" Width="90px" 
                    onclick="btn_llamadas_Click" />
            
                <asp:Button ID="btn_visitas" runat="server" Text="Visitas" Width="90px" 
                    onclick="btn_visitas_Click" />
                </td></tr>
                </table>
                </td>

        </tr>
    </table>


    <div class="" style="width: 800px; height: 132px;">
    <div class="" style="width: 800px; height: 30px;">
        <h2><asp:Label ID="lbl_Tit_Det" runat="server" Text="Informacion Detalle"></asp:Label>
        </h2>
    </div>
        <asp:GridView ID="gv_Detalle" runat="server" BackColor="White" 
            BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="1" 
            GridLines="Horizontal" Width="778px" Font-Size="Small" Height="62px">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <SortedAscendingCellStyle BackColor="#F4F4FD" />
            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
            <SortedDescendingCellStyle BackColor="#D8D8F0" />
            <SortedDescendingHeaderStyle BackColor="#3E3277" />
        </asp:GridView>
    </div>
    </div>
</asp:Content>
