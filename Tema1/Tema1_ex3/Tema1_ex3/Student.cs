using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tema1_ex3
{
    class Student : Persoana
    {
        public Student(String firstName, String lastName, String address, String id, double average) : base(firstName, lastName, address)
        {
            this.ID = id;
            this.Average = average;
        }

        String ID { get; set; }
        double Average { get; set; }
    }
}
