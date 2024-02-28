using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class csFibonacci
    {
        public int[] Fibonacci(int number)
        {
            if(number <= 2) return new int[] { 0, 1 };
            int[] fibonacci = new int[number];
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            for (int i = 2; i < number; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }
            return fibonacci;
        }
    }
}
