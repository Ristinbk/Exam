using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Разработайте класс «Устройство хранение информации», унаследуйте его в классе «Книга», с виртуальными методом, возвращающим объем информации
//    (количество страниц * среднее количество букв на странице).

namespace Exam
{
    public class StorageDevices : IStorageDevices
    {
        public string Name { get; }
        public int CountPages { get; }
        protected Average average;
        public Average Average => average;

        public StorageDevices(string name, int countPages)
        {
            Name = name;
            CountPages = countPages;
        }

        public virtual int InformationVolume()
        {
            return CountPages * (int)Average;
        }

    }
}
