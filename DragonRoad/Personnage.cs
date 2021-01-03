using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonRoad
{
    public class Personnage
    {   
        /********************************************************************************************************************************/
        /* Variables liées au personnage                                                                                                */
        /********************************************************************************************************************************/

        //Int
        public int staMax;
        public int regSta;
        public int tauxEsq;
        public int nivTransfo;
        public int costSpe1;
        public int costSpe2;
        public int picIndex;

        //Double
        public double multi1;
        public double multi2;
        public double pvMax;
        public double atk;
        public double coeffAtkSimple;

        //String
        public String nom;
        public String nomTransfo = String.Empty;
        public String spe1;
        public String spe2;
        public String msgTransfo;
        public String descrSpecial;

        //Mise en place des stats du personnage selectionné
        public void InitialiseStats(string charaName, int transfo)  
        {
            if (charaName == "Son Goku (GT)")
            {
                if (transfo == 0)
                {
                    nom = "Son Goku (GT)";
                    nomTransfo = String.Empty;
                    atk = 1050;
                    pvMax = 11000;
                    staMax = 65;
                    regSta = 10;
                    tauxEsq = 10;
                    spe1 = "Enchainement rapide";
                    spe2 = "Kamehameha";
                    multi1 = 1.5;
                    multi2 = 2.7;
                    costSpe1 = 15;
                    costSpe2 = 30;
                    nivTransfo = 5;
                    picIndex = 45;
                    coeffAtkSimple = 1.15;
                }
                else if (transfo == 1)
                {
                    nomTransfo = "Super Saiyan";
                    atk = 1340;
                    pvMax = 15000;
                    staMax = 90;
                    regSta = 15;
                    tauxEsq = 13;
                    spe1 = "Enchainement puissant";
                    spe2 = "Super Kamehameha";
                    multi1 = 2.8;
                    multi2 = 5;
                    costSpe1 = 30;
                    costSpe2 = 50;
                    nivTransfo = 10;
                    msgTransfo = "Ce ne sera pas aussi facile.. ! Super Saiyan !!";
                    picIndex = 46;
                    coeffAtkSimple = 1.25;
                }
                else if (transfo == 2)
                {
                    nomTransfo = "Super Saiyan 3";
                    atk = 1600;
                    pvMax = 17200;
                    staMax = 110;
                    regSta = 20;
                    tauxEsq = 16;
                    spe1 = "Kamehameha";
                    spe2 = "Poing du Dragon";
                    multi1 = 3.4;
                    multi2 = 7.2;
                    costSpe1 = 35;
                    costSpe2 = 70;
                    nivTransfo = 15;
                    msgTransfo = "Tu n'as encore rien vu... Super Saiyan 3 !";
                    picIndex = 47;
                    coeffAtkSimple = 1.35;
                }
                else
                {
                    nomTransfo = "Super Saiyan 4";
                    atk = 2110;
                    pvMax = 23000;
                    staMax = 160;
                    regSta = 25;
                    tauxEsq = 22;
                    spe1 = "Smash du Dragon";
                    spe2 = "Kamehameha x10";
                    multi1 = 3.9;
                    multi2 = 11.5;
                    costSpe1 = 35;
                    costSpe2 = 85;
                    msgTransfo = "L'évolution continue... ! Super Saiyan 4 !!";
                    picIndex = 48;
                    coeffAtkSimple = 1.5;
                }
            }
            else if (charaName == "Son Goku")
            {
                if (transfo == 0)
                {
                    nom = "Son Goku";
                    nomTransfo = String.Empty;
                    atk = 1100;
                    pvMax = 12000;
                    staMax = 70;
                    regSta = 10;
                    tauxEsq = 10;
                    spe1 = "Attaque Kaioken";
                    spe2 = "Kamehameha";
                    multi1 = 1.5;
                    multi2 = 2.7;
                    costSpe1 = 15;
                    costSpe2 = 30;
                    nivTransfo = 5;
                    picIndex = 13;
                    coeffAtkSimple = 1.15;
                }
                else if (transfo == 1)
                {
                    nomTransfo = "Super Saiyan";
                    atk = 1400;
                    pvMax = 16500;
                    staMax = 100;
                    regSta = 15;
                    tauxEsq = 15;
                    spe1 = "Combo fureur";
                    spe2 = "Super Kamehameha";
                    multi1 = 2.3;
                    multi2 = 5;
                    costSpe1 = 25;
                    costSpe2 = 50;
                    nivTransfo = 10;
                    msgTransfo = "Les choses sérieuses commencent.. ! Super Saiyan !!";
                    picIndex = 14;
                    coeffAtkSimple = 1.25;
                }
                else if (transfo == 2)
                {
                    nomTransfo = "Super Saiyan God";
                    atk = 1690;
                    pvMax = 19000;
                    staMax = 120;
                    regSta = 20;
                    tauxEsq = 18;
                    spe1 = "Restrictions divines";
                    spe2 = "Smash du Dragon";
                    multi1 = 2.9;
                    multi2 = 6.5;
                    costSpe1 = 30;
                    costSpe2 = 60;
                    nivTransfo = 15;
                    msgTransfo = "La puissance d'un Dieu... Super Saiyan God !";
                    picIndex = 15;
                    coeffAtkSimple = 1.35;
                }
                else
                {
                    nomTransfo = "Ultra Instinct";
                    atk = 2150;
                    pvMax = 20000;
                    staMax = 150;
                    regSta = 25;
                    tauxEsq = 35;
                    spe1 = "Poing jaissant";
                    spe2 = "Kamehameha suprême";
                    multi1 = 4;
                    multi2 = 10;
                    costSpe1 = 35;
                    costSpe2 = 80;
                    msgTransfo = "Au-delà de toutes les limites... Ultra Instinct.. !!";
                    picIndex = 16;
                    coeffAtkSimple = 1.5;
                }
            }
            else if (charaName == "Vegeta")
            {
                if (transfo == 0)
                {
                    nom = "Vegeta";
                    nomTransfo = String.Empty;
                    atk = 1150;
                    pvMax = 11800;
                    staMax = 80;
                    regSta = 10;
                    tauxEsq = 10;
                    spe1 = "Enchainement puissant";
                    spe2 = "Canon Garric";
                    multi1 = 1.6;
                    multi2 = 2.8;
                    costSpe1 = 20;
                    costSpe2 = 35;
                    nivTransfo = 5;
                    picIndex = 17;
                    coeffAtkSimple = 1.15;
                }
                else if (transfo == 1)
                {
                    nomTransfo = "Super Saiyan";
                    atk = 1500;
                    pvMax = 14500;
                    staMax = 110;
                    regSta = 15;
                    tauxEsq = 14;
                    spe1 = "Big Bang";
                    spe2 = "Explosion Finale";
                    multi1 = 2.6;
                    multi2 = 7;
                    costSpe1 = 25;
                    costSpe2 = 70;
                    nivTransfo = 10;
                    msgTransfo = "Tu vas le regretter.. ! Super Saiyan !!";
                    picIndex = 18;
                    coeffAtkSimple = 1.25;
                }
                else if (transfo == 2)
                {
                    nomTransfo = "Super Saiyan God";
                    atk = 1760;
                    pvMax = 18000;
                    staMax = 130;
                    regSta = 20;
                    tauxEsq = 17;
                    spe1 = "Aura écrasante";
                    spe2 = "Big Bang divin";
                    multi1 = 3.6;
                    multi2 = 7.5;
                    costSpe1 = 35;
                    costSpe2 = 70;
                    nivTransfo = 15;
                    msgTransfo = "La puissance d'un Dieu... Super Saiyan God !";
                    picIndex = 19;
                    coeffAtkSimple = 1.35;
                }
                else
                {
                    nomTransfo = "SSB Evolution";
                    atk = 1950;
                    pvMax = 21500;
                    staMax = 160;
                    regSta = 30;
                    tauxEsq = 20;
                    spe1 = "Combo pleine puissance";
                    spe2 = "Final Flash ultime";
                    multi1 = 5;
                    multi2 = 9;
                    costSpe1 = 40;
                    costSpe2 = 75;
                    msgTransfo = "Surpasser les dieux ! Super Saiyan Blue Evolution !!";
                    picIndex = 20;
                    coeffAtkSimple = 1.5;
                }
            }
            else if (charaName == "Son Gohan (Ado)")
            {
                if (transfo == 0)
                {
                    nom = "Son Gohan (Ado)";
                    nomTransfo = String.Empty;
                    atk = 1230;
                    pvMax = 11500;
                    staMax = 70;
                    regSta = 10;
                    tauxEsq = 8;
                    spe1 = "Enchainement rapide";
                    spe2 = "Masenko";
                    multi1 = 1.5;
                    multi2 = 2.9;
                    costSpe1 = 15;
                    costSpe2 = 35;
                    nivTransfo = 6;
                    picIndex = 21;
                    coeffAtkSimple = 1.15;
                }
                else if (transfo == 1)
                {
                    nomTransfo = "Super Saiyan";
                    atk = 1700;
                    pvMax = 15000;
                    staMax = 120;
                    regSta = 15;
                    tauxEsq = 12;
                    spe1 = "Enchainement puissant";
                    spe2 = "Kamehameha";
                    multi1 = 2.2;
                    multi2 = 6.2;
                    costSpe1 = 20;
                    costSpe2 = 60;
                    nivTransfo = 12;
                    msgTransfo = "Je dois... me battre.. ! Super Saiyan !!";
                    picIndex = 22;
                    coeffAtkSimple = 1.3;
                }
                else
                {
                    nomTransfo = "Super Saiyan 2";
                    atk = 2100;
                    pvMax = 20500;
                    staMax = 175;
                    regSta = 30;
                    tauxEsq = 20;
                    spe1 = "Explosion de rage";
                    spe2 = "Kamehameha Père-Fils";
                    multi1 = 4.5;
                    multi2 = 15;
                    costSpe1 = 35;
                    costSpe2 = 100;
                    msgTransfo = "Tu vas payer pour tout ce que tu as fait.. ! \nSuper Saiyan 2 !!";
                    picIndex = 23;
                    coeffAtkSimple = 1.5;
                }
            }
            else if (charaName == "Trunks (Futur)")
            {
                if (transfo == 0)
                {
                    nom = "Trunks (Futur)";
                    nomTransfo = String.Empty;
                    atk = 1180;
                    pvMax = 11200;
                    staMax = 80;
                    regSta = 15;
                    tauxEsq = 10;
                    spe1 = "Entaille rapide";
                    spe2 = "Canon Garric";
                    multi1 = 1.7;
                    multi2 = 2.7;
                    costSpe1 = 20;
                    costSpe2 = 35;
                    nivTransfo = 6;
                    picIndex = 24;
                    coeffAtkSimple = 1.15;
                }
                else if (transfo == 1)
                {
                    nomTransfo = "Super Saiyan";
                    atk = 1620;
                    pvMax = 16000;
                    staMax = 125;
                    regSta = 20;
                    tauxEsq = 14;
                    spe1 = "Slash vengeur";
                    spe2 = "Burning Attack";
                    multi1 = 2.3;
                    multi2 = 5.2;
                    costSpe1 = 25;
                    costSpe2 = 55;
                    nivTransfo = 12;
                    msgTransfo = "Je ne reculerais pas.. ! Super Saiyan !!";
                    picIndex = 25;
                    coeffAtkSimple = 1.3;
                }
                else
                {
                    nomTransfo = "Épée de l'espoir";
                    atk = 1980;
                    pvMax = 21800;
                    staMax = 180;
                    regSta = 25;
                    tauxEsq = 20;
                    spe1 = "Dome d'énergie";
                    spe2 = "Slash miraculeux";
                    multi1 = 4.7;
                    multi2 = 14;
                    costSpe1 = 35;
                    costSpe2 = 95;
                    msgTransfo = "Nous sauverons le futur... Épée de l'espoir !!";
                    picIndex = 26;
                    coeffAtkSimple = 1.5;
                }
            }
            else if (charaName == "Gotenks")
            {
                if (transfo == 0)
                {
                    nom = "Gotenks";
                    nomTransfo = String.Empty;
                    atk = 1280;
                    pvMax = 13500;
                    staMax = 70;
                    regSta = 10;
                    tauxEsq = 13;
                    spe1 = "Feinte inévitable";
                    spe2 = "Super boules d'énergie";
                    multi1 = 1.8;
                    multi2 = 2.8;
                    costSpe1 = 20;
                    costSpe2 = 30;
                    nivTransfo = 6;
                    picIndex = 27;
                    coeffAtkSimple = 1.15;
                }
                else if (transfo == 1)
                {
                    nomTransfo = "Super Saiyan";
                    atk = 1700;
                    pvMax = 18500;
                    staMax = 100;
                    regSta = 15;
                    tauxEsq = 16;
                    spe1 = "Enchainement super rapide";
                    spe2 = "Fantôme Kamikaze";
                    multi1 = 2.6;
                    multi2 = 6.1;
                    costSpe1 = 25;
                    costSpe2 = 55;
                    nivTransfo = 13;
                    msgTransfo = "Haha, tu m'as sous-estimé ! Super Saiyan !!";
                    picIndex = 28;
                    coeffAtkSimple = 1.3;
                }
                else
                {
                    nomTransfo = "Super Saiyan 3";
                    atk = 2130;
                    pvMax = 24000;
                    staMax = 160;
                    regSta = 25;
                    tauxEsq = 20;
                    spe1 = "Hurlement puissant";
                    spe2 = "Super Fantômes Kamikazes";
                    multi1 = 5.5;
                    multi2 = 11;
                    costSpe1 = 40;
                    costSpe2 = 80;
                    msgTransfo = "Agenouille-toi devant le grand Gotenks... \nSuper Saiyan 3 !!";
                    picIndex = 29;
                    coeffAtkSimple = 1.5;
                }
            }
            else if (charaName == "Son Gohan")
            {
                if (transfo == 0)
                {
                    nom = "Son Gohan";
                    nomTransfo = String.Empty;
                    atk = 1280;
                    pvMax = 11500;
                    staMax = 75;
                    regSta = 15;
                    tauxEsq = 10;
                    spe1 = "Enchainement super rapide";
                    spe2 = "Kamehameha";
                    multi1 = 1.8;
                    multi2 = 3.1;
                    costSpe1 = 20;
                    costSpe2 = 35;
                    nivTransfo = 6;
                    picIndex = 49;
                    coeffAtkSimple = 1.15;
                }
                else if (transfo == 1)
                {
                    nomTransfo = "Super Saiyan";
                    atk = 1770;
                    pvMax = 17500;
                    staMax = 130;
                    regSta = 20;
                    tauxEsq = 14;
                    spe1 = "Frappe enragée";
                    spe2 = "Super Masenko";
                    multi1 = 2.8;
                    multi2 = 7.5;
                    costSpe1 = 25;
                    costSpe2 = 60;
                    nivTransfo = 14;
                    msgTransfo = "Je dois te stopper ici.. ! Super Saiyan !!";
                    picIndex = 50;
                    coeffAtkSimple = 1.3;
                }
                else
                {
                    nomTransfo = "Potentiel libéré";
                    atk = 2150;
                    pvMax = 23200;
                    staMax = 180;
                    regSta = 30;
                    tauxEsq = 20;
                    spe1 = "Super enchainement";
                    spe2 = "Kamehameha Ultime";
                    multi1 = 4.8;
                    multi2 = 13;
                    costSpe1 = 35;
                    costSpe2 = 90;
                    msgTransfo = "Je ne te laisserai pas faire.. ! \nPotentiel libéré !!";
                    picIndex = 51;
                    coeffAtkSimple = 1.5;
                }
            }
            else if (charaName == "Broly")
            {
                if (transfo == 0)
                {
                    nom = "Broly";
                    nomTransfo = String.Empty;
                    atk = 1400;
                    pvMax = 13000;
                    staMax = 60;
                    regSta = 10;
                    tauxEsq = 5;
                    spe1 = "Charge furieuse";
                    spe2 = "Météore puissant";
                    multi1 = 1.5;
                    multi2 = 3;
                    costSpe1 = 15;
                    costSpe2 = 35;
                    nivTransfo = 4;
                    picIndex = 30;
                    coeffAtkSimple = 1.15;
                }
                else if (transfo == 1)
                {
                    nomTransfo = "Furieux";
                    atk = 1600;
                    pvMax = 15500;
                    staMax = 80;
                    regSta = 15;
                    tauxEsq = 8;
                    spe1 = "Frappe enragée";
                    spe2 = "Explosion de rage";
                    multi1 = 2;
                    multi2 = 5.2;
                    costSpe1 = 20;
                    costSpe2 = 50;
                    nivTransfo = 9;
                    msgTransfo = "Son.. Goku... Je vais te détruire.. !!";
                    picIndex = 31;
                    coeffAtkSimple = 1.25;
                }
                else if (transfo == 2)
                {
                    nomTransfo = "Super Saiyan";
                    atk = 1850;
                    pvMax = 20500;
                    staMax = 110;
                    regSta = 20;
                    tauxEsq = 12;
                    spe1 = "Smash météore";
                    spe2 = "Cataclysme";
                    multi1 = 2.9;
                    multi2 = 7.4;
                    costSpe1 = 25;
                    costSpe2 = 65;
                    nivTransfo = 15;
                    msgTransfo = "Vous.. avez osé... ! Super Saiyan !!";
                    picIndex = 32;
                    coeffAtkSimple = 1.35;
                }
                else
                {
                    nomTransfo = "Super Saiyan Légendaire";
                    atk = 2170;
                    pvMax = 24500;
                    staMax = 140;
                    regSta = 25;
                    tauxEsq = 15;
                    spe1 = "Météore géant";
                    spe2 = "Catastrophe gigantesque";
                    multi1 = 4.2;
                    multi2 = 12;
                    costSpe1 = 30;
                    costSpe2 = 90;
                    msgTransfo = "Hugh.. raaaAAGGh.. ! Super Saiyan Légendaire !!";
                    picIndex = 33;
                    coeffAtkSimple = 1.5;
                }
            }
            else if (charaName == "Goku Black")
            {
                if (transfo == 0)
                {
                    nom = "Goku Black";
                    nomTransfo = String.Empty;
                    atk = 1520;
                    pvMax = 15500;
                    staMax = 80;
                    regSta = 15;
                    tauxEsq = 10;
                    spe1 = "Boule d'énergie noire";
                    spe2 = "Black Kamehameha";
                    multi1 = 2;
                    multi2 = 2.9;
                    costSpe1 = 20;
                    costSpe2 = 35;
                    nivTransfo = 10;
                    picIndex = 34;
                    coeffAtkSimple = 1.2;
                }
                else
                {
                    nomTransfo = "Super Saiyan Rosé";
                    atk = 2080;
                    pvMax = 22500;
                    staMax = 140;
                    regSta = 25;
                    tauxEsq = 18;
                    spe1 = "Lasso Divin";
                    spe2 = "Super Kamehameha Black Rosé";
                    multi1 = 5.1;
                    multi2 = 12.2;
                    costSpe1 = 35;
                    costSpe2 = 75;
                    msgTransfo = "Eh bien.. Cette couleure, n'est-elle pas magnifique.. ? \nSuper Saiyan Rosé !!";
                    picIndex = 35;
                    coeffAtkSimple = 1.5;
                }
            }
            else if (charaName == "Vegeto")
            {
                if (transfo == 0)
                {
                    nom = "Vegeto";
                    nomTransfo = String.Empty;
                    atk = 1400;
                    pvMax = 17000;
                    staMax = 75;
                    regSta = 15;
                    tauxEsq = 10;
                    spe1 = "Super enchainement";
                    spe2 = "Épée de Vegeto";
                    multi1 = 2.1;
                    multi2 = 3.1;
                    costSpe1 = 25;
                    costSpe2 = 35;
                    nivTransfo = 6;
                    picIndex = 36;
                    coeffAtkSimple = 1.15;
                }
                else if (transfo == 1)
                {
                    nomTransfo = "Super Saiyan";
                    atk = 1750;
                    pvMax = 21000;
                    staMax = 110;
                    regSta = 25;
                    tauxEsq = 16;
                    spe1 = "Big Bang";
                    spe2 = "Super Épée de Vegeto";
                    multi1 = 3.2;
                    multi2 = 7.2;
                    costSpe1 = 30;
                    costSpe2 = 65;
                    nivTransfo = 14;
                    msgTransfo = "Fini de jouer.. ! Super Saiyan !!";
                    picIndex = 37;
                    coeffAtkSimple = 1.3;
                }
                else
                {
                    nomTransfo = "Super Saiyan Blue";
                    atk = 2200;
                    pvMax = 27000;
                    staMax = 150;
                    regSta = 30;
                    tauxEsq = 22;
                    spe1 = "Percée invincible";
                    spe2 = "Kamehameha Final";
                    multi1 = 7.5;
                    multi2 = 13.5;
                    costSpe1 = 45;
                    costSpe2 = 95;
                    msgTransfo = "Guerrier né de la plus puissante des fusions... \nVegeto Blue !!";
                    picIndex = 38;
                    coeffAtkSimple = 1.5;
                }
            }
            else if (charaName == "Gogeta")
            {
                if (transfo == 0)
                {
                    nom = "Gogeta";
                    nomTransfo = String.Empty;
                    atk = 1500;
                    pvMax = 16000;
                    staMax = 80;
                    regSta = 15;
                    tauxEsq = 10;
                    spe1 = "Danse folle";
                    spe2 = "Poussière d'étoile cosmique";
                    multi1 = 1.9;
                    multi2 = 3.5;
                    costSpe1 = 20;
                    costSpe2 = 35;
                    nivTransfo = 7;
                    picIndex = 39;
                    coeffAtkSimple = 1.15;
                }
                else if (transfo == 1)
                {
                    nomTransfo = "Super Saiyan";
                    atk = 1910;
                    pvMax = 20200;
                    staMax = 120;
                    regSta = 25;
                    tauxEsq = 16;
                    spe1 = "Danse super folle";
                    spe2 = "Pluie de poussière d'étoile";
                    multi1 = 3.8;
                    multi2 = 6;
                    costSpe1 = 35;
                    costSpe2 = 55;
                    nivTransfo = 15;
                    msgTransfo = "L'échauffement est terminé... Super Saiyan !!";
                    picIndex = 40;
                    coeffAtkSimple = 1.3;
                }
                else
                {
                    nomTransfo = "Super Saiyan Blue";
                    atk = 2350;
                    pvMax = 25800;
                    staMax = 160;
                    regSta = 30;
                    tauxEsq = 22;
                    spe1 = "Bouclier du châtiment";
                    spe2 = "Big Bang Kamehameha x100";
                    multi1 = 7;
                    multi2 = 16;
                    costSpe1 = 40;
                    costSpe2 = 110;
                    msgTransfo = "Je ne suis ni Goku ni Vegeta.. Je suis Gogeta.. Blue !!";
                    picIndex = 41;
                    coeffAtkSimple = 1.5;
                }
            }
        }

        //Fonction qui associe une description à une attaque
        public void descriptionAtk(String nomAtk)
        {
            if (nomAtk == "Attaque Kaioken")
            {
                descrSpecial = "L'utilisateur entre en Kaioken et lance\n";
                descrSpecial += "une rapide série de coups.\n";
                descrSpecial += "La puissance et la vitesse sont décuplés.";
            }
            else if (nomAtk == "Kamehameha")
            {
                descrSpecial = "Technique originale de Tortue Géniale.\n";
                descrSpecial += "Une puissante attaque d'énergie, qui sera\n";
                descrSpecial += "utilisée par Goku pour vaincre de nombreux\n";
                descrSpecial += "adversaires.";
            }
            else if (nomAtk == "Kamehameha x10")
            {
                descrSpecial = "En combinant deux Kamehameha en un seul,\n";
                descrSpecial += "sa puissance se retrouve décuplée.\n";
                descrSpecial += "Il est de couleure pourpre.";
            }
            else if (nomAtk == "Kamehameha Ultime")
            {
                descrSpecial = "Une forme avancée du Kamehameha, qui est\n";
                descrSpecial += "supportée par la puissance maximale du\n";
                descrSpecial += "potentiel libéré.";
            }
            else if (nomAtk == "Super Masenko")
            {
                descrSpecial = "Forme améliorée du Masenko, bien plus\n";
                descrSpecial += "puissante qu'auparavant.\n";
                descrSpecial += "C'est une technique plus rapide que le\n";
                descrSpecial += "Kamehameha, mais moins imposante.";
            }
            else if (nomAtk == "Poing du Dragon")
            {
                descrSpecial = "Un poing doré d'une puissance colossale,\n";
                descrSpecial += "si bien qu'un Dragon est matérialisé.\n";
                descrSpecial += "C'est une technique de dernier recours.";
            }
            else if (nomAtk == "Combo fureur")
            {
                descrSpecial = "Enragé, l'utilisateur fonce sur son\n";
                descrSpecial += "adversaire et enchaine une violente série\n";
                descrSpecial += "de coups.";
            }
            else if (nomAtk == "Super Kamehameha")
            {
                descrSpecial = "Forme améliorée du Kamehameha.\n";
                descrSpecial += "Sa puissance est bien supérieure.";
            }
            else if (nomAtk == "Restrictions divines")
            {
                descrSpecial = "L'utilisateur emprisonne l'adversaire\n";
                descrSpecial += "dans son Ki divin, le paralysant sur place.";
            }
            else if (nomAtk == "Smash du Dragon")
            {
                descrSpecial = "Par la puissance du Dragon, fonce sur\n";
                descrSpecial += "l'adversaire et lui assène un coup d'une\n";
                descrSpecial += "puissance incroyable.";
            }
            else if (nomAtk == "Poing jaissant")
            {
                descrSpecial = "L'utilisateur effectue un coup de poing,\n";
                descrSpecial += "si rapide et puissant qu'il se propage\n";
                descrSpecial += "dans l'air. Peut être envoyé à distance.";

            }
            else if (nomAtk == "Kamehameha suprême")
            {
                descrSpecial = "Un Kamehameha mêlé au Ki divin surpuissant\n";
                descrSpecial += "de son utilisateur.\n";
                descrSpecial += "C'est une vague de puissance inarrêtable.";
            }
            else if (nomAtk == "Enchainement puissant")
            {
                descrSpecial = "L'utilisateur mêle de puissants coups à sa\n";
                descrSpecial += "vitesse, créant un violent enchainement.";
            }
            else if (nomAtk == "Canon Garric")
            {
                descrSpecial = "Technique originale de Vegeta.\n";
                descrSpecial += "Puissante attaque d'énergie nécessitant\n";
                descrSpecial += "d'être chargée avant son lancement.";
            }
            else if (nomAtk == "Big Bang")
            {
                descrSpecial = "Boule d'énergie comprimée, qui déclanche\n";
                descrSpecial += "une énorme explosion lorsqu'elle touche\n";
                descrSpecial += "son adversaire.";
            }
            else if (nomAtk == "Explosion Finale")
            {
                descrSpecial = "L'utilisateur fait exploser le Ki à\n";
                descrSpecial += "l'intérieur de lui, ce qui mène à une\n";
                descrSpecial += "gigantesque explosion.";
            }
            else if (nomAtk == "Aura écrasante")
            {
                descrSpecial = "L'utilisateur déchaîne son Ki divin,\n";
                descrSpecial += "repoussant l'adversaire et l'écrasant au\n";
                descrSpecial += "sol, impuissant.";
            }
            else if (nomAtk == "Big Bang divin")
            {
                descrSpecial = "Forme améliorée du Big Bang, lorsque mêlé\n";
                descrSpecial += "à du Ki divin.\n";
                descrSpecial += "Sa puissance est colossale.";
            }
            else if (nomAtk == "Combo pleine puissance")
            {
                descrSpecial = "Une série de coups surpuissants, lancée\n";
                descrSpecial += "sans retenue par l'utilisateur.";
            }
            else if (nomAtk == "Final Flash ultime")
            {
                descrSpecial = "Forme ultime du Final Flash, lorsque\n";
                descrSpecial += "utilisée avec du Ki divin.\n";
                descrSpecial += "C'est une massive vague d'énergie destructice.";
            }
            else if (nomAtk == "Enchainement rapide")
            {
                descrSpecial = "L'utilisateur utilise sa grande vitesse pour\n";
                descrSpecial += "frapper de multiples fois l'adversaire.";
            }
            else if (nomAtk == "Masenko")
            {
                descrSpecial = "La technique originale de Son Gohan.\n";
                descrSpecial += "Une attaque d'énergie puissante et dorée,\n";
                descrSpecial += "qui rivalise presque avec le Kamehameha.";
            }
            else if (nomAtk == "Explosion de rage")
            {
                descrSpecial = "Incapable de retenir sa colère plus\n";
                descrSpecial += "longtemps, l'utilisateur laisse exploser sa\n";
                descrSpecial += "rage et crée une puissante onde de choc.";
            }
            else if (nomAtk == "Kamehameha Père-Fils")
            {
                descrSpecial = "Le plus puissant Kamehameha lancé par\n";
                descrSpecial += "Son Gohan, aidé psychologiquement par son\n";
                descrSpecial += "père afin de sauver la Terre.";
            }
            else if (nomAtk == "Entaille rapide")
            {
                descrSpecial = "L'utilisateur mêle vitesse et coups d'épée\n";
                descrSpecial += "pour asséner un combo à l'adversaire.";
            }
            else if (nomAtk == "Slash vengeur")
            {
                descrSpecial = "Un puissant coup d'épée, qui découpe\n";
                descrSpecial += "l'adversaire sans lui laisser une chance\n";
                descrSpecial += "de réagir.";
            }
            else if (nomAtk == "Burning Attack")
            {
                descrSpecial = "Technique utilisée par Trunks.\n";
                descrSpecial += "Une attaque d'energie rapide et puissante,\n";
                descrSpecial += "créé par du Ki brûlant.";
            }
            else if (nomAtk == "Dome d'énergie")
            {
                descrSpecial = "L'utilisateur envoie l'adversaire dans\n";
                descrSpecial += "les airs et lance une puissante attaque\n";
                descrSpecial += "d'énergie au dessus de lui.";
            }
            else if (nomAtk == "Slash miraculeux")
            {
                descrSpecial = "Un coup d'épée chargé d'espoir, qui saura\n";
                descrSpecial += "stoper n'importe quel ennemi du futur.";
            }
            else if (nomAtk == "Feinte inévitable")
            {
                descrSpecial = "L'utilisateur trompe l'ennemi, et en\n";
                descrSpecial += "profite pour tourner la situation en sa\n";
                descrSpecial += "faveur avec un puissant coup.";
            }
            else if (nomAtk == "Super boules d'énergie")
            {
                descrSpecial = "Une rafale d'énergie rapide, difficile\n";
                descrSpecial += "à esquiver ou à contrer.";
            }
            else if (nomAtk == "Enchainement super rapide")
            {
                descrSpecial = "Encore plus rapide, l'utilisateur utilise\n";
                descrSpecial += "sa vitesse pour surprendre l'adversaire\n";
                descrSpecial += "et lui asséner une série de coups.";
            }
            else if (nomAtk == "Fantôme Kamikaze")
            {
                descrSpecial = "L'utilisateur crée un fantôme de Ki à\n";
                descrSpecial += "son effigie, qui explosera après avoir\n";
                descrSpecial += "touché l'adversaire.";
            }
            else if (nomAtk == "Hurlement puissant")
            {
                descrSpecial = "L'utilisateur hurle de toutes ses forces,\n";
                descrSpecial += "assomant n'importe quel ennemi proche.";
            }
            else if (nomAtk == "Super Fantômes Kamikazes")
            {
                descrSpecial = "L'utilisateur crée plusieurs fantômes\n";
                descrSpecial += "kamikazes d'un seul coup, multipliant\n";
                descrSpecial += "l'efficacité de l'attaque.";
            }
            else if (nomAtk == "Charge furieuse")
            {
                descrSpecial = "L'utilisateur charge furieusement son\n";
                descrSpecial += "adversaire, ne suivant que ses instincts.";
            }
            else if (nomAtk == "Météore puissant")
            {
                descrSpecial = "Une boule d'énergie puissante, qui\n";
                descrSpecial += "déclanche une explosion lorsqu'elle\n";
                descrSpecial += "touche l'adversaire.";
            }
            else if (nomAtk == "Frappe enragée")
            {
                descrSpecial = "Un coup de poing débordant de puissance,\n";
                descrSpecial += "véritable démonstration de force.";
            }
            else if (nomAtk == "Smash météore")
            {
                descrSpecial = "L'utilisateur saisit l'adversaire pour\n";
                descrSpecial += "lui asséner un coup de poing surpuissant,\n";
                descrSpecial += "l'envoyant au loin de force.";
            }
            else if (nomAtk == "Cataclysme")
            {
                descrSpecial = "Un déchainement de puissance où le Ki\n";
                descrSpecial += "est envoyé dans toutes les directions,\n";
                descrSpecial += "n'épargnant rien ni personne.";
            }
            else if (nomAtk == "Météore géant")
            {
                descrSpecial = "L'utilisateur envoie une boule de Ki\n";
                descrSpecial += "comprimée, qui déclanche une gigantesque\n";
                descrSpecial += "explosion lorsque proche de l'adversaire.";
            }
            else if (nomAtk == "Catastrophe gigantesque")
            {
                descrSpecial = "Une vague d'énergie débordant de colère,\n";
                descrSpecial += "où l'utilisateur laisse son Ki se déchainer.";
            }
            else if (nomAtk == "Boule d'énergie noire")
            {
                descrSpecial = "Une boule d'énergie sombre, déclanchant\n";
                descrSpecial += "une terrible explosion à l'arrivée.";
            }
            else if (nomAtk == "Black Kamehameha")
            {
                descrSpecial = "Un Kamehameha mêlé au Ki divin d'un\n";
                descrSpecial += "Kaioshin maléfique.\n";
                descrSpecial += "Sa puissance est colossale.";
            }
            else if (nomAtk == "Lasso Divin")
            {
                descrSpecial = "L'utilisateur crée une lame d'énergie\n";
                descrSpecial += "sombre, et lance un enchainement\n";
                descrSpecial += "dévastateur sur l'adversaire.";
            }
            else if (nomAtk == "Super Kamehameha Black Rosé")
            {
                descrSpecial = "Forme améliorée du Kamehameha Black.\n";
                descrSpecial += "Utilisée lorsque Super Saiyan Rosé, il\n";
                descrSpecial += "est d'une puissance inimaginable.";
            }
            else if (nomAtk == "Super enchainement")
            {
                descrSpecial = "L'utilisateur effectue un puissant\n";
                descrSpecial += "combo sur l'adversaire, prouvant sa\n";
                descrSpecial += "supériorité sur tous les points.";
            }
            else if (nomAtk == "Épée de Vegeto")
            {
                descrSpecial = "L'utilisateur forme une épée de Ki\n";
                descrSpecial += "avec sa main, qui ne peut être bloquée\n";
                descrSpecial += "et inflige des dégâts immenses.";
            }
            else if (nomAtk == "Super Épée de Vegeto")
            {
                descrSpecial = "Forme améliorée de l'Épée de Vegeto.\n";
                descrSpecial += "Sa puissance et sa taille sont démesurés\n";
                descrSpecial += "lorsqu'utilisée sérieusement.";
            }
            else if (nomAtk == "Percée invincible")
            {
                descrSpecial = "L'utilisateur fonce sur l'adversaire\n";
                descrSpecial += "et déchaine une incroyable série de coups\n";
                descrSpecial += "débordants de puissance.";

            }
            else if (nomAtk == "Kamehameha Final")
            {
                descrSpecial = "Fusion du Kamehameha et du Final Flash,\n";
                descrSpecial += "cette attaque est une vague de Ki quasi-\n";
                descrSpecial += "inarrêtable. Attaque originale de Vegeto.";
            }
            else if (nomAtk == "Danse folle")
            {
                descrSpecial = "Enchainement qui ne laisse aucun répit\n";
                descrSpecial += "à l'adversaire, incapable de se défendre\n";
                descrSpecial += "dans cette tornade de coups imprévisibles.";
            }
            else if (nomAtk == "Poussière d'étoile cosmique")
            {
                descrSpecial = "Attaque de Ki pure, qui anhile toute\n";
                descrSpecial += "forme de mauvaise énergie.";
            }
            else if (nomAtk == "Danse super folle")
            {
                descrSpecial = "Forme améliorée de la danse folle,\n";
                descrSpecial += "encore plus rapide et puissante.\n";
                descrSpecial += "Une véritable tempête pour l'adversaire.";
            }
            else if (nomAtk == "Pluie de poussière d'étoile")
            {
                descrSpecial = "Véritable pluie de vagues de Ki,\n";
                descrSpecial += "dominant l'adversaire par sa puissance\n";
                descrSpecial += "de frappe.";
            }
            else if (nomAtk == "Bouclier du châtiment")
            {
                descrSpecial = "Contre à base de Ki divin, renvoyant\n";
                descrSpecial += "n'importe quelle attaque en formant\n";
                descrSpecial += "un bouclier.";
            }
            else if (nomAtk == "Big Bang Kamehameha x100")
            {
                descrSpecial = "Fusion du Kamehameha et du Big Bang,\n";
                descrSpecial += "cette attaque est une vague de Ki quasi-\n";
                descrSpecial += "inarrêtable. Attaque originale de Gogeta.";
            }
        }
    }
}
