using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class csPagoAutobus
    {
        // * Private solo se puede acceder desde la misma clase
        // * Protected solo se puede acceder desde la misma clase y sus clases hijas
        private int number_students; 
        private int autobus_pay;

        public void SetStudentsPay(int number_students_params)
        {
            this.number_students = number_students_params;
        }
        public int GetStudentsPay()
        {
            return this.number_students;
        }

        public string calcularPagoAutobus(int number_students_assists)
        {
            string message = "";
            if(number_students_assists >= 100) return message = "El pago por estudiante es de: 65";
            if(number_students_assists >= 50 && number_students_assists<=99) return message = "El pago por estudiante es de: 70";
            if(number_students_assists >= 30 && number_students_assists<=49) return message = "El pago por estudiante es de: 95";
        }
    }
}
