using System.Collections.Generic;

namespace TaxDeductions.lib
{
    public class TaxTable
    {
        public  List<Tax> Taxes => new List<Tax>
        {
            new Tax{CumulativeChargeableIncome  = 216,ChargeableIncome = 216,Rate = 0.00M},
            new Tax{CumulativeChargeableIncome = 324,ChargeableIncome = 108,Rate = 0.05M},
            new Tax{CumulativeChargeableIncome = 475,ChargeableIncome = 151,Rate = 0.10M},
            new Tax{CumulativeChargeableIncome = 3240,ChargeableIncome = 2765,Rate =0.175M},
        };

        public static decimal MaxNormal => 3240;

       
        public static decimal GetTaxPayable(decimal amount, List<Tax> taxes)
        {
            var cumulativetax = 0.0M;
            if (amount <= TaxTable.MaxNormal)
            {
                foreach (var tax in taxes)
                {
                    if (amount >= tax.CumulativeChargeableIncome)
                    {
                        cumulativetax = cumulativetax + (tax.ChargeableIncome * tax.Rate);
                    }
                }
            }
            else
            {
                cumulativetax = 0.25M * amount;
            }

            return cumulativetax;
        }

        //public static List<Tax> GetTaxTable()
        //{
        //    return new List<Tax>
        //    {
        //        new Tax{CumulativeChargeableIncome  = 216,ChargeableIncome = 216,Rate = 0.00M},
        //        new Tax{CumulativeChargeableIncome = 324,ChargeableIncome = 108,Rate = 0.05M},
        //        new Tax{CumulativeChargeableIncome = 475,ChargeableIncome = 151,Rate = 0.10M},
        //        new Tax{CumulativeChargeableIncome = 3240,ChargeableIncome = 2765,Rate =0.175M},
        //        //new Tax{CumulativeChargeableIncome = 3241,ChargeableIncome = 108,Rate = 0.25M},
        //    };
        //}
    }
}