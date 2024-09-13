using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TPWinForm_equipo_8A;
using System.Text.RegularExpressions;
using System.Windows.Forms;



namespace WinTPWinForm_equipo_8A
{
    class GestionArticulos
    {
        // clase para listar, agegar, modificar,
        public List<Articulo> Listar()
        { 
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try 
	        {
                datos.setearConsulta(@"SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, M.Descripcion AS Marca, 
                                     A.IdCategoria, C.Descripcion AS Categoria, A.Precio, 
                                     MIN(I.ImagenUrl) AS ImagenUrl
                                     FROM ARTICULOS A
                                     JOIN MARCAS M ON A.IdMarca = M.Id
                                     LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id
                                     LEFT JOIN IMAGENES I ON A.Id = I.IdArticulo
                                     GROUP BY A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, M.Descripcion, A.IdCategoria, C.Descripcion, A.Precio");
                datos.ejecutarLectura();
            
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = datos.Lector["Codigo"].ToString();
                    aux.Nombre = datos.Lector["Nombre"].ToString();
                    aux.Descripcion = datos.Lector["Descripcion"].ToString();
                    aux.marca = new Marca((int)datos.Lector["IdMarca"], datos.Lector["marca"].ToString());
                    aux.categoria = new Categoria((int)datos.Lector["idCategoria"], datos.Lector["categoria"].ToString());
                    if (!(datos.Lector["ImagenUrl"] is DBNull)) { 
                    aux.Imagen = datos.Lector["ImagenUrl"].ToString();
                    }
                    else
                    {
                        aux.Imagen = "https://media.istockphoto.com/id/1128826884/es/vector/ning%C3%BAn-s%C3%ADmbolo-de-vector-de-imagen-falta-icono-disponible-no-hay-galer%C3%ADa-para-este-momento.jpg?s=612x612&w=0&k=20&c=9vnjI4XI3XQC0VHfuDePO7vNJE7WDM8uzQmZJ1SnQgk=";
                    }
                    aux.Precio = (float)(decimal)datos.Lector["Precio"];
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
        public void agregar(Articulo articuloNuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            agregarArticulo(articuloNuevo);
            int idArticulo = datos.ObtenerIdArticulo(articuloNuevo.Codigo);
            agregarImagenUrl(idArticulo,articuloNuevo.Imagen);
        }
        public void agregarArticulo(Articulo nuevoArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdCategoria, IdMarca, Precio) " +
                                     "VALUES (@Codigo, @Nombre, @Descripcion, @IdCategoria, @IdMarca, @Precio);");
                datos.SetearParametro("@Codigo", nuevoArticulo.Codigo);
                datos.SetearParametro("@Nombre", nuevoArticulo.Nombre);
                datos.SetearParametro("@Descripcion", nuevoArticulo.Descripcion);
                datos.SetearParametro("@IdCategoria", nuevoArticulo.categoria.Id);
                datos.SetearParametro("@IdMarca", nuevoArticulo.marca.idM);
                datos.SetearParametro("@Precio", nuevoArticulo.Precio);
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
        public void agregarImagenUrl(int idArticulo, string Imagen)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) " +
                                     "VALUES (@IdArticulo, @ImagenUrl)");
                datos.SetearParametro("@IdArticulo", idArticulo);
                datos.SetearParametro("@ImagenUrl", Imagen);
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
        public void Modificar(Articulo modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            modificarArticulo(modificar);
            int idArticulo = datos.ObtenerIdArticulo(modificar.Codigo);
            modificarImagenUrl(idArticulo, modificar.Imagen);
        }
        public void modificarArticulo(Articulo modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
            datos.setearConsulta("UPDATE ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca," +
                                 "IdCategoria = @IdCategoria, Precio = @Precio where Id = @Id"); 
            datos.SetearParametro("@Codigo", modificar.Codigo);
            datos.SetearParametro("@Nombre", modificar.Nombre);
            datos.SetearParametro("@Descripcion", modificar.Descripcion);
            datos.SetearParametro("@IdCategoria", modificar.categoria.Id);
            datos.SetearParametro("@IdMarca", modificar.marca.idM);
            datos.SetearParametro("@Precio", modificar.Precio);
            datos.SetearParametro("@Id", modificar.Id);
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
        public void modificarImagenUrl(int idArticulo, string Imagen)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE IMAGENES SET ImagenUrl = @ImagenUrl where idArticulo = @IdArticulo");
                datos.SetearParametro("@IdArticulo", idArticulo);
                datos.SetearParametro("@ImagenUrl", Imagen);
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
        public void Eliminar(Articulo Eliminar) {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "DELETE FROM ARTICULOS where Codigo = '"+ Eliminar.Codigo +"'";
                datos.setearConsulta(consulta);
                datos.ejecutarAccion();
            }
            catch (Exception ex) {
                throw ex;
            }
            finally { datos.cerrarConexion();}
        }

        public Articulo BuscarMenorPrecio()
        {
            AccesoDatos datos = new AccesoDatos();
            Articulo articuloMenorPrecio = null;

            try
            {
                string consulta = "SELECT TOP 1 Codigo, Nombre, Descripcion, IdCategoria, IdMarca, Precio " +
                                  "FROM ARTICULOS ORDER BY Precio ASC";
                datos.setearConsulta(consulta);


                datos.ejecutarLectura();

           
                if (datos.Lector.Read())
                {
                    articuloMenorPrecio = new Articulo
                    {
                        Codigo = datos.Lector["Codigo"].ToString(),
                        Nombre = datos.Lector["Nombre"].ToString(),
                        Descripcion = datos.Lector["Descripcion"].ToString(),
                        Precio = (float)(decimal)datos.Lector["Precio"]
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

            return articuloMenorPrecio;
        }












    }
}