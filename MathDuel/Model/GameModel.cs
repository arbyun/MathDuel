using System;

namespace MathDuel.Models
{
    /// <summary>
    /// Represents the game state and logic
    /// </summary>
    public class GameModel
    {
        private readonly Random _random;
        
        public int Score { get; private set; }
        public int WrongAnswers { get; private set; }
        public int MaxWrongAnswers { get; }
        public bool IsGameOver => WrongAnswers >= MaxWrongAnswers;

        public GameModel(int maxWrongAnswers = 3)
        {
            _random = new Random();
            Score = 0;
            WrongAnswers = 0;
            MaxWrongAnswers = maxWrongAnswers;
        }

        public void IncrementScore()
        {
            Score++;
        }

        public void IncrementWrongAnswers()
        {
            WrongAnswers++;
        }

        public QuestionModel GenerateQuestion()
        {
            int a = _random.Next(1, 11);     // 1 to 10
            int b = _random.Next(1, 11);     // 1 to 10
            int operation = _random.Next(3); // 0: +, 1: -, 2: *

            return new QuestionModel(a, b, (OperationType)operation);
        }
    }
}