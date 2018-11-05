using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uit_war
{
    public abstract class Trop
    {
        protected int speed;
        protected int damage;
        protected int HP;
        private PictureBox picture;

        public PictureBox Picture { get => picture; set => picture = value; }

        public abstract void Move();
    }
    public class Archer:Trop
    {
        public Archer()
        {
            speed = 3;
            damage = 20;
            HP = 100;
            Picture = new PictureBox();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGameForm));
            Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Picture.Image = ((System.Drawing.Image)(resources.GetObject("archer_left.Image")));
            Picture.Name = "picture";
            Picture.Size = new System.Drawing.Size(51, 50);
            Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }
        public override void Move()
        {
            this.Picture.Location= new Point(this.Picture.Location.X + speed, this.Picture.Location.Y);
        }
    }
    public class Tank:Trop
    {
        public Tank()
        {
            speed = 2;
            damage = 10;
            HP = 300;
            Picture = new PictureBox();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGameForm));
            Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Picture.Image = Image.FromFile(Application.StartupPath + "\\Resources\\giant.jpg");
            Picture.Name = "picture";
            Picture.Size = new System.Drawing.Size(51, 50);
            Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }
        public override void Move()
        {
            this.Picture.Location = new Point(this.Picture.Location.X + speed, this.Picture.Location.Y);
        }
    }
    public class Minion:Trop
    {
        public Minion()
        {
            speed = 10;
            damage = 10;
            HP = 80;
            Picture = new PictureBox();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGameForm));
            Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Picture.Image = Image.FromFile(Application.StartupPath + "\\Resources\\minion.png");
            Picture.Name = "picture";
            Picture.Size = new System.Drawing.Size(51, 50);
            Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }
        public override void Move()
        {
            this.Picture.Location = new Point(this.Picture.Location.X + speed, this.Picture.Location.Y);
        }
    }
    public enum CurrentTrop
    {
        Archer,
        Tank,
        Minion
    }
}
