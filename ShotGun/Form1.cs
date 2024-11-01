using System;
using System.Windows.Forms;

namespace ShotGun
{
    public partial class Form1 : Form
    {
        private Player player;
        private Computer computer;
        private Game gameLogic;

        public Form1 ()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            player = new Player(0, "Player", "");
            computer = new Computer(0, "Computer", "");
            gameLogic = new Game(player, computer);
            UpdateStatus();
        }
        private void DisplayMessage(string resultMessage, bool isGameOver)
        {
            labelMessage.Text = resultMessage;
            buttonStartAgain.Visible = true; 
        }

        private void UpdateStatus()
        {
            labelPlayer.Text = $"{player.Name} - Shots: {player.Shot} - Choice: {player.Choice}";
            labelComputer.Text = $"{computer.Name} - Shots: {computer.Shot} - Choice: {computer.Choice}";
            labelMessage.Text = "";
        }
        private void buttonStartAgain_Click(object sender, EventArgs e)
        {
            InitializeGame(); //clear evertyhing 

        }
        private void buttonShoot_Click(object sender, EventArgs e)
        {
            if (player.Shot == 0)
            {
                labelMessage.Text = "No shots left";
                return;
            }

            player.Shoot();
            computer.ComputerAction();

            var (resultMessage, isGameOver) = gameLogic.Winner();

            UpdateStatus(); 
            DisplayMessage(resultMessage, isGameOver);
        }


        private void buttonLoad_Click(object sender, EventArgs e)
        {
            player.Load();
            computer.ComputerAction(); 

            var (resultMessage, isGameOver) = gameLogic.Winner();
            UpdateStatus();
            DisplayMessage(resultMessage, isGameOver);
        }

        private void buttonBlock_Click(object sender, EventArgs e)
        {
            player.Block();
            computer.ComputerAction(); // Use computer instance directly
            var (resultMessage, isGameOver) = gameLogic.Winner();
            UpdateStatus();
            DisplayMessage(resultMessage, isGameOver);
        }

        private void buttonShotGun_Click(object sender, EventArgs e)
        {
            if (player.Shot >= 3)
            {
                player.Shotgun();
                var (resultMessage, isGameOver) = gameLogic.Winner();
                UpdateStatus();
                DisplayMessage(resultMessage, isGameOver);
            }
            else
            {
                labelMessage.Text = "Not enough shots for Shotgun!";
            }
        }

      

       

        private void textBoxPlayerName_TextChanged(object sender, EventArgs e)
        {
            player.Name = labelPlayer.Text;
        }

        private void textBoxComputer_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
