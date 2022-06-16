using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.Entidades { 

	/// <summary>
	/// Summary description for Class1
	/// </summary>
	public class RecursoTecnologico
	{
		private int numeroRT;
		private DateTime fechaAlta;
		private Image imagen;
		private int periodicidadMantenimientoPrev;
		private int duracionMantenimientoPrev;
		private int fraccionHorarioTurnos;

        public RecursoTecnologico(int numeroRT, DateTime fechaAlta, Image imagen, int periodicidadMantenimientoPrev, int duracionMantenimientoPrev, int fraccionHorarioTurnos)
        {
            this.numeroRT = numeroRT;
            this.fechaAlta = fechaAlta;
            this.imagen = imagen;
            this.periodicidadMantenimientoPrev = periodicidadMantenimientoPrev;
            this.duracionMantenimientoPrev = duracionMantenimientoPrev;
            this.fraccionHorarioTurnos = fraccionHorarioTurnos;
        }

        public int NumeroRT { get => numeroRT; set => numeroRT = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
		public Image Imagen { get => imagen; set => imagen = value; }
		public int PeriodicidadMantenimientoPrev { get => periodicidadMantenimientoPrev; set => periodicidadMantenimientoPrev = value; }
        public int DuracionMantenimientoPrev { get => duracionMantenimientoPrev; set => duracionMantenimientoPrev = value; }
        public int FraccionHorarioTurnos { get => fraccionHorarioTurnos; set => fraccionHorarioTurnos = value; }
        
    }
}