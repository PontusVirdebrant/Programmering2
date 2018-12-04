using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinewSwooper
{
    public partial class MineswooperForm : Form
    {
        private Svårighetsgrad svårighetsgrad;
        public MineswooperForm()
        {
            InitializeComponent();
        }

        private enum Svårighetsgrad { Expert, Intermediate, Noob}

        private void StartaSpel(object sender, EventArgs e)
        {
            int x, y, minor;
            switch (this.svårighetsgrad)
            {
                case Svårighetsgrad.Noob:
                    x = y = 9;
                    minor = 10;
                    break;
                case Svårighetsgrad.Intermediate:
                    x = y = 16;
                    minor = 40;
                    break;
                case Svårighetsgrad.Expert:
                    x = 30;
                    y = 16;
                    minor = 99;
                    break;
                default:
                    throw new InvalidOperationException("oimplementerad svårighetsgrad vald");
            }
        }

        private class TileGrid : Panel
        {
            private Size gridSize;
            private int mines;
            private int flags;

            internal void LoadGrid(Size gridSize, int mines)
            {
                this.Controls.Clear();
                this.gridSize = gridSize;
                this.mines = this.flags = mines;
                this.Size = new Size(gridSize.Width * Tile.LENGTH, gridSize.Height * Tile.LENGTH);
                for(int x = 0; x<gridSize.Width; x++)
                {
                    for (int y = 0; y< gridSize.Height; y++)
                    {
                        Tile tile = new Tile();
                    }
                }
            }

            private class Tile : PictureBox
            {
                internal const int LENGTH = 25;

                internal Tile(int x, int y)
                {
                    this.Name = $"Tile_{x}_{y}";
                    this.Location = new Point(x * LENGTH, y * LENGTH);
                }
            }
        }
    }
}
