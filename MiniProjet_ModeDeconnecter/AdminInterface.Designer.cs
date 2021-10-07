namespace MiniProjet_ModeDeconnecter
{
    partial class AdminInterface
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
            this.Commande = new System.Windows.Forms.Button();
            this.Dessert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Commande
            // 
            this.Commande.BackgroundImage = global::MiniProjet_ModeDeconnecter.Properties.Resources._0_2b9452_ddb55a89_XXXL;
            this.Commande.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Commande.Location = new System.Drawing.Point(265, 222);
            this.Commande.Name = "Commande";
            this.Commande.Size = new System.Drawing.Size(220, 45);
            this.Commande.TabIndex = 2;
            this.Commande.Text = "Gestion des commandes";
            this.Commande.UseVisualStyleBackColor = true;
            this.Commande.Click += new System.EventHandler(this.button3_Click);
            // 
            // Dessert
            // 
            this.Dessert.BackgroundImage = global::MiniProjet_ModeDeconnecter.Properties.Resources._0_2b9452_ddb55a89_XXXL;
            this.Dessert.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dessert.Location = new System.Drawing.Point(265, 273);
            this.Dessert.Name = "Dessert";
            this.Dessert.Size = new System.Drawing.Size(220, 45);
            this.Dessert.TabIndex = 3;
            this.Dessert.Text = "Gestion des dessert";
            this.Dessert.UseVisualStyleBackColor = true;
            this.Dessert.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::MiniProjet_ModeDeconnecter.Properties.Resources._0_2b9452_ddb55a89_XXXL;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(265, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Gestion des dessert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MiniProjet_ModeDeconnecter.Properties.Resources._0_2b9452_ddb55a89_XXXL;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dessert);
            this.Controls.Add(this.Commande);
            this.Name = "AdminInterface";
            this.Text = "AdminInterface";
            this.Load += new System.EventHandler(this.AdminInterface_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Commande;
        private System.Windows.Forms.Button Dessert;
        private System.Windows.Forms.Button button1;
    }
}