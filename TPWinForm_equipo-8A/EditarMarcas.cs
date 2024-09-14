using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
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
            dgvMarcas.DataSource = null;
            dgvMarcas.DataSource = lista; 
        }


        private void EditarMarcas_Load(object sender, EventArgs e)
        {
            cargarMarcas();
        }

        //............................validar......................................

        private bool validarMarcaDescripcion(string marca)
        {
            AccesoDatos datosValidarMarca = new AccesoDatos();
           return datosValidarMarca.ExisteNombreMarca(marca);

        }

      
        private void btnAceptarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                Marca nuevaMarca = new Marca();
                nuevaMarca.NombreM = txtboxMarca.Text;

                if (!(validarMarcaDescripcion(nuevaMarca.NombreM)))
                {

                    MarcaNegocio negocio = new MarcaNegocio();
                    negocio.agregar(nuevaMarca);

                    MessageBox.Show("Marca agregada exitosamente.");

                    cargarMarcas();
                    txtboxMarca.Clear();

                }
                else
                {
                    MessageBox.Show("La marca ya existe en la base de datos,agregue otra distinta");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar la marca: " + ex.Message);
            }
        }

        private bool validarCodigoMarca(int codigo)
        {
            AccesoDatos datosValidarIdMarca = new AccesoDatos();
            return datosValidarIdMarca.ExisteIDmarca(codigo);
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                int idMarca = Convert.ToInt32(txtboxEliminarMarca.Text);


                if (validarCodigoMarca(idMarca))
                {

                    MarcaNegocio negocio = new MarcaNegocio();
                    negocio.eliminar(idMarca);

                    MessageBox.Show("Marca eliminada exitosamente.");
                    cargarMarcas();
                    txtboxEliminarMarca.Clear();
                }
                else
                {
                    MessageBox.Show("No existe el ID en la base de datos, ingrese otro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar la marca: " + ex.Message);
            }
        }
    }
}
