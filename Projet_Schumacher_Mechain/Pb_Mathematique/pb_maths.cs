using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace Pb_Mathematique
{
    public class pb_maths
    {
        Random rnd = new Random();

        public double score
        {
            get;
            set;
        }

        public string consigne{get;set;}

        public int difficulte
        {
            get;
            set;
        }

        public probleme[] problemes_faciles = new probleme[10];

        public probleme[] problemes_difficiles = new probleme[10];

        public pb_maths() 
        {
            consigne = "Répondez aux problèmes posés.";
            score = 0;
            difficulte = 0;
            problemes_faciles[0] = new probleme("Hors-saison, un hôtel propose une chambre double à 80 euros. \nEn pleine saison, le prix augmente de 15%. \nQuel est le prix de la chambre double en pleine saison?", "92 euros", "81,5 euros", "92 euros", "95 euros", "120 euros", 0, false);
            problemes_faciles[1] = new probleme("Un rectangle de 12 mètres par 8 mètres a la même surface qu’un autre rectangle \ndont un des côtés mesure 16 mètres. \nQuelle est la longueur du 2ème côté de cet autre rectangle?", "6 mètres", "3 mètres", "4 mètres", "6 mètres", "8 mètres", 0, false);
            problemes_faciles[2] = new probleme("Combien y a t-il de centimètres cubes dans un mètre cube?", "1000000", "100", "1000", "10000", "1000000", 0, false);
            problemes_faciles[3] = new probleme("La longueur d’une tige de métal augmente de 4mm à chaque fois qu’on augmente la température de 10 degrés. \nQuel est théoriquement l’allongement de la tige (en cm) si on augmente la température de 150 degrés? ", "6", "60", "600", "6000", "", 0, false);
            problemes_faciles[4] = new probleme("Lionel achète un dictionnaire à 39,90 euros, un compas à 18,50 euros et trois classeurs à 2,60 euros la pièce. \nIl paie avec un billet de 100 euros. Combien lui rend-on ?", "33,80", "15,20", "25", "33,80", "66,20", 0, false);
            problemes_faciles[5] = new probleme("Le litre de super 95 coûte 1,189 euros. Combien coûte un plein de 40 litres de super 95 ?", "47,56", "25,24", "47,56", "50,78", "65,21", 0, false);
            problemes_faciles[6] = new probleme("Un pantalon coûte 80 €, il est en solde à 30% moins cher. \nCombien coûte le pantalon ?", "56", "56", "60,5", "72", "77,6", 0, false);
            problemes_faciles[7] = new probleme("Sarah a 20 billes. Son grand-frère lui en donne 4. \nSa petite sœur lui en emprunte 8. Elle gagne à un jeu 9 billes. \nCombien a-t-elle de billes maintenant ?", "29", "18", "27", "29", "32", 0, false);
            problemes_faciles[8] = new probleme("La calculatrice de Léo est vraiment en mauvais état. Les seules touches en état de marche sont 5    7     +     =. \nQuel nombre ne peut-il pas afficher ?", "16", "10", "12", "14", "16", 0, false);
            problemes_faciles[9] = new probleme("Pour l’ensemble de ses chantiers, une entreprise se fournit auprès d’un grossiste. \nLes tarifs proposés pour des paquets de 10 dalles sont 48 euros le paquet, livraison gratuite. \nQuel est le prix pour une commande de 9 paquets ?", "432 euros", "200 euros", "432 euros", "564 euros", "789 euros", 0, false);

            problemes_difficiles[0] = new probleme("Quel est l’objet qui a le plus grand volume ?", "la sphère", "le cube", "la sphère", "le cylindre", "le parallélépipède", 1, false);
            problemes_difficiles[1] = new probleme("La somme des âges de deux enfants est de 23 ans. \nSachant que le premier a 5 ans de plus que le deuxième, quel est l’âge du plus jeune?", "9 ans", "9 ans", "10 ans", "11 ans", "13 ans", 1, false);
            problemes_difficiles[2] = new probleme("Je parcours 10 mètres en 1 seconde. Quelle est ma vitesse moyenne (en km/h)?", "36", "18", "36", "40", "56", 1, false);
            problemes_difficiles[3] = new probleme("Dans ma tirelire, j’ai des pièces de 50 centimes et de 20 centimes. \nEn tout, j’ai 5 euros. Combien ai-je de pièces de 50 centimes, \nsachant que j’ai 16 pièces en tout? ", "6", "15", "10", "8", "6", 1, false);
            problemes_difficiles[4] = new probleme("Une ville compte 2000 habitants. 12% sont des enfants, 2/8 de ce qui reste sont des femmes. \nCombien y a t-il d’hommes dans la ville? ", "1200", "400", "600", "1200", "1600", 1, false);
            problemes_difficiles[5] = new probleme("Bernard, un solide constructeur de routes, a besoin de huit jours pour creuser un trou de 8x8x8 mètres. \nDe combien de jours a-t-il besoin pour creuser un trou de 4x4x4 mètres?", "1", "1", "0,5", "3", "6", 1, false);
            problemes_difficiles[6] = new probleme("Monsieur Jean possède 57 € et il veut acheter le plus d'ananas possible. \nCe jour-là les ananas coûtent 2,35 € la pièce. \nCombien d'ananas Monsieur Jean pourra-t-il acheter ?", "24", "14", "22", "24", "37", 1, false);
            problemes_difficiles[7] = new probleme("L’aire de chaque petit disque est de 2cm². Quelle est l’aire du grand disque (en cm²) ?", "72", "32", "44", "56", "72", 1, false);
            problemes_difficiles[8] = new probleme("La somme de 2 nombres est 300. \nDe combien augmente leur produit quand chaque nombre augmente de 7 ?", "2149", "50", "609", "2149", "5642", 1, false);
            problemes_difficiles[9] = new probleme("En pliant une feuille de papier en deux parties égales, dans le sens de la largeur, \nj'obtiens un rectangle de longueur 11 cm. \nL’aire de la feuille de papier est de 88 cm². \nQuelle est la largeur de la feuille de papier (en cm)?", "4", "4", "5", "6", "7", 1, false);
            
        }

        

        public probleme selectionItem()
        {
            probleme pb = new probleme();
            int numPb = 0;

            if (this.difficulte == 0)
            {
                numPb = rnd.Next(0, problemes_faciles.Length);         
                if (problemes_faciles[numPb].dejaChoisi == true)
                {
                    numPb = rnd.Next(0, problemes_faciles.Length);
                } 
                else
                {
                    problemes_faciles[numPb].dejaChoisi = true;
                    pb = problemes_faciles[numPb];
                }
                
            }
            else if (this.difficulte == 1)
            {
                numPb = rnd.Next(0, problemes_difficiles.Length);
                if (problemes_difficiles[numPb].dejaChoisi == true)
                {
                    numPb = rnd.Next(0, problemes_difficiles.Length);
                } 
                else
                {
                    problemes_difficiles[numPb].dejaChoisi = true;
                    pb = problemes_difficiles[numPb];
                }               
                
            }
            return pb;
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

        //public void deserialiserPbMaths()
        //{
        //    XDocument document = XDocument.Load("problemes_mathematiques.xml");

        //    var pbfs = document.Descendants("problemes_faciles").First();
        //    var pbf = document.Descendants("probleme");
            

        //    for (int k = 0; k < problemes_faciles.Length; k++)
        //    {               
        //        foreach (var i in pbf)
        //        {
        //            problemes_faciles[k] = new probleme(
        //                    (string)i.Descendants("enonce").First(),
        //                    (string)i.Descendants("reponse").First(),                       
        //                    (string)i.Descendants("Choix1").First(),  
        //                    (string)i.Descendants("Choix2").First(),
        //                    (string)i.Descendants("Choix3").First(),
        //                    (string)i.Descendants("Choix4").First(),
        //                    (int)i.Descendants("difficulte").First(),
        //                    (bool)i.Descendants("dejaChoisi").First());                    
        //        }

        //        var pbds = document.Descendants("problemes_difficiles").First();
        //        var pbd = document.Descendants("probleme");


        //        for (int l = 0; l < problemes_faciles.Length; l++)
        //        {
        //            foreach (var i in pbd)
        //            {
        //                problemes_difficiles[l] = new probleme(
        //                        (string)i.Descendants("enonce").First(),
        //                        (string)i.Descendants("reponse").First(),
        //                        (string)i.Descendants("Choix1").First(),
        //                        (string)i.Descendants("Choix2").First(),
        //                        (string)i.Descendants("Choix3").First(),
        //                        (string)i.Descendants("Choix4").First(),
        //                        (int)i.Descendants("difficulte").First(),
        //                        (bool)i.Descendants("dejaChoisi").First());
        //            }
                
        //        }
           // }  
        //}
    }
}
