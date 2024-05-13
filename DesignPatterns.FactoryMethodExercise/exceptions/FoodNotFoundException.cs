using DesignPatterns.FactoryMethodExercise.enums;

namespace DesignPatterns.FactoryMethodExercise.exceptions
{
    internal class FoodNotFoundException(FoodEnum type) : Exception
    {
        public FoodEnum FoodType { get; } = type;

        public override string Message => $"Food of this type [{FoodType}] not found";
    }
}
