using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using negocio;
using System.Reflection;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace CATALOGO
{
    internal class ArticuloService
    {
        private List<Articulo> _listaArticulos;
        public ArticuloService()
        {
            // Inicializa la lista de artículos
            _listaArticulos = new List<Articulo>();
        }
        public void agregar(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo,Nombre,Descripcion,Precio,ImagenUrl) VALUES ('" + art.CODIGO + "','" + art.NOMBRE + "','" + art.DESCRIPCION + "','" + art.PRECIO + "','" + art.Imagen);
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
                datos.setearParametro("@codigo", art.CODIGO);
                datos.setearParametro("@nombre", art.NOMBRE);
                datos.setearParametro("@descripcion", art.DESCRIPCION);
                datos.setearParametro("@precio", art.PRECIO);
                datos.setearParametro("@img", art.Imagen);
                datos.setearParametro("@id", art.ID);
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

        public void eliminarArticulo(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("DELETE FROM ARTICULOS WHERE Id = @id");
                datos.setearParametro("@id", id);
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


        public List<Articulo> ListarArticulos()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT A.*, M.Descripcion AS MarcaDescripcion, C.Descripcion AS CategoriaDescripcion, I.* FROM ARTICULOS A " +
                                     "INNER JOIN MARCAS M ON A.IdMarca = M.Id " +
                                     "INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id " +
                                     "INNER JOIN IMAGENES I ON A.Id = I.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    lista.Add(new Articulo
                    {
                        ID = Convert.ToInt32(datos.Lector["Id"]),
                        CODIGO = datos.Lector["Codigo"].ToString(),
                        NOMBRE = datos.Lector["Nombre"].ToString(),
                        DESCRIPCION = datos.Lector["Descripcion"].ToString(),
                        PRECIO = Convert.ToDecimal(datos.Lector["Precio"]),
                        Marca = new Marca
                        {
                            Id = Convert.ToInt32(datos.Lector["IdMarca"]),
                            Descripcion = datos.Lector["MarcaDescripcion"].ToString()
                        },
                        Categoria = new Categoria
                        {
                            Id = Convert.ToInt32(datos.Lector["IdCategoria"]),
                            Descripcion = datos.Lector["Descripcion"].ToString()
                        },
                        Imagen = new Imagen
                        {
                            Codigo = Convert.ToInt32(datos.Lector["IdArticulo"]),
                            Url = datos.Lector["ImagenUrl"].ToString()
                        }
                    });
                }
                return lista;
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
