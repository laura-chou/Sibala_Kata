using System;
using System.Linq;

namespace Sibala
{
    public class Game
    {
        public string ShowResult(string input)
        {
            var parse = new Parse();
            var parser = parse.Parser(input);
            var winnerPlayer = parser[0].Name;
            var winnerCategory = "all of a kind";
            var winnerPoint = parser[0].Dices.First().Value;
            return $"{winnerPlayer} win. - with {winnerCategory}: {winnerPoint}";
        }
    }
}