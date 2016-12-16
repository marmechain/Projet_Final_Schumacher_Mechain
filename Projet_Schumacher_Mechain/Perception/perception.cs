using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace PerceptionForm
{
    public class perception
    {
        Random rnd = new Random();
        

        public double score
        {
            get;
            set;
        }

        public int difficulte
        {
            get;
            set;
        }

        public perception() 
        {
            score = 0;
            difficulte = 0;
            
        }

        //public void deserialiserPerception()
        //{
        //    XDocument document = XDocument.Load("perception.xml");
        //    var Images = document.Descendants("TabImages").First();
        //    var Image = document.Descendants("TabImage");

        //    for (int k = 0; k < TabImages.Length; k++)
        //    {
        //        for (int i = 0; i < TabImages[k].Length; i++)
        //        {
        //            foreach (var j in Image)
        //            {
        //                TabImages[k][i] = (string)j.Descendants("image").First();
        //            }
        //        }
        //    }

        //    var Consignes = document.Descendants("consignes");
        //    for (int l=0;l<consigne.Length;l++)
        //    {
        //        foreach (var m in Consignes)
        //        {
        //            consigne[l] = (string)m.Descendants("Consigne").First();
        //        }
        //    }                   
        //}

        

        public double calculeScore(int [] repUser,int[]reponses)
        {
            bool verif = verificationReponse(repUser,reponses);
            if (verif == true)
            {
                this.score = this.score + 3;
            }
            return this.score;     
        }

        public bool verificationReponse(int [] repUser, int [] reponses)
        {
            bool verif = false;

            for (int i=0;i<3;i++)
            {
                if (repUser[i] == reponses[i])
                {
                    verif = true;
                }
                else { verif = false; }
            }
            return verif;
        }
    }
}
