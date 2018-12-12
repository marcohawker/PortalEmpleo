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
		private int volarea;
		private int volsubarea;
		private string voldesc;
		private string volugar;
		private int volvac;
		private int volvacdisp;
		private DateTime volfechainic;
		private DateTime volfechafin;
		private bool voljornada;
		private bool volmov;
		private int VolTcontrato;
		private bool Voledu;
		private int volestado;

		public int VolID1 { get => VolID; set => VolID = value; }
		public int VolAutorID1 { get => VolAutorID; set => VolAutorID = value; }
		public string VolTitulo1 { get => VolTitulo; set => VolTitulo = value; }
		public string Volpuesto1 { get => Volpuesto; set => Volpuesto = value; }
		public int Volarea { get => volarea; set => volarea = value; }
		public int Volsubarea { get => volsubarea; set => volsubarea = value; }
		public string Voldesc { get => voldesc; set => voldesc = value; }
		public string Volugar { get => volugar; set => volugar = value; }
		public int Volvac { get => volvac; set => volvac = value; }
		public int Volvacdisp { get => volvacdisp; set => volvacdisp = value; }
		public DateTime Volfechainic { get => volfechainic; set => volfechainic = value; }
		public DateTime Volfechafin { get => volfechafin; set => volfechafin = value; }
		public bool Voljornada { get => voljornada; set => voljornada = value; }
		public bool Volmov { get => volmov; set => volmov = value; }
		public int VolTcontrato1 { get => VolTcontrato; set => VolTcontrato = value; }
		public bool Voledu1 { get => Voledu; set => Voledu = value; }
		public int Volestado { get => volestado; set => volestado = value; }
	}
}