namespace MiniProjet_ModeDeconnecter
{
    partial class ListeDessert
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
            this.liste = new System.Windows.Forms.DataGridView();
            this.recherche = new System.Windows.Forms.TextBox();
            this.rechercher1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).BeginInit();
            this.SuspendLayout();
            // 
            // liste
            // 
            this.liste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.liste.BackgroundColor = System.Drawing.Color.LightCoral;
            this.liste.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste.GridColor = System.Drawing.Color.MistyRose;
            this.liste.Location = new System.Drawing.Point(12, 108);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(762, 308);
            this.liste.TabIndex = 1;
            // 
            // recherche
            // 
            this.recherche.Location = new System.Drawing.Point(68, 74);
            this.recherche.Name = "recherche";
            this.recherche.Size = new System.Drawing.Size(139, 20);
            this.recherche.TabIndex = 2;
            // 
            // rechercher1
            // 
            this.rechercher1.BackColor = System.Drawing.Color.MistyRose;
            this.rechercher1.BackgroundImage = global::MiniProjet_ModeDeconnecter.Properties.Resources.icons8_groupe_d_utilisateurs_homme_homme_100;
            this.rechercher1.Image = global::MiniProjet_ModeDeconnecter.Properties.Resources.icons8_conférence_50;
            this.rechercher1.Location = new System.Drawing.Point(240, 71);
            this.rechercher1.Name = "rechercher1";
            this.rechercher1.Size = new System.Drawing.Size(138, 31);
            this.rechercher1.TabIndex = 3;
            this.rechercher1.Text = "recherche";
            this.rechercher1.UseVisualStyleBackColor = false;
            this.rechercher1.Click += new System.EventHandler(this.rechercher1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.BackgroundImage = global::MiniProjet_ModeDeconnecter.Properties.Resources.icons8_groupe_d_utilisateurs_homme_homme_100;
            this.button1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(450, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "remplisser";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListeDessert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MiniProjet_ModeDeconnecter.Properties.Resources._0_2b9460_bede19f1_XXXL1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(910, 614);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rechercher1);
            this.Controls.Add(this.recherche);
            this.Controls.Add(this.liste);
            this.Name = "ListeDessert";
            this.Text = "ListeDessert";
            this.Load += new System.EventHandler(this.ListeDessert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.liste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView liste;
        private System.Windows.Forms.TextBox recherche;
        private System.Windows.Forms.Button rechercher1;
        private System.Windows.Forms.Button button1;
    }
}