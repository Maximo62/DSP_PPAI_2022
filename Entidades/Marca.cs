using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.Entidades
{
    public class Marca
    {
        private string nombre;

        public Marca(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
    }
}
