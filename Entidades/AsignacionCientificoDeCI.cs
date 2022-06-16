using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.Entidades
{
    public class AsignacionCientificoDeCI
    {

        private DateTime fechaDesde;
        private DateTime fechaHasta;
        public AsignacionCientificoDeCI(DateTime fechaDesde, DateTime fechaHasta)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
        }

        public DateTime FechaDesde { get => fechaDesde; set => fechaDesde = value; }
        public DateTime FechaHasta { get => fechaHasta; set => fechaHasta = value; }
    }
}
