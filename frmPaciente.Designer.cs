namespace ReservasCitasMedicas_MLCJ
{
    partial class frmPaciente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaciente));
            this.txtContraseñaPaciente = new System.Windows.Forms.TextBox();
            this.txtApellidoPaciente = new System.Windows.Forms.TextBox();
            this.txtCiudadPaciente = new System.Windows.Forms.TextBox();
            this.txtIdentificacionPaciente = new System.Windows.Forms.TextBox();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.lblContraseñaPaciente = new System.Windows.Forms.Label();
            this.lblCiudadPaciente = new System.Windows.Forms.Label();
            this.lblIdentificacionPaciente = new System.Windows.Forms.Label();
            this.lblApellidoPaciente = new System.Windows.Forms.Label();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.txtEmailPaciente = new System.Windows.Forms.TextBox();
            this.txtTelefonoPaciente = new System.Windows.Forms.TextBox();
            this.lblEmailPaciente = new System.Windows.Forms.Label();
            this.lblTelefonoPaciente = new System.Windows.Forms.Label();
            this.btnSalirClientes = new System.Windows.Forms.Button();
            this.btnLimpiarClientes = new System.Windows.Forms.Button();
            this.btnCrearPaciente = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContraseñaPaciente
            // 
            this.txtContraseñaPaciente.Location = new System.Drawing.Point(165, 156);
            this.txtContraseñaPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContraseñaPaciente.Name = "txtContraseñaPaciente";
            this.txtContraseñaPaciente.Size = new System.Drawing.Size(224, 24);
            this.txtContraseñaPaciente.TabIndex = 24;
            // 
            // txtApellidoPaciente
            // 
            this.txtApellidoPaciente.Location = new System.Drawing.Point(165, 65);
            this.txtApellidoPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoPaciente.Name = "txtApellidoPaciente";
            this.txtApellidoPaciente.Size = new System.Drawing.Size(224, 24);
            this.txtApellidoPaciente.TabIndex = 23;
            this.txtApellidoPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoPaciente_KeyPress);
            // 
            // txtCiudadPaciente
            // 
            this.txtCiudadPaciente.Location = new System.Drawing.Point(165, 304);
            this.txtCiudadPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCiudadPaciente.Name = "txtCiudadPaciente";
            this.txtCiudadPaciente.Size = new System.Drawing.Size(224, 24);
            this.txtCiudadPaciente.TabIndex = 22;
            this.txtCiudadPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCiudadPaciente_KeyPress);
            // 
            // txtIdentificacionPaciente
            // 
            this.txtIdentificacionPaciente.Location = new System.Drawing.Point(165, 111);
            this.txtIdentificacionPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdentificacionPaciente.Name = "txtIdentificacionPaciente";
            this.txtIdentificacionPaciente.Size = new System.Drawing.Size(224, 24);
            this.txtIdentificacionPaciente.TabIndex = 21;
            this.txtIdentificacionPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificacionPaciente_KeyPress);
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Location = new System.Drawing.Point(165, 16);
            this.txtNombrePaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(224, 24);
            this.txtNombrePaciente.TabIndex = 20;
            this.txtNombrePaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombrePaciente_KeyPress);
            // 
            // lblContraseñaPaciente
            // 
            this.lblContraseñaPaciente.AutoSize = true;
            this.lblContraseñaPaciente.Location = new System.Drawing.Point(24, 154);
            this.lblContraseñaPaciente.Name = "lblContraseñaPaciente";
            this.lblContraseñaPaciente.Size = new System.Drawing.Size(76, 16);
            this.lblContraseñaPaciente.TabIndex = 19;
            this.lblContraseñaPaciente.Text = "Contraseña";
            // 
            // lblCiudadPaciente
            // 
            this.lblCiudadPaciente.AutoSize = true;
            this.lblCiudadPaciente.Location = new System.Drawing.Point(24, 312);
            this.lblCiudadPaciente.Name = "lblCiudadPaciente";
            this.lblCiudadPaciente.Size = new System.Drawing.Size(50, 16);
            this.lblCiudadPaciente.TabIndex = 18;
            this.lblCiudadPaciente.Text = "Ciudad";
            // 
            // lblIdentificacionPaciente
            // 
            this.lblIdentificacionPaciente.AutoSize = true;
            this.lblIdentificacionPaciente.Location = new System.Drawing.Point(24, 111);
            this.lblIdentificacionPaciente.Name = "lblIdentificacionPaciente";
            this.lblIdentificacionPaciente.Size = new System.Drawing.Size(91, 16);
            this.lblIdentificacionPaciente.TabIndex = 17;
            this.lblIdentificacionPaciente.Text = "Identificacion";
            // 
            // lblApellidoPaciente
            // 
            this.lblApellidoPaciente.AutoSize = true;
            this.lblApellidoPaciente.Location = new System.Drawing.Point(24, 65);
            this.lblApellidoPaciente.Name = "lblApellidoPaciente";
            this.lblApellidoPaciente.Size = new System.Drawing.Size(59, 16);
            this.lblApellidoPaciente.TabIndex = 16;
            this.lblApellidoPaciente.Text = "Apellido";
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Location = new System.Drawing.Point(28, 16);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(57, 16);
            this.lblNombrePaciente.TabIndex = 15;
            this.lblNombrePaciente.Text = "Nombre";
            // 
            // txtEmailPaciente
            // 
            this.txtEmailPaciente.Location = new System.Drawing.Point(165, 255);
            this.txtEmailPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailPaciente.Name = "txtEmailPaciente";
            this.txtEmailPaciente.Size = new System.Drawing.Size(224, 24);
            this.txtEmailPaciente.TabIndex = 28;
            // 
            // txtTelefonoPaciente
            // 
            this.txtTelefonoPaciente.Location = new System.Drawing.Point(165, 207);
            this.txtTelefonoPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefonoPaciente.Name = "txtTelefonoPaciente";
            this.txtTelefonoPaciente.Size = new System.Drawing.Size(224, 24);
            this.txtTelefonoPaciente.TabIndex = 27;
            this.txtTelefonoPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoPaciente_KeyPress);
            // 
            // lblEmailPaciente
            // 
            this.lblEmailPaciente.AutoSize = true;
            this.lblEmailPaciente.Location = new System.Drawing.Point(24, 258);
            this.lblEmailPaciente.Name = "lblEmailPaciente";
            this.lblEmailPaciente.Size = new System.Drawing.Size(41, 16);
            this.lblEmailPaciente.TabIndex = 26;
            this.lblEmailPaciente.Text = "Email";
            // 
            // lblTelefonoPaciente
            // 
            this.lblTelefonoPaciente.AutoSize = true;
            this.lblTelefonoPaciente.Location = new System.Drawing.Point(24, 207);
            this.lblTelefonoPaciente.Name = "lblTelefonoPaciente";
            this.lblTelefonoPaciente.Size = new System.Drawing.Size(62, 16);
            this.lblTelefonoPaciente.TabIndex = 25;
            this.lblTelefonoPaciente.Text = "Telefono";
            // 
            // btnSalirClientes
            // 
            this.btnSalirClientes.BackColor = System.Drawing.Color.White;
            this.btnSalirClientes.Location = new System.Drawing.Point(154, 478);
            this.btnSalirClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalirClientes.Name = "btnSalirClientes";
            this.btnSalirClientes.Size = new System.Drawing.Size(129, 54);
            this.btnSalirClientes.TabIndex = 34;
            this.btnSalirClientes.Text = "Salir";
            this.btnSalirClientes.UseVisualStyleBackColor = false;
            this.btnSalirClientes.Click += new System.EventHandler(this.btnSalirClientes_Click);
            // 
            // btnLimpiarClientes
            // 
            this.btnLimpiarClientes.BackColor = System.Drawing.Color.White;
            this.btnLimpiarClientes.Location = new System.Drawing.Point(295, 400);
            this.btnLimpiarClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiarClientes.Name = "btnLimpiarClientes";
            this.btnLimpiarClientes.Size = new System.Drawing.Size(129, 54);
            this.btnLimpiarClientes.TabIndex = 33;
            this.btnLimpiarClientes.Text = "Limpiar";
            this.btnLimpiarClientes.UseVisualStyleBackColor = false;
            this.btnLimpiarClientes.Click += new System.EventHandler(this.btnLimpiarClientes_Click);
            // 
            // btnCrearPaciente
            // 
            this.btnCrearPaciente.BackColor = System.Drawing.Color.White;
            this.btnCrearPaciente.Location = new System.Drawing.Point(27, 400);
            this.btnCrearPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrearPaciente.Name = "btnCrearPaciente";
            this.btnCrearPaciente.Size = new System.Drawing.Size(129, 54);
            this.btnCrearPaciente.TabIndex = 29;
            this.btnCrearPaciente.Text = "Agregar";
            this.btnCrearPaciente.UseVisualStyleBackColor = false;
            this.btnCrearPaciente.Click += new System.EventHandler(this.btnAgregarClientes_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(448, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(618, 553);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // frmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalirClientes);
            this.Controls.Add(this.btnLimpiarClientes);
            this.Controls.Add(this.btnCrearPaciente);
            this.Controls.Add(this.txtEmailPaciente);
            this.Controls.Add(this.txtTelefonoPaciente);
            this.Controls.Add(this.lblEmailPaciente);
            this.Controls.Add(this.lblTelefonoPaciente);
            this.Controls.Add(this.txtContraseñaPaciente);
            this.Controls.Add(this.txtApellidoPaciente);
            this.Controls.Add(this.txtCiudadPaciente);
            this.Controls.Add(this.txtIdentificacionPaciente);
            this.Controls.Add(this.txtNombrePaciente);
            this.Controls.Add(this.lblContraseñaPaciente);
            this.Controls.Add(this.lblCiudadPaciente);
            this.Controls.Add(this.lblIdentificacionPaciente);
            this.Controls.Add(this.lblApellidoPaciente);
            this.Controls.Add(this.lblNombrePaciente);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPaciente";
            this.Text = "frmPaciente";
            this.Load += new System.EventHandler(this.frmPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContraseñaPaciente;
        private System.Windows.Forms.TextBox txtApellidoPaciente;
        private System.Windows.Forms.TextBox txtCiudadPaciente;
        private System.Windows.Forms.TextBox txtIdentificacionPaciente;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.Label lblContraseñaPaciente;
        private System.Windows.Forms.Label lblCiudadPaciente;
        private System.Windows.Forms.Label lblIdentificacionPaciente;
        private System.Windows.Forms.Label lblApellidoPaciente;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.TextBox txtEmailPaciente;
        private System.Windows.Forms.TextBox txtTelefonoPaciente;
        private System.Windows.Forms.Label lblEmailPaciente;
        private System.Windows.Forms.Label lblTelefonoPaciente;
        private System.Windows.Forms.Button btnSalirClientes;
        private System.Windows.Forms.Button btnLimpiarClientes;
        private System.Windows.Forms.Button btnCrearPaciente;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}