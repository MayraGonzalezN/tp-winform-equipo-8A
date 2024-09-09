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
    public partial class ListadoArticulos : Form
    {
        private List<Articulo> listaArticulos;
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
            listaArticulos = articulos.Listar();
            dgvArt.DataSource = listaArticulos;
            dgvArt.Columns["Imagen"].Visible = false;
            //dgvArt.Columns["marca"].DataPropertyName = "Nombre";
            //dgvArt.Columns["categoria"].DataPropertyName = "categoria";
            //cargarImagen(listaArticulos[0].Imagen);
        }

        private void dgvArt_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArt.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagen);
        }

        public void cargarImagen(string imagen)
        {
            try
            {
                pbxImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxImagen.Load("https://media.istockphoto.com/id/1128826884/es/vector/ning%C3%BAn-s%C3%ADmbolo-de-vector-de-imagen-falta-icono-disponible-no-hay-galer%C3%ADa-para-este-momento.jpg?s=612x612&w=0&k=20&c=9vnjI4XI3XQC0VHfuDePO7vNJE7WDM8uzQmZJ1SnQgk=");
            }
        }

    }
}
