using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.DTO
{
    public class DTOTurno
    {
        private int nroTurno;
        private DateTime fechaHoraInicio;
        private DateTime fechaHoraFin;
        private string nombreEstadoActual;
        private string diaSemana;

        public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
        public DateTime FechaHoraFin { get => fechaHoraFin; set => fechaHoraFin = value; }
        public string NombreEstadoActual { get => nombreEstadoActual; set => nombreEstadoActual = value; }
        public int NroTurno { get => nroTurno; set => nroTurno = value; }
        public string DiaSemana { get => diaSemana; set => diaSemana = value; }
    }
}
