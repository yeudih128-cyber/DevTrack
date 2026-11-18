using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DevTrack
{
    public partial class Control_Calidad : Form
    {
        public Control_Calidad()
        {
            InitializeComponent();
            btnAprobar.Click += (_, _) => Revisar("Aprobada", "Aprobada");
            btnRechazar.Click += (_, _) => Revisar("Rechazada", "Rechazada");
            btnError.Click += (_, _) => Revisar("Rechazada", "Error reportado");
            cmbSeleccionarTarea.DropDown += (_, _) => CargarTareas();
            cmbSeleccionarTarea.SelectedIndexChanged += (_, _) => MostrarResponsable();
            dgvControlCalidad.AllowUserToAddRows = false;
            CargarTareas(); Actualizar();
        }
        private void CargarTareas()
        {
            string seleccion = cmbSeleccionarTarea.Text;
            cmbSeleccionarTarea.Items.Clear();
            foreach (var t in Almacen.Tareas.Where(x => x.Estado == "En revisión QA"))
                cmbSeleccionarTarea.Items.Add(t.Codigo + " - " + t.Titulo);
            cmbSeleccionarTarea.Text = seleccion;
            MostrarResponsable();
        }
        private void MostrarResponsable()
        {
            var t = TareaSeleccionada();
            txtResponsable.Text = t?.Responsable ?? "";
        }
        private TareaDato? TareaSeleccionada()
        {
            string codigo = cmbSeleccionarTarea.Text.Split(new[] { " - " }, StringSplitOptions.None)[0];
            return Almacen.Tareas.FirstOrDefault(t => t.Codigo == codigo);
        }
        private void Revisar(string estado, string resultado)
        {
            if (!Sesion.TienePermiso("Calidad")) { MessageBox.Show("No tiene permiso para realizar revisiones de QA."); return; }
            var t = TareaSeleccionada();
            if (t == null || t.Estado != "En revisión QA")
            { MessageBox.Show("Seleccione una tarea pendiente de revisión QA."); return; }
            if (resultado != "Aprobada" && string.IsNullOrWhiteSpace(textBox1.Text))
            { MessageBox.Show("Escriba una observación para el rechazo o error."); return; }
            t.Estado = estado; t.Resultado = resultado; t.Observacion = textBox1.Text.Trim();
            Almacen.Registrar("QA " + resultado + ": " + t.Codigo);
            textBox1.Clear(); cmbSeleccionarTarea.Text = ""; txtResponsable.Clear();
            CargarTareas(); Actualizar(); MessageBox.Show("Revisión registrada.");
        }
        private void Actualizar()
        {
            dgvControlCalidad.Rows.Clear();
            foreach (var t in Almacen.Tareas.Where(t => t.Estado == "En revisión QA" || !string.IsNullOrWhiteSpace(t.Resultado)))
                dgvControlCalidad.Rows.Add(t.Codigo, t.Titulo, t.Responsable, t.Estado, t.Resultado);
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Control_Calidad));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlMenu = new Panel();
            panelProyectos = new Panel();
            lblProyecto = new Label();
            pnlInicio = new Panel();
            btnRechazar = new Button();
            btnError = new Button();
            btnAprobar = new Button();
            pictureBox1 = new PictureBox();
            lblSeleccionarTarea = new Label();
            lblResponsable = new Label();
            cmbSeleccionarTarea = new ComboBox();
            txtResponsable = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            lblObservaciones = new Label();
            textBox1 = new TextBox();
            dgvControlCalidad = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Tarea = new DataGridViewTextBoxColumn();
            Responsable = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Resultado = new DataGridViewTextBoxColumn();
            pnlMenu.SuspendLayout();
            panelProyectos.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((ISupportInitialize)dgvControlCalidad).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(0, 0, 64);
            pnlMenu.Controls.Add(panelProyectos);
            pnlMenu.Controls.Add(pnlInicio);
            pnlMenu.Controls.Add(btnRechazar);
            pnlMenu.Controls.Add(btnError);
            pnlMenu.Controls.Add(btnAprobar);
            pnlMenu.Controls.Add(pictureBox1);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(208, 618);
            pnlMenu.TabIndex = 3;
            // 
            // panelProyectos
            // 
            panelProyectos.BackColor = Color.FromArgb(0, 0, 64);
            panelProyectos.BorderStyle = BorderStyle.FixedSingle;
            panelProyectos.Controls.Add(lblProyecto);
            panelProyectos.Location = new Point(208, 14);
            panelProyectos.Name = "panelProyectos";
            panelProyectos.Size = new Size(604, 52);
            panelProyectos.TabIndex = 16;
            // 
            // lblProyecto
            // 
            lblProyecto.AutoSize = true;
            lblProyecto.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProyecto.ForeColor = Color.White;
            lblProyecto.Location = new Point(14, -1);
            lblProyecto.Name = "lblProyecto";
            lblProyecto.Size = new Size(262, 65);
            lblProyecto.TabIndex = 0;
            lblProyecto.Text = "Proyectos ";
            // 
            // pnlInicio
            // 
            pnlInicio.BackColor = Color.Transparent;
            pnlInicio.Location = new Point(208, 9);
            pnlInicio.Name = "pnlInicio";
            pnlInicio.Size = new Size(643, 298);
            pnlInicio.TabIndex = 6;
            // 
            // btnRechazar
            // 
            btnRechazar.BackColor = Color.Silver;
            btnRechazar.FlatStyle = FlatStyle.Flat;
            btnRechazar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRechazar.ForeColor = Color.Navy;
            btnRechazar.Location = new Point(17, 441);
            btnRechazar.Name = "btnRechazar";
            btnRechazar.Size = new Size(161, 84);
            btnRechazar.TabIndex = 6;
            btnRechazar.Text = "Rechazar";
            btnRechazar.UseVisualStyleBackColor = false;
            // 
            // btnError
            // 
            btnError.BackColor = Color.Navy;
            btnError.FlatStyle = FlatStyle.Flat;
            btnError.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnError.ForeColor = Color.White;
            btnError.Location = new Point(12, 278);
            btnError.Name = "btnError";
            btnError.Size = new Size(161, 105);
            btnError.TabIndex = 3;
            btnError.Text = "Reportar error ";
            btnError.UseVisualStyleBackColor = false;
            // 
            // btnAprobar
            // 
            btnAprobar.BackColor = Color.Green;
            btnAprobar.FlatStyle = FlatStyle.Flat;
            btnAprobar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAprobar.ForeColor = Color.White;
            btnAprobar.Location = new Point(17, 127);
            btnAprobar.Name = "btnAprobar";
            btnAprobar.Size = new Size(161, 92);
            btnAprobar.TabIndex = 2;
            btnAprobar.Text = "Aprobar";
            btnAprobar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblSeleccionarTarea
            // 
            lblSeleccionarTarea.AutoSize = true;
            lblSeleccionarTarea.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeleccionarTarea.ForeColor = Color.Navy;
            lblSeleccionarTarea.Location = new Point(223, 126);
            lblSeleccionarTarea.Name = "lblSeleccionarTarea";
            lblSeleccionarTarea.Size = new Size(241, 40);
            lblSeleccionarTarea.TabIndex = 4;
            lblSeleccionarTarea.Text = "Seleccionar tarea";
            // 
            // lblResponsable
            // 
            lblResponsable.AutoSize = true;
            lblResponsable.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResponsable.ForeColor = Color.Navy;
            lblResponsable.Location = new Point(482, 126);
            lblResponsable.Name = "lblResponsable";
            lblResponsable.Size = new Size(181, 40);
            lblResponsable.TabIndex = 5;
            lblResponsable.Text = "Responsable";
            // 
            // cmbSeleccionarTarea
            // 
            cmbSeleccionarTarea.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbSeleccionarTarea.FormattingEnabled = true;
            cmbSeleccionarTarea.Location = new Point(223, 180);
            cmbSeleccionarTarea.Name = "cmbSeleccionarTarea";
            cmbSeleccionarTarea.Size = new Size(221, 39);
            cmbSeleccionarTarea.TabIndex = 14;
            // 
            // txtResponsable
            // 
            txtResponsable.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResponsable.Location = new Point(482, 182);
            txtResponsable.Name = "txtResponsable";
            txtResponsable.Size = new Size(214, 37);
            txtResponsable.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(223, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(604, 88);
            panel1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 0);
            label1.Name = "label1";
            label1.Size = new Size(499, 65);
            label1.TabIndex = 0;
            label1.Text = "Control Calidad (QA)";
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblObservaciones.ForeColor = Color.Navy;
            lblObservaciones.Location = new Point(214, 381);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(218, 40);
            lblObservaciones.TabIndex = 17;
            lblObservaciones.Text = "Observaciones ";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(214, 460);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(620, 114);
            textBox1.TabIndex = 18;
            // 
            // dgvControlCalidad
            // 
            dgvControlCalidad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvControlCalidad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvControlCalidad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvControlCalidad.Columns.AddRange(new DataGridViewColumn[] { Codigo, Tarea, Responsable, Estado, Resultado });
            dgvControlCalidad.EnableHeadersVisualStyles = false;
            dgvControlCalidad.Location = new Point(214, 261);
            dgvControlCalidad.Name = "dgvControlCalidad";
            dgvControlCalidad.RowHeadersWidth = 51;
            dgvControlCalidad.Size = new Size(655, 105);
            dgvControlCalidad.TabIndex = 19;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            // 
            // Tarea
            // 
            Tarea.HeaderText = "Tarea";
            Tarea.MinimumWidth = 6;
            Tarea.Name = "Tarea";
            // 
            // Responsable
            // 
            Responsable.HeaderText = "Responsable";
            Responsable.MinimumWidth = 6;
            Responsable.Name = "Responsable";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            // 
            // Resultado
            // 
            Resultado.HeaderText = "Resultado";
            Resultado.MinimumWidth = 6;
            Resultado.Name = "Resultado";
            // 
            // Control_Calidad
            // 
            ClientSize = new Size(1009, 618);
            Controls.Add(dgvControlCalidad);
            Controls.Add(textBox1);
            Controls.Add(lblObservaciones);
            Controls.Add(panel1);
            Controls.Add(txtResponsable);
            Controls.Add(cmbSeleccionarTarea);
            Controls.Add(lblResponsable);
            Controls.Add(lblSeleccionarTarea);
            Controls.Add(pnlMenu);
            Name = "Control_Calidad";
            pnlMenu.ResumeLayout(false);
            panelProyectos.ResumeLayout(false);
            panelProyectos.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)dgvControlCalidad).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private Panel pnlMenu;
        private Panel pnlInicio;
        private Button btnRechazar;
        private Button btnError;
        private Button btnAprobar;
        private Label lblSeleccionarTarea;
        private Label lblResponsable;
        private ComboBox cmbSeleccionarTarea;
        private TextBox txtResponsable;
        private Panel panelProyectos;
        private Label lblProyecto;
        private Panel panel1;
        private Label label1;
        private Label lblObservaciones;
        private TextBox textBox1;
        private DataGridView dgvControlCalidad;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Tarea;
        private DataGridViewTextBoxColumn Responsable;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Resultado;
        private PictureBox pictureBox1;
    }
}
