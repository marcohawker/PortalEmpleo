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
			String insert = "insert into UsuarioPostulante values('" + a.rut +
				"', '" + a.direccion +
				"', '" + a.fechaNacimiento +
				"', '1', '1', '" + a.nacionalidad +
				"', '" +a.estadoCivil+
				"', '" +a.educacion+
				"', '" +a.jornadaPreferente+
				"', '1', '"+a.profesion+
				"', '" +a.experiencia+
				"', 'hab', '"+a.cartaPresentacion+"') insert into Usuario values ('" + a.rut +
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
			{ //orden columnas bd
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
				a.estadoCivil = c.rs.GetInt32(15);
				a.educacion = c.rs.GetInt32(16);
				a.profesion = c.rs.GetString(19);
				a.experiencia = c.rs.GetString(20);
				a.cartaPresentacion = c.rs.GetString(22);






			}
			c.con.Close();
			return a;
		}
		/* Update)*/
		public void ActualizarUsuario(usuario a)
		{
			String update = "  update [PortalEmpleo].[dbo].[Usuario] set UsrClave='" + a.clave +
				"', UsrNombre='" + a.nombres +
				"', UsrApellido='" + a.apellidos +
				"', UsrTelefono='" + a.telefono +
				"', UsrEstado='" + a.estadoCivil +
				"' where UsrRut='" + a.rut + "' update [PortalEmpleo].[dbo].[UsuarioPostulante] set UsrPDir='" + a.direccion +
				"', UsrPFnac='" + a.fechaNacimiento +
				"', UsrPNac='" + a.nacionalidad +
				"', UsrPECivil='" + a.estadoCivil +
				"', UsrPEdu='" + a.educacion +
				"', UsrPJor='" + a.jornadaPreferente +
				"', UsrPProficio='" + a.profesion +
				"', UsrPExpLab='" + a.experiencia +
				"', UsrPRCV='" + a.cartaPresentacion + 
				"' where UsrPRut = '" + a.rut + "'";
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
			String creaEmpresa = "insert into [PortalEmpleo].[dbo].[Empresa] values ("+e.idEmpresa+", '"+e.razonSocial+"', 'direcccion1', 'www.empresa1.cl', 'rubro1', 'com1', 7777)";
			Ejecutar(creaEmpresa);
		}
		public Empresa BuscarEmpresa(string idEmpresa)
		{
			String select = "select * from Empresa t where EmpRut='" + idEmpresa + "'";
			c.con.Open();
			c.sen = new System.Data.SqlClient.SqlCommand(select, c.con);
			c.rs = c.sen.ExecuteReader();

			Empresa a = null;
			if (c.rs.Read())
			{ //orden columnas bd
				a = new Empresa();
				a.idEmpresa = c.rs.GetString(0);
				a.razonSocial= c.rs.GetString(1);
				//direccionn
				//web
				//rubro
				//com






			}
			c.con.Close();
			return a;
		}
		public void ActualizarEmpresa(Empresa e)
		{
			String update = "update [PortalEmpleo].[dbo].[Empresa] set EmpRSocial='" + e.razonSocial +
				"' where EmpRut='" + e.idEmpresa + "'";
			Ejecutar(update);
		}
			public void CrearOfertaEmpleo(Empresa e)
		{
			string creaOferta= "insert into [PortalEmpleo].[dbo].[OfertaLaboral] values ('rutEmp1', "+e.tituloOferta+", "+e.puesto+", 1, 1, "+e.descripcionOferta+", "+e.ubicacion+", "+e.numeroVacantes+", GETDATE(), GETDATE(), 1, "+e.salario+", "+e.jornadraLaboral+", "+e.movilidadRequerida+", "+e.educacionRequerida+", "+e.tipoDeContrato+", 1)";
			Ejecutar(creaOferta);
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