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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.archer_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(102, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 25);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(142, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 25);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox3.Location = new System.Drawing.Point(182, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 25);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox4.Location = new System.Drawing.Point(222, 25);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 25);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox5.Location = new System.Drawing.Point(262, 25);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(34, 25);
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox6.Location = new System.Drawing.Point(302, 25);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(34, 25);
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox7.Location = new System.Drawing.Point(342, 25);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(34, 25);
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox8.Location = new System.Drawing.Point(382, 25);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(34, 25);
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Visible = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox9.Location = new System.Drawing.Point(422, 25);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(34, 25);
            this.pictureBox9.TabIndex = 18;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Visible = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox10.Location = new System.Drawing.Point(462, 25);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(34, 25);
            this.pictureBox10.TabIndex = 19;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Visible = false;
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
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonMinion);
            this.Controls.Add(this.buttonArcher);
            this.Controls.Add(this.buttonGiant);
            this.Controls.Add(this.money);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.archer_left);
             this.Margin = new System.Windows.Forms.Padding(4);
            this.DoubleBuffered = true;
            this.Name = "MainGameForm";
            this.Text = "Form1";
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.MainGameForm_ControlAdded);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.archer_left)).EndInit();
             ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Timer timer1;
    }
}

