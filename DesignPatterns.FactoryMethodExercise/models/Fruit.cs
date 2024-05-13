using DesignPatterns.FactoryMethodExercise.enums;

namespace DesignPatterns.FactoryMethodExercise.models
{
    internal class Fruit(FoodEnum foodType, string name, decimal price, DateOnly expirationDate) : Food(name, price, expirationDate)
    {
        public FoodEnum FoodType { get; set; } = foodType;

        public override string Info()
            => $"Food Type: {FoodType}, {base.Info()}";
    }
}
