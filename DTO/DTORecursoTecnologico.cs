using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.DTO
{
    public class DTORecursoTecnologico
    {
        private int numeroRT;
        private string nombreCentroDeInvestigacion;
        private string nombreEstadoActual;
        private string modeloYMarca;
        private string nombreTipoRT;

        public int NumeroRT { get => numeroRT; set => numeroRT = value; }
        public string NombreCentroDeInvestigacion { get => nombreCentroDeInvestigacion; set => nombreCentroDeInvestigacion = value; }
        public string NombreEstadoActual { get => nombreEstadoActual; set => nombreEstadoActual = value; }
        public string ModeloYMarca { get => modeloYMarca; set => modeloYMarca = value; }
        public string NombreTipoRT { get => nombreTipoRT; set => nombreTipoRT = value; }
    }
}
