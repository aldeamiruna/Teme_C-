using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Tema1_ex3
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Persoana> personList = new List<Persoana>();
            Persoana p1 = new Persoana
            {
                Prenume = "John",
                Nume = "Smith",
                Adresa = "Strada Dobrogea,Nr 29"
            };

            Persoana p2 = new Persoana
            {
                Prenume = "Mihai",
                Nume = "Popescu",
                Adresa = "Strada 13 Decembrie,Nr 8"
            };

        }
    }

    internal class List<T> : System.Collections.Generic.List<Persoana>
    {
    }
}
