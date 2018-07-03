using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class LogFile :ILogFile
    {
        StreamWriter sw;
     //   File.AppendText(path)

        public LogFile(string path)
        {
            sw = File.AppendText(path);            
        }

        public void WriteLine(string str)
        {           
            sw.WriteLine(str);           
            sw.Flush();
            Console.WriteLine(str + " - записан в файл");
        }


        public void ReadLine()
        {
            sw.Close();
            StreamReader sr = new StreamReader(@"E:\Ucit\C#\Лабы\Exam\Log.txt");
            string Str = sr.ReadLine();
            while (Str != null)
            {
                Console.WriteLine(Str = sr.ReadLine());
            }
        }
    }
}
