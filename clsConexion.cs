using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasCitasMedicas_MLCJ
{
    class clsConexion
    {
        string cadenaConexion = "Data Source=DESKTOP-40CORT5;Initial Catalog=dboReservaCitasMedicas;Integrated Security=True";

        public SqlConnection conexion = new SqlConnection();

        public clsConexion()
        {
            conexion.ConnectionString = cadenaConexion;
        }

        public void abrirConexion()
        {
            try
            {

                conexion.Open();
                Console.WriteLine("Exitoso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexion" + ex.Message);

            }

        }

        public void cerrarConexion()
        {
            conexion.Close();
        }
    }
}

