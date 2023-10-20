using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSharpApp
{
    internal class CoffeeMachine : Machine
    {
        public CoffeeMachine()
        {
            Console.WriteLine("Am Strom angeschlossen? " + IsPowerd);
        }

        public virtual void MakeCoffee()
        {
            // Algo for making coffee

            TurnOff();
        }
    }
}
