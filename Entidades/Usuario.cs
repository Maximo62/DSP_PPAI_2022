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
        private string usuarioNombre;
        private bool habilitado;

        public string Clave { get => clave; set => clave = value; }
        public string UsuarioNombre { get => usuarioNombre; set => usuarioNombre = value; }
        public bool Habilitado { get => habilitado; set => habilitado = value; }
    }
}
