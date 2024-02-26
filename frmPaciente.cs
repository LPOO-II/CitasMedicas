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
    public partial class frmPaciente : Form
    {
        public frmPaciente()
        {
            InitializeComponent();
        }

        private void btnSalirClientes_Click(object sender, EventArgs e)
        {

            frmPaciente frmPaciente = new frmPaciente();
            Form1 form1 = new Form1();
            if (frmPaciente != null)
            {
                this.Close();
                form1.BringToFront();

            }
        }

        private void btnLimpiarClientes_Click(object sender, EventArgs e)
        {
            txtNombrePaciente.Text = string.Empty;
            txtApellidoPaciente.Text = string.Empty;
            txtIdentificacionPaciente.Text = string.Empty;
            txtTelefonoPaciente.Text = string.Empty;
            txtContraseñaPaciente.Text = string.Empty;
            txtEmailPaciente.Text = string.Empty;
            txtCiudadPaciente.Text = string.Empty;
        }

        private void btnEliminarClientes_Click(object sender, EventArgs e)
        {

        }

       

        

        private void btnAgregarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                BorrarMensajeError();
                if (ValidarCampos()==true)
                {

                

                clsConexion conexion = new clsConexion();
                conexion.abrirConexion();

                clsPaciente p1 = new clsPaciente(Convert.ToInt64(txtIdentificacionPaciente.Text), txtNombrePaciente.Text, txtApellidoPaciente.Text, Convert.ToInt64(txtTelefonoPaciente.Text), txtEmailPaciente.Text, txtCiudadPaciente.Text, txtContraseñaPaciente.Text);

                bool strPaciente= p1.VerificarPacientes(txtIdentificacionPaciente.Text);
                if (strPaciente ) 
                {
                    MessageBox.Show("El usuario ya existe");
                }   
                else
                { 
                p1.insertarPaciente();  // Utiliza el nuevo método
                MessageBox.Show("Datos Ingresados");
                }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar dato" + ex.Message);
            }
        }

        private void frmPaciente_Load(object sender, EventArgs e)
        {

        }

        private void txtIdentificacionPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                //Envio de alerta si se preciona una letra
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtTelefonoPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                //Envio de alerta si se preciona una letra
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtNombrePaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellidoPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCiudadPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private bool ValidarCampos()
        {
            bool ok = true;

            if (txtNombrePaciente.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombrePaciente, "Por Favor ingresar su nombre");
            }
            if (txtApellidoPaciente.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtApellidoPaciente, "Por Favor ingresar el apellido");
            }
            if (txtCiudadPaciente.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCiudadPaciente, "Por Favor ingresar la ciudad");
            }
            if (txtContraseñaPaciente.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtContraseñaPaciente, "Por Favor ingresar la contraseña");
            }
            if (txtEmailPaciente.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtEmailPaciente, "Por Favor ingresar el email");
            }
            if (txtIdentificacionPaciente.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtIdentificacionPaciente, "Por Favor ingresar la identificacion");
            }
            if (txtTelefonoPaciente.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtTelefonoPaciente, "Por Favor ingresar el numero de telefono");
            }

            return ok;

        }
        private void BorrarMensajeError()
        {
            errorProvider1.SetError(txtCiudadPaciente, "");
            errorProvider1.SetError(txtEmailPaciente, "");
            errorProvider1.SetError(txtIdentificacionPaciente, "");
            errorProvider1.SetError(txtNombrePaciente, "");
            errorProvider1.SetError(txtApellidoPaciente, "");
            errorProvider1.SetError(txtTelefonoPaciente, "");
            errorProvider1.SetError(txtContraseñaPaciente, "");
        }

    }
}
