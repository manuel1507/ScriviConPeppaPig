namespace HangmanGame
{
    partial class frm_Accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Accueil));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMots = new System.Windows.Forms.PictureBox();
            this.btnJouer = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrésente = new System.Windows.Forms.Label();
            this.panelBienvenue = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnJouer)).BeginInit();
            this.panelBienvenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(320, 532);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 83);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnMots
            // 
            this.btnMots.BackColor = System.Drawing.Color.Transparent;
            this.btnMots.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMots.BackgroundImage")));
            this.btnMots.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMots.Location = new System.Drawing.Point(12, 532);
            this.btnMots.Name = "btnMots";
            this.btnMots.Size = new System.Drawing.Size(137, 83);
            this.btnMots.TabIndex = 6;
            this.btnMots.TabStop = false;
            this.btnMots.Click += new System.EventHandler(this.buttonClick);
            // 
            // btnJouer
            // 
            this.btnJouer.BackColor = System.Drawing.Color.Transparent;
            this.btnJouer.BackgroundImage = global::HangmanGame.Properties.Resources.jouer;
            this.btnJouer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJouer.Location = new System.Drawing.Point(134, 272);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.Size = new System.Drawing.Size(187, 179);
            this.btnJouer.TabIndex = 4;
            this.btnJouer.TabStop = false;
            this.btnJouer.Click += new System.EventHandler(this.buttonClick);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(469, 119);
            this.label3.TabIndex = 0;
            this.label3.Text = "PEPPA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPrésente
            // 
            this.lblPrésente.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrésente.ForeColor = System.Drawing.Color.White;
            this.lblPrésente.Location = new System.Drawing.Point(12, 79);
            this.lblPrésente.Name = "lblPrésente";
            this.lblPrésente.Size = new System.Drawing.Size(469, 168);
            this.lblPrésente.TabIndex = 1;
            this.lblPrésente.Text = "SCRIVERE CON";
            this.lblPrésente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelBienvenue
            // 
            this.panelBienvenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(24)))), ((int)(((byte)(21)))));
            this.panelBienvenue.Controls.Add(this.lblPrésente);
            this.panelBienvenue.Controls.Add(this.label3);
            this.panelBienvenue.Location = new System.Drawing.Point(1, 1);
            this.panelBienvenue.Name = "panelBienvenue";
            this.panelBienvenue.Size = new System.Drawing.Size(476, 635);
            this.panelBienvenue.TabIndex = 12;
            // 
            // frm_Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = global::HangmanGame.Properties.Resources.peppa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(469, 626);
            this.Controls.Add(this.panelBienvenue);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnMots);
            this.Controls.Add(this.btnJouer);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnJouer)).EndInit();
            this.panelBienvenue.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnJouer;
        private System.Windows.Forms.PictureBox btnMots;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrésente;
        private System.Windows.Forms.Panel panelBienvenue;
    }
}

