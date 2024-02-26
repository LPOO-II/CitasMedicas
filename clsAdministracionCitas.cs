using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace ReservasCitasMedicas_MLCJ
{
    class clsAdministracionCitas
    {
        public long bigintIdDoctor { get; set; }
        public string strNombreDoctor { get; set; }
        public string strApellidoDoctor { get; set; }
        public string strEspecialidad { get; set; }
        public string strEmail { get; set; }
        public string strContrasena { get; set; }
        public int intCodigoCita { get; set; }
        public DateTime dateFechaCita { get; set; }
        public string  strConfirmacionCita { get; set; }
        public string strEspecialista { get; set; }
        public long bigintIdentificacionPaciente { get; set; }

       public clsAdministracionCitas()
       {
            
       }

        public clsAdministracionCitas(string strConfirmacionCita, int intCodigoCita)
        {
            this.intCodigoCita = intCodigoCita;
            this.strConfirmacionCita = strConfirmacionCita;
        }

        public clsAdministracionCitas(long bigintIdDoctor, string strNombreDoctor, string strApellidoDoctor, string strEspecialidad, string strEmail, string strContrasena)
        {
            this.bigintIdDoctor = bigintIdDoctor;
            this.strNombreDoctor = strNombreDoctor;
            this.strApellidoDoctor = strApellidoDoctor;
            this.strEspecialidad = strEspecialidad;
            this.strEmail = strEmail;
            this.strContrasena = strContrasena;
           
        }


        public DataTable consultarDatoAdministracionCitas()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            DataTable dtC = new DataTable();
            string consultaDAC = "Select * from tblCitaMedica";
            SqlCommand cmd = new SqlCommand(consultaDAC, conexion.conexion);
            SqlDataAdapter daC = new SqlDataAdapter(cmd);
            daC.Fill(dtC);
            return dtC;

        }
        public DataTable seleccionarDatoReservaCitaMedica(int bigintIdDoctor)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            this.bigintIdDoctor = bigintIdDoctor;
            DataTable dt = new DataTable();
            string seleccionarRCM = "select * from tblCitaMedica where  bigintIdDoctor=@bigintIdDoctor";
            SqlCommand cmd = new SqlCommand(seleccionarRCM, conexion.conexion);
            cmd.Parameters.AddWithValue("@bigintIdDoctor", this.bigintIdDoctor);
            SqlDataAdapter daD = new SqlDataAdapter(cmd);
            daD.Fill(dt);
            return dt;

        }
        public bool modificarCita(string strConfirmacionCita, int intCodigoCita)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string modificarP = "update tblCitaMedica set strConfirmacionCita=@strConfirmacionCita where intCodigoCita=@intCodigoCita";
            SqlCommand sql = new SqlCommand(modificarP, conexion.conexion);
            sql.Parameters.AddWithValue("@strConfirmacionCita", strConfirmacionCita);
            sql.Parameters.AddWithValue("@intCodigoCita", intCodigoCita);

            sql.ExecuteNonQuery();
            return true;
        }
        private static frmAdministracionCitas instancia = null;
        public static frmAdministracionCitas ventanaUnica()
        {
            if (instancia == null)
            {
                instancia = new frmAdministracionCitas();
                return instancia;
            }
            return instancia;
        }
    }
}
