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
        private DateTime fechaHoraHasta;

        public CambioEstadoTurno(DateTime fechaHoraDesde, DateTime fechaHoraHasta)
        {
            this.fechaHoraDesde = fechaHoraDesde;
            this.fechaHoraHasta = fechaHoraHasta;
        }

        public DateTime FechaHoraDesde { get => fechaHoraDesde; set => fechaHoraDesde = value; }
        public DateTime FechaHoraHasta { get => fechaHoraHasta; set => fechaHoraHasta = value; }
    }
}
