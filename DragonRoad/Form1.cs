using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
//Dragon Road : Jeu de mini-combats où un personnage parmis 9 choix est contrôlé

namespace DragonRoad
{
    public partial class frmDepart : Form
    {
        /********************************************************************************************************************************/
        /* Classes et variables générales                                                                                               */
        /********************************************************************************************************************************/

        //Classes
        Random rdm = new Random();
        Personnage perso = new Personnage();
        Game game = new Game();
        Music music = new Music();

        /********************************************************************************************************************************/
        /* Lancement et fermeture de l'application                                                                                      */
        /********************************************************************************************************************************/

        //Au lancement de l'application
        public frmDepart()
        {
            //Réglages
            InitializeComponent();
            DoubleBuffered = true;

            rdbDif3.Checked = true;

            //Initialisations
            lblMsgBonus.Text = String.Empty;
            lblTransfo.Text = String.Empty;

            //Numéro de la version
            lblVersion.Text = "Version 1.0";
            lblVersion.Visible = true;

            //Mise en place des Dragon Balls
            picBoxDB1.Image = imgListDB.Images[0];
            picBoxDB2.Image = imgListDB.Images[1];
            picBoxDB3.Image = imgListDB.Images[2];
            picBoxDB4.Image = imgListDB.Images[3];
            picBoxDB5.Image = imgListDB.Images[4];
            picBoxDB6.Image = imgListDB.Images[5];
            picBoxDB7.Image = imgListDB.Images[6];
        }


