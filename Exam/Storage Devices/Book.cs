using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Book : StorageDevices
    {
        public string Author { get; }
        public string PublishingHouse { get; }

        public Book(string name) :this(name, new int())
        {
        }

        public Book(string name, int countPages) 
            : base(name, countPages)
        {
            average = Average.BookList;
        }

        public override int InformationVolume()
        {
            return CountPages * (int)Average;
        }

        public override string ToString()
        {
            return $": {Name} - {Author} {PublishingHouse} (str = {CountPages})";
        }
    }
}
