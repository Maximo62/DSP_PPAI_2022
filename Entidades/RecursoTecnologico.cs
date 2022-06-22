using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSI_PPAI.DTO;

namespace DSI_PPAI.Entidades { 

	/// <summary>
	/// Summary description for Class1
	/// </summary>
	public class RecursoTecnologico
	{
		private int numeroRT;
		private DateTime fechaAlta;
		private object imagen;
		private int periodicidadMantenimientoPrev;
		private int duracionMantenimientoPrev;
		private int fraccionHorarioTurnos;
		private CambioEstadoRT[] cambiosEstadoRT;
		private TipoRecursoTecnologico tipoRecursoTecnologico;
		private Modelo modelo;
		private List<Turno> turnos;
        private CentroDeInvestigacion centroDeInvestigacion;

        //Constructur sin turnos
        public RecursoTecnologico(int numeroRT, DateTime fechaAlta, object imagen, int periodicidadMantenimientoPrev, int duracionMantenimientoPrev, int fraccionHorarioTurnos, CambioEstadoRT[] cambiosEstadoRT, TipoRecursoTecnologico tipoRecursoTecnologico, Modelo modelo)
        {
            this.numeroRT = numeroRT;
            this.fechaAlta = fechaAlta;
            this.imagen = imagen;
            this.periodicidadMantenimientoPrev = periodicidadMantenimientoPrev;
            this.duracionMantenimientoPrev = duracionMantenimientoPrev;
            this.fraccionHorarioTurnos = fraccionHorarioTurnos;
            this.cambiosEstadoRT = cambiosEstadoRT;
            this.tipoRecursoTecnologico = tipoRecursoTecnologico;
            this.modelo = modelo;
        }
        //Constructor completo
        public RecursoTecnologico(int numeroRT, DateTime fechaAlta, object imagen, int periodicidadMantenimientoPrev, int duracionMantenimientoPrev, int fraccionHorarioTurnos, List<Turno> turnos, CambioEstadoRT[] cambiosEstadoRT, TipoRecursoTecnologico tipoRecursoTecnologico, Modelo modelo)
        {
            this.numeroRT = numeroRT;
            this.fechaAlta = fechaAlta;
            this.imagen = imagen;
            this.periodicidadMantenimientoPrev = periodicidadMantenimientoPrev;
            this.duracionMantenimientoPrev = duracionMantenimientoPrev;
            this.fraccionHorarioTurnos = fraccionHorarioTurnos;
            this.turnos = turnos;
            this.cambiosEstadoRT = cambiosEstadoRT;
            this.tipoRecursoTecnologico = tipoRecursoTecnologico;
            this.modelo = modelo;
        }

        public int NumeroRT { get => numeroRT; set => numeroRT = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public object Imagen { get => imagen; set => imagen = value; }
        public int PeriodicidadMantenimientoPrev { get => periodicidadMantenimientoPrev; set => periodicidadMantenimientoPrev = value; }
        public int DuracionMantenimientoPrev { get => duracionMantenimientoPrev; set => duracionMantenimientoPrev = value; }
        public int FraccionHorarioTurnos { get => fraccionHorarioTurnos; set => fraccionHorarioTurnos = value; }
        public List<Turno> Turnos { get => turnos; set => turnos = value; }
        public CambioEstadoRT[] CambiosEstadoRT { get => cambiosEstadoRT; set => cambiosEstadoRT = value; }
        public TipoRecursoTecnologico TipoRecursoTecnologico { get => tipoRecursoTecnologico; set => tipoRecursoTecnologico = value; }
        public Modelo Modelo { get => modelo; set => modelo = value; }
        public CentroDeInvestigacion CentroDeInvestigacion { get => centroDeInvestigacion; set => centroDeInvestigacion = value; }



        public bool esTuTipoRT(string nombreTipoRT)
        {
            if (this.TipoRecursoTecnologico.Nombre.Equals(nombreTipoRT))
            {
                return this.sosRTActivo();
            }
            return false;
        }

        public bool sosRTActivo()
        {
            foreach (CambioEstadoRT cambioEstado in this.CambiosEstadoRT)
            {
                if( cambioEstado.sosEstadoActual())
                {
                    if (cambioEstado.sosReservable())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public string getCentroDeInvestigacion()
        {
            return this.centroDeInvestigacion.Nombre;
        }

        public string getEstadoActual()
        {
            foreach (CambioEstadoRT cambioEstado in this.CambiosEstadoRT)
            {
                if (cambioEstado.sosEstadoActual())
                {
                    return cambioEstado.getEstado();
                }
            }
            return "";
        }

        public string getModeloYMarca()
        {
            return this.modelo.getModeloYMarca();
        }

        public bool esCientificoDeCI(PersonalCientifico cientificoLogueado)
        {
            return this.centroDeInvestigacion.esCientificoDeCI(cientificoLogueado);
        }

        public List<DTOTurno> getTurnosRT(DateTime fechaActual)
        {
            List<DTOTurno> turnos = new List<DTOTurno>();
            foreach (Turno turno in this.turnos)
            {
                if (turno.esPosteriorFechaActual(fechaActual))
                {
                    turnos.Add(turno.getDatos());
                }
            }
            return turnos;
        }
    }

    
}