public class EvaluateReversePolishNotationSolution {
    public int EvalRPN(string[] tokens) {
        Stack<string> stack = new Stack<string>();

        for(int i = 0; i < tokens.Length; i++)
        {
            if (tokens[i] != "+" && tokens[i] != "-" && tokens[i] != "*" && tokens[i] != "/")
            {
                stack.Push($"{tokens[i]}");
            }
            else
            {
                var firstDigit = stack.Pop();
                var secondDigit = stack.Pop();

                if (tokens[i] == "+")
                {
                    var result = int.Parse(secondDigit) + int.Parse(firstDigit);
                    stack.Push(result.ToString());
                }
                else if (tokens[i] == "-")
                {
                    var result = int.Parse(secondDigit) - int.Parse(firstDigit);
                    stack.Push(result.ToString());
                }
                else if (tokens[i] == "*")
                {
                    var result = int.Parse(secondDigit) * int.Parse(firstDigit);
                    stack.Push(result.ToString());
                }
                else if (tokens[i] == "/")
                {
                    var result = int.Parse(secondDigit) / int.Parse(firstDigit);
                    stack.Push(result.ToString());
                }
            }
        }
var finalResult = stack.Pop();
        return int.Parse(finalResult);
    }
}