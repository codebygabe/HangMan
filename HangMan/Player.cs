namespace HangMan;

public class Player
{
    private int _score;

    public Player(string name)
    {
        Name = name;
    }

    public string Name { get; private set; }
    public List<char> GuessedLetters { get; set; } = new();

    public int Score
    {
        get
        {
            return _score;
        }
        set
        {
            if (value > 0)
                _score = value;
        }
    }
}

