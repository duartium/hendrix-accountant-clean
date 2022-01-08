namespace HendrixAccountant.ApplicationCore.Models
{
    public class CashMovement
    {
        public int IdMovimiento { get; set; }
        public string FechaHoraApertura { get; set; }
        public int TipoMovimiento { get; set; }
        public decimal Ingresos { get; set; }
        public decimal Egresos { get; set; }
        public decimal Saldo { get; set; }
        public decimal IdUsuario { get; set; }
        public decimal IdCaja { get; set; }
    }
}
