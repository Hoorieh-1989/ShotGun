using System;

namespace ShotGun
{
   
    public class Game
    {
        private Player player;     // The player instance
        private Player computer;   // The computer instance
        private Random random;     // Random number generator for computer actions

        // Constructor that initializes the game with player and computer instances
        public Game(Player player, Player computer)
        {
            this.player = player;        // Assigns the player object
            this.computer = computer;      // Assigns the computer object
            random = new Random();        // Initializes the random number generator
        }

        
        public (string message, bool isGameOver) Winner()
        {
            // Check for various combinations of choices and return appropriate messages and game state
            if (player.Choice == "Load" && computer.Choice == "Load")
            {
                return ("Both get 1 shot", false); // Both players gain a shot
            }
            else if (player.Choice == "Block" && computer.Choice == "Block")
            {
                return ("Both blocked, continue playing", false); // Both block, continue game
            }
            else if (player.Choice == "Shoot" && computer.Choice == "Shoot")
            {
                return ("Both lost a shot", false); // Both players lose a shot
            }
            else if (player.Choice == "Load" && computer.Choice == "Block")
            {
                return ($"{player.Name} gets 1 shot, {computer.Name} blocked.", false); // Player gains a shot, computer blocks
            }
            else if (player.Choice == "Block" && computer.Choice == "Load")
            {
                return ($"{computer.Name} gets 1 shot, {player.Name} blocked.", false); // Computer gains a shot, player blocks
            }
            else if (player.Choice == "Shoot" && computer.Choice == "Block")
            {
                return ($"{player.Name} lost a shot.", false); // Player loses a shot to a block
            }
            else if (player.Choice == "Block" && computer.Choice == "Shoot")
            {
                return ($"{computer.Name} lost a shot.", false); // Computer loses a shot to a block
            }
            else if (player.Choice == "Shoot" && computer.Choice == "Load")
            {
                ResetShots(); // Resets shots if player shoots and computer loads
                return ($"{player.Name} Wins the game!", true); // Player wins
            }
            else if (player.Choice == "Load" && computer.Choice == "Shoot")
            {
                ResetShots(); // Resets shots if player loads and computer shoots
                return ($"{computer.Name} Wins the game!", true); // Computer wins
            }
            else if (player.Choice == "Shotgun")
            {
                ResetShots(); // Resets shots when player uses Shotgun
                return ($"{player.Name} Wins the game with SHOTGUN!", true); // Player wins with Shotgun
            }
            else if (computer.Choice == "Shotgun")
            {
                ResetShots(); // Resets shots when computer uses Shotgun
                return ($"{computer.Name} Wins the game with SHOTGUN!", true); // Computer wins with Shotgun
            }
            else
            {
                return ("Unexpected outcome", false); // Catch-all for any unexpected game states
            }
        }

        // Resets the shot counts for both players to zero
        private void ResetShots()
        {
            player.Shot = 0;     // Set player's shots to 0
            computer.Shot = 0;   // Set computer's shots to 0
        }
    }
}
