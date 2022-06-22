using DSI_PPAI.Boundary;
using DSI_PPAI.Control;
using DSI_PPAI.Entidades;

namespace DSI_PPAI
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void registrarTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaRegistrarTurnoRT pantalla = new PantallaRegistrarTurnoRT();
            GestorReservaTurnoRT gestorReservaTurnoRT = new GestorReservaTurnoRT();

            pantalla.tomarOpNuevoTurnoRT(gestorReservaTurnoRT);
        }
    }
}