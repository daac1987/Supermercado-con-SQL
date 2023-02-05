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
    internal class DatosCompras
    {
        public static void InsertarCompras(Compras parametros)
        {
            try
            {
                Conexiones.abrir();
                SqlCommand cmd = new SqlCommand("INSERTARCOMPRA", Conexiones.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("IDEMPLEADO", parametros.IdEmpleado);
                cmd.Parameters.AddWithValue("IDCLIENTE", parametros.IdCliente);
                cmd.Parameters.AddWithValue("IDARTICULO", parametros.IdProducto);
                cmd.Parameters.AddWithValue("FECHA", parametros.Fecha);
                cmd.Parameters.AddWithValue("DESCUENTO", parametros.Descuento);
                cmd.Parameters.AddWithValue("MONTOFINAL", parametros.MontoTotal);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Empleado " + parametros.IdEmpleado + " realizo la venta correctamente");
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

        public void mostrarCompra(ref DataTable dt)
        {
            try
            {
                Conexiones.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrarCompra", Conexiones.conectar);
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
        public static void BorrarCompra(int idCompra)
        {
            try
            {
                Conexiones.abrir();
                SqlCommand cmd = new SqlCommand("ELIMINARCOMPRA", Conexiones.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("IDCOMPRA", idCompra);
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

        public static void ModificarCompra(Compras parametro)
        {
            try
            {
                Conexiones.abrir();
                SqlCommand cmd = new SqlCommand("modificarCompra", Conexiones.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("IDCOMPRA", parametro.IdCompra);
                cmd.Parameters.AddWithValue("IDEMPLEADO", parametro.IdEmpleado);
                cmd.Parameters.AddWithValue("IDCLIENTE", parametro.IdCliente);
                cmd.Parameters.AddWithValue("IDARTICULO", parametro.IdProducto);
                cmd.Parameters.AddWithValue("FECHA", parametro.Fecha);
                cmd.Parameters.AddWithValue("DESCUENTO", parametro.Descuento);
                cmd.Parameters.AddWithValue("MONTOFINAL", parametro.MontoTotal);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Compra actualizado correctamente");
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
