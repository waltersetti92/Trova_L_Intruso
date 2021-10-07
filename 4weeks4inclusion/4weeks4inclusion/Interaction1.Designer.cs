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
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).BeginInit();
            this.SuspendLayout();
            // 
            // Listen
            // 
            this.Listen.BackColor = System.Drawing.Color.Transparent;
            this.Listen.Font = new System.Drawing.Font("Snap ITC", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listen.ForeColor = System.Drawing.Color.Blue;
            this.Listen.Location = new System.Drawing.Point(3, 627);
            this.Listen.Name = "Listen";
            this.Listen.Size = new System.Drawing.Size(141, 30);
            this.Listen.TabIndex = 4;
            this.Listen.Text = "ANIMALI";
            this.Listen.UseVisualStyleBackColor = false;
            this.Listen.Click += new System.EventHandler(this.Listen_Click);
            // 
            // p3
            // 
            this.p3.Location = new System.Drawing.Point(509, 363);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(167, 117);
            this.p3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p3.TabIndex = 5;
            this.p3.TabStop = false;
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(510, 185);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(166, 117);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p1.TabIndex = 6;
            this.p1.TabStop = false;
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(815, 185);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(170, 117);
            this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p2.TabIndex = 7;
            this.p2.TabStop = false;
            // 
            // p4
            // 
            this.p4.Location = new System.Drawing.Point(819, 363);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(166, 117);
            this.p4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p4.TabIndex = 8;
            this.p4.TabStop = false;
            // 
            // gioca_btn
            // 
            this.gioca_btn.Font = new System.Drawing.Font("Snap ITC", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gioca_btn.ForeColor = System.Drawing.Color.Blue;
            this.gioca_btn.Location = new System.Drawing.Point(171, 627);
            this.gioca_btn.Name = "gioca_btn";
            this.gioca_btn.Size = new System.Drawing.Size(270, 30);
            this.gioca_btn.TabIndex = 9;
            this.gioca_btn.Text = "TROVA L\'INTRUSO";
            this.gioca_btn.UseVisualStyleBackColor = true;
            this.gioca_btn.Visible = false;
            this.gioca_btn.Click += new System.EventHandler(this.gioca_btn_Click);
            // 
            // Interaction1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gioca_btn);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.Listen);
            this.Name = "Interaction1";
            this.Size = new System.Drawing.Size(1101, 774);
            this.Load += new System.EventHandler(this.Interaction1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Listen;
        private System.Windows.Forms.PictureBox p3;
        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox p4;
        private System.Windows.Forms.Button gioca_btn;
    }
}
