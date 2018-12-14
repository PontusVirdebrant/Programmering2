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
        bool Vinst = false;
        private Svårighetsgrad svårighetsgrad;
        public Timer timer = new Timer();
        public MineswooperForm()
        {
            InitializeComponent();
            this.StartaSpel(null, null);
            this.tileGrid.TileFlagStatusChange += this.TileFlagStatusChanged;
        }

        private enum Svårighetsgrad { Expert, Intermediate, Noob}

        private int Tid { get; set; }

        private void StartaSpel(object sender, EventArgs e)
        {
            timer.Tick -= new EventHandler(ScoreTimerTick);
            Tid = 0;
            Vinst = false;
            Initialize_Timer();
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
            this.flaggRäknare.Text = minor.ToString();
            this.flaggRäknare.ForeColor = Color.Black;
        }

        private void MenuStrip_Game_New_Click(object sender, EventArgs e)
        {
            this.StartaSpel(null, null);
        }

        private void MenuStrip_Game_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuStrip_Game_DifficultyChanged(object sender, EventArgs e)
        {
            this.svårighetsgrad = (Svårighetsgrad)Enum.Parse(typeof(Svårighetsgrad), (string)((ToolStripMenuItem)sender).Tag);
            this.StartaSpel(null, null);
            //Ändrar svårighetsgraden när den väljs i menyn.
        }

        private void TileFlagStatusChanged(object sender, TileGrid.TileFlagStatusChangedEventArgs e)
        {
            this.flaggRäknare.Text = e.Flaggor.ToString();
            this.flaggRäknare.ForeColor = e.LabelColor;
        }

        private void Initialize_Timer()
        {
           timer.Interval = 1000;

           timer.Tick += new EventHandler(ScoreTimerTick);

           timer.Start();
        }

        private void ScoreTimerTick(object sender, EventArgs e)
        {
            this.TidLabel.Text = Tid.ToString();
            
            if(!Vinst)
            {
                Tid++;
            }
        }


        public class TileGrid : Panel
        {
            private static readonly Random random = new Random();
            private static readonly HashSet<Tile> gridSearchBlacklist = new HashSet<Tile>();

            private Size gridSize;
            private int mines;
            private int flags;
            private bool minorGenererade;

            internal event EventHandler<TileFlagStatusChangedEventArgs> TileFlagStatusChange = delegate { };

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
                                this.GenerateMines(tile);
                            }
                            if (tile.Mined)
                            {
                                this.DisableTiles(true);
                            }
                            else
                            {
                                tile.TestAdjacentTiles();
                                gridSearchBlacklist.Clear(); 
                            }
                            break;
                        case MouseButtons.Right when this.flags > 0:
                            if (tile.Flagged)
                            {
                                tile.Flagged = false;
                                this.flags++;
                            }
                            else
                            {
                                tile.Flagged = true;
                                this.flags--;
                            }
                            TileFlagStatusChange(this, new TileFlagStatusChangedEventArgs(this.flags, this.flags < this.mines * 0.25 ? Color.Red : Color.Black));
                            // texten som visar antalet flaggor kvar blir röd när mindre än 25% är kvar 
                            break;
                    }
                }
                this.CheckForWin();
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
                    Point point = new Point(random.Next(this.gridSize.Width), random.Next(this.gridSize.Height));
                    if (!usedPositions.Contains(point))
                    {
                        this[point].Mina();
                        usedPositions[i] = point;
                    }
                    else
                    {
                        i--;
                    }
                }
                this.minorGenererade = true;
            }

            private void DisableTiles(bool gameLost)
            {
                foreach (Tile tile in this.Controls)
                {
                    tile.MouseDown -= this.Tile_MouseDown;
                    if (gameLost)
                    {
                        tile.Image = !tile.Opened && tile.Mined && !tile.Flagged ? Resources.Mina : tile.Flagged && !tile.Mined ? Resources.False_Flag : tile.Image;
                    }
                }
            }

            private void CheckForWin()
            {
                if (this.flags != 0 || this.Controls.OfType<Tile>().Count(tile => tile.Opened || tile.Flagged) != this.gridSize.Width * this.gridSize.Height)
                {
                    return;
                }
                MessageBox.Show("Grattis, du klarade spelet!", "Spel klarat", MessageBoxButtons.OK);
                // Vinst = true;
                
                this.DisableTiles(false);
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
                private int AdjacentMines => this.AdjacentTiles.Count(tile => tile.Mined);

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

                internal void TestAdjacentTiles()
                {
                    if (this.flagged || gridSearchBlacklist.Contains(this))
                    {
                        return;
                    }
                    gridSearchBlacklist.Add(this);
                    if (this.AdjacentMines == 0)
                    {
                        foreach (Tile tile in this.AdjacentTiles)
                        {
                            tile.TestAdjacentTiles();
                        }
                    }
                    this.Open();
                }

                internal void Mina()
                {
                    this.Mined = true;
                }

                private void Open()
                {
                    this.Opened = true;
                    this.Image = (Image)Resources.ResourceManager.GetObject($"EmptyTile_{this.AdjacentMines}");
                }
            }

            internal class TileFlagStatusChangedEventArgs : EventArgs
            {
                internal int Flaggor { get; }
                internal Color LabelColor { get; }

                internal TileFlagStatusChangedEventArgs(int flaggor, Color labelColor)
                {
                    this.Flaggor = flaggor;
                    this.LabelColor = labelColor;
                }
            }
        }

        private void MineswooperForm_Load(object sender, EventArgs e)
        {

        }
    }
}