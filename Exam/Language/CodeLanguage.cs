namespace Exam
{
    public class CodeLanguage
    {
        public string Code { get; }

        public CodeLanguage(string name)
        {
            Code = name.ToString().Substring(0, 2);
        }

        public override string ToString()
        {
            return $"{Code }";
        }
    }
}