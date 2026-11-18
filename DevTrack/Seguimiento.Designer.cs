namespace DevTrack
{
    partial class Seguimiento
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelTareas = new Panel();
            lblseguimiento = new Label();
            panelProyecto = new Panel();
            lblProyectosActivos = new Label();
            lblTotal = new Label();
            panel2 = new Panel();
            lblTareasCompletadas = new Label();
            lblCompletadas = new Label();
            panel3 = new Panel();
            lblTareasPendientes = new Label();
            lblPendientes = new Label();
            dgvSeguimiento = new DataGridView();
            coProyecto = new DataGridViewTextBoxColumn();
            colCompletadas = new DataGridViewTextBoxColumn();
            colPendientes = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            lblProgreso = new Label();
            panelTareas.SuspendLayout();
            panelProyecto.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSeguimiento).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panelTareas
            // 
            panelTareas.BackColor = Color.FromArgb(0, 0, 64);
            panelTareas.BorderStyle = BorderStyle.FixedSingle;
            panelTareas.Controls.Add(lblseguimiento);
            panelTareas.Location = new Point(4, 2);
            panelTareas.Margin = new Padding(4, 5, 4, 5);
            panelTareas.Name = "panelTareas";
            panelTareas.Size = new Size(971, 85);
            panelTareas.TabIndex = 2;
            // 
            // lblseguimiento
            // 
            lblseguimiento.AutoSize = true;
            lblseguimiento.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblseguimiento.ForeColor = Color.White;
            lblseguimiento.Location = new Point(4, 8);
            lblseguimiento.Margin = new Padding(4, 0, 4, 0);
            lblseguimiento.Name = "lblseguimiento";
            lblseguimiento.Size = new Size(619, 65);
            lblseguimiento.TabIndex = 0;
            lblseguimiento.Text = "Seguimiento de proyectos";
            // 
            // panelProyecto
            // 
            panelProyecto.BackColor = Color.FromArgb(192, 192, 255);
            panelProyecto.BorderStyle = BorderStyle.FixedSingle;
            panelProyecto.Controls.Add(lblProyectosActivos);
            panelProyecto.Controls.Add(lblTotal);
            panelProyecto.Location = new Point(10, 98);
            panelProyecto.Margin = new Padding(4, 5, 4, 5);
            panelProyecto.Name = "panelProyecto";
            panelProyecto.Size = new Size(289, 215);
            panelProyecto.TabIndex = 4;
            // 
            // lblProyectosActivos
            // 
            lblProyectosActivos.AutoSize = true;
            lblProyectosActivos.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProyectosActivos.Location = new Point(4, 0);
            lblProyectosActivos.Margin = new Padding(4, 0, 4, 0);
            lblProyectosActivos.Name = "lblProyectosActivos";
            lblProyectosActivos.Size = new Size(46, 55);
            lblProyectosActivos.TabIndex = 8;
            lblProyectosActivos.Text = "0";
            lblProyectosActivos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.FlatStyle = FlatStyle.Flat;
            lblTotal.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotal.ImageAlign = ContentAlignment.MiddleRight;
            lblTotal.Location = new Point(107, 107);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(186, 96);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Proyectos \r\nactivos";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MintCream;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblTareasCompletadas);
            panel2.Controls.Add(lblCompletadas);
            panel2.Location = new Point(670, 97);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(282, 215);
            panel2.TabIndex = 5;
            // 
            // lblTareasCompletadas
            // 
            lblTareasCompletadas.AutoSize = true;
            lblTareasCompletadas.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTareasCompletadas.Location = new Point(4, 0);
            lblTareasCompletadas.Margin = new Padding(4, 0, 4, 0);
            lblTareasCompletadas.Name = "lblTareasCompletadas";
            lblTareasCompletadas.Size = new Size(46, 55);
            lblTareasCompletadas.TabIndex = 10;
            lblTareasCompletadas.Text = "0";
            lblTareasCompletadas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCompletadas
            // 
            lblCompletadas.AutoSize = true;
            lblCompletadas.FlatStyle = FlatStyle.Flat;
            lblCompletadas.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCompletadas.ImageAlign = ContentAlignment.MiddleRight;
            lblCompletadas.Location = new Point(59, 107);
            lblCompletadas.Margin = new Padding(4, 0, 4, 0);
            lblCompletadas.Name = "lblCompletadas";
            lblCompletadas.Size = new Size(231, 96);
            lblCompletadas.TabIndex = 8;
            lblCompletadas.Text = "Tareas\r\nCompletadas";
            lblCompletadas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MistyRose;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblTareasPendientes);
            panel3.Controls.Add(lblPendientes);
            panel3.Location = new Point(327, 98);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(308, 215);
            panel3.TabIndex = 5;
            // 
            // lblTareasPendientes
            // 
            lblTareasPendientes.AutoSize = true;
            lblTareasPendientes.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTareasPendientes.Location = new Point(4, 0);
            lblTareasPendientes.Margin = new Padding(4, 0, 4, 0);
            lblTareasPendientes.Name = "lblTareasPendientes";
            lblTareasPendientes.Size = new Size(46, 55);
            lblTareasPendientes.TabIndex = 9;
            lblTareasPendientes.Text = "0";
            lblTareasPendientes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPendientes
            // 
            lblPendientes.AutoSize = true;
            lblPendientes.FlatStyle = FlatStyle.Flat;
            lblPendientes.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPendientes.ImageAlign = ContentAlignment.MiddleRight;
            lblPendientes.Location = new Point(104, 107);
            lblPendientes.Margin = new Padding(4, 0, 4, 0);
            lblPendientes.Name = "lblPendientes";
            lblPendientes.Size = new Size(206, 96);
            lblPendientes.TabIndex = 8;
            lblPendientes.Text = "Tareas \r\nPendientes \r\n";
            lblPendientes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvSeguimiento
            // 
            dgvSeguimiento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Navy;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSeguimiento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSeguimiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSeguimiento.Columns.AddRange(new DataGridViewColumn[] { coProyecto, colCompletadas, colPendientes, colTotal });
            dgvSeguimiento.EnableHeadersVisualStyles = false;
            dgvSeguimiento.Location = new Point(11, 553);
            dgvSeguimiento.Margin = new Padding(4, 5, 4, 5);
            dgvSeguimiento.Name = "dgvSeguimiento";
            dgvSeguimiento.RowHeadersWidth = 62;
            dgvSeguimiento.Size = new Size(941, 100);
            dgvSeguimiento.TabIndex = 6;
            // 
            // coProyecto
            // 
            coProyecto.HeaderText = "Proyecto";
            coProyecto.MinimumWidth = 8;
            coProyecto.Name = "coProyecto";
            // 
            // colCompletadas
            // 
            colCompletadas.HeaderText = "Completadas";
            colCompletadas.MinimumWidth = 8;
            colCompletadas.Name = "colCompletadas";
            // 
            // colPendientes
            // 
            colPendientes.HeaderText = "Pendientes";
            colPendientes.MinimumWidth = 8;
            colPendientes.Name = "colPendientes";
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total tareas";
            colTotal.MinimumWidth = 8;
            colTotal.Name = "colTotal";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Navy;
            panel4.Controls.Add(lblProgreso);
            panel4.Location = new Point(15, 393);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(933, 58);
            panel4.TabIndex = 7;
            // 
            // lblProgreso
            // 
            lblProgreso.AutoSize = true;
            lblProgreso.BackColor = Color.Navy;
            lblProgreso.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProgreso.ForeColor = SystemColors.ControlLightLight;
            lblProgreso.Location = new Point(4, 0);
            lblProgreso.Margin = new Padding(4, 0, 4, 0);
            lblProgreso.Name = "lblProgreso";
            lblProgreso.Size = new Size(258, 32);
            lblProgreso.TabIndex = 0;
            lblProgreso.Text = "Progreso de proyectos";
            lblProgreso.Click += lblProgreso_Click;
            // 
            // Seguimiento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 848);
            Controls.Add(panel4);
            Controls.Add(dgvSeguimiento);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panelProyecto);
            Controls.Add(panelTareas);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Seguimiento";
            Text = "Seguimiento";
            panelTareas.ResumeLayout(false);
            panelTareas.PerformLayout();
            panelProyecto.ResumeLayout(false);
            panelProyecto.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSeguimiento).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTareas;
        private Label lblseguimiento;
        private Panel panelProyecto;
        private Label lblTotal;
        private Panel panel2;
        private Panel panel3;
        private Label lblPendientes;
        private Label lblCompletadas;
        private DataGridView dgvSeguimiento;
        private Panel panel4;
        private Label lblProgreso;
        private Label lblProyectosActivos;
        private DataGridViewTextBoxColumn coProyecto;
        private DataGridViewTextBoxColumn colCompletadas;
        private DataGridViewTextBoxColumn colPendientes;
        private DataGridViewTextBoxColumn colTotal;
        private Label lblTareasCompletadas;
        private Label lblTareasPendientes;
    }
}