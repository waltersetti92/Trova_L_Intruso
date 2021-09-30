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
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
