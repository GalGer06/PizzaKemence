namespace PizzaKemence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaKemce pizzaKemce = new PizzaKemce(10);

            Sef sef = new Sef(pizzaKemce);
            Futar futar = new Futar(pizzaKemce);

            Thread sefThread = new Thread(sef.Sutes);
            Thread futarThread = new Thread(futar.Szallit);

            sefThread.Start();
            futarThread.Start();
        }
    }
}
