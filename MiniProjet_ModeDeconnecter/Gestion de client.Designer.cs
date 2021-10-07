namespace MiniProjet_ModeDeconnecter
{
    partial class Gestion_de_client
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
            this.GestionClient = new System.Windows.Forms.GroupBox();
            this.dessert = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numTel1 = new System.Windows.Forms.TextBox();
            this.AdresseClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.TextBox();
            this.button_quitter = new System.Windows.Forms.Button();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.button_nouveau = new System.Windows.Forms.Button();
            this.textnomClient = new System.Windows.Forms.TextBox();
            this.textcodeClient = new System.Windows.Forms.TextBox();
            this.prenomclient = new System.Windows.Forms.Label();
            this.nomClient = new System.Windows.Forms.Label();
            this.codeClient = new System.Windows.Forms.Label();
            this.listeClient = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.GestionClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // GestionClient
            // 
            this.GestionClient.BackColor = System.Drawing.Color.IndianRed;
            this.GestionClient.BackgroundImage = global::MiniProjet_ModeDeconnecter.Properties.Resources.d2e628e31075cc701192331e895f2380;
            this.GestionClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GestionClient.Controls.Add(this.pictureBox3);
            this.GestionClient.Controls.Add(this.pictureBox2);
            this.GestionClient.Controls.Add(this.pictureBox1);
            this.GestionClient.Controls.Add(this.dessert);
            this.GestionClient.Controls.Add(this.label3);
            this.GestionClient.Controls.Add(this.numTel1);
            this.GestionClient.Controls.Add(this.AdresseClient);
            this.GestionClient.Controls.Add(this.label1);
            this.GestionClient.Controls.Add(this.label2);
            this.GestionClient.Controls.Add(this.prenom);
            this.GestionClient.Controls.Add(this.button_quitter);
            this.GestionClient.Controls.Add(this.button_ajouter);
            this.GestionClient.Controls.Add(this.button_nouveau);
            this.GestionClient.Controls.Add(this.textnomClient);
            this.GestionClient.Controls.Add(this.textcodeClient);
            this.GestionClient.Controls.Add(this.prenomclient);
            this.GestionClient.Controls.Add(this.nomClient);
            this.GestionClient.Controls.Add(this.codeClient);
            this.GestionClient.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GestionClient.Location = new System.Drawing.Point(37, 12);
            this.GestionClient.Name = "GestionClient";
            this.GestionClient.Size = new System.Drawing.Size(576, 468);
            this.GestionClient.TabIndex = 4;
            this.GestionClient.TabStop = false;
            this.GestionClient.Text = "Gestion de client";
            this.GestionClient.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dessert
            // 
            this.dessert.FormattingEnabled = true;
            this.dessert.Location = new System.Drawing.Point(222, 222);
            this.dessert.Name = "dessert";
            this.dessert.Size = new System.Drawing.Size(138, 26);
            this.dessert.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "mon dessert";
            // 
            // numTel1
            // 
            this.numTel1.Location = new System.Drawing.Point(218, 185);
            this.numTel1.Name = "numTel1";
            this.numTel1.Size = new System.Drawing.Size(142, 23);
            this.numTel1.TabIndex = 12;
            // 
            // AdresseClient
            // 
            this.AdresseClient.Location = new System.Drawing.Point(218, 156);
            this.AdresseClient.Name = "AdresseClient";
            this.AdresseClient.Size = new System.Drawing.Size(142, 23);
            this.AdresseClient.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Telephone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Adresse";
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(218, 127);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(142, 23);
            this.prenom.TabIndex = 8;
            // 
            // button_quitter
            // 
            this.button_quitter.Location = new System.Drawing.Point(420, 161);
            this.button_quitter.Name = "button_quitter";
            this.button_quitter.Size = new System.Drawing.Size(138, 47);
            this.button_quitter.TabIndex = 7;
            this.button_quitter.Text = "quitter";
            this.button_quitter.UseVisualStyleBackColor = true;
            this.button_quitter.Click += new System.EventHandler(this.button_quitter_Click);
            // 
            // button_ajouter
            // 
            this.button_ajouter.Location = new System.Drawing.Point(420, 84);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(138, 52);
            this.button_ajouter.TabIndex = 7;
            this.button_ajouter.Text = "ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // button_nouveau
            // 
            this.button_nouveau.Location = new System.Drawing.Point(420, 22);
            this.button_nouveau.Name = "button_nouveau";
            this.button_nouveau.Size = new System.Drawing.Size(138, 44);
            this.button_nouveau.TabIndex = 7;
            this.button_nouveau.Text = "nouveau";
            this.button_nouveau.UseVisualStyleBackColor = true;
            this.button_nouveau.Click += new System.EventHandler(this.button_nouveau_Click);
            // 
            // textnomClient
            // 
            this.textnomClient.Location = new System.Drawing.Point(218, 86);
            this.textnomClient.Name = "textnomClient";
            this.textnomClient.Size = new System.Drawing.Size(142, 23);
            this.textnomClient.TabIndex = 2;
            // 
            // textcodeClient
            // 
            this.textcodeClient.Location = new System.Drawing.Point(218, 43);
            this.textcodeClient.Name = "textcodeClient";
            this.textcodeClient.Size = new System.Drawing.Size(142, 23);
            this.textcodeClient.TabIndex = 1;
            // 
            // prenomclient
            // 
            this.prenomclient.AutoSize = true;
            this.prenomclient.Location = new System.Drawing.Point(142, 132);
            this.prenomclient.Name = "prenomclient";
            this.prenomclient.Size = new System.Drawing.Size(55, 18);
            this.prenomclient.TabIndex = 0;
            this.prenomclient.Text = "Prenom";
            // 
            // nomClient
            // 
            this.nomClient.AutoSize = true;
            this.nomClient.Location = new System.Drawing.Point(157, 91);
            this.nomClient.Name = "nomClient";
            this.nomClient.Size = new System.Drawing.Size(40, 18);
            this.nomClient.TabIndex = 0;
            this.nomClient.Text = "Nom ";
            // 
            // codeClient
            // 
            this.codeClient.AutoSize = true;
            this.codeClient.Location = new System.Drawing.Point(133, 48);
            this.codeClient.Name = "codeClient";
            this.codeClient.Size = new System.Drawing.Size(79, 18);
            this.codeClient.TabIndex = 0;
            this.codeClient.Text = "code client";
            // 
            // listeClient
            // 
            this.listeClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listeClient.BackgroundColor = System.Drawing.Color.LightCoral;
            this.listeClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listeClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeClient.GridColor = System.Drawing.Color.MistyRose;
            this.listeClient.Location = new System.Drawing.Point(86, 336);
            this.listeClient.Name = "listeClient";
            this.listeClient.Size = new System.Drawing.Size(542, 164);
            this.listeClient.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Image = global::MiniProjet_ModeDeconnecter.Properties.Resources.icons8_contact_d_affaires_100___Copie;
            this.pictureBox1.Location = new System.Drawing.Point(515, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox2.Image = global::MiniProjet_ModeDeconnecter.Properties.Resources.icons8_conférence_50;
            this.pictureBox2.Location = new System.Drawing.Point(515, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox3.Image = global::MiniProjet_ModeDeconnecter.Properties.Resources.icons8_retour_50;
            this.pictureBox3.Location = new System.Drawing.Point(515, 161);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // Gestion_de_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = global::MiniProjet_ModeDeconnecter.Properties.Resources.d2e628e31075cc701192331e895f2380;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(723, 492);
            this.Controls.Add(this.listeClient);
            this.Controls.Add(this.GestionClient);
            this.Name = "Gestion_de_client";
            this.Text = "Gestion_de_client";
            this.Load += new System.EventHandler(this.Gestion_de_client_Load);
            this.GestionClient.ResumeLayout(false);
            this.GestionClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GestionClient;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.Button button_quitter;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Button button_nouveau;
        private System.Windows.Forms.TextBox textnomClient;
        private System.Windows.Forms.TextBox textcodeClient;
        private System.Windows.Forms.Label prenomclient;
        private System.Windows.Forms.Label nomClient;
        private System.Windows.Forms.Label codeClient;
        private System.Windows.Forms.TextBox numTel1;
        private System.Windows.Forms.TextBox AdresseClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox dessert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView listeClient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}