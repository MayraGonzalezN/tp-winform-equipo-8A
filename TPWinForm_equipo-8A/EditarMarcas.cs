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
    public partial class EditarMarcas : Form
    {
        public EditarMarcas()
        {
            InitializeComponent();
        }

        private void cargarMarcas()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            List<Marca> lista = negocio.listar();
            dgvMarcas.DataSource = lista; 
        }

        private void frmGestionMarcas_Load(object sender, EventArgs e)
        {
            cargarMarcas(); 
        }


        private void btnAceptarMarca_Click(object sender, EventArgs e)
        {
            try
            {

                Marca nuevaMarca = new Marca();
                nuevaMarca.NombreM = txtboxMarca.Text;


                MarcaNegocio negocio = new MarcaNegocio();
                negocio.agregar(nuevaMarca);

              
                MessageBox.Show("Marca agregada exitosamente.");

                cargarMarcas();

               
                txtboxMarca.Clear();

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar la marca: " + ex.Message);
            }

        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                int idMarca = Convert.ToInt32(txtboxEliminarMarca.Text); 

                MarcaNegocio negocio = new MarcaNegocio();
                negocio.eliminar(idMarca);

              
                MessageBox.Show("Marca eliminada exitosamente.");
                cargarMarcas();

                txtboxEliminarMarca.Clear();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar la marca: " + ex.Message);
            }
        }
    }
}
