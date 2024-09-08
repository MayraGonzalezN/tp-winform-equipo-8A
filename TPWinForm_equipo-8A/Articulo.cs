using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{
    partial class Articulo
    {

       // private Marca idmarca;
       // private

       // Categoria categoria;
        public Categoria categoria { get; set; } 
        public Marca marca { get; set; }



        public string Codigo { get; set; }
        public string Nombre { get; set; }  
        public string Descripcion { get; set; }
        public string Imagen { get; set; }  
        public float Precio { get; set; }
    }
}
