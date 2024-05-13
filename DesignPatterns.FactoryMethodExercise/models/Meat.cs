using DesignPatterns.FactoryMethodExercise.enums;
using System.Diagnostics;
using System.Xml.Linq;

namespace DesignPatterns.FactoryMethodExercise.models
{
    internal class Meat(FoodEnum foodType, string name, decimal price, DateOnly expirationDate) : Food(name, price, expirationDate)
    {
        public FoodEnum FoodType { get; set; } = foodType;

        public override string Info()
            => $"Food Type: {FoodType}, {base.Info()}";
    }
}
