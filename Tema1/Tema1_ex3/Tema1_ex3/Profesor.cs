using System;
using System.Collections.Generic;
using System.Text;

namespace Tema1_ex3
{
    class Profesor :Persoana
    {
        public Profesor(String firstName, String lastName, String address, TeacherRank teacherRank) : base(firstName, lastName, address)
        {
            this.teacherRank = teacherRank;
        }



        TeacherRank teacherRank { get; set; }
    }
}

