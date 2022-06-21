using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.Entidades
{
    public class CambioEstadoRT
    {
        private DateTime fechaHoraDesde;
        private DateTime? fechaHoraHasta;
        private Estado estado;

        public CambioEstadoRT(DateTime fechaHoraDesde, DateTime fechaHoraHasta, Estado estado)
        {
            this.fechaHoraDesde = fechaHoraDesde;
            this.fechaHoraHasta = fechaHoraHasta;
            this.estado = estado;
        }

        public CambioEstadoRT(DateTime fechaHoraDesde, Estado estado)
        {
            this.fechaHoraDesde = fechaHoraDesde;
            this.estado = estado;
        }

        public DateTime FechaHoraDesde { get => fechaHoraDesde; set => fechaHoraDesde = value; }
        public DateTime FechaHoraHasta { get => (DateTime)fechaHoraHasta; set => fechaHoraHasta = value; }
        public Estado Estado { get => estado; set => estado = value; }


        public bool sosEstadoActual()
        {
            return fechaHoraHasta.Equals(null) ? true : false;
        }

        public bool sosReservable()
        {
            return estado.sosReservable();
        }

        public string getEstado()
        {
            return this.Estado.Nombre;
        }
    }
}
