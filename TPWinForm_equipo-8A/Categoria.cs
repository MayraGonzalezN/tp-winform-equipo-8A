using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_equipo_8A
{
    internal class Categoria
    {

        /* private int idCategoria;
         private string nombreCategoria;


         public void setidCategoria(int cat)
         {
             idCategoria = cat;
         }
         public int getidCategoria()
         {
             return idCategoria;
         }
         public void setnombreCategoria(string nombreCat)
         {
             nombreCategoria = nombreCat;
         }
         public string getnombreCategoria()
         {
             return nombreCategoria;
         }*/
        public int id { get; set; }
        public string Nombre { get; set; }

        //public override string ToString() ///NO FUNCIONA >:( 
        //{
        //    return Nombre; 
        //}
    }
}
