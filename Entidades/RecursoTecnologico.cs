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
		private Turno[] turnos;

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
        public RecursoTecnologico(int numeroRT, DateTime fechaAlta, object imagen, int periodicidadMantenimientoPrev, int duracionMantenimientoPrev, int fraccionHorarioTurnos, Turno[] turnos, CambioEstadoRT[] cambiosEstadoRT, TipoRecursoTecnologico tipoRecursoTecnologico, Modelo modelo)
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
        public Turno[] Turnos { get => turnos; set => turnos = value; }
        public CambioEstadoRT[] CambiosEstadoRT { get => cambiosEstadoRT; set => cambiosEstadoRT = value; }
        public TipoRecursoTecnologico TipoRecursoTecnologico { get => tipoRecursoTecnologico; set => tipoRecursoTecnologico = value; }
        public Modelo Modelo { get => modelo; set => modelo = value; }
    }

    
}