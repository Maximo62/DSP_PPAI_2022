using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSI_PPAI.Boundary.InterfacesNotificacion;

namespace DSI_PPAI.Entidades
{
    public class NotificacionMail : INotificacion
    {
        public bool enviarNotificacion(List<string> datosReserva)
        {
            return true;
        }
    }
}
