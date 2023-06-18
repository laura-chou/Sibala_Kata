using System;
using System.Linq;

namespace Sibala.src
{
    public class Game
    {
        public string ShowResult(string input)
        {
            var parser = new Parser();
            var parse = parser.Parse(input);

            var winnerPlayer = parse[0].Name;
            var winnerCategory = "all of a kind";
            var winnerPoint = parse[0].Dices.First().Output;
            return $"{winnerPlayer} win. - with {winnerCategory}: {winnerPoint}";
        }
    }
}
