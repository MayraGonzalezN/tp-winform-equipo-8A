using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_8A
{
    public partial class DetallesXArticulo : Form
    {
        private Articulo articulo;
        public DetallesXArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            flpImagenes(articulo.Id);
            txtNombre.Text = articulo.Nombre;
            txtCodigo.Text = articulo.Codigo;
            txtCategoria.Text = articulo.Nombre;
            txtDescripcion.Text = articulo.Descripcion;
            txtMarca.Text = articulo.marca.ToString();
            txtCategoria.Text = articulo.categoria.ToString();
            txtPrecio.Text = articulo.Precio.ToString();
        }
        private void detallesXArticulo_Load(object sender, EventArgs e)
        {

        }

        private void lbNombre_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void flpImagenes(int articuloId)
        {
            flpImagenesDetalles.Controls.Clear();
            Articulo articulo = new Articulo();
            articulo.Id = articuloId;
            List<string> imagenesUrl = articulo.ImagenesXArticulo();

            foreach (string imagen in imagenesUrl)
            {
                PictureBox pbxImagenUrl = new PictureBox();
                pbxImagenUrl.Width = 320;
                pbxImagenUrl.Height = 320;
                pbxImagenUrl.Margin = new Padding (30);
                pbxImagenUrl.SizeMode = PictureBoxSizeMode.Zoom;
                {
                    try
                    {
                        pbxImagenUrl.ImageLocation = imagen;
                    }
                    catch (Exception ex)
                    {
                        pbxImagenUrl.Load("https://media.istockphoto.com/id/1128826884/es/vector/ning%C3%BAn-s%C3%ADmbolo-de-vector-de-imagen-falta-icono-disponible-no-hay-galer%C3%ADa-para-este-momento.jpg?s=612x612&w=0&k=20&c=9vnjI4XI3XQC0VHfuDePO7vNJE7WDM8uzQmZJ1SnQgk=");
                    }
                }
                flpImagenesDetalles.Controls.Add(pbxImagenUrl);
            }
        }
    }
}
