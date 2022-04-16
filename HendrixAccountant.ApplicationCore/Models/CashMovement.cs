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

    public class CashFlowToday
    {
        public string TotalIngresos { get; set; }
        public string TotalEgresos { get; set; }
        public string TotalGastos { get; set; }
        public string BaseApertura { get; set; }
        public string Saldo { get; set; }
        public string FechaApertura { get; set; }
    }
}
