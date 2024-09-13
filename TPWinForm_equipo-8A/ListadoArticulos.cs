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
        private Articulo articuloModificar=null;    
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
            dgvArt.Columns["Id"].Visible = false;  
            cargarImagen(listaArticulos[0].Imagen);
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
                //MessageBox.Show($"error:{ex.Message}");
                pbxImagen.Load("https://media.istockphoto.com/id/1128826884/es/vector/ning%C3%BAn-s%C3%ADmbolo-de-vector-de-imagen-falta-icono-disponible-no-hay-galer%C3%ADa-para-este-momento.jpg?s=612x612&w=0&k=20&c=9vnjI4XI3XQC0VHfuDePO7vNJE7WDM8uzQmZJ1SnQgk=");
            }
        }
        private void btnAgregar2_Click(object sender, EventArgs e)//btnAgregar2 no se porque el nombre del boton esta por defecto
        {
            formAlta ventaAlta = new formAlta();
            ventaAlta.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArt.CurrentRow.DataBoundItem;

            formAlta modificar = new formAlta(seleccionado);//instancia de la clase ventanaAlta
            modificar.ShowDialog();
        }
        public void actualizarLista()
        {
            GestionArticulos gestionArticulos = new GestionArticulos();
            listaArticulos = gestionArticulos.Listar();
            dgvArt.DataSource = null;
            dgvArt.DataSource = listaArticulos;
            dgvArt.Columns["Imagen"].Visible = false;
            dgvArt.Columns["Id"].Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarArticulo eliminar = new EliminarArticulo();
            eliminar.ShowDialog();
        }
    }
}
