namespace git_rekt_m8
{
    partial class SecondForm
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
            this.trollLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // trollLabel
            // 
            this.trollLabel.AutoSize = true;
            this.trollLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trollLabel.Location = new System.Drawing.Point(312, 294);
            this.trollLabel.Name = "trollLabel";
            this.trollLabel.Size = new System.Drawing.Size(615, 135);
            this.trollLabel.TabIndex = 0;
            this.trollLabel.Text = "git rekt m8";
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 739);
            this.Controls.Add(this.trollLabel);
            this.Name = "SecondForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "git rekt m8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label trollLabel;
    }
}