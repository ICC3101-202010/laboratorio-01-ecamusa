using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Bob", "Kunga");
            Console.WriteLine(persona1.Lanzar());
            Console.ReadLine();

        }
    }
}
