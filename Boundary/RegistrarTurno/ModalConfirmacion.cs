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
        private DTOConfirmacionReserva datosReserva { get; set; }   

        public ModalConfirmacion()
        {
            InitializeComponent();
        }
        public void habilitarVentana(DTOConfirmacionReserva datosConfirmacionReserva, List<string> listaTipos, PantallaRegistrarTurnoRT pantallaRegistrarTurnoRT)
        {
            this.pantallaRegistrarTurno = pantallaRegistrarTurnoRT;

            lblRecursoNumero.Text = datosConfirmacionReserva.NumeroRT;
            lblRecursoTipo.Text = datosConfirmacionReserva.NombreTipo;
            lblRecursoModeloMarca.Text = datosConfirmacionReserva.ModeloYMarca;
            lblRecursoCI.Text = datosConfirmacionReserva.NombreCI;
            lblDiaFecha.Text = datosConfirmacionReserva.DiaSemana + " - " + datosConfirmacionReserva.FechaHoraInicio.Date.ToShortDateString();
            lblHoraInicio.Text = datosConfirmacionReserva.FechaHoraInicio.TimeOfDay.ToString();
            lblHoraFin.Text = datosConfirmacionReserva.FechaHoraFin.TimeOfDay.ToString();
            lblNombreCientifico.Text = datosConfirmacionReserva.NombreYApellido;
            lblLegajoCientifico.Text = datosConfirmacionReserva.Legajo;

            cboTiposNotificacion.Items.AddRange(listaTipos.ToArray());
            cboTiposNotificacion.SelectedIndex = 0;
            cboTiposNotificacion.Refresh();


            this.Show();
        }

        private void tomarConfirmacionReserva(object sender, EventArgs e)
        {
            int indiceTipoSeleccionado = cboTiposNotificacion.SelectedIndex;
            this.pantallaRegistrarTurno.tomarConfirmacionreserva(this.datosReserva, indiceTipoSeleccionado);
            this.Dispose();
        }

        private void ocultarPantalla(object sender, EventArgs e)
        {
            MessageBox.Show("La reserva se canceló correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }
    }
}
