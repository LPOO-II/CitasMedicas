using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservasCitasMedicas_MLCJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        private void btnIngresarPacientes_Click(object sender, EventArgs e)
        {
            try
            {
                BorrarMensajeError();
                if (ValidarCampos() == true)
                {
                    clsLogin log = new clsLogin();
                    string stridentificacion = txtidentificacionPaciente.Text;
                    string strContrasena = txtContraseñaPaciente.Text;
                    bool strPaciente = log.VerificarPacientes(stridentificacion, strContrasena);
                    bool strDoctor = log.VerificarDoctores(stridentificacion, strContrasena);

                    if (strPaciente)
                    {

                        frmReservaCitasMedicas frm = new frmReservaCitasMedicas();
                        frm.Show();
                        frm.BringToFront();

                    }
                    else if  (strDoctor) 
                    {
                        frmAdministracionCitas frmAdministracionCitas = new frmAdministracionCitas();
                        frmAdministracionCitas.Show();

                    }
                    else
                    {
                        MessageBox.Show("Tu Cuenta no existe");
                    } 
                   
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al ingresar al sistema" + ex);

            }




        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            
            frmPaciente frmPaciente = new frmPaciente();
           
                frmPaciente.Show();
                frmPaciente.BringToFront(); 
            
            
           
        }
        private bool ValidarCampos()
        {
            bool ok = true;

            if (txtContraseñaPaciente.Text == "")
            {
                ok = false;
                errorproviderLogin.SetError(txtContraseñaPaciente, "Por Favor ingresar la contraseña");
            }
            if (txtidentificacionPaciente.Text == "")
            {
                ok = false;
                errorproviderLogin.SetError(txtidentificacionPaciente, "Por Favor ingresar la identificacion");
            }

            return ok;

        }
        private void BorrarMensajeError()
        {
            errorproviderLogin.SetError(txtContraseñaPaciente, "");
            errorproviderLogin.SetError(txtidentificacionPaciente, "");
            
        }

        
    }
}
