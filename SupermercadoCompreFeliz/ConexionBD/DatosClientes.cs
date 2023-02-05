using SupermercadoCompreFeliz.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermercadoCompreFeliz.ConexionBD
{
    internal class DatosClientes
    {
        public static void InsertarCliente(Cliente parametros)
        {
            try
            {
                Conexiones.abrir();
                SqlCommand cmd = new SqlCommand("insertarClientes", Conexiones.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("IDCLIENTE", parametros.Id);
                cmd.Parameters.AddWithValue("NOMBRE", parametros.Name);
                cmd.Parameters.AddWithValue("DIRECCION",parametros.Direccion);
                cmd.Parameters.AddWithValue("TIPOCLIENTE", parametros.TipoCliente);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente: "+parametros.Name+" creado correctamente");
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

        public void mostrarClientes(ref DataTable dt)
        {
            try
            {
                Conexiones.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrarClientes", Conexiones.conectar);
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
        public static void BorrarClientes(int idCliente)
        {
            try
            {
                Conexiones.abrir();
                SqlCommand cmd = new SqlCommand("eliminarClientes", Conexiones.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("IDcliente", idCliente);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente eliminado correctamente");
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

        public static void ModificarClientes(Cliente parametro)
        {
            try
            {
                Conexiones.abrir();
                SqlCommand cmd = new SqlCommand("modificarClientes", Conexiones.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("IDCLIENTE", parametro.Id);
                cmd.Parameters.AddWithValue("NOMBRE", parametro.Name);
                cmd.Parameters.AddWithValue("DIRECCION", parametro.Direccion);
                cmd.Parameters.AddWithValue("TIPOCLIENTE", parametro.TipoCliente);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente actualizado correctamente");
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
