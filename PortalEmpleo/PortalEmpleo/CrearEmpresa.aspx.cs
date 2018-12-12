using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PortalEmpleo.Models;

namespace PortalEmpleo
{
	public partial class CrearEmpresa : System.Web.UI.Page
	{
		private OAD d;
		protected void Page_Load(object sender, EventArgs e)
		{
			d = new OAD();
		}
		protected void btnCrear_Click(object sender, EventArgs e)
		{
			Empresa u = new Empresa();
			u.email = txt_Email.Text;
			u.clave = txt_clave.Text;
			u.idEmpresa = Int32.Parse(txt_RutEmpresa.Text);
			u.razonSocial = txt_RazonSocial.Text;
			u.nombreEmpresa = txt_NombreEmpresa.Text;
			u.tuNombre = txt_TuNombre.Text;
			u.tuApellido = txt_TuApellido.Text;
			u.telefono = Int32.Parse(txt_Telefono.Text);
			u.usrTipo = txt_UsrTipo.Text;

			d.CrearEmpresa(u);
		}
	}
}