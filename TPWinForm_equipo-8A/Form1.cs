using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WinTPWinForm_equipo_8A;
using System.IO;
using System.Net;
using System.Xml;
using System.Drawing.Printing;

namespace TPWinForm_equipo_8A
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            articulosPrincipal();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aRTICULOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListadoArticulos listadoArticulos = new ListadoArticulos();
            listadoArticulos.ShowDialog();
        }

        private void BajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarArticulo eliminar = new EliminarArticulo();
            eliminar.ShowDialog();
        }

        private void ListarXMARCAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarxMarca ListarxMarca = new ListarxMarca();
            ListarxMarca.ShowDialog();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void articulosPrincipal()
        {
            GestionArticulos gestionArticulos = new GestionArticulos();
            List<Articulo> articulos = gestionArticulos.Listar();

            foreach (Articulo articulo in articulos)
            {
                Panel panelArticulo = new Panel();
                panelArticulo.Width = 300;
                panelArticulo.Height = 350;//aca agrego el tamaño que quiero que tenga mi panel x cada articulo
                panelArticulo.Margin = new Padding(10);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = panelArticulo.Width - 20;
                pictureBox.Height = panelArticulo.Height - 40; //en vez de ponerle un with y que quede mal la img, le pongo un - teniendo en cuenta el tam del panel
                pictureBox.ImageLocation = articulo.Imagen.ToString();
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                try
                {
                    pictureBox.Load(articulo.Imagen.ToString());
                }
                catch
                {
                    pictureBox.Load("https://media.istockphoto.com/id/1128826884/es/vector/ning%C3%BAn-s%C3%ADmbolo-de-vector-de-imagen-falta-icono-disponible-no-hay-galer%C3%ADa-para-este-momento.jpg?s=612x612&w=0&k=20&c=9vnjI4XI3XQC0VHfuDePO7vNJE7WDM8uzQmZJ1SnQgk=");
                }

                Label labelNombreArticulo = new Label();
                labelNombreArticulo.Text = articulo.Nombre;
                labelNombreArticulo.AutoSize = false;
                labelNombreArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                labelNombreArticulo.Dock = DockStyle.Bottom;

                System.Windows.Forms.Button btnDetalles = new System.Windows.Forms.Button();
                btnDetalles.Text = "Dettales";
                btnDetalles.Width = panelArticulo.Width - 100;
                btnDetalles.Height = 20;
                btnDetalles.Dock = DockStyle.Bottom;
                btnDetalles.Cursor = Cursors.Hand;

                btnDetalles.Tag = articulo;
                btnDetalles.Click += btnDetalles_Click;

                panelArticulo.Controls.Add(pictureBox);
                panelArticulo.Controls.Add(labelNombreArticulo);
                panelArticulo.Controls.Add(btnDetalles);
                flpImagenXArt.Controls.Add(panelArticulo);
            }
        }
        private void btnDetalles_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            if (btn != null && btn.Tag is Articulo articulo)
            {
                DetallesXArticulo detallesXArticulo = new DetallesXArticulo(articulo);
                detallesXArticulo.ShowDialog();
            }
        }

        private void mARCASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
             
                EditarMarcas formularioEditarMarca = new EditarMarcas();

           
                formularioEditarMarca.ShowDialog();
            
        }

        private void toolstripCategorias_Click(object sender, EventArgs e)
        {

            EditarCategorias formularioEditarCategoria = new EditarCategorias();


            formularioEditarCategoria.ShowDialog();
        }
    }
}
