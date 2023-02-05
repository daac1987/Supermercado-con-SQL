
using System.Data.SqlClient;
using System.Data;
namespace SupermercadoCompreFeliz.ConexionBD
{
    internal class Conexiones
    {
        public static string conexion = @"Data source = DESKTOP-FJ5LC5T;
         Initial Catalog = SUPERMERCADO;Integrated Security=True";
        public static SqlConnection conectar = new SqlConnection(conexion);
        public static void abrir()
        {
            if (conectar.State==ConnectionState.Closed)
            {
                conectar.Open();    
            }
        }
        public static void cerrar()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }


    }
}
