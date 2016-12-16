using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace Pb_Physique
{
    public class pb_phys
    {
        Random rnd = new Random();

        public double score
        {
            get;
            set;
        }

        public string consigne;


        public int difficulte
        {
            get;
            set;
        }

        public probleme[] problemes = new probleme[10];

        public pb_phys() 
        {
            consigne = "Répondez aux problèmes posés.";
            score = 0;
            difficulte = 0;

            problemes[0] = new probleme("Dans quel cas est-il le plus facile de bouger la pierre?", "D", "A", "B", "C", "D", 0, false);
            problemes[1] = new probleme("Si la poulie P1 tourne dans le sens des aiguilles d'une montre, \ndans quel sens tournera la poulie P2 ?", "Sens horaire", "Sens horaire", "Sens anti-horaire", " ", " ", 0, false);
            problemes[2] = new probleme("Quels composés chimiques obtient-on \nlorsqu’on brûle du méthane dans l’air ?", "Du dioxyde de carbone \net de la vapeur d’eau", "Du dioxyde de carbone \net du dioxygène", "Du dioxyde de carbone \net de la vapeur d’eau", "Du dioxygène \net de la vapeur d’eau", "Du fer et \ndu dioxygène", 0, false);
            problemes[3] = new probleme("En général, quand on augmente la température d’un gaz \nsans changer le volume, comment varie la pression ?", "Elle augmente", "Elle baisse", "Elle augmente", "Elle reste stable", "On ne peut pas augmenter \nla température \nà volume constant", 0, false);
            problemes[4] = new probleme("Lorsqu’une voiture roule à 100 km/h, \nla résistance de l’air est proportionnelle à ?", "Sa masse", "Sa masse", "Sa vitesse", "Au carré de sa vitesse", "Sa masse et sa vitesse", 0, false);
            problemes[5] = new probleme("Dans un champ magnétique :", "Seuls les électrons \npeuvent être déviés", "Les ions peuvent être \ndéviés mais pas la lumière", "La lumière peut être \ndéviée mais pas les ions", "La lumière et les ions \npeuvent être déviés", "Seuls les électrons \npeuvent être déviés", 0, false);
            problemes[6] = new probleme("De quelle couleur est le sulfate de cuivre anhydre hydraté ?", "bleu", "vert", "rouge", "incolore", "bleu", 0, false);
            problemes[7] = new probleme("Quelle(s) lampes(s) va/vont s’allumer si on ferme l’interrupteur ?", "Les deux lampes", "La lampe 1", "La lampe 2", "Les deux lampes", "Aucune des deux lampes", 0, false);
            problemes[8] = new probleme("Dans un circuit électrique, quelle est la valeur de l’intensité \ndu courant I sachant que U=20V et R=2 Ohm ?", "40 A", "40 A", "80 A", "22 A", "10 A", 0, false);
            problemes[9] = new probleme("Combien de Pa font 1 Bar ?", "100000", "10", "100", "1000", "100000", 0, false);
            
        }

        //public void deserialiserPbPhysique()
        //{
        //    XDocument document = XDocument.Load("problemes_physiques.xml");
        //    var pbs = document.Descendants("problemes").First();
        //    var pb = document.Descendants("probleme");
            
        //    for (int k = 0; k < problemes.Length; k++)
        //    {               
        //        foreach (var i in pb)
        //        {
        //            problemes[k] = new probleme((string)i.Descendants("image").First(),
        //                    (string)i.Descendants("enonce").First(),
        //                    (string)i.Descendants("reponse").First(),                       
        //                    (string)i.Descendants("Choix1").First(),  
        //                    (string)i.Descendants("Choix2").First(),
        //                    (string)i.Descendants("Choix3").First(),
        //                    (string)i.Descendants("Choix4").First(),
        //                    (int)i.Descendants("difficulte").First(),
        //                    (bool)i.Descendants("dejaChoisi").First());                    
        //        }
        //    }        
        //}

        public probleme selectionItem()
        {
            int numPb = 0;
            numPb = rnd.Next(0, problemes.Length);
          
            //if (problemes[numPb].dejaChoisi == true)
            //{
            //    numPb = rnd.Next(0, problemes.Length);

            //}
            //problemes[numPb].dejaChoisi = true;  
         
            return problemes[numPb];

        }
        public bool verificationReponse(string repUser, probleme pb)
        {
            bool verif = false;
            if (repUser == pb.reponse)
            {
                verif = true;
            }
            return verif;
        }

        public double calculeScore(string repUser, probleme pb)
        {
            bool verif = verificationReponse(repUser, pb);
            if (verif == true)
            {
                this.score = this.score + 1;
            }
            return this.score;
        }
    }
}
