using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PortalEmpleo.Models;

namespace PortalEmpleo
{
	public partial class Registro : System.Web.UI.Page
	{
		private OAD d;
		protected void Page_Load(object sender, EventArgs e)
		{
			d = new OAD();
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
			u.telefono = Int32.Parse(txt_Telefono.Text);
			u.direccion = txt_Direccion.Text;
			u.email = txt_Email.Text;
			u.estadoCivil = Int32.Parse(drp_EstadoCivil.Text);
			u.usrTipo = txt_UsrTipo.Text;
			u.nacionalidad = Int32.Parse(drp_Nacionalidad.Text);
			u.fechaNacimiento = fechasinhora;

			d.CrearUsuario(u);
			
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
	}
}//anadir filas a insert en OAD