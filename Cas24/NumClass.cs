using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas24
{
    class NumClass
    {

        public int Add(int num1, int num2)
        {
            return this.Addition(num1, num2);
        }

        private int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int AddS(int num1, int num2)
        {
            return num1 + num2;
        }

    }
}
