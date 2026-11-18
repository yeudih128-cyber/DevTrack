namespace DevTrack
{
    partial class Tareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tareas));
            panelTareas = new Panel();
            lblTareas = new Label();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblTituloTarea = new Label();
            txtTituloTarea = new TextBox();
            lblProyecto = new Label();
            cmbProyecto = new ComboBox();
            lblResponsable = new Label();
            cmbRerponsable = new ComboBox();
            lblPrioridad = new Label();
            cmbPrioridad = new ComboBox();
            lblFechaLimite = new Label();
            dtpFechaLimite = new DateTimePicker();
            lblEstado = new Label();
            panel3 = new Panel();
            cmbEstado = new ComboBox();
            dgvTareas = new DataGridView();
            Tarea = new DataGridViewTextBoxColumn();
            Responsable = new DataGridViewTextBoxColumn();
            Prioridad = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            panelTareas.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTareas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelTareas
            // 
            panelTareas.BackColor = Color.FromArgb(0, 0, 64);
            panelTareas.BorderStyle = BorderStyle.FixedSingle;
            panelTareas.Controls.Add(lblTareas);
            panelTareas.Location = new Point(47, 2);
            panelTareas.Name = "panelTareas";
            panelTareas.Size = new Size(604, 52);
            panelTareas.TabIndex = 1;
            // 
            // lblTareas
            // 
            lblTareas.AutoSize = true;
            lblTareas.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTareas.ForeColor = Color.White;
            lblTareas.Location = new Point(14, -1);
            lblTareas.Name = "lblTareas";
            lblTareas.Size = new Size(114, 45);
            lblTareas.TabIndex = 0;
            lblTareas.Text = "Tareas";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.RoyalBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Location = new Point(22, 120);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(161, 38);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkRed;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(22, 283);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(161, 38);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.SkyBlue;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = SystemColors.ButtonHighlight;
            btnModificar.Location = new Point(22, 201);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(161, 41);
            btnModificar.TabIndex = 17;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigo.ForeColor = Color.Navy;
            lblCodigo.Location = new Point(29, 62);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(73, 25);
            lblCodigo.TabIndex = 23;
            lblCodigo.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCodigo.Location = new Point(12, 105);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(144, 27);
            txtCodigo.TabIndex = 24;
            // 
            // lblTituloTarea
            // 
            lblTituloTarea.AutoSize = true;
            lblTituloTarea.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloTarea.ForeColor = Color.Navy;
            lblTituloTarea.Location = new Point(191, 62);
            lblTituloTarea.Name = "lblTituloTarea";
            lblTituloTarea.Size = new Size(146, 25);
            lblTituloTarea.TabIndex = 25;
            lblTituloTarea.Text = "Titulo de tarea  ";
            // 
            // txtTituloTarea
            // 
            txtTituloTarea.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTituloTarea.Location = new Point(190, 105);
            txtTituloTarea.Name = "txtTituloTarea";
            txtTituloTarea.Size = new Size(186, 27);
            txtTituloTarea.TabIndex = 26;
            // 
            // lblProyecto
            // 
            lblProyecto.AutoSize = true;
            lblProyecto.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProyecto.ForeColor = Color.Navy;
            lblProyecto.Location = new Point(445, 62);
            lblProyecto.Name = "lblProyecto";
            lblProyecto.Size = new Size(98, 25);
            lblProyecto.TabIndex = 27;
            lblProyecto.Text = "Proyecto  ";
            // 
            // cmbProyecto
            // 
            cmbProyecto.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbProyecto.FormattingEnabled = true;
            cmbProyecto.Location = new Point(434, 105);
            cmbProyecto.Name = "cmbProyecto";
            cmbProyecto.Size = new Size(187, 28);
            cmbProyecto.TabIndex = 28;
            // 
            // lblResponsable
            // 
            lblResponsable.AutoSize = true;
            lblResponsable.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResponsable.ForeColor = Color.Navy;
            lblResponsable.Location = new Point(12, 178);
            lblResponsable.Name = "lblResponsable";
            lblResponsable.Size = new Size(123, 25);
            lblResponsable.TabIndex = 29;
            lblResponsable.Text = "Responsable ";
            // 
            // cmbRerponsable
            // 
            cmbRerponsable.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbRerponsable.FormattingEnabled = true;
            cmbRerponsable.Location = new Point(12, 216);
            cmbRerponsable.Name = "cmbRerponsable";
            cmbRerponsable.Size = new Size(187, 28);
            cmbRerponsable.TabIndex = 30;
            // 
            // lblPrioridad
            // 
            lblPrioridad.AutoSize = true;
            lblPrioridad.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrioridad.ForeColor = Color.Navy;
            lblPrioridad.Location = new Point(242, 178);
            lblPrioridad.Name = "lblPrioridad";
            lblPrioridad.Size = new Size(95, 25);
            lblPrioridad.TabIndex = 31;
            lblPrioridad.Text = "Prioridad ";
            // 
            // cmbPrioridad
            // 
            cmbPrioridad.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbPrioridad.FormattingEnabled = true;
            cmbPrioridad.Location = new Point(242, 228);
            cmbPrioridad.Name = "cmbPrioridad";
            cmbPrioridad.Size = new Size(187, 28);
            cmbPrioridad.TabIndex = 32;
            // 
            // lblFechaLimite
            // 
            lblFechaLimite.AutoSize = true;
            lblFechaLimite.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaLimite.ForeColor = Color.Navy;
            lblFechaLimite.Location = new Point(25, 291);
            lblFechaLimite.Name = "lblFechaLimite";
            lblFechaLimite.Size = new Size(121, 25);
            lblFechaLimite.TabIndex = 33;
            lblFechaLimite.Text = "Fecha limite ";
            // 
            // dtpFechaLimite
            // 
            dtpFechaLimite.Format = DateTimePickerFormat.Short;
            dtpFechaLimite.Location = new Point(12, 339);
            dtpFechaLimite.Name = "dtpFechaLimite";
            dtpFechaLimite.Size = new Size(147, 23);
            dtpFechaLimite.TabIndex = 34;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.ForeColor = Color.Navy;
            lblEstado.Location = new Point(279, 291);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(74, 25);
            lblEstado.TabIndex = 35;
            lblEstado.Text = "Estado ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 0, 64);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(btnGuardar);
            panel3.Controls.Add(btnEliminar);
            panel3.Controls.Add(btnModificar);
            panel3.Location = new Point(657, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 525);
            panel3.TabIndex = 21;
            // 
            // cmbEstado
            // 
            cmbEstado.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(266, 334);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(121, 28);
            cmbEstado.TabIndex = 36;
            // 
            // dgvTareas
            // 
            dgvTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTareas.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTareas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTareas.Columns.AddRange(new DataGridViewColumn[] { Tarea, Responsable, Prioridad, Estado });
            dgvTareas.EnableHeadersVisualStyles = false;
            dgvTareas.Location = new Point(12, 449);
            dgvTareas.Name = "dgvTareas";
            dgvTareas.Size = new Size(618, 73);
            dgvTareas.TabIndex = 37;
            // 
            // Tarea
            // 
            Tarea.HeaderText = "Tarea";
            Tarea.Name = "Tarea";
            // 
            // Responsable
            // 
            Responsable.HeaderText = "Responsable";
            Responsable.Name = "Responsable";
            // 
            // Prioridad
            // 
            Prioridad.HeaderText = "Prioridad";
            Prioridad.Name = "Prioridad";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // Tareas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 529);
            Controls.Add(dgvTareas);
            Controls.Add(cmbEstado);
            Controls.Add(lblEstado);
            Controls.Add(dtpFechaLimite);
            Controls.Add(lblFechaLimite);
            Controls.Add(cmbPrioridad);
            Controls.Add(lblPrioridad);
            Controls.Add(cmbRerponsable);
            Controls.Add(lblResponsable);
            Controls.Add(cmbProyecto);
            Controls.Add(lblProyecto);
            Controls.Add(txtTituloTarea);
            Controls.Add(lblTituloTarea);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(panel3);
            Controls.Add(panelTareas);
            Name = "Tareas";
            Text = "Tareas";
            panelTareas.ResumeLayout(false);
            panelTareas.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTareas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTareas;
        private Label lblTareas;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnModificar;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblTituloTarea;
        private TextBox txtTituloTarea;
        private Label lblProyecto;
        private ComboBox cmbProyecto;
        private Label lblResponsable;
        private ComboBox cmbRerponsable;
        private Label lblPrioridad;
        private ComboBox cmbPrioridad;
        private Label lblFechaLimite;
        private DateTimePicker dtpFechaLimite;
        private Label lblEstado;
        private Panel panel3;
        private ComboBox cmbEstado;
        private DataGridView dgvTareas;
        private DataGridViewTextBoxColumn Tarea;
        private DataGridViewTextBoxColumn Responsable;
        private DataGridViewTextBoxColumn Prioridad;
        private DataGridViewTextBoxColumn Estado;
        private PictureBox pictureBox1;
    }
}