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
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Nombre,Descripcion,idMarca,idCategoria,Codigo FROM ARTICULOS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];

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
