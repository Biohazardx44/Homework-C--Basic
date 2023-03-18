Console.Write("Enter a number: ");
int inputNumber = int.Parse(Console.ReadLine());

int digitSum = SumDigits(inputNumber);
Console.WriteLine($"The sum of the digits in {inputNumber} is {digitSum}");

int SumDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}