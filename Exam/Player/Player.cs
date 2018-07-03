using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
13.	Разработайте класс «Игрок» (имя, страна, сумма очков, - все это свойства, защищенные от записи извне). 
    Добавьте в класс метод увеличения количества набранных очков(на сколько – передается параметром).
14.	При помощи LINQ посчитайте количество игроков из Германии, которые набрали от 100 до 500 очков.
15.	При помощи LINQ посчитайте количество игроков из России, которые набрали более 1000очков, упорядочив список по полю имени.
*/

namespace Exam
{
    public class Player :IPlayer
    {
        public string Name { get; }
        public Country Country { get; }
        public int SumPoints { get; private set; }

        public Player(string name, Country country)
        {
            Name = name;
            Country = country;
            SumPoints = 0;
        }

        public Player()
        {
        }

        public int AddPoints(int points)
        {
            return SumPoints += points;
        }
    }
}
