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
        private PersonalCientifico personalCientifico;

        public Usuario(string clave, string usuarioNombre, bool habilitado, PersonalCientifico personalCientifico)
        {
            this.clave = clave;
            this.usuarioNombre = usuarioNombre;
            this.habilitado = habilitado;
            this.personalCientifico = personalCientifico;
        }

        public string Clave { get => clave; set => clave = value; }
        public string UsuarioNombre { get => usuarioNombre; set => usuarioNombre = value; }
        public bool Habilitado { get => habilitado; set => habilitado = value; }
        public PersonalCientifico PersonalCientifico { get => personalCientifico; set => personalCientifico = value; }

        public PersonalCientifico getPersonalCientifico()
        {
            return this.personalCientifico;
        }
    }
}
