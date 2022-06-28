namespace DSI_PPAI.Boundary
{
    partial class PantallaRegistrarTurnoRT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_tipoRecurso = new System.Windows.Forms.ComboBox();
            this.lbl_tipoRecurso = new System.Windows.Forms.Label();
            this.dgvRecursos = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelRecurso = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelTurno = new System.Windows.Forms.Button();
            this.dgvTurnos = new System.Windows.Forms.DataGridView();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_tipoRecurso
            // 
            this.cmb_tipoRecurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipoRecurso.FormattingEnabled = true;
            this.cmb_tipoRecurso.Location = new System.Drawing.Point(39, 34);
            this.cmb_tipoRecurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_tipoRecurso.Name = "cmb_tipoRecurso";
            this.cmb_tipoRecurso.Size = new System.Drawing.Size(272, 23);
            this.cmb_tipoRecurso.TabIndex = 0;
            // 
            // lbl_tipoRecurso
            // 
            this.lbl_tipoRecurso.AutoSize = true;
            this.lbl_tipoRecurso.Location = new System.Drawing.Point(25, 17);
            this.lbl_tipoRecurso.Name = "lbl_tipoRecurso";
            this.lbl_tipoRecurso.Size = new System.Drawing.Size(154, 15);
            this.lbl_tipoRecurso.TabIndex = 1;
            this.lbl_tipoRecurso.Text = "Tipo de recurso tecnologico";
            // 
            // dgvRecursos
            // 
            this.dgvRecursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecursos.Location = new System.Drawing.Point(14, 20);
            this.dgvRecursos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRecursos.Name = "dgvRecursos";
            this.dgvRecursos.RowHeadersWidth = 51;
            this.dgvRecursos.RowTemplate.Height = 29;
            this.dgvRecursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecursos.Size = new System.Drawing.Size(819, 141);
            this.dgvRecursos.TabIndex = 2;
            this.dgvRecursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.habilitarSeleccionRecurso);
            this.dgvRecursos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRecursos_CellFormatting);
            this.dgvRecursos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvRecursos_CellPainting);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(317, 35);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 22);
            this.button3.TabIndex = 6;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.tomarSeleccionTipoRT);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelRecurso);
            this.groupBox1.Controls.Add(this.dgvRecursos);
            this.groupBox1.Location = new System.Drawing.Point(25, 69);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(839, 204);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recursos Tecnologicos";
            // 
            // btnSelRecurso
            // 
            this.btnSelRecurso.Enabled = false;
            this.btnSelRecurso.Location = new System.Drawing.Point(751, 165);
            this.btnSelRecurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelRecurso.Name = "btnSelRecurso";
            this.btnSelRecurso.Size = new System.Drawing.Size(82, 22);
            this.btnSelRecurso.TabIndex = 7;
            this.btnSelRecurso.Text = "Seleccionar";
            this.btnSelRecurso.UseVisualStyleBackColor = true;
            this.btnSelRecurso.Click += new System.EventHandler(this.tomarSeleccionRT);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelTurno);
            this.groupBox2.Controls.Add(this.dgvTurnos);
            this.groupBox2.Location = new System.Drawing.Point(25, 278);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(839, 255);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Turnos Disponibles";
            // 
            // btnSelTurno
            // 
            this.btnSelTurno.Enabled = false;
            this.btnSelTurno.Location = new System.Drawing.Point(751, 220);
            this.btnSelTurno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelTurno.Name = "btnSelTurno";
            this.btnSelTurno.Size = new System.Drawing.Size(82, 22);
            this.btnSelTurno.TabIndex = 8;
            this.btnSelTurno.Text = "Seleccionar";
            this.btnSelTurno.UseVisualStyleBackColor = true;
            this.btnSelTurno.Click += new System.EventHandler(this.tomarSeleccionTurno);
            // 
            // dgvTurnos
            // 
            this.dgvTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnos.Location = new System.Drawing.Point(14, 20);
            this.dgvTurnos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.RowHeadersWidth = 51;
            this.dgvTurnos.RowTemplate.Height = 29;
            this.dgvTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurnos.Size = new System.Drawing.Size(819, 196);
            this.dgvTurnos.TabIndex = 3;
            this.dgvTurnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.habilitarSeleccionTurno);
            this.dgvTurnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.habilitarSeleccionTurno);
            this.dgvTurnos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTurnos_CellFormatting);
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Location = new System.Drawing.Point(737, 545);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(127, 26);
            this.btnCancelarReserva.TabIndex = 10;
            this.btnCancelarReserva.Text = "Cancelar Reserva";
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            this.btnCancelarReserva.Click += new System.EventHandler(this.cancelarReserva);
            // 
            // PantallaRegistrarTurnoRT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(876, 583);
            this.Controls.Add(this.btnCancelarReserva);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbl_tipoRecurso);
            this.Controls.Add(this.cmb_tipoRecurso);
            this.Name = "PantallaRegistrarTurnoRT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Turno Reserva";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmb_tipoRecurso;
        private Label lbl_tipoRecurso;
        private DataGridView dgvRecursos;
        private Button button3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnSelRecurso;
        private Button btnSelTurno;
        private DataGridView dgvTurnos;
        private Button btnCancelarReserva;
    }
}