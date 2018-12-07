using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinewSwooper.Properties;

namespace MinewSwooper
{
    public partial class MineswooperForm : Form
    {
        private Svårighetsgrad svårighetsgrad;

        public MineswooperForm()
        {
            InitializeComponent();
            this.StartaSpel(null, null);
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
            this.tileGrid.LoadGrid(new Size(x, y), minor);
            this.MaximumSize = this.MinimumSize = new Size(this.tileGrid.Width + 36, this.tileGrid.Height + 98);
        }

        private class TileGrid : Panel
        {
            private static readonly Random random = new Random();

            private Size gridSize;
            private int mines;
            private int flags;
            private bool minorGenererade;

            private Tile this[Point point] => (Tile)this.Controls[$"Tile_{point.X}_{point.Y}"];

            private void Tile_MouseDown(object sender, MouseEventArgs e)
            {
                Tile tile = (Tile)sender;
                if (!tile.Opened)
                {
                    switch (e.Button)
                    {
                        case MouseButtons.Left when !tile.Flagged:
                            if (!this.minorGenererade)
                            {

                            }
                            break;
                        case MouseButtons.Right when this.flags > 0:
                            break;
                    }
                }
            }

            internal void LoadGrid(Size gridSize, int mines)
            {
                this.minorGenererade = false;
                this.Controls.Clear();
                this.gridSize = gridSize;
                this.mines = this.flags = mines;
                this.Size = new Size(gridSize.Width * Tile.LENGTH, gridSize.Height * Tile.LENGTH);
                for(int x = 0; x<gridSize.Width; x++)
                {
                    for (int y = 0; y< gridSize.Height; y++)
                    {
                        Tile tile = new Tile(x, y);
                        tile.MouseDown += Tile_MouseDown;
                        this.Controls.Add(tile);
                    }
                }

                foreach (Tile tile in this.Controls)
                {
                    tile.SetAdjacentTiles();
                }
            }
            private void GenerateMines(Tile safeTile)
            {
                int safeTilesCount = safeTile.AdjacentTiles.Length + 1;
                Point[] usedPositions = new Point[this.mines + safeTilesCount];
                usedPositions[0] = safeTile.GridPosition;
                for (int i  = 1; i < safeTilesCount; i++)
                {
                    usedPositions[i] = safeTile.AdjacentTiles[i - 1].GridPosition;
                }
                for (int i = safeTilesCount; i < usedPositions.Length; i++)
                {
                    Point point = new Point[i]
                }
            }

            private class Tile : PictureBox
            {
                internal const int LENGTH = 25;
                private static readonly int[][] adjacentCoords =
                {
                    new[] {-1,-1}, new[]{0,-1}, new[]{1,-1}, new[] {1,0}, new[]{1,1}, new[]{0,1}, new []{-1,1}, new[]{-1,0}
                };

                private bool flagged; 

                internal Tile(int x, int y)
                {
                    this.Name = $"Tile_{x}_{y}";
                    this.Location = new Point(x * LENGTH, y * LENGTH);
                    this.GridPosition = new Point(x, y);
                    this.Size = new Size(LENGTH, LENGTH);
                    this.Image = Resources.Tile;
                    this.SizeMode = PictureBoxSizeMode.Zoom;
                }

                internal Tile[] AdjacentTiles { get; private set; }
                internal Point GridPosition { get; }
                internal bool Opened { get; private set; }
                internal bool Mined { get; private set; }
                internal bool Flagged
                {
                    get => this.flagged;
                    set
                    {
                        this.flagged = value;
                        this.Image = value ? Resources.Flag : Resources.Tile;
                    }
                }
                internal void SetAdjacentTiles()
                {
                    TileGrid tileGrid = (TileGrid)this.Parent;
                    List<Tile> adjacentTiles = new List<Tile>(8);
                    foreach (int[] adjacentCoord in adjacentCoords)
                    {
                        Tile tile = tileGrid[new Point(this.GridPosition.X + adjacentCoord[0], this.GridPosition.Y + adjacentCoord[1])];
                        if (tile != null)
                        {
                            adjacentTiles.Add(tile);
                        }
                    }
                    this.AdjacentTiles = adjacentTiles.ToArray();
                }
            }
        }

        private void tileGrid_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
