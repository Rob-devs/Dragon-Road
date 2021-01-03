using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonRoad
{
    public class Game
    {
        /********************************************************************************************************************************/
        /* Variables liées au jeu                                                                                                       */
        /********************************************************************************************************************************/

        //Booléen
        public bool dropHaricot = false;
        public bool nivSup = false;
        public bool speAdv = false;
        public bool esquive = false;
        public bool dropDB = false;
        public bool voeuDB = false;

        //Int
        public int numCombat = 0;
        public int sta;
        public int lvl = 1;
        public int nbHaricots = 1;
        public int numTransfo = 0;
        public int numTransfoMax;
        public int difficultyCoeffXP;
        public int difficultyCoeffEsq;
        public int choixAdv1;
        public int choixAdv2;
        public int picIndexAdv;

        public int chanceUltAdv;

        public int nbDragonsBall;   

        //Double
        public double atkAdv;
        public double pv;
        public double pvAdv;
        public double pvAdvMax;
        public double xp;
        public double xpTotal;
        public double heal = 0.0;
        public double degatsPerso;
        public double degatsAdv;
        public double score;
        public double scoreMax;

        public double forceAdv1;
        public double forceAdv2;

        public double multiUltAdv;

        public double multiAtk = 1.0;
        public double multiPv = 1.0;
        public double multiXP = 1.0;
        public double multiDif = 1.0;
        public double difficultyCoeffScore;

        public double multiEnnemi1 = 1.0;
        public double multiEnnemi2 = 1.0;
        public double multiEnnemi3 = 1.0;
        public double multiEnnemi4 = 1.0;
        public double multiEnnemi5 = 1.0;
        public double multiEnnemi6 = 1.0;

        //String
        public String msgUltAdv;
        public String nomAdv;
        public String nomAdv1;
        public String nomAdv2;

        /********************************************************************************************************************************/
        /* Adversaires                                                                                                                  */
        /********************************************************************************************************************************/

        //------------- Choix de l'adversaire -------------

        //Choisit 2 adversaires distincts aléatoirement et leur attribue une force
        public void ChoixAdversaires()
        {
            int test;

            choixAdv1 = detAdversaire();
            while (detNomAdv(choixAdv1) == nomAdv)
            {
                choixAdv1 = detAdversaire();
            }
            test = detAdversaire();

            while (test == choixAdv1 || detNomAdv(test) == nomAdv)
            {
                test = detAdversaire();
            }
            choixAdv2 = test;

            forceAdv1 = detForce(choixAdv1);
            forceAdv2 = detForce(choixAdv2);

            nomAdv1 = detNomAdv(choixAdv1);
            nomAdv2 = detNomAdv(choixAdv2);
        }

        //Choisit un adversaire aléatoirement
        private int detAdversaire()
        {
            Random rdm = new Random();
            int valeur;

            if (numCombat > 25)
            {
                valeur = rdm.Next(5, 12);
            }
            else if (numCombat > 20)
            {
                valeur = rdm.Next(4, 11);
            }
            else if (numCombat > 15)
            {
                valeur = rdm.Next(3, 9);
            }
            else if (numCombat > 10)
            {
                valeur = rdm.Next(2, 8);
            }
            else if (numCombat > 5)
            {
                valeur = rdm.Next(1, 6);
            }
            else
            {
                valeur = rdm.Next(0, 5);
            }

            return valeur;
        }

        //------------- Informations sur l'adversaire -------------

        //Détermine la force d'un adversaire
        public double detForce(int adv)
        {
            double force = 0;

            if (adv == 0)
            {
                force = 120 * multiEnnemi1 * 1.15;
            }
            else if (adv == 1)
            {
                force = 150 * multiEnnemi1 * 1.15;
            }
            else if (adv == 2)
            {
                force = 170 * multiEnnemi1 * 1.15;
            }
            else if (adv == 3)
            {
                force = 160 * multiEnnemi1 * 1.15;
            }
            else if (adv == 4)
            {
                force = 250 * multiEnnemi1 * 1.15;
            }
            else if (adv == 5)
            {
                if (numCombat > 14)
                {
                    force = 1450 * multiEnnemi4 * 1.1;
                }
                else
                {
                    force = 450 * multiEnnemi2 * 1.1;
                }
            }
            else if (adv == 6)
            {
                force = 800 * multiEnnemi3 * 1.08;
            }
            else if (adv == 7)
            {
                if (numCombat > 19)
                {
                    force = 2080 * multiEnnemi5 * 1.08;
                }
                else
                {
                    force = 1000 * multiEnnemi3 * 1.08;
                }
            }
            else if (adv == 8)
            {
                force = 1300 * multiEnnemi4 * 1.07;
            }
            else if (adv == 9)
            {
                force = 2000 * multiEnnemi5 * 1.06;
            }
            else if (adv == 10)
            {
                if (numCombat > 24)
                {
                    force = 3180 * multiEnnemi6 * 1.06;
                }
                else
                {
                    force = 2200 * multiEnnemi5 * 1.06;
                }
            }
            else if (adv == 11)
            {
                force = 3000 * multiEnnemi6 * 1.05;
            }
            else
            {
                force = 5000;
            }

            return Math.Round(force);
        }

        //Détermine le nom d'un adversaire
        public string detNomAdv(int adv)
        {
            string nom = String.Empty;

            if (adv == 0)
            {
                nom = "Saibaman";
            }
            else if (adv == 1)
            {
                nom = "Yamcha";
            }
            else if (adv == 2)
            {
                nom = "Krillin";
            }
            else if (adv == 3)
            {
                nom = "Piccolo";
            }
            else if (adv == 4)
            {
                nom = "Tortue Géniale";
            }
            else if (adv == 5)
            {
                if (numCombat > 14)
                {
                    nom = "Golden Freezer";
                }
                else
                {
                    nom = "Freezer";
                }
            }
            else if (adv == 6)
            {
                nom = "Cell";
            }
            else if (adv == 7)
            {
                if (numCombat > 19)
                {
                    nom = "Cooler (Forme finale)";
                }
                else
                {
                    nom = "Cooler";
                }
            }
            else if (adv == 8)
            {
                nom = "Buu";
            }
            else if (adv == 9)
            {
                nom = "Super Janemba";
            }
            else if (adv == 10)
            {
                if (numCombat > 24)
                {
                    nom = "Zamasu fusionné";
                }
                else
                {
                    nom = "Zamasu";
                }
            }
            else if (adv == 11)
            {
                nom = "Omega Shenron";
            }
            else
            {
                nom = "Jiren";
            }

            return nom;
        }

        /********************************************************************************************************************************/
        /* Initialisations et messages                                                                                                  */
        /********************************************************************************************************************************/

        //------------- Stats adverses -------------

        //Attribution des stats adverses
        public void InitialiseStatsAdverses()
        {
            if (nomAdv == "Saibaman")
            {
                pvAdvMax = 3000 * multiEnnemi1;
                atkAdv = 850 * multiEnnemi1;
                xp = 100 * multiEnnemi1;
                chanceUltAdv = 25;
                multiUltAdv = 0;
                msgUltAdv = "Grimace";
                picIndexAdv = 0;
                score = 80;
            }
            else if (nomAdv == "Yamcha")
            {
                pvAdvMax = 3800 * multiEnnemi1;
                atkAdv = 1000 * multiEnnemi1;
                xp = 110 * multiEnnemi1;
                chanceUltAdv = 35;
                multiUltAdv = 1.5;
                msgUltAdv = "Technique du Loup";
                picIndexAdv = 1;
                score = 110;
            }
            else if (nomAdv == "Krillin")
            {
                pvAdvMax = 4000 * multiEnnemi1;
                atkAdv = 1100 * multiEnnemi1;
                xp = 140 * multiEnnemi1;
                chanceUltAdv = 40;
                multiUltAdv = 1.4;
                msgUltAdv = "Kienzan";
                picIndexAdv = 2;
                score = 125;
            }
            else if (nomAdv == "Piccolo")
            {
                pvAdvMax = 4800 * multiEnnemi1;
                atkAdv = 1100 * multiEnnemi1;
                xp = 120 * multiEnnemi1;
                chanceUltAdv = 20;
                multiUltAdv = 2;
                msgUltAdv = "Makankosappo";
                picIndexAdv = 3;
                score = 135;
            }
            else if (nomAdv == "Tortue Géniale")
            {
                pvAdvMax = 5200 * multiEnnemi1;
                atkAdv = 1250 * multiEnnemi1;
                xp = 200 * multiEnnemi1;
                chanceUltAdv = 25;
                multiUltAdv = 2;
                msgUltAdv = "Kamehameha";
                picIndexAdv = 4;
                score = 165;
            }
            else if (nomAdv == "Freezer")
            {
                pvAdvMax = 7000 * multiEnnemi2;
                atkAdv = 1800 * multiEnnemi2;
                xp = 440 * multiEnnemi2;
                chanceUltAdv = 25;
                multiUltAdv = 2.3;
                msgUltAdv = "Boule de la Mort";
                picIndexAdv = 5;
                score = 225;
            }
            else if (nomAdv == "Cell")
            {
                pvAdvMax = 14000 * multiEnnemi3;
                atkAdv = 2300 * multiEnnemi3;
                xp = 850 * multiEnnemi3;
                chanceUltAdv = 20;
                multiUltAdv = 3;
                msgUltAdv = "Kamehameha Solaire";
                picIndexAdv = 6;
                score = 315;
            }
            else if (nomAdv == "Cooler")
            {
                pvAdvMax = 14500 * multiEnnemi3;
                atkAdv = 2600 * multiEnnemi3;
                xp = 1100 * multiEnnemi3;
                chanceUltAdv = 20;
                multiUltAdv = 3.3;
                msgUltAdv = "Rayon de la Mort";
                picIndexAdv = 7;
                score = 325;
            }
            else if (nomAdv == "Buu")
            {
                pvAdvMax = 19000 * multiEnnemi4;
                atkAdv = 3000 * multiEnnemi4;
                xp = 1350 * multiEnnemi4;
                chanceUltAdv = 30;
                multiUltAdv = 2.4;
                msgUltAdv = "Rugissement monstrueux";
                picIndexAdv = 8;
                score = 405;
            }
            else if (nomAdv == "Golden Freezer")
            {
                pvAdvMax = 16200 * multiEnnemi4;
                atkAdv = 3600 * multiEnnemi4;
                xp = 1700 * multiEnnemi4;
                chanceUltAdv = 35;
                multiUltAdv = 2.3;
                msgUltAdv = "Vague de la Mort";
                picIndexAdv = 42;
                score = 420;
            }
            else if (nomAdv == "Super Janemba")
            {
                pvAdvMax = 26000 * multiEnnemi5;
                atkAdv = 4500 * multiEnnemi5;
                xp = 2000 * multiEnnemi5;
                chanceUltAdv = 40;
                multiUltAdv = 2;
                msgUltAdv = "Pluie foudroyante";
                picIndexAdv = 9;
                score = 475;
            }
            else if (nomAdv == "Zamasu")
            {
                pvAdvMax = 27000 * multiEnnemi5;
                atkAdv = 5800 * multiEnnemi5;
                xp = 2800 * multiEnnemi5;
                chanceUltAdv = 30;
                multiUltAdv = 2.7;
                msgUltAdv = "Coupe Divine";
                picIndexAdv = 10;
                score = 490;
            }
            else if (nomAdv == "Cooler (Forme finale)")
            {
                pvAdvMax = 30000 * multiEnnemi5;
                atkAdv = 6100 * multiEnnemi5;
                xp = 3100 * multiEnnemi5;
                chanceUltAdv = 25;
                multiUltAdv = 3.2;
                msgUltAdv = "Supernova";
                picIndexAdv = 43;
                score = 500;
            }
            else if (nomAdv == "Omega Shenron")
            {
                pvAdvMax = 35000 * multiEnnemi6;
                atkAdv = 7000 * multiEnnemi6;
                xp = 3400 * multiEnnemi6;
                chanceUltAdv = 25;
                multiUltAdv = 3;
                msgUltAdv = "Boule d'énergie Négative";
                picIndexAdv = 11;
                score = 565;
            }
            else if (nomAdv == "Zamasu fusionné")
            {
                pvAdvMax = 40000 * multiEnnemi6;
                atkAdv = 7100 * multiEnnemi6;
                xp = 4200 * multiEnnemi6;
                chanceUltAdv = 35;
                multiUltAdv = 2.4;
                msgUltAdv = "Lames du jugement";
                picIndexAdv = 44;
                score = 580;
            }
            else if (nomAdv == "Jiren")
            {
                pvAdvMax = 70000;
                atkAdv = 12000;
                xp = 0;
                chanceUltAdv = 15;
                multiUltAdv = 5;
                msgUltAdv = "Déferlante de Justice absolue";
                picIndexAdv = 12;
                score = 700;
            }
            pvAdv = pvAdvMax;
        }

        //Augmentation des multiplicateurs ennemis
        public void InitialiseMultiEnnemis()
        {
            multiEnnemi1 *= 1.08 * multiDif;
            if (numCombat > 4)
            {
                multiEnnemi2 *= 1.075 * multiDif;
            }
            if (numCombat > 9)
            {
                multiEnnemi3 *= 1.07 * multiDif;
            }
            if (numCombat > 14)
            {
                multiEnnemi4 *= 1.065 * multiDif;
            }
            if (numCombat > 19)
            {
                multiEnnemi5 *= 1.06 * multiDif;
            }
            if (numCombat > 24)
            {
                multiEnnemi6 *= 1.06 * multiDif;
            }
        }

        //------------- Messages -------------

        //Renvoie un message de fin de combat
        public string WinMessage()
        {
            string message = String.Empty;

            if (numCombat == 5)
            {
                message = "Vous avez vaincu le grand Freezer !";
            }
            else if (numCombat == 10)
            {
                message = "Vous avez vaincu le terrible Cell !";
            }
            else if (numCombat == 15)
            {
                message = "Vous avez vaincu le terrifiant Buu !";
            }
            else if (numCombat == 20)
            {
                message = "Vous avez vaincu le puissant Janemba !";
            }
            else if (numCombat == 25)
            {
                message = "Vous avez vaincu le surpuissant \nOmega Shenron !";
            }
            else
            {
                message = "Adversaire vaincu !";
            }

            return message;
        }

        //Renvoie un message bonus en fonction de l'adversaire
        public string BonusMessage()
        {
            string message = String.Empty;

            if (dropHaricot)
            {
                message = "Vous avez obtenu un Haricot Senzu !";
            }
            else if (nomAdv == "Tortue Géniale")
            {
                message = "L'entrainement avec Tortue Géniale vous reviguore !\n";
                message += "(25% des PV restaurés)";
                heal = 0.15;
            }
            else if (nomAdv == "Yamcha")
            {
                message = "Yamcha est sympa !\n";
                message += "(30% des PV restaurés)";
                heal = 0.2;
            }
            else if (nomAdv == "Krillin")
            {
                message = "Krillin vous offre du lait !\n";
                message += "(20% des PV restaurés)";
                heal = 0.1;
            }

            return message;
        }
    }
}
