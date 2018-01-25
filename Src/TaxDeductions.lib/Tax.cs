namespace TaxDeductions.lib
{
    public class Tax
    {
        public decimal ChargeableIncome { get; set; }
        public decimal CumulativeChargeableIncome { get; set; }
        public decimal Rate { get; set; }
    }
}
