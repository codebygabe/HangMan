
namespace HangMan;

internal class HangMan
{
    private static string correctWord;
    private static char[] letters;
    private static Player player;
    
    private static void Main()
    {
        StartGame();
        PlayGame();
        EndGame();
    }

    private static void StartGame()
    {
        string[] words = File.ReadAllLines(@"C:\Users\Gabriel\Desktop\words.txt");

        var rand = new Random();
        correctWord = words[rand.Next(0, words.Length)];

        letters = new char[correctWord.Length];
        for (int i = 0; i < correctWord.Length; i++)
            letters[i] = '-';

        AskForUsersName();
    }

    private static void AskForUsersName()
    {
        Console.Write("Enter your name: ");
        string input = Console.ReadLine() ?? "Player";
        if (input.Length >= 2)
            player = new Player(input);
        else
            AskForUsersName();
    }

    private static void PlayGame()
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

    private static void DisplayMaskedWord()
    {
        foreach (char c in letters)
            Console.Write(c);
        Console.WriteLine();
    }

    private static char AskForLetter()
    {
        string input;
        while (true)
        {
            Console.Write("Enter a letter: ");
            input = Console.ReadLine() ?? string.Empty;
            if (input.Length == 1)
                break;
        }

        var letter = input[0];

        if (!player.GuessedLetters.Contains(letter))
            player.GuessedLetters.Add(letter);

        return letter;
    }

    private static void CheckLetter(char guessedLetter)
    {
        for (int i = 0; i < correctWord.Length; i++)
        {
            if (guessedLetter == correctWord[i])
            {
                letters[i] = guessedLetter;
                player.Score++;
            }
        }
    }

    private static void EndGame()
    {
        Console.WriteLine("Game over...");
        Console.WriteLine($"Thanks for playing, {player.Name}");
        Console.WriteLine($"Guessed: {player.GuessedLetters.Count} Score: {player.Score}");
    }
}
