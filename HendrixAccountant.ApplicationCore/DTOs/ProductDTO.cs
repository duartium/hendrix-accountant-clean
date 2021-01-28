using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.DTOs
{
    public class ProductDTO
    {
        public string Descripcion { get; set; }
        public string Codigo { get; set; }
    }

    public class ProductIdentityDto : ISaleElement
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public int Stock { get; set; }
        public decimal Total { get; set; }
    }

    public class StockDto
    {
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
    }
}
