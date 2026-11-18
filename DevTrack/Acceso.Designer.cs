namespace DevTrack;

partial class Acceso
{
    private Label titulo = null!;
    private Label lblNombre = null!;
    private Label lblRol = null!;
    private TextBox txtNombre = null!;
    private ComboBox cmbRol = null!;
    private Button btnEntrar = null!;

    private void InitializeComponent()
    {
        titulo = new Label();
        lblNombre = new Label();
        lblRol = new Label();
        txtNombre = new TextBox();
        cmbRol = new ComboBox();
        btnEntrar = new Button();
        SuspendLayout();

        titulo.AutoSize = true;
        titulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
        titulo.ForeColor = Color.FromArgb(20, 40, 70);
        titulo.Location = new Point(34, 25);
        titulo.Text = "DevTrack";

        lblNombre.AutoSize = true;
        lblNombre.Location = new Point(37, 94);
        lblNombre.Text = "Nombre de usuario";
        txtNombre.Location = new Point(40, 121);
        txtNombre.Size = new Size(330, 29);
        txtNombre.TabIndex = 0;

        lblRol.AutoSize = true;
        lblRol.Location = new Point(37, 168);
        lblRol.Text = "Rol de la sesión";
        cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbRol.Location = new Point(40, 195);
        cmbRol.Size = new Size(330, 29);
        cmbRol.TabIndex = 1;

        btnEntrar.BackColor = Color.FromArgb(30, 69, 124);
        btnEntrar.FlatStyle = FlatStyle.Flat;
        btnEntrar.ForeColor = Color.White;
        btnEntrar.Location = new Point(40, 250);
        btnEntrar.Size = new Size(330, 44);
        btnEntrar.TabIndex = 2;
        btnEntrar.Text = "Entrar";
        btnEntrar.UseVisualStyleBackColor = false;
        btnEntrar.Click += Entrar_Click;

        AcceptButton = btnEntrar;
        AutoScaleDimensions = new SizeF(8F, 21F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(410, 334);
        Controls.Add(titulo);
        Controls.Add(lblNombre);
        Controls.Add(txtNombre);
        Controls.Add(lblRol);
        Controls.Add(cmbRol);
        Controls.Add(btnEntrar);
        Font = new Font("Segoe UI", 11F);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "Acceso";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Acceso a DevTrack";
        ResumeLayout(false);
        PerformLayout();
    }
}
