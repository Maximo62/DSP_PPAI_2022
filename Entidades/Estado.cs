using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.Entidades
{
    public class Estado
    {
        private string nombre;
        private string descripcion;
        private string ambito;
        private bool esReservable;
        private bool esCancelable;

        public Estado(string nombre, string descripcion, string ambito, bool esReservable, bool esCancelable)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.ambito = ambito;
            this.esReservable = esReservable;
            this.esCancelable = esCancelable;
            
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Ambito { get => ambito; set => ambito = value; }
        public bool EsReservable { get => esReservable; set => esReservable = value; }
        public bool EsCancelable { get => esCancelable; set => esCancelable = value; }
        
    }
}
