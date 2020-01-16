namespace RapMot
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
            this.LblWords = new System.Windows.Forms.Label();
            this.LblSeconds = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblWords
            // 
            this.LblWords.Font = new System.Drawing.Font("MS Reference Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
            this.LblWords.Location = new System.Drawing.Point(128, 164);
            this.LblWords.Name = "LblWords";
            this.LblWords.Size = new System.Drawing.Size(558, 118);
            this.LblWords.TabIndex = 0;
            this.LblWords.Text = "PALABRAS";
            this.LblWords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblWords.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblSeconds
            // 
            this.LblSeconds.AutoSize = true;
            this.LblSeconds.Font = new System.Drawing.Font("MS Reference Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSeconds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.LblSeconds.Location = new System.Drawing.Point(345, 66);
            this.LblSeconds.Name = "LblSeconds";
            this.LblSeconds.Size = new System.Drawing.Size(100, 46);
            this.LblSeconds.TabIndex = 1;
            this.LblSeconds.Text = "15 s";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblSeconds);
            this.Controls.Add(this.LblWords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblWords;
        private System.Windows.Forms.Label LblSeconds;
    }
}

