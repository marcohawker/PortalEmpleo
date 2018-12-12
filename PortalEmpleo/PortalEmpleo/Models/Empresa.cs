using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalEmpleo.Models
{
	public class Empresa
	{
		//oferta laboral
		private int IdOferta;
		private int IdEmpresa;//foranea
		private string TituloOferta;
		private string Puesto;
		private int Area;//foranea
		private int SubArea;//foranea
		private string DescripcionOferta;
		private string Ubicacion;
		private int NumeroVacantes;
		private string FechaFin;
		private int TipoDeContrato;
		private int Salario;
		//falta bool tipo de trabajo(remoto, presencial)
		private bool JornadraLaboral;
		private bool MovilidadRequerida;
		private bool EducacionRequerida;
		private int Estado;

		//crear empresa ID Empresa Yaa definido
		private string Email;
		private string Clave;
		private int RutEmpresa;
		private string NombreEmpresa;
		private string RazonSocial;
		private string TuNombre;
		private string TuApellido;
		private int Telefono;
		private string UsrTipo;

		//oferta empleo
		public int idOferta { get => IdOferta; set => IdOferta = value; }
		public int idEmpresa { get => IdEmpresa; set => IdEmpresa = value; }
		public string tituloOferta { get => TituloOferta; set => TituloOferta = value; }
		public string puesto { get => Puesto; set => Puesto = value; }
		public int area { get => Area; set => Area = value; }
		public int subArea { get => SubArea; set => SubArea = value; }
		public string descripcionOferta { get => DescripcionOferta; set => DescripcionOferta = value; }
		public string ubicacion { get => Ubicacion; set => Ubicacion = value; }
		public int numeroVacantes { get => NumeroVacantes; set => NumeroVacantes = value; }
		public string fechaFin { get => FechaFin; set => FechaFin = value; }
		public int tipoDeContrato { get => TipoDeContrato; set => TipoDeContrato = value; }
		public int salario { get => Salario; set => Salario = value; }
		//aca el que falte
		public bool jornadraLaboral { get => JornadraLaboral; set => JornadraLaboral = value; }
		public bool movilidadRequerida { get => MovilidadRequerida; set => MovilidadRequerida = value; }
		public bool educacionRequerida { get => EducacionRequerida; set => EducacionRequerida = value; }
		public int estado { get => Estado; set => Estado = value; }


		//empresa
		public string email { get => Email; set => Email = value; }
		public string clave { get => Clave; set => Clave = value; }
		public string nombreEmpresa { get => NombreEmpresa; set => NombreEmpresa = value; }
		public string razonSocial { get => RazonSocial; set => RazonSocial = value; }
		public string tuNombre { get => TuNombre; set => TuNombre = value; }
		public string tuApellido { get => TuApellido; set => TuApellido = value; }
		public int telefono { get => Telefono; set => Telefono = value; }
		public string usrTipo { get => UsrTipo; set => UsrTipo = value; }
	}
}