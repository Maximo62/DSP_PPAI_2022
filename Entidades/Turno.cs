using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public bool esPosteriorPlazoDefinido(DateTime fechaHoraPlazo)
        {
            return fechaHoraPlazo <= fechaHoraInicio;
        }

        public Dictionary<string, string> getDatos()
        {
            Dictionary<string, string> turno = new Dictionary<string, string>();
            turno.Add("Numero Turno", this.NroTurno.ToString());
            turno.Add("Fecha y Hora Inicio", this.FechaHoraInicio.ToString());
            turno.Add("Fecha y Hora Fin", this.FechaHoraFin.ToString());
            turno.Add("Dia Semana", this.DiaSemana);
            foreach (CambioEstadoTurno cambioEstadoTurno in this.CambioEstadoTurno)
            {
                if (cambioEstadoTurno.esEstadoActual())
                {
                    turno.Add("Estado", cambioEstadoTurno.getEstado());
                }
            }

            return turno;
        }
        // generamos la reserva del turno seteandole una fechaFin al cambio de estado actual y creando un nuevo cambio de estado con el estadoReservado que buscamos antes
        public void reservar(DateTime now, Estado reservado)
        {
            var cambioEstadoActual = this.cambiosEstadoTurnos.FirstOrDefault(cambioEstado => cambioEstado.esEstadoActual());
            cambioEstadoActual.setFechaFin(now);
            this.nuevoCambioEstadoTurno(now, reservado);
        }

        // llamamos al new del cambio de estado del turno
        public void nuevoCambioEstadoTurno(DateTime now, Estado reservado)
        {
            this.cambiosEstadoTurnos.Add(new CambioEstadoTurno(now, reservado));
        }
    }
}
