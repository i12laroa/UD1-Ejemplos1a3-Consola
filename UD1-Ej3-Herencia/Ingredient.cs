using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ej3_Herencia
{
    public class Ingredient
    {
        //Propiedades
        public string Name { get; set; }
        public double Count { get; set; }

        public Ingredient (string name, double count)
        {
            Name = name;
            Count = count;
        }

        //Método de preparación

        public virtual void MakeFood()
        {
            Console.WriteLine($"Preparando {Count} gramos de {Name} ");
        }

    }
}
