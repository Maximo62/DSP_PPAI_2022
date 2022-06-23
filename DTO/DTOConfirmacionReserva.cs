using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.DTO
{
    public class DTOConfirmacionReserva
    {
        private string numeroRT;
        private string nombreTipo;
        private string nombreCI;
        private string modeloYMarca;
        private DateTime fechaHoraInicio;
        private DateTime fechaHoraFin;
        private string diaSemana;
        private string nombreYApellido;
        private string legajo;


        public string NumeroRT { get => numeroRT; set => numeroRT = value; }
        public string NombreTipo { get => nombreTipo; set => nombreTipo = value; }
        public string NombreCI { get => nombreCI; set => nombreCI = value; }
        public string ModeloYMarca { get => modeloYMarca; set => modeloYMarca = value; }
        public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
        public DateTime FechaHoraFin { get => fechaHoraFin; set => fechaHoraFin = value; }
        public string DiaSemana { get => diaSemana; set => diaSemana = value; }
        public string NombreYApellido { get => nombreYApellido; set => nombreYApellido = value; }
        public string Legajo { get => legajo; set => legajo = value; }
    }
}
