using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.Entidades
{
    public class Usuario
    {
        private string clave;
        private string nombreUsuario;
        private bool habilitado;

        public Usuario(string clave, string nombreUsuario, bool habilitado)
        {
            this.clave = clave;
            this.nombreUsuario = nombreUsuario;
            this.habilitado = habilitado;
        }

        public string Clave { get => clave; set => clave = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public bool Habilitado { get => habilitado; set => habilitado = value; }
    }
}
