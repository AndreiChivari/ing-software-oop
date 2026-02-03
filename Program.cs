using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ING_SOFT_OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefon tel1 = new Telefon("IPhone 15", 5000, "IOS");
            Frigider frig1 = new Frigider("Samsung", 4500, "A++");
            List<Gadget> gadgets = new List<Gadget>();
            gadgets.Add(tel1);
            gadgets.Add(frig1);

            foreach(Gadget g in gadgets)
            {
                g.Porneste();

                if (g is IBluetooth b)
                {
                    b.ConecteazaBluetooth();
                }
            }


            Console.ReadKey();
        }

    }
}
 