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
using DSI_PPAI.DTO;
using DSI_PPAI.Entidades;
using DSI_PPAI.Boundary.RegistrarTurno;


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
            cmb_tipoRecurso.Items.Add("Todos");
            cmb_tipoRecurso.Items.AddRange(tipos);
            cmb_tipoRecurso.Refresh();
            cmb_tipoRecurso.SelectedIndex = 0;
        }

        private void tomarSeleccionTipoRT(object sender, EventArgs e)
        {
            int indiceTipoSeleccionado = cmb_tipoRecurso.SelectedIndex;
            dgvTurnos.DataSource = null;
            gestorReservaTurnoRT.tomarSeleccionTipoRT(indiceTipoSeleccionado);
            
        }

        public void mostrarDatosRTActivos(List<Dictionary<string, string>> recursosActivos)
        {
            DataTable table = ToDataTable(recursosActivos);
            dgvRecursos.DataSource = table;


            dgvRecursos.Refresh();

            dgvRecursos.ClearSelection();

            if (dgvRecursos.Rows.Count.Equals(0))
            {
                MessageBox.Show("No se encontraron recursos tecnológicos para el tipo seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        DataTable ToDataTable(List<Dictionary<string, string>> list)
        {
            DataTable result = new DataTable();
            if (list.Count == 0)
                return result;

            var columnNames = list.SelectMany(dict => dict.Keys).Distinct();
            result.Columns.AddRange(columnNames.Select(c => new DataColumn(c)).ToArray());
            foreach (Dictionary<string, string> item in list)
            {
                var row = result.NewRow();
                foreach (var key in item.Keys)
                {
                    row[key] = item[key];
                }

                result.Rows.Add(row);
            }

            return result;
        }

        public void tomarSeleccionRT(object sender, EventArgs e)
        {
            DTORecursoTecnologico recursoSeleccionado = new DTORecursoTecnologico();
            if (dgvRecursos.CurrentRow != null)
            {
                recursoSeleccionado = (DTORecursoTecnologico)dgvRecursos.CurrentRow.DataBoundItem;
                gestorReservaTurnoRT.tomarSeleccionRT(recursoSeleccionado);
            }
        }

        public void mostrarTurnosDisponibles(List<DTOTurno> turnos)
        {
            dgvTurnos.DataSource = turnos;
            dgvTurnos.Columns["fechaHoraInicio"].DisplayIndex = 0;
            dgvTurnos.Columns["fechaHoraInicio"].HeaderText = "Fecha y Hora Inicio";
            dgvTurnos.Columns["fechaHoraFin"].DisplayIndex = 1;
            dgvTurnos.Columns["fechaHoraFin"].HeaderText = "Fecha y Hora Fin";
            dgvTurnos.Columns["nombreEstadoActual"].DisplayIndex = 2;
            dgvTurnos.Columns["nombreEstadoActual"].HeaderText = "Estado Actual";
            dgvTurnos.Columns["diaSemana"].Visible = false;
            dgvTurnos.ClearSelection();

            if (dgvTurnos.Rows.Count.Equals(0))
            {
                MessageBox.Show("No se encontraron turnos para el recurso seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tomarSeleccionTurno(object sender, EventArgs e)
        {
            DTOTurno turnoSeleccionado = new DTOTurno();
            if (dgvTurnos.CurrentRow != null)
            {
                turnoSeleccionado = (DTOTurno)dgvTurnos.CurrentRow.DataBoundItem;
                gestorReservaTurnoRT.tomarSeleccionTurno(turnoSeleccionado);
            }
        }

        public void solicitarConfirmacionReserva(DTOConfirmacionReserva datosConfirmacionReserva, List<string> tiposNotificacion)
        {
            ModalConfirmacion modalConfirmacion = new ModalConfirmacion();
            modalConfirmacion.habilitarVentana(datosConfirmacionReserva, tiposNotificacion, this);
        }

        public void tomarConfirmacionreserva(DTOConfirmacionReserva datosConfirmacion, int indiceTipoNotificacion)
        {
            gestorReservaTurnoRT.tomarConfirmacionReserva(datosConfirmacion, indiceTipoNotificacion);
        }


        #region Agrupamos recursos segun centro de investigacion
               

        private void dgvRecursos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Bottom =
               DataGridViewAdvancedCellBorderStyle.None;

            // Ignore column and row headers and first row
            if (e.RowIndex < 1 || e.ColumnIndex < 0)
                return;

            if (IsRepeatedCellValue(e.RowIndex, e.ColumnIndex))
            {
                e.AdvancedBorderStyle.Top =
                   DataGridViewAdvancedCellBorderStyle.None;
            }
            else
            {
                e.AdvancedBorderStyle.Top = e.AdvancedBorderStyle.Top;
            }
        }

        private void dgvRecursos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (IsRepeatedCellValue(e.RowIndex, e.ColumnIndex))
                {
                    e.Value = string.Empty;
                    e.FormattingApplied = true;
                }
            }
        }

        private bool IsRepeatedCellValue(int rowIndex, int colIndex)
        {
            DataGridViewCell currCell = dgvRecursos.Rows[rowIndex].Cells[colIndex]; /*Rows[rowIndex].Cells[colIndex];*/
            DataGridViewCell prevCell = dgvRecursos.Rows[rowIndex - 1].Cells[colIndex]; /*Rows[rowIndex - 1].Cells[colIndex];*/

            if (currCell.ColumnIndex == 1)
            {
                if ((currCell.Value == prevCell.Value) ||
                               (currCell.Value != null && prevCell.Value != null &&
                               currCell.Value.ToString() == prevCell.Value.ToString()))
                {
                    return true;
                }

                return false;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region metodos de soporte de la pantalla para mejorar la usabilidad



        public void mostrarErrorCientifico()
        {
            MessageBox.Show("El recurso seleccionado no pertenece a su centro de investigación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void mostrarErrorSinTurnos()
        {
            MessageBox.Show("No existen turnos disponibles para el recurso tecnológico seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       

        private void habilitarSeleccionRecurso(object sender, DataGridViewCellEventArgs e)
        {
            dgvTurnos.DataSource = null;
            btnSelRecurso.Enabled = true;
        }

        private void habilitarSeleccionTurno(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTurnos.CurrentRow.Cells[2].Value.Equals("Disponible"))
            {
                btnSelTurno.Enabled = true;
            } else
            {
                btnSelTurno.Enabled = false;
            }
        }

        public void mostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        public void ocultarPantalla()
        {
            this.Dispose();
        }

        private void cancelarReserva(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #endregion

        #region Asignamos color a turnos segun su disponibilidad

        private void dgvTurnos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow myRow in dgvTurnos.Rows)
            {
                if (myRow.Cells[2].Value.Equals("Disponible"))
                {
                    myRow.DefaultCellStyle.BackColor = Color.LightSkyBlue;
                } else if (myRow.Cells[2].Value.Equals("Pendiente de Confirmacion"))
                {
                    myRow.DefaultCellStyle.BackColor = Color.LightSteelBlue;
                } else
                {
                    myRow.DefaultCellStyle.BackColor = Color.IndianRed;
                }
            }
        }

        #endregion
    }
}
