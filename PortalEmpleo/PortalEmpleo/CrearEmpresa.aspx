<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearEmpresa.aspx.cs" Inherits="PortalEmpleo.CrearEmpresa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<asp:Panel ID="Fila1" runat="server" Title="">
				Email:
				<asp:textbox ID="txt_Email" Titlewidth="4" Title="Email" runat="server" 
					WebControl-Size="auto"/>
			</asp:Panel>
			<asp:Panel ID="Fila2" runat="server" Title="">
				<asp:Label  runat="server" Text="Clave" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:TextBox ID="txt_clave" runat="server" TitleWidth="4" WebControl-Size="auto"></asp:TextBox>
			</asp:Panel>
			<asp:Panel ID="Fila3" runat="server" Title="">
				<asp:Label  runat="server" Text="Rut de la empresa" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:TextBox ID="txt_RutEmpresa" runat="server" TitleWidth="4" WebControl-Size="auto"></asp:TextBox>
			</asp:Panel>
			<asp:Panel ID="Fila4" runat="server" Title="">
				<asp:Label  runat="server" Text="Nombre de la empresa" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:textbox ID="txt_NombreEmpresa" TitleWidth ="4" Title="Nombre Empresa" runat="server"
					WebControl-Size="auto"/>
			</asp:Panel>
			<asp:Panel ID ="Fila5" runat="server" Title="">
				<asp:label text="Razón Social" runat="server"></asp:label>
				<asp:TextBox ID="txt_RazonSocial" runat="server"></asp:TextBox>
			</asp:Panel>
			<asp:Panel ID="Fila6" runat="server" Title="">
				<asp:label text="Tu nombre" runat="server"></asp:label>
				<asp:TextBox ID="txt_TuNombre" runat="server"></asp:TextBox>
			</asp:Panel>
			<asp:Panel id="Fila7" runat="server" Title="">
				<asp:label text="Tu apellido" runat="server"></asp:label>
				<asp:TextBox ID="txt_TuApellido" runat="server"></asp:TextBox>
			</asp:Panel>
			
			<asp:Panel ID="Fila8" runat="server" Title="">
				<asp:label text="Teléfono de contacto" runat="server"></asp:label>
				<asp:textbox ID="txt_Telefono" Titlewidth="4" Title="Telefono" runat="server" 
					WebControl-Size="auto"/>
				<asp:label text="Tipo usuario" runat="server"></asp:label>
				<asp:TextBox ID="txt_UsrTipo" runat="server"></asp:TextBox>
			</asp:Panel>
		</div>
		<div>
			<asp:Panel ID="registrar" runat="server">
			<asp:Label ID="Label1" runat="server" Text="Acepto terminos y condiciones"></asp:Label>
			<asp:Button ID="btnCrear" runat="server" Text="Registrar" OnClick="btnCrear_Click"/>
				<asp:Button ID="btonmodificar" runat="server" Text="buscar" OnClick="btnModificar_Click"/>
				<asp:Button ID="Button1" runat="server" Text="Actualiza" OnClick="btnActualizar_Click"/>
				</asp:Panel>
		</div>
    	
    </form>
</body>
</html>
