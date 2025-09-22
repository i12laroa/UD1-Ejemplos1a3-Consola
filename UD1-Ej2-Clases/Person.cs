using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ej2_Clases
{
    public class Person
    {
        public string Name { get; set; }

        private int salary;
        public int Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    salary = 0;
                }
                else
                {
                    salary = value;
                }
            }
        }

        //Métodos 
        public Person()
        {
            Name = "Juan";
            salary = 1500;
        }

    
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre Persona: {Name} y su salario {Salary}");
        }
    }
}