        //Bouton de fermeture de l'application
        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            //Demande de fermeture par message box
            string message = "Voulez-vous quitter le jeu ?";
            string title = "Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                //Fermeture de la fenêtre
                Application.Exit();
            }
        }

        /********************************************************************************************************************************/
        /* Musique                                                                                                                      */
        /********************************************************************************************************************************/

        //Bouton qui change la musique aléatoirement
        private void BtnMusic_Click(object sender, EventArgs e)
        {
            //Si la suite est terminée
            if (music.indiceMusic == 12)
            {
                //Mélange de la liste
                music.randomizeTab();
                music.indiceMusic = 0;

                //Suppression des doublons
                if (music.tabNum[0] == music.numeroMusic)
                {
                    music.indiceMusic++;
                }
            }

            //Actualisation de la musique
            music.numeroMusic = music.tabNum[music.indiceMusic];
            music.actualiseMusic();
            music.start();
            txtNomMusic.Text = "Musique : " + music.nomMusic;
            txtNomMusic.Visible = true;

            //Incrémentation du compteur
            music.indiceMusic++;
        }

        //Bouton qui stoppe la musique
        private void BtnMusicStop_Click(object sender, EventArgs e)
        {
            txtNomMusic.Visible = false;
            music.stop();
        }

        /********************************************************************************************************************************/
        /* Choix du personnage                                                                                                          */
        /********************************************************************************************************************************/

        //------------- Choix dans une liste -------------

        //Liste des personnages disponibles et choix du joueur
        private void lstPerso_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStart.BackColor = Color.White;

            int indice = 0;
            if ((String)lstPerso.SelectedItem == "Son Goku (GT)")
            {
                indice = 0;
            }
            else if ((String)lstPerso.SelectedItem == "Son Goku")
            {
                indice = 1;
            }
            else if ((String)lstPerso.SelectedItem == "Vegeta")
            {
                indice = 2;
            }
            else if ((String)lstPerso.SelectedItem == "Son Gohan (Ado)")
            {
                indice = 3;
            }
            else if ((String)lstPerso.SelectedItem == "Trunks (Futur)")
            {
                indice = 4;
            }
            else if ((String)lstPerso.SelectedItem == "Gotenks")
            {
                indice = 5;
            }
            else if ((String)lstPerso.SelectedItem == "Son Gohan")
            {
                indice = 6;
            }
            else if ((String)lstPerso.SelectedItem == "Broly")
            {
                indice = 7;
            }
            else if ((String)lstPerso.SelectedItem == "Goku Black")
            {
                indice = 8;
            }
            else if ((String)lstPerso.SelectedItem == "Vegeto")
            {
                indice = 9;
            }
            else if ((String)lstPerso.SelectedItem == "Gogeta")
            {
                indice = 10;
            }
            picBoxChara.Image = imgListStart.Images[indice];
            picBoxChara.Visible = true;

            InitialisePuissance(indice);
        }

        //------------- Bouton random -------------

        //Bouton qui choisit un personnage aléatoirement
        private void BtnRandomChoice_Click(object sender, EventArgs e)
        {
            int choix = rdm.Next(0, 11);
            while (choix == lstPerso.SelectedIndex)
            {
                choix = rdm.Next(0, 11);
            }
            lstPerso.SelectedIndex = choix;

            picBoxChara.Image = imgListStart.Images[choix];
            picBoxChara.Visible = true;

            InitialisePuissance(choix);
        }

        //------------- Initialisations -------------

        //Initialisation et affichage de la puissance du personnage selectionné
        private void InitialisePuissance(int perso)
        {
            if (perso < 3)
            {
                lblPuissance.Text = "Puissance : 500";
            }
            else if (perso < 5)
            {
                lblPuissance.Text = "Puissance : 510";
            }
            else if (perso == 5)
            {
                lblPuissance.Text = "Puissance : 550";
            }
            else if (perso == 6)
            {
                lblPuissance.Text = "Puissance : 570";
            }
            else if (perso == 7)
            {
                lblPuissance.Text = "Puissance : 580";
            }
            else if (perso == 8)
            {
                lblPuissance.Text = "Puissance : 610";
            }
            else if (perso == 9)
            {
                lblPuissance.Text = "Puissance : 640";
            }
            else if (perso == 10)
            {
                lblPuissance.Text = "Puissance : 650";
            }

            lblPuissance.Visible = true;
        }

        /********************************************************************************************************************************/
        /* Début de la partie                                                                                                           */
        /********************************************************************************************************************************/

        //------------- Bouton start -------------

        //Bouton de lancement de la partie
        private void BtnStart_Click(object sender, EventArgs e)
        {
            //On cache le menu précédent
            lblPuissance.Visible = false;
            grpChoixPerso.Visible = false;
            grpRules.Visible = false;
            grpDif.Visible = false;
            btnStart.Visible = false;
            picBoxChara.Visible = false;

            //Initialisations
            //Stats du joueur
            perso.InitialiseStats((String)lstPerso.SelectedItem, game.numTransfo);
            InitialiseTransfoMax();
            game.pv = perso.pvMax * game.multiPv;
            game.sta = perso.staMax;
            game.nbDragonsBall = 0;
            game.scoreMax = 0;
            //Difficulté
            MultiDifficulty();

            //Affichage du menu suivant
            RecapInfos();

            //Adversaires à choisir
            detAdversaires();

            grpChoixEnnemi.Visible = true;
            btnCombattre.Visible = true;

            btnReset.Visible = true;
        }

        //------------- Initialisations -------------

        //Réglagle du multiplicateur pour la difficulté
        private void MultiDifficulty()
        {
            if (rdbDif1.Checked)
            {
                game.multiDif = 0.94;
                game.difficultyCoeffXP = 0;
                game.difficultyCoeffEsq = 3;
                game.difficultyCoeffScore = 0.7;
            }
            else if (rdbDif2.Checked)
            {
                game.multiDif = 0.97;
                game.difficultyCoeffXP = 14;
                game.difficultyCoeffEsq = 2;
                game.difficultyCoeffScore = 0.85;
            }
            else if (rdbDif3.Checked)
            {
                game.multiDif = 1.0;
                game.difficultyCoeffXP = 32;
                game.difficultyCoeffEsq = 0;
                game.difficultyCoeffScore = 1.0;
            }
            else if (rdbDif4.Checked)
            {
                game.multiDif = 1.03;
                game.difficultyCoeffXP = 56;
                game.difficultyCoeffEsq = -2;
                game.difficultyCoeffScore = 1.15;
            }
            else
            {
                game.multiDif = 1.06;
                game.difficultyCoeffXP = 80;
                game.difficultyCoeffEsq = -3;
                game.difficultyCoeffScore = 1.3;
            }
        }

        //Initialise le nombre de transformations maximum en fonction du personnage
        private void InitialiseTransfoMax()
        {
            //Si Goku, Goku GT, Vegata ou Broly
            if (lstPerso.SelectedIndex < 3 || lstPerso.SelectedIndex == 7)
            {
                //3 transformations
                game.numTransfoMax = 3;
            }
            //Sinon, si Goku Black
            else if (lstPerso.SelectedIndex == 8)
            {
                //1 transformation
                game.numTransfoMax = 1;
            }
            //Sinon
            else
            {
                //2 transformations
                game.numTransfoMax = 2;
            }
        }

        /********************************************************************************************************************************/
        /* Menu du choix de l'adversaire                                                                                                */
        /********************************************************************************************************************************/

        //------------- Récapitulatif -------------

        //Affichage des informations post-combat
        private void RecapInfos()
        {
            grpRecapInfos.Visible = true;

            picCharaInfos.Image = imgListOther.Images[perso.picIndex];
            lblInfoNiveau.Text = "Niveau " + game.lvl;

            //Drop de Dragon Ball
            if (game.dropDB)
            {
                lblDB.Visible = true;
                game.dropDB = false;
            }

            //A partir du premier combat
            if (game.numCombat != 0)
            {
                //Affichage du numéro de combat, du message de victoire et du message bonus
                lblNumCombat.Text = "Combat n°" + game.numCombat;
                lblNumCombat.Visible = true;

                lblAdversaireVaincu.Text = game.WinMessage();
                lblAdversaireVaincu.Visible = true;

                lblMsgBonus.Text = game.BonusMessage();
                lblMsgBonus.Visible = true;

                //Affichage des Dragon Balls
                if (!game.voeuDB)
                {
                    afficheDB();
                }
                
                //Si le joueur a gagné un niveau
                if (game.nivSup)
                {
                    //Affichage de 'niveau supérieur'
                    lblNiveauSup.Visible = true;
                }
                game.nivSup = false;

                //Affichage de l'XP obtenu
                lblXp.Text = "XP obtenu : " + Math.Round(game.xp);
                lblXp.Visible = true;

                //Affichage d'un message de transformation si besoin
                lblTransfo.Text = perso.msgTransfo;
            }
            //Avant le premier combat
            else
            {
                lblAdversaireVaincu.Text = "C'est ici que les informations concernant tes\n";
                lblAdversaireVaincu.Text += "combats seront affichées.\n";
                lblAdversaireVaincu.Text += "Commence par choisir un adversaire !\n";
            }
        }

        //------------- Adversaire suivant -------------

        //Effectue le choix de ou des adversaires en fonction du niveau
        private void detAdversaires()
        {
            if ((game.numCombat + 1) % 5 != 0)
            {
                game.ChoixAdversaires();
                lstChoixEnnemi.Items.Add(game.nomAdv1);
                lstChoixEnnemi.Items.Add(game.nomAdv2);
            }
            else
            {
                if ((game.numCombat + 1) == 5)
                {
                    game.choixAdv1 = 5;
                }
                else if ((game.numCombat + 1) == 10)
                {
                    game.choixAdv1 = 6;
                }
                else if ((game.numCombat + 1) == 15)
                {
                    game.choixAdv1 = 8;
                }
                else if ((game.numCombat + 1) == 20)
                {
                    game.choixAdv1 = 9;
                }
                else if ((game.numCombat + 1) == 25)
                {
                    game.choixAdv1 = 11;
                }
                else
                {
                    game.choixAdv1 = 12;
                }
                game.nomAdv = game.detNomAdv(game.choixAdv1);
                game.forceAdv1 = game.detForce(game.choixAdv1);

                game.picIndexAdv = game.choixAdv1;

                lstChoixEnnemi.Items.Add(game.nomAdv);
                lstChoixEnnemi.SelectedIndex = 0;
            }
        }

        //Affichage de l'image adverse
        private void LstChoixEnnemi_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCombattre.Enabled = true;
            btnCombattre.BackColor = Color.White;

            if (lstChoixEnnemi.SelectedIndex == 0)
            {
                game.nomAdv = game.detNomAdv(game.choixAdv1);
                lblForceEnnemi.Text = "Force : " + game.forceAdv1;
            }
            else
            {
                game.nomAdv = game.detNomAdv(game.choixAdv2);
                lblForceEnnemi.Text = "Force : " + game.forceAdv2;
            }
            lblForceEnnemi.Visible = true;

            game.InitialiseStatsAdverses();

            picBoxEnnemi.Image = imgListOther.Images[game.picIndexAdv];
            picBoxEnnemi.Visible = true;
        }

        //------------- Bouton combattre -------------

        //Lance un combat
        private void BtnCombattre_Click(object sender, EventArgs e) 
        {
            //Clear du menu précédent
            btnCombattre.Visible = false;
            grpRecapInfos.Visible = false;
            grpChoixEnnemi.Visible = false;
            picBoxEnnemi.Visible = false;
            lblForceEnnemi.Visible = false;
            lblNiveauSup.Visible = false;
            lblDB.Visible = false;
            btnShenron.Visible = false;

            btnCombattre.BackColor = Color.Gray;

            clearDB();

            //Initialisation des stats adverses
            if (lstChoixEnnemi.SelectedIndex == 0 && lstChoixEnnemi.Items.Count > 1)
            {
                game.nomAdv = game.nomAdv1;
            }
            else if (lstChoixEnnemi.Items.Count > 1)
            {
                game.nomAdv = game.nomAdv2;
            }
            game.InitialiseStatsAdverses();

            //Changement du fond de combat
            changeFond();

            //Affichage du menu de combat
            lblPersoAtk.Visible = false;
            lblPersoDegats.Visible = false;
            lblAdvAtk.Visible = false;
            lblAdvDegats.Visible = false;
            lblEsquive.Visible = false;

            grpInfosCombat.Visible = true;
            btnAtkSimple.Visible = true;

            //Boutons
            btnSpe1.Text = "Coût : " + perso.costSpe1 + " - " + perso.spe1;
            btnSpe2.Text = "Coût : " + perso.costSpe2 + " - " + perso.spe2;
            btnSpe1.Visible = true;
            btnSpe2.Visible = true;
            btnHaricot.Visible = true;

            //Autres informations
            lblSta.Text = "Stamina : " + game.sta + " / " + perso.staMax + "\n";
            lblSta.Text += "(Régénération de " + perso.regSta + " par tour)";
            lblHaricotsRestants.Text = "Haricots restants : " + game.nbHaricots;
            grpInfosAutres.Visible = true;
            //Dragon Balls
            if (!game.voeuDB)
            {
                lblNbDB.Text = "Dragon Balls : " + game.nbDragonsBall + " / 7";
            }
            else
            {
                lblNbDB.Text = String.Empty;
            }

            //Nom du personnage et de l'adversaire
            lblNomPersonnage.Text = perso.nom;
            if (game.numTransfo > 0)
            {
                lblNomPersonnage.Text += " (" + perso.nomTransfo + ")";
            }
            lblNomAdversaire.Text = game.nomAdv;

            lblNomPersonnage.Visible = true;
            lblNomAdversaire.Visible = true;

            //PV
            lblPvPerso.Text = "PV : " + Math.Round(game.pv).ToString() + " / " + Math.Round(perso.pvMax * game.multiPv).ToString();
            lblPvPerso.Visible = true;
            lblPvAdv.Text = "PV : " + Math.Round(game.pvAdv).ToString() + " / " + Math.Round(game.pvAdvMax).ToString();
            lblPvAdv.Visible = true;

            //Actualisation de la barre de vie du joueur
            picBoxHealthBar1_2.Width = (int)(game.pv / (perso.pvMax * game.multiPv) * 200);
            picBoxHealthBar1_2.Left = 520 + (200 - picBoxHealthBar1_2.Width);
            picBoxHealthBar1_2.Visible = true;
            picBoxHealthBar1_1.Visible = true;

            //Actualisation de la barre de vie adverse
            picBoxHealthBar2_2.Width = 200;
            picBoxHealthBar2_2.Visible = true;
            picBoxHealthBar2_1.Visible = true;

            //Vérification logiques
            VerifBarres();
            VerifStamina();

            //Gestion du bouton Haricot senzu
            if ((game.pv < perso.pvMax * game.multiPv || game.sta < perso.staMax) && game.nbHaricots > 0)
            {
                btnHaricot.Enabled = true;
                btnHaricot.BackColor = Color.PaleGreen;
            }
            else
            {
                btnHaricot.Enabled = false;
                btnHaricot.BackColor = Color.Gray;
            }

            //Affichage des icones des personnages
            picBoxDroite.Image = imgListOther.Images[game.picIndexAdv];
            picBoxGauche.Image = imgListOther.Images[perso.picIndex];
            picBoxDroite.Visible = true;
            picBoxGauche.Visible = true;
        }

        //------------- Dragon Balls -------------

        //Affiche les Dragon Balls
        private void afficheDB()
        {
            if (game.nbDragonsBall > 0)
            {
                picBoxDB1.Visible = true;
                if (game.nbDragonsBall > 1)
                {
                    picBoxDB2.Visible = true;
                    if (game.nbDragonsBall > 2)
                    {
                        picBoxDB3.Visible = true;
                        if (game.nbDragonsBall > 3)
                        {
                            picBoxDB4.Visible = true;
                            if (game.nbDragonsBall > 4)
                            {
                                picBoxDB5.Visible = true;
                                if (game.nbDragonsBall > 5)
                                {
                                    picBoxDB6.Visible = true;
                                    if (game.nbDragonsBall > 6)
                                    {
                                        picBoxDB7.Visible = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        //Clear les Dragon Balls
        private void clearDB()
        {
            picBoxDB1.Visible = false;
            picBoxDB2.Visible = false;
            picBoxDB3.Visible = false;
            picBoxDB4.Visible = false;
            picBoxDB5.Visible = false;
            picBoxDB6.Visible = false;
            picBoxDB7.Visible = false;
        }

        /********************************************************************************************************************************/
        /* Menu de combat                                                                                                               */
        /********************************************************************************************************************************/

        //------------- Boutons -------------

        //Clique sur attaque simple
        private void BtnAtkSimple_Click(object sender, EventArgs e)
        {
            //Attaque
            attaquePerso(1);

            //Informations de combat actualisés
            InitialiseInfosCombat(1);
        }

        //Clique sur le premier spécial
        private void BtnSpe1_Click(object sender, EventArgs e)
        {
            //Attaque
            attaquePerso(2);

            //Informations de combat actualisés
            InitialiseInfosCombat(2);
        }

        //Clique sur le second spécial
        private void BtnSpe2_Click(object sender, EventArgs e)
        {
            //Attaque
            attaquePerso(3);

            //Informations de combat actualisés
            InitialiseInfosCombat(3);
        }

        //Clique sur le haricot senzu
        private void BtnHaricot_Click(object sender, EventArgs e)
        {
            //Utilisation d'un haricot senzu
            game.pv = perso.pvMax * game.multiPv;
            game.sta += 2 * perso.regSta;
            game.nbHaricots--;
            game.scoreMax *= 0.9;

            //Informations de combat actualisés
            InitialiseInfosCombat(0);

            //Actualisation de la barre de vie
            picBoxHealthBar1_2.Width = 200;
            picBoxHealthBar1_2.Left = 520;

            VerifBarres();
            VerifStamina();

            lblPvPerso.Text = "PV : " + Math.Round(game.pv).ToString() + " / " + Math.Round(perso.pvMax * game.multiPv).ToString();

            //Gestion du bouton Haricot senzu
            if ((game.pv < perso.pvMax * game.multiPv || game.sta < perso.staMax) && game.nbHaricots > 0)
            {
                btnHaricot.Enabled = true;
                btnHaricot.BackColor = Color.PaleGreen;
            }
            else
            {
                btnHaricot.Enabled = false;
                btnHaricot.BackColor = Color.Gray;
            }

            lblSta.Text = "Stamina : " + game.sta + " / " + perso.staMax + "\n";
            lblHaricotsRestants.Text = "Haricots restants : " + game.nbHaricots;
        }

        //------------- Attaques -------------

        //Attaque du joueur sur l'ennemi
        private void attaquePerso(int click)
        {
            //Attaque
            if (click == 1)
            {
                game.degatsPerso = critique(perso.atk * game.multiAtk * perso.coeffAtkSimple);
            }
            else if (click == 2)
            {
                game.degatsPerso = critique(perso.atk * game.multiAtk * perso.multi1);
                game.sta -= perso.costSpe1;
            }
            else
            {
                game.degatsPerso = critique(perso.atk * game.multiAtk * perso.multi2);
                game.sta -= perso.costSpe2;
            }
            game.pvAdv -= game.degatsPerso;

            //Actualisation de la barre de vie adverse
            picBoxHealthBar2_2.Width = (int)(game.pvAdv / game.pvAdvMax * 200);

            //Évaluation des pv adverses restants
            if (game.pvAdv <= 0)
            {
                finCombat(click);
            }
            else
            {
                //Régénération de stamina
                game.sta += perso.regSta;

                //Attaque adverse
                attaqueEnnemi();

                //Actualisation de la barre de vie du joueur
                picBoxHealthBar1_2.Width = (int)(game.pv / (perso.pvMax * game.multiPv) * 200);
                picBoxHealthBar1_2.Left = 520 + (200 - picBoxHealthBar1_2.Width);

                if (game.pv <= 0)
                {
                    defaite();
                }
            }
        }

        //Attaque de l'ennemi sur le joueur
        private void attaqueEnnemi()
        {
            Random rdm = new Random();

            game.speAdv = false;
            game.esquive = false;

            //Calcul des degats
            if (rdm.Next(1, 101) <= game.chanceUltAdv)
            {
                game.degatsAdv = game.atkAdv * game.multiUltAdv;
                game.speAdv = true;
            }
            else
            {
                game.degatsAdv = game.atkAdv;
            }

            //Chance d'esquive du joueur
            if (rdm.Next(1, 101) <= (perso.tauxEsq + game.difficultyCoeffEsq))
            {
                game.degatsAdv = 0;
                game.esquive = true;
            }

            game.pv -= game.degatsAdv;
        }

        //Gestion du coup critique
        private double critique(double degats)
        {
            lblCrit.Visible = false;
            double degatsCrit;

            //Si coup critique
            if (rdm.Next(1,101) <= 15)
            {
                //Multiplication des dégâts
                degatsCrit = 1.5 * degats;

                //Affichage du message 'coup critique'
                lblCrit.Visible = true;
            }
            //Sinon, ne fait rien
            else
            {
                degatsCrit = degats;
            }

            return degatsCrit;
        }

        //------------- Initialisations -------------

        //Actualisation des informations de combat
        private void InitialiseInfosCombat(int click)
        {
            string nomAtk = String.Empty;

            //Clear des stats précédentes
            lblPersoAtk.Visible = false;
            lblPersoDegats.Visible = false;
            lblAdvAtk.Visible = false;
            lblAdvDegats.Visible = false;
            lblEsquive.Visible = false;

            //Vérification de la couleure des barres de vie
            VerifBarres();

            //PV
            lblPvPerso.Text = "PV : " + Math.Round(game.pv).ToString() + " / " + Math.Round(perso.pvMax * game.multiPv).ToString();
            lblPvAdv.Text = "PV : " + Math.Round(game.pvAdv).ToString() + " / " + Math.Round(game.pvAdvMax).ToString();

            //Gestion du bouton Haricot senzu
            if ((game.pv < perso.pvMax * game.multiPv || game.sta < perso.staMax ) && game.nbHaricots > 0)
            {
                btnHaricot.Enabled = true;
                btnHaricot.BackColor = Color.PaleGreen;
            }
            else
            {
                btnHaricot.Enabled = false;
                btnHaricot.BackColor = Color.Gray;
            }

            //Gestion des différents messages
            if (click == 0)
            {
                lblPersoAtk.Text = "Vous avez utilisé un Haricot Senzu !";
                lblPersoDegats.Text = "PV et stamina restaurés !";
                lblPersoAtk.Visible = true;
                lblPersoDegats.Visible = true;
            }
            else
            {
                //Message d'esquive
                if (game.esquive)
                {
                    lblEsquive.Visible = true;
                }

                //Nom de l'attaque du joueur
                if (click == 1)
                {
                    nomAtk = "Attaque simple";
                }
                else if (click == 2)
                {
                    nomAtk = perso.spe1;
                }
                else
                {
                    nomAtk = perso.spe2;
                }
                lblPersoAtk.Text = "Vous avez utilisé " + nomAtk + " !";

                //Dégâts du joueur
                lblPersoDegats.Text = Math.Round(game.degatsPerso).ToString() + " dégâts";

                lblPersoAtk.Visible = true;
                lblPersoDegats.Visible = true;

                //Coup spécial adverse
                if (game.speAdv)
                {
                    lblAdvAtk.Text = game.nomAdv + " a utilisé " + game.msgUltAdv;
                }
                else
                {
                    lblAdvAtk.Text = game.nomAdv + " attaque !";
                }

                //Dégâts adverses
                lblAdvDegats.Text = Math.Round(game.degatsAdv).ToString() + " dégâts";

                lblAdvAtk.Visible = true;
                lblAdvDegats.Visible = true;
            }

            //Gestion des informations de combats supplémentaires
            VerifStamina();

            lblSta.Text = "Stamina : " + game.sta + " / " + perso.staMax + "\n";
            lblSta.Text += "(Régénération de " + perso.regSta + " par tour)";
            lblHaricotsRestants.Text = "Haricots restants : " + game.nbHaricots;
        }

        //Attribution ou non d'un nouvel Haricot Senzu
        private void DropSenzu()
        {
            if (game.numCombat + 1 == 5 || game.numCombat + 1 == 10 || game.numCombat + 1 == 15 || game.numCombat + 1 == 20 || game.numCombat + 1 == 25)
            {
                game.nbHaricots++;
                game.dropHaricot = true;
            }
            else if (game.nomAdv == "Piccolo")
            {
                if (rdm.Next(1, 4) == 1)
                {
                    game.nbHaricots++;
                    game.dropHaricot = true;
                }
            }
        }

        //Calculs de fin de combat
        private void finCombat(int click)
        {
            if (game.numCombat == 29)
            {
                victoire();
            }
            else
            {
                //Clear du menu et des stats
                perso.msgTransfo = String.Empty;
                game.nivSup = false;
                game.dropHaricot = false;

                lstChoixEnnemi.Items.Clear();

                lblPersoAtk.Visible = false;
                lblPersoDegats.Visible = false;
                lblAdvAtk.Visible = false;
                lblAdvDegats.Visible = false;
                lblEsquive.Visible = false;

                lblNomPersonnage.Visible = false;
                lblNomAdversaire.Visible = false;

                picBoxHealthBar1_1.Visible = false;
                picBoxHealthBar1_2.Visible = false;
                picBoxHealthBar2_1.Visible = false;
                picBoxHealthBar2_2.Visible = false;

                lblPvPerso.Visible = false;
                lblPvAdv.Visible = false;

                grpInfosAutres.Visible = false;
                grpInfosCombat.Visible = false;
                picBoxGauche.Visible = false;
                picBoxDroite.Visible = false;
                btnAtkSimple.Visible = false;
                btnSpe1.Visible = false;
                btnSpe2.Visible = false;
                btnHaricot.Visible = false;

                //Remise du fond menu
                frmDepart.ActiveForm.BackgroundImage = global::DragonRoad.Properties.Resources.back_menu;

                //XP
                game.xpTotal += game.xp;
                while (game.xpTotal > ((200 + game.difficultyCoeffXP) * game.multiXP))
                {
                    game.xpTotal -= (200 + game.difficultyCoeffXP) * game.multiXP;

                    game.pv += 0.1 * perso.pvMax * game.multiPv;
                    game.lvl++;
                    game.multiXP *= 1.22;
                    game.multiPv *= 1.05;
                    game.multiAtk *= 1.03;

                    game.nivSup = true;
                }

                lblTransfo.Visible = false;

                //Transformation
                if (game.numTransfo < game.numTransfoMax && game.lvl >= perso.nivTransfo)
                {
                    game.numTransfo++;
                    perso.InitialiseStats(perso.nom, game.numTransfo);
                    game.pv += 0.5 * perso.pvMax * game.multiPv;
                    game.sta += 2 * perso.regSta;
                    VerifStats();
                    lblTransfo.Visible = true;
                }

                //Score
                game.scoreMax += (game.score * game.difficultyCoeffScore) * (1 + (game.numCombat * 3)/100) * (1 + (game.numCombat * 3)/100);

                //Drop de Dragon Ball
                if (game.nbDragonsBall < 7 && rdm.Next(1, 101) <= (10 + (game.numCombat * 2)))
                {
                    game.nbDragonsBall++;
                    game.dropDB = true;
                }

                //Récupération de stamina et de PV
                //PV
                game.pv += ((0.1 + game.heal) * perso.pvMax * game.multiPv);
                game.heal = 0;
                //Stamina
                if (click == 1)
                {
                    game.sta += 15;
                }
                else
                {
                    game.sta += 5;
                }

                VerifStats();

                //Stats adverses augmentées
                game.InitialiseMultiEnnemis();

                //Drops de Haricots Senzus
                DropSenzu();

                //Combat suivant
                game.numCombat++;
                btnCombattre.Enabled = false;

                //Affichage du menu suivant
                RecapInfos();

                //Adversaires à choisir
                detAdversaires();

                grpChoixEnnemi.Visible = true;
                btnCombattre.Visible = true;

                if (game.nbDragonsBall == 7 && !game.voeuDB)
                {
                    btnShenron.Visible = true;
                }
            }
        }

        //Fond de combat
        private void changeFond()
        {
            if (game.nomAdv == "Saibaman" || game.nomAdv == "Yamcha")
            {
                frmDepart.ActiveForm.BackgroundImage = global::DragonRoad.Properties.Resources.back_saibaman_yamcha;
            }
            else if (game.nomAdv == "Piccolo")
            {
                frmDepart.ActiveForm.BackgroundImage = global::DragonRoad.Properties.Resources.back_piccolo;
            }
            else if (game.nomAdv == "Tortue Géniale" || game.nomAdv == "Krillin")
            {
                frmDepart.ActiveForm.BackgroundImage = global::DragonRoad.Properties.Resources.back_kame_krillin;
            }
            else if (game.nomAdv == "Freezer" || game.nomAdv == "Golden Freezer")
            {
                frmDepart.ActiveForm.BackgroundImage = global::DragonRoad.Properties.Resources.back_freezer;
            }
            else if (game.nomAdv == "Cell")
            {
                frmDepart.ActiveForm.BackgroundImage = global::DragonRoad.Properties.Resources.back_cell;
            }
            else if (game.nomAdv == "Cooler" || game.nomAdv == "Cooler (Forme finale)")
            {
                frmDepart.ActiveForm.BackgroundImage = global::DragonRoad.Properties.Resources.back_cooler;
            }
            else if (game.nomAdv == "Buu")
            {
                frmDepart.ActiveForm.BackgroundImage = global::DragonRoad.Properties.Resources.back_buu;
            }
            else if (game.nomAdv == "Super Janemba")
            {
                frmDepart.ActiveForm.BackgroundImage = global::DragonRoad.Properties.Resources.back_janemba;
            }
            else if (game.nomAdv == "Zamasu" || game.nomAdv == "Zamasu fusionné")
            {
                frmDepart.ActiveForm.BackgroundImage = global::DragonRoad.Properties.Resources.back_zamasu;
            }
            else if (game.nomAdv == "Omega Shenron")
            {
                frmDepart.ActiveForm.BackgroundImage = global::DragonRoad.Properties.Resources.back_omega_shenron;
            }
            else
            {
                frmDepart.ActiveForm.BackgroundImage = global::DragonRoad.Properties.Resources.back_jiren;
            }
        }

        //------------- Fonctions de vérifications -------------

        //Vérification de la stamina avant de lancer une attaque
        private void VerifStamina()
        {
            if (game.sta > perso.staMax)
            {
                game.sta = perso.staMax;
            }

            btnSpe1.Enabled = true;
            btnSpe2.Enabled = true;

            btnSpe1.BackColor = Color.PaleTurquoise;
            btnSpe2.BackColor = Color.LightPink;

            if (game.sta < perso.costSpe1)
            {
                btnSpe1.Enabled = false;
                btnSpe2.Enabled = false;

                btnSpe1.BackColor = Color.Gray;
                btnSpe2.BackColor = Color.Gray;
            }
            else if (game.sta < perso.costSpe2)
            {
                btnSpe2.Enabled = false;

                btnSpe2.BackColor = Color.Gray;
            }
        }

        //Vérification de la couleure des barres de vie
        private void VerifBarres()
        {
            if (picBoxHealthBar1_2.Width < 50)
            {
                picBoxHealthBar1_2.BackColor = Color.Red;
            }
            else if (picBoxHealthBar1_2.Width < 100)
            {
                picBoxHealthBar1_2.BackColor = Color.Gold;
            }
            else
            {
                picBoxHealthBar1_2.BackColor = Color.Lime;
            }

            if (picBoxHealthBar2_2.Width < 50)
            {
                picBoxHealthBar2_2.BackColor = Color.Red;
            }
            else if (picBoxHealthBar2_2.Width < 100)
            {
                picBoxHealthBar2_2.BackColor = Color.Gold;
            }
            else
            {
                picBoxHealthBar2_2.BackColor = Color.Lime;
            }
        }

        //Vérification de la validité des stats, respect des maximum
        private void VerifStats()
        {
            //PV
            if (game.pv > (perso.pvMax * game.multiPv))
            {
                game.pv = perso.pvMax * game.multiPv;
            }

            //Stamina
            if (game.sta > perso.staMax)
            {
                game.sta = perso.staMax;
            }
        }

        /********************************************************************************************************************************/
        /* Fin de partie                                                                                                                */
        /********************************************************************************************************************************/

        //------------- Résultats -------------

        //Écran de fin de victoire
        private void victoire()
        {
            //Clear du menu précédent
            btnAtkSimple.Visible = false;
            btnSpe1.Visible = false;
            btnSpe2.Visible = false;
            btnHaricot.Visible = false;

            grpInfosCombat.Visible = false;
            grpInfosAutres.Visible = false;

            lblPvPerso.Visible = false;
            lblPvAdv.Visible = false;

            lblNomPersonnage.Visible = false;
            lblNomAdversaire.Visible = false;

            picBoxGauche.Visible = false;
            picBoxDroite.Visible = false;

            picBoxHealthBar1_1.Visible = false;
            picBoxHealthBar1_2.Visible = false;
            picBoxHealthBar2_1.Visible = false;
            picBoxHealthBar2_2.Visible = false;

            btnReset.Visible = false;

            //Écriture du message
            grpResultats.Text = "Victoire !";
            lblMsgFin.Text = "Vous avez su défaire tous les adversaires, dont le tout-puissant Jiren !\n";
            lblMsgFin.Text += "Félicitations!\n";
            lblMsgFin.Text += "\n";
            lblMsgFin.Text += "Score : " +Math.Round(game.scoreMax).ToString() +"\n";
            lblMsgFin.Text += "\n";
            lblMsgFin.Text += "Maintenant que plus rien ne peut vous arrêter, il vous faut essayer\n";
            lblMsgFin.Text += "des défis plus difficiles encore.\n";
            lblMsgFin.Text += "L'esprit Dragon Ball vous guidera vers vos rêves !";

            //Affichage du nouveau menu
            grpResultats.Visible = true;
            btnRetourMenu.Visible = true;
        }

        //Écran de fin de défaite
        private void defaite()
        {
            //Clear du menu précédent
            btnAtkSimple.Visible = false;
            btnSpe1.Visible = false;
            btnSpe2.Visible = false;
            btnHaricot.Visible = false;

            grpInfosCombat.Visible = false;
            grpInfosAutres.Visible = false;

            lblPvPerso.Visible = false;
            lblPvAdv.Visible = false;

            lblNomPersonnage.Visible = false;
            lblNomAdversaire.Visible = false;

            picBoxGauche.Visible = false;
            picBoxDroite.Visible = false;

            picBoxHealthBar1_1.Visible = false;
            picBoxHealthBar1_2.Visible = false;
            picBoxHealthBar2_1.Visible = false;
            picBoxHealthBar2_2.Visible = false;

            btnReset.Visible = false;

            //Écriture du message
            grpResultats.Text = "Perdu...";
            lblMsgFin.Text = "Vous aviez beau être fort, vous n'étiez malheureusement pas invincible.\n";
            lblMsgFin.Text += "Mais que serait un jeu sans réel défi ?\n";
            lblMsgFin.Text += "\n";
            lblMsgFin.Text += "Score : " + Math.Round(game.scoreMax).ToString() + "\n";
            lblMsgFin.Text += "\n";
            lblMsgFin.Text += "Les plus fiers combattants Dragon Ball n'attendent que vous pour\n";
            lblMsgFin.Text += "retenter leur chance !\n";
            lblMsgFin.Text += "Vous ne serez jamais réellement perdant !";

            //Affichage du nouveau menu
            grpResultats.Visible = true;
            btnRetourMenu.Visible = true;
        }

        //------------- Reset -------------

        //Bouton de fin de jeu
        private void BtnRetourMenu_Click(object sender, EventArgs e)
        {
            //Appel de la fonction Reset
            Reset();
        }

        //Fonction de réinitialisation
        private void Reset()
        {
            //Clear de tous les menus
            btnReset.Visible = false;

            //Résultats
            grpResultats.Visible = false;
            btnRetourMenu.Visible = false;

            //Shenron
            picBoxShenron.Visible = false;
            grpShenron.Visible = false;
            btnShenron1.Visible = false;
            btnShenron2.Visible = false;

            //Combat
            btnAtkSimple.Visible = false;
            btnSpe1.Visible = false;
            btnSpe2.Visible = false;
            btnHaricot.Visible = false;

            grpInfosCombat.Visible = false;
            grpInfosAutres.Visible = false;

            lblPvPerso.Visible = false;
            lblPvAdv.Visible = false;
            lblNomPersonnage.Visible = false;
            lblNomAdversaire.Visible = false;

            picBoxGauche.Visible = false;
            picBoxDroite.Visible = false;
            picBoxHealthBar1_1.Visible = false;
            picBoxHealthBar1_2.Visible = false;
            picBoxHealthBar2_1.Visible = false;
            picBoxHealthBar2_2.Visible = false;

            //Choix de l'adversaire
            btnCombattre.Visible = false;

            grpRecapInfos.Visible = false;
            grpChoixEnnemi.Visible = false;

            picBoxEnnemi.Visible = false;

            lblForceEnnemi.Visible = false;
            lblTransfo.Visible = false;
            lblDB.Visible = false;
            lblXp.Visible = false;
            lblNiveauSup.Visible = false;
            lblNumCombat.Visible = false;
            lblMsgBonus.Visible = false;

            btnCombattre.BackColor = Color.Gray;

            clearDB();

            //Réinitialisation du jeu
            game.numCombat = 0;
            game.numTransfo = 0;
            game.lvl = 1;
            game.nbHaricots = 1;

            game.speAdv = false;
            game.dropHaricot = false;
            game.esquive = false;
            game.nivSup = false;
            game.voeuDB = false;

            game.multiAtk = 1.0;
            game.multiPv = 1.0;
            game.multiXP = 1.0;

            game.xp = 0;
            game.xpTotal = 0;

            game.multiEnnemi1 = 1.0;
            game.multiEnnemi2 = 1.0;
            game.multiEnnemi3 = 1.0;
            game.multiEnnemi4 = 1.0;
            game.multiEnnemi5 = 1.0;
            game.multiEnnemi6 = 1.0;

            perso.nomTransfo = String.Empty;

            lstChoixEnnemi.Items.Clear();
            lstPerso.SelectedItems.Clear();
            rdbDif3.Checked = true;

            //Remise du fond menu
            frmDepart.ActiveForm.BackgroundImage = global::DragonRoad.Properties.Resources.back_menu;

            //Choix du personnage
            btnStart.Enabled = false;
            btnStart.BackColor = Color.Gray;

            picBoxChara.Visible = false;
            lblPuissance.Visible = false;

            //Réaffichage du menu de départ
            grpRules.Visible = true;
            grpChoixPerso.Visible = true;
            grpDif.Visible = true;
            btnStart.Visible = true;
        }

        //Bouton retour au menu
        private void BtnReset_Click(object sender, EventArgs e)
        {
            //Demande de fermeture par message box
            string message = "Êtes-vous certain de vouloir recommencer ?";
            string title = "Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                //Appel de la fonction Reset
                Reset();
            }
        }

        /********************************************************************************************************************************/
        /* Shenron                                                                                                                      */
        /********************************************************************************************************************************/

        //Bouton d'invocation de Shenron
        private void BtnShenron_Click(object sender, EventArgs e)
        {
            //Clear du menu précédent
            btnShenron.Visible = false;
            grpChoixEnnemi.Visible = false;
            grpRecapInfos.Visible = false;
            btnCombattre.Visible = false;

            clearDB();

            game.voeuDB = true;

            //Affichage du nouveau menu
            picBoxShenron.Image = imgListShenron.Images[0];
            picBoxShenron.Visible = true;
            grpShenron.Visible = true;
            btnShenron1.Visible = true;
            btnShenron2.Visible = true;
        }

        //Le joueur choisit les niveaux
        private void BtnShenron1_Click(object sender, EventArgs e)
        {
            //Voeu
            game.lvl += 3;

            //Transformation
            if (game.numTransfo < game.numTransfoMax && game.lvl >= perso.nivTransfo)
            {
                game.numTransfo++;
                perso.InitialiseStats(perso.nom, game.numTransfo);
                game.pv = perso.pvMax * game.multiPv;
                game.sta = perso.staMax;
                lblTransfo.Visible = true;
            }

            lblAdversaireVaincu.Text = "Vous êtes monté de 3 niveaux !";

            //Clear du menu et réaffichage de la suite
            apresVoeu();
        }

        //Le joueur choisit les haricots
        private void BtnShenron2_Click(object sender, EventArgs e)
        {
            //Voeu
            game.nbHaricots += 3;

            lblAdversaireVaincu.Text = "Vous avez obtenu 3 Haricots Senzus !";

            //Clear du menu et réaffichage de la suite
            apresVoeu();
        }

        //Initialisations des menus après voeu
        private void apresVoeu()
        {
            //Clear de l'ancien menu
            picBoxShenron.Visible = false;
            grpShenron.Visible = false;
            btnShenron1.Visible = false;
            btnShenron2.Visible = false;

            lblMsgBonus.Visible = false;
            lblXp.Visible = false;
            lblNiveauSup.Visible = false;
            game.nivSup = false;
            lblDB.Visible = false;

            //Affichage du nouveau menu
            grpRecapInfos.Visible = true;

            picCharaInfos.Image = imgListOther.Images[perso.picIndex];
            lblInfoNiveau.Text = "Niveau " + game.lvl;

            grpChoixEnnemi.Visible = true;
            btnCombattre.Visible = true;

            lblTransfo.Text = perso.msgTransfo;
        }

        /********************************************************************************************************************************/
        /* Informations dynamiques                                                                                                      */
        /********************************************************************************************************************************/

        //Lorsque la souris survole un bouton
        private void BtnSpe2_MouseMove(object sender, MouseEventArgs e)
        {
            if (Convert.ToInt32(((Button)sender).Tag) == 0)
            {
                lblInfosAtkTitre.Text = "Attaque simple";
                perso.descrSpecial = "Une attaque basique, mêlant puissance\n";
                perso.descrSpecial += "et technique de l'utilisateur.";
            }
            else if (Convert.ToInt32(((Button)sender).Tag) == 1)
            {
                lblInfosAtkTitre.Text = perso.spe1;
                perso.descriptionAtk(perso.spe1);
            }
            else
            {
                lblInfosAtkTitre.Text = perso.spe2;
                perso.descriptionAtk(perso.spe2);
            }
            lblInfosAtk.Text = perso.descrSpecial;
            grpInfosAtk.Visible = true;
        }

        //Lorsque la souris ne survole plus un bouton
        private void BtnSpe2_MouseLeave(object sender, EventArgs e)
        {
            grpInfosAtk.Visible = false;
        }
    }
}

