using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinTPWinForm_equipo_8A;

namespace TPWinForm_equipo_8A
{
    public partial class formAlta : Form
    {
<<<<<<< HEAD

       private Articulo articuloMdfc = null;

=======
        private Articulo articulo = null;
>>>>>>> d6289c2040079f5f1c10e05aa5bfeeda67cb6020
        public formAlta()
        {
            InitializeComponent();
        }
        public formAlta(Articulo artModif)
        {
            InitializeComponent();
           
            articuloMdfc = artModif;

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======
                articulo = new Articulo();
>>>>>>> d6289c2040079f5f1c10e05aa5bfeeda67cb6020
                GestionArticulos gestionArticulo = new GestionArticulos();

            try
            {


                if(articuloMdfc==null)

                articuloMdfc = new Articulo();


                articuloMdfc.Codigo = txtCodigo.Text;
                articuloMdfc.Nombre = txtNombre.Text;
                articuloMdfc.Descripcion = txtDescripcion.Text;
                articuloMdfc.marca = (Marca)cboMarca.SelectedItem;
                articuloMdfc.categoria = (Categoria)cboCategoria.SelectedItem;
                articuloMdfc.Precio = (float)decimal.Parse(txtPrecio.Text);
                articuloMdfc.Imagen = txtImagenUrl.Text;


                if(articuloMdfc.Id != 0)
                {
                 gestionArticulo.modificar(articuloMdfc);
                 MessageBox.Show("Modificado exitosamente");

                }
                else
                {
                gestionArticulo.agregar(articuloMdfc);
                MessageBox.Show("Agregado exitosamente");

                }
             

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void formAlta_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            
            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "IdM";
                cboMarca.DisplayMember = "Descrpcion";
                cboCategoria.DataSource = categoriaNegocio.listar();
<<<<<<< HEAD
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descrpcion";


                //cboCategoria.DisplayMember = "Nombre";
                if (articuloMdfc != null)
                {
                    txtCodigo.Text=articuloMdfc.Codigo;
                    txtNombre.Text = articuloMdfc.Nombre;
                    txtDescripcion.Text = articuloMdfc.Descripcion;
                   // txtMarca.Text = articuloMdfc.marca;
                   // txtCategoria.Text = articuloMdfc.Categoria;
                    txtImagenUrl.Text = articuloMdfc.Imagen;
                    cargarImagen(articuloMdfc.Imagen);
                    txtPrecio.Text = articuloMdfc.Precio.ToString();
                    cboMarca.SelectedValue = articuloMdfc.marca.idM;
                    cboCategoria.SelectedValue = articuloMdfc.categoria.Id;
                }


=======
>>>>>>> d6289c2040079f5f1c10e05aa5bfeeda67cb6020
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtImagenUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagenUrl.Text);
        }
        public void cargarImagen(string imagen)
        {
            try
            {
                pbxImagenUrl.Load(imagen);
            }
            catch (Exception ex)
            {
               // MessageBox.Show($"error:{ex.Message}");
                pbxImagenUrl.Load("https://media.istockphoto.com/id/1128826884/es/vector/ning%C3%BAn-s%C3%ADmbolo-de-vector-de-imagen-falta-icono-disponible-no-hay-galer%C3%ADa-para-este-momento.jpg?s=612x612&w=0&k=20&c=9vnjI4XI3XQC0VHfuDePO7vNJE7WDM8uzQmZJ1SnQgk=");
            }
        }
    }
}
