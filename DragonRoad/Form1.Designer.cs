using System.Drawing;

namespace DragonRoad
{
    partial class frmDepart
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepart));
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnMusic = new System.Windows.Forms.Button();
            this.btnMusicStop = new System.Windows.Forms.Button();
            this.txtNomMusic = new System.Windows.Forms.TextBox();
            this.grpRules = new System.Windows.Forms.GroupBox();
            this.lblRules = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.grpChoixPerso = new System.Windows.Forms.GroupBox();
            this.btnRandomChoice = new System.Windows.Forms.Button();
            this.lstPerso = new System.Windows.Forms.ListBox();
            this.imgListStart = new System.Windows.Forms.ImageList(this.components);
            this.grpDif = new System.Windows.Forms.GroupBox();
            this.rdbDif4 = new System.Windows.Forms.RadioButton();
            this.rdbDif2 = new System.Windows.Forms.RadioButton();
            this.rdbDif3 = new System.Windows.Forms.RadioButton();
            this.rdbDif5 = new System.Windows.Forms.RadioButton();
            this.rdbDif1 = new System.Windows.Forms.RadioButton();
            this.bgwFondPrincipal = new System.ComponentModel.BackgroundWorker();
            this.lblPuissance = new System.Windows.Forms.Label();
            this.picBoxChara = new System.Windows.Forms.PictureBox();
            this.grpRecapInfos = new System.Windows.Forms.GroupBox();
            this.lblDB = new System.Windows.Forms.Label();
            this.lblInfoNiveau = new System.Windows.Forms.Label();
            this.picCharaInfos = new System.Windows.Forms.PictureBox();
            this.lblNumCombat = new System.Windows.Forms.Label();
            this.lblNiveauSup = new System.Windows.Forms.Label();
            this.lblXp = new System.Windows.Forms.Label();
            this.lblMsgBonus = new System.Windows.Forms.Label();
            this.lblTransfo = new System.Windows.Forms.Label();
            this.lblAdversaireVaincu = new System.Windows.Forms.Label();
            this.grpChoixEnnemi = new System.Windows.Forms.GroupBox();
            this.lblForceEnnemi = new System.Windows.Forms.Label();
            this.picBoxEnnemi = new System.Windows.Forms.PictureBox();
            this.lstChoixEnnemi = new System.Windows.Forms.ListBox();
            this.btnCombattre = new System.Windows.Forms.Button();
            this.imgListOther = new System.Windows.Forms.ImageList(this.components);
            this.grpInfosCombat = new System.Windows.Forms.GroupBox();
            this.lblEsquive = new System.Windows.Forms.Label();
            this.lblAdvDegats = new System.Windows.Forms.Label();
            this.lblPersoDegats = new System.Windows.Forms.Label();
            this.lblAdvAtk = new System.Windows.Forms.Label();
            this.lblPersoAtk = new System.Windows.Forms.Label();
            this.btnSpe1 = new System.Windows.Forms.Button();
            this.btnSpe2 = new System.Windows.Forms.Button();
            this.btnAtkSimple = new System.Windows.Forms.Button();
            this.btnHaricot = new System.Windows.Forms.Button();
            this.picBoxDroite = new System.Windows.Forms.PictureBox();
            this.picBoxGauche = new System.Windows.Forms.PictureBox();
            this.grpInfosAutres = new System.Windows.Forms.GroupBox();
            this.lblNbDB = new System.Windows.Forms.Label();
            this.lblHaricotsRestants = new System.Windows.Forms.Label();
            this.lblSta = new System.Windows.Forms.Label();
            this.picBoxHealthBar1_1 = new System.Windows.Forms.PictureBox();
            this.picBoxHealthBar1_2 = new System.Windows.Forms.PictureBox();
            this.picBoxHealthBar2_1 = new System.Windows.Forms.PictureBox();
            this.picBoxHealthBar2_2 = new System.Windows.Forms.PictureBox();
            this.lblPvPerso = new System.Windows.Forms.Label();
            this.lblPvAdv = new System.Windows.Forms.Label();
            this.grpResultats = new System.Windows.Forms.GroupBox();
            this.lblMsgFin = new System.Windows.Forms.Label();
            this.btnRetourMenu = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNomPersonnage = new System.Windows.Forms.Label();
            this.lblNomAdversaire = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnShenron = new System.Windows.Forms.Button();
            this.imgListShenron = new System.Windows.Forms.ImageList(this.components);
            this.picBoxShenron = new System.Windows.Forms.PictureBox();
            this.grpShenron = new System.Windows.Forms.GroupBox();
            this.lblShenron = new System.Windows.Forms.Label();
            this.btnShenron1 = new System.Windows.Forms.Button();
            this.btnShenron2 = new System.Windows.Forms.Button();
            this.grpInfosAtk = new System.Windows.Forms.GroupBox();
            this.lblInfosAtkTitre = new System.Windows.Forms.Label();
            this.lblInfosAtk = new System.Windows.Forms.Label();
            this.lblCrit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBoxDB4 = new System.Windows.Forms.PictureBox();
            this.picBoxDB5 = new System.Windows.Forms.PictureBox();
            this.picBoxDB6 = new System.Windows.Forms.PictureBox();
            this.picBoxDB7 = new System.Windows.Forms.PictureBox();
            this.picBoxDB3 = new System.Windows.Forms.PictureBox();
            this.picBoxDB2 = new System.Windows.Forms.PictureBox();
            this.picBoxDB1 = new System.Windows.Forms.PictureBox();
            this.imgListDB = new System.Windows.Forms.ImageList(this.components);
            this.grpRules.SuspendLayout();
            this.grpChoixPerso.SuspendLayout();
            this.grpDif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxChara)).BeginInit();
            this.grpRecapInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCharaInfos)).BeginInit();
            this.grpChoixEnnemi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEnnemi)).BeginInit();
            this.grpInfosCombat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDroite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGauche)).BeginInit();
            this.grpInfosAutres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHealthBar1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHealthBar1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHealthBar2_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHealthBar2_2)).BeginInit();
            this.grpResultats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShenron)).BeginInit();
            this.grpShenron.SuspendLayout();
            this.grpInfosAtk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDB4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDB5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDB6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDB7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDB1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Silver;
            this.btnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnQuitter.FlatAppearance.BorderSize = 3;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Location = new System.Drawing.Point(1745, 960);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(143, 44);
            this.btnQuitter.TabIndex = 0;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // btnMusic
            // 
            this.btnMusic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMusic.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnMusic.FlatAppearance.BorderSize = 2;
            this.btnMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusic.Location = new System.Drawing.Point(1585, 960);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(143, 44);
            this.btnMusic.TabIndex = 1;
            this.btnMusic.Text = "Musique aléatoire";
            this.btnMusic.UseVisualStyleBackColor = false;
            this.btnMusic.Click += new System.EventHandler(this.BtnMusic_Click);
            // 
            // btnMusicStop
            // 
            this.btnMusicStop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMusicStop.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnMusicStop.FlatAppearance.BorderSize = 2;
            this.btnMusicStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicStop.Location = new System.Drawing.Point(1425, 960);
            this.btnMusicStop.Name = "btnMusicStop";
            this.btnMusicStop.Size = new System.Drawing.Size(143, 44);
            this.btnMusicStop.TabIndex = 2;
            this.btnMusicStop.Text = "Stopper la musique";
            this.btnMusicStop.UseVisualStyleBackColor = false;
            this.btnMusicStop.Click += new System.EventHandler(this.BtnMusicStop_Click);
            // 
            // txtNomMusic
            // 
            this.txtNomMusic.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNomMusic.Enabled = false;
            this.txtNomMusic.Font = new System.Drawing.Font("Prototype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomMusic.Location = new System.Drawing.Point(1425, 928);
            this.txtNomMusic.Name = "txtNomMusic";
            this.txtNomMusic.ReadOnly = true;
            this.txtNomMusic.Size = new System.Drawing.Size(303, 26);
            this.txtNomMusic.TabIndex = 5;
            this.txtNomMusic.Visible = false;
            // 
            // grpRules
            // 
            this.grpRules.BackColor = System.Drawing.Color.Transparent;
            this.grpRules.Controls.Add(this.lblRules);
            this.grpRules.Font = new System.Drawing.Font("Prototype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.grpRules.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpRules.Location = new System.Drawing.Point(562, 300);
            this.grpRules.Name = "grpRules";
            this.grpRules.Size = new System.Drawing.Size(796, 262);
            this.grpRules.TabIndex = 6;
            this.grpRules.TabStop = false;
            this.grpRules.Text = "Règles du jeu";
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.BackColor = System.Drawing.Color.Transparent;
            this.lblRules.Font = new System.Drawing.Font("Prototype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.ForeColor = System.Drawing.Color.Black;
            this.lblRules.Location = new System.Drawing.Point(20, 22);
            this.lblRules.Margin = new System.Windows.Forms.Padding(5);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(752, 220);
            this.lblRules.TabIndex = 0;
            this.lblRules.Text = resources.GetString("lblRules.Text");
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Gray;
            this.btnStart.Enabled = false;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStart.FlatAppearance.BorderSize = 3;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(820, 860);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(280, 44);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Jouer !";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // grpChoixPerso
            // 
            this.grpChoixPerso.BackColor = System.Drawing.Color.Transparent;
            this.grpChoixPerso.Controls.Add(this.btnRandomChoice);
            this.grpChoixPerso.Controls.Add(this.lstPerso);
            this.grpChoixPerso.Font = new System.Drawing.Font("Prototype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.grpChoixPerso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpChoixPerso.Location = new System.Drawing.Point(562, 568);
            this.grpChoixPerso.Name = "grpChoixPerso";
            this.grpChoixPerso.Size = new System.Drawing.Size(234, 311);
            this.grpChoixPerso.TabIndex = 7;
            this.grpChoixPerso.TabStop = false;
            this.grpChoixPerso.Text = "Choix du personnage";
            // 
            // btnRandomChoice
            // 
            this.btnRandomChoice.BackColor = System.Drawing.Color.White;
            this.btnRandomChoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRandomChoice.FlatAppearance.BorderSize = 3;
            this.btnRandomChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomChoice.Font = new System.Drawing.Font("Prototype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomChoice.Location = new System.Drawing.Point(33, 262);
            this.btnRandomChoice.Name = "btnRandomChoice";
            this.btnRandomChoice.Size = new System.Drawing.Size(174, 31);
            this.btnRandomChoice.TabIndex = 2;
            this.btnRandomChoice.Text = "Random";
            this.btnRandomChoice.UseVisualStyleBackColor = false;
            this.btnRandomChoice.Click += new System.EventHandler(this.BtnRandomChoice_Click);
            // 
            // lstPerso
            // 
            this.lstPerso.Font = new System.Drawing.Font("Prototype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPerso.FormattingEnabled = true;
            this.lstPerso.ItemHeight = 20;
            this.lstPerso.Items.AddRange(new object[] {
            "Son Goku (GT)",
            "Son Goku",
            "Vegeta",
            "Son Gohan (Ado)",
            "Trunks (Futur)",
            "Gotenks",
            "Son Gohan",
            "Broly",
            "Goku Black",
            "Vegeto",
            "Gogeta"});
            this.lstPerso.Location = new System.Drawing.Point(33, 36);
            this.lstPerso.Name = "lstPerso";
            this.lstPerso.Size = new System.Drawing.Size(174, 224);
            this.lstPerso.TabIndex = 1;
            this.lstPerso.SelectedIndexChanged += new System.EventHandler(this.lstPerso_SelectedIndexChanged);
            // 
            // imgListStart
            // 
            this.imgListStart.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListStart.ImageStream")));
            this.imgListStart.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListStart.Images.SetKeyName(0, "goku_gt_0.png");
            this.imgListStart.Images.SetKeyName(1, "goku_0.png");
            this.imgListStart.Images.SetKeyName(2, "vegeta_0.png");
            this.imgListStart.Images.SetKeyName(3, "teen_gohan_0.png");
            this.imgListStart.Images.SetKeyName(4, "trunks_0.png");
            this.imgListStart.Images.SetKeyName(5, "gotenks_0.png");
            this.imgListStart.Images.SetKeyName(6, "gohan_0.png");
            this.imgListStart.Images.SetKeyName(7, "broly_0.png");
            this.imgListStart.Images.SetKeyName(8, "goku_black_0.png");
            this.imgListStart.Images.SetKeyName(9, "vegeto_0.png");
            this.imgListStart.Images.SetKeyName(10, "gogeta_0.png");
            // 
            // grpDif
            // 
            this.grpDif.BackColor = System.Drawing.Color.Transparent;
            this.grpDif.Controls.Add(this.rdbDif4);
            this.grpDif.Controls.Add(this.rdbDif2);
            this.grpDif.Controls.Add(this.rdbDif3);
            this.grpDif.Controls.Add(this.rdbDif5);
            this.grpDif.Controls.Add(this.rdbDif1);
            this.grpDif.Font = new System.Drawing.Font("Prototype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.grpDif.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpDif.Location = new System.Drawing.Point(1124, 568);
            this.grpDif.Name = "grpDif";
            this.grpDif.Size = new System.Drawing.Size(234, 311);
            this.grpDif.TabIndex = 8;
            this.grpDif.TabStop = false;
            this.grpDif.Text = "Difficulté";
            // 
            // rdbDif4
            // 
            this.rdbDif4.AutoSize = true;
            this.rdbDif4.Font = new System.Drawing.Font("Prototype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.rdbDif4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbDif4.Location = new System.Drawing.Point(38, 188);
            this.rdbDif4.Name = "rdbDif4";
            this.rdbDif4.Size = new System.Drawing.Size(78, 24);
            this.rdbDif4.TabIndex = 4;
            this.rdbDif4.TabStop = true;
            this.rdbDif4.Text = "Difficile";
            this.rdbDif4.UseVisualStyleBackColor = true;
            // 
            // rdbDif2
            // 
            this.rdbDif2.AutoSize = true;
            this.rdbDif2.Font = new System.Drawing.Font("Prototype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.rdbDif2.Location = new System.Drawing.Point(38, 96);
            this.rdbDif2.Name = "rdbDif2";
            this.rdbDif2.Size = new System.Drawing.Size(67, 24);
            this.rdbDif2.TabIndex = 3;
            this.rdbDif2.TabStop = true;
            this.rdbDif2.Text = "Facile";
            this.rdbDif2.UseVisualStyleBackColor = true;
            // 
            // rdbDif3
            // 
            this.rdbDif3.AutoSize = true;
            this.rdbDif3.Font = new System.Drawing.Font("Prototype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.rdbDif3.Location = new System.Drawing.Point(38, 142);
            this.rdbDif3.Name = "rdbDif3";
            this.rdbDif3.Size = new System.Drawing.Size(76, 24);
            this.rdbDif3.TabIndex = 2;
            this.rdbDif3.TabStop = true;
            this.rdbDif3.Text = "Moyen";
            this.rdbDif3.UseVisualStyleBackColor = true;
            // 
            // rdbDif5
            // 
            this.rdbDif5.AutoSize = true;
            this.rdbDif5.Font = new System.Drawing.Font("Prototype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.rdbDif5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbDif5.Location = new System.Drawing.Point(38, 231);
            this.rdbDif5.Name = "rdbDif5";
            this.rdbDif5.Size = new System.Drawing.Size(113, 24);
            this.rdbDif5.TabIndex = 1;
            this.rdbDif5.TabStop = true;
            this.rdbDif5.Text = "Très difficile";
            this.rdbDif5.UseVisualStyleBackColor = true;
            // 
            // rdbDif1
            // 
            this.rdbDif1.AutoSize = true;
            this.rdbDif1.Font = new System.Drawing.Font("Prototype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.rdbDif1.Location = new System.Drawing.Point(38, 52);
            this.rdbDif1.Name = "rdbDif1";
            this.rdbDif1.Size = new System.Drawing.Size(100, 24);
            this.rdbDif1.TabIndex = 0;
            this.rdbDif1.TabStop = true;
            this.rdbDif1.Text = "Très facile";
            this.rdbDif1.UseVisualStyleBackColor = true;
            // 
            // lblPuissance
            // 
            this.lblPuissance.AutoSize = true;
            this.lblPuissance.BackColor = System.Drawing.Color.Transparent;
            this.lblPuissance.Font = new System.Drawing.Font("Prototype", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuissance.Location = new System.Drawing.Point(900, 572);
            this.lblPuissance.Name = "lblPuissance";
            this.lblPuissance.Size = new System.Drawing.Size(122, 20);
            this.lblPuissance.TabIndex = 9;
            this.lblPuissance.Text = "Puissance : 000";
            this.lblPuissance.Visible = false;
            // 
            // picBoxChara
            // 
            this.picBoxChara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxChara.Location = new System.Drawing.Point(835, 600);
            this.picBoxChara.Name = "picBoxChara";
            this.picBoxChara.Size = new System.Drawing.Size(250, 250);
            this.picBoxChara.TabIndex = 10;
            this.picBoxChara.TabStop = false;
            this.picBoxChara.Visible = false;
            this.picBoxChara.WaitOnLoad = true;
            // 
            // grpRecapInfos
            // 
            this.grpRecapInfos.BackColor = System.Drawing.Color.Transparent;
            this.grpRecapInfos.Controls.Add(this.lblDB);
            this.grpRecapInfos.Controls.Add(this.lblInfoNiveau);
            this.grpRecapInfos.Controls.Add(this.picCharaInfos);
            this.grpRecapInfos.Controls.Add(this.lblNumCombat);
            this.grpRecapInfos.Controls.Add(this.lblNiveauSup);
            this.grpRecapInfos.Controls.Add(this.lblXp);
            this.grpRecapInfos.Controls.Add(this.lblMsgBonus);
            this.grpRecapInfos.Controls.Add(this.lblTransfo);
            this.grpRecapInfos.Controls.Add(this.lblAdversaireVaincu);
            this.grpRecapInfos.Font = new System.Drawing.Font("Prototype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRecapInfos.Location = new System.Drawing.Point(568, 297);
            this.grpRecapInfos.Name = "grpRecapInfos";
            this.grpRecapInfos.Size = new System.Drawing.Size(378, 536);
            this.grpRecapInfos.TabIndex = 11;
            this.grpRecapInfos.TabStop = false;
            this.grpRecapInfos.Text = "Récapitulatif";
            this.grpRecapInfos.Visible = false;
            // 
            // lblDB
            // 
            this.lblDB.AutoSize = true;
            this.lblDB.Font = new System.Drawing.Font("Prototype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDB.Location = new System.Drawing.Point(21, 155);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(279, 19);
            this.lblDB.TabIndex = 7;
            this.lblDB.Text = "Vous avez obtenu une Dragon Ball !";
            this.lblDB.Visible = false;
            // 
            // lblInfoNiveau
            // 
            this.lblInfoNiveau.AutoSize = true;
            this.lblInfoNiveau.Font = new System.Drawing.Font("Prototype", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoNiveau.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInfoNiveau.Location = new System.Drawing.Point(159, 490);
            this.lblInfoNiveau.Name = "lblInfoNiveau";
            this.lblInfoNiveau.Size = new System.Drawing.Size(43, 19);
            this.lblInfoNiveau.TabIndex = 6;
            this.lblInfoNiveau.Text = "label1";
            // 
            // picCharaInfos
            // 
            this.picCharaInfos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCharaInfos.Location = new System.Drawing.Point(87, 283);
            this.picCharaInfos.Name = "picCharaInfos";
            this.picCharaInfos.Size = new System.Drawing.Size(200, 200);
            this.picCharaInfos.TabIndex = 3;
            this.picCharaInfos.TabStop = false;
            // 
            // lblNumCombat
            // 
            this.lblNumCombat.AutoSize = true;
            this.lblNumCombat.Font = new System.Drawing.Font("Prototype", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCombat.Location = new System.Drawing.Point(138, 29);
            this.lblNumCombat.Name = "lblNumCombat";
            this.lblNumCombat.Size = new System.Drawing.Size(43, 19);
            this.lblNumCombat.TabIndex = 5;
            this.lblNumCombat.Text = "label1";
            this.lblNumCombat.Visible = false;
            // 
            // lblNiveauSup
            // 
            this.lblNiveauSup.AutoSize = true;
            this.lblNiveauSup.Font = new System.Drawing.Font("Prototype", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNiveauSup.Location = new System.Drawing.Point(21, 131);
            this.lblNiveauSup.Name = "lblNiveauSup";
            this.lblNiveauSup.Size = new System.Drawing.Size(127, 19);
            this.lblNiveauSup.TabIndex = 4;
            this.lblNiveauSup.Text = "Niveau supérieur !";
            this.lblNiveauSup.Visible = false;
            // 
            // lblXp
            // 
            this.lblXp.AutoSize = true;
            this.lblXp.Font = new System.Drawing.Font("Prototype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXp.Location = new System.Drawing.Point(21, 110);
            this.lblXp.Name = "lblXp";
            this.lblXp.Size = new System.Drawing.Size(43, 19);
            this.lblXp.TabIndex = 3;
            this.lblXp.Text = "label1";
            this.lblXp.Visible = false;
            // 
            // lblMsgBonus
            // 
            this.lblMsgBonus.AutoSize = true;
            this.lblMsgBonus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMsgBonus.Font = new System.Drawing.Font("Prototype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgBonus.ForeColor = System.Drawing.Color.Black;
            this.lblMsgBonus.Location = new System.Drawing.Point(21, 229);
            this.lblMsgBonus.Name = "lblMsgBonus";
            this.lblMsgBonus.Size = new System.Drawing.Size(50, 19);
            this.lblMsgBonus.TabIndex = 2;
            this.lblMsgBonus.Text = "bonus";
            // 
            // lblTransfo
            // 
            this.lblTransfo.AutoSize = true;
            this.lblTransfo.Font = new System.Drawing.Font("Prototype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransfo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTransfo.Location = new System.Drawing.Point(21, 188);
            this.lblTransfo.Name = "lblTransfo";
            this.lblTransfo.Size = new System.Drawing.Size(58, 19);
            this.lblTransfo.TabIndex = 1;
            this.lblTransfo.Text = "transfo";
            // 
            // lblAdversaireVaincu
            // 
            this.lblAdversaireVaincu.AutoSize = true;
            this.lblAdversaireVaincu.Font = new System.Drawing.Font("Prototype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdversaireVaincu.Location = new System.Drawing.Point(21, 68);
            this.lblAdversaireVaincu.Name = "lblAdversaireVaincu";
            this.lblAdversaireVaincu.Size = new System.Drawing.Size(49, 19);
            this.lblAdversaireVaincu.TabIndex = 0;
            this.lblAdversaireVaincu.Text = "label1";
            // 
            // grpChoixEnnemi
            // 
            this.grpChoixEnnemi.BackColor = System.Drawing.Color.Transparent;
            this.grpChoixEnnemi.Controls.Add(this.lblForceEnnemi);
            this.grpChoixEnnemi.Controls.Add(this.picBoxEnnemi);
            this.grpChoixEnnemi.Controls.Add(this.lstChoixEnnemi);
            this.grpChoixEnnemi.Font = new System.Drawing.Font("Prototype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChoixEnnemi.Location = new System.Drawing.Point(974, 297);
            this.grpChoixEnnemi.Name = "grpChoixEnnemi";
            this.grpChoixEnnemi.Size = new System.Drawing.Size(378, 361);
            this.grpChoixEnnemi.TabIndex = 12;
            this.grpChoixEnnemi.TabStop = false;
            this.grpChoixEnnemi.Text = "Choix de l\'adversaire";
            this.grpChoixEnnemi.Visible = false;
            // 
            // lblForceEnnemi
            // 
            this.lblForceEnnemi.AutoSize = true;
            this.lblForceEnnemi.Font = new System.Drawing.Font("Prototype", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForceEnnemi.Location = new System.Drawing.Point(139, 307);
            this.lblForceEnnemi.Name = "lblForceEnnemi";
            this.lblForceEnnemi.Size = new System.Drawing.Size(43, 19);
            this.lblForceEnnemi.TabIndex = 2;
            this.lblForceEnnemi.Text = "label1";
            this.lblForceEnnemi.Visible = false;
            // 
            // picBoxEnnemi
            // 
            this.picBoxEnnemi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxEnnemi.Location = new System.Drawing.Point(88, 97);
            this.picBoxEnnemi.Name = "picBoxEnnemi";
            this.picBoxEnnemi.Size = new System.Drawing.Size(200, 200);
            this.picBoxEnnemi.TabIndex = 1;
            this.picBoxEnnemi.TabStop = false;
            this.picBoxEnnemi.Visible = false;
            // 
            // lstChoixEnnemi
            // 
            this.lstChoixEnnemi.Font = new System.Drawing.Font("Prototype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstChoixEnnemi.FormattingEnabled = true;
            this.lstChoixEnnemi.ItemHeight = 19;
            this.lstChoixEnnemi.Location = new System.Drawing.Point(38, 44);
            this.lstChoixEnnemi.Name = "lstChoixEnnemi";
            this.lstChoixEnnemi.Size = new System.Drawing.Size(298, 42);
            this.lstChoixEnnemi.TabIndex = 0;
            this.lstChoixEnnemi.SelectedIndexChanged += new System.EventHandler(this.LstChoixEnnemi_SelectedIndexChanged);
            // 
            // btnCombattre
            // 
            this.btnCombattre.BackColor = System.Drawing.Color.Gray;
            this.btnCombattre.Enabled = false;
            this.btnCombattre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCombattre.FlatAppearance.BorderSize = 3;
            this.btnCombattre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCombattre.Font = new System.Drawing.Font("Prototype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.btnCombattre.Location = new System.Drawing.Point(974, 679);
            this.btnCombattre.Name = "btnCombattre";
            this.btnCombattre.Size = new System.Drawing.Size(378, 154);
            this.btnCombattre.TabIndex = 13;
            this.btnCombattre.Text = "Combattre !";
            this.btnCombattre.UseVisualStyleBackColor = false;
            this.btnCombattre.Visible = false;
            this.btnCombattre.Click += new System.EventHandler(this.BtnCombattre_Click);
            // 
            // imgListOther
            // 
            this.imgListOther.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListOther.ImageStream")));
            this.imgListOther.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListOther.Images.SetKeyName(0, "saibaman.png");
            this.imgListOther.Images.SetKeyName(1, "yamcha.png");
            this.imgListOther.Images.SetKeyName(2, "krillin.png");
            this.imgListOther.Images.SetKeyName(3, "piccolo.png");
            this.imgListOther.Images.SetKeyName(4, "tortue_geniale.png");
            this.imgListOther.Images.SetKeyName(5, "freezer_0.png");
            this.imgListOther.Images.SetKeyName(6, "cell.png");
            this.imgListOther.Images.SetKeyName(7, "cooler_0.png");
            this.imgListOther.Images.SetKeyName(8, "buu.png");
            this.imgListOther.Images.SetKeyName(9, "super_janemba.png");
            this.imgListOther.Images.SetKeyName(10, "zamasu_0.png");
            this.imgListOther.Images.SetKeyName(11, "omega_shenron.png");
            this.imgListOther.Images.SetKeyName(12, "jiren.png");
            this.imgListOther.Images.SetKeyName(13, "goku_0.png");
            this.imgListOther.Images.SetKeyName(14, "goku_1.png");
            this.imgListOther.Images.SetKeyName(15, "goku_2.png");
            this.imgListOther.Images.SetKeyName(16, "goku_3.png");
            this.imgListOther.Images.SetKeyName(17, "vegeta_0.png");
            this.imgListOther.Images.SetKeyName(18, "vegeta_1.png");
            this.imgListOther.Images.SetKeyName(19, "vegeta_2.png");
            this.imgListOther.Images.SetKeyName(20, "vegeta_3.png");
            this.imgListOther.Images.SetKeyName(21, "teen_gohan_0.png");
            this.imgListOther.Images.SetKeyName(22, "teen_gohan_1.png");
            this.imgListOther.Images.SetKeyName(23, "teen_gohan_2.png");
            this.imgListOther.Images.SetKeyName(24, "trunks_0.png");
            this.imgListOther.Images.SetKeyName(25, "trunks_1.png");
            this.imgListOther.Images.SetKeyName(26, "trunks_2.png");
            this.imgListOther.Images.SetKeyName(27, "gotenks_0.png");
            this.imgListOther.Images.SetKeyName(28, "gotenks_1.png");
            this.imgListOther.Images.SetKeyName(29, "gotenks_2.png");
            this.imgListOther.Images.SetKeyName(30, "broly_0.png");
            this.imgListOther.Images.SetKeyName(31, "broly_1.png");
            this.imgListOther.Images.SetKeyName(32, "broly_2.png");
            this.imgListOther.Images.SetKeyName(33, "broly_3.png");
            this.imgListOther.Images.SetKeyName(34, "goku_black_0.png");
            this.imgListOther.Images.SetKeyName(35, "goku_black_1.png");
            this.imgListOther.Images.SetKeyName(36, "vegeto_0.png");
            this.imgListOther.Images.SetKeyName(37, "vegeto_1.png");
            this.imgListOther.Images.SetKeyName(38, "vegeto_2.png");
            this.imgListOther.Images.SetKeyName(39, "gogeta_0.png");
            this.imgListOther.Images.SetKeyName(40, "gogeta_1.png");
            this.imgListOther.Images.SetKeyName(41, "gogeta_2.png");
            this.imgListOther.Images.SetKeyName(42, "freezer_1.png");
            this.imgListOther.Images.SetKeyName(43, "cooler_1.png");
            this.imgListOther.Images.SetKeyName(44, "zamasu_1.png");
            this.imgListOther.Images.SetKeyName(45, "goku_gt_0.png");
            this.imgListOther.Images.SetKeyName(46, "goku_gt_1.png");
            this.imgListOther.Images.SetKeyName(47, "goku_gt_2.png");
            this.imgListOther.Images.SetKeyName(48, "goku_gt_3.png");
            this.imgListOther.Images.SetKeyName(49, "gohan_0.png");
            this.imgListOther.Images.SetKeyName(50, "gohan_1.png");
            this.imgListOther.Images.SetKeyName(51, "gohan_2.png");
            // 
            // grpInfosCombat
            // 
            this.grpInfosCombat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpInfosCombat.Controls.Add(this.lblCrit);
            this.grpInfosCombat.Controls.Add(this.lblEsquive);
            this.grpInfosCombat.Controls.Add(this.lblAdvDegats);
            this.grpInfosCombat.Controls.Add(this.lblPersoDegats);
            this.grpInfosCombat.Controls.Add(this.lblAdvAtk);
            this.grpInfosCombat.Controls.Add(this.lblPersoAtk);
            this.grpInfosCombat.Font = new System.Drawing.Font("Prototype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfosCombat.Location = new System.Drawing.Point(748, 299);
            this.grpInfosCombat.Name = "grpInfosCombat";
            this.grpInfosCombat.Size = new System.Drawing.Size(424, 289);
            this.grpInfosCombat.TabIndex = 7;
            this.grpInfosCombat.TabStop = false;
            this.grpInfosCombat.Text = "Informations de combat";
            this.grpInfosCombat.Visible = false;
            // 
            // lblEsquive
            // 
            this.lblEsquive.AutoSize = true;
            this.lblEsquive.Font = new System.Drawing.Font("Prototype", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsquive.Location = new System.Drawing.Point(68, 186);
            this.lblEsquive.Name = "lblEsquive";
            this.lblEsquive.Size = new System.Drawing.Size(204, 19);
            this.lblEsquive.TabIndex = 4;
            this.lblEsquive.Text = "Vous avez esquivé l\'attaque !";
            this.lblEsquive.Visible = false;
            // 
            // lblAdvDegats
            // 
            this.lblAdvDegats.AutoSize = true;
            this.lblAdvDegats.Font = new System.Drawing.Font("Prototype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvDegats.Location = new System.Drawing.Point(69, 158);
            this.lblAdvDegats.Name = "lblAdvDegats";
            this.lblAdvDegats.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAdvDegats.Size = new System.Drawing.Size(47, 18);
            this.lblAdvDegats.TabIndex = 3;
            this.lblAdvDegats.Text = "label1";
            this.lblAdvDegats.Visible = false;
            // 
            // lblPersoDegats
            // 
            this.lblPersoDegats.AutoSize = true;
            this.lblPersoDegats.Font = new System.Drawing.Font("Prototype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersoDegats.Location = new System.Drawing.Point(69, 73);
            this.lblPersoDegats.Name = "lblPersoDegats";
            this.lblPersoDegats.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPersoDegats.Size = new System.Drawing.Size(47, 18);
            this.lblPersoDegats.TabIndex = 2;
            this.lblPersoDegats.Text = "label1";
            this.lblPersoDegats.Visible = false;
            // 
            // lblAdvAtk
            // 
            this.lblAdvAtk.AutoSize = true;
            this.lblAdvAtk.Font = new System.Drawing.Font("Prototype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvAtk.Location = new System.Drawing.Point(64, 139);
            this.lblAdvAtk.Name = "lblAdvAtk";
            this.lblAdvAtk.Size = new System.Drawing.Size(43, 19);
            this.lblAdvAtk.TabIndex = 1;
            this.lblAdvAtk.Text = "label1";
            this.lblAdvAtk.Visible = false;
            // 
            // lblPersoAtk
            // 
            this.lblPersoAtk.AutoSize = true;
            this.lblPersoAtk.Font = new System.Drawing.Font("Prototype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersoAtk.Location = new System.Drawing.Point(64, 54);
            this.lblPersoAtk.Name = "lblPersoAtk";
            this.lblPersoAtk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPersoAtk.Size = new System.Drawing.Size(43, 19);
            this.lblPersoAtk.TabIndex = 0;
            this.lblPersoAtk.Text = "label1";
            this.lblPersoAtk.Visible = false;
            // 
            // btnSpe1
            // 
            this.btnSpe1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSpe1.FlatAppearance.BorderSize = 3;
            this.btnSpe1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpe1.Location = new System.Drawing.Point(748, 600);
            this.btnSpe1.Name = "btnSpe1";
            this.btnSpe1.Size = new System.Drawing.Size(424, 48);
            this.btnSpe1.TabIndex = 7;
            this.btnSpe1.Tag = "1";
            this.btnSpe1.Text = "button1";
            this.btnSpe1.UseVisualStyleBackColor = false;
            this.btnSpe1.Visible = false;
            this.btnSpe1.Click += new System.EventHandler(this.BtnSpe1_Click);
            this.btnSpe1.MouseLeave += new System.EventHandler(this.BtnSpe2_MouseLeave);
            this.btnSpe1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnSpe2_MouseMove);
            // 
            // btnSpe2
            // 
            this.btnSpe2.BackColor = System.Drawing.Color.LightPink;
            this.btnSpe2.FlatAppearance.BorderSize = 3;
            this.btnSpe2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpe2.Location = new System.Drawing.Point(748, 655);
            this.btnSpe2.Name = "btnSpe2";
            this.btnSpe2.Size = new System.Drawing.Size(424, 48);
            this.btnSpe2.TabIndex = 14;
            this.btnSpe2.Tag = "2";
            this.btnSpe2.Text = "button1";
            this.btnSpe2.UseVisualStyleBackColor = false;
            this.btnSpe2.Visible = false;
            this.btnSpe2.Click += new System.EventHandler(this.BtnSpe2_Click);
            this.btnSpe2.MouseLeave += new System.EventHandler(this.BtnSpe2_MouseLeave);
            this.btnSpe2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnSpe2_MouseMove);
            // 
            // btnAtkSimple
            // 
            this.btnAtkSimple.FlatAppearance.BorderSize = 3;
            this.btnAtkSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtkSimple.Location = new System.Drawing.Point(615, 600);
            this.btnAtkSimple.Name = "btnAtkSimple";
            this.btnAtkSimple.Size = new System.Drawing.Size(127, 103);
            this.btnAtkSimple.TabIndex = 15;
            this.btnAtkSimple.Tag = "0";
            this.btnAtkSimple.Text = "Attaque simple";
            this.btnAtkSimple.UseVisualStyleBackColor = true;
            this.btnAtkSimple.Visible = false;
            this.btnAtkSimple.Click += new System.EventHandler(this.BtnAtkSimple_Click);
            this.btnAtkSimple.MouseLeave += new System.EventHandler(this.BtnSpe2_MouseLeave);
            this.btnAtkSimple.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnSpe2_MouseMove);
            // 
            // btnHaricot
            // 
            this.btnHaricot.BackColor = System.Drawing.Color.PaleGreen;
            this.btnHaricot.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHaricot.FlatAppearance.BorderSize = 3;
            this.btnHaricot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHaricot.Location = new System.Drawing.Point(1178, 600);
            this.btnHaricot.Name = "btnHaricot";
            this.btnHaricot.Size = new System.Drawing.Size(127, 103);
            this.btnHaricot.TabIndex = 16;
            this.btnHaricot.Text = "Utiliser un\r\nHaricot\r\n";
            this.btnHaricot.UseVisualStyleBackColor = false;
            this.btnHaricot.Visible = false;
            this.btnHaricot.Click += new System.EventHandler(this.BtnHaricot_Click);
            // 
            // picBoxDroite
            // 
            this.picBoxDroite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxDroite.Location = new System.Drawing.Point(1200, 370);
            this.picBoxDroite.Name = "picBoxDroite";
            this.picBoxDroite.Size = new System.Drawing.Size(200, 200);
            this.picBoxDroite.TabIndex = 17;
            this.picBoxDroite.TabStop = false;
            this.picBoxDroite.Visible = false;
            // 
            // picBoxGauche
            // 
            this.picBoxGauche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxGauche.Location = new System.Drawing.Point(520, 370);
            this.picBoxGauche.Name = "picBoxGauche";
            this.picBoxGauche.Size = new System.Drawing.Size(200, 200);
            this.picBoxGauche.TabIndex = 18;
            this.picBoxGauche.TabStop = false;
            this.picBoxGauche.Visible = false;
            // 
            // grpInfosAutres
            // 
            this.grpInfosAutres.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpInfosAutres.Controls.Add(this.lblNbDB);
            this.grpInfosAutres.Controls.Add(this.lblHaricotsRestants);
            this.grpInfosAutres.Controls.Add(this.lblSta);
            this.grpInfosAutres.Font = new System.Drawing.Font("Prototype", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfosAutres.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpInfosAutres.Location = new System.Drawing.Point(863, 712);
            this.grpInfosAutres.Name = "grpInfosAutres";
            this.grpInfosAutres.Size = new System.Drawing.Size(194, 121);
            this.grpInfosAutres.TabIndex = 22;
            this.grpInfosAutres.TabStop = false;
            this.grpInfosAutres.Text = "Autres infos";
            this.grpInfosAutres.Visible = false;
            // 
            // lblNbDB
            // 
            this.lblNbDB.AutoSize = true;
            this.lblNbDB.Font = new System.Drawing.Font("Prototype", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbDB.Location = new System.Drawing.Point(12, 95);
            this.lblNbDB.Name = "lblNbDB";
            this.lblNbDB.Size = new System.Drawing.Size(38, 16);
            this.lblNbDB.TabIndex = 2;
            this.lblNbDB.Text = "label1";
            // 
            // lblHaricotsRestants
            // 
            this.lblHaricotsRestants.AutoSize = true;
            this.lblHaricotsRestants.Font = new System.Drawing.Font("Prototype", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHaricotsRestants.Location = new System.Drawing.Point(12, 59);
            this.lblHaricotsRestants.Name = "lblHaricotsRestants";
            this.lblHaricotsRestants.Size = new System.Drawing.Size(38, 16);
            this.lblHaricotsRestants.TabIndex = 1;
            this.lblHaricotsRestants.Text = "label1";
            // 
            // lblSta
            // 
            this.lblSta.AutoSize = true;
            this.lblSta.Font = new System.Drawing.Font("Prototype", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSta.Location = new System.Drawing.Point(12, 25);
            this.lblSta.Name = "lblSta";
            this.lblSta.Size = new System.Drawing.Size(38, 16);
            this.lblSta.TabIndex = 0;
            this.lblSta.Text = "label1";
            // 
            // picBoxHealthBar1_1
            // 
            this.picBoxHealthBar1_1.BackColor = System.Drawing.SystemColors.MenuText;
            this.picBoxHealthBar1_1.Location = new System.Drawing.Point(515, 318);
            this.picBoxHealthBar1_1.Name = "picBoxHealthBar1_1";
            this.picBoxHealthBar1_1.Size = new System.Drawing.Size(210, 36);
            this.picBoxHealthBar1_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxHealthBar1_1.TabIndex = 23;
            this.picBoxHealthBar1_1.TabStop = false;
            this.picBoxHealthBar1_1.Visible = false;
            // 
            // picBoxHealthBar1_2
            // 
            this.picBoxHealthBar1_2.BackColor = System.Drawing.Color.Lime;
            this.picBoxHealthBar1_2.Location = new System.Drawing.Point(520, 322);
            this.picBoxHealthBar1_2.Name = "picBoxHealthBar1_2";
            this.picBoxHealthBar1_2.Size = new System.Drawing.Size(200, 28);
            this.picBoxHealthBar1_2.TabIndex = 24;
            this.picBoxHealthBar1_2.TabStop = false;
            this.picBoxHealthBar1_2.Visible = false;
            // 
            // picBoxHealthBar2_1
            // 
            this.picBoxHealthBar2_1.BackColor = System.Drawing.SystemColors.MenuText;
            this.picBoxHealthBar2_1.Location = new System.Drawing.Point(1195, 318);
            this.picBoxHealthBar2_1.Name = "picBoxHealthBar2_1";
            this.picBoxHealthBar2_1.Size = new System.Drawing.Size(210, 36);
            this.picBoxHealthBar2_1.TabIndex = 25;
            this.picBoxHealthBar2_1.TabStop = false;
            this.picBoxHealthBar2_1.Visible = false;
            // 
            // picBoxHealthBar2_2
            // 
            this.picBoxHealthBar2_2.BackColor = System.Drawing.Color.Lime;
            this.picBoxHealthBar2_2.Location = new System.Drawing.Point(1200, 322);
            this.picBoxHealthBar2_2.Name = "picBoxHealthBar2_2";
            this.picBoxHealthBar2_2.Size = new System.Drawing.Size(200, 28);
            this.picBoxHealthBar2_2.TabIndex = 26;
            this.picBoxHealthBar2_2.TabStop = false;
            this.picBoxHealthBar2_2.Visible = false;
            // 
            // lblPvPerso
            // 
            this.lblPvPerso.AutoSize = true;
            this.lblPvPerso.BackColor = System.Drawing.Color.Transparent;
            this.lblPvPerso.Font = new System.Drawing.Font("Prototype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPvPerso.Location = new System.Drawing.Point(540, 295);
            this.lblPvPerso.Name = "lblPvPerso";
            this.lblPvPerso.Size = new System.Drawing.Size(43, 19);
            this.lblPvPerso.TabIndex = 27;
            this.lblPvPerso.Text = "label1";
            this.lblPvPerso.Visible = false;
            // 
            // lblPvAdv
            // 
            this.lblPvAdv.AutoSize = true;
            this.lblPvAdv.BackColor = System.Drawing.Color.Transparent;
            this.lblPvAdv.Font = new System.Drawing.Font("Prototype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPvAdv.Location = new System.Drawing.Point(1220, 295);
            this.lblPvAdv.Name = "lblPvAdv";
            this.lblPvAdv.Size = new System.Drawing.Size(43, 19);
            this.lblPvAdv.TabIndex = 28;
            this.lblPvAdv.Text = "label1";
            this.lblPvAdv.Visible = false;
            // 
            // grpResultats
            // 
            this.grpResultats.BackColor = System.Drawing.Color.Transparent;
            this.grpResultats.Controls.Add(this.lblMsgFin);
            this.grpResultats.Font = new System.Drawing.Font("Prototype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpResultats.Location = new System.Drawing.Point(650, 324);
            this.grpResultats.Name = "grpResultats";
            this.grpResultats.Size = new System.Drawing.Size(610, 220);
            this.grpResultats.TabIndex = 29;
            this.grpResultats.TabStop = false;
            this.grpResultats.Text = "groupBox1";
            this.grpResultats.Visible = false;
            // 
            // lblMsgFin
            // 
            this.lblMsgFin.AutoSize = true;
            this.lblMsgFin.Font = new System.Drawing.Font("Prototype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgFin.ForeColor = System.Drawing.Color.Black;
            this.lblMsgFin.Location = new System.Drawing.Point(24, 45);
            this.lblMsgFin.Name = "lblMsgFin";
            this.lblMsgFin.Size = new System.Drawing.Size(35, 19);
            this.lblMsgFin.TabIndex = 0;
            this.lblMsgFin.Text = "text";
            // 
            // btnRetourMenu
            // 
            this.btnRetourMenu.BackColor = System.Drawing.Color.LightGray;
            this.btnRetourMenu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRetourMenu.FlatAppearance.BorderSize = 3;
            this.btnRetourMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetourMenu.Location = new System.Drawing.Point(832, 553);
            this.btnRetourMenu.Name = "btnRetourMenu";
            this.btnRetourMenu.Size = new System.Drawing.Size(256, 35);
            this.btnRetourMenu.TabIndex = 5;
            this.btnRetourMenu.Text = "Retour au menu";
            this.btnRetourMenu.UseVisualStyleBackColor = false;
            this.btnRetourMenu.Visible = false;
            this.btnRetourMenu.Click += new System.EventHandler(this.BtnRetourMenu_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(45, 960);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(143, 44);
            this.btnReset.TabIndex = 30;
            this.btnReset.Text = "Retour au menu";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // lblNomPersonnage
            // 
            this.lblNomPersonnage.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblNomPersonnage.AutoSize = true;
            this.lblNomPersonnage.BackColor = System.Drawing.Color.Transparent;
            this.lblNomPersonnage.ForeColor = System.Drawing.Color.Black;
            this.lblNomPersonnage.Location = new System.Drawing.Point(541, 576);
            this.lblNomPersonnage.Name = "lblNomPersonnage";
            this.lblNomPersonnage.Size = new System.Drawing.Size(40, 16);
            this.lblNomPersonnage.TabIndex = 31;
            this.lblNomPersonnage.Text = "name";
            this.lblNomPersonnage.Visible = false;
            // 
            // lblNomAdversaire
            // 
            this.lblNomAdversaire.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblNomAdversaire.AutoSize = true;
            this.lblNomAdversaire.BackColor = System.Drawing.Color.Transparent;
            this.lblNomAdversaire.Location = new System.Drawing.Point(1242, 576);
            this.lblNomAdversaire.Name = "lblNomAdversaire";
            this.lblNomAdversaire.Size = new System.Drawing.Size(40, 16);
            this.lblNomAdversaire.TabIndex = 32;
            this.lblNomAdversaire.Text = "name";
            this.lblNomAdversaire.Visible = false;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Prototype", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVersion.Location = new System.Drawing.Point(1741, 26);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(56, 24);
            this.lblVersion.TabIndex = 33;
            this.lblVersion.Text = "label1";
            this.lblVersion.Visible = false;
            // 
            // btnShenron
            // 
            this.btnShenron.BackColor = System.Drawing.Color.Gold;
            this.btnShenron.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnShenron.FlatAppearance.BorderSize = 3;
            this.btnShenron.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShenron.Location = new System.Drawing.Point(729, 890);
            this.btnShenron.Name = "btnShenron";
            this.btnShenron.Size = new System.Drawing.Size(462, 82);
            this.btnShenron.TabIndex = 34;
            this.btnShenron.Text = "Invoquer Shenron !";
            this.btnShenron.UseVisualStyleBackColor = false;
            this.btnShenron.Visible = false;
            this.btnShenron.Click += new System.EventHandler(this.BtnShenron_Click);
            // 
            // imgListShenron
            // 
            this.imgListShenron.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListShenron.ImageStream")));
            this.imgListShenron.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListShenron.Images.SetKeyName(0, "shenron.png");
            // 
            // picBoxShenron
            // 
            this.picBoxShenron.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxShenron.Location = new System.Drawing.Point(832, 300);
            this.picBoxShenron.Name = "picBoxShenron";
            this.picBoxShenron.Size = new System.Drawing.Size(256, 256);
            this.picBoxShenron.TabIndex = 35;
            this.picBoxShenron.TabStop = false;
            this.picBoxShenron.Visible = false;
            // 
            // grpShenron
            // 
            this.grpShenron.BackColor = System.Drawing.Color.Transparent;
            this.grpShenron.Controls.Add(this.lblShenron);
            this.grpShenron.Font = new System.Drawing.Font("Prototype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpShenron.Location = new System.Drawing.Point(710, 570);
            this.grpShenron.Name = "grpShenron";
            this.grpShenron.Size = new System.Drawing.Size(500, 103);
            this.grpShenron.TabIndex = 30;
            this.grpShenron.TabStop = false;
            this.grpShenron.Text = "Shenron";
            this.grpShenron.Visible = false;
            // 
            // lblShenron
            // 
            this.lblShenron.AutoSize = true;
            this.lblShenron.Font = new System.Drawing.Font("Prototype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShenron.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblShenron.Location = new System.Drawing.Point(62, 44);
            this.lblShenron.Name = "lblShenron";
            this.lblShenron.Size = new System.Drawing.Size(384, 38);
            this.lblShenron.TabIndex = 0;
            this.lblShenron.Text = "Toi qui a réuni les 7 Dragon Balls... J\'exhauserai ton voeu.\r\nParle.";
            // 
            // btnShenron1
            // 
            this.btnShenron1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShenron1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnShenron1.FlatAppearance.BorderSize = 3;
            this.btnShenron1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShenron1.Location = new System.Drawing.Point(710, 680);
            this.btnShenron1.Name = "btnShenron1";
            this.btnShenron1.Size = new System.Drawing.Size(240, 50);
            this.btnShenron1.TabIndex = 36;
            this.btnShenron1.Text = "Je veux devenir plus fort !";
            this.btnShenron1.UseVisualStyleBackColor = false;
            this.btnShenron1.Visible = false;
            this.btnShenron1.Click += new System.EventHandler(this.BtnShenron1_Click);
            // 
            // btnShenron2
            // 
            this.btnShenron2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShenron2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnShenron2.FlatAppearance.BorderSize = 3;
            this.btnShenron2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShenron2.Location = new System.Drawing.Point(970, 680);
            this.btnShenron2.Name = "btnShenron2";
            this.btnShenron2.Size = new System.Drawing.Size(240, 50);
            this.btnShenron2.TabIndex = 37;
            this.btnShenron2.Text = "Je veux des haricots !";
            this.btnShenron2.UseVisualStyleBackColor = false;
            this.btnShenron2.Visible = false;
            this.btnShenron2.Click += new System.EventHandler(this.BtnShenron2_Click);
            // 
            // grpInfosAtk
            // 
            this.grpInfosAtk.BackColor = System.Drawing.Color.Transparent;
            this.grpInfosAtk.Controls.Add(this.lblInfosAtkTitre);
            this.grpInfosAtk.Controls.Add(this.lblInfosAtk);
            this.grpInfosAtk.Font = new System.Drawing.Font("Prototype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfosAtk.Location = new System.Drawing.Point(1477, 394);
            this.grpInfosAtk.Name = "grpInfosAtk";
            this.grpInfosAtk.Size = new System.Drawing.Size(320, 148);
            this.grpInfosAtk.TabIndex = 30;
            this.grpInfosAtk.TabStop = false;
            this.grpInfosAtk.Text = "Infos attaque";
            this.grpInfosAtk.Visible = false;
            // 
            // lblInfosAtkTitre
            // 
            this.lblInfosAtkTitre.AutoSize = true;
            this.lblInfosAtkTitre.Font = new System.Drawing.Font("Prototype", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfosAtkTitre.ForeColor = System.Drawing.Color.Black;
            this.lblInfosAtkTitre.Location = new System.Drawing.Point(24, 27);
            this.lblInfosAtkTitre.Name = "lblInfosAtkTitre";
            this.lblInfosAtkTitre.Size = new System.Drawing.Size(37, 20);
            this.lblInfosAtkTitre.TabIndex = 1;
            this.lblInfosAtkTitre.Text = "text";
            // 
            // lblInfosAtk
            // 
            this.lblInfosAtk.AutoSize = true;
            this.lblInfosAtk.Font = new System.Drawing.Font("Prototype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfosAtk.ForeColor = System.Drawing.Color.Black;
            this.lblInfosAtk.Location = new System.Drawing.Point(24, 58);
            this.lblInfosAtk.Name = "lblInfosAtk";
            this.lblInfosAtk.Size = new System.Drawing.Size(279, 19);
            this.lblInfosAtk.TabIndex = 0;
            this.lblInfosAtk.Text = "Ceci est un texte de test pour déterminer\r\n";
            // 
            // lblCrit
            // 
            this.lblCrit.AutoSize = true;
            this.lblCrit.Font = new System.Drawing.Font("Prototype", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrit.Location = new System.Drawing.Point(69, 92);
            this.lblCrit.Name = "lblCrit";
            this.lblCrit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCrit.Size = new System.Drawing.Size(94, 18);
            this.lblCrit.TabIndex = 5;
            this.lblCrit.Text = "Coup critique !";
            this.lblCrit.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 25);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // picBoxDB4
            // 
            this.picBoxDB4.BackColor = System.Drawing.Color.Transparent;
            this.picBoxDB4.Location = new System.Drawing.Point(945, 845);
            this.picBoxDB4.Name = "picBoxDB4";
            this.picBoxDB4.Size = new System.Drawing.Size(30, 30);
            this.picBoxDB4.TabIndex = 39;
            this.picBoxDB4.TabStop = false;
            this.picBoxDB4.Visible = false;
            // 
            // picBoxDB5
            // 
            this.picBoxDB5.BackColor = System.Drawing.Color.Transparent;
            this.picBoxDB5.Location = new System.Drawing.Point(1005, 845);
            this.picBoxDB5.Name = "picBoxDB5";
            this.picBoxDB5.Size = new System.Drawing.Size(30, 30);
            this.picBoxDB5.TabIndex = 40;
            this.picBoxDB5.TabStop = false;
            this.picBoxDB5.Visible = false;
            // 
            // picBoxDB6
            // 
            this.picBoxDB6.BackColor = System.Drawing.Color.Transparent;
            this.picBoxDB6.Location = new System.Drawing.Point(1065, 845);
            this.picBoxDB6.Name = "picBoxDB6";
            this.picBoxDB6.Size = new System.Drawing.Size(30, 30);
            this.picBoxDB6.TabIndex = 41;
            this.picBoxDB6.TabStop = false;
            this.picBoxDB6.Visible = false;
            // 
            // picBoxDB7
            // 
            this.picBoxDB7.BackColor = System.Drawing.Color.Transparent;
            this.picBoxDB7.Location = new System.Drawing.Point(1125, 845);
            this.picBoxDB7.Name = "picBoxDB7";
            this.picBoxDB7.Size = new System.Drawing.Size(30, 30);
            this.picBoxDB7.TabIndex = 42;
            this.picBoxDB7.TabStop = false;
            this.picBoxDB7.Visible = false;
            // 
            // picBoxDB3
            // 
            this.picBoxDB3.BackColor = System.Drawing.Color.Transparent;
            this.picBoxDB3.Location = new System.Drawing.Point(885, 845);
            this.picBoxDB3.Name = "picBoxDB3";
            this.picBoxDB3.Size = new System.Drawing.Size(30, 30);
            this.picBoxDB3.TabIndex = 43;
            this.picBoxDB3.TabStop = false;
            this.picBoxDB3.Visible = false;
            // 
            // picBoxDB2
            // 
            this.picBoxDB2.BackColor = System.Drawing.Color.Transparent;
            this.picBoxDB2.Location = new System.Drawing.Point(825, 845);
            this.picBoxDB2.Name = "picBoxDB2";
            this.picBoxDB2.Size = new System.Drawing.Size(30, 30);
            this.picBoxDB2.TabIndex = 44;
            this.picBoxDB2.TabStop = false;
            this.picBoxDB2.Visible = false;
            // 
            // picBoxDB1
            // 
            this.picBoxDB1.BackColor = System.Drawing.Color.Transparent;
            this.picBoxDB1.Location = new System.Drawing.Point(765, 845);
            this.picBoxDB1.Name = "picBoxDB1";
            this.picBoxDB1.Size = new System.Drawing.Size(30, 30);
            this.picBoxDB1.TabIndex = 45;
            this.picBoxDB1.TabStop = false;
            this.picBoxDB1.Visible = false;
            // 
            // imgListDB
            // 
            this.imgListDB.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListDB.ImageStream")));
            this.imgListDB.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListDB.Images.SetKeyName(0, "db_1.png");
            this.imgListDB.Images.SetKeyName(1, "db_2.png");
            this.imgListDB.Images.SetKeyName(2, "db_3.png");
            this.imgListDB.Images.SetKeyName(3, "db_4.png");
            this.imgListDB.Images.SetKeyName(4, "db_5.png");
            this.imgListDB.Images.SetKeyName(5, "db_6.png");
            this.imgListDB.Images.SetKeyName(6, "db_7.png");
            // 
            // frmDepart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::DragonRoad.Properties.Resources.back_menu;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.picBoxDB1);
            this.Controls.Add(this.picBoxDB2);
            this.Controls.Add(this.picBoxDB3);
            this.Controls.Add(this.picBoxDB7);
            this.Controls.Add(this.picBoxDB6);
            this.Controls.Add(this.picBoxDB5);
            this.Controls.Add(this.picBoxDB4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpInfosAtk);
            this.Controls.Add(this.btnShenron2);
            this.Controls.Add(this.btnShenron1);
            this.Controls.Add(this.grpShenron);
            this.Controls.Add(this.picBoxShenron);
            this.Controls.Add(this.btnShenron);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblNomAdversaire);
            this.Controls.Add(this.lblNomPersonnage);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRetourMenu);
            this.Controls.Add(this.grpResultats);
            this.Controls.Add(this.lblPvAdv);
            this.Controls.Add(this.lblPvPerso);
            this.Controls.Add(this.picBoxHealthBar2_2);
            this.Controls.Add(this.picBoxHealthBar2_1);
            this.Controls.Add(this.picBoxHealthBar1_2);
            this.Controls.Add(this.picBoxHealthBar1_1);
            this.Controls.Add(this.grpInfosAutres);
            this.Controls.Add(this.picBoxGauche);
            this.Controls.Add(this.picBoxDroite);
            this.Controls.Add(this.btnHaricot);
            this.Controls.Add(this.btnAtkSimple);
            this.Controls.Add(this.btnSpe2);
            this.Controls.Add(this.btnSpe1);
            this.Controls.Add(this.grpInfosCombat);
            this.Controls.Add(this.btnCombattre);
            this.Controls.Add(this.grpChoixEnnemi);
            this.Controls.Add(this.grpRecapInfos);
            this.Controls.Add(this.picBoxChara);
            this.Controls.Add(this.lblPuissance);
            this.Controls.Add(this.grpDif);
            this.Controls.Add(this.grpChoixPerso);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpRules);
            this.Controls.Add(this.txtNomMusic);
            this.Controls.Add(this.btnMusicStop);
            this.Controls.Add(this.btnMusic);
            this.Controls.Add(this.btnQuitter);
            this.Font = new System.Drawing.Font("Prototype", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDepart";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dragon Road";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpRules.ResumeLayout(false);
            this.grpRules.PerformLayout();
            this.grpChoixPerso.ResumeLayout(false);
            this.grpDif.ResumeLayout(false);
            this.grpDif.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxChara)).EndInit();
            this.grpRecapInfos.ResumeLayout(false);
            this.grpRecapInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCharaInfos)).EndInit();
            this.grpChoixEnnemi.ResumeLayout(false);
            this.grpChoixEnnemi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEnnemi)).EndInit();
            this.grpInfosCombat.ResumeLayout(false);
            this.grpInfosCombat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDroite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGauche)).EndInit();
            this.grpInfosAutres.ResumeLayout(false);
            this.grpInfosAutres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHealthBar1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHealthBar1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHealthBar2_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHealthBar2_2)).EndInit();
            this.grpResultats.ResumeLayout(false);
            this.grpResultats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShenron)).EndInit();
            this.grpShenron.ResumeLayout(false);
            this.grpShenron.PerformLayout();
            this.grpInfosAtk.ResumeLayout(false);
            this.grpInfosAtk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDB4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDB5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDB6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDB7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnMusicStop;
        private System.Windows.Forms.TextBox txtNomMusic;
        private System.Windows.Forms.GroupBox grpRules;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox grpChoixPerso;
        private System.Windows.Forms.ListBox lstPerso;
        private System.Windows.Forms.GroupBox grpDif;
        private System.Windows.Forms.RadioButton rdbDif4;
        private System.Windows.Forms.RadioButton rdbDif2;
        private System.Windows.Forms.RadioButton rdbDif3;
        private System.Windows.Forms.RadioButton rdbDif5;
        private System.Windows.Forms.RadioButton rdbDif1;
        private System.Windows.Forms.Button btnRandomChoice;
        private System.ComponentModel.BackgroundWorker bgwFondPrincipal;
        private System.Windows.Forms.Label lblPuissance;
        private System.Windows.Forms.PictureBox picBoxChara;
        private System.Windows.Forms.GroupBox grpRecapInfos;
        private System.Windows.Forms.Label lblMsgBonus;
        private System.Windows.Forms.Label lblTransfo;
        private System.Windows.Forms.Label lblAdversaireVaincu;
        private System.Windows.Forms.Label lblNumCombat;
        private System.Windows.Forms.Label lblNiveauSup;
        private System.Windows.Forms.Label lblXp;
        private System.Windows.Forms.GroupBox grpChoixEnnemi;
        private System.Windows.Forms.ListBox lstChoixEnnemi;
        private System.Windows.Forms.Button btnCombattre;
        private System.Windows.Forms.PictureBox picBoxEnnemi;
        private System.Windows.Forms.Label lblForceEnnemi;
        public System.Windows.Forms.ImageList imgListStart;
        private System.Windows.Forms.Label lblInfoNiveau;
        private System.Windows.Forms.PictureBox picCharaInfos;
        private System.Windows.Forms.ImageList imgListOther;
        private System.Windows.Forms.GroupBox grpInfosCombat;
        private System.Windows.Forms.Button btnSpe1;
        private System.Windows.Forms.Button btnSpe2;
        private System.Windows.Forms.Button btnAtkSimple;
        private System.Windows.Forms.Button btnHaricot;
        private System.Windows.Forms.PictureBox picBoxDroite;
        private System.Windows.Forms.PictureBox picBoxGauche;
        private System.Windows.Forms.Label lblEsquive;
        private System.Windows.Forms.Label lblAdvDegats;
        private System.Windows.Forms.Label lblPersoDegats;
        private System.Windows.Forms.Label lblAdvAtk;
        private System.Windows.Forms.Label lblPersoAtk;
        private System.Windows.Forms.GroupBox grpInfosAutres;
        private System.Windows.Forms.Label lblHaricotsRestants;
        private System.Windows.Forms.Label lblSta;
        private System.Windows.Forms.PictureBox picBoxHealthBar1_1;
        private System.Windows.Forms.PictureBox picBoxHealthBar1_2;
        private System.Windows.Forms.PictureBox picBoxHealthBar2_1;
        private System.Windows.Forms.PictureBox picBoxHealthBar2_2;
        private System.Windows.Forms.Label lblPvAdv;
        private System.Windows.Forms.Label lblPvPerso;
        private System.Windows.Forms.GroupBox grpResultats;
        private System.Windows.Forms.Label lblMsgFin;
        private System.Windows.Forms.Button btnRetourMenu;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNomPersonnage;
        private System.Windows.Forms.Label lblNomAdversaire;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblDB;
        private System.Windows.Forms.Label lblNbDB;
        private System.Windows.Forms.Button btnShenron;
        private System.Windows.Forms.ImageList imgListShenron;
        private System.Windows.Forms.PictureBox picBoxShenron;
        private System.Windows.Forms.GroupBox grpShenron;
        private System.Windows.Forms.Label lblShenron;
        private System.Windows.Forms.Button btnShenron1;
        private System.Windows.Forms.Button btnShenron2;
        private System.Windows.Forms.GroupBox grpInfosAtk;
        private System.Windows.Forms.Label lblInfosAtk;
        private System.Windows.Forms.Label lblInfosAtkTitre;
        private System.Windows.Forms.Label lblCrit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBoxDB4;
        private System.Windows.Forms.PictureBox picBoxDB5;
        private System.Windows.Forms.PictureBox picBoxDB6;
        private System.Windows.Forms.PictureBox picBoxDB7;
        private System.Windows.Forms.PictureBox picBoxDB3;
        private System.Windows.Forms.PictureBox picBoxDB2;
        private System.Windows.Forms.PictureBox picBoxDB1;
        private System.Windows.Forms.ImageList imgListDB;
    }
}