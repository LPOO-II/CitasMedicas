namespace ReservasCitasMedicas_MLCJ
{
    partial class frmAdministracionCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministracionCitas));
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscarCitasM = new System.Windows.Forms.Button();
            this.dtgVisualizacionCitas = new System.Windows.Forms.DataGridView();
            this.cmbConfirmacionCita = new System.Windows.Forms.ComboBox();
            this.txtIdReserva = new System.Windows.Forms.TextBox();
            this.lblIdSedeReservas = new System.Windows.Forms.Label();
            this.lblCodigoCita = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdentificacionDoctor = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisualizacionCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(183, 156);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(135, 41);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscarCitasM
            // 
            this.btnBuscarCitasM.BackColor = System.Drawing.Color.White;
            this.btnBuscarCitasM.Location = new System.Drawing.Point(29, 156);
            this.btnBuscarCitasM.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCitasM.Name = "btnBuscarCitasM";
            this.btnBuscarCitasM.Size = new System.Drawing.Size(117, 41);
            this.btnBuscarCitasM.TabIndex = 1;
            this.btnBuscarCitasM.Text = "Buscar";
            this.btnBuscarCitasM.UseVisualStyleBackColor = false;
            this.btnBuscarCitasM.Click += new System.EventHandler(this.btnBuscarCitasM_Click);
            // 
            // dtgVisualizacionCitas
            // 
            this.dtgVisualizacionCitas.AllowUserToOrderColumns = true;
            this.dtgVisualizacionCitas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dtgVisualizacionCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVisualizacionCitas.GridColor = System.Drawing.Color.Gray;
            this.dtgVisualizacionCitas.Location = new System.Drawing.Point(-1, 356);
            this.dtgVisualizacionCitas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgVisualizacionCitas.Name = "dtgVisualizacionCitas";
            this.dtgVisualizacionCitas.RowHeadersWidth = 51;
            this.dtgVisualizacionCitas.RowTemplate.Height = 24;
            this.dtgVisualizacionCitas.Size = new System.Drawing.Size(1069, 197);
            this.dtgVisualizacionCitas.TabIndex = 31;
            this.dtgVisualizacionCitas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgVisualizacionCitas_MouseClick);
            // 
            // cmbConfirmacionCita
            // 
            this.cmbConfirmacionCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConfirmacionCita.FormattingEnabled = true;
            this.cmbConfirmacionCita.Items.AddRange(new object[] {
            "CONFIRMADA",
            "CANCELADA",
            "APLAZADA"});
            this.cmbConfirmacionCita.Location = new System.Drawing.Point(160, 98);
            this.cmbConfirmacionCita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbConfirmacionCita.Name = "cmbConfirmacionCita";
            this.cmbConfirmacionCita.Size = new System.Drawing.Size(121, 24);
            this.cmbConfirmacionCita.TabIndex = 47;
            // 
            // txtIdReserva
            // 
            this.txtIdReserva.Location = new System.Drawing.Point(160, 54);
            this.txtIdReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdReserva.Name = "txtIdReserva";
            this.txtIdReserva.Size = new System.Drawing.Size(207, 24);
            this.txtIdReserva.TabIndex = 46;
            this.txtIdReserva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdReserva_KeyPress);
            // 
            // lblIdSedeReservas
            // 
            this.lblIdSedeReservas.AutoSize = true;
            this.lblIdSedeReservas.Location = new System.Drawing.Point(12, 98);
            this.lblIdSedeReservas.Name = "lblIdSedeReservas";
            this.lblIdSedeReservas.Size = new System.Drawing.Size(118, 16);
            this.lblIdSedeReservas.TabIndex = 45;
            this.lblIdSedeReservas.Text = "Confirmacion Cita";
            // 
            // lblCodigoCita
            // 
            this.lblCodigoCita.AutoSize = true;
            this.lblCodigoCita.Location = new System.Drawing.Point(11, 58);
            this.lblCodigoCita.Name = "lblCodigoCita";
            this.lblCodigoCita.Size = new System.Drawing.Size(79, 16);
            this.lblCodigoCita.TabIndex = 44;
            this.lblCodigoCita.Text = "Codigo Cita";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Identitifcacion Doctor";
            // 
            // txtIdentificacionDoctor
            // 
            this.txtIdentificacionDoctor.Location = new System.Drawing.Point(160, 14);
            this.txtIdentificacionDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdentificacionDoctor.Name = "txtIdentificacionDoctor";
            this.txtIdentificacionDoctor.Size = new System.Drawing.Size(207, 24);
            this.txtIdentificacionDoctor.TabIndex = 49;
            this.txtIdentificacionDoctor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificacionDoctor_KeyPress);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(29, 236);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(117, 41);
            this.btnLimpiar.TabIndex = 50;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(183, 236);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(135, 41);
            this.btnSalir.TabIndex = 51;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(404, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(664, 361);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // frmAdministracionCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtIdentificacionDoctor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbConfirmacionCita);
            this.Controls.Add(this.txtIdReserva);
            this.Controls.Add(this.lblIdSedeReservas);
            this.Controls.Add(this.lblCodigoCita);
            this.Controls.Add(this.dtgVisualizacionCitas);
            this.Controls.Add(this.btnBuscarCitasM);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdministracionCitas";
            this.Text = "frmAdministracionCitas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisualizacionCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscarCitasM;
        private System.Windows.Forms.DataGridView dtgVisualizacionCitas;
        private System.Windows.Forms.ComboBox cmbConfirmacionCita;
        private System.Windows.Forms.TextBox txtIdReserva;
        private System.Windows.Forms.Label lblIdSedeReservas;
        private System.Windows.Forms.Label lblCodigoCita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdentificacionDoctor;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}