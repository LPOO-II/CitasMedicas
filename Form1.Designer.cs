namespace ReservasCitasMedicas_MLCJ
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnIngresarPacientes = new System.Windows.Forms.Button();
            this.txtContraseñaPaciente = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.txtidentificacionPaciente = new System.Windows.Forms.TextBox();
            this.errorproviderLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorproviderLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresarPacientes
            // 
            this.btnIngresarPacientes.BackColor = System.Drawing.Color.White;
            this.btnIngresarPacientes.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarPacientes.Location = new System.Drawing.Point(939, 400);
            this.btnIngresarPacientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresarPacientes.Name = "btnIngresarPacientes";
            this.btnIngresarPacientes.Size = new System.Drawing.Size(192, 95);
            this.btnIngresarPacientes.TabIndex = 9;
            this.btnIngresarPacientes.Text = "Ingresar";
            this.btnIngresarPacientes.UseVisualStyleBackColor = false;
            this.btnIngresarPacientes.Click += new System.EventHandler(this.btnIngresarPacientes_Click);
            // 
            // txtContraseñaPaciente
            // 
            this.txtContraseñaPaciente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaPaciente.Location = new System.Drawing.Point(896, 324);
            this.txtContraseñaPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContraseñaPaciente.Name = "txtContraseñaPaciente";
            this.txtContraseñaPaciente.PasswordChar = '*';
            this.txtContraseñaPaciente.Size = new System.Drawing.Size(219, 25);
            this.txtContraseñaPaciente.TabIndex = 8;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(712, 329);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(90, 18);
            this.lblContraseña.TabIndex = 7;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacion.Location = new System.Drawing.Point(712, 255);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(103, 18);
            this.lblIdentificacion.TabIndex = 6;
            this.lblIdentificacion.Text = "Identificacion";
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.BackColor = System.Drawing.Color.White;
            this.btnCrearCuenta.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCuenta.Location = new System.Drawing.Point(701, 400);
            this.btnCrearCuenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(192, 95);
            this.btnCrearCuenta.TabIndex = 11;
            this.btnCrearCuenta.Text = "Crear Cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = false;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // txtidentificacionPaciente
            // 
            this.txtidentificacionPaciente.BackColor = System.Drawing.Color.White;
            this.txtidentificacionPaciente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidentificacionPaciente.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtidentificacionPaciente.Location = new System.Drawing.Point(896, 246);
            this.txtidentificacionPaciente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtidentificacionPaciente.Name = "txtidentificacionPaciente";
            this.txtidentificacionPaciente.Size = new System.Drawing.Size(219, 25);
            this.txtidentificacionPaciente.TabIndex = 12;
            // 
            // errorproviderLogin
            // 
            this.errorproviderLogin.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(693, 527);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(829, 70);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1148, 530);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtidentificacionPaciente);
            this.Controls.Add(this.btnCrearCuenta);
            this.Controls.Add(this.txtContraseñaPaciente);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblIdentificacion);
            this.Controls.Add(this.btnIngresarPacientes);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            //this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorproviderLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIngresarPacientes;
        private System.Windows.Forms.TextBox txtContraseñaPaciente;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.TextBox txtidentificacionPaciente;
        private System.Windows.Forms.ErrorProvider errorproviderLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

