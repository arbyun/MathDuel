using MathDuel.Controllers;
using MathDuel.Models;
using MathDuel.Views;

namespace MathDuel
{
    class Program
    {
        static void Main()
        {
            // Create the model
            var gameModel = new GameModel();
            
            // Create the view
            var gameView = new GameView();
            
            // Create the controller with the model and view
            var gameController = new GameController(gameModel, gameView);
            
            // Start the game
            gameController.RunGame();
        }
    }
}
