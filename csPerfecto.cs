﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class csPerfecto
    {
        public bool calcularPerfecto(int number)
        {
            int sum = 0;
            for(int i = 1; i < number; i ++)
            {
                if(number % i == 0) sum += i;
            }
            return sum == number;
        }
    }
}
