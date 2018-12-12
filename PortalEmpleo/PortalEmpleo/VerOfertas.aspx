<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerOfertas.aspx.cs" Inherits="PortalEmpleo.VerOfertas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    	<asp:ListView ID="ListView1" runat="server" DataSourceID="ConsultaOfertas">
		</asp:ListView>
		<asp:SqlDataSource ID="ConsultaOfertas" runat="server" ConnectionString="<%$ ConnectionStrings:PortalEmpleoConnectionString %>" SelectCommand="SELECT [OfTitulo], [OfPuesto], [OfArea], [OfFechaFin], [OfVacante] FROM [OfertaLaboral]"></asp:SqlDataSource>
    </form>
</body>
</html>
