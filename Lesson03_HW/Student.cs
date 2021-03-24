using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_HW
{
    public class Student
    {
        public string Jmeno;
        public string Primeni;
        public List<Predmet> ZapsaneAbsolvovanePredmety;

        public Student(string jmeno, string primeni)
        {
            Jmeno = jmeno;
            Primeni = primeni;
            ZapsaneAbsolvovanePredmety = new List<Predmet>();
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}", Primeni, Jmeno);
        }
    }
}
