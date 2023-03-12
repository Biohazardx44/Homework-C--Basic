// See https://aka.ms/new-console-template for more information

int[] numbers = new int[6];
int sumOfEven = 0;

for (int i = 0; i < 6; i++)
{
    Console.Write("Enter integer no." + (i + 1) + ": ");
    numbers[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 6; i++)
{
    if (numbers[i] % 2 == 0)
    {
        sumOfEven += numbers[i];
    }
}

Console.WriteLine("The result is: " + sumOfEven);