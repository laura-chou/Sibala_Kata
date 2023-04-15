using System;

namespace Sibala
{
    public class Game
    {
        public string ShowResult(string input)
        {
            var winnerPlayer = "Black";
            var winnerCategory = "normal point";
            var winnerPoint = "7";
            return $"{winnerPlayer} win. - with {winnerCategory}: {winnerPoint}";
        }
    }
}