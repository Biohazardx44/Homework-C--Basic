// See https://aka.ms/new-console-template for more information
//Using double just in case for decimals

////With Switch-Case just in case :)
//Console.WriteLine("This is a Real Calculator!");
//Console.Write("Enter the First number: ");
//double num1 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Enter the Second number: ");
//double num2 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Enter the Operation (+, -, *, /): ");
//string operation = Console.ReadLine();

//double result = 0;
//switch (operation)
//{
//    case "+":
//        result = num1 + num2;
//        break;
//    case "-":
//        result = num1 - num2;
//        break;
//    case "*":
//        result = num1 * num2;
//        break;
//    case "/":
//        result = num1 / num2;
//        break;
//    default:
//        Console.WriteLine("Invalid Operation");
//        break;
//}

//Console.WriteLine("The result is: " + result);

//With If-Else
Console.WriteLine("This is a Real Calculator!");
Console.Write("Enter the First number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the Second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the Operation (+, -, *, /): ");
string operation = Console.ReadLine();

double result = 0;
if (operation == "+")
{
    result = num1 + num2;
}
else if (operation == "-")
{
    result = num1 - num2;
}
else if (operation == "*")
{
    result = num1 * num2;
}
else if (operation == "/")
{
    result = num1 / num2;
}
else
{
    Console.WriteLine("Invalid Operation");
}

Console.WriteLine("The result is: " + result);