namespace MiniProjet_ModeDeconnecter
{
    partial class Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            this.Dessert1 = new System.Windows.Forms.Button();
            this.Commande = new System.Windows.Forms.Button();
            this.Service = new System.Windows.Forms.Button();
            this.Client = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dessert1
            // 
            this.Dessert1.BackgroundImage = global::MiniProjet_ModeDeconnecter.Properties.Resources._0_2b9452_ddb55a89_XXXL;
            this.Dessert1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dessert1.Location = new System.Drawing.Point(290, 250);
            this.Dessert1.Name = "Dessert1";
            this.Dessert1.Size = new System.Drawing.Size(220, 45);
            this.Dessert1.TabIndex = 6;
            this.Dessert1.Text = "Gestion des dessert";
            this.Dessert1.UseVisualStyleBackColor = true;
            this.Dessert1.Click += new System.EventHandler(this.Dessert1_Click);
            // 
            // Commande
            // 
            this.Commande.BackgroundImage = global::MiniProjet_ModeDeconnecter.Properties.Resources._0_2b9452_ddb55a89_XXXL;
            this.Commande.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Commande.Location = new System.Drawing.Point(290, 199);
            this.Commande.Name = "Commande";
            this.Commande.Size = new System.Drawing.Size(220, 45);
            this.Commande.TabIndex = 5;
            this.Commande.Text = "Gestion des commandes";
            this.Commande.UseVisualStyleBackColor = true;
            this.Commande.Click += new System.EventHandler(this.Commande_Click);
            // 
            // Service
            // 
            this.Service.BackgroundImage = global::MiniProjet_ModeDeconnecter.Properties.Resources._0_2b9452_ddb55a89_XXXL;
            this.Service.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Service.Image = global::MiniProjet_ModeDeconnecter.Properties.Resources._0_2b9452_ddb55a89_XXXL;
            this.Service.Location = new System.Drawing.Point(290, 156);
            this.Service.Name = "Service";
            this.Service.Size = new System.Drawing.Size(220, 37);
            this.Service.TabIndex = 4;
            this.Service.Text = "service client";
            this.Service.UseVisualStyleBackColor = true;
            this.Service.Click += new System.EventHandler(this.Service_Click);
            // 
            // Client
            // 
            this.Client.BackgroundImage = global::MiniProjet_ModeDeconnecter.Properties.Resources._0_2b9452_ddb55a89_XXXL;
            this.Client.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client.Location = new System.Drawing.Point(290, 314);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(220, 45);
            this.Client.TabIndex = 7;
            this.Client.Text = "Gestion des clients";
            this.Client.UseVisualStyleBackColor = true;
            this.Client.Click += new System.EventHandler(this.Client_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MiniProjet_ModeDeconnecter.Properties.Resources._4259102566b35a2533a1f6834fefde3b1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.Dessert1);
            this.Controls.Add(this.Commande);
            this.Controls.Add(this.Service);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Interface";
            this.Text = "Interface";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Dessert1;
        private System.Windows.Forms.Button Commande;
        private System.Windows.Forms.Button Service;
        private System.Windows.Forms.Button Client;
    }
}