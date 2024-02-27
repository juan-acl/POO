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
            Console.WriteLine("3. Verificar si un numero es perfecto.");
            Console.WriteLine("4. Verificar la persona de menor edad.");
            Console.WriteLine("5. Verificar si un numero es entero es positivo/negativo.");
            Console.WriteLine("0. Salir.");
            Dictionary<int, Action> listOptions = new Dictionary<int, Action>();
            int option = int.Parse(Console.ReadLine());
            listOptions[0] = Exit;
            listOptions[1] = Payments;
            listOptions[2] = QuatityBills;
            listOptions[3] = NumberPerfect;
            listOptions[4] = Ages;
            listOptions[5] = SighNumber;
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
        static void NumberPerfect()
        {
            Console.Clear();
            Console.WriteLine("-----Numero perfecto-----");
            Console.WriteLine("Ingrese un numero");
            int input_number = int.Parse(Console.ReadLine());
            csPerfecto number_perfect = new csPerfecto();
            Console.WriteLine(number_perfect.calcularPerfecto(input_number) ? "El número es perfecto" : "El número no es perfecto");
            Console.ReadKey();
        }
        static void Ages()
        {
            Console.Clear();
            Console.WriteLine("-----Edad de una persona menor-----");
            Console.WriteLine("Ingrese la edad de la primera persona");
            int input_age1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre de la primera persona");
            string input_name1 = Console.ReadLine();
            Console.WriteLine("Ingrese la edad de la segunda persona");
            int input_age2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre de la segunda persona");
            string input_name2 = Console.ReadLine();
            Console.WriteLine("Ingrese la edad de la tercera persona");
            int input_age3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre de la tercera persona");
            string input_name3 = Console.ReadLine();
            csEdad menorEdad = new csEdad();
            csPersona[] csPerson = new csPersona[] // Creacion de un array de objetos de la clase csPersona
            {
                new csPersona{age= input_age1, name = input_name1 },
                new csPersona{age= input_age2, name = input_name2 },
                new csPersona{age= input_age3, name = input_name3 }
            };
            Console.WriteLine(menorEdad.calcularEdad(csPerson));
            Console.ReadKey();
        }
        static void SighNumber()
        {
            Console.Clear();
            Console.WriteLine("-----Numero positivo/negativo-----");
            Console.WriteLine("Ingrese un numero");
            int input_number = int.Parse(Console.ReadLine());
            csEntero type_number = new csEntero();
            Console.WriteLine(type_number.calcularPositivo(input_number));
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
