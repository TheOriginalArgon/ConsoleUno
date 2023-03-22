using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUno;

internal static class Engine
{
    public static List<Card> Deck = new List<Card>()
    {
        new Card(CardValue.Number, CardColor.Red, '0'),
        new Card(CardValue.Number, CardColor.Red, '0'),
        new Card(CardValue.Number, CardColor.Red, '1'),
        new Card(CardValue.Number, CardColor.Red, '1'),
        new Card(CardValue.Number, CardColor.Red, '2'),
        new Card(CardValue.Number, CardColor.Red, '2'),
        new Card(CardValue.Number, CardColor.Red, '3'),
        new Card(CardValue.Number, CardColor.Red, '3'),
        new Card(CardValue.Number, CardColor.Red, '4'),
        new Card(CardValue.Number, CardColor.Red, '4'),
        new Card(CardValue.Number, CardColor.Red, '5'),
        new Card(CardValue.Number, CardColor.Red, '5'),
        new Card(CardValue.Number, CardColor.Red, '6'),
        new Card(CardValue.Number, CardColor.Red, '6'),
        new Card(CardValue.Number, CardColor.Red, '7'),
        new Card(CardValue.Number, CardColor.Red, '7'),
        new Card(CardValue.Number, CardColor.Red, '8'),
        new Card(CardValue.Number, CardColor.Red, '8'),
        new Card(CardValue.Number, CardColor.Red, '9'),
        new Card(CardValue.Number, CardColor.Red, '9'),
        new Card(CardValue.DrawTwo, CardColor.Red),
        new Card(CardValue.DrawTwo, CardColor.Red),
        new Card(CardValue.Skip, CardColor.Red),
        new Card(CardValue.Skip, CardColor.Red),
        new Card(CardValue.Reverse, CardColor.Red),
        new Card(CardValue.Reverse, CardColor.Red),

        new Card(CardValue.Number, CardColor.Blue, '0'),
        new Card(CardValue.Number, CardColor.Blue, '0'),
        new Card(CardValue.Number, CardColor.Blue, '1'),
        new Card(CardValue.Number, CardColor.Blue, '1'),
        new Card(CardValue.Number, CardColor.Blue, '2'),
        new Card(CardValue.Number, CardColor.Blue, '2'),
        new Card(CardValue.Number, CardColor.Blue, '3'),
        new Card(CardValue.Number, CardColor.Blue, '3'),
        new Card(CardValue.Number, CardColor.Blue, '4'),
        new Card(CardValue.Number, CardColor.Blue, '4'),
        new Card(CardValue.Number, CardColor.Blue, '5'),
        new Card(CardValue.Number, CardColor.Blue, '5'),
        new Card(CardValue.Number, CardColor.Blue, '6'),
        new Card(CardValue.Number, CardColor.Blue, '6'),
        new Card(CardValue.Number, CardColor.Blue, '7'),
        new Card(CardValue.Number, CardColor.Blue, '7'),
        new Card(CardValue.Number, CardColor.Blue, '8'),
        new Card(CardValue.Number, CardColor.Blue, '8'),
        new Card(CardValue.Number, CardColor.Blue, '9'),
        new Card(CardValue.Number, CardColor.Blue, '9'),
        new Card(CardValue.DrawTwo, CardColor.Blue),
        new Card(CardValue.DrawTwo, CardColor.Blue),
        new Card(CardValue.Skip, CardColor.Blue),
        new Card(CardValue.Skip, CardColor.Blue),
        new Card(CardValue.Reverse, CardColor.Blue),
        new Card(CardValue.Reverse, CardColor.Blue),

        new Card(CardValue.Number, CardColor.Green, '0'),
        new Card(CardValue.Number, CardColor.Green, '0'),
        new Card(CardValue.Number, CardColor.Green, '1'),
        new Card(CardValue.Number, CardColor.Green, '1'),
        new Card(CardValue.Number, CardColor.Green, '2'),
        new Card(CardValue.Number, CardColor.Green, '2'),
        new Card(CardValue.Number, CardColor.Green, '3'),
        new Card(CardValue.Number, CardColor.Green, '3'),
        new Card(CardValue.Number, CardColor.Green, '4'),
        new Card(CardValue.Number, CardColor.Green, '4'),
        new Card(CardValue.Number, CardColor.Green, '5'),
        new Card(CardValue.Number, CardColor.Green, '5'),
        new Card(CardValue.Number, CardColor.Green, '6'),
        new Card(CardValue.Number, CardColor.Green, '6'),
        new Card(CardValue.Number, CardColor.Green, '7'),
        new Card(CardValue.Number, CardColor.Green, '7'),
        new Card(CardValue.Number, CardColor.Green, '8'),
        new Card(CardValue.Number, CardColor.Green, '8'),
        new Card(CardValue.Number, CardColor.Green, '9'),
        new Card(CardValue.Number, CardColor.Green, '9'),
        new Card(CardValue.DrawTwo, CardColor.Green),
        new Card(CardValue.DrawTwo, CardColor.Green),
        new Card(CardValue.Skip, CardColor.Green),
        new Card(CardValue.Skip, CardColor.Green),
        new Card(CardValue.Reverse, CardColor.Green),
        new Card(CardValue.Reverse, CardColor.Green),

        new Card(CardValue.Number, CardColor.Yellow, '0'),
        new Card(CardValue.Number, CardColor.Yellow, '0'),
        new Card(CardValue.Number, CardColor.Yellow, '1'),
        new Card(CardValue.Number, CardColor.Yellow, '1'),
        new Card(CardValue.Number, CardColor.Yellow, '2'),
        new Card(CardValue.Number, CardColor.Yellow, '2'),
        new Card(CardValue.Number, CardColor.Yellow, '3'),
        new Card(CardValue.Number, CardColor.Yellow, '3'),
        new Card(CardValue.Number, CardColor.Yellow, '4'),
        new Card(CardValue.Number, CardColor.Yellow, '4'),
        new Card(CardValue.Number, CardColor.Yellow, '5'),
        new Card(CardValue.Number, CardColor.Yellow, '5'),
        new Card(CardValue.Number, CardColor.Yellow, '6'),
        new Card(CardValue.Number, CardColor.Yellow, '6'),
        new Card(CardValue.Number, CardColor.Yellow, '7'),
        new Card(CardValue.Number, CardColor.Yellow, '7'),
        new Card(CardValue.Number, CardColor.Yellow, '8'),
        new Card(CardValue.Number, CardColor.Yellow, '8'),
        new Card(CardValue.Number, CardColor.Yellow, '9'),
        new Card(CardValue.Number, CardColor.Yellow, '9'),
        new Card(CardValue.DrawTwo, CardColor.Yellow),
        new Card(CardValue.DrawTwo, CardColor.Yellow),
        new Card(CardValue.Skip, CardColor.Yellow),
        new Card(CardValue.Skip, CardColor.Yellow),
        new Card(CardValue.Reverse, CardColor.Yellow),
        new Card(CardValue.Reverse, CardColor.Yellow),

        new Card(CardValue.WildDrawFour, CardColor.None),
        new Card(CardValue.WildDrawFour, CardColor.None),
        new Card(CardValue.WildDrawFour, CardColor.None),
        new Card(CardValue.WildDrawFour, CardColor.None),

        new Card(CardValue.Wild, CardColor.None),
        new Card(CardValue.Wild, CardColor.None),
        new Card(CardValue.Wild, CardColor.None),
        new Card(CardValue.Wild, CardColor.None)
    };
    public static List<Card> DiscardPile = new List<Card>();

    public static void ShuffleDeck()
    {
        if (DiscardPile.Count > 0)
        {
            foreach (Card card in DiscardPile)
            {
                DiscardPile.Remove(card);
                Deck.Add(card);
            }
        }
    }
 
    public static void UpdateTurn()
    {
        // todo
    }
}
