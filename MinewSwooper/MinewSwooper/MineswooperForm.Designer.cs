namespace MinewSwooper
{
    partial class MineswooperForm
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
            this.startKnapp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.startKnapp)).BeginInit();
            this.SuspendLayout();
            // 
            // startKnapp
            // 
            this.startKnapp.Image = global::MinewSwooper.Properties.Resources.startKnapp;
            this.startKnapp.Location = new System.Drawing.Point(380, 12);
            this.startKnapp.Name = "startKnapp";
            this.startKnapp.Size = new System.Drawing.Size(40, 40);
            this.startKnapp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.startKnapp.TabIndex = 0;
            this.startKnapp.TabStop = false;
            this.startKnapp.Click += new System.EventHandler(this.StartaSpel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startKnapp);
            this.Name = "Form1";
            this.Text = "Mineswooper";
            ((System.ComponentModel.ISupportInitialize)(this.startKnapp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox startKnapp;
    }
}

