namespace HendrixAccountant.ApplicationCore.Models
{
    public class ProductWithdrawal
    {
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public int IdMotivo { get; set; }
        public string OtroMotivo { get; set; }
    }
}
