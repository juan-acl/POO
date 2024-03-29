﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class csDinero
    {
        public int[] calcularBilletes(int quantity)
        {
            int[] billetes = { 100, 50, 20, 10, 5, 1 };
            int[] cantidad = new int[6];
            for (int i = 0; i < 6; i++)
            {
                cantidad[i] = quantity / billetes[i];
                quantity %= billetes[i]; // * El modulo nos da el restante
            }
            return cantidad;
        }
    }
}
