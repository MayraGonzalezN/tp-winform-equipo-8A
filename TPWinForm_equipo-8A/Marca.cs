using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_equipo-8A
{
    internal class Marca
    {
        private int idMarca;
        private string nombreMarca;


        public void setidMarca(int mar)
        {
            idMarca = mar;
        }
        public int getidMarca()
        {
            return idMarca;
        }
        public void setnombreMarca(string nombreMar)
        {
            nombreMarca = nombreMar;
        }
        public string getnombreMarca()
        {
            return nombreMarca;//
        }


    }
}
