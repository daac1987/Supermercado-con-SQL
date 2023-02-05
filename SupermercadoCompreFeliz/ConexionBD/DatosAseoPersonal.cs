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
    internal class DatosAseoPersonal
    {
        public static void InsertarAseoPersonal(AseoPersonal parametros)
        {
            try
            {
                Conexiones.abrir();
                SqlCommand cmd = new SqlCommand("INSERTARPRODUCTOS", Conexiones.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("NOMBRE", parametros.Name);
                cmd.Parameters.AddWithValue("DESCRIPCION", parametros.Descripcion);
                cmd.Parameters.AddWithValue("TAMAÑO", parametros.Tamaño);
                cmd.Parameters.AddWithValue("CANTIDAD", parametros.Cantidad);
                cmd.Parameters.AddWithValue("CATEGORIA", parametros.Categoria);
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

        public void mostrarAseoPersonal(ref DataTable dt)
        {
            try
            {
                Conexiones.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrarAseoPersonal", Conexiones.conectar);
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
        public static void BorrarAseoPersonal(int idArticulo)
        {
            try
            {
                Conexiones.abrir();
                SqlCommand cmd = new SqlCommand("ELIMINARPRODUCTOS", Conexiones.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("IDARTICULO", idArticulo);
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

        public static void ModificarAseoPersonal(AseoPersonal parametro)
        {
            try
            {
                Conexiones.abrir();
                SqlCommand cmd = new SqlCommand("modificarArticulos", Conexiones.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("IDARTICULO", parametro.Id);
                cmd.Parameters.AddWithValue("NOMBRE", parametro.Name);
                cmd.Parameters.AddWithValue("DESCRIPCION", parametro.Descripcion);
                cmd.Parameters.AddWithValue("TAMAÑO", parametro.Tamaño);
                cmd.Parameters.AddWithValue("CANTIDAD", parametro.Cantidad);
                cmd.Parameters.AddWithValue("CATEGORIA", parametro.Categoria);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto actualizado correctamente");
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
