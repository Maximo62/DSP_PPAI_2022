using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSI_PPAI.DTO;

namespace DSI_PPAI.Boundary.RegistrarTurno
{
    public partial class ModalConfirmacion : Form
    {
        private PantallaRegistrarTurnoRT pantallaRegistrarTurno { get; set; } 

        public ModalConfirmacion()
        {
            InitializeComponent();
        }
        public void habilitarVentana(List<string> datosConfirmacionReserva, List<string> listaTipos, PantallaRegistrarTurnoRT pantallaRegistrarTurnoRT)
        {
            this.pantallaRegistrarTurno = pantallaRegistrarTurnoRT;

            lblRecursoNumero.Text = datosConfirmacionReserva[0];
            lblRecursoTipo.Text = datosConfirmacionReserva[1];
            lblRecursoModeloMarca.Text = datosConfirmacionReserva[2];
            lblRecursoCI.Text = datosConfirmacionReserva[3];
            lblDiaFecha.Text = datosConfirmacionReserva[4] + " - " + DateTime.Parse(datosConfirmacionReserva[5]).Date.ToShortDateString();
            lblHoraInicio.Text = DateTime.Parse(datosConfirmacionReserva[5]).TimeOfDay.ToString();
            lblHoraFin.Text = DateTime.Parse(datosConfirmacionReserva[6]).TimeOfDay.ToString();
            lblNombreCientifico.Text = datosConfirmacionReserva[7];
            lblLegajoCientifico.Text = datosConfirmacionReserva[8];

            cboTiposNotificacion.Items.AddRange(listaTipos.ToArray());
            cboTiposNotificacion.SelectedIndex = 0;
            cboTiposNotificacion.Refresh();


            this.Show();
        }

        private void tomarConfirmacionReserva(object sender, EventArgs e)
        {
            int indiceTipoSeleccionado = cboTiposNotificacion.SelectedIndex;
            this.pantallaRegistrarTurno.tomarConfirmacionreserva(indiceTipoSeleccionado);
            this.Dispose();
        }

        private void ocultarPantalla(object sender, EventArgs e)
        {
            MessageBox.Show("La reserva se canceló correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }
    }
}
