using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Lab2Sem_Csharp_
{
    class AverageComparer : IComparer<Copywriter>
    {
        int IComparer<Copywriter>.Compare(Copywriter x, Copywriter y)
        {

            {
                return x.Average.CompareTo(y.Average);
            }

        }
    }
}
