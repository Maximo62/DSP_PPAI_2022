using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.Entidades
{
    public class Turno
    {
        private DateTime fechaGeneracion;
        private string diaSemana;
        private DateTime fechaHoraInicio;
        private DateTime fechaHoraFin;
        private CambioEstadoTurno[] cambiosEstadoTurnos;
        private RecursoTecnologico recursoTecnologico;

        public Turno(DateTime fechaGeneracion, string diaSemana, DateTime fechaHoraInicio, DateTime fechaHoraFin, CambioEstadoTurno[] cambioEstadoTurno, RecursoTecnologico recursoTecnologico)
        {
            this.fechaGeneracion = fechaGeneracion;
            this.diaSemana = diaSemana;
            this.fechaHoraInicio = fechaHoraInicio;
            this.fechaHoraFin = fechaHoraFin;
            this.cambiosEstadoTurnos = cambioEstadoTurno;
            this.recursoTecnologico = recursoTecnologico;
        }

        public DateTime FechaGeneracion { get => fechaGeneracion; set => fechaGeneracion = value; }
        public string DiaSemana { get => diaSemana; set => diaSemana = value; }
        public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
        public DateTime FechaHoraFin { get => fechaHoraFin; set => fechaHoraFin = value; }
        
        public RecursoTecnologico RecursoTecnologico { get => recursoTecnologico; set => recursoTecnologico = value; }
        public CambioEstadoTurno[] CambioEstadoTurno { get => cambiosEstadoTurnos; set => cambiosEstadoTurnos = value; }
    }
}
