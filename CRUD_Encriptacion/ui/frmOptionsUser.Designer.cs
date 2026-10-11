namespace CRUD_Encriptacion.ui
{
    partial class frmOptionsUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptionsUser));
            btnVer = new Button();
            lblSaludo = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnSalir = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnVer
            // 
            btnVer.BackColor = Color.FromArgb(40, 40, 40);
            btnVer.FlatAppearance.BorderSize = 0;
            btnVer.FlatStyle = FlatStyle.Flat;
            btnVer.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVer.ForeColor = Color.LightGray;
            btnVer.Image = (Image)resources.GetObject("btnVer.Image");
            btnVer.ImageAlign = ContentAlignment.MiddleRight;
            btnVer.Location = new Point(44, 147);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(317, 62);
            btnVer.TabIndex = 1;
            btnVer.Text = "Ver Usuarios";
            btnVer.TextAlign = ContentAlignment.MiddleLeft;
            btnVer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVer.UseVisualStyleBackColor = false;
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaludo.ForeColor = Color.Gainsboro;
            lblSaludo.Location = new Point(21, 10);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(232, 36);
            lblSaludo.TabIndex = 0;
            lblSaludo.Text = "HOLA, USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(30, 57);
            label2.Name = "label2";
            label2.Size = new Size(179, 22);
            label2.TabIndex = 1;
            label2.Text = "¿Qué desea hacer?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(260, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblSaludo);
            panel1.Location = new Point(-9, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(816, 106);
            panel1.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(40, 40, 40);
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.LightGray;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.MiddleRight;
            btnSalir.Location = new Point(107, 279);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(178, 59);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Location = new Point(12, 246);
            panel2.Name = "panel2";
            panel2.Size = new Size(380, 1);
            panel2.TabIndex = 0;
            // 
            // frmOptionsUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(404, 436);
            Controls.Add(panel2);
            Controls.Add(btnSalir);
            Controls.Add(panel1);
            Controls.Add(btnVer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmOptionsUser";
            Text = "frmOptionsUser";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnVer;
        private Label lblSaludo;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnSalir;
        private Panel panel2;
    }
}