using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo-8A
{
    public partial class ListadoArticulos : Form
    {
        //private List<Articulo> listaArticulos;
        public ListadoArticulos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListadoArticulos_Load(object sender, EventArgs e)
        {
            GestionArticulos articulos = new GestionArticulos();

            dgvArt.DataSource = articulos.Listar();
            //pictureboxImg.Load(listaArticulos[0].Imagen);
        }
    }
}
