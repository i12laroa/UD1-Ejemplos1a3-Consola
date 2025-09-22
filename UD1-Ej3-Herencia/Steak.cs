using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ej3_Herencia
{
    public class Steak : Ingredient
    {
        public Steak(string name, double count) : base(name, count){}

        public override void MakeFood()
        {
            Console.WriteLine($"Haciendo {Count} a la brasa del filete de {Name}");
        }
    }
}
