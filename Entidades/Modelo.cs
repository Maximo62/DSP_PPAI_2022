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

        public Modelo(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }


        public string getModeloYMarca(List<Marca> marcas)
        {
            foreach (Marca marca in marcas)
            {
                if (marca.esTuModelo(this))
                {
                    return this.Nombre + " - " + marca.Nombre;
                }
            }
            return "";
        }
    }
}
