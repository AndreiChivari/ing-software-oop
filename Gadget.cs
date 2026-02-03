using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ING_SOFT_OOP2
{
    interface IBluetooth
    {
        void ConecteazaBluetooth();
    }

    class Gadget
    {
        public string Model { get; set; }
        public int Pret { get; set; }

        public Gadget(string model, int pret)
        {
            Model = model;
            Pret = pret;
        }

        public virtual void Porneste()
        {
            Console.WriteLine("Gadgetul porneste...");
        }
    }

    class Telefon : Gadget, IBluetooth
    {
        public string SistemDeOperare { get; set; }

        public Telefon(string model, int pret, string os): base(model, pret)
        {
            SistemDeOperare = os;
        }

        public override void Porneste()
        {
            Console.WriteLine($"Telefonul {Model} afiseaza logo-ul {SistemDeOperare}");
        }

        public void ConecteazaBluetooth()
        {
            Console.WriteLine("Telefonul s-a conectat la casti!");
        }


    }

    class Frigider : Gadget
    {
        public string ClasaEnergetica { get; set; }

        public Frigider(string model, int pret, string clasaEnergetica) : base(model, pret)
        {
            ClasaEnergetica = clasaEnergetica;
        }

        public override void Porneste()
        {
            Console.WriteLine($"Frigiderul {Model} a pornit compresorul");
        }
    }
}
