using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_8A
{
    public partial class EditarCategorias : Form
    {
        public EditarCategorias()
        {
            InitializeComponent();
        }

        private void cargarCategoria()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            List<Categoria> lista = negocio.listar();
            dgvEditarCategorias.DataSource = null;
            dgvEditarCategorias.DataSource = lista;
        }

        private void EditarCategorias_Load(object sender, EventArgs e)
        {
            cargarCategoria();
        }

        //........................................validacion
       

    
        private bool ValidarCategoriaDescripcion(string nombreC)
        {
            AccesoDatos datosValidarCate = new AccesoDatos();
            return datosValidarCate.ExisteNombreCategoria(nombreC);


        }

        private void btnAceptarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria nuevaCategoria = new Categoria();
                nuevaCategoria.Nombre = TxtNuevaCategoria.Text;

                if (!(ValidarCategoriaDescripcion(nuevaCategoria.Nombre)))
                {

                    CategoriaNegocio negocio = new CategoriaNegocio();
                    negocio.agregar(nuevaCategoria);

                    MessageBox.Show("Categoria agregada exitosamente.");

                    cargarCategoria();
                    TxtNuevaCategoria.Clear();

                }
                else
                {
                    MessageBox.Show("La categoria ya existe en la base de datos,agregue otra distinta.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar la categoria: " + ex.Message);
            }
        }

        private bool ValidarCodigoCategoria(int codCat)
        {
            AccesoDatos datosValidarCod=new AccesoDatos();
           return  datosValidarCod.ExisteIDcategoria(codCat);

        }
        private void BtnEliminarCategoria_Click(object sender, EventArgs e)
        {
            AccesoDatos datos = new AccesoDatos();  
            try
            {
                int idCategoria = Convert.ToInt32(TxtEliminarCategoria.Text);

<<<<<<< HEAD
                CategoriaNegocio negocio = new CategoriaNegocio();
                if (datos.ExisteCategotia(idCategoria))
                {
                negocio.eliminar(idCategoria);
                MessageBox.Show("Categoria eliminada exitosamente.");
                }
                else
                {
                    MessageBox.Show("La categoria que intenta eliminar no existe.");
                }
                cargarCategoria();
                TxtEliminarCategoria.Clear();
=======

                if (ValidarCodigoCategoria(idCategoria))
                {
                    CategoriaNegocio negocio = new CategoriaNegocio();
                    negocio.eliminar(idCategoria);


                    MessageBox.Show("Categoria eliminada exitosamente.");
                    cargarCategoria();

                    TxtEliminarCategoria.Clear();
                }
                else
                {
                    MessageBox.Show("No existe el ID en la base de datos, ingrese otro.");
                    
                }
>>>>>>> 70430e4818f2d326b59c52caf098050cb94fd7df
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message + "\n" + ex.StackTrace);
            }
        }
    }
}
