using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pb_Mathematique
{
    public class probleme
    {

        public string enonce
        {
            get;
            set;
        }

        public string reponse
        {
            get;
            set;
        }

        public string choix1
        {
            get;
            set;
        }

        public string choix2
        {
            get;
            set;
        }

        public string choix3
        {
            get;
            set;
        }

        public string choix4
        {
            get;
            set;
        }


        public int difficulte
        {
            get;
            set;
        }


        public bool dejaChoisi
        {
            get;
            set;
        }

        public probleme() { }

        public probleme(string e, string r, string c1, string c2, string c3, string c4, int d, bool dc) 
        {
            enonce = e;
            reponse = r;
            choix1 = c1;
            choix2 = c2;
            choix3 = c3;
            choix4 = c4;
            difficulte = d;
            dejaChoisi = dc;
        }
    }
}
