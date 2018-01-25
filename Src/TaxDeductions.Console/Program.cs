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
           var taxVariations=new TaxTable().Taxes;
            _cumulativetax = TaxTable.GetTaxPayable(amount, taxVariations);
            System.Console.WriteLine($"Cumulative Tax: {Math.Round(_cumulativetax,2)}");  
            
            System.Console.ReadLine();
        }
    }
}
