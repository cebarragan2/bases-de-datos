<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Inicio.aspx.cs" Inherits="Paginas_Inicio" %>

<!DOCTYPE html>

<head runat="server">
<style type="text/css">
.normal {
  width: 250px;
  border: 1px solid #000;
}
.normal th, .normal td {
  border: 1px solid #000;
}
</style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table class="normal" >
      <th scope="col">Usuario</th>
    <th> 
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
      </th>
      <tr></tr>
        <th scope="col">Clave</th>
    <th> 
        <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
      </th>
 
    </table>
       <asp:Button ID="Button1" runat="server" Text="Entrar" 
        PostBackUrl="~/procesarLogin.aspx" />
    </div>
 
    </form>
</body>
</html>