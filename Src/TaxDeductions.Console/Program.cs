using System;
using System.Linq;
using TaxDeductions.lib;

namespace TaxDeductions.Console
{
    class Program
    {
        private static decimal _cumulativetax=0.0M;

        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter Amount to Calculate Tax");
            var amount = Convert.ToDecimal(System.Console.ReadLine());

            if (amount<=TaxTable.MaxNormal)
            {
                foreach (var tax in TaxTable.GetTaxTable())
                {
                    if ( amount >= tax.CumulativeChargeableIncome)
                    {
                        _cumulativetax=_cumulativetax+(tax.ChargeableIncome*tax.Rate);
                    }
                }
            }
            else
            {
                _cumulativetax = 0.25M * amount;
            }
            System.Console.WriteLine($"Cumulative Tax: {Math.Round(_cumulativetax,2)}");  


            System.Console.ReadLine();
        }
    }
}
