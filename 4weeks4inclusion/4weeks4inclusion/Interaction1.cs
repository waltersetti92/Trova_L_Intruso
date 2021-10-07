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
    public partial class Interaction1 : UserControl
    {
        public Main parentForm { get; set; }
        public Interaction1()
        {
            InitializeComponent();
        }
        private void resetOperations()
        {

            gioca_btn.Visible = false;
            p1.Visible = false;
            p2.Visible = false;
            p3.Visible = false;
            p4.Visible = false;
            Listen.Enabled = true;
        }
        public void Images_Sounds(string a, string b, string c, string d,string e, string f, string g, string h)
        {
            p1.WaitOnLoad = true;
            p1.ImageLocation = Main.resourcesPath + "\\" + a + ".png";
            p1.Visible = true;
            this.Update();
            parentForm.playbackResourceAudio(e);
            Thread.Sleep(4000);
            p2.WaitOnLoad = true;
            p2.ImageLocation = Main.resourcesPath + "\\" + b + ".png";
            p2.Visible = true;
            this.Update();
            parentForm.playbackResourceAudio(f);
            Thread.Sleep(2000);
            p3.WaitOnLoad = true;
            p3.ImageLocation = Main.resourcesPath + "\\" + c + ".png";
            p3.Visible = true;
            this.Update();
            parentForm.playbackResourceAudio(g);
            Thread.Sleep(2000);
            p4.WaitOnLoad = true;
            p4.ImageLocation = Main.resourcesPath + "\\" + d + ".png";
            p4.Visible = true;
            this.Update();
            parentForm.playbackResourceAudio(h);
            Thread.Sleep(2000);

        }
        public void setPos(int w, int h)
        {

            int offset = 0;
            Location = new Point(offset, offset);
            Width = w - 1 * offset;
            Height = h - 1 * offset;

        }
        public void setOperationsIcons(int i)
        {
            resetOperations();

            if (i == 1)
            {
                Images_Sounds("Bicycle", "cat", "dog", "hamster", "bicicletta", "gatto", "cane", "criceto");
            }
        }
        private void Interaction1_Load(object sender, EventArgs e)
        {
            resetOperations();
        }

        private void Listen_Click(object sender, EventArgs e)
        {
            resetOperations();
            this.Update();
            Listen.Enabled = false;

                setOperationsIcons(parentForm.step);
            if (parentForm.step < 6)
            {
                this.Update();
                gioca_btn.Visible = true;
            }

        }
    }
}
