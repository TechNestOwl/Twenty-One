//Gill Guimaraes
// Mini-Project #2

using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Policy;
using Twenty_One.Properties;

namespace Twenty_One
{
    public partial class Form1 : Form
    {
        private int totalScore = 0;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            ResetGame(); // Initializin the game
            PlayAgainBtn.Visible = false; // Hiding Play Again button initially
        }

        private void rollOneDie_Click_1(object sender, EventArgs e)
        {
            int roll = random.Next(1, 7);
            totalScore += roll;

            // Display the corresponding dice image
            pictureBox1.Image = GetDiceImage(roll);
            pictureBox2.Image = null; // not displaying the second dice

            UpdateGameState();
        }

        private void rollTwoDice_Click_1(object sender, EventArgs e)
        {
            int roll1 = random.Next(1, 7);
            int roll2 = random.Next(1, 7);
            totalScore += (roll1 + roll2);

            // Show both dice images
            pictureBox1.Image = GetDiceImage(roll1);
            pictureBox2.Image = GetDiceImage(roll2);

            UpdateGameState();
        }

        private Image GetDiceImage(int diceValue)
        {
            switch (diceValue)
            {
                case 1: return Properties.Resources.dice1; 
                case 2: return Properties.Resources.dice2;
                case 3: return Properties.Resources.dice3;
                case 4: return Properties.Resources.dice4;
                case 5: return Properties.Resources.dice5;
                case 6: return Properties.Resources.dice6;
                default: return null;
            }
        }
        private void hitCount_Click(object sender, EventArgs e)
        {

        }
        private void UpdateGameState()
        {
            // update hitCount label
            hitCount.Text = totalScore.ToString();

            // Check my win/lose conditions
            if (totalScore == 21)
            {
                DialogResult result = MessageBox.Show(
                    "Congratulations! You hit 21!\nWould you like to play again?",
                    "Winner!",
                    MessageBoxButtons.YesNo);

                HandleGameEnd(result);
            }
            else if (totalScore > 21)
            {
                DialogResult result = MessageBox.Show(
                    $"Game Over! You went over 21 with {totalScore}!\nWould you like to play again?",
                    "Game Over",
                    MessageBoxButtons.YesNo);

                HandleGameEnd(result);
            }
        }

        private void HandleGameEnd(DialogResult result)
        {
            if (result == DialogResult.Yes)
            {
                ResetGame();
            }
            else
            {
                this.Close();
            }
        }

        private void ResetGame()
        {
            totalScore = 0;
            hitCount.Text = "0";
            pictureBox1.Image = null;
            pictureBox2.Image = null;
        }

        private void PlayAgainBtn_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
