using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.DTO
{
    public class DTOTurno
    {
        private DateTime fechaHoraInicio;
        private DateTime fechaHoraFin;
        private string nombreEstadoActual;

        public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
        public DateTime FechaHoraFin { get => fechaHoraFin; set => fechaHoraFin = value; }
        public string NombreEstadoActual { get => nombreEstadoActual; set => nombreEstadoActual = value; }
    }
}
