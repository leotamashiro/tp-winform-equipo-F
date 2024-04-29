using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

using dominio;

namespace negocio
{
    public class ArticuloService
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
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion,IdMarca, IdCategoria, Precio) VALUES (@codigo, @nombre, @descripcion, @idMarca, @idCategoria, @precio)");
                datos.setearParametro("@codigo", art.CODIGO);
                datos.setearParametro("@nombre", art.NOMBRE);
                datos.setearParametro("@descripcion", art.DESCRIPCION);
                datos.setearParametro("@idMarca", art.MARCA.Id);
                datos.setearParametro("@idCategoria", art.CATEGORIA.Id);
                datos.setearParametro("@precio", art.PRECIO);
                datos.ejecutarAccion();

                datos.setearConsulta("SELECT MAX(Id) AS MaxId FROM ARTICULOS");
                datos.ejecutarLectura();

                int nuevoId = 0;

                if (datos.Lector.Read() && datos.Lector["MaxId"] != DBNull.Value)
                {
                    nuevoId = Convert.ToInt32(datos.Lector["MaxId"]);
                }

                datos.cerrarConexion();

                if (art.IMAGEN != null)
                {
                    datos.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@idArticulo, @imagenUrl)");
                    datos.setearParametro("@idArticulo", nuevoId);
                    datos.setearParametro("@imagenUrl", art.IMAGEN.Url);
                    datos.ejecutarAccion();
                }
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
                datos.setearConsulta("UPDATE ARTICULOS SET CODIGO = @codigo, NOMBRE = @nombre, DESCRIPCION = @descripcion, IdMarca =@idMarca, IdCategoria=@idCategoria ,PRECIO = @precio WHERE ID = @id");
                datos.setearParametro("@codigo", art.CODIGO);
                datos.setearParametro("@id", art.ID);
                datos.setearParametro("@nombre", art.NOMBRE);
                datos.setearParametro("@descripcion", art.DESCRIPCION);
                datos.setearParametro("@precio", art.PRECIO);
                datos.setearParametro("@idMarca", art.MARCA.Id);
                datos.setearParametro("@idCategoria", art.CATEGORIA.Id);
                datos.ejecutarAccion();

                if (art.IMAGEN != null)
                {
                    datos.setearConsulta("UPDATE IMAGENES SET ImagenUrl = @imagenUrl WHERE IdArticulo = @idArticulo");
                    datos.setearParametro("@imagenUrl", art.IMAGEN.Url);
                    datos.setearParametro("@idArticulo", art.ID);
                    datos.ejecutarAccion();
                }
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
                datos.setearConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion AS Marca, C.Descripcion AS Categoria, A.Precio, I.ImagenUrl FROM ARTICULOS A INNER JOIN MARCAS M ON A.IdMarca = M.Id INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id INNER JOIN IMAGENES I ON A.Id = I.IdArticulo; ");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.ID = Convert.ToInt32(datos.Lector["Id"]);
                    aux.CODIGO = (string)datos.Lector["Codigo"];
                    aux.NOMBRE = (string)datos.Lector["Nombre"];
                    aux.DESCRIPCION = (string)datos.Lector["Descripcion"];
                    aux.PRECIO = Math.Truncate(100 * (decimal)datos.Lector["Precio"]) / 100;
                    aux.MARCA = new Marca();
                    aux.MARCA.Descripcion = (string)datos.Lector["Marca"];
                    aux.CATEGORIA = new Categoria();
                    aux.CATEGORIA.Descripcion = (string)datos.Lector["Categoria"];
                    aux.IMAGEN = new Imagen();
                    aux.IMAGEN.Url = (string)datos.Lector["ImagenUrl"];

                    lista.Add(aux);
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

        public Articulo listarArticuloXID(int id)
        {
            Articulo articulo = null;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT A.*, M.Descripcion AS MarcaDescripcion, CA.Descripcion AS CategoriaDescripcion, I.* " +
                                     "FROM ARTICULOS A " +
                                     "INNER JOIN MARCAS M ON A.IdMarca = M.Id " +
                                     "INNER JOIN CATEGORIAS CA ON A.IdCategoria = CA.Id " +
                                     "INNER JOIN IMAGENES I ON A.Id = I.IdArticulo " +
                                     "WHERE A.Id = @Id");
                datos.setearParametro("@Id", id);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    articulo = new Articulo
                    {
                        ID = Convert.ToInt32(datos.Lector["Id"]),
                        CODIGO = datos.Lector["Codigo"].ToString(),
                        NOMBRE = datos.Lector["Nombre"].ToString(),
                        DESCRIPCION = datos.Lector["Descripcion"].ToString(),
                        PRECIO = Convert.ToDecimal(datos.Lector["Precio"]),
                        MARCA = new Marca
                        {
                            Id = Convert.ToInt32(datos.Lector["IdMarca"]),
                            Descripcion = datos.Lector["MarcaDescripcion"].ToString()
                        },
                        CATEGORIA = new Categoria
                        {
                            Id = Convert.ToInt32(datos.Lector["IdCategoria"]),
                            Descripcion = datos.Lector["CategoriaDescripcion"].ToString()
                        },
                        IMAGEN = new Imagen
                        {
                            Codigo = Convert.ToInt32(datos.Lector["IdArticulo"]),
                            Url = datos.Lector["ImagenUrl"].ToString()
                        }
                    };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
            return articulo;
        }

    }
}
