using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalEmpleo.Models
{
	public class usuario
	{ //tabla usuario
		private int Rut;
		private string Clave;
		private string Nombres;
		private string Apellidos;
		private int Telefono;
		private string Email;
		private string UsrTipo;
		private DateTime UsrCreacion;
		private int EstadoCivil;
		//tabla usuario postulante
		private string Direccion;
		private int Nacionalidad;
		private String FechaNacimiento;
		private int Educacion;
		private string Profesion;
		//falta area de gusto
		private bool JornadaPreferente;
		private string Experiencia;
		private string CartaPresentacion;

		public int rut { get => Rut; set => Rut = value; }
		public string clave { get => Clave; set => Clave = value; }
		public string nombres { get => Nombres; set => Nombres = value; }
		public string apellidos { get => Apellidos; set => Apellidos = value; }
		public int telefono { get => Telefono; set => Telefono = value; }
		public string email { get => Email; set => Email = value; }
		public string usrTipo { get => UsrTipo; set => UsrTipo = value; }
		public DateTime usrCreacion { get => UsrCreacion; set => UsrCreacion = value; }
		public int estadoCivil { get => EstadoCivil; set => EstadoCivil = value; }

		public string direccion { get => Direccion; set => Direccion = value; }
		public int nacionalidad { get => Nacionalidad; set => Nacionalidad = value; }
		public String fechaNacimiento { get => FechaNacimiento; set => FechaNacimiento = value; }
		public int educacion { get => Educacion; set => Educacion = value; }
		public string profesion { get => Profesion; set => Profesion = value; }
		public bool jornadaPreferente { get => JornadaPreferente; set => JornadaPreferente = value; }
		public string experiencia { get => Experiencia; set => Experiencia = value; }
		public string cartaPresentacion { get => CartaPresentacion; set => CartaPresentacion = value; }
	}
}