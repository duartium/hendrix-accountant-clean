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

    public class ProductDto : ISaleElement
    {
        public int IdProducto { get; set; }
        public string CodigoBarras { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int IdTalla { get; set; }
        public int IdProveedor { get; set; }
        public int IdCategoria { get; set; }
        public decimal Descuento { get; set; }
        public string Usuario { get; set; }
    }

    public class StockDto
    {
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
    }

    public class ProductPurchaseDto
    {
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public int StockActual { get; set; }
        public int StockNuevo { get; set; }
        public int Precio { get; set; }
    }
}
