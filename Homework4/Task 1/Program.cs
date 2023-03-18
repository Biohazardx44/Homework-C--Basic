Console.Write("Enter a string & get the last 5 characters: ");
string inputString = Console.ReadLine();

if (inputString.Length >= 5)
{
    string lastFiveChars = "";
    if (inputString.Length >= 5)
    {
        lastFiveChars = inputString.Substring(inputString.Length - 5);
    }
    Console.WriteLine("Last 5 characters of the input string: " + lastFiveChars);
}
else
{
    Console.WriteLine("Input string is too short! It must be at least 5 characters long.");
}