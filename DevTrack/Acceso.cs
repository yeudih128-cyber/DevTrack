namespace DevTrack;

public partial class Acceso : Form
{
    public Acceso()
    {
        InitializeComponent();
        cmbRol.Items.AddRange(Almacen.Roles);
    }

    private void Entrar_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtNombre.Text) || cmbRol.SelectedItem is not string rol)
        {
            MessageBox.Show(this, "Escriba su nombre y seleccione un rol.", "Datos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        Sesion.Iniciar(txtNombre.Text, rol);
        DialogResult = DialogResult.OK;
    }
}
