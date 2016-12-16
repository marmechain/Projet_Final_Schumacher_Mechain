using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attention
{
    class attention
    {
        public string[] seq1 { get; set; }
        public string[] seq2 { get; set; }
        public string[] seq3 { get; set; }
        public string[] Consigne { get; set; }
        public string[] Consigne_Select { get; set; }
        public int[] bonne_rep1 { get; set; }
        public int[] bonne_rep2 { get; set; }
        public int[] bonne_rep3 { get; set; }

        public attention()
        {
            seq1 = new string[] {"RB2.JPG", "CB4.JPG", "CJ0.JPG", "TR0.JPG", "RV1.JPG" };
            seq2 = new string[] {"TJ3.JPG", "CJ1.JPG", "TB1.JPG", "RB4.JPG", "RR0.JPG" };
            seq3 = new string[] {"CV2.JPG", "RJ2.JPG", "RB3.JPG", "TV0.JPG", "CV4.JPG" };
            Consigne = new string[] { "L'image a la même forme que la précédente", "L'image a la même couleur que la précédente", "L'image a le même nombre de points que la précédente" };
            Consigne_Select = new string[2];
            bonne_rep1 = new int[5];
            bonne_rep2 = new int[5];
            bonne_rep3 = new int[5];
        }

        public void Selection_Cons()
        {
            Random rnd = new Random();
            int a;
            int b;
            do
            {
                a = rnd.Next(0, 2);
                b = rnd.Next(0, 2);
            }
            while (a == b);

            Consigne_Select[0] = Consigne[a];
            Consigne_Select[1] = Consigne[b];

            switch (a)
            {
                case 0:
                    switch (b)
                    {
                        case 1:
                            bonne_rep1[0] = 3;
                            bonne_rep1[1] = 2;
                            bonne_rep1[2] = 1;
                            bonne_rep1[3] = 3;
                            bonne_rep1[4] = 3;

                            bonne_rep2[0] = 3;
                            bonne_rep2[1] = 2;
                            bonne_rep2[2] = 3;
                            bonne_rep2[3] = 2;
                            bonne_rep2[4] = 1;

                            bonne_rep3[0] = 3;
                            bonne_rep3[1] = 3;
                            bonne_rep3[2] = 1;
                            bonne_rep3[3] = 3;
                            bonne_rep3[4] = 2;
                            break;
                        case 2:
                            bonne_rep1[0] = 3;
                            bonne_rep1[1] = 3;
                            bonne_rep1[2] = 1;
                            bonne_rep1[3] = 2;
                            bonne_rep1[4] = 3;

                            bonne_rep2[0] = 3;
                            bonne_rep2[1] = 3;
                            bonne_rep2[2] = 2;
                            bonne_rep2[3] = 3;
                            bonne_rep2[4] = 1;

                            bonne_rep3[0] = 3;
                            bonne_rep3[1] = 2;
                            bonne_rep3[2] = 1;
                            bonne_rep3[3] = 3;
                            bonne_rep3[4] = 3;
                            break;
                    }
                    break;
                case 1:
                    switch (b)
                    {
                        case 0:
                            bonne_rep1[0] = 3;
                            bonne_rep1[1] = 1;
                            bonne_rep1[2] = 2;
                            bonne_rep1[3] = 3;
                            bonne_rep1[4] = 3;

                            bonne_rep2[0] = 3;
                            bonne_rep2[1] = 1;
                            bonne_rep2[2] = 3;
                            bonne_rep2[3] = 1;
                            bonne_rep2[4] = 2;

                            bonne_rep3[0] = 3;
                            bonne_rep3[1] = 3;
                            bonne_rep3[2] = 2;
                            bonne_rep3[3] = 3;
                            bonne_rep3[4] = 1;
                            break;
                        case 2:
                            bonne_rep1[0] = 3;
                            bonne_rep1[1] = 1;
                            bonne_rep1[2] = 3;
                            bonne_rep1[3] = 2;
                            bonne_rep1[4] = 3;

                            bonne_rep2[0] = 3;
                            bonne_rep2[1] = 1;
                            bonne_rep2[2] = 2;
                            bonne_rep2[3] = 1;
                            bonne_rep2[4] = 3;

                            bonne_rep3[0] = 3;
                            bonne_rep3[1] = 2;
                            bonne_rep3[2] = 3;
                            bonne_rep3[3] = 3;
                            bonne_rep3[4] = 1;
                            break;
                    }
                    break;
                case 2:
                    {
                        switch (b)
                        {
                            case 0:
                                bonne_rep1[0] = 3;
                                bonne_rep1[1] = 3;
                                bonne_rep1[2] = 2;
                                bonne_rep1[3] = 1;
                                bonne_rep1[4] = 3;

                                bonne_rep2[0] = 3;
                                bonne_rep2[1] = 3;
                                bonne_rep2[2] = 1;
                                bonne_rep2[3] = 3;
                                bonne_rep2[4] = 2;

                                bonne_rep3[0] = 3;
                                bonne_rep3[1] = 1;
                                bonne_rep3[2] = 2;
                                bonne_rep3[3] = 3;
                                bonne_rep3[4] = 3;
                                break;

                            case 1:
                                bonne_rep1[0] = 3;
                                bonne_rep1[1] = 2;
                                bonne_rep1[2] = 3;
                                bonne_rep1[3] = 1;
                                bonne_rep1[4] = 3;

                                bonne_rep2[0] = 3;
                                bonne_rep2[1] = 2;
                                bonne_rep2[2] = 1;
                                bonne_rep2[3] = 2;
                                bonne_rep2[4] = 3;

                                bonne_rep3[0] = 3;
                                bonne_rep3[1] = 1;
                                bonne_rep3[2] = 3;
                                bonne_rep3[3] = 3;
                                bonne_rep3[4] = 2;
                                break;
                        }
                        break;
                }
            }
        }
    }
}
