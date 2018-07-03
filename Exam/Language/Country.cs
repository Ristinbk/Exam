using System;
using System.Collections.Generic;

namespace Exam
{
    public class Country
    {
        public string Name { get; }
        public CodeCountry CodeCountry { get; }
        public List<ILanguage> Languages { get; } = new List<ILanguage>();

        public Country()
        {
        }

        public Country(string name) : this(name, new Language())
        {
            Name = name;
            CodeCountry = new CodeCountry(name);
        }

        public Country(string name, ILanguage language)
        {
            Name = name;
            CodeCountry = new CodeCountry(name);
            if (Languages == null)
                throw new ArgumentNullException();
            Languages.Add(language);
        }

        public void AddTo(Language language)
        {
            Languages.Add(language);
        }

        public void AddLanguage(ILanguage language)
        {
            Languages.Add(language);
        }

        public override string ToString()
        {
            return $"{Name} {CodeCountry}";
        }
    }
}