
StartGame();
PlayGame();
EndGame();


static void StartGame()
{
    Console.WriteLine("Starting the game...");
    AskForUsersName();
}

static void AskForUsersName()
{
    Console.WriteLine("Asking user for name...");
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
}

static void EndGame()
{
    Console.WriteLine("Game over...");
}