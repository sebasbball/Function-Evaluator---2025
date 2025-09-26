namespace Evaluator.Core;

public class ExpressionEvaluator
{
    public static double Evaluate(string infix)
    {
        var postfix = InfixToPostfix(infix);
        return Calulate(postfix);
    }

    private static Queue<string> InfixToPostfix(string infix)
    {
        var stack = new Stack<string>();
        var postfix = new Queue<string>();
        var tokens = TokenizeExpression(infix);

        foreach (string token in tokens)
        {
            if (IsOperator(token))
            {
                if (token == ")")
                {
                    while (stack.Count > 0 && stack.Peek() != "(")
                    {
                        postfix.Enqueue(stack.Pop());
                    }
                    if (stack.Count > 0)
                        stack.Pop(); // Remove '('
                }
                else
                {
                    while (stack.Count > 0 &&
                        PriorityInfix(token) <= PriorityStack(stack.Peek()))
                    {
                        postfix.Enqueue(stack.Pop());
                    }
                    stack.Push(token);
                }
            }
            else
            {
                postfix.Enqueue(token);
            }
        }

        while (stack.Count > 0)
        {
            postfix.Enqueue(stack.Pop());
        }
        return postfix;
    }

    private static List<string> TokenizeExpression(string infix)
    {
        var tokens = new List<string>();
        var currentNumber = string.Empty;

        foreach (char c in infix)
        {
            if (char.IsDigit(c) || c == '.')
            {
                currentNumber += c;
            }
            else if (IsOperator(c.ToString()))
            {
                if (!string.IsNullOrEmpty(currentNumber))
                {
                    tokens.Add(currentNumber);
                    currentNumber = string.Empty;
                }
                tokens.Add(c.ToString());
            }
        }

        if (!string.IsNullOrEmpty(currentNumber))
        {
            tokens.Add(currentNumber);
        }

        return tokens;
    }

    private static bool IsOperator(string token) => token is "^" or "/" or "*" or "%" or "+" or "-" or "(" or ")";

    private static int PriorityInfix(string op) => op switch
    {
        "^" => 4,
        "*" or "/" or "%" => 2,
        "-" or "+" => 1,
        "(" => 5,
        _ => throw new Exception("Invalid expression."),
    };

    private static int PriorityStack(char op) => op switch
    {
        '^' => 3,
        '*' or '/' or '%' => 2,
        '-' or '+' => 1,
        '(' => 0,
        _ => throw new Exception("Invalid expression."),
    };

    private static double Calulate(Queue<string> postfix)
    {
        var stack = new Stack<double>();

        while (postfix.Count > 0)
        {
            string token = postfix.Dequeue();

            if (IsOperator(token))
            {
                var op2 = stack.Pop();
                var op1 = stack.Pop();
                stack.Push(Calulate(op1, token, op2));
            }
            else
            {
                stack.Push(Convert.ToDouble(token));
            }
        }

        return stack.Peek();
    }

    private static double Calulate(double op1, string op, double op2) => op switch
    {
        "*" => op1 * op2,
        "/" => op1 / op2,
        "^" => Math.Pow(op1, op2),
        "+" => op1 + op2,
        "-" => op1 - op2,
        _ => throw new Exception("Invalid expression."),
    };
}