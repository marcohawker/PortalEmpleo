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
			<asp:panel ID="fila1" runat="server">
				<asp:Label  runat="server" Text="Nombre de voluntariado/titulo de aviso" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:TextBox ID="txt_Titulo" runat="server" TitleWidth="4" WebControl-Size="auto" Width="372px"></asp:TextBox>
				<asp:Label  runat="server" Text="Área" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:TextBox ID="txt_Area" runat="server" TitleWidth="4" WebControl-Size="auto"></asp:TextBox>
			</asp:panel>
			<asp:Panel ID="fila2" runat="server">
				<asp:Label  runat="server" Text="Numero de vacantes" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:TextBox ID="txt_Vacantes" runat="server" TitleWidth="4" WebControl-Size="auto"></asp:TextBox>
				<asp:Label  runat="server" Text="Vacantes disponibles" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:TextBox ID="txt_VacantesDisponibles" runat="server" TitleWidth="4" WebControl-Size="auto"></asp:TextBox>
				<asp:Label  runat="server" Text="SubArea" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:TextBox ID="txt_SubArea" runat="server" TitleWidth="4" WebControl-Size="auto"></asp:TextBox>
			</asp:Panel>
        </div>
		<div>
			<asp:Panel ID="fila3" runat="server">
				<asp:Label runat="server" Text="Tipo de jornada" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:RadioButtonList ID="rdb_Jornada" runat="server" TitleWidth="4" WebControl-Size="auto">
					<asp:ListItem Value="1">Completa</asp:ListItem>
					<asp:ListItem Value="0">Media</asp:ListItem>
				</asp:RadioButtonList>
				<asp:Label runat="server" Text="Movilidad reducida" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:RadioButtonList ID="rdb_Movilidad" runat="server" TitleWidth="4" WebControl-Size="auto">
					<asp:ListItem Value="0">Si</asp:ListItem>
					<asp:ListItem Value="1">No</asp:ListItem>
				</asp:RadioButtonList>
				<asp:Label runat="server" Text="Tipo Voluntariado" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:RadioButtonList ID="rdb_TipoVoluntariado" runat="server" TitleWidth="4" WebControl-Size="auto">
					<asp:ListItem Value="0">Presencial</asp:ListItem>
					<asp:ListItem Value="1">Remoto</asp:ListItem>
				</asp:RadioButtonList>
				<asp:Label runat="server" Text="Educacion Superior" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:RadioButtonList ID="rdb_EducacionSuperior" runat="server" TitleWidth="4" WebControl-Size="auto">
					<asp:ListItem Value="0">Si</asp:ListItem>
					<asp:ListItem Value="1">No</asp:ListItem>
				</asp:RadioButtonList>
			</asp:Panel>
			<asp:Panel ID="Panel1" runat="server" Title="">
				<asp:label text="Fecha de fin" runat="server"></asp:label>
				<asp:Calendar ID="cal_FechaFin" runat="server" Title="" SelectionMode="DayWeekMonth"></asp:Calendar>
			</asp:Panel>
			<asp:Panel ID="fila4" runat="server">
				<asp:Label  runat="server" Text="Lugar de actividades" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:TextBox ID="txt_LugarDeVoluntariado" runat="server" TitleWidth="4" WebControl-Size="auto"></asp:TextBox>
				<asp:Label  runat="server" Text="Duración de la oferta" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				
				<asp:TextBox ID="txt_DuracionOferta" runat="server" TitleWidth="4" WebControl-Size="auto"></asp:TextBox>
				<asp:Label  runat="server" Text="Tipo de contrato" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:dropdownlist ID="drp_TipoDeContrato" Titlewidth="4" Title="Tipo de contrato" runat="server" 
					WebControl-Size="auto">
					<asp:ListItem Value="1">Honorarios</asp:ListItem>
					<asp:ListItem Value="2">Contrato a plazo</asp:ListItem>
				</asp:dropdownlist>
			</asp:Panel>
			<asp:Panel ID="fila5" runat="server">
				<asp:Label  runat="server" Text="Puesto" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:TextBox ID="txt_Puesto" runat="server" TitleWidth="4" WebControl-Size="auto"></asp:TextBox>
				<asp:Label  runat="server" Text="Descripción del voluntariado y tareas" TitleWidth="4" WebControl-Size="auto"></asp:Label>
				<asp:TextBox ID="txt_DescripcionVoluntariado" runat="server" TitleWidth="4" WebControl-Size="auto" Height="109px" Width="633px"></asp:TextBox>
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
