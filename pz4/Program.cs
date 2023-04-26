using pz4_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace pz4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Liquid hh = new Liquid();
            hh.Read();
            hh.Display();
            Alcohol alcohol = new Alcohol();
            alcohol.Read();
            alcohol.Display();
        }
    }
}
