namespace MinewSwooper
{
    partial class HighScores
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
            this.label1 = new System.Windows.Forms.Label();
            this.HighScoreBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Skriv ditt namn";
            // 
            // HighScoreBox
            // 
            this.HighScoreBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.HighScoreBox.Location = new System.Drawing.Point(41, 57);
            this.HighScoreBox.Name = "HighScoreBox";
            this.HighScoreBox.ShortcutsEnabled = false;
            this.HighScoreBox.Size = new System.Drawing.Size(135, 20);
            this.HighScoreBox.TabIndex = 1;
            this.HighScoreBox.Tag = "SpelarNamn";
            this.HighScoreBox.WordWrap = false;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SubmitButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SubmitButton.Location = new System.Drawing.Point(71, 97);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // HighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 132);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.HighScoreBox);
            this.Controls.Add(this.label1);
            this.Name = "HighScores";
            this.Text = "HighScores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HighScoreBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}