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
            this.Listen.Text = "TRIAL";
            this.Listen.UseVisualStyleBackColor = false;
            // 
            // Interaction1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Listen);
            this.Name = "Interaction1";
            this.Size = new System.Drawing.Size(1101, 774);
            this.Load += new System.EventHandler(this.Interaction1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Listen;
    }
}
