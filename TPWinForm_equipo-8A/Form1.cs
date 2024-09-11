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
            //CargarArticulos(); //En Proceso
        }

        private void aLTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAlta ventaAlta = new formAlta();/// me lo copie para cambiar de lugar btnAgregar
            ventaAlta.ShowDialog();
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
    }
}
