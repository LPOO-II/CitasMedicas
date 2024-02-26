using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservasCitasMedicas_MLCJ
{
     class clsLogin
     {
        public bool VerificarPacientes(string bigintIdentificacionPaciente, string strContrasenaP)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string Consulta = "SELECT COUNT(1) FROM tblPacientes WHERE bigintIdentificacionPaciente = @bigintIdentificacionPaciente AND strContrasenaP = @strContrasenaP";
            using (SqlCommand comando = new SqlCommand(Consulta, conexion.conexion))
            {
                comando.Parameters.AddWithValue("@bigintIdentificacionPaciente", bigintIdentificacionPaciente);
                comando.Parameters.AddWithValue("@strContrasenaP", strContrasenaP);
                int cantidad = Convert.ToInt32(comando.ExecuteScalar());
                return cantidad == 1;
            }


        }
        public bool VerificarDoctores(string bigintIdDoctor, string strContrasena)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string Consulta = "SELECT COUNT(1) FROM tblDoctor WHERE bigintIdDoctor = @bigintIdDoctor AND strContrasena=@strContrasena";
            using (SqlCommand comando = new SqlCommand(Consulta, conexion.conexion))
            {
                comando.Parameters.AddWithValue("@bigintIdDoctor", bigintIdDoctor);
                comando.Parameters.AddWithValue("@strContrasena", strContrasena);
                int cantidad = Convert.ToInt32(comando.ExecuteScalar());
                return cantidad == 1;
            }
        }
       
     }
}
