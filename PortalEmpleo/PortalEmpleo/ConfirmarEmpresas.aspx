<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfirmarEmpresas.aspx.cs" Inherits="PortalEmpleo.ConfirmarEmpresas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
	<h1>Aprobar usuario empresa</h1>
    <form id="form1" runat="server">
        <div>

        	<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="EmpRut" DataSourceID="SqlDataSource1" OnRowUpdated="GridView1_RowUpdated">
				<Columns>
					<asp:BoundField DataField="EmpRut" HeaderText="EmpRut" ReadOnly="True" SortExpression="EmpRut" />
					<asp:BoundField DataField="EmpRSocial" HeaderText="EmpRSocial" SortExpression="EmpRSocial" />
					<asp:BoundField DataField="EmpDir" HeaderText="EmpDir" SortExpression="EmpDir" />
					<asp:BoundField DataField="EmpCom" HeaderText="EmpCom" SortExpression="EmpCom" />
					<asp:ButtonField ButtonType="Button" CommandName="btn_Aprobar"  HeaderText="Gestionar" ShowHeader="True" Text="Aprobar" />
					<asp:ButtonField ButtonType="Button" CommandName="btn_Rechazar"  Text="Rechazar" />
				</Columns>
			</asp:GridView>
			<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PortalEmpleoConnectionString %>" SelectCommand="SELECT [EmpRut], [EmpRSocial], [EmpDir], [EmpCom] FROM [Empresa]"></asp:SqlDataSource>

        </div>
    </form>
</body>
</html>
