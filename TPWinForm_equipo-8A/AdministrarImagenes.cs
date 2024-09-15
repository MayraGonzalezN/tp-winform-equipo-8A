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
    public partial class AdministrarImagenes : Form
    {
        private int idArticulo;
        private List<string> listImagenes;
        public AdministrarImagenes(int idArticulo)
        {
            InitializeComponent();
            this.idArticulo = idArticulo;
        }

        private void AdministrarImagenes_Load(object sender, EventArgs e)
        {
            dgvImagenesId.Columns.Add("Id", "ID");
            dgvImagenesId.Columns.Add("ImagenUrl", "Imagen Url");
            cargarImagenes();
        }
        private void cargarImagenes()
        {
            dgvImagenesId.Rows.Clear();
            Articulo articulo = new Articulo();
            articulo.Id = idArticulo;
            listImagenes = articulo.ImagenesXArticulo();

            foreach (string imagenUrl in listImagenes)
            {
                dgvImagenesId.Rows.Add(idArticulo, imagenUrl);
            }
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
        private void dgvImagenesId_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvImagenesId.SelectedRows.Count > 0)
            {
                var selectedRow = dgvImagenesId.SelectedRows[0];
                if (selectedRow.Cells["ImagenUrl"].Value != null)
                {
                string imagenUrl = selectedRow.Cells["ImagenUrl"].Value.ToString();
                    if (!string.IsNullOrEmpty(imagenUrl))
                    {
                cargarImagen(imagenUrl);
                    }
                }
            }
        }
        private void dgvImagenesId_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
       
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nuevaUrl = txtUrl.Text.Trim();
            if (!string.IsNullOrEmpty(nuevaUrl))
            {
                GestionArticulos gestionArticulos = new GestionArticulos();
                gestionArticulos.agregarImagenUrl(idArticulo, nuevaUrl);
                cargarImagenes();
                txtUrl.Clear();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgvImagenesId.SelectedRows.Count > 0)
            {
                string imagenUrl = dgvImagenesId.SelectedRows[0].Cells["ImagenUrl"].Value.ToString();
                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar esta imagen?", "Eliminar", MessageBoxButtons.YesNo);
                if(respuesta == DialogResult.Yes)
                {
                    GestionArticulos gestionArticulos = new GestionArticulos();
                    gestionArticulos.EliminarImagenUrl(idArticulo, imagenUrl);
                    MessageBox.Show("Imagen eliminada correctamente.");
                    cargarImagenes();
                }
            }
        }
    }
}
