using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ING_SOFT_OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CLASA GADGET
            //Telefon tel1 = new Telefon("IPhone 15", 5000, "IOS");
            //Frigider frig1 = new Frigider("Samsung", 4500, "A++");
            //List<Gadget> gadgets = new List<Gadget>();
            //gadgets.Add(tel1);
            //gadgets.Add(frig1);

            //foreach(Gadget g in gadgets)
            //{
            //    g.Porneste();

            //    if (g is IBluetooth b)
            //    {
            //        b.ConecteazaBluetooth();
            //    }
            //}

            //CLASA ANGAJAT
            Angajat ang1 = new Angajat("andrei");
            Console.WriteLine(ang1.Nume);
            Console.WriteLine(ang1.Salariu);
            Manager man1 = new Manager("horea", 6700, "IT");

            List<Angajat> angs = new List<Angajat>();
            angs.Add(ang1);
            angs.Add(man1);

            foreach(Angajat a in angs)
            {
                a.Lucreaza();

                if(a is Manager m)
                {
                    m.TineSedinta();
                }
            }


            Console.ReadKey();
        }

    }
}
 