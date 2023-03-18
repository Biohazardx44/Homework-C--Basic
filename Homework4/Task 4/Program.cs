Console.Write("Enter your date of birth (yyyy-MM-dd): ");
DateTime birthday = DateTime.Parse(Console.ReadLine());

int age = AgeCalculator(birthday);
Console.WriteLine($"You are {age} years old.");

int AgeCalculator(DateTime birthday)
{
    DateTime today = DateTime.Today;
    int age = today.Year - birthday.Year;

    if (birthday > today.AddYears(-age))
    {
        age--;
    }

    return age;
}