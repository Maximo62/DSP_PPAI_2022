using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.Entidades
{
    public  class TipoNotificacion
    {
        private int idTipo;
        private string nombre;
        private string descripcion;

        public TipoNotificacion(int idTipo, string nombre, string descripcion   )
        {
            this.idTipo = idTipo;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdTipo { get => idTipo; set => idTipo = value; }
    }
}
