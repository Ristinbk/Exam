using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    interface IStorageDevices
    {
        string Name { get;  }
        int CountPages { get; }        
        Average Average { get; }

        int InformationVolume();
    }
}
