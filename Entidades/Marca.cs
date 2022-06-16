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
        private Modelo[] modelos;

        public string Nombre { get => nombre; set => nombre = value; }
        public Modelo[] Modelos { get => modelos; set => modelos = value; }
    }
}
