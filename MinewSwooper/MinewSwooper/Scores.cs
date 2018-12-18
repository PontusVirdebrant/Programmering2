using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MinewSwooper
{
    public partial class Scores : Form
    {
        public Scores()
        {
            InitializeComponent();
        }

        private void Scores_Load(object sender, EventArgs e)
        {
            string Desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Desktop += "//Scorefil";
            BinaryReader scoreReader = new BinaryReader(
            new FileStream(@Desktop, FileMode.OpenOrCreate, FileAccess.Read));
            scoreReader.Read();
        }
    }
}
