// See https://aka.ms/new-console-template for more information

string[] studentsG1 = { "Ana", "Kole", "Sime", "Ivan", "Jovan" };
string[] studentsG2 = { "Nikola", "Martin", "Viktor", "Kire", "Spase" };

Console.Write("Enter student group (1 or 2): ");
int studentGroup = int.Parse(Console.ReadLine());

if (studentGroup == 1)
{
    Console.WriteLine("The Students in G1 are: ");
    foreach (string student in studentsG1)
    {
        Console.WriteLine(student);
    }
}
else if (studentGroup == 2)
{
    Console.WriteLine("The Students in G2 are: ");
    foreach (string student in studentsG2)
    {
        Console.WriteLine(student);
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter 1 or 2!");
}