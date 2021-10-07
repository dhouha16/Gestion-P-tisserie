namespace MiniProjet_ModeDeconnecter
{
    partial class ListeCLient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listeC = new System.Windows.Forms.DataGridView();
            this.recherche = new System.Windows.Forms.TextBox();
            this.rechercher = new System.Windows.Forms.Button();
            this.dessert = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numTel1 = new System.Windows.Forms.TextBox();
            this.AdresseClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.TextBox();
            this.button_quitter = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_nouveau = new System.Windows.Forms.Button();
            this.textnomClient = new System.Windows.Forms.TextBox();
            this.textcodeClient = new System.Windows.Forms.TextBox();
            this.prenomclient = new System.Windows.Forms.Label();
            this.nomClient = new System.Windows.Forms.Label();
            this.codeClient = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listeC)).BeginInit();
            this.SuspendLayout();
            // 
            // listeC
            // 
            this.listeC.BackgroundColor = System.Drawing.Color.Tan;
            this.listeC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeC.Location = new System.Drawing.Point(87, 295);
            this.listeC.Name = "listeC";
            this.listeC.Size = new System.Drawing.Size(601, 223);
            this.listeC.TabIndex = 0;
            this.listeC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.listeC.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.listeC_RowHeaderMouseClick);
            // 
            // recherche
            // 
            this.recherche.Location = new System.Drawing.Point(398, 269);
            this.recherche.Name = "recherche";
            this.recherche.Size = new System.Drawing.Size(152, 20);
            this.recherche.TabIndex = 1;
            // 
            // rechercher
            // 
            this.rechercher.BackColor = System.Drawing.Color.Tan;
            this.rechercher.Location = new System.Drawing.Point(565, 252);
            this.rechercher.Name = "rechercher";
            this.rechercher.Size = new System.Drawing.Size(148, 37);
            this.rechercher.TabIndex = 2;
            this.rechercher.Text = "rechercher";
            this.rechercher.UseVisualStyleBackColor = false;
            this.rechercher.Click += new System.EventHandler(this.rechercher_Click);
            // 
            // dessert
            // 
            this.dessert.FormattingEnabled = true;
            this.dessert.Location = new System.Drawing.Point(150, 252);
            this.dessert.Name = "dessert";
            this.dessert.Size = new System.Drawing.Size(143, 21);
            this.dessert.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "mon dessert";
            // 
            // numTel1
            // 
            this.numTel1.Location = new System.Drawing.Point(150, 226);
            this.numTel1.Name = "numTel1";
            this.numTel1.Size = new System.Drawing.Size(142, 20);
            this.numTel1.TabIndex = 31;
            // 
            // AdresseClient
            // 
            this.AdresseClient.Location = new System.Drawing.Point(150, 190);
            this.AdresseClient.Name = "AdresseClient";
            this.AdresseClient.Size = new System.Drawing.Size(142, 20);
            this.AdresseClient.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Telephone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Adresse";
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(150, 164);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(142, 20);
            this.prenom.TabIndex = 27;
            // 
            // button_quitter
            // 
            this.button_quitter.BackColor = System.Drawing.Color.BurlyWood;
            this.button_quitter.Location = new System.Drawing.Point(346, 199);
            this.button_quitter.Name = "button_quitter";
            this.button_quitter.Size = new System.Drawing.Size(138, 23);
            this.button_quitter.TabIndex = 26;
            this.button_quitter.Text = "quitter";
            this.button_quitter.UseVisualStyleBackColor = false;
            this.button_quitter.Click += new System.EventHandler(this.button_quitter_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.BackColor = System.Drawing.Color.BurlyWood;
            this.button_supprimer.Location = new System.Drawing.Point(346, 170);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(138, 23);
            this.button_supprimer.TabIndex = 25;
            this.button_supprimer.Text = "supprimer";
            this.button_supprimer.UseVisualStyleBackColor = false;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // button_modifier
            // 
            this.button_modifier.BackColor = System.Drawing.Color.BurlyWood;
            this.button_modifier.Location = new System.Drawing.Point(346, 141);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(138, 23);
            this.button_modifier.TabIndex = 24;
            this.button_modifier.Text = "modifier";
            this.button_modifier.UseVisualStyleBackColor = false;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // button_nouveau
            // 
            this.button_nouveau.BackColor = System.Drawing.Color.BurlyWood;
            this.button_nouveau.Location = new System.Drawing.Point(346, 107);
            this.button_nouveau.Name = "button_nouveau";
            this.button_nouveau.Size = new System.Drawing.Size(138, 23);
            this.button_nouveau.TabIndex = 22;
            this.button_nouveau.Text = "nouveau";
            this.button_nouveau.UseVisualStyleBackColor = false;
            this.button_nouveau.Click += new System.EventHandler(this.button_nouveau_Click);
            // 
            // textnomClient
            // 
            this.textnomClient.Location = new System.Drawing.Point(150, 138);
            this.textnomClient.Name = "textnomClient";
            this.textnomClient.Size = new System.Drawing.Size(142, 20);
            this.textnomClient.TabIndex = 21;
            // 
            // textcodeClient
            // 
            this.textcodeClient.Location = new System.Drawing.Point(150, 112);
            this.textcodeClient.Name = "textcodeClient";
            this.textcodeClient.Size = new System.Drawing.Size(142, 20);
            this.textcodeClient.TabIndex = 20;
            // 
            // prenomclient
            // 
            this.prenomclient.AutoSize = true;
            this.prenomclient.Location = new System.Drawing.Point(95, 167);
            this.prenomclient.Name = "prenomclient";
            this.prenomclient.Size = new System.Drawing.Size(43, 13);
            this.prenomclient.TabIndex = 18;
            this.prenomclient.Text = "Prenom";
            // 
            // nomClient
            // 
            this.nomClient.AutoSize = true;
            this.nomClient.Location = new System.Drawing.Point(95, 141);
            this.nomClient.Name = "nomClient";
            this.nomClient.Size = new System.Drawing.Size(32, 13);
            this.nomClient.TabIndex = 19;
            this.nomClient.Text = "Nom ";
            // 
            // codeClient
            // 
            this.codeClient.AutoSize = true;
            this.codeClient.Location = new System.Drawing.Point(89, 112);
            this.codeClient.Name = "codeClient";
            this.codeClient.Size = new System.Drawing.Size(59, 13);
            this.codeClient.TabIndex = 17;
            this.codeClient.Text = "code client";
            // 
            // ListeCLient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MiniProjet_ModeDeconnecter.Properties.Resources._516301e3d3ac261acc953470770861b31;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(741, 530);
            this.Controls.Add(this.dessert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numTel1);
            this.Controls.Add(this.AdresseClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.button_quitter);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.button_modifier);
            this.Controls.Add(this.button_nouveau);
            this.Controls.Add(this.textnomClient);
            this.Controls.Add(this.textcodeClient);
            this.Controls.Add(this.prenomclient);
            this.Controls.Add(this.nomClient);
            this.Controls.Add(this.codeClient);
            this.Controls.Add(this.rechercher);
            this.Controls.Add(this.recherche);
            this.Controls.Add(this.listeC);
            this.Name = "ListeCLient";
            this.Text = "ListeCLient";
            this.Load += new System.EventHandler(this.ListeCLient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listeC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listeC;
        private System.Windows.Forms.TextBox recherche;
        private System.Windows.Forms.Button rechercher;
        private System.Windows.Forms.ComboBox dessert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numTel1;
        private System.Windows.Forms.TextBox AdresseClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.Button button_quitter;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_nouveau;
        private System.Windows.Forms.TextBox textnomClient;
        private System.Windows.Forms.TextBox textcodeClient;
        private System.Windows.Forms.Label prenomclient;
        private System.Windows.Forms.Label nomClient;
        private System.Windows.Forms.Label codeClient;
    }
}