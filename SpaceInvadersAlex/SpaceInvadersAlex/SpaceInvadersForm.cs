using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvadersAlex
{
    public partial class frmSpaceInvaders : Form
    {
        WMPLib.WindowsMediaPlayer sound = new WMPLib.WindowsMediaPlayer();
        bool goleft = false;
        bool goright = false;
        int speed = 15;
        int score = 0;
        bool isPressed = false;
        int totalEnemies = 12;
        int playerSpeed = 20;

        public frmSpaceInvaders()
        {
            InitializeComponent();
            sound.URL = "sound.mp3";
            sound.controls.play();

            tmrTime.Start();
            time = 40;
            lblTimer.Text = "Time left : " + time;
        }

        public int time { get; set; }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Space && !isPressed)
            {
                isPressed = true;
                createBullet();
                //do work
            }


        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (isPressed == true)
            {
                isPressed = false;
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time - 1;
            lblTimer.Text = "Time left : " + time;

            //player moving left and right
            if (goleft)
            {
                player.Left -= playerSpeed;
            }
            else if (goright)
            {
                player.Left += playerSpeed;
            }
            //end of player moving left and right


            //invaders moving on the form
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "invader")
                {

                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        gameOver();
                    }

                   ((PictureBox)x).Left += speed;


                    if (((PictureBox)x).Left > 720)
                    {
                        ((PictureBox)x).Top += ((PictureBox)x).Height + 10;
                        ((PictureBox)x).Left = -50;

                    }
                }
            }
            //end of enemies moving on the form
        
            //animating the bullets and removing them when they have left the scene
            foreach (Control y in this.Controls)
            {
                if (y is PictureBox && y.Tag == "bullet")
                {
                    y.Top -= 20;
                    if (((PictureBox)y).Top < this.Height - 490)
                    {
                        this.Controls.Remove(y);
                    }
                }
            }
            //bullet and enemy collision start
            foreach (Control i in this.Controls)
            {
                foreach (Control j in this.Controls)
                {
                    if (i is PictureBox && i.Tag == "invader")
                    {
                        if (j is PictureBox && j.Tag == "bullet")
                        {
                            if (i.Bounds.IntersectsWith(j.Bounds))
                            {
                                score++;
                                this.Controls.Remove(i);
                                this.Controls.Remove(j);
                            }
                        }
                    }
                }
            }
            //keeping and showing score
            
            if (score > totalEnemies - 1)
            {
                gameOver();
               
            }
            if (time == 0)
            {
                if (score < 12)
                {
                    gameOver();
                }
            }

        }
        
        //Procedure: createBullet
        //input: void
        //output: void
        //Description: This procedure produces the bullets that comes out of the cannon
        private void createBullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.Image = Properties.Resources.bullet;
            bullet.Size = new Size(5, 20);
            bullet.Tag = "bullet";
            bullet.Left = player.Left + player.Width / 2;
            bullet.Top = player.Top - 20;
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }
        //Procedure: gameOver
        //input: void
        //output: void
        //Description:this procedure produces the end of the game
        private void gameOver()
        {
            tmrTime.Stop();
            sound.controls.stop();
            this.Close();
            new frmGameOver().Show();

            
            
        }

        private void SpaceInvadersForm_Load(object sender, EventArgs e)
        {

        }
    }


}
