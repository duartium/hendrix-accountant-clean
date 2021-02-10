﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.DTOs
{
    public class CategoryDto : ISaleElement
    {
        public string Usuario { get; set; }
        public int IdCategoria { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
    }

    public class ComboBoxCategoriaDTO
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
