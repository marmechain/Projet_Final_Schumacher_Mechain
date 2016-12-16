using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcul_Mental
{
    class calcul
    {
        public string[] tabCalcul { get; set; }
        public int[] tabRep { get; set; }
        public Random rnd = new Random();
        public int nb1;
        public int nb2;

        public calcul()
        {
            tabCalcul = new string[10];
            tabRep = new int[10];
        }

        public void Addition()
        {
            for (int i = 0; i < 10; i++)
            {
                nb1 = rnd.Next(100, 999);
                nb2 = rnd.Next(100, 999);

                tabCalcul[i] = "" + nb1 + " + " + nb2;
                tabRep[i] = nb1 + nb2;
            }
        }

        public void Soustraction()
        {
            for (int i = 0; i < 10; i++)
            {
                nb1 = rnd.Next(100, 999);
                nb2 = rnd.Next(10, nb1);

                tabCalcul[i] = "" + nb1 + " - " + nb2;
                tabRep[i] = nb1 - nb2;
            }
        }

        public void Multiplication()
        {
            for (int i = 0; i < 10; i++)
            {
                nb1 = rnd.Next(0, 19);
                nb2 = rnd.Next(0, 9);

                tabCalcul[i] = "" + nb1 + " x " + nb2;
                tabRep[i] = nb1 * nb2;
            }
        }

        public void Division()
        {
            for (int i = 0; i < 10; i++)
            {
                nb1 = rnd.Next(10, 999);
                nb2 = rnd.Next(1, 9);

                tabCalcul[i] = "" + nb1 + " ÷ " + nb2;
                tabRep[i] = Convert.ToInt32(nb1 / nb2);
            }
        }
    }
}
