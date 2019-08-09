using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_ex3
{
    class Test
    {
        static void Main(string[] args)
        {
            List<Persoana> personList = new List<Persoana>();
            List<Persoana> sortedByFirstName = new List<Persoana>();
            List<Persoana> sortedByLastName = new List<Persoana>();

            Persoana p1 = new Persoana("Aldea", "Miruna", "Dobrogea 29");
            Persoana p2 = new Persoana("Tazlaoanu", "Sandra", "Nicolae Titulescu 38A");
            Persoana p3 = new Persoana("Iacob", "Stefan", "Dragos Voda 23");
            Persoana p4 = new Persoana("Huma", "Horatiu", "Alexandru Sahia 20");
            Persoana p5 = new Persoana("Popa", "Andreea", "Harmanului 25A");
            Persoana s1 = new Student("Rusen", "Andrei", "Scriitorilor 18", "1", 9.1);
            Persoana s2 = new Student("Huma", "Laurentiu", "Alexandru Sahia 20", "2", 7.8);
            Persoana s3 = new Student("Petru", "Iulia", "Vidin 8", "3", 5.9);


            personList.Add(p1);
            personList.Add(p2);
            personList.Add(p3);
            personList.Add(p4);
            personList.Add(p5);
            personList.Add(s1);
            personList.Add(s2);
            personList.Add(s3);

            sortedByFirstName = personList.OrderBy(x => x.FirstName).ToList();
            sortedByLastName = personList.OrderBy(x => x.LastName).ToList();

            Console.WriteLine("The alphabetically sorted list after first name: ");
            sortedByFirstName.ForEach(Console.WriteLine);


            Console.WriteLine();
            Console.WriteLine("The alphabetically sorted list after last name: ");
            sortedByLastName.ForEach(Console.WriteLine);
        }
    }
}
