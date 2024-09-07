using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TPWinForm_equipo-8A
{
    class GestionArticulos
    {
        public List<Articulo> Listar()
        {
            List<Articulo> Lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=Articulos; integrated security = true ";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select CodigoArticulo, Nombre, Descripcion from Productos";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.CodigoArticulo = (string)lector["CodigoArticulo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    //aux.Precio = lector.GetFloat(3);
                    //aux.Imagen = (string)lector["Imagen"];
                    Lista.Add(aux);
                }
                conexion.Close();
                return Lista;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
