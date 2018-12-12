using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PortalEmpleo.Models;

namespace PortalEmpleo
{
	public partial class ModificarCv : System.Web.UI.Page
	{
		private OAD d; 
		protected void Page_Load(object sender, EventArgs e)
		{
			d = new OAD();
		}
		protected void btnBuscar_Click(object sender, EventArgs e)
		{
			int rut = Int32.Parse(txt_rut.Text);
			/*string clave = txt_clave.Text;
			string nombre = txt_Nombre.Text;
			string apellido = txt_Apellido.Text;
			int telefono = Int32.Parse(txt_Telefono.Text);
			string direccion = txt_Direccion.Text;
			string email = txt_Email.Text;
			int estadoCivil = Int32.Parse(drp_EstadoCivil.Text);
			string tipousuario = usrtipo.Text; */

			usuario a = d.BuscarPorRut(rut);
			if (a != null)
			{
				mensajeAccion.Text = "Encntrado";
				txt_clave.Text = a.clave;
				txt_Nombre.Text = a.nombres;
				txt_Apellido.Text = a.apellidos;
				txt_Telefono.Text = a.telefono.ToString();
				txt_Direccion.Text = a.direccion;
				txt_Email.Text = a.email;
				drp_EstadoCivil.Text = a.estadoCivil.ToString();
				txt_UsrTipo.Text = a.usrTipo;
				//drp_Nacionalidad.Text = a.nacionalidad.ToString();
				drp_Nacionalidad.DataTextField = "nacionalidad";
				drp_Nacionalidad.DataBind();
//				cal_FechaNacimiento = a.fechaNacimiento;
				txt_clave.Enabled = true;
				txt_Nombre.Enabled = true;
				txt_Apellido.Enabled = true;
				txt_Telefono.Enabled = true;
				txt_Direccion.Enabled = true;
				txt_Email.Enabled = true;

			}
			else
			{
				
				mensajeAccion.Text = " No Encontrado";
			}
		}
		
		protected void btnCrear_Click(object sender, EventArgs e)
		{
			var calendario = (cal_FechaNacimiento.SelectedDate);
			var fechasinhora = calendario.ToString("yyyy-MM-dd HH:mm:ss.000");


			usuario u = new usuario();
			
			u.rut = Int32.Parse(txt_rut.Text);
			u.clave = txt_clave.Text;
			u.nombres = txt_Nombre.Text;
			u.apellidos = txt_Apellido.Text;
			u.telefono= Int32.Parse(txt_Telefono.Text);
			u.direccion= txt_Direccion.Text;
			u.email = txt_Email.Text;
			u.estadoCivil= Int32.Parse(drp_EstadoCivil.Text);
			u.usrTipo = txt_UsrTipo.Text;
			u.nacionalidad= Int32.Parse(drp_Nacionalidad.Text);
			u.fechaNacimiento = fechasinhora;

			d.CrearUsuario(u);
			mensajeAccion.Text = "Creado";
			/*txt_rut.Text = "";
			txt_clave.Text = "";
			txt_Nombre.Text = "";
			txt_Apellido.Text = "";
			txt_Telefono.Text ="";
			txt_Direccion.Text = "";
			txt_Email.Text = "";
			drp_EstadoCivil.Text = "";			
			txt_UsrTipo.Text = "";
			drp_Nacionalidad.Text = ""; 
			cal_FechaNacimiento = null;*/
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
			d.ActualizarUsuario(u);
			mensajeAccion.Text = "Actualizado";
			txt_rut.Enabled = false;
		}
		protected void btnEliminar_Click(object sender, EventArgs e)
		{


			int rut = Int32.Parse(txt_rut.Text);
			d.BorrarUsuario(rut);
			mensajeAccion.Text = "Eliminado";
			txt_rut.Enabled = true;
		}
	}
}