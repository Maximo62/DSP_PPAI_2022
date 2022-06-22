﻿using System;
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

        public void mostrarDatosRTActivos(List<DTORecursoTecnologico> recursosActivos)
        {
            dgvRecursos.DataSource = recursosActivos;
            dgvRecursos.Columns["nombreCentroDeInvestigacion"].DisplayIndex = 0;
            dgvRecursos.Columns["nombreCentroDeInvestigacion"].HeaderText = "Centro de Investigacion";
            dgvRecursos.Columns["numeroRT"].DisplayIndex = 1;
            dgvRecursos.Columns["numeroRT"].HeaderText = "Numero Recurso";
            dgvRecursos.Columns["modeloYMarca"].DisplayIndex = 2;
            dgvRecursos.Columns["modeloYMarca"].HeaderText = "Modelo y Marca";
            dgvRecursos.Columns["nombreEstadoActual"].DisplayIndex = 3;
            dgvRecursos.Columns["nombreEstadoActual"].HeaderText = "Estado Actual";

            if (dgvRecursos.Rows.Count.Equals(0))
            {
                MessageBox.Show("No se encontraron recursos tecnológicos para el tipo seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

            if (dgvTurnos.Rows.Count.Equals(0))
            {
                MessageBox.Show("No se encontraron turnos para el recurso seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void mostrarErrorCientifico()
        {
            MessageBox.Show("El recurso seleccionado no pertenece a su centro de investigación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void mostrarErrorSinTurnos()
        {
            MessageBox.Show("No existen turnos disponibles para el recurso tecnológico seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvRecursos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                return;
            }

            if (IsRepeatedCellValue(e.RowIndex, e.ColumnIndex))
            {
                e.Value = string.Empty;
                e.FormattingApplied = true;
            }
        }

        private bool IsRepeatedCellValue(int rowIndex, int colIndex)
        {
            DataGridViewCell currCell = dgvRecursos.CurrentRow.Cells[colIndex]; /*Rows[rowIndex].Cells[colIndex];*/
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

        private void btnSelRecurso_Click(object sender, EventArgs e)
        {

        }

        private void habilitarSeleccionRecurso(object sender, DataGridViewCellEventArgs e)
        {
            btnSelRecurso.Enabled = true;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
