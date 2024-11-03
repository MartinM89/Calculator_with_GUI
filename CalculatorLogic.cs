public class CalculatorLogic
{
    public static string StringToCalculate(string userInput)
    {
        double firstNumber;
        double secondNumber;
        char chosenOperator;
        char[] possibleOperators = ['+', '-', '*', '/', '%'];

        int operatorIndex = -1;
        foreach (char op in possibleOperators)
        {
            operatorIndex = userInput.IndexOf(op);
            if (!operatorIndex.Equals(-1))
            {
                chosenOperator = op;
                break;
            }
        }

        firstNumber = double.Parse(userInput.Substring(0, operatorIndex));
        secondNumber = double.Parse(userInput.Substring(operatorIndex + 1));
        chosenOperator = userInput[operatorIndex];

        return chosenOperator switch
        {
            '+' => CalculateAdd(firstNumber, secondNumber),
            '-' => CalculateSubstract(firstNumber, secondNumber),
            '*' => CalculateMultiply(firstNumber, secondNumber),
            '/' => CalculateDivide(firstNumber, secondNumber),
            '%' => CalculateModulus(firstNumber, secondNumber),
            _ => throw new InvalidOperationException("Operator not supported!")

        };
    }

    public static string CalculateAdd(double firstNumber, double secondNumber)
    {
        double resultNumber = firstNumber + secondNumber;

        string result = double.Round(resultNumber, 5).ToString();
        return result;
    }

    public static string CalculateSubstract(double firstNumber, double secondNumber)
    {
        double resultNumber = firstNumber - secondNumber;

        string result = double.Round(resultNumber, 5).ToString();
        return result;
    }

    public static string CalculateMultiply(double firstNumber, double secondNumber)
    {
        double resultNumber = firstNumber * secondNumber;

        string result = double.Round(resultNumber, 5).ToString();
        return result;
    }

    public static string CalculateDivide(double firstNumber, double secondNumber)
    {
        double resultNumber = firstNumber / secondNumber;

        string result = double.Round(resultNumber, 5).ToString();
        return result;
    }

    public static string CalculateModulus(double firstNumber, double secondNumber)
    {
        double resultNumber = firstNumber % secondNumber;

        string result = double.Round(resultNumber, 5).ToString();
        return result;
    }
}
