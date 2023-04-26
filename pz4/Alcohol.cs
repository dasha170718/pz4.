using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz4_
{
    internal class Alcohol:Liquid
    {
        public float Strength;
        public void Read()
        {
            Console.WriteLine("Укажите крепость:");
            Strength = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("");
        }
        public void Display()
        {
            Console.WriteLine("Крепость алкоголя:");
            Console.WriteLine($"{Strength}");
        }
        public void ChangeStrength(Alcohol alcohol)
        {
            if (alcohol == null)
                throw new NullReferenceException("alcohol");
            Console.WriteLine($"Kрепость: {alcohol.Strength}");
            float NewStrength = Convert.ToSingle(Console.ReadLine());
             alcohol.Strength = NewStrength;
            return;
        }
    }
}
