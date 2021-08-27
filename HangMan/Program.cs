
namespace HangMan;

class HangMan
{
    static readonly string correctWord = "hangman";
    static char[]? letters;
    static string name = string.Empty;
    static int guesses = 0;

    static void Main()
    {
        StartGame();
        PlayGame();
        EndGame();
    }

    static void StartGame()
    {
        letters = new char[correctWord.Length];
        for (int i = 0; i < correctWord.Length; i++) 
            letters[i] = '-';
        AskForUsersName();
    }

    static void AskForUsersName()
    {
        Console.Write("Enter your name: ");
        string input = Console.ReadLine() ?? "Player";
        if (input.Length >= 2) 
            name = input;
        else 
            AskForUsersName();
    }

    static void PlayGame()
    {
        while (true)
        {
            Console.Clear();
            DisplayMaskedWord();
            char guessedLetter = AskForLetter();
            CheckLetter(guessedLetter);
            if (correctWord == new string(letters))
                break;
        }

        Console.Clear();
    }

    private static void CheckLetter(char guessedLetter)
    {
        for (int i = 0; i < correctWord.Length; i++)
        {
            if (guessedLetter == correctWord[i]) 
                letters[i] = guessedLetter;
        }
    }

    static void DisplayMaskedWord()
    {
        foreach (char c in letters) 
            Console.Write(c);

        Console.WriteLine();
    }

    static char AskForLetter()
    {
        string input;
        while (true)
        {
            Console.Write("Enter a letter: ");
            input = Console.ReadLine() ?? string.Empty;
            if (input.Length == 1) 
                break;
        }

        guesses++;

        return input[0];
    }

    static void EndGame()
    {
        Console.WriteLine("Game over...");
        Console.WriteLine($"Thanks for playing, {name}");
        Console.WriteLine($"You made {guesses} guesses");
    }
}
