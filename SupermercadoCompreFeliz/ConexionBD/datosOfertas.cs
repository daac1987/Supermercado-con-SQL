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
    internal class datosOfertas
    {
        public static void InsertarCompras(Ofertas parametros)
        {
            try
            {
                Conexiones.abrir();
                SqlCommand cmd = new SqlCommand("INSERTAROFERTAS", Conexiones.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("IDARTICULO", parametros.IdProducto);
                cmd.Parameters.AddWithValue("FECHAINICIAL", parametros.FechaInicio);
                cmd.Parameters.AddWithValue("FECHAFINAL", parametros.Fechafinal);
                cmd.Parameters.AddWithValue("DESCUENTO", parametros.Descuento);
                cmd.Parameters.AddWithValue("MONTOFINAL", parametros.MontoTotal);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ofarta a producto " + parametros.IdProducto + " creada correctamente");
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

        public void mostrarOferta(ref DataTable dt)
        {
            try
            {
                Conexiones.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrarOfertas", Conexiones.conectar);
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
        public static void BorrarOfertas(int idCompra)
        {
            try
            {
                Conexiones.abrir();
                SqlCommand cmd = new SqlCommand("ELIMINAROFERTAS", Conexiones.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("IDOFERTA", idCompra);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Oferta eliminada correctamente");
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

        public static void ModificarOferta(Ofertas parametros)
        {
            try
            {
                Conexiones.abrir();
                SqlCommand cmd = new SqlCommand("modificarOfertas", Conexiones.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("IDOFERTAS", parametros.IdOfertas);
                cmd.Parameters.AddWithValue("IDARTICULO", parametros.IdProducto);
                cmd.Parameters.AddWithValue("FECHAINICIAL", parametros.FechaInicio);
                cmd.Parameters.AddWithValue("FECHAFINAL", parametros.Fechafinal);
                cmd.Parameters.AddWithValue("DESCUENTO", parametros.Descuento);
                cmd.Parameters.AddWithValue("MONTOFINAL", parametros.MontoTotal);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Oferta actualizada correctamente");
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
