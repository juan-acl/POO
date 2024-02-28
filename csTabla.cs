using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class csTabla
    {
        public int[,] GenerateTable(int rows)
        {
            int[,] table = new int[9, 9];
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    table[i, j] = (i ) * (j );
                }
            }
            return table;
        }
    }
}
