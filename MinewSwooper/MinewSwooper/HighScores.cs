using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinewSwooper;

namespace MinewSwooper
{
    public partial class HighScores : Form
    {
        

        public string ScoreNamn
        {
            get { return HighScoreBox.Text; }
            set { HighScoreBox.Text = value; }
        }

        public HighScores()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string Desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Desktop += "//Scorefil";
            BinaryWriter scoreSaver = new BinaryWriter(
            new FileStream(@Desktop, FileMode.OpenOrCreate, FileAccess.ReadWrite));
            scoreSaver.Write(ScoreNamn);
            scoreSaver.Close();
        }
    }
}
