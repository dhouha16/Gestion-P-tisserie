namespace MiniProjet_ModeDeconnecter
{
    partial class Gestion_de_dessert
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
            this.ListeDessert = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.choisir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.prix = new System.Windows.Forms.TextBox();
            this.button_quitter = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.button_nouveau = new System.Windows.Forms.Button();
            this.textnomDessert = new System.Windows.Forms.TextBox();
            this.textcodeDessert = new System.Windows.Forms.TextBox();
            this.prix_dessert = new System.Windows.Forms.Label();
            this.nom_dessert = new System.Windows.Forms.Label();
            this.code_dessert = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListeDessert)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListeDessert
            // 
            this.ListeDessert.BackgroundColor = System.Drawing.Color.Violet;
            this.ListeDessert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeDessert.GridColor = System.Drawing.Color.LightCoral;
            this.ListeDessert.Location = new System.Drawing.Point(61, 389);
            this.ListeDessert.Name = "ListeDessert";
            this.ListeDessert.Size = new System.Drawing.Size(576, 144);
            this.ListeDessert.TabIndex = 3;
            this.ListeDessert.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListeDessert_CellContentClick);
            this.ListeDessert.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ListeDessert_RowHeaderMouseClick);
            this.ListeDessert.RowHeaderCellChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.ListeDessert_RowHeaderCellChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::MiniProjet_ModeDeconnecter.Properties.Resources.d2e628e31075cc701192331e895f23802;
            this.groupBox1.Controls.Add(this.choisir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.prix);
            this.groupBox1.Controls.Add(this.button_quitter);
            this.groupBox1.Controls.Add(this.button_supprimer);
            this.groupBox1.Controls.Add(this.button_modifier);
            this.groupBox1.Controls.Add(this.button_ajouter);
            this.groupBox1.Controls.Add(this.button_nouveau);
            this.groupBox1.Controls.Add(this.textnomDessert);
            this.groupBox1.Controls.Add(this.textcodeDessert);
            this.groupBox1.Controls.Add(this.prix_dessert);
            this.groupBox1.Controls.Add(this.nom_dessert);
            this.groupBox1.Controls.Add(this.code_dessert);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(61, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 435);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion de dessert";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // choisir
            // 
            this.choisir.BackColor = System.Drawing.SystemColors.Control;
            this.choisir.Location = new System.Drawing.Point(117, 193);
            this.choisir.Name = "choisir";
            this.choisir.Size = new System.Drawing.Size(75, 23);
            this.choisir.TabIndex = 4;
            this.choisir.Text = "choisr une image";
            this.choisir.UseVisualStyleBackColor = false;
            this.choisir.Click += new System.EventHandler(this.choisir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "choisir une image";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(218, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // prix
            // 
            this.prix.Location = new System.Drawing.Point(218, 127);
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(142, 23);
            this.prix.TabIndex = 8;
            // 
            // button_quitter
            // 
            this.button_quitter.Location = new System.Drawing.Point(432, 193);
            this.button_quitter.Name = "button_quitter";
            this.button_quitter.Size = new System.Drawing.Size(138, 23);
            this.button_quitter.TabIndex = 7;
            this.button_quitter.Text = "quitter";
            this.button_quitter.UseVisualStyleBackColor = true;
            this.button_quitter.Click += new System.EventHandler(this.button_quitter_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.Location = new System.Drawing.Point(432, 154);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(138, 23);
            this.button_supprimer.TabIndex = 7;
            this.button_supprimer.Text = "supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // button_modifier
            // 
            this.button_modifier.Location = new System.Drawing.Point(432, 115);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(138, 23);
            this.button_modifier.TabIndex = 7;
            this.button_modifier.Text = "modifier";
            this.button_modifier.UseVisualStyleBackColor = true;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // button_ajouter
            // 
            this.button_ajouter.Location = new System.Drawing.Point(432, 76);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(138, 23);
            this.button_ajouter.TabIndex = 7;
            this.button_ajouter.Text = "ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // button_nouveau
            // 
            this.button_nouveau.Location = new System.Drawing.Point(432, 37);
            this.button_nouveau.Name = "button_nouveau";
            this.button_nouveau.Size = new System.Drawing.Size(138, 23);
            this.button_nouveau.TabIndex = 7;
            this.button_nouveau.Text = "nouveau";
            this.button_nouveau.UseVisualStyleBackColor = true;
            this.button_nouveau.Click += new System.EventHandler(this.button_nouveau_Click);
            // 
            // textnomDessert
            // 
            this.textnomDessert.Location = new System.Drawing.Point(218, 86);
            this.textnomDessert.Name = "textnomDessert";
            this.textnomDessert.Size = new System.Drawing.Size(142, 23);
            this.textnomDessert.TabIndex = 2;
            // 
            // textcodeDessert
            // 
            this.textcodeDessert.Location = new System.Drawing.Point(218, 43);
            this.textcodeDessert.Name = "textcodeDessert";
            this.textcodeDessert.Size = new System.Drawing.Size(142, 23);
            this.textcodeDessert.TabIndex = 1;
            // 
            // prix_dessert
            // 
            this.prix_dessert.AutoSize = true;
            this.prix_dessert.Location = new System.Drawing.Point(160, 127);
            this.prix_dessert.Name = "prix_dessert";
            this.prix_dessert.Size = new System.Drawing.Size(32, 18);
            this.prix_dessert.TabIndex = 0;
            this.prix_dessert.Text = "prix";
            // 
            // nom_dessert
            // 
            this.nom_dessert.AutoSize = true;
            this.nom_dessert.Location = new System.Drawing.Point(114, 89);
            this.nom_dessert.Name = "nom_dessert";
            this.nom_dessert.Size = new System.Drawing.Size(88, 18);
            this.nom_dessert.TabIndex = 0;
            this.nom_dessert.Text = "Nom Dessert";
            // 
            // code_dessert
            // 
            this.code_dessert.AutoSize = true;
            this.code_dessert.Location = new System.Drawing.Point(102, 48);
            this.code_dessert.Name = "code_dessert";
            this.code_dessert.Size = new System.Drawing.Size(90, 18);
            this.code_dessert.TabIndex = 0;
            this.code_dessert.Text = "code dessert";
            // 
            // Gestion_de_dessert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MiniProjet_ModeDeconnecter.Properties.Resources.d2e628e31075cc701192331e895f23801;
            this.ClientSize = new System.Drawing.Size(714, 545);
            this.Controls.Add(this.ListeDessert);
            this.Controls.Add(this.groupBox1);
            this.Name = "Gestion_de_dessert";
            this.Text = "Gestion_de_commande";
            this.Load += new System.EventHandler(this.Gestion_de_commande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListeDessert)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListeDessert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_quitter;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Button button_nouveau;
        private System.Windows.Forms.TextBox textnomDessert;
        private System.Windows.Forms.TextBox textcodeDessert;
        private System.Windows.Forms.Label prix_dessert;
        private System.Windows.Forms.Label nom_dessert;
        private System.Windows.Forms.Label code_dessert;
        private System.Windows.Forms.TextBox prix;
        private System.Windows.Forms.Button choisir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}