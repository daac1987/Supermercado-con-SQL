using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SupermercadoCompreFeliz.Clases;

namespace SupermercadoCompreFeliz.ConexionBD
{
    internal class DatosEmpleados
    {
        public static void InsertarEmpleados (Empleado parametros)
        {
			try
			{
                Conexiones.abrir();
                SqlCommand cmd = new SqlCommand("insertarEmpleados", Conexiones.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("IDEMPLEADOS",parametros.Id);
                cmd.Parameters.AddWithValue("NOMBRE", parametros.Name);
                cmd.Parameters.AddWithValue("SALARIO", parametros.Salario);
                cmd.Parameters.AddWithValue("PUESTO", parametros.Puesto);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Empleados: " + parametros.Name + " creado correctamente");
            }
			catch (Exception e)
			{
                MessageBox.Show(e.Message);
			}
            finally
            {
                Conexiones.cerrar();
            }
        }
        public void mostraEmpleados(ref DataTable dt)
        {
            try
            {
                Conexiones.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrarEmpleados",Conexiones.conectar);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Conexiones.cerrar();
            }
        }

        public static void BorrarEmpleados(int idEmpleado)
        {
            try
            {
                Conexiones.abrir();
                SqlCommand cmd = new SqlCommand("eliminarEmpleados", Conexiones.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("IDEMPLEADOS", idEmpleado);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Empleado eliminado correctamente");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Conexiones.cerrar();
            }
        }
        public static void ModificarEmpleados(Empleado parametro)
        {
            try
            {
                Conexiones.abrir();
                SqlCommand cmd = new SqlCommand("modificarEmpleados", Conexiones.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("IDEMPLEADOS", parametro.Id);
                cmd.Parameters.AddWithValue("NOMBRE", parametro.Name);
                cmd.Parameters.AddWithValue("SALARIO", parametro.Salario);
                cmd.Parameters.AddWithValue("PUESTO", parametro.Puesto);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Empleado actualizado creado correctamente");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Conexiones.cerrar();
            }
        }
    }
}
