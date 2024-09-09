using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TPWinForm_equipo_8A;



namespace WinTPWinForm_equipo_8A
{
    class GestionArticulos
    {
        // clase para acceso a datos, listar, agegar, modificar,
        public List<Articulo> Listar()
        { 
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try 
	        {
                datos.setearConsulta("select Codigo, Nombre, A.Descripcion, IdMarca, Precio, IdCategoria, C.Descripcion categoria, M.Descripcion marca from ARTICULOS A, CATEGORIAS C, MARCAS M where C.id = A.IdCategoria and M.id = A.IdMarca\r\n");
                datos.ejecutarLectura();
            
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = datos.Lector["Codigo"].ToString();
                    aux.Nombre = datos.Lector["Nombre"].ToString();
                    aux.Descripcion = datos.Lector["Descripcion"].ToString();
<<<<<<< HEAD
                    //aux.Imagen = datos.Lector["ImagenUrl"].ToString();
                    //decimal preciodec = (decimal)lector["precio"];
                    //aux.Precio = (float)preciodec;
=======

                    if (!(datos.Lector["ImagenUrl"] is DBNull)) { 
                    aux.Imagen = datos.Lector["ImagenUrl"].ToString();
                    }

>>>>>>> 906f552f1bf2753ebe5b6095f4c507f9ddc973e8
                    aux.Precio = (float) (decimal)datos.Lector["Precio"];
                    aux.categoria = new Categoria((int)datos.Lector["idCategoria"], datos.Lector["Categoria"].ToString());
                    aux.marca = new Marca((int)datos.Lector["idMarca"], datos.Lector["Marca"].ToString());

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

        public void agregar(Articulo nuevoArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) " +
                                     "VALUES ('" + nuevoArticulo.Codigo + "', '" + nuevoArticulo.Nombre + "', '" + nuevoArticulo.Descripcion +
                                     "', " + nuevoArticulo.marca.idM + ", " + nuevoArticulo.categoria.Id + ", " + nuevoArticulo.Precio + ")");
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

        public void modificar(Articulo modificar) { }

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
    }
}
