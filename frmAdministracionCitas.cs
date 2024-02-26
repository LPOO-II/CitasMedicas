using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservasCitasMedicas_MLCJ
{
    public partial class frmAdministracionCitas : Form
    {
        public frmAdministracionCitas()
        {
            InitializeComponent();
        }

        private void btnBuscarCitasM_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();


                if (txtIdentificacionDoctor.Text == "")
                {
                    clsAdministracionCitas p1 = new clsAdministracionCitas();

                    dtgVisualizacionCitas.DataSource = p1.consultarDatoAdministracionCitas();
                }

                else
                {
                    clsAdministracionCitas p1 = new clsAdministracionCitas();
                    dtgVisualizacionCitas.DataSource = p1.seleccionarDatoReservaCitaMedica(Convert.ToInt32(txtIdentificacionDoctor.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar  dato" + ex.Message);

            }
        }

        private void dtgVisualizacionCitas_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtIdentificacionDoctor.Text = dtgVisualizacionCitas.SelectedRows[0].Cells[0].Value.ToString();
                txtIdReserva.Text = dtgVisualizacionCitas.SelectedRows[0].Cells[1].Value.ToString();
                cmbConfirmacionCita.Text = dtgVisualizacionCitas.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                BorrarMensajeError();
                if (ValidarCampos()== true)
                {

                
                frmReservaCitasMedicas rs = new frmReservaCitasMedicas();
                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                clsAdministracionCitas p1 = new clsAdministracionCitas();
                p1.modificarCita(cmbConfirmacionCita.Text, Convert.ToInt32(txtIdReserva.Text));
                MessageBox.Show("Datos modificados");
                dtgVisualizacionCitas.DataSource = p1.consultarDatoAdministracionCitas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el dato" + ex);

            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdentificacionDoctor.Text = string.Empty;
            txtIdReserva.Text = string.Empty;
            cmbConfirmacionCita.Text= string.Empty; 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmAdministracionCitas frmadministracionCitas = new frmAdministracionCitas();
            Form1 form1 = new Form1();
            if (frmadministracionCitas!=null)
            {
                this.Close();
                form1.BringToFront();
            }
        }

        private void txtIdentificacionDoctor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                //Envio de alerta si se preciona una letra
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtIdReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                //Envio de alerta si se preciona una letra
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private bool ValidarCampos()
        {
            bool ok = true;
            
            if (txtIdReserva.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtIdReserva, "Por Favor ingresar la id de la reserva lo puedes ver en la tabla al buscar");
            }
            if (cmbConfirmacionCita.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cmbConfirmacionCita, "Por Favor ingresar el estado de la cita");
            }

            return ok;

        }
        private void BorrarMensajeError()
        {
            errorProvider1.SetError(txtIdReserva, "");
            errorProvider1.SetError(cmbConfirmacionCita, "");

        }

        
    }
}
