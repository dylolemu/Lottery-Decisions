namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.ticket3 = new System.Windows.Forms.PictureBox();
            this.ticket1 = new System.Windows.Forms.PictureBox();
            this.ticket2 = new System.Windows.Forms.PictureBox();
            this.tv = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.answerBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ticket3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticket1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticket2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a Ticket";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ticket3
            // 
            this.ticket3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ticket3.BackgroundImage")));
            this.ticket3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ticket3.Location = new System.Drawing.Point(143, 234);
            this.ticket3.Name = "ticket3";
            this.ticket3.Size = new System.Drawing.Size(177, 218);
            this.ticket3.TabIndex = 2;
            this.ticket3.TabStop = false;
            this.ticket3.Click += new System.EventHandler(this.pictureBox1_Click);
            this.ticket3.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.ticket3.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // ticket1
            // 
            this.ticket1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ticket1.BackgroundImage")));
            this.ticket1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ticket1.Location = new System.Drawing.Point(61, 12);
            this.ticket1.Name = "ticket1";
            this.ticket1.Size = new System.Drawing.Size(177, 218);
            this.ticket1.TabIndex = 3;
            this.ticket1.TabStop = false;
            this.ticket1.Click += new System.EventHandler(this.v_Click);
            this.ticket1.MouseLeave += new System.EventHandler(this.Ticket1_MouseLeave);
            this.ticket1.MouseHover += new System.EventHandler(this.Ticket1_MouseHover);
            // 
            // ticket2
            // 
            this.ticket2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ticket2.BackgroundImage")));
            this.ticket2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ticket2.Location = new System.Drawing.Point(244, 10);
            this.ticket2.Name = "ticket2";
            this.ticket2.Size = new System.Drawing.Size(177, 218);
            this.ticket2.TabIndex = 5;
            this.ticket2.TabStop = false;
            this.ticket2.Click += new System.EventHandler(this.pictureBox3_Click);
            this.ticket2.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.ticket2.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // tv
            // 
            this.tv.BackColor = System.Drawing.Color.Transparent;
            this.tv.Location = new System.Drawing.Point(441, 312);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(31, 45);
            this.tv.TabIndex = 6;
            this.tv.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 7;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerBox
            // 
            this.answerBox.Location = new System.Drawing.Point(197, 371);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(70, 20);
            this.answerBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 464);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tv);
            this.Controls.Add(this.ticket2);
            this.Controls.Add(this.ticket1);
            this.Controls.Add(this.ticket3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lottery Decision Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.ticket3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticket1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticket2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ticket3;
        private System.Windows.Forms.PictureBox ticket1;
        private System.Windows.Forms.PictureBox ticket2;
        private System.Windows.Forms.PictureBox tv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox answerBox;
    }
}

