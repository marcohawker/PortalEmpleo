using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PortalEmpleo.Models;
namespace PortalEmpleo
{
	public partial class CrearOfertaLaboral : System.Web.UI.Page
	{
		private OAD d;
		protected void Page_Load(object sender, EventArgs e)
		{
			d = new OAD();
		}
		protected void btnCrear_Click(object sender, EventArgs e)
		{
			Empresa u = new Empresa();
			u.tituloOferta = txt_Titulo.Text;
			u.area = Int32.Parse(txt_Area.Text);
			u.subArea = Int32.Parse(txt_SubArea.Text);
			u.numeroVacantes = Int32.Parse(txt_Vacantes.Text);
			u.salario = Int32.Parse(txt_Salario.Text);
			//u.jornadraLaboral = rdb_Jornada.SelectedValue(true);
			//u.movilidadRequerida = rdb_Movilidad.SelectedValue(true);
			//u.tipoTrabajo = rdb_TipoTrabajo.SelectedValue(true);
			//u.educacionRequerida = rdb_EducacionSuperior.SelectedValue(true);
			u.ubicacion = txt_LugarDeTrabajo.Text;
			u.fechaFin = txt_DuracionOferta.Text;
			u.tipoDeContrato = Int32.Parse(drp_TipoDeContrato.Text);
			u.puesto = txt_Puesto.Text;
			u.descripcionOferta = txt_DescripcionTrabajo.Text;

			d.CrearOfertaEmpleo(u);
			

		}
	}
}