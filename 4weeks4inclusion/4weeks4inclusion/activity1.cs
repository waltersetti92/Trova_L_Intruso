using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _4weeks4inclusion
{
    public partial class activity1 : UserControl
    {
        public Main parentForm { get; set; }
        public int timeleft = 20;

        public activity1()
        {
            InitializeComponent();
            lbl_intruso.Visible = false;
            back.Visible = false;
            lbl_timer.Visible = false;
    }
        public void Images_Sounds(string a, string b)
        {
            p5.WaitOnLoad = true;
            p5.ImageLocation = Main.resourcesPath + "\\" + a + ".png";
            p5.Visible = true;
            this.Update();
            parentForm.playbackResourceAudio(b);
            Thread.Sleep(3500);           
        }
        public void setOperationsIcons(int i)
        {

            if (i == 1)
            {
                Images_Sounds("lizard", "lucertola");
            }
            parentForm.playbackResourceAudio("domanda");
            lbl_intruso.Visible = true;
            this.Update();
            Thread.Sleep(2000);
            timer1.Start();

        
        }
        public void setPos(int w, int h)
        {

            int offset = 0;
            Location = new Point(offset, offset);
            Width = w - 1 * offset;
            Height = h - 1 * offset;

        }

        private void activity1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Stop();
        }

        private void back_Click(object sender, EventArgs e)
        {
            parentForm.step++;
            parentForm.playbackResourceAudio("gruppo");
            Thread.Sleep(2000);
            this.Hide();

            parentForm.onStart();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft = timeleft - 1;
            }
            if (timeleft == 0)
            {
                timer1.Stop();
                parentForm.playbackResourceAudio("tempo");
                lbl_timer.Visible = true;
                this.Update();
                Thread.Sleep(4000);
                back.Visible = true;
                this.Update();
 
            }
        }
    }
}
