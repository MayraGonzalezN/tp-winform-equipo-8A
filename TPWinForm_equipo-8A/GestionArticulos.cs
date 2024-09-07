using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinForm
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
                conexion.ConnectionString = "server=.\\SQLEXPRESS01; database=CATALOGO_P3_DB; integrated security=true";
          
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
    }
}
