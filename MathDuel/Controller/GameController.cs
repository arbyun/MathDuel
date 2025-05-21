using MathDuel.Models;
using MathDuel.Views;

namespace MathDuel.Controllers
{
    /// <summary>
    /// Controller that manages the game flow and coordinates between model and view
    /// </summary>
    public class GameController
    {
        private readonly GameModel _gameModel;
        private readonly GameView _gameView;

        public GameController(GameModel gameModel, GameView gameView)
        {
            _gameModel = gameModel;
            _gameView = gameView;
        }

        /// <summary>
        /// Start and run the game
        /// </summary>
        public void RunGame()
        {
            // Display welcome message
            _gameView.DisplayWelcome();

            // Main game loop
            while (!_gameModel.IsGameOver)
            {
                // Generate a new question
                QuestionModel question = _gameModel.GenerateQuestion();
                
                // Display the question
                _gameView.DisplayQuestion(question);
                
                // Get player's answer
                int playerAnswer = _gameView.GetPlayerAnswer();
                
                // Calculate correct answer
                int correctAnswer = question.CalculateCorrectAnswer();
                
                // Check if answer is correct
                if (playerAnswer == correctAnswer)
                {
                    _gameView.DisplayCorrectAnswer();
                    _gameModel.IncrementScore();
                }
                else
                {
                    _gameView.DisplayWrongAnswer(correctAnswer);
                    _gameModel.IncrementWrongAnswers();
                }
            }

            // Display game over message
            _gameView.DisplayGameOver(_gameModel.Score);
        }
    }
}