using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tab_retirement_calculator.Service
{
    public class RetirementCalculator
    {
        public string responseYear(int year, int workedYears, string gender, double averageSalary)
        {
            int minYear = gender == "H" ? 65 : 62;
            int minWorkedYearsBefore = gender == "H" ? 35 : 30;
            int remainingTime = calculateTime(year, workedYears, gender, minYear, minWorkedYearsBefore);
            if (remainingTime == -1)
            {
                return "Verifique as informações oferecidas\nO tempo trabalhado ou idade esta abaixo de 0";
            }
            if (remainingTime == -2)
            {
                return $"A idade minima para a aposentadoria é de {minYear} anos\nOu no minimo {minWorkedYearsBefore} anos de contribuição ";
            }
            double value = calculateValue(averageSalary, workedYears, minYear);
            if (remainingTime == 0)
            {
                return $"Parabéns, você já pode se aposentar\n{(averageSalary != 0 ? $"E receberá R${value}" : "")}";
            }
            if (remainingTime == -3)
            {
                return "Parabéns, você já pode se aposentar\nE receberá R$"+ value;
            }
            return "Faltam " + remainingTime + " anos para a sua aposentadoria";
        }
        public int calculateTime(int year, int workedYears, string gender, int minYear, int minWorkedYearsBefore) 
        {     
            int minWorkedYears = gender == "H" ? 20 : 15;

            if (year < 0 || workedYears < 0)
            {
                return -1;
            }
            if (workedYears >= minWorkedYearsBefore)
            {
                return -3;
            }
            if (year < minYear)
            {
                return -2;
            }


            return (minWorkedYears - workedYears) < 0 ? 0 : minWorkedYears - workedYears; 
        }
        public double calculateValue(double averageSalary, int workedYears, int minYear)
        {
            double maxValue = 7786.02;

            double percentage = 60 + Math.Max(0, (workedYears - minYear)) * 2;

            percentage = Math.Min(percentage, 100);

            double approximateValue = (averageSalary * percentage) / 100;

            return Math.Min(approximateValue, maxValue);

        }
        public RetirementCalculator() { }
    }
}
