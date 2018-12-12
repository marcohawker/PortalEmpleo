using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PortalEmpleo
{
	/// <summary>
	/// Descripción breve de WebService
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
	// [System.Web.Script.Services.ScriptService]
	public class WebService : System.Web.Services.WebService
	{

		/*public String ModificarDatosCv(UsuarioPostulanteConsulta UsuarioPosstulanteConsulta)
		{

			IdSolicitud idsolicitud = bPlaControl.buscarNivelSolicitud(UsuarioPostulanteConsulta.IdNivelSolicitud);

			List<ClienteMaterialPlac> lClienteMaterial = bPlaControl.buscarClienteMaterialPorNivelBus(UsuarioPostulanteConsulta.IdNivelSolicitud);

			foreach (ClienteMaterialPlac c in lClienteMaterial)
			{
				if (c.CodigoCliente != 0 && c.CodigoCliente != int.Parse(UsuarioPostulanteConsulta.CodigoSap))
				{
					bPlaControl.eliminarClienteMaterialBus(c.IdClienteMaterialSap);
				}
			}

			idsolicitud.CodNotTipo = UsuarioPostulanteConsulta.Nombres;
			idsolicitud.CodNotTipoCaract = UsuarioPostulanteConsulta.Apellidos;
			idsolicitud.DiaIni = UsuarioPostulanteConsulta.Telefono;
			idsolicitud.DiaIni = UsuarioPostulanteConsulta.Direccion;
			idsolicitud.DiaIni = UsuarioPostulanteConsulta.Email;
			idsolicitud.DiaIni = UsuarioPostulanteConsulta.EstadoCivil;


			bPlaControl.modificarNivelSolicitud(nivelsolicitud);
			return "La Selección se ha modificado exitosamente";
		} */
	}
}
