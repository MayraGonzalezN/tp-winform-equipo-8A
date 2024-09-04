using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF1
{
    internal class Articulo
    {
        private char codigoArticulo;
        private string nombre;
        private string descripcion;
        private float precio;
        private string imagen;// para cargar la url
        private Marca marca;
        private Categoria categoria;

        public void setcodigoArticulo(char art)
        {
            codigoArticulo = art;
        }
        public char getcodigoArticulo()
        {
            return codigoArticulo;
        }
        public void setnombre(string nom)
        {
            nombre = nom;
        }
        public string getnombre()
        {
            return nombre;
        }
        public void setdescripcion(string desc)
        {
            descripcion = desc;
        }
        public string getdescripcion()
        {
            return descripcion;
        }
        public void setprecio(float prec)
        {
            precio = prec;
        }
        public float getprecio()
        {
            return precio;
        }
        public void setimagen(string imag)
        {
            imagen = imag;
        }
        public string getimagen()
        {
            return imagen;
        }

    }
}
