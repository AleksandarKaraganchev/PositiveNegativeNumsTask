using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveNegativeNums
{
    public class PositiveNegativeNum
    {
        public bool IsPositive(double number)
        {
            if (number < 0 && number != 0)
            {
                return false;
            }
            if (number == 0)
            {
                throw new ArgumentException("Vuvedenoto chislo ne e nito polojitelno nito otricatelno to e 0");
            }
            return true;
        }
    }
}
