using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class FindComplement
    {
        public int Execute(int num)
        {
            int mask = ~0;
            while ((mask & num) > 0) mask <<= 1;
            return ~mask & ~num;
        }
    }
}
