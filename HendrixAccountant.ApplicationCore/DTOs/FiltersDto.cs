namespace HendrixAccountant.ApplicationCore.DTOs
{
    public class SalesFilterDto
    {
        public int Secuencial { get; set; }
        public int IdCliente { get; set; }
        public string FechaDesde { get; set; }
        public string FechaHasta { get; set; }
        public int IdUsuario { get; set; }
        public int Estado { get; set; }
    }

    public class ClientFilterDto
    {
        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
    }

    public class ProductFilterDto
    {
        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public string NombreProducto { get; set; }
        public int EsServicio { get; set; }
    }

    public class SupplierFilterDto
    {
        public int IdProveedor { get; set; }
        public string NombreProveedor { get; set; }
    }

    public class KardexFilterDto
    {
        public int IdProducto { get; set; }
        public string FechaDesde { get; set; }
        public string FechaHasta { get; set; }
        public int TipoMovimiento { get; set; }
    }

}
