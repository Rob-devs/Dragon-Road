using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonRoad
{
    class Music
    {
        /********************************************************************************************************************************/
        /* Variables liées à la musique                                                                                                 */
        /********************************************************************************************************************************/

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        Random rdm = new Random();

        //Int
        public int numeroMusic = 0;
        public int indiceMusic = 12;
        public int[] tabNum = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

        //String
        public string nomMusic;

        /********************************************************************************************************************************/
        /* Fonctions                                                                                                                    */
        /********************************************************************************************************************************/

        //Actualise la musique en fonction du numéro
        public void actualiseMusic()
        {
            if (numeroMusic == 0)
            {
                player.SoundLocation = "Become Villanious.wav";
                nomMusic = "Become Villanious";
            }
            else if (numeroMusic == 1)
            {
                player.SoundLocation = "Beyond the Limit.wav";
                nomMusic = "Beyond the Limit";
            }
            else if (numeroMusic == 2)
            {
                player.SoundLocation = "Blizzard.wav";
                nomMusic = "Blizzard";
            }
            else if (numeroMusic == 3)
            {
                player.SoundLocation = "Clash of Gods.wav";
                nomMusic = "Clash of Gods";
            }
            else if (numeroMusic == 4)
            {
                player.SoundLocation = "Genkidama.wav";
                nomMusic = "Genkidama";
            }
            else if (numeroMusic == 5)
            {
                player.SoundLocation = "Gogeta vs Broly.wav";
                nomMusic = "Gogeta vs Broly";
            }
            else if (numeroMusic == 6)
            {
                player.SoundLocation = "Makafushigi Adventure.wav";
                nomMusic = "Makafushigi Adventure";
            }
            else if (numeroMusic == 7)
            {
                player.SoundLocation = "Solid State Scouter.wav";
                nomMusic = "Solid State Scouter";
            }
            else if (numeroMusic == 8)
            {
                player.SoundLocation = "Super Survivor.wav";
                nomMusic = "Super Survivor";
            }
            else if (numeroMusic == 9)
            {
                player.SoundLocation = "Ultimate Battle.wav";
                nomMusic = "Ultimate Battle";
            }
            else if (numeroMusic == 10)
            {
                player.SoundLocation = "Vegito Blue theme.wav";
                nomMusic = "Vegito Blue theme";
            }
            else
            {
                player.SoundLocation = "Wild Soul.wav";
                nomMusic = "Wild soul";
            }
        }

        //Lance la musique
        public void start()
        {
            player.PlayLooping();
        }

        //Stop la musique
        public void stop()
        {
            player.Stop();
        }

        //Change les numéros aléatoirement
        public void randomizeTab()
        {
            //Variables locales
            int valStocke;
            int newIndice;

            //Pour toutes les valeurs du tableau
            for (int i = 0; i < tabNum.Length; i++)
            {
                //Détermination d'un autre indice que i
                newIndice = rdm.Next(0, 12);
                while (newIndice == i)
                {
                    newIndice = rdm.Next(0, 12);
                }

                //Échange des valeurs du tableau
                valStocke = tabNum[newIndice];
                tabNum[newIndice] = tabNum[i];
                tabNum[i] = valStocke;
            }
        }
    }
}
