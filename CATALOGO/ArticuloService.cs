using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using negocio;

namespace CATALOGO
{
    internal class ArticuloService
    {

        public void agregar(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo,Nombre,Descripcion,Precio,ImagenUrl) VALUES ('" + art.codigo + "','" + art.nombre + "','" + art.descripcion + "','" + art.precio + "','" + art.imagen);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        // ver el tema de las catagoria y marca
        public void modificar(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE ARTICULOS SET Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, Precio = @precio, ImagenUrl = @img, IdMarca = @idMarca, IdCategoria = @idCategoria WHERE Id = @id");
                datos.setearParametro("@codigo", art.codigo);
                datos.setearParametro("@nombre", art.nombre);
                datos.setearParametro("@descripcion", art.descripcion);
                datos.setearParametro("@precio", art.precio);
                datos.setearParametro("@img", art.imagen);
                datos.setearParametro("@id", art.id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

    }
}
