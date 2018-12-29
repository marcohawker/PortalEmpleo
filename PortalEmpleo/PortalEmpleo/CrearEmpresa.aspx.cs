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
			u.idEmpresa = txt_RutEmpresa.Text;
			u.razonSocial = txt_RazonSocial.Text;
			u.nombreEmpresa = txt_NombreEmpresa.Text;
			u.tuNombre = txt_TuNombre.Text;
			u.tuApellido = txt_TuApellido.Text;
			u.telefono = Int32.Parse(txt_Telefono.Text);
			u.usrTipo = txt_UsrTipo.Text;

			d.CrearEmpresa(u);
		}

		protected void btnModificar_Click(object sender, EventArgs e)
		{
			String idEmpresa = txt_RutEmpresa.Text;



			Empresa a = d.BuscarEmpresa(idEmpresa);
			if (a != null)

			txt_RutEmpresa.Text = a.idEmpresa;
			txt_clave.Text = a.clave;
			txt_NombreEmpresa.Text = a.nombreEmpresa;
			txt_RazonSocial.Text = a.razonSocial;
			txt_RutEmpresa.Enabled = false;
		}
		protected void btnActualizar_Click(object sender, EventArgs e)
		{
			Empresa u = new Empresa();

			u.idEmpresa = txt_RutEmpresa.Text;
			u.razonSocial = txt_RazonSocial.Text;
			d.ActualizarEmpresa(u);
		}
	}
}