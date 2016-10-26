<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Vehiculo.aspx.cs" Inherits="TiendaWeb.Vehiculo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Entidad Vehiculo</h1>
        <asp:Label ID="lblIdentificador" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="lblPlaca" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="lblColor" runat="server" Text="Label"></asp:Label>

        <h1>Listado de vehículos</h1>
        <asp:GridView ID="grvVehiculos" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
