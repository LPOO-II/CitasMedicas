namespace ReservasCitasMedicas_MLCJ
{
    partial class frmReservaCitasMedicas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservaCitasMedicas));
            this.lblProfesional = new System.Windows.Forms.Label();
            this.txtIdIdentificacionPaciente = new System.Windows.Forms.TextBox();
            this.lblFechaCita = new System.Windows.Forms.Label();
            this.lblIdReserva = new System.Windows.Forms.Label();
            this.lblIdentificacionPaciente = new System.Windows.Forms.Label();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.btnAgregarCitas = new System.Windows.Forms.Button();
            this.btnConsultarReservas = new System.Windows.Forms.Button();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.dtgReservaCitasM = new System.Windows.Forms.DataGridView();
            this.lblTurnoCita = new System.Windows.Forms.Label();
            this.cmbstrTurnoCita = new System.Windows.Forms.ComboBox();
            this.btnSalirClientes = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtCodigoCita = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReservaCitasM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProfesional
            // 
            this.lblProfesional.AutoSize = true;
            this.lblProfesional.BackColor = System.Drawing.Color.White;
            this.lblProfesional.Location = new System.Drawing.Point(753, 149);
            this.lblProfesional.Name = "lblProfesional";
            this.lblProfesional.Size = new System.Drawing.Size(49, 16);
            this.lblProfesional.TabIndex = 58;
            this.lblProfesional.Text = "Doctor";
            // 
            // txtIdIdentificacionPaciente
            // 
            this.txtIdIdentificacionPaciente.Location = new System.Drawing.Point(932, 99);
            this.txtIdIdentificacionPaciente.Name = "txtIdIdentificacionPaciente";
            this.txtIdIdentificacionPaciente.Size = new System.Drawing.Size(192, 24);
            this.txtIdIdentificacionPaciente.TabIndex = 56;
            this.txtIdIdentificacionPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdIdentificacionPaciente_KeyPress);
            // 
            // lblFechaCita
            // 
            this.lblFechaCita.AutoSize = true;
            this.lblFechaCita.BackColor = System.Drawing.Color.White;
            this.lblFechaCita.Location = new System.Drawing.Point(753, 194);
            this.lblFechaCita.Name = "lblFechaCita";
            this.lblFechaCita.Size = new System.Drawing.Size(70, 16);
            this.lblFechaCita.TabIndex = 52;
            this.lblFechaCita.Text = "Fecha Cita";
            // 
            // lblIdReserva
            // 
            this.lblIdReserva.AutoSize = true;
            this.lblIdReserva.Location = new System.Drawing.Point(806, 112);
            this.lblIdReserva.Name = "lblIdReserva";
            this.lblIdReserva.Size = new System.Drawing.Size(0, 16);
            this.lblIdReserva.TabIndex = 48;
            // 
            // lblIdentificacionPaciente
            // 
            this.lblIdentificacionPaciente.AutoSize = true;
            this.lblIdentificacionPaciente.BackColor = System.Drawing.Color.White;
            this.lblIdentificacionPaciente.Location = new System.Drawing.Point(752, 99);
            this.lblIdentificacionPaciente.Name = "lblIdentificacionPaciente";
            this.lblIdentificacionPaciente.Size = new System.Drawing.Size(147, 16);
            this.lblIdentificacionPaciente.TabIndex = 62;
            this.lblIdentificacionPaciente.Text = "Identificacion Paciente";
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(932, 146);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(192, 24);
            this.cmbDoctor.TabIndex = 65;
            // 
            // btnAgregarCitas
            // 
            this.btnAgregarCitas.BackColor = System.Drawing.Color.White;
            this.btnAgregarCitas.Location = new System.Drawing.Point(747, 293);
            this.btnAgregarCitas.Name = "btnAgregarCitas";
            this.btnAgregarCitas.Size = new System.Drawing.Size(165, 45);
            this.btnAgregarCitas.TabIndex = 67;
            this.btnAgregarCitas.Text = "Agendar Cita";
            this.btnAgregarCitas.UseVisualStyleBackColor = false;
            this.btnAgregarCitas.Click += new System.EventHandler(this.btnAgregarCitas_Click);
            // 
            // btnConsultarReservas
            // 
            this.btnConsultarReservas.BackColor = System.Drawing.Color.White;
            this.btnConsultarReservas.Location = new System.Drawing.Point(977, 293);
            this.btnConsultarReservas.Name = "btnConsultarReservas";
            this.btnConsultarReservas.Size = new System.Drawing.Size(153, 45);
            this.btnConsultarReservas.TabIndex = 68;
            this.btnConsultarReservas.Text = "Consultar";
            this.btnConsultarReservas.UseVisualStyleBackColor = false;
            this.btnConsultarReservas.Click += new System.EventHandler(this.btnConsultarReservas_Click);
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.BackColor = System.Drawing.Color.White;
            this.lblEspecialidad.Location = new System.Drawing.Point(752, 48);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(83, 16);
            this.lblEspecialidad.TabIndex = 70;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Items.AddRange(new object[] {
            "neurologia",
            "internista",
            "medicina general",
            "bacteriologia",
            "pediatria",
            "odontologia",
            "oftalmologia ",
            "cirugia vascular",
            "dermatoligia",
            "gastroenterolpgia ",
            "ginecologia"});
            this.cmbEspecialidad.Location = new System.Drawing.Point(932, 48);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(192, 24);
            this.cmbEspecialidad.TabIndex = 71;
            this.cmbEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidad_SelectedIndexChanged);
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCita.Location = new System.Drawing.Point(932, 187);
            this.dtpFechaCita.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(192, 24);
            this.dtpFechaCita.TabIndex = 73;
            this.dtpFechaCita.Value = new System.DateTime(2024, 2, 22, 0, 0, 0, 0);
            // 
            // dtgReservaCitasM
            // 
            this.dtgReservaCitasM.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtgReservaCitasM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReservaCitasM.Location = new System.Drawing.Point(9, 454);
            this.dtgReservaCitasM.Name = "dtgReservaCitasM";
            this.dtgReservaCitasM.RowHeadersWidth = 51;
            this.dtgReservaCitasM.RowTemplate.Height = 24;
            this.dtgReservaCitasM.Size = new System.Drawing.Size(1115, 119);
            this.dtgReservaCitasM.TabIndex = 74;
            this.dtgReservaCitasM.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgReservaCitasM_MouseClick);
            // 
            // lblTurnoCita
            // 
            this.lblTurnoCita.AutoSize = true;
            this.lblTurnoCita.BackColor = System.Drawing.Color.White;
            this.lblTurnoCita.Location = new System.Drawing.Point(752, 232);
            this.lblTurnoCita.Name = "lblTurnoCita";
            this.lblTurnoCita.Size = new System.Drawing.Size(72, 16);
            this.lblTurnoCita.TabIndex = 75;
            this.lblTurnoCita.Text = "Turno Cita";
            // 
            // cmbstrTurnoCita
            // 
            this.cmbstrTurnoCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbstrTurnoCita.FormattingEnabled = true;
            this.cmbstrTurnoCita.Items.AddRange(new object[] {
            "8:00 am a 8:40 am",
            "8:40 am a 9:20 am ",
            "9:20 am a 10:00 am",
            "10:00 am a 10:40 am",
            "10:40 am a 11:20 am",
            "11:20 am a 12:00 am",
            "12:00 am a 12:40 am",
            "1:20 pm a 2:00 pm",
            "2:00 pm a 2:40 pm"});
            this.cmbstrTurnoCita.Location = new System.Drawing.Point(932, 228);
            this.cmbstrTurnoCita.Name = "cmbstrTurnoCita";
            this.cmbstrTurnoCita.Size = new System.Drawing.Size(192, 24);
            this.cmbstrTurnoCita.TabIndex = 76;
            // 
            // btnSalirClientes
            // 
            this.btnSalirClientes.BackColor = System.Drawing.Color.White;
            this.btnSalirClientes.Location = new System.Drawing.Point(879, 370);
            this.btnSalirClientes.Name = "btnSalirClientes";
            this.btnSalirClientes.Size = new System.Drawing.Size(147, 45);
            this.btnSalirClientes.TabIndex = 77;
            this.btnSalirClientes.Text = "Salir";
            this.btnSalirClientes.UseVisualStyleBackColor = false;
            this.btnSalirClientes.Click += new System.EventHandler(this.btnSalirClientes_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtCodigoCita
            // 
            this.txtCodigoCita.Enabled = false;
            this.txtCodigoCita.Location = new System.Drawing.Point(834, 12);
            this.txtCodigoCita.Name = "txtCodigoCita";
            this.txtCodigoCita.Size = new System.Drawing.Size(192, 24);
            this.txtCodigoCita.TabIndex = 63;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(748, 456);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // frmReservaCitasMedicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1139, 571);
            this.Controls.Add(this.btnSalirClientes);
            this.Controls.Add(this.cmbstrTurnoCita);
            this.Controls.Add(this.lblTurnoCita);
            this.Controls.Add(this.dtgReservaCitasM);
            this.Controls.Add(this.dtpFechaCita);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.btnConsultarReservas);
            this.Controls.Add(this.btnAgregarCitas);
            this.Controls.Add(this.cmbDoctor);
            this.Controls.Add(this.txtCodigoCita);
            this.Controls.Add(this.lblIdentificacionPaciente);
            this.Controls.Add(this.lblProfesional);
            this.Controls.Add(this.txtIdIdentificacionPaciente);
            this.Controls.Add(this.lblFechaCita);
            this.Controls.Add(this.lblIdReserva);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmReservaCitasMedicas";
            this.Text = "frmReservaCitasMedicas";
            this.Load += new System.EventHandler(this.frmReservaCitasMedicas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgReservaCitasM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProfesional;
        private System.Windows.Forms.TextBox txtIdIdentificacionPaciente;
        private System.Windows.Forms.Label lblFechaCita;
        private System.Windows.Forms.Label lblIdReserva;
        private System.Windows.Forms.Label lblIdentificacionPaciente;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Button btnAgregarCitas;
        private System.Windows.Forms.Button btnConsultarReservas;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.DataGridView dtgReservaCitasM;
        private System.Windows.Forms.Label lblTurnoCita;
        private System.Windows.Forms.ComboBox cmbstrTurnoCita;
        private System.Windows.Forms.Button btnSalirClientes;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtCodigoCita;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}