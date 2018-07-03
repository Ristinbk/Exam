using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//   Разработайте универсальный класс, который может хранить в себе пару значений(произвольного типа).
//  Разработайте универсальный метод, обменивающий 2 значения между собой.

namespace Exam
{
    public class Universal<T>
    {
        public T value1;
        public T value2;

        public Universal(T value1, T value2)
        {
            this.value1 = value1;
            this.value2 = value2;
        }

        public void Swap(ref T value1, ref T value2)
        {
            T temp;
            temp = value1;
            value1 = value2;
            value2 = temp;
        }    
    }
}
