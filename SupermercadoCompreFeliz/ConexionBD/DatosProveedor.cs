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
    internal class DatosProveedor
    {
        public static void InsertarProvedor(Proveedor parametros)
        {
            try
            {
                Conexiones.abrir();
                SqlCommand cmd = new SqlCommand("insertarProvedor", Conexiones.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("IDPROVEEDOR", parametros.Id);
                cmd.Parameters.AddWithValue("NOMBRE", parametros.Name);
                cmd.Parameters.AddWithValue("IDARTICULO", parametros.IdProducto);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Proveedor: " + parametros.Name + " creado correctamente");
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

        public void mostrarProvedor(ref DataTable dt)
        {
            try
            {
                Conexiones.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrarProvedor", Conexiones.conectar);
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
        public static void BorrarProvedor(int idProvedor)
        {
            try
            {
                Conexiones.abrir();
                SqlCommand cmd = new SqlCommand("eliminarProvedor", Conexiones.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("IDPROVEEDOR", idProvedor);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Proveedor eliminado correctamente");
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

        public static void ModificarProvedor(Proveedor parametro)
        {
            try
            {
                Conexiones.abrir();
                SqlCommand cmd = new SqlCommand("modificarProvedor", Conexiones.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("IDPROVEEDOR", parametro.Id);
                cmd.Parameters.AddWithValue("NOMBRE", parametro.Name);
                cmd.Parameters.AddWithValue("IDARTICULO", parametro.IdProducto);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Proveedor actualizado correctamente");
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
