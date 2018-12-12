<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificarCv.aspx.cs" Inherits="PortalEmpleo.ModificarCv" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<%--	<script>
		var UsuarioPostulanteConsulta = {
			Id:'',
			Nombres: '',
			Apellidos: '',
			Telefono: 0,
			Direccion: '',
			Email: '',
			EstadoCivil: 0
		};
		function ConfInicial(Id,
			Nombres,
			Apellidos,
			Telefono,
			Direcccion,
			Email,
			EstadoCivil)

		UsuarioPostulanteConsulta.Id = Id;
		UsuarioPostulanteConsulta.Nombres = Nombres;
		UsuarioPostulanteConsulta.Apellidos = Apellidos;
		UsuarioPostulanteConsulta.Telefono = Telefono;
		UsuarioPostulanteConsulta.Direccion = Direcccion;
		UsuarioPostulanteConsulta.Email = Email;
		UsuarioPostulanteConsulta.EstadoCivil = EstadoCivil;

		jsFiltroUsuario(UsuarioPostulanteConsulta.Id);
			$('#form1_txt_Nombres_textbox').val(UsuarioPostulanteConsulta.Nombres)
			$('#form1_txt_Apellidos_textbox').val(UsuarioPostulanteConsulta.Apellidos)
			$('#form1_txt_Telefono_textbox').val(UsuarioPostulanteConsulta.Telefono)
			$('#form1_txt_Direccion_textbox').val(UsuarioPostulanteConsulta.Direccion)
			$('#form1_txt_Email_textbox').val(UsuarioPostulanteConsulta.Email)
			$('#form1_drp_EstadoCivil_dropdownlist').val(UsuarioPostulanteConsulta.EstadoCivil)

		function validaConcepto() {//replicar para los campos obligatorios
			//$('#form1_txt_Nombres_textbox').val("");
			if ($('#form1_txt_Nombres_textbox :selected').val() == "") {
				alert("Debe Ingresar los nombres");
				return false;
			}
		}

		$('#btnModificarDatos').click(function () {
			UsuarioPostulanteConsulta.Id = $('#MainContent_cmbNotTipo_combo').val();

			$.ajax({
					type: "POST",
					url: "WebService.asmx/ModificarDatosCv",
					async: true,
					data: JSON.stringify({
						UsuarioPostulanteConsulta: UsuarioPostulanteConsulta
					}),
					contentType: "application/json; charset=utf-8",
					dataType: "json",
					success: function (response) {
						var Resultado = response.d;
						alert(Resultado);
						buscar();
					},
					error: function (XMLHttpRequest, text, error) { debugger; alert(XMLHttpRequest.responseText); },
					failure: function (response) { alert(response.d); }
				});
			}


	</script> --%>
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
				<asp:ListItem Value="0">0</asp:ListItem>
				<asp:ListItem Value="1">1</asp:ListItem>
					</asp:dropdownlist>
				
				
			</asp:Panel>
			<asp:Panel ID="Fila4" runat="server" Title="">
				<asp:label text="Tipo usuario" runat="server"></asp:label>
				<asp:TextBox ID="txt_UsrTipo" runat="server"></asp:TextBox>
				<asp:label text="Nacionalidad" runat="server"></asp:label>
				<asp:dropdownlist ID="drp_Nacionalidad" Titlewidth="4" Title="Nacionalidad" runat="server" 
					WebControl-Size="auto">
				<asp:ListItem Value="0">0</asp:ListItem>
				<asp:ListItem Value="1">1</asp:ListItem>
					</asp:dropdownlist>
			</asp:Panel>
			<asp:Panel ID="Fila5" runat="server" Title="">
				<asp:label text="Fecha de nacimiento" runat="server"></asp:label>
				<asp:Calendar ID="cal_FechaNacimiento" runat="server" Title="" SelectionMode="DayWeekMonth"></asp:Calendar>
			</asp:Panel>

			<asp:Button ID="btnCrear" runat="server" Text="crear" OnClick="btnCrear_Click"/>
			<asp:Button ID="btnBuscar" runat="server" Text="buscar" OnClick="btnBuscar_Click" />
			<asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
			<asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
	    </div>
		<div>

		</div>
    	<asp:Label ID="mensajeAccion" runat="server" Text="Haga Algo"></asp:Label>
    	<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="UsrRut" DataSourceID="DatosPostulante">
			<Columns>
				<asp:BoundField DataField="UsrRut" HeaderText="UsrRut" ReadOnly="True" SortExpression="UsrRut" />
				<asp:BoundField DataField="UsrNombre" HeaderText="UsrNombre" SortExpression="UsrNombre" />
				<asp:BoundField DataField="UsrApellido" HeaderText="UsrApellido" SortExpression="UsrApellido" />
			</Columns>
		</asp:GridView>
		<asp:SqlDataSource ID="DatosPostulante" runat="server" ConnectionString="<%$ ConnectionStrings:PortalEmpleoConnectionString %>" SelectCommand="SELECT [UsrRut], [UsrNombre], [UsrApellido] FROM [Usuario]"></asp:SqlDataSource>
    </form>

</body>
</html>
