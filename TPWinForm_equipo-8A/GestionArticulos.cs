using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TPWinForm_equipo_8A;


namespace WinForm
{
    class GestionArticulos
    {
        // clase para acceso a datos, listar, agegar, modificar,
        public List<Articulo> Listar()
        {
            List<Articulo> Lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
<<<<<<< HEAD
          
=======
>>>>>>> 29a90685e86820cdda7e60fb5ea9a77e23340742
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Codigo, Nombre, A.Descripcion, IdMarca, Precio, IdCategoria, C.Descripcion categoria, M.Descripcion marca, ImagenUrl from ARTICULOS A, CATEGORIAS C, MARCAS M, IMAGENES I where C.id = A.IdCategoria and M.id = A.IdMarca and A.Id = I.id\r\n";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = lector["Codigo"].ToString();
                    aux.Nombre = lector["Nombre"].ToString();
                    aux.Descripcion = lector["Descripcion"].ToString();
                    aux.Imagen = lector["ImagenUrl"].ToString();
                    //decimal preciodec = (decimal)lector["precio"];
                    //aux.Precio = (float)preciodec;
                    aux.Precio = (float)(decimal)lector["Precio"];

                    aux.categoria = new Categoria();
                    aux.categoria.id = (int)lector["idCategoria"];

                    aux.marca = new Marca();
                    aux.marca.idM = (int)lector["idMarca"];

                    Lista.Add(aux);
                }
                conexion.Close();
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void agregar(Articulo nuevoArt)
        {
            AccesoDatos datos = new AccesoDatos();


            try
            {
                /////////////ACA ESTA EL ERROR CREO QUE HAY ALGO EN EL FORMATO DE LOS DATOS QUE IMPIDE QUE INCERTE DATOS
                string consulta = "INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) " +
                "VALUES ('" + nuevoArt.Codigo + "', '" + nuevoArt.Nombre + "', '" + nuevoArt.Descripcion +
                "', " + nuevoArt.marca.idM + ", " + nuevoArt.categoria.id + ", " + nuevoArt.Precio + ")"; 

           
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
