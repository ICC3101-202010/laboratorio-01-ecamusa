using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1_1
{
    public class Persona
    {
        public string name;
        public string lastname;
        public Persona(string aName, string aLastname)
        {
            name = aName;
            lastname = aLastname;

            Console.WriteLine(name);
            Console.WriteLine(lastname);

        }
        public int Lanzar()
        {
            Random rand = new Random();
            int a = rand.Next(0, 3);

            return a;

        }
    }
}
