using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_equipo_8A
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public SqlDataReader Lector
        {
            get { return lector; }
        }
        public AccesoDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true");
            comando = new SqlCommand();
        }
        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }
        public void SetearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }
        public int ObtenerIdArticulo(string codigo) //Permite obtener el nuevo codigo id de articulo
        {
            int id = 0;
            try
            {
                setearConsulta("SELECT Id FROM ARTICULOS WHERE Codigo = @Codigo");
                SetearParametro("@Codigo", codigo);
                ejecutarLectura();
                if (Lector.Read())
                {
                    id = (int)(Lector["Id"]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cerrarConexion();
            }
            return id;


        }
//..................................................validar.........................................................

        public bool ExisteCodigoArticulo(string codigo, int idArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            bool existe = false;

            try
            {
                string consulta;
                if (idArticulo == 0)
                {
                    consulta = "SELECT Codigo FROM ARTICULOS WHERE Codigo = @codigo";
                }
                else
                {
                    consulta = "SELECT Codigo FROM ARTICULOS WHERE Codigo = @codigo AND Id != @idArticulo";
                }
                setearConsulta(consulta);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@codigo", codigo);
                if (idArticulo != 0)
                {
                    comando.Parameters.AddWithValue("@idArticulo", idArticulo);
                }
                ejecutarLectura();
                if (Lector.Read())
                {
                    existe = true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cerrarConexion();
            }
            return existe;
        }
        public bool ExisteCategotia(int idCategoria)
        {
            bool existe = false;
            
            try
            {
                setearConsulta("SELECT Id FROM CATEGORIAS WHERE Id = @idCategoria");
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idCategoria", idCategoria);
                ejecutarLectura();

                if (Lector.Read())
                {
                    existe = true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cerrarConexion();
            }
            return existe;
        }
        public bool ExisteMarca(int idMarca)
        {
            bool existe = false;

            try
            {
                setearConsulta("SELECT Id FROM MARCAS WHERE Id = @idMarca");
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idMarca", idMarca);
                ejecutarLectura();

                if (Lector.Read())
                {
                    existe = true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cerrarConexion();
            }
            return existe;
        }
    }
}




