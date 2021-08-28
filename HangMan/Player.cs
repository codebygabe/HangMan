using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan;

public class Player
{  
    public Player(string name)
    {
        Name = name;
    }
    
    public string Name { get; set; } = string.Empty;
    public List<char> GuessLetters { get; set; } = new();
    public int Score { get; set; } = 0;
}

