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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            lblUserFilter = new Label();
            txtUser = new TextBox();
            btnResetFilters = new Button();
            pnlTop = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvUsuarios.ColumnHeadersHeight = 40;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { clmID, clmUsuario, clmContraseña, clmRol, clmNombre, clmApellidos, clmEmail, clmTelefono, clmDireccion, clmCiudad, clmEstado, clmFechaNacimiento, clmPuesto, clmSalario, clmNSS, clmCuentaBancaria });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(240, 240, 240);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle6;
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.GridColor = Color.LightGray;
            dgvUsuarios.Location = new Point(0, 106);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowTemplate.Height = 35;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(1376, 495);
            dgvUsuarios.TabIndex = 2;
            dgvUsuarios.CellContentClick += dataGridView1_CellContentClick;
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
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(39, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(211, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Reporte de Usuarios";
            // 
            // lblUserFilter
            // 
            lblUserFilter.AutoSize = true;
            lblUserFilter.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserFilter.ForeColor = Color.DimGray;
            lblUserFilter.Location = new Point(12, 66);
            lblUserFilter.Name = "lblUserFilter";
            lblUserFilter.Size = new Size(59, 17);
            lblUserFilter.TabIndex = 4;
            lblUserFilter.Text = "Usuarios";
            // 
            // txtUser
            // 
            txtUser.BorderStyle = BorderStyle.FixedSingle;
            txtUser.Font = new Font("Segoe UI", 10F);
            txtUser.ForeColor = Color.Gray;
            txtUser.Location = new Point(77, 64);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(280, 25);
            txtUser.TabIndex = 5;
            txtUser.Text = "(Escribe para filtrar)";
            // 
            // btnResetFilters
            // 
            btnResetFilters.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnResetFilters.BackColor = Color.WhiteSmoke;
            btnResetFilters.FlatAppearance.BorderColor = Color.Silver;
            btnResetFilters.FlatStyle = FlatStyle.Flat;
            btnResetFilters.Font = new Font("Segoe UI", 9F);
            btnResetFilters.ForeColor = Color.Gray;
            btnResetFilters.Location = new Point(1153, 60);
            btnResetFilters.Name = "btnResetFilters";
            btnResetFilters.Size = new Size(100, 30);
            btnResetFilters.TabIndex = 6;
            btnResetFilters.Text = "Borrar Filtro";
            btnResetFilters.UseVisualStyleBackColor = false;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.White;
            pnlTop.Controls.Add(btnResetFilters);
            pnlTop.Controls.Add(txtUser);
            pnlTop.Controls.Add(lblUserFilter);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1376, 106);
            pnlTop.TabIndex = 0;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 247);
            ClientSize = new Size(1376, 601);
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
        private Label lblUserFilter;
        private TextBox txtUser;
        private Button btnResetFilters;
        private Panel pnlTop;
    }
}