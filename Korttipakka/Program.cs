using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korttipakka
{
    class Program
    {
        static void Main(string[] args)
        {
            Pakka pakka = new Pakka();
            pakka.LuoPakka();

            pakka.Shuffle();

            Pakka kortti = new Pakka();
           kortti.Lista = pakka.DealHand(1);
            kortti.Sort();
            Console.Write(pakka.ToString());
            Console.WriteLine("nostettu kortti:");
            Console.Write(kortti.ToString());

            Console.ReadLine();
        }
    }
}

