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
            this.tileGrid = new MinewSwooper.MineswooperForm.TileGrid();
            this.startKnapp = new System.Windows.Forms.PictureBox();
            this.flaggRäknare = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip_Game = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Game_New = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip_Game_Beginner = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Game_Intermediate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Game_Expert = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.highscoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip_Game_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.TidLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.startKnapp)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileGrid
            // 
            this.tileGrid.Location = new System.Drawing.Point(12, 58);
            this.tileGrid.Name = "tileGrid";
            this.tileGrid.Size = new System.Drawing.Size(760, 491);
            this.tileGrid.TabIndex = 0;
            // 
            // startKnapp
            // 
            this.startKnapp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startKnapp.Image = global::MinewSwooper.Properties.Resources.startKnapp;
            this.startKnapp.Location = new System.Drawing.Point(370, 12);
            this.startKnapp.Name = "startKnapp";
            this.startKnapp.Size = new System.Drawing.Size(40, 40);
            this.startKnapp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.startKnapp.TabIndex = 0;
            this.startKnapp.TabStop = false;
            this.startKnapp.Click += new System.EventHandler(this.StartaSpel);
            // 
            // flaggRäknare
            // 
            this.flaggRäknare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flaggRäknare.AutoSize = true;
            this.flaggRäknare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flaggRäknare.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flaggRäknare.Location = new System.Drawing.Point(721, 12);
            this.flaggRäknare.Name = "flaggRäknare";
            this.flaggRäknare.Size = new System.Drawing.Size(2, 33);
            this.flaggRäknare.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_Game});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip_Game
            // 
            this.menuStrip_Game.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_Game_New,
            this.toolStripSeparator1,
            this.menuStrip_Game_Beginner,
            this.menuStrip_Game_Intermediate,
            this.menuStrip_Game_Expert,
            this.toolStripSeparator2,
            this.highscoresToolStripMenuItem,
            this.toolStripSeparator3,
            this.menuStrip_Game_Exit});
            this.menuStrip_Game.Name = "menuStrip_Game";
            this.menuStrip_Game.Size = new System.Drawing.Size(50, 20);
            this.menuStrip_Game.Text = "Game";
            // 
            // menuStrip_Game_New
            // 
            this.menuStrip_Game_New.Name = "menuStrip_Game_New";
            this.menuStrip_Game_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuStrip_Game_New.Size = new System.Drawing.Size(141, 22);
            this.menuStrip_Game_New.Text = "New";
            this.menuStrip_Game_New.Click += new System.EventHandler(this.MenuStrip_Game_New_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // menuStrip_Game_Beginner
            // 
            this.menuStrip_Game_Beginner.Name = "menuStrip_Game_Beginner";
            this.menuStrip_Game_Beginner.Size = new System.Drawing.Size(141, 22);
            this.menuStrip_Game_Beginner.Tag = "Noob";
            this.menuStrip_Game_Beginner.Text = "Beginner";
            this.menuStrip_Game_Beginner.Click += new System.EventHandler(this.MenuStrip_Game_DifficultyChanged);
            // 
            // menuStrip_Game_Intermediate
            // 
            this.menuStrip_Game_Intermediate.Name = "menuStrip_Game_Intermediate";
            this.menuStrip_Game_Intermediate.Size = new System.Drawing.Size(141, 22);
            this.menuStrip_Game_Intermediate.Tag = "Intermediate";
            this.menuStrip_Game_Intermediate.Text = "Intermediate";
            this.menuStrip_Game_Intermediate.Click += new System.EventHandler(this.MenuStrip_Game_DifficultyChanged);
            // 
            // menuStrip_Game_Expert
            // 
            this.menuStrip_Game_Expert.Name = "menuStrip_Game_Expert";
            this.menuStrip_Game_Expert.Size = new System.Drawing.Size(141, 22);
            this.menuStrip_Game_Expert.Tag = "Expert";
            this.menuStrip_Game_Expert.Text = "Expert";
            this.menuStrip_Game_Expert.Click += new System.EventHandler(this.MenuStrip_Game_DifficultyChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(138, 6);
            // 
            // highscoresToolStripMenuItem
            // 
            this.highscoresToolStripMenuItem.Name = "highscoresToolStripMenuItem";
            this.highscoresToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.highscoresToolStripMenuItem.Text = "Highscores";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(138, 6);
            // 
            // menuStrip_Game_Exit
            // 
            this.menuStrip_Game_Exit.Name = "menuStrip_Game_Exit";
            this.menuStrip_Game_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuStrip_Game_Exit.Size = new System.Drawing.Size(141, 22);
            this.menuStrip_Game_Exit.Tag = "Exit";
            this.menuStrip_Game_Exit.Text = "Exit";
            this.menuStrip_Game_Exit.Click += new System.EventHandler(this.MenuStrip_Game_Exit_Click);
            // 
            // TidLabel
            // 
            this.TidLabel.AutoSize = true;
            this.TidLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TidLabel.Location = new System.Drawing.Point(56, 12);
            this.TidLabel.Name = "TidLabel";
            this.TidLabel.Size = new System.Drawing.Size(2, 33);
            this.TidLabel.TabIndex = 3;
            // 
            // MineswooperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.TidLabel);
            this.Controls.Add(this.flaggRäknare);
            this.Controls.Add(this.tileGrid);
            this.Controls.Add(this.startKnapp);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MineswooperForm";
            this.Text = "Mineswooper";
            this.Load += new System.EventHandler(this.MineswooperForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.startKnapp)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TileGrid tileGrid;

        private System.Windows.Forms.PictureBox startKnapp;
        private System.Windows.Forms.Label flaggRäknare;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Game;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Game_New;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Game_Beginner;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Game_Intermediate;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Game_Expert;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem highscoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Game_Exit;
        private System.Windows.Forms.Label TidLabel;
    }
}

