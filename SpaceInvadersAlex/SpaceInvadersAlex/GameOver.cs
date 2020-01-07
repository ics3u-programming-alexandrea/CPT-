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
    public partial class frmGameOver : Form
    {
        WMPLib.WindowsMediaPlayer game = new WMPLib.WindowsMediaPlayer();
        public frmGameOver()
        {
            InitializeComponent();
            
        }

        private void FrmGameOver_Load(object sender, EventArgs e)
        {
            game.URL = "GameOver.mp3";
            game.controls.play();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            game.controls.stop();
            new frmBeginning().Show();
        }
    }
}
