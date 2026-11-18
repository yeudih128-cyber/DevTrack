namespace DevTrack
{
    partial class Proyectos
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
            panelProyectos = new Panel();
            lblProyecto = new Label();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblfechaInicio = new Label();
            dtpInicio = new DateTimePicker();
            lblFechaFin = new Label();
            dtpFechaFin = new DateTimePicker();
            lblEstado = new Label();
            cmbEstado = new ComboBox();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Proyecto = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            panelProyectos.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelProyectos
            // 
            panelProyectos.BackColor = Color.FromArgb(0, 0, 64);
            panelProyectos.BorderStyle = BorderStyle.FixedSingle;
            panelProyectos.Controls.Add(lblProyecto);
            panelProyectos.Location = new Point(46, 3);
            panelProyectos.Name = "panelProyectos";
            panelProyectos.Size = new Size(604, 52);
            panelProyectos.TabIndex = 0;
            // 
            // lblProyecto
            // 
            lblProyecto.AutoSize = true;
            lblProyecto.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProyecto.ForeColor = Color.White;
            lblProyecto.Location = new Point(14, -1);
            lblProyecto.Name = "lblProyecto";
            lblProyecto.Size = new Size(177, 45);
            lblProyecto.TabIndex = 0;
            lblProyecto.Text = "Proyectos ";
            lblProyecto.Click += lblProyecto_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigo.ForeColor = Color.Navy;
            lblCodigo.Location = new Point(28, 74);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(73, 25);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCodigo.Location = new Point(34, 128);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(121, 27);
            txtCodigo.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.Navy;
            lblNombre.Location = new Point(213, 74);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(200, 25);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre del proyecto ";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(213, 128);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(214, 27);
            txtNombre.TabIndex = 4;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.ForeColor = Color.Navy;
            lblDescripcion.Location = new Point(502, 74);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(117, 25);
            lblDescripcion.TabIndex = 5;
            lblDescripcion.Text = "Descripción ";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(502, 111);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(176, 44);
            txtDescripcion.TabIndex = 6;
            // 
            // lblfechaInicio
            // 
            lblfechaInicio.AutoSize = true;
            lblfechaInicio.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblfechaInicio.ForeColor = Color.Navy;
            lblfechaInicio.Location = new Point(27, 201);
            lblfechaInicio.Name = "lblfechaInicio";
            lblfechaInicio.Size = new Size(150, 25);
            lblfechaInicio.TabIndex = 7;
            lblfechaInicio.Text = "Fecha de Inicio  ";
            // 
            // dtpInicio
            // 
            dtpInicio.CalendarForeColor = Color.Navy;
            dtpInicio.CalendarMonthBackground = SystemColors.HotTrack;
            dtpInicio.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(24, 242);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(163, 27);
            dtpInicio.TabIndex = 8;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaFin.ForeColor = Color.Navy;
            lblFechaFin.Location = new Point(281, 201);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(100, 25);
            lblFechaFin.TabIndex = 9;
            lblFechaFin.Text = "Fecha fin  ";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.CalendarForeColor = Color.Navy;
            dtpFechaFin.CalendarMonthBackground = SystemColors.HotTrack;
            dtpFechaFin.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(260, 242);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(163, 27);
            dtpFechaFin.TabIndex = 10;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.ForeColor = Color.Navy;
            lblEstado.Location = new Point(540, 201);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(79, 25);
            lblEstado.TabIndex = 11;
            lblEstado.Text = "Estado  ";
            // 
            // cmbEstado
            // 
            cmbEstado.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(515, 241);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(163, 28);
            cmbEstado.TabIndex = 13;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.RoyalBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Location = new Point(15, 17);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(128, 38);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.SkyBlue;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(337, 14);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(145, 41);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.SeaGreen;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = SystemColors.ButtonHighlight;
            btnEditar.Location = new Point(182, 17);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(125, 38);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkRed;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(532, 14);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(158, 41);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(btnLimpiar);
            panel2.Location = new Point(21, 421);
            panel2.Name = "panel2";
            panel2.Size = new Size(795, 67);
            panel2.TabIndex = 20;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, Proyecto, Estado });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(192, 192, 255);
            dataGridView1.Location = new Point(46, 335);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(724, 59);
            dataGridView1.TabIndex = 21;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            // 
            // Proyecto
            // 
            Proyecto.HeaderText = "Proyecto";
            Proyecto.Name = "Proyecto";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // Proyectos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 493);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(cmbEstado);
            Controls.Add(lblEstado);
            Controls.Add(dtpFechaFin);
            Controls.Add(lblFechaFin);
            Controls.Add(dtpInicio);
            Controls.Add(lblfechaInicio);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(panelProyectos);
            Name = "Proyectos";
            Text = "Proyectos";
            panelProyectos.ResumeLayout(false);
            panelProyectos.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelProyectos;
        private Label lblProyecto;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Label lblfechaInicio;
        private DateTimePicker dtpInicio;
        private Label lblFechaFin;
        private DateTimePicker dtpFechaFin;
        private Label lblEstado;
        private ComboBox cmbEstado;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnEditar;
        private Button btnEliminar;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Proyecto;
        private DataGridViewTextBoxColumn Estado;
    }
}