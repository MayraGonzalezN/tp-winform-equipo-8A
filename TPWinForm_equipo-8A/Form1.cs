using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aLTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAlta ventaAlta = new formAlta();
            ventaAlta.ShowDialog();
        }

        private void mODIFICARToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        }
    }
}
