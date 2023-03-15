// See https://aka.ms/new-console-template for more information

//Exercise 1
int Sum(int num1, int num2)
{
    return num1 + num2;
}
int Subtract(int num1, int num2)
{
    return num1 - num2;
}

int Divide(int num1, int num2)
{
    if (num2 == 0)
    {
        Console.WriteLine("Cannot divide by zero.");
        return 0;
    }
    return num1 / num2;
}

int Multiply(int num1, int num2)
{
    return num1 * num2;
}

int Calculator(char operation, int num1, int num2)
{
    int result = 0;

    switch (operation)
    {
        case '+':
            result = Sum(num1, num2);
            break;
        case '-':
            result = Subtract(num1, num2);
            break;
        case '/':
            result = Divide(num1, num2);
            break;
        case '*':
            result = Multiply(num1, num2);
            break;
        default:
            Console.WriteLine("Invalid operation");
            break;
    }
    return result;
}

Console.WriteLine("Enter number 1:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter operation (+,-,/,*):");
char op = char.Parse(Console.ReadLine());

Console.WriteLine("Enter number 2:");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = Calculator(op, number1, number2);
Console.WriteLine($"The result is {result}.");