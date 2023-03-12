// See https://aka.ms/new-console-template for more information

int num1;
int num2;
int tempVarToStoreData;

Console.Write("Input the First Number: ");
num1 = int.Parse(Console.ReadLine());

Console.Write("Input the Second Number: ");
num2 = int.Parse(Console.ReadLine());

tempVarToStoreData = num1;
num1 = num2;
num2 = tempVarToStoreData;

Console.WriteLine("After Swapping:");
Console.WriteLine("First Number: " + num1);
Console.WriteLine("Second Number: " + num2);