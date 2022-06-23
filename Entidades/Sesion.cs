using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.Entidades
{
    public class Sesion
    {
        private DateTime fechaHoraInicio;
        private DateTime? fechaHoraFin;
        private Usuario usuario;

        public Sesion(DateTime fechaHoraInicio, Usuario usuario)
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.Usuario = usuario;
        }

        public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
        public DateTime? FechaHoraFin { get => fechaHoraFin; set => fechaHoraFin = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }

        public PersonalCientifico obtenerUsuarioLogueado()
        {
            return this.usuario.getPersonalCientifico();
        }
    }
}
