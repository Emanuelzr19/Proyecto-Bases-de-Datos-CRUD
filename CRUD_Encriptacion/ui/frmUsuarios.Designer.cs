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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            clmID = new DataGridViewTextBoxColumn();
            clmUsuario = new DataGridViewTextBoxColumn();
            clmContraseña = new DataGridViewTextBoxColumn();
            clmRol = new DataGridViewTextBoxColumn();
            clmNombre = new DataGridViewTextBoxColumn();
            clmApellidos = new DataGridViewTextBoxColumn();
            clmEmail = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            clmDireccion = new DataGridViewTextBoxColumn();
            clmEstado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 27);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clmID, clmUsuario, clmContraseña, clmRol, clmNombre, clmApellidos, clmEmail, Column1, clmDireccion, clmEstado });
            dataGridView1.Location = new Point(-256, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1109, 150);
            dataGridView1.TabIndex = 1;
            // 
            // clmID
            // 
            clmID.HeaderText = "ID";
            clmID.Name = "clmID";
            clmID.ReadOnly = true;
            // 
            // clmUsuario
            // 
            clmUsuario.HeaderText = "Usuario";
            clmUsuario.Name = "clmUsuario";
            clmUsuario.ReadOnly = true;
            // 
            // clmContraseña
            // 
            clmContraseña.HeaderText = "Contraseña";
            clmContraseña.Name = "clmContraseña";
            clmContraseña.ReadOnly = true;
            // 
            // clmRol
            // 
            clmRol.HeaderText = "Rol";
            clmRol.Name = "clmRol";
            clmRol.ReadOnly = true;
            // 
            // clmNombre
            // 
            clmNombre.HeaderText = "Nombre(s)";
            clmNombre.Name = "clmNombre";
            clmNombre.ReadOnly = true;
            // 
            // clmApellidos
            // 
            clmApellidos.HeaderText = "Apellidos";
            clmApellidos.Name = "clmApellidos";
            clmApellidos.ReadOnly = true;
            // 
            // clmEmail
            // 
            clmEmail.HeaderText = "Correo Electrónico";
            clmEmail.Name = "clmEmail";
            clmEmail.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // clmDireccion
            // 
            clmDireccion.HeaderText = "Dirección";
            clmDireccion.Name = "clmDireccion";
            clmDireccion.ReadOnly = true;
            // 
            // clmEstado
            // 
            clmEstado.HeaderText = "Estado";
            clmEstado.Name = "clmEstado";
            clmEstado.ReadOnly = true;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(924, 542);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clmID;
        private DataGridViewTextBoxColumn clmUsuario;
        private DataGridViewTextBoxColumn clmContraseña;
        private DataGridViewTextBoxColumn clmRol;
        private DataGridViewTextBoxColumn clmNombre;
        private DataGridViewTextBoxColumn clmApellidos;
        private DataGridViewTextBoxColumn clmEmail;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn clmDireccion;
        private DataGridViewTextBoxColumn clmEstado;
    }
}