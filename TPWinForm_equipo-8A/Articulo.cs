﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_equipo_8A
{
    public partial class Articulo
    {

        public int Id { get; set; }

        [DisplayName("Código")]
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public string Imagen { get; set; }  
        public float Precio { get; set; }
        [DisplayName("Categoría")]
        public Categoria categoria { get; set; }
        [DisplayName("Marca")]
        public Marca marca { get; set; }
    }
}
