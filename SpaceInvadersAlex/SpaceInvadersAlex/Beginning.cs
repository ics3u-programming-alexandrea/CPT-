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
    public partial class frmBeginning : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        public frmBeginning()
        {
            InitializeComponent();

            player.URL = "sound.mp3";
            player.controls.play();

        }

        private void frmBeginning_Load(object sender, EventArgs e)
        {
         
        }

        private void Btnbegin_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            this.Hide();
            new frmSpaceInvaders().Show();


        }
        
    }
}
