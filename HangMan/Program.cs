
namespace HangMan;

class HangMan
{
    static string name = string.Empty;
    static int guesses;

    static void Main(string[] args)
    {
        StartGame();
        PlayGame();
        EndGame();
    }

    static void StartGame()
    {
        Console.WriteLine("Starting the game...");
        AskForUsersName();
    }

    static void AskForUsersName()
    {
        Console.Write("Enter your name: ");
        var input = Console.ReadLine() ?? "Player";
        if (input.Length >= 2) name = input;
        else AskForUsersName();
    }

    static void PlayGame()
    {
        Console.WriteLine("Playing the game...");
        DisplayMaskedWord();
        AskForLetter();
    }

    static void DisplayMaskedWord()
    {
        Console.WriteLine("Displaying masked word...");
    }

    static void AskForLetter()
    {
        Console.WriteLine("Asking for letter...");
        guesses++;
    }

    static void EndGame()
    {
        Console.WriteLine("Game over...");
        Console.WriteLine($"Thanks for playing, {name}");
        Console.WriteLine($"You made {guesses} guesses");
    }
}
