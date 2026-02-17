using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKemence
{
    internal class Sef
    {
        private PizzaKemce pizzaKemce;
        private static string[] nevek = { "Margherita", "Pepperoni", "Hawaii", "Vegetariana", "Quattro Formaggi" };
        private static Random r = new Random();
        private static int[] meretek = { 20, 30, 40, 50, 60 };

        public Sef(PizzaKemce pizzaKemce)
        {
            this.pizzaKemce = pizzaKemce;
        }
        public void Sutes()
        {
            while (true)
            {
                string nev = nevek[r.Next(nevek.Length)];
                int meret = meretek[r.Next(meretek.Length)];
                Pizza pizza = new Pizza(nev, meret);
                pizzaKemce.KemencebeTesz(pizza);
                Console.WriteLine($"Séf készítette: {pizza.Nev} ({pizza.Meret})");
                Thread.Sleep(meret * 100);
            }
        }
    }
}
