using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ReservasCitasMedicas_MLCJ
{
    public partial class frmReservaCitasMedicas : Form
    {
        public frmReservaCitasMedicas()
        {
            InitializeComponent();
        }

        private void btnAgregarCitas_Click(object sender, EventArgs e)
        {
           
            try
            {


               clsReservaCitaMedicas clsReservaCitaMedicas1 = new clsReservaCitaMedicas();


               bool Disponibilidad = clsReservaCitaMedicas1.VerificarDisponibilidadCita(Convert.ToInt32(txtIdIdentificacionPaciente.Text), dtpFechaCita.Value,cmbstrTurnoCita.Text, clsReservaCitaMedicas1.ObtenerIdUsuarioPorNombre(cmbDoctor.Text));
                if (Disponibilidad)
                {
                   MessageBox.Show("El turno no se encuentra disponible");
                    MessageBox.Show(Disponibilidad.ToString());
                }
                else 
                {

                    clsConexion conexion = new clsConexion();
                    conexion.abrirConexion();

                    clsReservaCitaMedicas p1 = new clsReservaCitaMedicas(Convert.ToInt16(txtCodigoCita.Text), dtpFechaCita.Value.Date, cmbstrTurnoCita.Text, cmbEspecialidad.Text,"Por Confirmar", clsReservaCitaMedicas1.ObtenerIdUsuarioPorNombre(cmbDoctor.Text), Convert.ToInt32(txtIdIdentificacionPaciente.Text));
                    p1.insertarDatoReservaCitaMedica();
                    MessageBox.Show("Datos Ingresados");
                    MessageBox.Show(Disponibilidad.ToString());

                    int numeroRandom = clsReservaCitaMedicas1.GenerarNumeroAleatorio();
                    txtCodigoCita.Text = numeroRandom.ToString();

                }
            }
          
            catch (Exception ex)
            {


                MessageBox.Show("Error al ingresar dato" + ex.Message);
            }
        }

        private void btnConsultarReservas_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();


                if (txtCodigoCita.Text == "")
                {
                    clsReservaCitaMedicas p1 = new clsReservaCitaMedicas();

                    dtgReservaCitasM.DataSource = p1.consultarDatoReservaCitaMedica();
                }

                else
                {
                    clsReservaCitaMedicas p1 = new clsReservaCitaMedicas();
                    dtgReservaCitasM.DataSource = p1.seleccionarDatoReservaCitaMedica(Convert.ToInt16(txtIdIdentificacionPaciente.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar  dato" + ex.Message);

            }
        }

        private void dtgReservaCitasM_MouseClick(object sender, MouseEventArgs e)
        {
            txtCodigoCita.Text = dtgReservaCitasM.SelectedRows[0].Cells[0].Value.ToString();
            cmbEspecialidad.Text = dtgReservaCitasM.SelectedRows[0].Cells[1].Value.ToString();
            txtIdIdentificacionPaciente.Text = dtgReservaCitasM.SelectedRows[0].Cells[2].Value.ToString();
            cmbDoctor.Text = dtgReservaCitasM.SelectedRows[0].Cells[3].Value.ToString();
            dtpFechaCita.Text = dtgReservaCitasM.SelectedRows[0].Cells[5].Value.ToString();
            cmbstrTurnoCita.Text= dtgReservaCitasM.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoctor.Items.Clear();

            string Especialidad = cmbEspecialidad.SelectedItem.ToString();

            clsConexion conexion = new clsConexion();

            using (SqlConnection connection = conexion.conexion)
            {
                string consulta = "SELECT strNombreDoctor FROM tblDoctor WHERE strEspecialidad = @strEspecialidad";
                using (SqlCommand command = new SqlCommand(consulta, connection))
                {
                    command.Parameters.AddWithValue("@strEspecialidad", Especialidad);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbDoctor.Items.Add(reader["strNombreDoctor"].ToString());
                        }
                    }
                }

            }
        }

        private void frmReservaCitasMedicas_Load(object sender, EventArgs e)
        {
            clsReservaCitaMedicas citasmedicas = new clsReservaCitaMedicas();
            int numeroRandom = citasmedicas.GenerarNumeroAleatorio();
            txtCodigoCita.Text=numeroRandom.ToString(); 
        }

        private void btnSalirClientes_Click(object sender, EventArgs e)
        {
            frmReservaCitasMedicas frmCita = new frmReservaCitasMedicas();
            Form1 form1 = new Form1();
            if (frmCita != null)
            {
                this.Close();
                form1.BringToFront();

            }
        }

        private void txtIdIdentificacionPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                //Envio de alerta si se preciona una letra
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }
        
    }
}
