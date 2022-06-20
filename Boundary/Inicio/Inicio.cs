using DSI_PPAI.Boundary;

namespace DSI_PPAI
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void registrarTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaRegistrarTurnoRT RegistrarTurno = new PantallaRegistrarTurnoRT();
            RegistrarTurno.ShowDialog();
        }
    }
}