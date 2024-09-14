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
    public partial class EliminarArticulo : Form
    {
        public EliminarArticulo()
        {
            InitializeComponent();
        }

        //...........................................................................
       
     

        private void button1_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            GestionArticulos gestionArticulos = new GestionArticulos();
            AccesoDatos datosValidar = new AccesoDatos();
            bool existeCodigo = false;

            try
            {
                articulo.Codigo = txtEliminar.Text;
                existeCodigo= datosValidar.ExisteCodigoArticulo(articulo.Codigo);
                if (existeCodigo==true)
                {

                    DialogResult respuesta = MessageBox.Show("¿Desea eliminar el articulo?", "Eliminar", MessageBoxButtons.YesNo);
                    if (respuesta == DialogResult.Yes)
                    {
                        gestionArticulos.Eliminar(articulo);
                        MessageBox.Show("ARTICULO ELIMINADO");
                        Close();
                    }

                }
                else
                {
                    MessageBox.Show("EL CODIGO DE ARTICULO ES INEXISTENTE");
                }
                
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtEliminar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
