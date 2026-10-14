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
            dataGridView1 = new DataGridView();
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
            btnResetFilters = new Button();
            pnlTop = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clmID, clmUsuario, clmContraseña, clmRol, clmNombre, clmApellidos, clmEmail, clmTelefono, clmDireccion, clmCiudad, clmEstado, clmFechaNacimiento, clmPuesto, clmSalario, clmNSS, clmCuentaBancaria });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(240, 240, 240);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(0, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1008, 495);
            dataGridView1.TabIndex = 2;
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
            lblTitle.Location = new Point(22, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(211, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Reporte de Usuarios";
            // 
            // btnResetFilters
            // 
            btnResetFilters.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnResetFilters.BackColor = Color.WhiteSmoke;
            btnResetFilters.FlatAppearance.BorderColor = Color.Silver;
            btnResetFilters.FlatStyle = FlatStyle.Flat;
            btnResetFilters.Font = new Font("Segoe UI", 9F);
            btnResetFilters.ForeColor = Color.Gray;
            btnResetFilters.Location = new Point(726, 12);
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
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1008, 106);
            pnlTop.TabIndex = 0;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 247);
            ClientSize = new Size(1008, 601);
            Controls.Add(dataGridView1);
            Controls.Add(pnlTop);
            Name = "frmUsuarios";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private Button btnResetFilters;
        private Panel pnlTop;
    }
}