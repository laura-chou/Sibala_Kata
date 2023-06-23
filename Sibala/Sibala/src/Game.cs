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

            var player1Dices = parse[0].Dices.First();
            var player2Dices = parse[1].Dices.First();

            var winnerPlayer = player1Dices.Value > player2Dices.Value ? parse[0].Name : parse[1].Name;
            var winnerCategory = "all of a kind";
            var winnerPoint = player1Dices.Value > player2Dices.Value ?  player1Dices.Output : player2Dices.Output;
            return $"{winnerPlayer} win. - with {winnerCategory}: {winnerPoint}";
        }
    }
}
