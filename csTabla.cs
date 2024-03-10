using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class csTabla
    {
        public int[] GenerateTable(int baseNumber)
        {
            int[] table = new int[10];
            for (int i = 0; i < 10; i++)
            {
                table[i] = baseNumber * (i + 1);
            }
            return table;
        }
    }
}
