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

        public Usuario(string clave, string usuarioNombre, bool habilitado)
        {
            this.clave = clave;
            this.usuarioNombre = usuarioNombre;
            this.habilitado = habilitado;
        }

        public string Clave { get => clave; set => clave = value; }
        public string UsuarioNombre { get => usuarioNombre; set => usuarioNombre = value; }
        public bool Habilitado { get => habilitado; set => habilitado = value; }

        public PersonalCientifico getPersonalCientifico(List<PersonalCientifico> cientificos)
        {
            foreach (PersonalCientifico cientifico in cientificos)
            {
                if (cientifico.esTuUsuario(this))
                {
                    return cientifico;
                }
            }
            return null;
        }

        public bool sosUsuario(Usuario usuario)
        {
            return usuario.UsuarioNombre.Equals(this.UsuarioNombre);
        }
    }
}
