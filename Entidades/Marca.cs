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
        private List<Modelo> modelos;

        public Marca(string nombre, List<Modelo> modelos)
        {
            this.nombre = nombre;
            this.modelos = modelos;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public List<Modelo> Modelos { get => modelos; set => modelos = value; }

        public bool esTuModelo(Modelo modeloAComprobar)
        {
            foreach (Modelo modelo in Modelos)
            {
                if (modeloAComprobar.sosModelo(modelo))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
