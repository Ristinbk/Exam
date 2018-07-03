using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    interface IPlayer
    {
        string Name { get; }
        Country Country { get; }
        int SumPoints { get; }

        int AddPoints(int points);
    }
}
