namespace _4weeks4inclusion
{
    partial class Interaction1
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
            this.Listen = new System.Windows.Forms.Button();
            this.p3 = new System.Windows.Forms.PictureBox();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.p4 = new System.Windows.Forms.PictureBox();
            this.gioca_btn = new System.Windows.Forms.Button();
            this.LBL_GC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).BeginInit();
            this.SuspendLayout();
            // 
            // Listen
            // 
            this.Listen.BackColor = System.Drawing.Color.Transparent;
            this.Listen.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listen.ForeColor = System.Drawing.Color.Blue;
            this.Listen.Location = new System.Drawing.Point(28, 581);
            this.Listen.Name = "Listen";
            this.Listen.Size = new System.Drawing.Size(302, 41);
            this.Listen.TabIndex = 4;
            this.Listen.Text = "NUOVO GRUPPO";
            this.Listen.UseVisualStyleBackColor = false;
            this.Listen.Click += new System.EventHandler(this.Listen_Click);
            // 
            // p3
            // 
            this.p3.Location = new System.Drawing.Point(732, 328);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(293, 175);
            this.p3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p3.TabIndex = 5;
            this.p3.TabStop = false;
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(395, 101);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(293, 175);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p1.TabIndex = 6;
            this.p1.TabStop = false;
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(732, 101);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(293, 175);
            this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p2.TabIndex = 7;
            this.p2.TabStop = false;
            // 
            // p4
            // 
            this.p4.Location = new System.Drawing.Point(395, 328);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(293, 175);
            this.p4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p4.TabIndex = 8;
            this.p4.TabStop = false;
            // 
            // gioca_btn
            // 
            this.gioca_btn.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gioca_btn.ForeColor = System.Drawing.Color.Blue;
            this.gioca_btn.Location = new System.Drawing.Point(336, 581);
            this.gioca_btn.Name = "gioca_btn";
            this.gioca_btn.Size = new System.Drawing.Size(380, 41);
            this.gioca_btn.TabIndex = 9;
            this.gioca_btn.Text = "TROVA L\'INTRUSO";
            this.gioca_btn.UseVisualStyleBackColor = true;
            this.gioca_btn.Visible = false;
            this.gioca_btn.Click += new System.EventHandler(this.gioca_btn_Click);
            // 
            // LBL_GC
            // 
            this.LBL_GC.AutoSize = true;
            this.LBL_GC.Font = new System.Drawing.Font("Snap ITC", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_GC.ForeColor = System.Drawing.Color.Blue;
            this.LBL_GC.Location = new System.Drawing.Point(149, 279);
            this.LBL_GC.Name = "LBL_GC";
            this.LBL_GC.Size = new System.Drawing.Size(1097, 103);
            this.LBL_GC.TabIndex = 10;
            this.LBL_GC.Text = "GIOCO COMPLETATO!";
            // 
            // Interaction1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.Controls.Add(this.LBL_GC);
            this.Controls.Add(this.gioca_btn);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.Listen);
            this.Name = "Interaction1";
            this.Size = new System.Drawing.Size(1271, 713);
            this.Load += new System.EventHandler(this.Interaction1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Listen;
        private System.Windows.Forms.PictureBox p3;
        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox p4;
        private System.Windows.Forms.Button gioca_btn;
        private System.Windows.Forms.Label LBL_GC;
    }
}
