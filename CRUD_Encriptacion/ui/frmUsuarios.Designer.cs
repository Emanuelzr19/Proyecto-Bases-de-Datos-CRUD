namespace CRUD_Encriptacion.ui
{
    partial class frmUsuarios
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            dgvUsuarios = new DataGridView();
            clmID = new DataGridViewTextBoxColumn();
            clmUsuario = new DataGridViewTextBoxColumn();
            clmContraseña = new DataGridViewTextBoxColumn();
            clmRol = new DataGridViewTextBoxColumn();
            clmNombre = new DataGridViewTextBoxColumn();
            clmApellidos = new DataGridViewTextBoxColumn();
            clmEmail = new DataGridViewTextBoxColumn();
            clmTelefono = new DataGridViewTextBoxColumn();
            clmDireccion = new DataGridViewTextBoxColumn();
            clmCiudad = new DataGridViewTextBoxColumn();
            clmEstado = new DataGridViewTextBoxColumn();
            clmFechaNacimiento = new DataGridViewTextBoxColumn();
            clmPuesto = new DataGridViewTextBoxColumn();
            clmSalario = new DataGridViewTextBoxColumn();
            clmNSS = new DataGridViewTextBoxColumn();
            clmCuentaBancaria = new DataGridViewTextBoxColumn();
            lblTitle = new Label();
            btnEliminar = new Button();
            pnlTop = new Panel();
            lblSeleccionaUsuario = new Label();
            btnSalir = new Button();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuarios.ColumnHeadersHeight = 40;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { clmID, clmUsuario, clmContraseña, clmRol, clmNombre, clmApellidos, clmEmail, clmTelefono, clmDireccion, clmCiudad, clmEstado, clmFechaNacimiento, clmPuesto, clmSalario, clmNSS, clmCuentaBancaria });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(240, 240, 240);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.GridColor = Color.LightGray;
            dgvUsuarios.Location = new Point(0, 143);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowTemplate.Height = 35;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(1008, 458);
            dgvUsuarios.TabIndex = 2;
            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged;
            // 
            // clmID
            // 
            clmID.HeaderText = "ID";
            clmID.Name = "clmID";
            clmID.ReadOnly = true;
            clmID.Width = 44;
            // 
            // clmUsuario
            // 
            clmUsuario.HeaderText = "Usuario";
            clmUsuario.Name = "clmUsuario";
            clmUsuario.ReadOnly = true;
            clmUsuario.Width = 73;
            // 
            // clmContraseña
            // 
            clmContraseña.HeaderText = "Contraseña";
            clmContraseña.Name = "clmContraseña";
            clmContraseña.ReadOnly = true;
            clmContraseña.Width = 93;
            // 
            // clmRol
            // 
            clmRol.HeaderText = "Rol";
            clmRol.Name = "clmRol";
            clmRol.ReadOnly = true;
            clmRol.Width = 49;
            // 
            // clmNombre
            // 
            clmNombre.HeaderText = "Nombre(s)";
            clmNombre.Name = "clmNombre";
            clmNombre.ReadOnly = true;
            clmNombre.Width = 90;
            // 
            // clmApellidos
            // 
            clmApellidos.HeaderText = "Apellidos";
            clmApellidos.Name = "clmApellidos";
            clmApellidos.ReadOnly = true;
            clmApellidos.Width = 81;
            // 
            // clmEmail
            // 
            clmEmail.HeaderText = "Correo Electrónico";
            clmEmail.Name = "clmEmail";
            clmEmail.ReadOnly = true;
            clmEmail.Width = 123;
            // 
            // clmTelefono
            // 
            clmTelefono.HeaderText = "Teléfono";
            clmTelefono.Name = "clmTelefono";
            clmTelefono.ReadOnly = true;
            clmTelefono.Width = 80;
            // 
            // clmDireccion
            // 
            clmDireccion.HeaderText = "Dirección";
            clmDireccion.Name = "clmDireccion";
            clmDireccion.ReadOnly = true;
            clmDireccion.Width = 84;
            // 
            // clmCiudad
            // 
            clmCiudad.HeaderText = "Ciudad";
            clmCiudad.Name = "clmCiudad";
            clmCiudad.ReadOnly = true;
            clmCiudad.Width = 68;
            // 
            // clmEstado
            // 
            clmEstado.HeaderText = "Estado";
            clmEstado.Name = "clmEstado";
            clmEstado.ReadOnly = true;
            clmEstado.Width = 67;
            // 
            // clmFechaNacimiento
            // 
            clmFechaNacimiento.HeaderText = "Fecha de Nacimiento";
            clmFechaNacimiento.Name = "clmFechaNacimiento";
            clmFechaNacimiento.ReadOnly = true;
            clmFechaNacimiento.Width = 134;
            // 
            // clmPuesto
            // 
            clmPuesto.HeaderText = "Puesto";
            clmPuesto.Name = "clmPuesto";
            clmPuesto.ReadOnly = true;
            clmPuesto.Width = 69;
            // 
            // clmSalario
            // 
            clmSalario.HeaderText = "Salario";
            clmSalario.Name = "clmSalario";
            clmSalario.ReadOnly = true;
            clmSalario.Width = 68;
            // 
            // clmNSS
            // 
            clmNSS.HeaderText = "Numero de Seguro Social";
            clmNSS.Name = "clmNSS";
            clmNSS.ReadOnly = true;
            clmNSS.Width = 128;
            // 
            // clmCuentaBancaria
            // 
            clmCuentaBancaria.HeaderText = "Cuenta Bancaria";
            clmCuentaBancaria.Name = "clmCuentaBancaria";
            clmCuentaBancaria.ReadOnly = true;
            clmCuentaBancaria.Width = 110;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(27, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(275, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Reporte de Usuarios";
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminar.BackColor = Color.WhiteSmoke;
            btnEliminar.FlatAppearance.BorderColor = Color.Silver;
            btnEliminar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.Gray;
            btnEliminar.Location = new Point(710, 76);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 32);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.White;
            pnlTop.Controls.Add(lblSeleccionaUsuario);
            pnlTop.Controls.Add(btnSalir);
            pnlTop.Controls.Add(btnEditar);
            pnlTop.Controls.Add(btnEliminar);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1008, 143);
            pnlTop.TabIndex = 0;
            // 
            // lblSeleccionaUsuario
            // 
            lblSeleccionaUsuario.AutoSize = true;
            lblSeleccionaUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSeleccionaUsuario.ForeColor = Color.FromArgb(64, 64, 64);
            lblSeleccionaUsuario.Location = new Point(39, 78);
            lblSeleccionaUsuario.Name = "lblSeleccionaUsuario";
            lblSeleccionaUsuario.Size = new Size(178, 21);
            lblSeleccionaUsuario.TabIndex = 9;
            lblSeleccionaUsuario.Text = "Selecciona un usuario";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.WhiteSmoke;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.Gray;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.MiddleRight;
            btnSalir.Location = new Point(816, 76);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(113, 32);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Atrás";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditar.BackColor = Color.WhiteSmoke;
            btnEditar.FlatAppearance.BorderColor = Color.Silver;
            btnEditar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.Gray;
            btnEditar.Location = new Point(816, 40);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(113, 30);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 247);
            ClientSize = new Size(1008, 601);
            Controls.Add(dgvUsuarios);
            Controls.Add(pnlTop);
            Name = "frmUsuarios";
            Load += frmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmContraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNSS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCuentaBancaria;
        private Label lblTitle;
        private Button btnEliminar;
        private Panel pnlTop;
        private Button btnEditar;
        private Button btnSalir;
        private Label lblSeleccionaUsuario;
    }
}