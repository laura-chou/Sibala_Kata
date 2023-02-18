using System;
using System.Linq;

namespace Sibala
{
    public class Game
    {
        public string ShowResult(string input)
        {
            var parse = new Parse();
            var player = parse.Parser(input);
            var winnerPlayer = player[0].Name;
            var winnerCategory = "all of a kind";
            var winnerPoints = player[0].Dices.First().Value;
            return $"{winnerPlayer} win. - with {winnerCategory}: {winnerPoints}";
        }
    }
}