using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        private int UserChoice;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = RockPaperScissors.Properties.Resources.Rock; // Sets the image in pictureBox1 to "Paper"
            button4.Enabled = true;
            UserChoice = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = RockPaperScissors.Properties.Resources.Scissors; // Sets the image in pictureBox1 to "Paper"
            button4.Enabled = true;
            UserChoice = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = RockPaperScissors.Properties.Resources.Paper; // Sets the image in pictureBox1 to "Scissors"
            button4.Enabled = true;
            UserChoice = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random RandomGenerator = new Random(); // Create a new random number generator
            int PCChoice = RandomGenerator.Next(1, 4);
            switch (PCChoice) // Use a switch statement to set the image based on PC's choice (1 = Rock, 2 = Scissors, 3 = Paper)
            {
                case 1:
                    pictureBox2.Image =
                    RockPaperScissors.Properties.Resources.Rock;
                    break;
                case 2:
                    pictureBox2.Image =
                    RockPaperScissors.Properties.Resources.Scissors;
                    break;
                case 3:
                    pictureBox2.Image =
                    RockPaperScissors.Properties.Resources.Paper;
                    break;
            }
            if (PCChoice == UserChoice)   // Determine the result of the game based on the PC's choice and the user's choice
                MessageBox.Show("Draw");
            else if ((PCChoice == 1) && (UserChoice == 2))
                MessageBox.Show("Player Wins");
            else if ((PCChoice == 1) && (UserChoice == 3))
                MessageBox.Show("PC Wins");
            else if ((PCChoice == 2) && (UserChoice == 1))
                MessageBox.Show("PC Wins");
            else if ((PCChoice == 2) && (UserChoice == 3))
                MessageBox.Show("Player Wins");
            else if ((PCChoice == 3) && (UserChoice == 1))
                MessageBox.Show("Player Wins");
            else if ((PCChoice == 3) && (UserChoice == 2))
                MessageBox.Show("PC Wins");
        }
    }
}
