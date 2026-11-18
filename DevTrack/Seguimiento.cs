using System;
using System.Linq;
using System.Windows.Forms;
namespace DevTrack;
public partial class Seguimiento : Form
{
    public Seguimiento()
    {
        InitializeComponent();
        dgvSeguimiento.AllowUserToAddRows = false;
        Actualizar();
        Almacen.Cambios += Actualizar;
        Disposed += (_, _) => Almacen.Cambios -= Actualizar;
    }
    private void Actualizar()
    {
        if (IsDisposed) return;
        dgvSeguimiento.Rows.Clear();
        foreach (var p in Almacen.Proyectos)
        {
            var tareas = Almacen.Tareas.Where(t => t.Proyecto == p.Nombre || t.Proyecto == p.Codigo).ToList();
            int hechas = tareas.Count(t => t.Estado == "Aprobada");
            dgvSeguimiento.Rows.Add(p.Nombre, hechas, tareas.Count - hechas, tareas.Count);
        }
        lblProyectosActivos.Text = Almacen.Proyectos.Count(p => p.Estado != "Finalizado").ToString();
        lblTareasCompletadas.Text = Almacen.Tareas.Count(t => t.Estado == "Aprobada").ToString();
        lblTareasPendientes.Text = Almacen.Tareas.Count(t => t.Estado != "Aprobada").ToString();
    }
    private void lblProgreso_Click(object sender, EventArgs e) { }
}
