using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PortalEmpleo.Models;
namespace PortalEmpleo
{
	public partial class CrearVoluntariado : System.Web.UI.Page
	{
		private OAD d;
		protected void Page_Load(object sender, EventArgs e)
		{
			d = new OAD();
		}
		protected void btnCrear_Click(object sender, EventArgs e)
		{
			var calendario = (cal_FechaFin.SelectedDate);
			var fechasinhora = calendario.ToString("yyyy-MM-dd HH:mm:ss.000");

			Voluntariado u = new Voluntariado();
			u.volTitulo = txt_Titulo.Text;
			u.volpuesto = txt_Titulo.Text;
			u.volarea = Int32.Parse(txt_Area.Text);
			u.volsubarea = Int32.Parse(txt_SubArea.Text);
			u.volvac = Int32.Parse(txt_Vacantes.Text);
			u.volvacdisp = Int32.Parse(txt_VacantesDisponibles.Text);
			u.voljornada = Int32.Parse(rdb_Jornada.SelectedValue);
			u.volmov = Int32.Parse(rdb_Movilidad.SelectedValue);
			
			u.voledu = Int32.Parse(rdb_EducacionSuperior.SelectedValue);
			u.volugar = txt_LugarDeVoluntariado.Text;
			u.volfechafin = fechasinhora;
			u.volTcontrato = Int32.Parse(drp_TipoDeContrato.Text);
			
			u.voldesc = txt_DescripcionVoluntariado.Text;

			d.CrearOfertaVoluntariado(u);


		}
	}
}