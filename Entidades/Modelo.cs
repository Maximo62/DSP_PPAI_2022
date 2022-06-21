using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.Entidades
{
    public class Modelo
    {
        private string nombre;
        private string marca;

        public Modelo(string nombre, string marca)
        {
            this.nombre = nombre;
            this.Marca = marca;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Marca { get => marca; set => marca = value; }


        public string getModeloYMarca()
        {
            return this.Nombre + " - " + this.Marca;
        }
    }
}
