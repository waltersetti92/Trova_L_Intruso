namespace _4weeks4inclusion
{
    partial class activity1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.p5 = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Button();
            this.lbl_intruso = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_timer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.p5)).BeginInit();
            this.SuspendLayout();
            // 
            // p5
            // 
            this.p5.Location = new System.Drawing.Point(563, 136);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(348, 218);
            this.p5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p5.TabIndex = 0;
            this.p5.TabStop = false;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.Blue;
            this.back.Location = new System.Drawing.Point(58, 555);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(342, 47);
            this.back.TabIndex = 6;
            this.back.Text = "NUOVO GRUPPO";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // lbl_intruso
            // 
            this.lbl_intruso.AutoSize = true;
            this.lbl_intruso.Font = new System.Drawing.Font("Snap ITC", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_intruso.ForeColor = System.Drawing.Color.Blue;
            this.lbl_intruso.Location = new System.Drawing.Point(487, 388);
            this.lbl_intruso.Name = "lbl_intruso";
            this.lbl_intruso.Size = new System.Drawing.Size(498, 51);
            this.lbl_intruso.TabIndex = 7;
            this.lbl_intruso.Text = "E\' LUI L\'INTRUSO?";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Font = new System.Drawing.Font("Snap ITC", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timer.ForeColor = System.Drawing.Color.Green;
            this.lbl_timer.Location = new System.Drawing.Point(437, 555);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(474, 51);
            this.lbl_timer.TabIndex = 8;
            this.lbl_timer.Text = "TEMPO SCADUTO!";
            // 
            // activity1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.lbl_intruso);
            this.Controls.Add(this.back);
            this.Controls.Add(this.p5);
            this.Name = "activity1";
            this.Size = new System.Drawing.Size(1900, 1000);
            this.Load += new System.EventHandler(this.activity1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox p5;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label lbl_intruso;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_timer;
    }
}
