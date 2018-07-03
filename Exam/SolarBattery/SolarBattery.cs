using System;


//	Разработайте класс «Солнечная батарея» (географическая широта и долгота размещения, вырабатываемая мощность) с методом вычисления выработки
//энергии за месяц(можно передавать ему на вход среднюю продолжительность светового дня).
//	При помощи LINQ посчитайте количество солнечный батарей с мощностью более 1КВт, установленных в северном полушарии(широта >0).

namespace Exam
{
    public class SolarBattery
    {
        public double geoWedth { get; }
        public double geoLength { get; }
        public double power { get; }
        public double AverageDaylightHours { get; }
        DateTime dt = new DateTime();

        public SolarBattery(double geoWedth, double geoLength, double power, double AverageDaylightHours)
        {
            this.power = power;
            this.geoLength = geoLength;
            this.geoWedth = geoWedth;
            this.AverageDaylightHours = AverageDaylightHours;
        }

        public void GetEnergyInMounth(double AverageDaylightHours)
        {
            var str = (AverageDaylightHours * power) * DateTime.DaysInMonth(dt.Year , dt.Month);
        }
    }
}
