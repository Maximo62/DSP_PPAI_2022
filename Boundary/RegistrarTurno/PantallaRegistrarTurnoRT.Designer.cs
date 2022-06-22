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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelRecurso = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvTurnos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_tipoRecurso
            // 
            this.cmb_tipoRecurso.FormattingEnabled = true;
            this.cmb_tipoRecurso.Location = new System.Drawing.Point(39, 34);
            this.cmb_tipoRecurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_tipoRecurso.Name = "cmb_tipoRecurso";
            this.cmb_tipoRecurso.Size = new System.Drawing.Size(207, 23);
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
            this.dgvRecursos.Size = new System.Drawing.Size(667, 141);
            this.dgvRecursos.TabIndex = 2;
            this.dgvRecursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.habilitarSeleccionRecurso);
            this.dgvRecursos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRecursos_CellFormatting);
            this.dgvRecursos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvRecursos_CellPainting);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(17, 20);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(329, 141);
            this.dataGridView2.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(251, 34);
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
            this.groupBox1.Size = new System.Drawing.Size(708, 204);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recursos Tecnologicos";
            // 
            // btnSelRecurso
            // 
            this.btnSelRecurso.Enabled = false;
            this.btnSelRecurso.Location = new System.Drawing.Point(598, 165);
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
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.dgvTurnos);
            this.groupBox2.Location = new System.Drawing.Point(25, 278);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(708, 255);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Turnos Disponibles";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(598, 220);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 22);
            this.button2.TabIndex = 8;
            this.button2.Text = "Seleccionar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgvTurnos
            // 
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnos.Location = new System.Drawing.Point(14, 20);
            this.dgvTurnos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.RowHeadersWidth = 51;
            this.dgvTurnos.RowTemplate.Height = 29;
            this.dgvTurnos.Size = new System.Drawing.Size(667, 196);
            this.dgvTurnos.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.dataGridView4);
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(755, 69);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(372, 464);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resumen";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(176, 428);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 22);
            this.button5.TabIndex = 10;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(263, 428);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 22);
            this.button4.TabIndex = 9;
            this.button4.Text = "Confirmar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(17, 228);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 29;
            this.dataGridView4.Size = new System.Drawing.Size(329, 196);
            this.dataGridView4.TabIndex = 6;
            // 
            // PantallaRegistrarTurnoRT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1153, 549);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbl_tipoRecurso);
            this.Controls.Add(this.cmb_tipoRecurso);
            this.Name = "PantallaRegistrarTurnoRT";
            this.Text = "Registrar Turno Reserva";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmb_tipoRecurso;
        private Label lbl_tipoRecurso;
        private DataGridView dgvRecursos;
        private DataGridView dataGridView2;
        private Button button3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnSelRecurso;
        private Button button2;
        private DataGridView dgvTurnos;
        private GroupBox groupBox3;
        private Button button5;
        private Button button4;
        private DataGridView dataGridView4;
    }
}