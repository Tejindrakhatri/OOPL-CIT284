using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disturbo_tax
{
    public class Calculate
    {
       
        const int DECDUCTION = 1000;
        public static decimal CalculateAdjustGross(decimal grossEarning,decimal numExcemption,decimal realEstate,
            decimal exciseTax,decimal medicalExpense, decimal capital)
        {
            double dGrossEarning = Convert.ToDouble(grossEarning) - (DECDUCTION * Convert.ToInt32(numExcemption));
            double dRealEstate = Convert.ToDouble(realEstate) *0.25;
            double dExciseTax = Convert.ToDouble(exciseTax)*0.25;
            double dMedicalExpense = Convert.ToDouble(medicalExpense)*0.08;
            double dCapital = Convert.ToDouble(capital)*0.15;

            double dResult = dGrossEarning - dRealEstate - dExciseTax - dMedicalExpense + dCapital;
           
            decimal result = Convert.ToDecimal(dResult);
           
            return Math.Round(result,0);
        }

        public static double calculateAmountOfTax(double adjustedGross)
        {
            if (adjustedGross >= 0 && adjustedGross <= 999.999)
                return adjustedGross * 0.1;
            else if (adjustedGross >= 1000 && adjustedGross <= 9999.99)
                return adjustedGross * 0.15;
            else if (adjustedGross >= 10000.00 && adjustedGross <= 19999.99)
                return adjustedGross * 0.2;
            else if (adjustedGross <= 20000 && adjustedGross <= 29999.99)
                return adjustedGross * 0.25;
            else if (adjustedGross >= 30000)
                return adjustedGross * 0.28;
            else
                return 0;
        }

        public static double calculatedPenalty(double amountOfTax,double taxFromW2)
        {
            double penalty = 0;
            if (taxFromW2 < (amountOfTax * 0.9))
                penalty = (amountOfTax - taxFromW2);
            return penalty * 0.1;
        }
    }
}
