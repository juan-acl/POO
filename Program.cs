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
            Console.WriteLine("6. Calcular el volumen de un cilindro.");
            Console.WriteLine("7. Equipo ganador.");
            Console.WriteLine("8. MCD.");
            Console.WriteLine("9. Serie de fibonacci.");
            Console.WriteLine("10. Tabla de multiplicacion.");
            Console.WriteLine("0. Salir.");
            Dictionary<int, Action> listOptions = new Dictionary<int, Action>();
            int option = int.Parse(Console.ReadLine());
            listOptions[0] = Exit;
            listOptions[1] = Payments;
            listOptions[2] = QuatityBills;
            listOptions[3] = NumberPerfect;
            listOptions[4] = Ages;
            listOptions[5] = SignNumber;
            listOptions[6] = Volumen;
            listOptions[7] = Winner;
            listOptions[8] = MCD;
            listOptions[9] = Fibonacci;
            listOptions[10] = TableMultiplication;
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
        static void SignNumber()
        {
            Console.Clear();
            Console.WriteLine("-----Numero positivo/negativo-----");
            Console.WriteLine("Ingrese un numero");
            int input_number = int.Parse(Console.ReadLine());
            csEntero type_number = new csEntero();
            Console.WriteLine(type_number.calcularPositivo(input_number));
            Console.ReadKey();
        }
        static void Volumen()
        {
            Console.Clear();
            Console.WriteLine("-----Volumen de un cilindro-----");
            Console.WriteLine("Ingrese el radio del cilindro");
            double input_radio = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del cilindro");
            double input_height = double.Parse(Console.ReadLine());
            csVolumen volumenCilindro = new csVolumen();
            Console.WriteLine("El volumen del radio es de: " + volumenCilindro.calcularVolumen(input_radio, input_height) + " unidades");
            Console.ReadKey();
        }
        static void Winner()
        {
            Console.Clear();
            Console.WriteLine("-----Equipo ganador-----");
            int[] scores = new int[2];
            string[] names = new string[2];
            Console.WriteLine("Ingrese el nombre del primer equipo");
            names[0] = Console.ReadLine();
            Console.WriteLine("Ingrese el puntaje del primer equipo");
            scores[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del segundo equipo");
            names[1] = Console.ReadLine();
            Console.WriteLine("Ingrese el puntaje del segundo equipo");
            scores[1] = int.Parse(Console.ReadLine());
            csEquipo winner_team = new csEquipo();
            Console.WriteLine(winner_team.calcularMarcador(scores, names));
            Console.ReadKey();
        }
        static void MCD()
        {
            Console.Clear();
            Console.WriteLine("-----MCD-----");
            Console.WriteLine("Ingrese el numero numero");
            int input_number = int.Parse(Console.ReadLine());
            csMCD mcd = new csMCD();
            Console.WriteLine("El MCD del numero" + input_number + " es: " + mcd.calcularMCD(input_number));
            Console.ReadKey();
        }
        static void Fibonacci()
        {

        }
        static void TableMultiplication()
        {

        }
        static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Gracias por usar el sistema, vuelva pronto!!!");
            Console.ReadKey();
        }
    }
}
