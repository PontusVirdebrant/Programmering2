namespace MinewSwooper
{
    partial class Scores
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.ScoreList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ScoreList
            // 
            this.ScoreList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ScoreList.Location = new System.Drawing.Point(12, 12);
            this.ScoreList.Name = "ScoreList";
            this.ScoreList.Size = new System.Drawing.Size(249, 237);
            this.ScoreList.TabIndex = 0;
            this.ScoreList.UseCompatibleStateImageBehavior = false;
            // 
            // Scores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 261);
            this.Controls.Add(this.ScoreList);
            this.Name = "Scores";
            this.Text = "Scores";
            this.Load += new System.EventHandler(this.Scores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ScoreList;
    }
}