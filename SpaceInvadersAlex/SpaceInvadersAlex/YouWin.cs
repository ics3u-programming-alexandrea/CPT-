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
    public partial class frmYouWin: Form
    {
        public frmYouWin()
        {
            InitializeComponent();
            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
            player.URL = "sound.mp3";
            player.controls.play();
        }
    }
}
