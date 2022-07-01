﻿using System;
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
		private object imagen;
		private int periodicidadMantenimientoPrev;
		private int duracionMantenimientoPrev;
		private int fraccionHorarioTurnos;
		private CambioEstadoRT[] cambiosEstadoRT;
		private TipoRecursoTecnologico tipoRecursoTecnologico;
		private Modelo modelo;
		private List<Turno> turnos;

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


        // verificamos si el tipo de recurso seleccionado es el tipo del recurso que se esta comprobando actualmente
        public bool esTuTipoRT(string nombreTipoRT)
        {
            return this.TipoRecursoTecnologico.Nombre.Equals(nombreTipoRT);
        }
        // Aqui consultamos el estado actual del recurso, consultando si es reservable
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

        public string? getCentroDeInvestigacion(List<CentroDeInvestigacion> centros)
        {
            foreach (CentroDeInvestigacion centro in centros)
            {
                if (centro.esTuRecurso(this))
                {
                    return centro.Nombre;
                }
            }
            return null;
        }

        public bool sosRecurso(RecursoTecnologico recurso)
        {
            return recurso.NumeroRT.Equals(this.NumeroRT);
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

        public string getModeloYMarca(List<Marca> marcas)
        {
            return this.modelo.getModeloYMarca(marcas);
        }

        public bool esCientificoDeCI(CentroDeInvestigacion centro, PersonalCientifico cientificoLogueado)
        {
            return centro.esCientificoDeCI(cientificoLogueado);
        }

        public List<Dictionary<string, string>> getTurnosRT(DateTime fechaActual)
        {
            List<Dictionary<string, string>> turnosRT = new List<Dictionary<string, string>>();
            if (this.turnos != null && this.turnos.Any())
            {
                foreach (Turno turno in this.turnos)
                {
                    if (turno.esPosteriorFechaActual(fechaActual))
                    {
                        turnosRT.Add(turno.getDatos());
                    }
                }
            }
            return turnosRT;
        }

        public List<Dictionary<string, string>> getTurnosRTDesdePlazo(DateTime fechaHoraPlazo)
        {
            List<Dictionary<string, string>> turnosRT = new List<Dictionary<string, string>>();
            foreach (Turno turno in this.turnos)
            {
                if (turno.esPosteriorPlazoDefinido(fechaHoraPlazo))
                {
                    turnosRT.Add(turno.getDatos());
                }
            }
            return turnosRT;
        }

        public string getNombreTipoRT()
        {
            return this.tipoRecursoTecnologico.Nombre;
        }

        public int obtenerPlazoMinimoReservaCI(CentroDeInvestigacion centro)
        {
            return centro.TiempoAntelacionReserva;
        }
    }

    
}