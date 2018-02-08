using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class JudgeRouteCircle
    {
        public bool JudgeCircle(string moves)
        {
            char[] movesArray = moves.ToUpper().ToCharArray();
            int lr = 0;
            int ud = 0;
            foreach (char m in movesArray)
            {
                switch (m)
                {
                    case 'U':
                        ud++;
                        break;
                    case 'D':
                        ud--;
                        break;
                    case 'L':
                        lr++;
                        break;
                    case 'R':
                        lr--;
                        break;
                }
            }

            return lr == 0 && ud == 0;
        }
    }
}
