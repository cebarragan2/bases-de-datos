<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Menu.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>ASP.NET</title>
    <link href="../Estilo%20CSS/Estilo.css" rel="stylesheet" />
    <style type="text/css">
        #form1 {
            height: 451px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div id="menu">
            <ul>
                <li><a href="#">Foraneos</a></li>
                <li><a href="#">Servicios</a>
                    <ul>
                        <li><a href="#">Entradas</a></li>
                        <li><a href="#">Alojamiento</a></li>
                        <li><a href="#">Restauracion</a></li>
                        <li><a href="#">Transporte</a></li>
                        <li><a href="#">Eventos</a></li>
                    </ul>
                </li>
                <li><a <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Registrar.aspx">Empresa</asp:HyperLink></a></li>
                <li><a <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Registrar.aspx">Contacto</asp:HyperLink></a></li>
                <li><a <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Paginas/Inicio.aspx">Iniciar Sesión</asp:HyperLink></a></li>
                <li><a <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Paginas/Registrar.aspx">Registrarse</asp:HyperLink></a></li>

            </ul>

        </div>
        <p>
            <site_headerr>
                <h4>&nbsp;</h4>
        <h4>&nbsp;</h4>
        <h4>BASES DE DATOS</h4>
        <p>&nbsp;</p>
                <h2>FORANEOS AEROLINE</h2>
            </site_headerr>
        </p>

    </form>
</body>
</html>
