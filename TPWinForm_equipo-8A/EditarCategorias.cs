using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            dgvEditarCategorias.DataSource = lista;
        }

        private void EditarCategorias_Load(object sender, EventArgs e)
        {
            cargarCategoria();
        }

        private void BtnAgregarCategoria_Click(object sender, EventArgs e)
        {

             try
             {

                 Categoria nuevaCategoria = new Categoria();
                 nuevaCategoria.Nombre = TxtNuevaCategoria.Text;


                 CategoriaNegocio negocio = new CategoriaNegocio();
                 negocio.agregar(nuevaCategoria);


                 MessageBox.Show("Categoria agregada exitosamente.");

                 cargarCategoria();


                 TxtNuevaCategoria.Clear();


             }
             catch (Exception ex)
             {
                 MessageBox.Show("Ocurrió un error al agregar la categoria: " + ex.Message);
             }
           

        }

        private void BtnEliminarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                int idCategoria = Convert.ToInt32(TxtEliminarCategoria.Text);

                CategoriaNegocio negocio = new CategoriaNegocio();
                negocio.eliminar(idCategoria);


                MessageBox.Show("Categoria eliminada exitosamente.");
                cargarCategoria();

                TxtEliminarCategoria.Clear();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message + "\n" + ex.StackTrace);
            }
        }

     
    }
   






}
