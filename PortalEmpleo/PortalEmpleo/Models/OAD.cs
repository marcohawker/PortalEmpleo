using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalEmpleo.Models
{
	public class OAD
	{
		private Conexion c;
		public OAD()
		{
			c = new Conexion();
		}
		/* create*/
		public void CrearUsuario(usuario a)
		{
			String insert = "insert into UsuarioPostulante (UsrPRut, UsrPDir, UsrPFnac, UsrPNac) values('" + a.rut +
				"', '" + a.direccion +
				"', '" + a.fechaNacimiento +
				"', '" + a.nacionalidad +
				"') insert into Usuario values ('" + a.rut +
				"','" + a.clave +
				"', '" + a.nombres +
				"','" + a.apellidos +
				"','" + a.email +
				"','" + a.usrTipo +
				"','" + a.telefono +
				"',GETDATE(),'" + a.estadoCivil + "')";

			Ejecutar(insert);
		}


		/* buscar(read)*/
		public usuario BuscarPorRut(int rut)
		{

			String select = "select * from Usuario x inner join UsuarioPostulante y  on x.UsrRut =y.UsrPRut where UsrRut='" + rut + "'";
			c.con.Open();
			c.sen = new System.Data.SqlClient.SqlCommand(select, c.con);
			c.rs = c.sen.ExecuteReader();

			usuario a = null;

			if (c.rs.Read())
			{
				a = new usuario();
				a.rut = c.rs.GetInt32(0);
				a.clave = c.rs.GetString(1);
				a.nombres = c.rs.GetString(2);
				a.apellidos = c.rs.GetString(3);
				a.email = c.rs.GetString(4);
				a.usrTipo = c.rs.GetString(5);
				a.telefono = c.rs.GetInt32(6);
				a.usrCreacion = c.rs.GetDateTime(7);
				a.estadoCivil = c.rs.GetInt32(8);
				a.direccion = c.rs.GetString(10);
				//a.fechaNacimiento = c.rs.GetString(11);
				a.nacionalidad = c.rs.GetInt32(14);



			}
			c.con.Close();
			return a;
		}
		/* Update)*/
		public void ActualizarUsuario(usuario a)
		{
			String update = "update Usuario set UsrClave='" + a.clave +
				"', UsrNombre='" + a.nombres +
				"', UsrApellido='" + a.apellidos +
				"',UsrTelefono='" + a.telefono +
				"',UsrEstado='" + a.estadoCivil +
				"' where UsrRut='" + a.rut + "'";
			Ejecutar(update);
		}
		/* Borrar*/
		public void BorrarUsuario(int rut)
		{

			string delete = "delete from Usuario where UsrRut = '" + rut + "' delete from UsuarioPostulante where UsrPRut ='" + rut + "'";
			Ejecutar(delete);
		}
		public void CrearEmpresa(Empresa e)
		{
			String creaEmpresa = "insert into [PortalEmpleo].[dbo].[Empresa] values ("+e.idEmpresa+", '"+e.razonSocial+"', 'direcccion1', 'www.empresa1.cl', 'rubro1', 'com1')";
			Ejecutar(creaEmpresa);
		}
		public void CrearOfertaEmpleo(Empresa e)
		{
			//string insert= "insert into[PortalEmpleo].[dbo].[OfertaLaboral] values(1234, 8888, 'oferta1', 'puesto1', 4444, 4441, 'descripcion1',
 //'ubicqacion1', 3, GETDATE(), GETDATE(), 1, 400000, 1, 1, 1, 1110, 1)";

		}
		public void BuscarOfertaEmpleo(int IdOfertaEmpleo)
		{

		}
		public void ModificarOfertaEmpleo(Empresa e)
		{

		}
		public void EliminarOfertaEmpleo(Empresa e)
		{

		}

		private void Ejecutar(String ConsultaSql)// la base de las funciones
		{
			c.con.Open();
			c.sen = new System.Data.SqlClient.SqlCommand(ConsultaSql, c.con);
			c.sen.ExecuteNonQuery();
			c.con.Close();
		}
	}
}