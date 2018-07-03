using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
1.  Разработайте класс «Язык», позволяющий хранить название языка, его двухбуквенный код, и список стран, где он принять в качестве основного.
    Интерфейс класса должен обеспечивать доступ ко всем этим данным.
2.	При помощи LINQ посчитайте количество языков, которые являются официальными только в одной стране.
3.	При помощи LINQ сделайте выборку языков, принятых в качестве официального в Швейцарии.

4.  Опишите интерфейс записи текстовой строки в лог, реализуйте его в классе, выводящем сообщение на экран консоли.
5.	Разработайте класс «Устройство хранение информации», унаследуйте его в классе «Книга», с виртуальными методом, возвращающим объем информации
(количество страниц * среднее количество букв на странице).
6.	Разработайте универсальный метод, обменивающий 2 значения между собой.

7.	Разработайте класс «Солнечная батарея» (географическая широта и долгота размещения, вырабатываемая мощность) с методом вычисления выработки
энергии за месяц(можно передавать ему на вход среднюю продолжительность светового дня).
8.	При помощи LINQ посчитайте количество солнечный батарей с мощностью более 1КВт, установленных в северном полушарии(широта >0).

9.	Разработайте универсальный класс, который может хранить в себе пару значений(произвольного типа).
10.	Разработайте универсальный класс, который может хранить в себе тройку значений(произвольного типа). 
11.	Продемонстрируйте выбрасывание исключения при установке некорректных значений в классе “Дробь” (хранит числитель и знаменатель).
12.	Продемонстрируйте выбрасывание исключения при установке некорректных значений в классе “Окружность”.

13.	Разработайте класс «Игрок» (имя, страна, сумма очков, - все это свойства, защищенные от записи извне). 
    Добавьте в класс метод увеличения количества набранных очков (на сколько – передается параметром).
14.	При помощи LINQ посчитайте количество игроков из Германии, которые набрали от 100 до 500 очков.
15.	При помощи LINQ посчитайте количество игроков из России, которые набрали более 1000очков, упорядочив список по полю имени.
*/

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            // Язык
            List<Country> Countries = new List<Country>
            {
                new Country("Швейцария"),
                new Country("Англия"),
                new Country("Россия"),
                new Country("Германия")
            };

            List<ILanguage> Languages = new List<ILanguage>
            {
                new Language("Ретороманский", Countries[0]),
                new Language("Немецкий", Countries[0]),
                new Language("Итальянский", Countries[0]),
                new Language("Французский", Countries[0]),
                new Language("Японский"),
                new Language("Китайский"),
                new Language("Китайский"),
                new Language("Русский", Countries[2]),
                new Language("Английский", Countries[1])
            };

            // При помощи LINQ посчитайте количество языков, которые являются официальными только в одной стране. 
            var oficialInOneCountry = (from t in Languages
                                       where t.Countries.Count == 1
                                       select t).Count();

            var ofInOneCountry = Languages.Where(l => l.Countries.Count == 1).Count();

            //   При помощи LINQ сделайте выборку языков, принятых в качестве официального в Швейцарии.
            var offInSweth = from language in Languages
                             from country in language.Countries
                             where country.Name.Equals("Швейцария")
                             select language; 

            var offInSweth2 = Languages.SelectMany(l => l.Countries,   // не работает =(
                            (l, c) => new { Language = l, Country = c })
                          .Where(l => l.Country.Equals("Швейцария"))
                          .Select(l => l.Language);
            
            //   Опишите интерфейс записи текстовой строки в лог, реализуйте его в классе, выводящем сообщение на экран консоли.
            ILogFile lf = new LogFile(@"E:\Ucit\C#\Лабы\Exam\Log.txt");
            lf.WriteLine("123");
            lf.WriteLine("423");
            lf.ReadLine();


            // Игрок
            List<IPlayer> players = new List<IPlayer>
            {
                new Player("Fred", Countries[0]),
                new Player("Rain", Countries[0]),
                new Player("Ain", Countries[1]),
                new Player("Sven", Countries[1]),
                new Player("Иван", Countries[2]),
                new Player("Глеб", Countries[2]),
                new Player("Андрей", Countries[2]),
                new Player("Dimitryi", Countries[3]),
                new Player("Tommy", Countries[3]),
                new Player("Alex", Countries[3]),
            };

            players[0].AddPoints(100);
            players[1].AddPoints(500);
            players[2].AddPoints(6000);
            players[3].AddPoints(1000);
            players[4].AddPoints(1300);
            players[5].AddPoints(800);
            players[6].AddPoints(300);
            players[7].AddPoints(1000);
            players[8].AddPoints(200);
            players[9].AddPoints(300);
            players[9].AddPoints(100);

            // При помощи LINQ посчитайте количество игроков из Германии, которые набрали от 100 до 500 очков.
            var CountPlayersHermany = from t in players
                                      where t.Country.Name.Equals("Германия")
                                      where t.SumPoints > 100
                                      where t.SumPoints < 500
                                      select t;

            var CountPlayersHermany2 = players.Where(l => l.Country.Name.Equals("Германия") && l.SumPoints > 100 && l.SumPoints < 500);


            // При помощи LINQ посчитайте количество игроков из России, которые набрали более 1000очков, упорядочив список по полю имени.
            var CountPlayersRusssia = (from p in players
                                       where p.Country.Name.Equals("Россия")
                                       where p.SumPoints > 1000
                                       select p).OrderBy(p => p.Name);

            var CountPlayersRusssia2 = players.Where(l => l.Country.Name.Equals("Россия") && l.SumPoints > 1000).OrderBy(p => p.Name);

            //«Солнечная батарея»
            List<SolarBattery> solarBatteries = new List<SolarBattery>
            {
                new SolarBattery(41.40338, 2.17403, 2, 7 ),
                new SolarBattery(1.81194, 55.2258, 2, 7 ),
                new SolarBattery(1.81194, 55.2258, 1.4, 7 ),
                new SolarBattery(41.40338, 2.17403, 1, 7 ),
                new SolarBattery(41.40338, 2.17403, 0.7, 12 ),
                new SolarBattery(41.40338, 2.17403, 2, 7 ),
                new SolarBattery(41.40338, 2.17403, 0.4, 12 ),
                new SolarBattery(41.40338, 2.17403, 2, 7 ),
                new SolarBattery(41.40338, 2.17403, 0.8, 7 ),
                new SolarBattery(41.40338, 2.17403, 1.9, 7 )
            };

            //При помощи LINQ посчитайте количество солнечный батарей с мощностью более 1КВт, установленных в северном полушарии(широта > 0).
            var Count = from p in solarBatteries
                        where p.power > 1
                        where p.geoWedth > 0
                        select p;

            var Count2 = solarBatteries.Where(l => l.power > 1 && l.geoWedth > 1).Count();

            //    Разработайте универсальный класс, который может хранить в себе пару значений(произвольного типа).  
            List<Universal<int>> un = new List<Universal<int>>
            {
                new Universal<int>(23, 15),
                new Universal<int>(6, 36)
            };

            //  Разработайте универсальный метод, обменивающий 2 значения между собой.
            int value1 = 13;
            int value2 = 24;

            un[0].Swap(ref value1, ref value2);
            un[1].Swap(ref value1, ref value2); 
        }
    }
}
