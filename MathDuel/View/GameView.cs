using System;
using MathDuel.Models;

namespace MathDuel.Views
{
    /// <summary>
    /// Console implementation of the game view
    /// </summary>
    public class GameView
    {
        public void DisplayWelcome()
        {
            Console.WriteLine("=== Math Duel ===");
            Console.WriteLine("Answer the math problems correctly!");
            Console.WriteLine("You can make up to 3 mistakes.");
            Console.WriteLine();
        }

        public void DisplayQuestion(QuestionModel question)
        {
            Console.Write($"Question: {question.GetQuestionText()} ");
        }

        public void DisplayCorrectAnswer()
        {
            Console.WriteLine("Correct!\n");
        }

        public void DisplayWrongAnswer(int correctAnswer)
        {
            Console.WriteLine($"Wrong! The correct answer was {correctAnswer}.\n");
        }

        public void DisplayGameOver(int score)
        {
            Console.WriteLine($"Game over! Your final score is: {score}");
        }

        public int GetPlayerAnswer()
        {
            string input = Console.ReadLine();
            
            // Basic input validation
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            
            Console.WriteLine("Invalid input. Please enter a number.");
            return GetPlayerAnswer(); // Recursively try again
        }
    }
}