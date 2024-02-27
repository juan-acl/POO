using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class csEdad
    {
        public string calcularEdad(csPersona[] personas)
        {
            int minor_age = int.MaxValue;
            string name = "";
            foreach(csPersona persona in personas)
            {
                if(persona.age < minor_age)
                {
                    name = persona.name;
                    minor_age = persona.age;
                }
            }
            return "La persona con menor edad es: " + name + " con " + minor_age + " años";
        }
    }
}
