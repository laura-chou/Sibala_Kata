using System.Linq;

namespace Sibala.src.Categories
{
    internal class NormalPoint : Category
    {
        public NormalPoint(Dices dices)
        {
            Output = dices.CalculateNormalPointDices()
                .Sum(dice => dice.Value)
                .ToString();
        }

        public override string Name => "normal point";

        public override string Output { get; }

        public override CategoryType Type => CategoryType.NormalPoint;
    }
}