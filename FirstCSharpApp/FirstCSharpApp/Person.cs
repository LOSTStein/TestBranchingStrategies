using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSharpApp
{
    internal class Person
    {
        public float height;
        public string name;
        public DateTime brithDate;

        public void Walk()
        {
            Console.WriteLine(name + " läuft jetzt.");
        }
    }
}
