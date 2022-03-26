using System;

namespace HendrixAccountant.ApplicationCore.DTOs
{
    public class ExpenseDto
    {
        public int IdTipoGasto { get; set; }
        public decimal Valor { get; set; }
        public string Detalle { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
    }
}
