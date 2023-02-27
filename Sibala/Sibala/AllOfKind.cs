using System.Collections.Generic;
using System.Linq;

namespace Sibala
{
    public class AllOfKind
    {
        public AllOfKind(Player player1, Player player2)
        {
            var player1Point = player1.Dices.First().Value;
            var player2Point = player2.Dices.First().Value;

            var pointOrder = new List<int> { 2, 3, 5, 6, 4, 1 };
            var comparePoint = pointOrder.IndexOf(player1Point) > pointOrder.IndexOf(player2Point);
            Player = comparePoint ? player1.Name : player2.Name;
            Point = comparePoint ? player1Point : player2Point;
        }

        public string Category => "all of a kind";

        public int Point { get; private set; }
        public string Player { get; private set; }
    }
}