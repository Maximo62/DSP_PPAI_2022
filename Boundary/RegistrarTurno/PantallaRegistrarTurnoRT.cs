using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSI_PPAI.Control;


namespace DSI_PPAI.Boundary
{
    public partial class PantallaRegistrarTurnoRT : Form
    {

        GestorReservaTurnoRT gestorReservaTurnoRT { get; set; } 

        public PantallaRegistrarTurnoRT()
        {
            InitializeComponent();
        }


        public void tomarOpNuevoTurnoRT(GestorReservaTurnoRT gestorReservaTurnoRT)
        {
            this.habilitarVentana();

            this.gestorReservaTurnoRT = gestorReservaTurnoRT;
            gestorReservaTurnoRT.nuevoTurnoRT(this);

        }

        public void habilitarVentana()
        {
            this.Show();
        }

        public void pedirSeleccionTipoRT(String[] tipos)
        {
            cmb_tipoRecurso.Items.AddRange(tipos);
            cmb_tipoRecurso.Refresh();
        }

        private void tomarSeleccionTipoRT(object sender, EventArgs e)
        {
            int indiceTipoSeleccionado = cmb_tipoRecurso.SelectedIndex;
            gestorReservaTurnoRT.tomarSeleccionTipoRT(indiceTipoSeleccionado);
            
        }

        private void RegistrarTurno_Load(object sender, EventArgs e)
        {

        }










        // para borrar


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
