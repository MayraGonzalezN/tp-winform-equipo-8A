﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{
    partial class Articulo
    {

        private Marca marca;
        private Categoria categoria;

        public string CodigoArticulo { get; set; }
        public string Nombre { get; set; }  
        public string Descripcion { get; set; }
        public string Imagen { get; set; }  
        public float Precio { get; set; }
        
    }
}
