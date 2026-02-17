using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKemence
{
    internal class PizzaKemce
    {
        private SzinkronPuffer<Pizza> kemence;
        public PizzaKemce(int meret)
        {
            this.kemence = new SzinkronPuffer<Pizza>(meret);
        }
        public void KemencebeTesz(Pizza pizza)
        {
            kemence.Add(pizza);
            Console.WriteLine($"Sef betette a kemencébe: {pizza}");
        }
        public Pizza KemencebolKivesz()
        {
            return kemence.Remove();
        }
    }
}
