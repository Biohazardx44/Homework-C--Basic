Console.Write("Enter a sentence: ");
string inputSentence = Console.ReadLine();

string[] words = inputSentence.Split(' ');

Console.WriteLine("The words in the sentence are:");
foreach (string word in words)
{
    Console.WriteLine(word);
}