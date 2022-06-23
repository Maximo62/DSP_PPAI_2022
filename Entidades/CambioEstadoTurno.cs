using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.Entidades
{
    public class CambioEstadoTurno
    {
        private DateTime fechaHoraDesde;
        private DateTime? fechaHoraHasta;
        private Estado estado;
        private Turno turno;

        public CambioEstadoTurno(DateTime fechaHoraDesde, Estado estado)
        {
            this.fechaHoraDesde = fechaHoraDesde;
            this.estado = estado;
        }

        public DateTime FechaHoraDesde { get => fechaHoraDesde; set => fechaHoraDesde = value; }
        public DateTime FechaHoraHasta { get => (DateTime)fechaHoraHasta; set => fechaHoraHasta = value; }
        public Estado Estado { get => estado; set => estado = value; }
        public Turno Turno { get => turno; set => turno = value; }

        public bool esEstadoActual()
        {
            return fechaHoraHasta.Equals(null);
        }

        public string getEstado()
        {
            return estado.Nombre;
        }

        public void setFechaFin(DateTime now)
        {
            this.fechaHoraHasta = now;
        }
    }
}
