using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_equipo_8A
{
    internal class Marca
    {
        public int idM { get; set; }
        public string NombreM { get; set; }
        public Marca() { }
        public Marca(int id, string nombre)
        {
            idM = id;
            NombreM = nombre;
        }
        public override string ToString()
        {
            return NombreM;
        }
    }
}
