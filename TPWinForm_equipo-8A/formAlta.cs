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
        public formAlta(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo"; 
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

        //  validaciones aca ....................................................................................
        private bool validarCajasTexto()
        {
            string mensajeError = "";

            if (!esAlfanumerico(txtCodigo.Text))
            {
                mensajeError += "El campo Código debe contener letras y números.\n";
            }



            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                mensajeError += "El campo Codigo no puede estar vacío.\n";
            }


            if (!esAlfanumerico(txtNombre.Text))
            {
                mensajeError += "El campo Nombre debe contener letras y/o numeros.\n";
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                mensajeError += "El campo Nombre no puede estar vacío.\n";
            }

            if (!esAlfanumerico(txtDescripcion.Text))
            {
                mensajeError += "El campo Descripción debe contener letras y/o numeros.\n";
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                mensajeError += "El campo Descripción no puede estar vacío.\n";
            }


            if (!decimal.TryParse(txtPrecio.Text, out _))
            {
                mensajeError += "El campo Precio debe contener números.\n";
            }

            if (mensajeError != "")
            {
                MessageBox.Show(mensajeError);
                return true;
            }

            return false; 
        }

     
        private bool esAlfanumerico(string texto)
        {
            foreach (char caracter in texto)
            {
                if (!char.IsLetterOrDigit(caracter) && !char.IsWhiteSpace(caracter))
                {
                    return false;
                }
            }
            return true;
        }

       
        private bool esSoloLetras(string texto)
        {
            foreach (char caracter in texto)
            {
                if (!char.IsLetter(caracter) && !char.IsWhiteSpace(caracter)) 
                {
                    return false;
                }
            }
            return true;
        }
   

        //.........................................................VALIDACIONES.............................................
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GestionArticulos gestionArticulo = new GestionArticulos();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                if (validarCajasTexto())
                    return;
                int idArticulo = 0;
                if(articulo != null)
                {
                    idArticulo = articulo.Id;
                }
                bool codigoExistente = datos.ExisteCodigoArticulo(txtCodigo.Text, idArticulo);

                if (!codigoExistente)
                {

                    if (articulo == null)
                        articulo = new Articulo();
                    articulo.Codigo = txtCodigo.Text;
                    articulo.Nombre = txtNombre.Text;
                    articulo.Descripcion = txtDescripcion.Text;
                    articulo.marca = (Marca)cboMarca.SelectedItem;
                    articulo.categoria = (Categoria)cboCategoria.SelectedItem;
                    articulo.Precio = (float)decimal.Parse(txtPrecio.Text);
                    articulo.Imagen = txtImagenUrl.Text;

                    if (articulo.Id != 0)
                    {
                        gestionArticulo.Modificar(articulo);
                        MessageBox.Show("Modificado exitosamente");
                    }
                    else
                    {
                        gestionArticulo.agregar(articulo);
                        MessageBox.Show("Agregado exitosamente");
                    }
                    ListadoArticulos listadoArticulos = new ListadoArticulos();
                    listadoArticulos.actualizarLista();

                    Close();

                }
                else
                {
                    MessageBox.Show("El codigo de articulo ya existe en la base de datos, ingrese otro codigo");
                }


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
                cboMarca.ValueMember = "idM";
                cboMarca.DisplayMember = "NombreM";
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Nombre";

                if (articulo != null)
                {
                    txtCodigo.Text=articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
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
