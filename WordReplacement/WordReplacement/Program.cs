Console.Write("Please enter the statement: ");
var userInputStatement = Console.ReadLine();
Console.WriteLine($"Statement: {userInputStatement}");

Console.Write("Please enter the word to replace: ");
var userInputWordToReplace = Console.ReadLine();
Console.WriteLine($"Word to replace: {userInputWordToReplace}");

Console.Write("Please enter the replacement word: ");
var userInputReplacementWord = Console.ReadLine();
Console.WriteLine($"Replacement word: {userInputReplacementWord}");

if (userInputStatement!.Contains(userInputWordToReplace!))
{
    Console.WriteLine($"New statement: {userInputStatement.Replace(userInputWordToReplace!, userInputReplacementWord)}");
}
else 
{
    Console.WriteLine($"Could not complete the replacement. {userInputWordToReplace} does not exist in the orginal statement '{userInputStatement}'");
}