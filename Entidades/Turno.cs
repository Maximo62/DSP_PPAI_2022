using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSI_PPAI.DTO;

namespace DSI_PPAI.Entidades
{
    public class Turno
    {
        private int nroTurno;
        private DateTime fechaGeneracion;
        private string diaSemana;
        private DateTime fechaHoraInicio;
        private DateTime fechaHoraFin;
        private List<CambioEstadoTurno> cambiosEstadoTurnos;
        private RecursoTecnologico recursoTecnologico;

        public Turno(DateTime fechaGeneracion, string diaSemana, DateTime fechaHoraInicio, DateTime fechaHoraFin, List<CambioEstadoTurno> cambioEstadoTurno, int nroTurno)
        {
            this.fechaGeneracion = fechaGeneracion;
            this.diaSemana = diaSemana;
            this.fechaHoraInicio = fechaHoraInicio;
            this.fechaHoraFin = fechaHoraFin;
            this.cambiosEstadoTurnos = cambioEstadoTurno;
            this.NroTurno = nroTurno;
        }

        public DateTime FechaGeneracion { get => fechaGeneracion; set => fechaGeneracion = value; }
        public string DiaSemana { get => diaSemana; set => diaSemana = value; }
        public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
        public DateTime FechaHoraFin { get => fechaHoraFin; set => fechaHoraFin = value; }
        
        public RecursoTecnologico RecursoTecnologico { get => recursoTecnologico; set => recursoTecnologico = value; }
        public List<CambioEstadoTurno> CambioEstadoTurno { get => cambiosEstadoTurnos; set => cambiosEstadoTurnos = value; }
        public int NroTurno { get => nroTurno; set => nroTurno = value; }

        public bool esPosteriorFechaActual(DateTime fechaActual)
        {
            return fechaActual < fechaHoraInicio;
        }

        public DTOTurno getDatos()
        {
            DTOTurno turno = new DTOTurno();
            turno.NroTurno = NroTurno;
            turno.FechaHoraInicio = this.fechaHoraInicio;
            turno.FechaHoraFin = this.fechaHoraFin;
            turno.DiaSemana = this.DiaSemana;
            foreach (CambioEstadoTurno cambioEstadoTurno in this.cambiosEstadoTurnos)
            {
                if (cambioEstadoTurno.esEstadoActual())
                {
                    turno.NombreEstadoActual = cambioEstadoTurno.getEstado();
                }
            }

            return turno;
        }

        public void reservar(DateTime now, Estado reservado)
        {
            var cambioEstadoActual = this.cambiosEstadoTurnos.FirstOrDefault(cambioEstado => cambioEstado.esEstadoActual());
            cambioEstadoActual.setFechaFin(now);
            this.nuevoCambioEstadoTurno(now, reservado);
        }

        public void nuevoCambioEstadoTurno(DateTime now, Estado reservado)
        {
            this.cambiosEstadoTurnos.Add(new CambioEstadoTurno(now, reservado));
        }
    }
}
