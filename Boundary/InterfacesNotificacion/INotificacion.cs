using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.Boundary.InterfacesNotificacion
{
    public interface INotificacion
    {
        public bool enviarNotificacion(List<string> datosReserva);
    }
}
