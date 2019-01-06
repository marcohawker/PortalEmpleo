using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalEmpleo.Models
{
	public class Voluntariado
	{
		private int VolID;
		private int VolAutorID;
		private string VolTitulo;
		private string Volpuesto;
		private int Volarea;
		private int Volsubarea;
		private string Voldesc;
		private string Volugar;
		private int Volvac;
		private int Volvacdisp;
		private DateTime Volfechainic;
		private String Volfechafin;
		private int Voljornada;
		private int Volmov;
		private int VolTcontrato;
		private int Voledu;
		private int Volestado;

		public int volID { get => VolID; set => VolID = value; }
		public int volAutorID { get => VolAutorID; set => VolAutorID = value; }
		public string volTitulo { get => VolTitulo; set => VolTitulo = value; }
		public string volpuesto { get => Volpuesto; set => Volpuesto = value; }
		public int volarea { get => Volarea; set => Volarea = value; }
		public int volsubarea { get => Volsubarea; set => Volsubarea = value; }
		public string voldesc { get => Voldesc; set => Voldesc = value; }
		public string volugar { get => Volugar; set => Volugar = value; }
		public int volvac { get => Volvac; set => Volvac = value; }
		public int volvacdisp { get => Volvacdisp; set => Volvacdisp = value; }
		public DateTime volfechainic { get => Volfechainic; set => Volfechainic = value; }
		public String volfechafin { get => Volfechafin; set => Volfechafin = value; }
		public int voljornada { get => Voljornada; set => Voljornada = value; }
		public int volmov { get => Volmov; set => Volmov = value; }
		public int volTcontrato { get => VolTcontrato; set => VolTcontrato = value; }
		public int voledu { get => Voledu; set => Voledu = value; }
		public int volestado { get => Volestado; set => Volestado = value; }
	}
}