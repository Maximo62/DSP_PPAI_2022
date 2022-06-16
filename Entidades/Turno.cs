using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.Entidades
{
    public class Turno
    {
        private DateTime fechaDeclaracion;
        private string diaSemana;
        private DateTime fechaHoraInicio;
        private DateTime fechaHoraFin;

        public Turno(DateTime fechaDeclaracion, string diaSemana, DateTime fechaHoraInicio, DateTime fechaHoraFin)
        {
            this.fechaDeclaracion = fechaDeclaracion;
            this.diaSemana = diaSemana;
            this.fechaHoraInicio = fechaHoraInicio;
            this.fechaHoraFin = fechaHoraFin;
        }

        public DateTime FechaDeclaracion { get => fechaDeclaracion; set => fechaDeclaracion = value; }
        public string DiaSemana { get => diaSemana; set => diaSemana = value; }
        public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
        public DateTime FechaHoraFin { get => fechaHoraFin; set => fechaHoraFin = value; }
    }
}
