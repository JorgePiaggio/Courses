<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarProductos.aspx.cs" Inherits="WebAppProducto.ListarProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnInsertar" runat="server" Text="Insertar Producto" OnClick="btnInsertar_Click" Height="26px" Width="163px" />
        <p>
        <asp:Button ID="btnModificar" runat="server" Text="Modificar Producto" OnClick="btnModificar_Click" />
        </p>
        <p>
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar Producto" Height="24px" OnClick="btnEliminar_Click" Width="163px" />
        </p>
        <asp:Button ID="btnAgregarCategoria" runat="server" Text="Agregar Categoria" OnClick="btnAgregarCategoria_Click" />
        <p>
            <asp:Button ID="btnModificarCategoria" runat="server" Text="Modificar Categoria" OnClick="btnModificarCategoria_Click" />
        </p>
        <asp:Button ID="btnEliminarCategoria" runat="server" Text="Eliminar Categoria" OnClick="btnEliminarCategoria_Click" />
    </form>
</body>
</html>
