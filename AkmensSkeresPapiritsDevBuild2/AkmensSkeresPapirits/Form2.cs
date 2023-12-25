using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkmensSkeresPapirits
{
    public partial class Form2 : Form
    {
        
        bool gameover = false;

        string[] ComputerChoiceList = { "Rock", "Paper", "Scissors", "Paper", "Scissors", "Rock" };

        int randomnumber = 0;

        Random random = new Random();

        string ComputerChoice;
        string PlayerChoice;

        int ComputerScore = 0;
        int PlayerScore = 0;
        
        public Form2()
        {
            InitializeComponent();

            PlayerChoice = "none";
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void butRock_Click(object sender, EventArgs e)
        {
            picBoxPlayer.Image = Properties.Resources.Rock;
            PlayerChoice = "Rock";

            randomnumber = random.Next(0, ComputerChoiceList.Length);

            ComputerChoice = ComputerChoiceList[randomnumber];

            switch (ComputerChoice)
            {
                case "Rock":
                    picBoxComputer.Image = Properties.Resources.Rock;
                    break;

                case "Paper":
                    picBoxComputer.Image = Properties.Resources.Paper;
                    break;

                case "Scissors":
                    picBoxComputer.Image = Properties.Resources.Scissors;
                    break;
            }
            checkGame();
        }

        public void butScissors_Click(object sender, EventArgs e)
        {
            picBoxPlayer.Image = Properties.Resources.Scissors;
            PlayerChoice = "Scissors";

            randomnumber = random.Next(0, ComputerChoiceList.Length);

            ComputerChoice = ComputerChoiceList[randomnumber];

            switch (ComputerChoice)
            {
                case "Rock":
                    picBoxComputer.Image = Properties.Resources.Rock;
                    break;

                case "Paper":
                    picBoxComputer.Image = Properties.Resources.Paper;
                    break;

                case "Scissors":
                    picBoxComputer.Image = Properties.Resources.Scissors;
                    break;
            }
            checkGame();
        }

        public void butPaper_Click(object sender, EventArgs e)
        {
            picBoxPlayer.Image = Properties.Resources.Paper;
            PlayerChoice = "Paper";
            randomnumber = random.Next(0, ComputerChoiceList.Length);

            ComputerChoice = ComputerChoiceList[randomnumber];

            switch (ComputerChoice)
            {
                case "Rock":
                    picBoxComputer.Image = Properties.Resources.Rock;
                    break;

                case "Paper":
                    picBoxComputer.Image = Properties.Resources.Paper;
                    break;

                case "Scissors":
                    picBoxComputer.Image = Properties.Resources.Scissors;
                    break;
            }
            checkGame();
        }



        public void checkGame()
        {
            if (PlayerChoice == "Rock" && ComputerChoice == "Paper")
            {
                ComputerScore += 1;

                labComputerScore.Text = (ComputerScore).ToString();

                labWinner.Text = "Dators uzvar!";
            }
            else if (PlayerChoice == "Scissors" && ComputerChoice == "Rock")
            {
                ComputerScore += 1;

                labComputerScore.Text = (ComputerScore).ToString();

                labWinner.Text = "Dators uzvar!";
            }
            else if (PlayerChoice == "Paper" && ComputerChoice == "Scissors")
            {
                ComputerScore += 1;

                labComputerScore.Text = (ComputerScore).ToString();

                labWinner.Text = "Dators uzvar!";
            }
            else if (PlayerChoice == "Rock" && ComputerChoice == "Scissors")
            {
                PlayerScore += 1;

                labPlayerScore.Text = (PlayerScore).ToString();

                labWinner.Text = "Spēlētājs uzvar!";
            }
            else if (PlayerChoice == "Scissors" && ComputerChoice == "Paper")
            {
                PlayerScore += 1;

                labPlayerScore.Text = (PlayerScore).ToString();

                labWinner.Text = "Spēlētājs uzvar!";
            }
            else if (PlayerChoice == "Paper" && ComputerChoice == "Rock")
            {
                PlayerScore += 1;

                labPlayerScore.Text = (PlayerScore).ToString();

                labWinner.Text = "Spēlētājs uzvar!";
            }
            else
            {
                labWinner.Text = "Neizšķirts";
            }
        }


    }
}
