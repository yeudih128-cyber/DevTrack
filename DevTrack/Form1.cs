namespace DevTrack
{
    public partial class Form1 : Form 
    {
        private Form? formularioActual;
        private Button? _botonActivo;
        private readonly Color _colorNormal = Color.Silver;
        private readonly Color _colorActivo = Color.LightSkyBlue;
    

        public Form1()
        {
            InitializeComponent();
            AplicarPermisos();
            btnProyectos.Click += btnProyectos_Click;
            btnTareas.Click += btnTareas_Click;
            btnCalidad.Click += btnCalidad_Click;
            btnSeguimiento.Click += btnSeguimiento_Click;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            button6.Click += btnInicio_Click;
            button5.Click += btnProyectos_Click;
            button4.Click += btnTareas_Click;
            button3.Click += btnCalidad_Click;
            button2.Click += btnSeguimiento_Click;
            button1.Click += btnCerrarSesion_Click;
            Almacen.Cambios += ActualizarResumen;
            FormClosed += (_, _) => Almacen.Cambios -= ActualizarResumen;
            ActualizarResumen();
        }

        private void AplicarPermisos()
        {
            btnProyectos.Enabled = Sesion.TienePermiso("Proyectos");
            btnTareas.Enabled = Sesion.TienePermiso("CrearTareas") || Sesion.TienePermiso("ConsultarTareas");
            btnCalidad.Enabled = Sesion.TienePermiso("Calidad");
            btnSeguimiento.Enabled = Sesion.TienePermiso("Seguimiento");
            // Los botones duplicados del menú lateral siguen los mismos permisos.
            button5.Enabled = btnProyectos.Enabled;
            button4.Enabled = btnTareas.Enabled;
            button3.Enabled = btnCalidad.Enabled;
            button2.Enabled = btnSeguimiento.Enabled;
        }

        private bool ExigirPermiso(string permiso)
        {
            if (Sesion.TienePermiso(permiso)) return true;
            MessageBox.Show("Su rol no tiene permiso para realizar esta acción.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private void ActualizarResumen()
        {
            lblCantidadProyectos.Text = Almacen.Proyectos.Count.ToString();
            lblCantidadTareas.Text = Almacen.Tareas.Count.ToString();
            lblCantidadPendientes.Text = Almacen.Tareas.Count(t => t.Estado != "Aprobada").ToString();
        }
        private void MostrarFormulario(Form formulario,Button boton) 
        {
            CerrarFormularioActual();

            formulario.TopLevel = false;                        
            formulario.FormBorderStyle = FormBorderStyle.None;  
            formulario.Dock = DockStyle.Fill;
            formulario.AutoScroll = true;                       

            pnlInicio.Visible = false;                          
            pnlContenido.Controls.Add(formulario);
            formulario.BringToFront();
            formulario.Show();

            formularioActual = formulario;
            MarcarBoton (boton);
        }

        private void CerrarFormularioActual()
        {
            if (formularioActual != null)
            {
                pnlContenido.Controls.Remove(formularioActual);
                formularioActual.Dispose();
                formularioActual = null;
            }
        }

        private void MarcarBoton(Button boton)
        {
            if (_botonActivo != null) _botonActivo.BackColor = _colorNormal;
            _botonActivo = boton;
            _botonActivo.BackColor = _colorActivo;
        }

        // ---------- Botones del menú ----------

        private void btnInicio_Click(object sender, EventArgs e)
        {
            CerrarFormularioActual();
            pnlInicio.Visible = true;
            ActualizarResumen();
            MarcarBoton(btnInicio);
        }

        private void btnProyectos_Click(object sender, EventArgs e)
        {
            if (!ExigirPermiso("Proyectos")) return;
            MostrarFormulario(new Proyectos(), btnProyectos);
        }

        private void btnTareas_Click(object sender, EventArgs e)
        {
            if (!Sesion.TienePermiso("CrearTareas") && !Sesion.TienePermiso("ConsultarTareas")) { ExigirPermiso("CrearTareas"); return; }
            MostrarFormulario(new Tareas(), btnTareas);
        }

        private void btnCalidad_Click(object sender, EventArgs e)
        {
            if (!ExigirPermiso("Calidad")) return;
            MostrarFormulario(new Control_Calidad(), btnCalidad);
        }

        private void btnSeguimiento_Click(object sender, EventArgs e)
        {
            if (!ExigirPermiso("Seguimiento")) return;
            MostrarFormulario(new Seguimiento(), btnSeguimiento);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea cerrar la sesión?", "Cerrar sesión",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Close();
            }
        }
    }





}

      