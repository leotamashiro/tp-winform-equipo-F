using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

using dominio;
using System.Text.RegularExpressions;

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
                datos.setearParametro("@nombre", art.NOMBRE);
                datos.setearParametro("@descripcion", art.DESCRIPCION);
                datos.setearParametro("@precio", art.PRECIO);
                datos.setearParametro("@id", art.ID);
                datos.setearParametro("@idMarca", art.MARCA.Id);
                datos.setearParametro("@idCategoria", art.CATEGORIA.Id);
                datos.ejecutarAccion();

                if (art.IMAGEN != null)
                {
                    datos.setearConsulta("UPDATE IMAGENES SET ImagenUrl = @imagenUrl WHERE IdArticulo = @id");
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
                datos.setearConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, M.Descripcion AS Marca, C.Descripcion AS Categoria, STRING_AGG(I.ImagenUrl, ', ') AS Imagenes FROM ARTICULOS A LEFT JOIN MARCAS M ON A.IdMarca = M.Id LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id LEFT JOIN IMAGENES I ON A.Id = I.IdArticulo GROUP BY A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, M.Descripcion, C.Descripcion;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.ID = Convert.ToInt32(datos.Lector["Id"]);
                    if (!(datos.Lector["Codigo"]is DBNull)) aux.CODIGO = (string)datos.Lector["Codigo"];
                    if (!(datos.Lector["Nombre"] is DBNull)) aux.NOMBRE = (string)datos.Lector["Nombre"];
                    if (!(datos.Lector["Descripcion"] is DBNull)) aux.DESCRIPCION = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["Precio"] is DBNull)) aux.PRECIO = Math.Truncate(100 * (decimal)datos.Lector["Precio"]) / 100;
                    aux.MARCA = new Marca();
                    if (!(datos.Lector["Marca"] is DBNull)) aux.MARCA.Descripcion = (string)datos.Lector["Marca"];
                    aux.CATEGORIA = new Categoria();
                    if (!(datos.Lector["Categoria"] is DBNull)) aux.CATEGORIA.Descripcion = (string)datos.Lector["Categoria"];
                    aux.IMAGEN = new Imagen();
                    if (!(datos.Lector["Imagenes"] is DBNull)) aux.IMAGEN.Url = (string)datos.Lector["Imagenes"];

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
                datos.setearConsulta("SELECT A.*, M.Descripcion AS MarcaDescripcion, CA.Descripcion AS CategoriaDescripcion, STRING_AGG(I.ImagenUrl, ', ') AS Imagenes FROM ARTICULOS A INNER JOIN MARCAS M ON A.IdMarca = M.Id INNER JOIN CATEGORIAS CA ON A.IdCategoria = CA.Id INNER JOIN IMAGENES I ON A.Id = I.IdArticulo WHERE A.Id = @id GROUP BY A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, A.IdMarca, A.IdCategoria, M.Descripcion, CA.Descripcion;");
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
                            Codigo = Convert.ToInt32(datos.Lector["Id"]),
                            Url = datos.Lector["Imagenes"].ToString()
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

        public void agregarNuevaImagen(int id,string url)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@Id, @imagenUrl)");
                datos.setearParametro("@Id", id);
                datos.setearParametro("@imagenUrl", url);
                datos.ejecutarLectura();
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
