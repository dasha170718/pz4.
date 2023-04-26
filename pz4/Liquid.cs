using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz4_
{
    internal class Liquid
    {
        public string Name;
        public float Density;
        public void Read()       
        {
            Console.WriteLine("Укажите название");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Укажите плотность");
            Density = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("");
        }
        public void Display()
        {
            Console.WriteLine("Наименование житкости:");
            Console.WriteLine($"{Name}");
            Console.WriteLine($"Плотность: {Density}");
            Console.WriteLine("");
        }
        public void SetDensity(Liquid liquid)
        {
            if (liquid == null)
                throw new ArgumentNullException("liquid");
            Console.WriteLine($"Плоткость житкости:{liquid.Density}");
            float NewDensity = Convert.ToSingle(Console.ReadLine());
            liquid.Density = NewDensity;
            Console.WriteLine($"Плотность житкости:{liquid.Density} ");
            return; 
        }
    }

}
