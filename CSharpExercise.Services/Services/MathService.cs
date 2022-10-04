namespace CSharpExercise.Domain.Services
{
    public class MathService
    {
        public decimal Addition( decimal firstNumber, decimal secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public decimal Substraction(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public decimal Multiplication(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public decimal Division(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber / secondNumber;
        }

        public string ChangeCommeToPoint(string text)
        {
            if (text.Contains(","))
            {
                string convertedText = text.Replace(",",".");
                text = convertedText;
            }

            return text;
        }
    }
}