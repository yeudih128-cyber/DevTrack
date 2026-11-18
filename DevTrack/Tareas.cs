using System;
using System.Linq;
using System.Windows.Forms;
namespace DevTrack;
public partial class Tareas : Form
{
    public Tareas()
    {
        InitializeComponent();
        btnGuardar.Enabled = Sesion.TienePermiso("CrearTareas");
        btnModificar.Enabled = Sesion.TienePermiso("ActualizarTareas");
        btnEliminar.Enabled = Sesion.TienePermiso("EliminarTareas");
        btnGuardar.Click += GuardarTarea;
        btnModificar.Click += ModificarTarea;
        btnEliminar.Click += EliminarTarea;
        dgvTareas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvTareas.MultiSelect = false;
        dgvTareas.ReadOnly = true;
        dgvTareas.SelectionChanged += (_, _) => Seleccionar();
        cmbProyecto.DropDown += (_, _) => CargarProyectos();
        if (cmbEstado.Items.Count == 0) cmbEstado.Items.AddRange(Almacen.EstadosTarea.Take(3).ToArray());
        if (cmbPrioridad.Items.Count == 0) cmbPrioridad.Items.AddRange(Almacen.Prioridades);
        if (cmbRerponsable.Items.Count == 0) cmbRerponsable.Items.AddRange(new object[] { "Desarrollador", "Líder", "QA" });
        dgvTareas.AllowUserToAddRows = false;
        CargarProyectos(); Actualizar();
    }
    private void CargarProyectos()
    {
        string actual = cmbProyecto.Text;
        cmbProyecto.Items.Clear();
        foreach (var p in Almacen.Proyectos) cmbProyecto.Items.Add(p.Codigo);
        cmbProyecto.Text = actual;
    }
    private void Actualizar()
    {
        dgvTareas.Rows.Clear();
        foreach (var t in Almacen.Tareas.OrderBy(t => t.Prioridad == "Alta" ? 0 : t.Prioridad == "Media" ? 1 : 2).ThenBy(t => t.Limite))
            dgvTareas.Rows[dgvTareas.Rows.Add(t.Titulo, t.Responsable, t.Prioridad, t.Estado)].Tag = t;
        dgvTareas.ClearSelection();
    }
    private TareaDato? Actual() => Almacen.Tareas.FirstOrDefault(t => t.Codigo == txtCodigo.Text.Trim());
    private void Seleccionar()
    {
        if (dgvTareas.SelectedRows.Count == 0) return;
        int i = dgvTareas.SelectedRows[0].Index;
        if (i < 0 || i >= dgvTareas.Rows.Count) return;
        if (dgvTareas.Rows[i].Tag is not TareaDato t) return;
        txtCodigo.Text = t.Codigo; txtTituloTarea.Text = t.Titulo; cmbProyecto.Text = t.Proyecto;
        cmbRerponsable.Text = t.Responsable; cmbPrioridad.Text = t.Prioridad;
        cmbEstado.Text = t.Estado; dtpFechaLimite.Value = t.Limite < dtpFechaLimite.MinDate ? DateTime.Today : t.Limite;
    }
    private bool Validar()
    {
        if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtTituloTarea.Text) || string.IsNullOrWhiteSpace(cmbProyecto.Text) || string.IsNullOrWhiteSpace(cmbRerponsable.Text))
        { MessageBox.Show("Complete código, tarea, proyecto y responsable."); return false; }
        if (!Almacen.Proyectos.Any(p => p.Codigo == cmbProyecto.Text))
        { MessageBox.Show("Seleccione un proyecto registrado."); return false; }
        if (!Almacen.Prioridades.Contains(cmbPrioridad.Text))
        { MessageBox.Show("Seleccione una prioridad."); return false; }
        return true;
    }
    private void GuardarTarea(object? sender, EventArgs e)
    {
        if (!Sesion.TienePermiso("CrearTareas")) { MessageBox.Show("No tiene permiso para crear tareas."); return; }
        if (!Validar()) return;
        if (Actual() != null) { MessageBox.Show("Ese código ya existe."); return; }
        Almacen.Tareas.Add(new TareaDato { Codigo = txtCodigo.Text.Trim(), Titulo = txtTituloTarea.Text.Trim(), Proyecto = cmbProyecto.Text, Responsable = cmbRerponsable.Text, Prioridad = cmbPrioridad.Text, Estado = Almacen.EstadosTarea.Take(3).Contains(cmbEstado.Text) ? cmbEstado.Text : "Pendiente", Limite = dtpFechaLimite.Value.Date });
        Almacen.Registrar("Tarea creada: " + txtCodigo.Text); Actualizar(); Limpiar(); MessageBox.Show("Tarea guardada.");
    }
    private void ModificarTarea(object? sender, EventArgs e)
    {
        if (!Sesion.TienePermiso("ActualizarTareas")) { MessageBox.Show("No tiene permiso para modificar tareas."); return; }
        if (!Validar()) return;
        var t = dgvTareas.SelectedRows.Count == 1 ? dgvTareas.SelectedRows[0].Tag as TareaDato : null; if (t == null) { MessageBox.Show("Seleccione una tarea."); return; }
        t.Titulo = txtTituloTarea.Text.Trim(); t.Proyecto = cmbProyecto.Text; t.Responsable = cmbRerponsable.Text;
        t.Prioridad = cmbPrioridad.Text; if (Almacen.EstadosTarea.Take(3).Contains(cmbEstado.Text)) t.Estado = cmbEstado.Text; t.Limite = dtpFechaLimite.Value.Date;
        Almacen.Registrar("Tarea modificada: " + t.Codigo); Actualizar(); Limpiar(); MessageBox.Show("Tarea modificada.");
    }
    private void EliminarTarea(object? sender, EventArgs e)
    {
        if (!Sesion.TienePermiso("EliminarTareas")) { MessageBox.Show("No tiene permiso para eliminar tareas."); return; }
        var t = dgvTareas.SelectedRows.Count == 1 ? dgvTareas.SelectedRows[0].Tag as TareaDato : null; if (t == null) { MessageBox.Show("Seleccione una tarea."); return; }
        if (MessageBox.Show("¿Eliminar tarea?", "Confirmar", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
        Almacen.Tareas.Remove(t); Almacen.Registrar("Tarea eliminada: " + t.Codigo); Actualizar(); Limpiar();
    }
    private void Limpiar()
    {
        txtCodigo.Clear(); txtTituloTarea.Clear(); cmbProyecto.SelectedIndex = -1; cmbRerponsable.SelectedIndex = -1;
        cmbPrioridad.SelectedIndex = -1; cmbEstado.SelectedIndex = -1; dtpFechaLimite.Value = DateTime.Today;
        dgvTareas.ClearSelection();
    }
    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
}

