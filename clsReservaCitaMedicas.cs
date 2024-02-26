using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservasCitasMedicas_MLCJ
{
    class clsReservaCitaMedicas
    {
        public int intCodigoCita { get; set; }
        public  DateTime dateFechaCita { get; set; }
        public string strTurnoCita { get; set; }    
        public string strEspecialista { get; set; }
        public string strConfirmacionCita { get; set; }
        public long bigintIdDoctor { get; set; }
        public long bigintIdentificacionPaciente { get; set; }

        public clsReservaCitaMedicas()
        {
        }

        public clsReservaCitaMedicas(int intCodigoCita, DateTime dateFechaCita, string strTurnoCita, string strEspecialista, string strConfirmacionCita, long bigintIdDoctor, long bigintIdentificacionPaciente)
        {
            this.intCodigoCita = intCodigoCita;
            this.dateFechaCita = dateFechaCita;
            this.strTurnoCita = strTurnoCita;
            this.strEspecialista = strEspecialista;
            this.strConfirmacionCita = strConfirmacionCita;
            this.bigintIdDoctor = bigintIdDoctor;
            this.bigintIdentificacionPaciente = bigintIdentificacionPaciente;

        }

        public bool insertarDatoReservaCitaMedica()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string insertarRCM = "insert into tblCitaMedica values (@intCodigoCita,@dateFechaCita,@strTurnoCita,@strEspecialista,@strConfirmacionCita,@bigintIdDoctor,@bigintIdentificacionPaciente)";
            SqlCommand sql = new SqlCommand(insertarRCM, conexion.conexion);

            sql.Parameters.AddWithValue("@intCodigoCita", this.intCodigoCita);
            sql.Parameters.AddWithValue("@dateFechaCita", SqlDbType.Date).Value = this.dateFechaCita;
            sql.Parameters.AddWithValue("@strTurnoCita", this.strTurnoCita);
            sql.Parameters.AddWithValue("@strEspecialista", this.strEspecialista);
            sql.Parameters.AddWithValue("@strConfirmacionCita", this.strConfirmacionCita);
            sql.Parameters.AddWithValue("@bigintIdDoctor", this.bigintIdDoctor);
            sql.Parameters.AddWithValue("@bigintIdentificacionPaciente", this.bigintIdentificacionPaciente);
            sql.ExecuteNonQuery();
            return true;
        }

        public DataTable consultarDatoReservaCitaMedica()
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            DataTable dtC = new DataTable();
            string consultaRCM = "Select * from tblCitaMedica";
            SqlCommand cmd = new SqlCommand(consultaRCM, conexion.conexion);
            SqlDataAdapter daC = new SqlDataAdapter(cmd);
            daC.Fill(dtC);
            return dtC;
        }

        public DataTable seleccionarDatoReservaCitaMedica(long bigintIdentificacionPaciente)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            this.bigintIdentificacionPaciente = bigintIdentificacionPaciente;
            DataTable dt = new DataTable();
            string seleccionarRCM = "select * from tblCitaMedica where  bigintIdentificacionPaciente= @bigintIdentificacionPaciente";
            SqlCommand cmd = new SqlCommand(seleccionarRCM, conexion.conexion);
            cmd.Parameters.AddWithValue("@bigintIdentificacionPaciente", this.bigintIdentificacionPaciente);
            SqlDataAdapter daD = new SqlDataAdapter(cmd);
            daD.Fill(dt);
            return dt;

        }

        public int ObtenerIdUsuarioPorNombre(string strNombreDoctor)
        {
            int bigintIdDoctor = -1; 

            string consulta = "SELECT bigintIdDoctor FROM tblDoctor WHERE strNombreDoctor = @strNombreDoctor";

            
            using (SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-40CORT5;Initial Catalog=dboReservaCitasMedicas;Integrated Security=True"))
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@strNombreDoctor", strNombreDoctor);

                    conexion.Open();
                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        bigintIdDoctor = Convert.ToInt32(resultado);
                    }
                }
            }

            return bigintIdDoctor;
        }

        public bool VerificarDisponibilidadCita(int bigintIdentificacionPaciente, DateTime dateFechaCita, string strTurnoCita, int bigintIdDoctor)
        {
            clsConexion conexion = new clsConexion();
            conexion.abrirConexion();
            string query = "SELECT COUNT(*) FROM tblCitaMedica WHERE dateFechaCita = @dateFechaCita AND strTurnoCita = @strTurnoCita AND bigintIdDoctor = @bigintIdDoctor";
            using (SqlCommand command = new SqlCommand(query,conexion.conexion))
            {
                command.Parameters.AddWithValue("@dateFechaCita", dateFechaCita);
                command.Parameters.AddWithValue("@strTurnoCita", strTurnoCita);
                command.Parameters.AddWithValue("@bigintIdentificacionPaciente", bigintIdentificacionPaciente);
                command.Parameters.AddWithValue("@bigintIdDoctor", bigintIdDoctor);
                int citasExistentes = Convert.ToInt32(command.ExecuteScalar());
                return citasExistentes>0;
            }
        }
        public int GenerarNumeroAleatorio()
        {
            Random random = new Random();
            return random.Next(5000);
        }
    }
}
