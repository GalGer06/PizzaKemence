using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKemence
{
    internal class Futar
    {
        private PizzaKemce pizzaKemce;

        public Futar(PizzaKemce pizzaKemce)
            {
                this.pizzaKemce = pizzaKemce;
        }

        public void Szallit()
        {
            while (true)
            {
                Pizza pizza = pizzaKemce.KemencebolKivesz();
                Pizza meret = pizzaKemce.KemencebolKivesz();

                Console.WriteLine($"Futár szállította: {pizza.Nev} ({pizza.Meret})");
                Thread.Sleep(pizza.Meret * 100);
            }
        }
    }
}
