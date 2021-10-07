namespace MiniProjet_ModeDeconnecter
{
    partial class Gestion_de_commande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_de_commande));
            this.ListeCommande = new System.Windows.Forms.DataGridView();
            this.client = new System.Windows.Forms.GroupBox();
            this.combclient = new System.Windows.Forms.ComboBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.codeDessert = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.Label();
            this.adresse_client = new System.Windows.Forms.Label();
            this.button_quitter = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.button_nouveau = new System.Windows.Forms.Button();
            this.NumCommande = new System.Windows.Forms.TextBox();
            this.nom_client = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListeCommande)).BeginInit();
            this.client.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListeCommande
            // 
            this.ListeCommande.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ListeCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeCommande.Location = new System.Drawing.Point(66, 355);
            this.ListeCommande.Name = "ListeCommande";
            this.ListeCommande.Size = new System.Drawing.Size(542, 144);
            this.ListeCommande.TabIndex = 7;
            this.ListeCommande.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ListeCommande_RowHeaderMouseClick);
            this.ListeCommande.RowHeaderCellChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.ListeCommande_RowHeaderCellChanged);
            // 
            // client
            // 
            this.client.BackgroundImage = global::MiniProjet_ModeDeconnecter.Properties.Resources._85400a9ed5fff674f82da2d064636dd4;
            this.client.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.client.Controls.Add(this.combclient);
            this.client.Controls.Add(this.dateTime);
            this.client.Controls.Add(this.codeDessert);
            this.client.Controls.Add(this.tel);
            this.client.Controls.Add(this.adresse_client);
            this.client.Controls.Add(this.button_quitter);
            this.client.Controls.Add(this.button_supprimer);
            this.client.Controls.Add(this.button_modifier);
            this.client.Controls.Add(this.button_ajouter);
            this.client.Controls.Add(this.button_nouveau);
            this.client.Controls.Add(this.NumCommande);
            this.client.Controls.Add(this.nom_client);
            this.client.Controls.Add(this.num);
            this.client.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client.Location = new System.Drawing.Point(38, 12);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(633, 487);
            this.client.TabIndex = 6;
            this.client.TabStop = false;
            this.client.Text = "Gestion de commande";
            // 
            // combclient
            // 
            this.combclient.FormattingEnabled = true;
            this.combclient.Location = new System.Drawing.Point(218, 83);
            this.combclient.Name = "combclient";
            this.combclient.Size = new System.Drawing.Size(142, 26);
            this.combclient.TabIndex = 15;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(218, 170);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(138, 23);
            this.dateTime.TabIndex = 12;
            // 
            // codeDessert
            // 
            this.codeDessert.Location = new System.Drawing.Point(218, 131);
            this.codeDessert.Name = "codeDessert";
            this.codeDessert.Size = new System.Drawing.Size(142, 23);
            this.codeDessert.TabIndex = 10;
            // 
            // tel
            // 
            this.tel.AutoSize = true;
            this.tel.Location = new System.Drawing.Point(56, 174);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(129, 18);
            this.tel.TabIndex = 8;
            this.tel.Text = "date de commande";
            // 
            // adresse_client
            // 
            this.adresse_client.AutoSize = true;
            this.adresse_client.Location = new System.Drawing.Point(56, 138);
            this.adresse_client.Name = "adresse_client";
            this.adresse_client.Size = new System.Drawing.Size(90, 18);
            this.adresse_client.TabIndex = 9;
            this.adresse_client.Text = "code dessert";
            // 
            // button_quitter
            // 
            this.button_quitter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_quitter.Location = new System.Drawing.Point(432, 193);
            this.button_quitter.Name = "button_quitter";
            this.button_quitter.Size = new System.Drawing.Size(138, 23);
            this.button_quitter.TabIndex = 7;
            this.button_quitter.Text = "quitter";
            this.button_quitter.UseVisualStyleBackColor = false;
            this.button_quitter.Click += new System.EventHandler(this.button_quitter_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_supprimer.Location = new System.Drawing.Point(432, 154);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(138, 23);
            this.button_supprimer.TabIndex = 7;
            this.button_supprimer.Text = "supprimer";
            this.button_supprimer.UseVisualStyleBackColor = false;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // button_modifier
            // 
            this.button_modifier.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_modifier.Location = new System.Drawing.Point(432, 115);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(138, 23);
            this.button_modifier.TabIndex = 7;
            this.button_modifier.Text = "modifier";
            this.button_modifier.UseVisualStyleBackColor = false;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // button_ajouter
            // 
            this.button_ajouter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_ajouter.Location = new System.Drawing.Point(432, 76);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(138, 23);
            this.button_ajouter.TabIndex = 7;
            this.button_ajouter.Text = "ajouter";
            this.button_ajouter.UseVisualStyleBackColor = false;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // button_nouveau
            // 
            this.button_nouveau.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_nouveau.Location = new System.Drawing.Point(432, 37);
            this.button_nouveau.Name = "button_nouveau";
            this.button_nouveau.Size = new System.Drawing.Size(138, 29);
            this.button_nouveau.TabIndex = 7;
            this.button_nouveau.Text = "nouveau";
            this.button_nouveau.UseVisualStyleBackColor = false;
            this.button_nouveau.Click += new System.EventHandler(this.button_nouveau_Click);
            // 
            // NumCommande
            // 
            this.NumCommande.Location = new System.Drawing.Point(218, 43);
            this.NumCommande.Name = "NumCommande";
            this.NumCommande.Size = new System.Drawing.Size(142, 23);
            this.NumCommande.TabIndex = 1;
            // 
            // nom_client
            // 
            this.nom_client.AutoSize = true;
            this.nom_client.Location = new System.Drawing.Point(56, 86);
            this.nom_client.Name = "nom_client";
            this.nom_client.Size = new System.Drawing.Size(79, 18);
            this.nom_client.TabIndex = 0;
            this.nom_client.Text = "code client";
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Location = new System.Drawing.Point(56, 50);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(149, 18);
            this.num.TabIndex = 0;
            this.num.Text = "Numéro de commande";
            // 
            // Gestion_de_commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MiniProjet_ModeDeconnecter.Properties.Resources._85400a9ed5fff674f82da2d064636dd4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(709, 511);
            this.Controls.Add(this.ListeCommande);
            this.Controls.Add(this.client);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gestion_de_commande";
            this.Text = "Gestion_de_commande";
            this.Load += new System.EventHandler(this.Gestion_de_commande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListeCommande)).EndInit();
            this.client.ResumeLayout(false);
            this.client.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListeCommande;
        private System.Windows.Forms.GroupBox client;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.TextBox codeDessert;
        private System.Windows.Forms.Label tel;
        private System.Windows.Forms.Label adresse_client;
        private System.Windows.Forms.Button button_quitter;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Button button_nouveau;
        private System.Windows.Forms.TextBox NumCommande;
        private System.Windows.Forms.Label nom_client;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.ComboBox combclient;
    }
}