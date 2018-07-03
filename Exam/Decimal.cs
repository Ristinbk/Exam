using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Продемонстрируйте выбрасывание исключения при установке некорректных значений в классе “Дробь” (хранит числитель и знаменатель).

namespace Exam
{
    public class Decimal
    {
        private double numerator;
        public double Numerator { get { return numerator; } }       
        public double Denominator { get; }

        public Decimal(double numerator, double denominator)
        {
            this.numerator = numerator;
            Denominator = denominator;
        }

        public void AddValues()
        {
            double x;
            string input = Console.ReadLine();
            if (double.TryParse(input, out x))
            {
                numerator = double.Parse(input);
            }

        }

    }
}
