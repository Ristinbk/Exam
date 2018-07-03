using System;
using System.Collections.Generic;

//1.  Разработайте класс «Язык», позволяющий хранить название языка, его двухбуквенный код, и список стран, где он принять в качестве основного.
//Интерфейс класса должен обеспечивать доступ ко всем этим данным.

namespace Exam
{
    public class Language : ILanguage
    {
        public string Name { get; }
        public CodeLanguage CodeLanguage { get; }
        public List<Country> Countries { get; }

        public Language() //: this(null)
        {
        }

        public Language(string name) :this (name,new Country())
        {
            Name = name;
            CodeLanguage = new CodeLanguage(name);
        }

        public Language(string name, Country Country)
        {
            Name = name;
            CodeLanguage = new CodeLanguage(name);
            if (Country == null)
                throw new ArgumentNullException();
            Countries = new List<Country>();
            if (Country.Name != null)
            {
                Countries.Add(Country);
                foreach (var t in Countries)
                {
                    if (t == null)
                        throw new ArgumentNullException();
                    t.AddTo(this);
                }
            }
        }

        public void AddCountry(Country Country)
        {
            Countries.Add(Country);
        }

        public void Show()
        {
            Console.WriteLine(ToString());
            foreach (var t in Countries)
            {
                Console.WriteLine(t.ToString());
            }
        }

        public override string ToString()
        {
            return $"{Name} {CodeLanguage}";
        }
    }
}
