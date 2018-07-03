using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public interface ILogFile
    {
        void WriteLine(string str);
        void ReadLine();
    }
}
