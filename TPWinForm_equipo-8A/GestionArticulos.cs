using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TPWinForm_equipo_8A;



namespace WinTPWinForm_equipo_8AForm
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
		        datos.setearConsulta("select Codigo, Nombre, A.Descripcion, IdMarca, Precio, IdCategoria, C.Descripcion categoria, M.Descripcion marca, ImagenUrl from ARTICULOS A, CATEGORIAS C, MARCAS M, IMAGENES I where C.id = A.IdCategoria and M.id = A.IdMarca and A.Id = I.id\r\n");
	            datos.ejecutarLectura();
            
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = datos.Lector["Codigo"].ToString();
                    aux.Nombre = datos.Lector["Nombre"].ToString();
                    aux.Descripcion = datos.Lector["Descripcion"].ToString();
                    aux.Imagen = datos.Lector["ImagenUrl"].ToString();
                    //decimal preciodec = (decimal)lector["precio"];
                    //aux.Precio = (float)preciodec;
                    aux.Precio = (float) (decimal)datos.Lector["Precio"];

                    aux.categoria = new Categoria();
                    aux.categoria.id = (int)datos.Lector["idCategoria"];

                    aux.marca = new Marca();
                    aux.marca.idM = (int)datos.Lector["idMarca"];

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
                /////////////ACA ESTA EL ERROR CREO QUE HAY ALGO EN EL FORMATO DE LOS DATOS QUE IMPIDE QUE INCERTE DATOS
                //string consulta = "INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio)VALUES ('" + nuevoArticuloiculoiculoiculo.Codigo + "', '" + nuevoArticuloiculoiculoiculo.Nombre + "', '" + nuevoArticuloiculoiculoiculo.Descripcion + "', " + nuevoArticuloiculoiculoiculo.marca.idM + ", " + nuevoArticuloiculoiculoiculo.categoria.id + ", " + nuevoArticuloiculoiculoiculo.Precio + ")";
                string consulta = "INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) " +
"VALUES ('" + nuevoArticulo.Codigo + "', '" + nuevoArticulo.Nombre + "', '" + nuevoArticulo.Descripcion +
"', " + nuevoArticulo.marca.idM + ", " + nuevoArticulo.categoria.id + ", " + nuevoArticulo.Precio + ")";

                datos.setearConsulta(consulta);
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
    }
}
