using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUno;

public struct Card
{
    public CardValue Value;
    public CardColor Color;
    public char numValue;

    public Card(CardValue val, CardColor col, char numV = 'n')
    {
        Value = val;
        Color = col;
        numValue = numV;
    }

    public ConsoleColor GetConsoleColor()
    {
        switch (Color)
        {
            case CardColor.None: return ConsoleColor.White;
            case CardColor.Red: return ConsoleColor.Red;
            case CardColor.Blue: return ConsoleColor.Blue;
            case CardColor.Green: return ConsoleColor.Green;
            case CardColor.Yellow: return ConsoleColor.Yellow;
            default: return ConsoleColor.White;
        }
    }
}
