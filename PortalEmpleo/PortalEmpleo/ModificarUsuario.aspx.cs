using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PortalEmpleo.Models;

namespace PortalEmpleo
{
	public partial class ModificarUsuario : System.Web.UI.Page
	{
		private OAD d;
		protected void Page_Load(object sender, EventArgs e)
		{
			d = new OAD();
		}
		protected void btnModificar_Click(object sender, EventArgs e)
		{
			int rut = Int32.Parse(txt_rut.Text);
			var calendario = (cal_FechaNacimiento.SelectedDate);
			var fechasinhora = calendario.ToString("yyyy-MM-dd HH:mm:ss.000");


			usuario a = d.BuscarPorRut(rut);
			if (a != null)

			txt_rut.Text = a.rut.ToString();
			txt_clave.Text = a.clave;
			txt_Nombre.Text = a.nombres;
			txt_Apellido.Text= a.apellidos;
			txt_Telefono.Text = a.telefono.ToString();
			txt_Direccion.Text=a.direccion;
			txt_Email.Text= a.email;
			drp_EstadoCivil.Text = a.estadoCivil.ToString();
			
			txt_UsrTipo.Text= a.usrTipo;
			drp_Nacionalidad.Text= a.nacionalidad.ToString();
			//cal_FechaNacimiento = a.fechaNacimiento.ToString();
			txt_Experiencia.Text = a.experiencia;
			txt_Presentacion.Text = a.cartaPresentacion;
			txt_rut.Enabled = false;


		}

		protected void btnActualizar_Click(object sender, EventArgs e)
		{
			var calendario = (cal_FechaNacimiento.SelectedDate);
			var fechasinhora = calendario.ToString("yyyy-MM-dd HH:mm:ss.000");

			usuario u = new usuario();

			u.rut = Int32.Parse(txt_rut.Text);
			u.clave = txt_clave.Text;
			u.nombres = txt_Nombre.Text;
			u.apellidos = txt_Apellido.Text;
			u.telefono = Int32.Parse(txt_Telefono.Text);
			u.direccion = txt_Direccion.Text;
			u.email = txt_Email.Text;
			u.estadoCivil = Int32.Parse(drp_EstadoCivil.Text);
			u.usrTipo = txt_UsrTipo.Text;
			u.nacionalidad = Int32.Parse(drp_Nacionalidad.Text);
			u.fechaNacimiento = fechasinhora;
			u.educacion = Int32.Parse(drp_Educacion.Text);
			u.profesion = drp_Profesion.Text;
			u.jornadaPreferente = Int32.Parse(drp_JornadaPreferida.Text);
			u.experiencia = txt_Experiencia.Text;
			u.cartaPresentacion = txt_Presentacion.Text;
			d.ActualizarUsuario(u);
			mensajeAccion.Text = "Actualizado";
			
		}
	}
}