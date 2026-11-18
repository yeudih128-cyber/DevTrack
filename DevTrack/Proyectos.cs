using System;
using System.Linq;
using System.Windows.Forms;

namespace DevTrack;
public partial class Proyectos : Form
{
    public Proyectos()
    {
        InitializeComponent();
        btnGuardar.Click += GuardarProyecto;
        btnEditar.Click += EditarProyecto;
        btnEliminar.Click += EliminarProyecto;
        btnLimpiar.Click += (_, _) => Limpiar();
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView1.MultiSelect = false;
        dataGridView1.ReadOnly = true;
        dataGridView1.SelectionChanged += (_, _) => Seleccionar();
        if (cmbEstado.Items.Count == 0) cmbEstado.Items.AddRange(Almacen.EstadosProyecto);
        dataGridView1.AllowUserToAddRows = false;
        Actualizar();
    }
    private void Actualizar()
    {
        dataGridView1.Rows.Clear();
        foreach (var x in Almacen.Proyectos)
            dataGridView1.Rows.Add(x.Codigo, x.Nombre, x.Estado);
        dataGridView1.ClearSelection();
    }
    private void Seleccionar()
    {
        if (dataGridView1.SelectedRows.Count == 0) return;
        var codigo = Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value);
        var x = Almacen.Proyectos.FirstOrDefault(p => p.Codigo == codigo);
        if (x == null) return;
        txtCodigo.Text = x.Codigo; txtNombre.Text = x.Nombre; txtDescripcion.Text = x.Descripcion;
        dtpInicio.Value = x.Inicio < dtpInicio.MinDate ? DateTime.Today : x.Inicio;
        dtpFechaFin.Value = x.Fin < dtpFechaFin.MinDate ? DateTime.Today : x.Fin;
        cmbEstado.Text = x.Estado;
    }
    private bool Validar()
    {
        if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
        { MessageBox.Show("Ingrese el código y el nombre del proyecto."); return false; }
        if (dtpFechaFin.Value.Date < dtpInicio.Value.Date)
        { MessageBox.Show("La fecha final no puede ser anterior al inicio."); return false; }
        return true;
    }
    private void GuardarProyecto(object? sender, EventArgs e)
    {
        if (!Sesion.TienePermiso("Proyectos")) { MessageBox.Show("No tiene permiso para crear proyectos."); return; }
        if (!Validar()) return;
        string codigo = txtCodigo.Text.Trim();
        if (Almacen.Proyectos.Any(p => p.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase)))
        { MessageBox.Show("Ya existe ese código. Use Editar para modificarlo."); return; }
        Almacen.Proyectos.Add(new ProyectoDato { Codigo = codigo, Nombre = txtNombre.Text.Trim(), Descripcion = txtDescripcion.Text, Inicio = dtpInicio.Value.Date, Fin = dtpFechaFin.Value.Date, Estado = cmbEstado.Text });
        Almacen.Registrar("Proyecto creado: " + codigo);
        Actualizar(); Limpiar(); MessageBox.Show("Proyecto guardado.");
    }
    private void EditarProyecto(object? sender, EventArgs e)
    {
        if (!Sesion.TienePermiso("Proyectos")) { MessageBox.Show("No tiene permiso para editar proyectos."); return; }
        if (!Validar()) return;
        var x = Almacen.Proyectos.FirstOrDefault(p => p.Codigo == txtCodigo.Text.Trim());
        if (x == null) { MessageBox.Show("Seleccione un proyecto existente."); return; }
        x.Nombre = txtNombre.Text.Trim(); x.Descripcion = txtDescripcion.Text;
        x.Inicio = dtpInicio.Value.Date; x.Fin = dtpFechaFin.Value.Date; x.Estado = cmbEstado.Text;
        Almacen.Registrar("Proyecto editado: " + x.Codigo);
        Actualizar(); Limpiar(); MessageBox.Show("Proyecto actualizado.");
    }
    private void EliminarProyecto(object? sender, EventArgs e)
    {
        if (!Sesion.TienePermiso("Proyectos")) { MessageBox.Show("No tiene permiso para eliminar proyectos."); return; }
        var x = Almacen.Proyectos.FirstOrDefault(p => p.Codigo == txtCodigo.Text.Trim());
        if (x == null) { MessageBox.Show("Seleccione un proyecto."); return; }
        if (Almacen.Tareas.Any(t => t.Proyecto == x.Codigo || t.Proyecto == x.Nombre))
        { MessageBox.Show("Este proyecto tiene tareas. Elimine o reasigne las tareas primero."); return; }
        if (MessageBox.Show("¿Eliminar proyecto?", "Confirmar", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
        Almacen.Proyectos.Remove(x); Almacen.Registrar("Proyecto eliminado: " + x.Codigo);
        Actualizar(); Limpiar();
    }
    private void Limpiar()
    {
        txtCodigo.Clear(); txtNombre.Clear(); txtDescripcion.Clear(); cmbEstado.SelectedIndex = -1;
        dtpInicio.Value = DateTime.Today; dtpFechaFin.Value = DateTime.Today;
        dataGridView1.ClearSelection();
    }
    private void lblProyecto_Click(object sender, EventArgs e) { }
}
