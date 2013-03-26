<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InicioLogin.aspx.cs" Inherits="WebApplication1.Paginas.InicioLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
 
<head runat="server">

    <title>Login</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            height: 47px;
        }
        .style4
        {
            height: 79px;
        }
        .login
        {
            width: 334px;
        }
        .style5
        {
            height: 36px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
     <div class="page">
       <div class="header">
       
       <div >
                <h1>
                    WSCobranzasoft DSD</h1>
            </div>
       </div>
         
      <div class="main">
    <div>
    <br />
     <h2>
        Iniciar sesión
    </h2>
    <p>
        Especifique su nombre de usuario y contraseña.
        </p>

     <fieldset class="login">
      <legend>Información de cuenta</legend>
     
     <table class="style1">
    <tr>
        <td class="style4">
            Nombre de usuario : <br />
            <asp:TextBox ID="txt_Login" runat="server" Width="281px"></asp:TextBox>
            </td>
        
    </tr>
    <tr>
        <td class="style4">
            Contraseña :<br />
            <asp:TextBox ID="txt_pwd" runat="server" TextMode="Password" Width="281px"></asp:TextBox>
            </td>
        
    </tr>
    
</table>
 
</fieldset> 
<p style="width: 363px; text-align: right">
    <asp:Button ID="btn_Aceptar" runat="server" onclick="btn_Aceptar_Click" 
                Text="Iniciar Sesion" Width="144px" />
                </p>
                <p>
                
                    <asp:Label ID="lbl_mensaje" runat="server" Font-Bold="True" 
                        Font-Size="Medium" ForeColor="Red"></asp:Label>
                </p>
    </div>
   </div>

   </div>
    </form>
</body>
</html>
