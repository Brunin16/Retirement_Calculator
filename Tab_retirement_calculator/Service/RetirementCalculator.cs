using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tab_retirement_calculator.Service
{
    public class RetirementCalculator
    {
        public string responseYear(int year, int workedYears, string gender, double avarageSalary)
        {
            int minYear = gender == "H" ? 65 : 62;
            int remainingTime = calculateTime(year, workedYears, gender, minYear);
            if (remainingTime == -1)
            {
                return "Verifique as informações oferecidas\nO tempo trabalhado ou idade esta abaixo de 0";
            }
            if (remainingTime == -2)
            {
                return $"A idade minima para a aposentadoria é de {minYear} anos";
            }
            double value = calculateValue(avarageSalary, workedYears, minYear);
            if (remainingTime == 0)
            {
                return $"Parabéns, você já pode se aposentar\nE receberá {value}";
            }
            return "Faltam " + remainingTime + " anos para a sua aposentadoria\nE voce reberá em media R$" + value;
        }
        public int calculateTime(int year, int workedYears, string gender, int minYear) 
        {     
            int minWorkedYears = gender == "H" ? 20 : 15;
            if (year < 0 || workedYears < 0)
            {
                return -1;
            }
            if (year < minYear)
            {
                return -2;
            }
            return (minWorkedYears - workedYears) < 0 ? 0 : minWorkedYears - workedYears; 
        }
        public double calculateValue(double avarageSalary, int workedYears, int minYear)
        {
            double maxValue = 7786.02;

            double percentage = 60 + Math.Max(0, (workedYears - minYear)) * 2;

            percentage = Math.Min(percentage, 100);

            double approximateValue = (avarageSalary * percentage) / 100;

            return Math.Min(approximateValue, maxValue);

        }
        public RetirementCalculator() { }
    }
}
