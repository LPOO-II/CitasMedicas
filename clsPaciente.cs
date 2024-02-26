using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasCitasMedicas_MLCJ
{
     class clsPaciente
     {
        public long bigintIdentificacionPaciente { get; set; }
        public string strNombre { get; set; }
        public string strApellido { get; set; }
        public long bigintTelefono { get; set; }
        public string strEmail { get; set; }
        public string strDireccion { get; set; }
        public string strContrasenaP { get; set; }
       
        public clsPaciente()
        {
        }

        public clsPaciente(long bigintIdentificacionPaciente, string strNombre, string strApellido, long bigintTelefono, string strEmail, string strDireccion, string strContrasenaP)
        {
            this.bigintIdentificacionPaciente = bigintIdentificacionPaciente;
            this.strNombre = strNombre;
            this.strApellido = strApellido;
            this.bigintTelefono = bigintTelefono;
            this.strEmail = strEmail;
            this.strDireccion = strDireccion;
            this.strContrasenaP = strContrasenaP;
        }
        public bool VerificarPacientes(string bigintIdentificacionPaciente)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string Consulta = "SELECT COUNT(1) FROM tblPacientes WHERE bigintIdentificacionPaciente = @bigintIdentificacionPaciente";
            using (SqlCommand comando = new SqlCommand(Consulta, conexion.conexion))
            {
                comando.Parameters.AddWithValue("@bigintIdentificacionPaciente", bigintIdentificacionPaciente);
                int cantidad = Convert.ToInt32(comando.ExecuteScalar());
                return cantidad == 1;
            }


        }
        public bool insertarPaciente()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string InsertarPaciente = "insert into tblPacientes values (@bigintIdentificacionPaciente,@strNombre,@strApellido,@bigintTelefono,@strEmail,@strDireccion,@strContrasenaP)";
            SqlCommand sql = new SqlCommand(InsertarPaciente, conexion.conexion);
            sql.Parameters.AddWithValue("bigintIdentificacionPaciente", this.bigintIdentificacionPaciente);
            sql.Parameters.AddWithValue("strNombre", this.strNombre);
            sql.Parameters.AddWithValue("strApellido", this.strApellido);
            sql.Parameters.AddWithValue("bigintTelefono", this.bigintTelefono);
            sql.Parameters.AddWithValue("strEmail", this.strEmail);
            sql.Parameters.AddWithValue("strDireccion", this.strDireccion);
            sql.Parameters.AddWithValue("strContrasenaP", this.strContrasenaP);
            sql.ExecuteNonQuery();
            return true;
        }
     }

}

