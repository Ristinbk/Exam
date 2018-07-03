using System;
using System.Collections.Generic;
using System.Linq;

//1.  Разработайте класс «Язык», позволяющий хранить название языка, его двухбуквенный код, и список стран, где он принять в качестве основного.
//Интерфейс класса должен обеспечивать доступ ко всем этим данным.

namespace Exam
{
    public interface ILanguage
    {
        string Name { get; }
        CodeLanguage CodeLanguage { get; }
        List<Country> Countries { get; }

        void AddCountry(Country Country);
        void Show();
    }
}
