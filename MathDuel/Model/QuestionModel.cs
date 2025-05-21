namespace MathDuel.Models
{
    /// <summary>
    /// Represents the type of mathematical operation
    /// </summary>
    public enum OperationType
    {
        Addition = 0,
        Subtraction = 1,
        Multiplication = 2
    }

    /// <summary>
    /// Represents a mathematical question with operands and operation
    /// </summary>
    public class QuestionModel
    {
        public int FirstOperand { get; }
        public int SecondOperand { get; }
        public OperationType Operation { get; }
        
        public QuestionModel(int firstOperand, int secondOperand, OperationType operation)
        {
            FirstOperand = firstOperand;
            SecondOperand = secondOperand;
            Operation = operation;
        }

        public int CalculateCorrectAnswer()
        {
            return Operation switch
            {
                OperationType.Addition => FirstOperand + SecondOperand,
                OperationType.Subtraction => FirstOperand - SecondOperand,
                OperationType.Multiplication => FirstOperand * SecondOperand,
                _ => 0 // Default case, should never happen with current implementation
            };
        }

        public string GetQuestionText()
        {
            string operationSymbol = Operation switch
            {
                OperationType.Addition => "+",
                OperationType.Subtraction => "-",
                OperationType.Multiplication => "*",
                _ => "?"
            };

            return $"{FirstOperand} {operationSymbol} {SecondOperand} = ?";
        }
    }
}