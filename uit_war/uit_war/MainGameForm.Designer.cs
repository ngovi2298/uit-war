using System.IO;

namespace uit_war
{
    public partial class MainGameForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGameForm));
            this.archer_left = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            this.money = new System.Windows.Forms.Label();
            this.buttonGiant = new System.Windows.Forms.Button();
            this.buttonArcher = new System.Windows.Forms.Button();
            this.buttonMinion = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.archer_left)).BeginInit();
            this.SuspendLayout();
            // 
            // archer_left
            // 
            this.archer_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.archer_left.Image = ((System.Drawing.Image)(resources.GetObject("archer_left.Image")));
            this.archer_left.Location = new System.Drawing.Point(223, 267);
            this.archer_left.Name = "archer_left";
            this.archer_left.Size = new System.Drawing.Size(51, 50);
            this.archer_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.archer_left.TabIndex = 3;
            this.archer_left.TabStop = false;
            this.archer_left.Click += new System.EventHandler(this.archer_left_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(713, 399);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 4;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Location = new System.Drawing.Point(25, 20);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(38, 13);
            this.money.TabIndex = 6;
            this.money.Text = "money";
            // 
            // buttonGiant
            // 
            this.buttonGiant.BackgroundImage = global::uit_war.Properties.Resources.giant;
            this.buttonGiant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGiant.Location = new System.Drawing.Point(730, 0);
            this.buttonGiant.Name = "buttonGiant";
            this.buttonGiant.Size = new System.Drawing.Size(71, 53);
            this.buttonGiant.TabIndex = 7;
            this.buttonGiant.UseVisualStyleBackColor = true;
            this.buttonGiant.Click += new System.EventHandler(this.button_giant_clicked);
            // 
            // buttonArcher
            // 
            this.buttonArcher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonArcher.BackgroundImage")));
            this.buttonArcher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonArcher.Location = new System.Drawing.Point(659, 0);
            this.buttonArcher.Name = "buttonArcher";
            this.buttonArcher.Size = new System.Drawing.Size(75, 53);
            this.buttonArcher.TabIndex = 8;
            this.buttonArcher.UseVisualStyleBackColor = true;
            this.buttonArcher.Click += new System.EventHandler(this.button_archer_clicked);
            // 
            // buttonMinion
            // 
            this.buttonMinion.BackgroundImage = global::uit_war.Properties.Resources.minion;
            this.buttonMinion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMinion.Location = new System.Drawing.Point(588, 0);
            this.buttonMinion.Name = "buttonMinion";
            this.buttonMinion.Size = new System.Drawing.Size(75, 53);
            this.buttonMinion.TabIndex = 9;
            this.buttonMinion.UseVisualStyleBackColor = true;
            this.buttonMinion.Click += new System.EventHandler(this.button_minion_clicked);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMinion);
            this.Controls.Add(this.buttonArcher);
            this.Controls.Add(this.buttonGiant);
            this.Controls.Add(this.money);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.archer_left);
            this.DoubleBuffered = true;
            this.Name = "MainGameForm";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.archer_left)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.PictureBox archer_left;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label money;
        private System.Windows.Forms.Button buttonGiant;
        private System.Windows.Forms.Button buttonArcher;
        private System.Windows.Forms.Button buttonMinion;
        private System.Windows.Forms.Timer timer1;
    }
}

