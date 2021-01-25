﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.DTOs
{
    public class ProductDetailBuyDto
    {
        public long Codigo { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; } = 0;
        public decimal PrecioCompra { get; set; } = 0;
        public decimal PrecioVenta { get; set; } = 0;
    }
}
