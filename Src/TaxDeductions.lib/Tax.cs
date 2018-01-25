using System.Collections.Generic;

namespace TaxDeductions.lib
{
    public class Tax
    {
        public decimal ChargeableIncome { get; set; }
        public decimal CumulativeChargeableIncome { get; set; }
        public decimal Rate { get; set; }
    }

    public class TaxTable
    {
        public List<Tax> Taxes { get; set; }

        public static decimal MaxNormal => 3240;

        //todo tax payable function
        //public static decimal GetTaxPayable()
        //{
        //    if (amount<=TaxTable.MaxNormal)
        //    {
        //        foreach (var tax in TaxTable.GetTaxTable())
        //        {
        //            if ( amount >= tax.CumulativeChargeableIncome)
        //            {
        //                _cumulativetax=_cumulativetax+(tax.ChargeableIncome*tax.Rate);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        _cumulativetax = 0.25M * amount;
        //    }
        //}

        public static List<Tax> GetTaxTable()
        {
            return new List<Tax>
            {
                new Tax{CumulativeChargeableIncome  = 216,ChargeableIncome = 216,Rate = 0.00M},
                new Tax{CumulativeChargeableIncome = 324,ChargeableIncome = 108,Rate = 0.05M},
                new Tax{CumulativeChargeableIncome = 475,ChargeableIncome = 151,Rate = 0.10M},
                new Tax{CumulativeChargeableIncome = 3240,ChargeableIncome = 2765,Rate =0.175M},
                //new Tax{CumulativeChargeableIncome = 3241,ChargeableIncome = 108,Rate = 0.25M},
            };
        }
    }

}
