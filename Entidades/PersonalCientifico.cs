using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.Entidades
{
	public class PersonalCientifico
	{
		private int legajo;
		private string nombre;
		private string apellido;
		private int numeroDocumento;
		private string correoElectronicoInstitucional;
		private string correoElectronicoPersonal;
		private int telefonoCelular;
		private Usuario usuario;

        

        public PersonalCientifico()
		{
				

		}

        public int Legajo { get => legajo; set => legajo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int NumeroDocumento { get => numeroDocumento; set => numeroDocumento = value; }
        public string CorreoElectronicoInstitucional { get => correoElectronicoInstitucional; set => correoElectronicoInstitucional = value; }
        public string CorreoElectronicoPersonal { get => correoElectronicoPersonal; set => correoElectronicoPersonal = value; }
        public int TelefonoCelular { get => telefonoCelular; set => telefonoCelular = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }
    }