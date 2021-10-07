namespace _4weeks4inclusion
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.initial1 = new _4weeks4inclusion.Initial();
            this.interaction11 = new _4weeks4inclusion.Interaction1();
            this.SuspendLayout();
            // 
            // initial1
            // 
            this.initial1.BackColor = System.Drawing.Color.Transparent;
            this.initial1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.initial1.Location = new System.Drawing.Point(305, 29);
            this.initial1.Name = "initial1";
            this.initial1.parentForm = null;
            this.initial1.Size = new System.Drawing.Size(387, 340);
            this.initial1.TabIndex = 0;
            // 
            // interaction11
            // 
            this.interaction11.Location = new System.Drawing.Point(30, 12);
            this.interaction11.Name = "interaction11";
            this.interaction11.Size = new System.Drawing.Size(725, 300);
            this.interaction11.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.interaction11);
            this.Controls.Add(this.initial1);
            this.Name = "Main";
            this.Text = "Trova l\'intruso";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Initial initial1;
        private Interaction1 interaction11;
    }
}

