<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificarCv.aspx.cs" Inherits="PortalEmpleo.ModificarCv" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
	<script>
		var UsuarioPostulanteConsulta = {
			Nombres: '',
			Apellidos: '',
			Telefono: 0,
			Direccion: '',
			Email: '',
			EstadoCivil: 0
		};
		function ConfInicial(Nombres,
			Apellidos,
			Telefono,
			Direcccion,
			Email,
			EstadoCivil)
	</script>
<body>
    <form id="form1" runat="server">
        <div>
			<asp:Panel ID="Fila1" runat="server" Title="">
				Nombres:
				<asp:textbox ID="txt_Nombre" TitleWidth ="4" Title="Nombres" runat="server"
					WebControl-Size="auto"/>
				Apellidos:
				<asp:textbox ID="txt_Apellido" TitleWidth ="4" Title="Apellidos" runat="server"
					WebControl-Size="auto"/>
			</asp:Panel>
			<asp:Panel ID="Fila2" runat="server" Title="">
				Telefono:
				<asp:textbox ID="txt_Telefono" Titlewidth="4" Title="Telefono" runat="server" 
					WebControl-Size="auto"/>
				Direccion:
				<asp:textbox ID="txt_Direccion" Titlewidth="4" Title="Direccion" runat="server" 
					WebControl-Size="auto"/>
			</asp:Panel>
			<asp:Panel ID="Fila3" runat="server" Title="">
				Email:
				<asp:textbox ID="txt_Email" Titlewidth="4" Title="Email" runat="server" 
					WebControl-Size="auto"/>
			<%-- 	<PorEm:ComboBox ID="cmb_EstadoCivil" Titlewidth"4" Title="Estado Civil" runat="server"
					WebControl-Size="auto"></PorEm:ComboBox>--%>
				Estado Civil:
				<asp:dropdownlist ID="drp_EstadoCivil" Titlewidth="4" Title="Estado Civil" runat="server" 
					WebControl-Size="auto"/>
			</asp:Panel>
	    </div>
		<div>

		</div>
    </form>
</body>
</html>
