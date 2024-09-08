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
    public partial class formAlta : Form
    {
        public formAlta()
        {
            InitializeComponent();
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
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
                Articulo aux = new Articulo();
                GestionArticulos art = new GestionArticulos();

            try
            {
                aux.Codigo = txtCodigo.Text;
                aux.Nombre = txtNombre.Text;
                aux.Descripcion = txtDescripcion.Text;
                //aux.marca = 
                //aux.categoria=
               // aunx.Imagen = txtimagen.Text; lo cargamos como string???
               aux.Precio = int.Parse (txtPrecio.Text);

                art.agregar(aux);
                MessageBox.Show("Agregado exitosamente");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
