using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ING_SOFT_OOP2
{
    interface ILead
    {
        void TineSedinta();
    }
    class Angajat
    {

        public string Nume { get; set; }

        private double _salariu;

        public double Salariu
        {
            get { return _salariu; }
            set
            {
                if (value < 3000)
                {
                    Console.WriteLine("Eroare! Salariu prea mic!");
                    _salariu = 3000;
                }
                else
                {
                    _salariu = value;
                }
            }
        }

        public virtual void Lucreaza()
        {
            Console.WriteLine("Angajatul lucreaza!");
        }

        public Angajat(string nume, double salariu)
        {
            Nume = nume;
            Salariu = salariu;
        }

        public Angajat(string nume) : this(nume, 3000)
        {
            Nume = nume;
        }
        

    }

    class Manager : Angajat, ILead
    {
        public string Departament { get; set; }

        public Manager(string nume, double salariu, string departament) : base(nume, salariu)
        {
            Nume = nume;
            Salariu = salariu;
            Departament = departament;
        }

        public void TineSedinta()
        {
            Console.WriteLine("Managerul a convocat sedinta!");
        }

        public override void Lucreaza()
        {
            Console.WriteLine($"Managerul {Nume} analizeaza rapoarte!");
        }
    }
}
