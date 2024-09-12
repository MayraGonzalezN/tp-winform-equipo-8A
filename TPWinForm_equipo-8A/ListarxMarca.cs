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
    public partial class ListarxMarca : Form
    {
        public ListarxMarca()
        {
            InitializeComponent();
        }

        private void btnListadoMarca_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMenorPrecio_Click(object sender, EventArgs e)
        {
            GestionArticulos gestionArticulos = new GestionArticulos();

            try
            {
                Articulo articulo = gestionArticulos.BuscarMenorPrecio();

                if (articulo != null)
                {
                    
                    if (dataGridView1.Columns.Count == 0)
                    {
                        dataGridView1.Columns.Add("Codigo", "Código");
                        dataGridView1.Columns.Add("Nombre", "Nombre");
                        dataGridView1.Columns.Add("Precio", "Precio");
                        dataGridView1.Columns.Add("Descripcion","Descripcion");

                    }

                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add(articulo.Codigo, articulo.Nombre, articulo.Precio, articulo.Descripcion);
                }
                else
                {
                    MessageBox.Show("No se encontró ningún artículo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }

        }
    }
}
