<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearOfertaLaboral.aspx.cs" Inherits="PortalEmpleo.CrearOfertaLaboral" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<asp:panel ID="fila1" runat="server">
				<asp:Label  runat="server" Text="Nombre de puesto/titulo de aviso" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:TextBox ID="txt_Titulo" runat="server" TitleWidth="4" WebControl-Size="auto" Width="372px"></asp:TextBox>
				<asp:Label  runat="server" Text="Área" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:TextBox ID="txt_Area" runat="server" TitleWidth="4" WebControl-Size="auto"></asp:TextBox>
			</asp:panel>
			<asp:Panel ID="fila2" runat="server">
				<asp:Label  runat="server" Text="Numero de vacantes" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:TextBox ID="txt_Vacantes" runat="server" TitleWidth="4" WebControl-Size="auto"></asp:TextBox>
				<asp:Label  runat="server" Text="Salario en miles" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:TextBox ID="txt_Salario" runat="server" TitleWidth="4" WebControl-Size="auto"></asp:TextBox>
				<asp:Label  runat="server" Text="SubArea" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:TextBox ID="txt_SubArea" runat="server" TitleWidth="4" WebControl-Size="auto"></asp:TextBox>
			</asp:Panel>
        </div>
		<div>
			<asp:Panel ID="fila3" runat="server">
				<asp:Label runat="server" Text="Tipo de jornada" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:RadioButtonList ID="rdb_Jornada" runat="server" TitleWidth="4" WebControl-Size="auto">
					<asp:ListItem>Completa</asp:ListItem>
					<asp:ListItem>Media</asp:ListItem>
				</asp:RadioButtonList>
				<asp:Label runat="server" Text="Movilidad reducida" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:RadioButtonList ID="rdb_Movilidad" runat="server" TitleWidth="4" WebControl-Size="auto">
					<asp:ListItem>Si</asp:ListItem>
					<asp:ListItem>No</asp:ListItem>
				</asp:RadioButtonList>
				<asp:Label runat="server" Text="Tipo Trabajo" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:RadioButtonList ID="rdb_TipoTrabajo" runat="server" TitleWidth="4" WebControl-Size="auto">
					<asp:ListItem>Presencial</asp:ListItem>
					<asp:ListItem>Remoto</asp:ListItem>
				</asp:RadioButtonList>
				<asp:Label runat="server" Text="Educacion Superior" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:RadioButtonList ID="rdb_EducacionSuperior" runat="server" TitleWidth="4" WebControl-Size="auto">
					<asp:ListItem>Si</asp:ListItem>
					<asp:ListItem>No</asp:ListItem>
				</asp:RadioButtonList>
			</asp:Panel>
			<asp:Panel ID="fila4" runat="server">
				<asp:Label  runat="server" Text="Lugar de trabajo" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:TextBox ID="txt_LugarDeTrabajo" runat="server" TitleWidth="4" WebControl-Size="auto"></asp:TextBox>
				<asp:Label  runat="server" Text="Duración de la oferta" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:TextBox ID="txt_DuracionOferta" runat="server" TitleWidth="4" WebControl-Size="auto"></asp:TextBox>
				<asp:Label  runat="server" Text="Tipo de contrato" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:dropdownlist ID="drp_TipoDeContrato" Titlewidth="4" Title="Tipo de contrato" runat="server" 
					WebControl-Size="auto">
					<asp:ListItem Value="0">Honorarios</asp:ListItem>
					<asp:ListItem Value="1">Contrato a plazo</asp:ListItem>
				</asp:dropdownlist>
			</asp:Panel>
			<asp:Panel ID="fila5" runat="server">
				<asp:Label  runat="server" Text="Puesto" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:TextBox ID="txt_Puesto" runat="server" TitleWidth="4" WebControl-Size="auto"></asp:TextBox>
				<asp:Label  runat="server" Text="Descripción del trabajo y tareas" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:TextBox ID="txt_DescripcionTrabajo" runat="server" TitleWidth="4" WebControl-Size="auto" Height="109px" Width="633px"></asp:TextBox>
			</asp:Panel>
		</div>
		<div>
			<asp:Panel ID="registrar" runat="server">
			<asp:Label ID="Label1" runat="server" Text="Acepto terminos y condiciones"></asp:Label>
			<asp:Button ID="btnCrear" runat="server" Text="Publicar" OnClick="btnCrear_Click"/>
				</asp:Panel>
		</div>
    </form>
</body>
</html>
