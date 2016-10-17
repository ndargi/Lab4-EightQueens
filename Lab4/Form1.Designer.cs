namespace Lab4
{
    partial class Form1
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
            this.Clear = new System.Windows.Forms.Button();
            this.Hints = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(149, 26);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(98, 38);
            this.Clear.TabIndex = 0;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Hints
            // 
            this.Hints.AutoSize = true;
            this.Hints.Location = new System.Drawing.Point(26, 32);
            this.Hints.Name = "Hints";
            this.Hints.Size = new System.Drawing.Size(93, 29);
            this.Hints.TabIndex = 1;
            this.Hints.Text = "Hints";
            this.Hints.UseVisualStyleBackColor = true;
            this.Hints.CheckedChanged += new System.EventHandler(this.Hints_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.Hints);
            this.Controls.Add(this.Clear);
            this.Name = "Form1";
            this.Text = "Eight Queens -by Nicholas Dargi";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.CheckBox Hints;
    }
}

