using System;
using System.Collections.Generic;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("-----Menu de opciones-----");
            Console.WriteLine("1. Pago de viaje de estudios.");
            Console.WriteLine("2. Cantidad de billetes.");
            Dictionary<int, Action> listOptions = new Dictionary<int, Action>();
            int option = int.Parse(Console.ReadLine());
            listOptions[0] = Exit;
            listOptions[1] = Payments;
            listOptions[2] = QuatityBills;
            listOptions[option]();
            if (option != 0) Menu();
        }
        static void Payments()
        {
            Console.Clear();
            Console.WriteLine("-----Pago de viaje de estudios-----");
            Console.WriteLine("Ingrese el numero de estudiasntes que asistiran");
            int input_students = int.Parse(Console.ReadLine());
            csPagoAutobus pagoEstudents = new csPagoAutobus();
            pagoEstudents.SetStudentsPay(input_students);
            Console.WriteLine(pagoEstudents.calcularPagoAutobus(input_students));
            Console.ReadKey();
        }
        static void QuatityBills()
        {
            Console.Clear();
            Console.WriteLine("-----Cantidad de billetes-----");
            Console.WriteLine("Ingrese la cantidad de dinero");
            int input_quantity = int.Parse(Console.ReadLine());
            csDinero quatityBills = new csDinero();
            int[] bills = quatityBills.calcularBilletes(input_quantity);
            string[] numbers = { "100", "50", "20", "10", "5", "1" };
            for(int i = 0; bills.Length < 6; i++)
            {
                Console.WriteLine("Cantiad de billetes de " + numbers[i] + " :" + bills[i]);
            }
            Console.ReadKey();
        }
        static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Gracias por usar el sistema, vuelva pronto!!!");
            Console.ReadKey();
        }
    }
}
