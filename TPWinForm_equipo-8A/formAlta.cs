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
        private Articulo articulo = null;
        public formAlta()
        {
            InitializeComponent();
        }
        public formAlta(Articulo artModif)
        {
            InitializeComponent();
           
            articulo = artModif;

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
                articulo = new Articulo();
                GestionArticulos gestionArticulo = new GestionArticulos();

            try
            {
                if(articulo == null)

                articulo = new Articulo();
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.marca = (Marca)cboMarca.SelectedItem;
                articulo.categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Precio = (float)decimal.Parse(txtPrecio.Text);
                articulo.Imagen = txtImagenUrl.Text;

                if(articulo.Id != 0)
                {
                 gestionArticulo.modificar(articulo);
                 MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                gestionArticulo.agregar(articulo);
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
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descrpcion";

                if (articulo != null)
                {
                    txtCodigo.Text=articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                   // txtMarca.Text = articulo.marca;
                   // txtCategoria.Text = articulo.Categoria;
                    txtImagenUrl.Text = articulo.Imagen;
                    cargarImagen(articulo.Imagen);
                    txtPrecio.Text = articulo.Precio.ToString();
                    cboMarca.SelectedValue = articulo.marca.idM;
                    cboCategoria.SelectedValue = articulo.categoria.Id;
                }
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
