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
            Thread.Sleep(3500);
            p2.WaitOnLoad = true;
            p2.ImageLocation = Main.resourcesPath + "\\" + b + ".png";
            p2.Visible = true;
            this.Update();
            parentForm.playbackResourceAudio(f);
            Thread.Sleep(3500);
            p3.WaitOnLoad = true;
            p3.ImageLocation = Main.resourcesPath + "\\" + c + ".png";
            p3.Visible = true;
            this.Update();
            parentForm.playbackResourceAudio(g);
            Thread.Sleep(3500);
            p4.WaitOnLoad = true;
            p4.ImageLocation = Main.resourcesPath + "\\" + d + ".png";
            p4.Visible = true;
            this.Update();
            parentForm.playbackResourceAudio(h);
            Thread.Sleep(3500);

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
                Images_Sounds("snake", "cow", "lizard", "crocodile", "serpente", "mucca", "lucertola", "coccodrillo");
            }
            if (i == 2)
            {
                Images_Sounds("kite", "pear", "orsacchiotto", "ball", "aquilone", "pera", "orsacchiotto", "palla");
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
            parentForm.playbackResourceAudio("gruppo_primo");
            Thread.Sleep(3000);
            Listen.Enabled = false;
           setOperationsIcons(parentForm.step);
            if (parentForm.step < 6)
            {
                this.Update();
                gioca_btn.Visible = true;
            }

        }

        private void gioca_btn_Click(object sender, EventArgs e)
        {
            //parentForm.playbackResourceAudio("intruso");
            //Thread.Sleep(3000);
            parentForm.activity();
            resetOperations();
        }
    }
}
