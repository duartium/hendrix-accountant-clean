namespace HendrixAccountant.ApplicationCore.Entities
{
    public class Kardex
    {
        public string Date { get; set; }
        public string Movement { get; set; }
        public string Name { get; set; }
        public string Sequential { get; set; }
        public int Quantity { get; set; }
        public decimal UnitValue { get; set; }
        public decimal TotalItem { get; set; }
    }
}
