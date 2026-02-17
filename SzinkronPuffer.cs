using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKemence
{
    internal class SzinkronPuffer<T>
    {
            private Queue<T> sor;
            private int meret;
            private object zar = new object();
    
            public SzinkronPuffer(int capacity)
            {
                this.meret = capacity;
                this.sor = new Queue<T>();
            }
    
            public void Add(T item)
            {
                lock (zar)
                {
                    while (sor.Count >= meret)
                    {
                        Monitor.Wait(zar);
                    }
                    sor.Enqueue(item);
                    Monitor.PulseAll(zar);
                }
            }
    
            public T Remove()
            {
                lock (zar)
                {
                    while (sor.Count == 0)
                    {
                        Monitor.Wait(zar);
                    }
                    T item = sor.Dequeue();
                    Monitor.PulseAll(zar);
                    return item;
                }
        }
    }
}
