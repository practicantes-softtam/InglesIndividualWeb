<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="InglesIndividual.Web.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ingles Individual</title>
    <link href="css/default-page.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div id="container">
        <form id="form1" runat="server">
            <div class="header"></div>
            <div class="body">
                <div class="logo"><img src="images/logo-login.png" alt="Logo Inglés Individual" style="width:300px" /></div>
                <div class="login-container">
                    <div class="title">CONTROL ESCOLAR</div>
                    <table>
                        <tr>
                            <td class="etiqueta">USUARIO</td><td><asp:TextBox runat="server" ID="uiEmail" CssClass="login-textbox"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td class="etiqueta">CONTRASEÑA</td>
                            <td><asp:TextBox runat="server" ID="uiPassword" CssClass="login-textbox" TextMode="Password"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td colspan="2"><asp:Button runat="server" ID="uiAceptar" CssClass="login-button" Text="Ingresar"/></td>
                        </tr>
                    </table>
                </div>
            </div>
            <div class="footer"></div>
        </form>
    </div>
</body>
</html>
