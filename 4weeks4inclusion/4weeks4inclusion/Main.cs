using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Threading;

namespace _4weeks4inclusion
{
    public partial class Main : Form
    {
        public static readonly string appPath = Path.GetDirectoryName(Application.ExecutablePath);
        public static readonly string resourcesPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\resources";
        private const string background_image = "galaxy.jpg";
        private UserControl currUC = null;
        public int step;
        public SoundPlayer player = null;
        public Main()
        {
            step = 1;
            InitializeComponent();
            interaction11.parentForm = this;
            activity11.parentForm = this;
            initial1.parentForm = this;
            interaction11.Visible = false;
            initial1.Visible = false;
            activity11.Visible = false;
            home();

        }
        public void activity()
        {
            interaction11.Visible = false;
            activity11.Visible = true;
            activity11.setOperationsIcons(step);
            currUC = activity11;
        }
        public void home()
        {
            if (currUC != null) currUC.Visible = false;
            initial1.Show();
            currUC = initial1;
            initial1.suono_iniziale();
        }
        public void onStart()
        {
            initial1.Visible = false;
            interaction11.Visible = true;
            currUC = interaction11;
           
        }
        private void Main_Load(object sender, EventArgs e)
        {
            Size size = this.Size;
            interaction11.setPos(size.Width, size.Height);
            activity11.setPos(size.Width, size.Height);
            initial1.setPos(size.Width, size.Height);
            interaction11.setPos(size.Width, size.Height);
            activity11.setPos(size.Width, size.Height);
        }
        public void playbackResourceAudio(string audioname)
        {

            string s = resourcesPath + "\\" + audioname + ".wav";
            player = new SoundPlayer(s);
            player.Play();
        }

        private void initial2_Load(object sender, EventArgs e)
        {

        }
    }
}
