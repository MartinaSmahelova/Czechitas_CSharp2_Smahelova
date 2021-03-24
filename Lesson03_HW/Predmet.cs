using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_HW
{
    public class Predmet
    {
        public string Kod;
        public string Jmeno;
        public List<string> PrerekvizityKod; // co musi by splneno nebo aspon zapsano zaroven

        public Predmet(string kod, string jmeno)
        {
            Kod = kod; Jmeno = jmeno; PrerekvizityKod = new List<string>();
        }

        public Predmet(string kod, string jmeno, List<string> prerekvizity)
        {
            Kod = kod; Jmeno = jmeno; PrerekvizityKod = prerekvizity;
        }
    }

}
