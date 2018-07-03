namespace Exam
{
    public class CodeCountry
    {
        public string Code { get; }

        public CodeCountry(string name)
        {
            Code = name.ToString().Substring(0, 3);
        }

        public override string ToString()
        {
            return $"{Code }";
        }
    }
}
