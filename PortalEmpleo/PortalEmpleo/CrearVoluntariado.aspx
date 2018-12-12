<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearVoluntariado.aspx.cs" Inherits="PortalEmpleo.CrearVoluntariado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

			<asp:Panel ID="Filaa" runat="server" Title="">
				<asp:Label  runat="server" Text="Rut" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:TextBox ID="txt_rut" runat="server" TitleWidth="4" WebControl-Size="auto"></asp:TextBox>

				<asp:Label  runat="server" Text="Clave" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:TextBox ID="txt_clave" runat="server" TitleWidth="4" WebControl-Size="auto"></asp:TextBox>
			</asp:Panel>
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
				<asp:label text="Estado Civil" runat="server"></asp:label>
				<asp:dropdownlist ID="drp_EstadoCivil" Titlewidth="4" Title="Estado Civil" runat="server" 
					WebControl-Size="auto">
				<asp:ListItem Value="0">Soltero/a</asp:ListItem>
				<asp:ListItem Value="1">Casado/a</asp:ListItem>
					</asp:dropdownlist>
				
				
			</asp:Panel>
			<asp:Panel ID="Fila4" runat="server" Title="">
				<asp:label text="Tipo usuario" runat="server"></asp:label>
				<asp:TextBox ID="txt_UsrTipo" runat="server"></asp:TextBox>
				<asp:label text="Nacionalidad" runat="server"></asp:label>
				<asp:dropdownlist ID="drp_Nacionalidad" Titlewidth="4" Title="Nacionalidad" runat="server" 
					WebControl-Size="auto">
					<asp:ListItem Value="0">Chileno/a</asp:ListItem>
					<asp:ListItem Value="1">Extranjero/a</asp:ListItem>
					</asp:dropdownlist>
			</asp:Panel>
			<asp:Panel ID="Fila5" runat="server" Title="">
				<asp:label text="Fecha de nacimiento" runat="server"></asp:label>
				<asp:Calendar ID="cal_FechaNacimiento" runat="server" Title="" SelectionMode="DayWeekMonth"></asp:Calendar>
			</asp:Panel>
			
	    </div>
		<div>
			<asp:label text="Educación" runat="server"></asp:label>
			<asp:dropdownlist ID="drp_Educacion" Titlewidth="4" Title="Educación" runat="server" 
					WebControl-Size="auto">
				<asp:ListItem Value="0">Escolar Completa</asp:ListItem>
				<asp:ListItem Value="1">Escolar Incompleta</asp:ListItem>
			</asp:dropdownlist>
			<asp:label text="Profesión u oficio" runat="server"></asp:label>
			<asp:dropdownlist ID="drp_Profesion" Titlewidth="4" Title="Profesión" runat="server" 
					WebControl-Size="auto">
				<asp:ListItem Value="0">Profesional</asp:ListItem>
				<asp:ListItem Value="1">No profesional</asp:ListItem>
			</asp:dropdownlist>
			<asp:label text="Tipo de jornada preferida" runat="server"></asp:label>
			<asp:dropdownlist ID="drp_JornadaPreferida" Titlewidth="4" Title="Jornada Preferida" runat="server" 
					WebControl-Size="auto">
				<asp:ListItem Value="0">Media</asp:ListItem>
				<asp:ListItem Value="1">Completa</asp:ListItem>
			</asp:dropdownlist>
			<asp:Panel ID="FilaTexto" runat="server">
			<asp:label text="Experiencia Laboral(max X caracteres)" runat="server"></asp:label>
				<asp:TextBox ID="txt_Experiencia" runat="server" Height="118px" Width="435px"></asp:TextBox>
			</asp:Panel>
			<asp:label text="Presentación/Objetivos(max X caracteres)" runat="server"></asp:label>
			<asp:TextBox ID="txt_Presentacion" runat="server" Height="118px" Width="435px"></asp:TextBox>
		</div>
		<div>
			<asp:Panel ID="registrar" runat="server">
			<asp:Label ID="Label1" runat="server" Text="Acepto terminos y condiciones"></asp:Label>
			<asp:Button ID="btnCrear" runat="server" Text="Registrar" OnClick="btnCrear_Click"/>
				</asp:Panel>
		</div>
    	
    </form>
</body>
</html>
